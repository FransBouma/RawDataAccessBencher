/////////////////////////////////////////////////////////////
// LLBLGen Pro ORM Support Classes Library
// (c) 2002-2003 Solutions Design. All rights reserved.
// http://www.llblgen.com
// http://www.sd.nl/llblgen
// 
// THIS IS NOT OPEN SOURCE SOFTWARE OF ANY KIND.
// SOURCECODE DISTRIBUTION IS NOT ALLOWED IN ANY WAY.
/////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Reflection;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// General Entity Base class, which is used to inherit the Entity classes from.
	/// </summary>
	[Serializable]
	public abstract class EntityBase : IEntity, ITransactionalElement, ISerializable
	{
		#region Class Member Declarations
			private IEntityFields		_fields;
			private Hashtable			_relatedEntitySyncInfos;		// EntitySyncInfo objects stored in an Hashtable per ObjectID
			private Hashtable			_field2RelatedEntity;			// Fieldname (mapped on relation) - ObjectID combinations. Used to find back entries in _relatedEntitySyncInfos
			private bool				_isNew, _isAlreadyRefetching, _isDeleted, _backupIsNew, _backupIsDeleted, _editCycleInProgress;
			private IValidator			_validator;
			private IEntityFactory		_entityFactoryToUse;
			private IConcurrencyPredicateFactory	_concurrencyPredicateFactoryToUse;
			private IEntityValidator	_entityValidatorToUse;

			[NonSerialized]
			private IEntityFields		 _backupFields;
			[NonSerialized]
			private bool				_pendingChangedEvent;
			[NonSerialized]
			private	ITransaction		_containingTransaction;
			[NonSerialized]
			private IEntityCollection	_parentCollection;		// databinding related
			[NonSerialized]
			private	bool				_isNewViaDataBinding;	// databinding related
			[NonSerialized]
			private Guid				_objectID;				// non serialized, because of backwards compatibility.
			[NonSerialized]
			private	bool				_isDeserializing;
			[NonSerialized]
			private	bool				_isSerializing;
		#endregion

		#region Event Handler Declarations
		/// <summary>
		/// Event handler declaration for the event that is fired each time the one of values of this entity are changed.
		/// The event does not contain the value / field which is changed, it only signals subscribers the entity is changed
		/// and the subscriber should act accordingly, f.e. fire a ListChanged event.
		/// </summary>
		public event EventHandler EntityContentsChanged;

		/// <summary>
		/// Event handler declaration for the event that is fired each time this entity is persisted. Related entities can subscribe to
		/// this event to start housekeeping actions, like syncing internal FK fields with the PK fields of this entity.
		/// </summary>
		public event EventHandler AfterSave;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public EntityBase()
		{
			InitClass();
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EntityBase(SerializationInfo info, StreamingContext context)
		{
			try
			{
				_isDeserializing = true;

				_fields = (IEntityFields)info.GetValue("_fields", typeof(IEntityFields));
				_backupFields = null;
				_containingTransaction = null;
				_isAlreadyRefetching = info.GetBoolean("_isAlreadyRefetching");
				_isNew = info.GetBoolean("_isNew");
				_backupIsDeleted = false;
				_isDeleted = info.GetBoolean("_isDeleted");
				_backupIsNew = false;
				_validator = (IValidator)info.GetValue("_validator", typeof(IValidator));
				_editCycleInProgress = false;
				_entityFactoryToUse = (IEntityFactory)info.GetValue("_entityFactoryToUse", typeof(IEntityFactory));
				_parentCollection=null;
				_isNewViaDataBinding=false;
				_pendingChangedEvent = false;
				_objectID = Guid.NewGuid();
				_relatedEntitySyncInfos = (Hashtable)info.GetValue("_relatedEntitySyncInfos", typeof(Hashtable));
				_field2RelatedEntity = (Hashtable)info.GetValue("_field2RelatedEntity", typeof(Hashtable));
				_concurrencyPredicateFactoryToUse = (IConcurrencyPredicateFactory)info.GetValue("_concurrencyPredicateFactoryToUse", typeof(IConcurrencyPredicateFactory));
				_entityValidatorToUse = (IEntityValidator)info.GetValue("_entityValidatorToUse", typeof(IEntityValidator));
			}
			finally
			{
				_isDeserializing = false;
			}
		}


		/// <summary>
		/// Method which will fire the AfterSave event to signal that this entity is persisted and refetched succesfully.
		/// </summary>
		public void FlagAsSaved()
		{
			if(AfterSave!=null)
			{
				// fire the AfterSave event.
				AfterSave(this, new EventArgs());
			}
		}


		/// <summary>
		/// Converts the EntityFields inside this entity into an EntityFields node with inner nodes for each field.
		/// </summary>
		/// <returns>XmlNode containing the EntityFields in xml format</returns>
		public virtual XmlNode ToXml()
		{
			// empty
			return null;
		}


		/// <summary>
		/// Converts this entity to XML, recursively. 
		/// </summary>
		/// <param name="entityXml">The complete outer XML as string, representing this complete entity object, including containing data.</param>
		public void WriteXml(out string entityXml)
		{
			WriteXml("Entity", out entityXml);
		}


		/// <summary>
		/// Converts this entity to XML, recursively. Uses the LLBLGenProEntityName for the rootnode name
		/// </summary>
		/// <param name="parentDocument">the XmlDocument which will contain the node this method will create. This document is required
		/// to create the new node object</param>
		/// <param name="entityNode">The XmlNode representing this complete entity object, including containing data.</param>
		public void WriteXml(XmlDocument parentDocument, out XmlNode entityNode)
		{
			WriteXml("Entity", parentDocument, out entityNode);
		}


		/// <summary>
		/// Converts this entity to XML, recursively. 
		/// </summary>
		/// <param name="rootNodeName">name of root element to use when building a complete XML representation of this entity.</param>
		/// <param name="entityXml">The complete outer XML as string, representing this complete entity object, including containing data.</param>
		public void WriteXml(string rootNodeName, out string entityXml)
		{
			XmlNode entityNode = null;
			WriteXml(rootNodeName, new XmlDocument(), out entityNode);
			entityXml = entityNode.OuterXml;
		}


		/// <summary>
		/// Converts this entity to XML, recursively. 
		/// </summary>
		/// <param name="rootNodeName">name of root element to use when building a complete XML representation of this entity.</param>
		/// <param name="parentDocument">the XmlDocument which will contain the node this method will create. This document is required
		/// to create the new node object</param>
		/// <param name="entityNode">The XmlNode representing this complete entity object, including containing data.</param>
		public virtual void WriteXml(string rootNodeName, XmlDocument parentDocument, out XmlNode entityNode)
		{
			Entity2Xml(rootNodeName, parentDocument, new Hashtable(), out entityNode);
		}


		/// <summary>
		/// Produces the actual XML for this entity, recursively. Because it recurses through referenced entities, it keeps track of which objects are processed
		/// so cyclic references are not resulting in cyclic recursion and thus a crash. 
		/// </summary>
		/// <param name="rootNodeName">name of root element to use when building a complete XML representation of this entity.</param>
		/// <param name="parentDocument">the XmlDocument which will contain the node this method will create. This document is required
		/// to create the new node object</param>
		/// <param name="processedObjectIDs">Hashtable with ObjectIDs of all the objects already processed. If this entity's ObjectID is in the
		/// hashtable's key list, a ProcessedObjectReference tag is emitted and the routine simply returns. </param>
		/// <param name="entityNode">The XmlNode representing this complete entity object, including containing data.</param>
		internal void Entity2Xml(string rootNodeName, XmlDocument parentDocument, Hashtable processedObjectIDs, out XmlNode entityNode)
		{
			XmlHelper nodeCreator = new XmlHelper();

			if(processedObjectIDs.ContainsKey(_objectID))
			{
				// already processed. Simply create a ProcessedObjectReference with the ObjectID and return.
				entityNode = parentDocument.CreateNode(XmlNodeType.Element, "ProcessedObjectReference", "");
				nodeCreator.AddAttribute(entityNode, "ObjectID", _objectID.ToString());

				// done.
				return;
			}

			entityNode = parentDocument.CreateNode(XmlNodeType.Element, rootNodeName, "");
			
			// add ourselves to the processedObjectIDs
			processedObjectIDs.Add(_objectID, null);

			// add PK fields as attributes.
			for(int i=0;i<_fields.PrimaryKeyFields.Count;i++)
			{
				IEntityField primaryKeyField = (IEntityField)(_fields.PrimaryKeyFields[i]);
				nodeCreator.AddAttribute(entityNode, primaryKeyField.Name, primaryKeyField.CurrentValue.ToString());
			}

			// add assembly as attribute
			nodeCreator.AddAttribute(entityNode, "Assembly", this.GetType().Assembly.FullName);
			nodeCreator.AddAttribute(entityNode, "Type", this.GetType().FullName);

			// create hashtable with names of all fields inside this entity
			Hashtable fieldNames = new Hashtable(_fields.Count);
			for (int i = 0; i < _fields.Count; i++)
			{
				fieldNames.Add(_fields[i].Name, null);
			}

			// get properties of this IEntity2 implementing object
			_isSerializing=true;
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this);
			try
			{
				for (int i = 0; i < properties.Count; i++)
				{
					if(properties[i].Attributes.Contains(new XmlIgnoreAttribute()))
					{
						// ignore this property
						continue;
					}

					// check if this property is part of the Fields collection. If so, skip it, because it is handled by the Fields property
					if(fieldNames.ContainsKey(properties[i].Name))
					{
						// field, continue
						continue;
					}

					if(properties[i].PropertyType.IsInterface)
					{
						// check for Fields
						if(properties[i].PropertyType.Equals(typeof(IEntityFields)))
						{
							// .Fields property
							XmlNode entityFieldsNode = nodeCreator.AddNode(entityNode, "Fields");

							// add the fields
							_fields.WriteXml(parentDocument, entityFieldsNode);
							// done with this property
							continue;
						}

						// check for EntityFactory
						if(properties[i].PropertyType.Equals(typeof(IEntityFactory)))
						{
							// .EntityFactoryToUse property
							XmlNode entityFactoryNode = nodeCreator.AddNode(entityNode, "EntityFactoryToUse");

							IEntityFactory entityFactory = properties[i].GetValue(this) as IEntityFactory;
							if(entityFactory==null)
							{
								nodeCreator.AddAttribute(entityFactoryNode, "Assembly", "Unknown");
							}
							else
							{
								nodeCreator.AddAttribute(entityFactoryNode, "Assembly", entityFactory.GetType().Assembly.FullName);
								nodeCreator.AddAttribute(entityFactoryNode, "Type", entityFactory.GetType().FullName);
							}
							// done with this property
							continue;
						}

						// check for Validator
						if(properties[i].PropertyType.Equals(typeof(IValidator)))
						{
							// .Validator property
							XmlNode validatorNode = nodeCreator.AddNode(entityNode, "Validator");
							IValidator validator = properties[i].GetValue(this) as IValidator;
							if(validator==null)
							{
								nodeCreator.AddAttribute(validatorNode, "Assembly", "Unknown");
							}
							else
							{
								nodeCreator.AddAttribute(validatorNode, "Assembly", validator.GetType().Assembly.FullName);
								nodeCreator.AddAttribute(validatorNode, "Type", validator.GetType().FullName);
							}
							// done with this property
							continue;
						}

						// check for EntityValidator
						if(properties[i].PropertyType.Equals(typeof(IEntityValidator)))
						{
							// .EntityValidator property
							XmlNode entityValidatorNode = nodeCreator.AddNode(entityNode, "EntityValidator");
							IEntityValidator entityValidator = properties[i].GetValue(this) as IEntityValidator;
							if(entityValidator==null)
							{
								nodeCreator.AddAttribute(entityValidatorNode, "Assembly", "Unknown");
							}
							else
							{
								nodeCreator.AddAttribute(entityValidatorNode, "Assembly", entityValidator.GetType().Assembly.FullName);
								nodeCreator.AddAttribute(entityValidatorNode, "Type", entityValidator.GetType().FullName);
							}
							// done with this property
							continue;
						}

						// check for ConcurrencyPredicateFactory
						if(properties[i].PropertyType.Equals(typeof(IConcurrencyPredicateFactory)))
						{
							// .ConcurrencyPredicateFactory property
							XmlNode concurrencyPredicateFactoryNode = nodeCreator.AddNode(entityNode, "ConcurrencyPredicateFactory");
							IConcurrencyPredicateFactory factory = properties[i].GetValue(this) as IConcurrencyPredicateFactory;
							if(factory==null)
							{
								nodeCreator.AddAttribute(concurrencyPredicateFactoryNode, "Assembly", "Unknown");
							}
							else
							{
								nodeCreator.AddAttribute(concurrencyPredicateFactoryNode, "Assembly", factory.GetType().Assembly.FullName);
								nodeCreator.AddAttribute(concurrencyPredicateFactoryNode, "Type", factory.GetType().FullName);
							}
							// done with this property
							continue;
						}
					}

					// get all interfaces of the type of this property
					Type[] propertyInterfaces = properties[i].PropertyType.GetInterfaces();

					bool propertyHandled = false;
					for(int j=0;j<propertyInterfaces.Length;j++)
					{
						// Use waterfall method, check using Equals.
						if(propertyInterfaces[j].Equals(typeof(IEntity)))
						{
							// a related Entity property which references an entity related to this entity. 
							XmlNode propertyNode = nodeCreator.AddNode(entityNode, "EntityReference");
							nodeCreator.AddAttribute(propertyNode, "PropertyName", properties[i].Name);

							XmlNode refEntityNode = null;
							EntityBase referencedEntity = properties[i].GetValue(this) as EntityBase;
							if(referencedEntity!=null)
							{
								referencedEntity.Entity2Xml("Entity", parentDocument, processedObjectIDs, out refEntityNode);
								propertyNode.AppendChild(refEntityNode);
							}

							propertyHandled = true;
							break;
						}

						if(propertyInterfaces[j].Equals(typeof(IEntityCollection)))
						{
							// a related entity collection property which references an EntityCollectionBase2 derived class with entities related to this entity.
							XmlNode propertyNode = nodeCreator.AddNode(entityNode, "EntityCollectionReference");
							nodeCreator.AddAttribute(propertyNode, "PropertyName", properties[i].Name);
							
							XmlNode refEntityCollectionNode = null;
							EntityCollectionBase referencedEntityCollection = properties[i].GetValue(this) as EntityCollectionBase;
							if(referencedEntityCollection!=null)
							{
								referencedEntityCollection.EntityCollection2Xml(properties[i].Name, parentDocument, processedObjectIDs, out refEntityCollectionNode);
								propertyNode.AppendChild(refEntityCollectionNode);
							}

							propertyHandled = true;
							break;
						}
					}

					if(propertyHandled)
					{
						continue;
					}

					// Normal not yet handled property. Add it.
					XmlNode childNode = nodeCreator.AddNode(entityNode, properties[i].Name);
					string valueTypeName = properties[i].PropertyType.UnderlyingSystemType.FullName.ToString();
					nodeCreator.AddAttribute(childNode, "Type", valueTypeName);

					string valueAsString = String.Empty;
					switch(valueTypeName)
					{
						case "System.String":
						case "System.Byte":
						case "System.Int32":
						case "System.Int16":
						case "System.Int64":
						case "System.Decimal":
						case "System.Double":
						case "System.Single":
						case "System.Boolean":
						case "System.Guid":
							valueAsString = properties[i].GetValue(this).ToString();
							break;
						case "System.DateTime":
							valueAsString = ((DateTime)properties[i].GetValue(this)).Ticks.ToString();
							break;
						case "System.Byte[]":
							// special case, base64encode it
							valueAsString = Convert.ToBase64String((byte[])properties[i].GetValue(this));
							break;
						default:
							object value = properties[i].GetValue(this);
							if(value!=null)
							{
								valueAsString = value.ToString();
							}
							else
							{
								valueAsString = "";
							}
							break;
					}
					childNode.AppendChild(parentDocument.CreateTextNode(valueAsString));
				}

				// add info nodes
				XmlNode isDirtyNode = nodeCreator.AddNode(entityNode, "IsDirty", _fields.IsDirty.ToString());
				nodeCreator.AddAttribute(isDirtyNode, "Type", "System.Boolean");

				XmlNode entityStateNode = nodeCreator.AddNode(entityNode, "EntityState", _fields.State.ToString());
				nodeCreator.AddAttribute(entityStateNode, "Type", _fields.State.GetType().FullName.ToString());
			}
			finally
			{
				_isSerializing=false;
			}
		}


		/// <summary>
		/// Will fill the entity and its containing members (recursively) with the data stored in the Xml string passed in. The string xmlData has to
		/// be filled with Xml in the format written by IEntity.WriteXml() and the Xml has to be compatible with the structure of this entity.
		/// </summary>
		/// <param name="xmlData">string with Xml data which should be read into this entity and its members. This string has to be in the
		/// correct format and should be loadable into a new XmlDocument without problems</param>
		public void ReadXml(string xmlData)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xmlData);
			ReadXml(doc.DocumentElement);
		}


		/// <summary>
		/// Will fill the entity and its containing members (recursively) with the data stored in the XmlNode passed in. The XmlNode has to
		/// be filled with Xml in the format written by IEntity.WriteXml() and the Xml has to be compatible with the structure of this entity.
		/// </summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element
		/// of the entity's Xml data</param>
		public virtual void ReadXml(XmlNode node)
		{
			ArrayList nodeEntityReferences = new ArrayList();
			Hashtable processedObjectIDs = new Hashtable();
			Xml2Entity(node, processedObjectIDs, nodeEntityReferences);

			// walk all references found and set them to the correct objects.
			XmlHelper.SetReadReferencesSS(nodeEntityReferences, processedObjectIDs);
		}


		/// <summary>
		/// Performs the actual conversion from Xml to entity data. 
		/// </summary>
		/// <param name="node">current node which points to an entity node.</param>
		/// <param name="processedObjectIDs">ObjectID's of all entities instantiated</param>
		/// <param name="nodeEntityReferences">Arraylist with all the references to entity objects we probably do not yet have instantiated. This list
		/// is traversed after the xml tree has been processed. (not done by this routine, but by the caller)</param>
		internal void Xml2Entity(XmlNode node, Hashtable processedObjectIDs, ArrayList nodeEntityReferences)
		{
			try
			{
				_isDeserializing = true;
				XmlHelper typeConverter = new XmlHelper();

				// get this instance's properties.
				PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this);

				// first walk the subnodes and process only the direct childs, skipping entity collections and entity references.
				foreach(XmlNode currentElement in node.ChildNodes)
				{
					switch(currentElement.Name)
					{
							// filter out special cases, the rest is handled by the default section.
						case "EntityCollectionReference":
							// create a new instance.
							XmlNode entityCollectionNode = currentElement.FirstChild;
							// get a reference to the collection object.
							EntityCollectionBase referencedEntityCollection = (EntityCollectionBase)properties[currentElement.Attributes["PropertyName"].Value].GetValue(this);
							referencedEntityCollection.Xml2EntityCollection(entityCollectionNode, processedObjectIDs, nodeEntityReferences);
							break;
						case "EntityReference":
							// first test if this node is empty
							if(currentElement.ChildNodes.Count<=0)
							{
								// is empty
								continue;
							}

							// if this node contains an entity reference, add a new entity reference to the arraylist. If it contains
							// a full object in Xml, deserialize that object.
							// find 'ProcessedObjectReference' subnode, if present.
							XmlNode referenceNode = currentElement.SelectSingleNode("ProcessedObjectReference");
							if(referenceNode!=null)
							{
								// reference node found. Add reference.
								NodeEntityReference newReference = new NodeEntityReference();
								newReference.ObjectID = new Guid(referenceNode.Attributes["ObjectID"].Value);
								newReference.PropertyHoldingInstance = this;
								newReference.IsCollectionAdd=false;
								newReference.ReferencingProperty = properties[currentElement.Attributes["PropertyName"].Value];
								nodeEntityReferences.Add(newReference);
								// done with this node.
								continue;
							}
							// not a reference, instantiate the full node if a full node is present
							XmlNode entityNode = currentElement.FirstChild;

							// get type and assembly for entity instance.
							string entityAssemblyName = entityNode.Attributes["Assembly"].Value;
							string entityTypeName = entityNode.Attributes["Type"].Value;
							// load assembly
							Assembly entityAssembly = Assembly.Load(entityAssemblyName);
							// create instance
							EntityBase referencedEntity = (EntityBase)entityAssembly.CreateInstance(entityTypeName);
							referencedEntity.IsDeserializing=true;
							try
							{
								// convert this entity's xml into data inside this entity
								referencedEntity.Xml2Entity(entityNode, processedObjectIDs, nodeEntityReferences);
								properties[currentElement.Attributes["PropertyName"].Value].SetValue(this, referencedEntity);
							}
							finally
							{
								referencedEntity.IsDeserializing=false;
							}
							break;
						case "Validator":
							string validatorAssemblyName = currentElement.Attributes["Assembly"].Value;
							if(validatorAssemblyName=="Unknown")
							{
								// no validator set nor serialized
								continue;
							}
							Assembly validatorAssembly = Assembly.Load(validatorAssemblyName);
							string validatorClassType = currentElement.Attributes["Type"].Value;
							this.Validator = (IValidator)validatorAssembly.CreateInstance(validatorClassType);
							break;
						case "EntityValidator":
							string entityValidatorAssemblyName = currentElement.Attributes["Assembly"].Value;
							if(entityValidatorAssemblyName=="Unknown")
							{
								// no entity validator set nor serialized
								continue;
							}
							Assembly entityValidatorAssembly = Assembly.Load(entityValidatorAssemblyName);
							string entityValidatorClassType = currentElement.Attributes["Type"].Value;
							this.EntityValidatorToUse = (IEntityValidator)entityValidatorAssembly.CreateInstance(entityValidatorClassType);
							break;
						case "ConcurrencyPredicateFactory":
							string cpFactoryAssemblyName = currentElement.Attributes["Assembly"].Value;
							if(cpFactoryAssemblyName=="Unknown")
							{
								// no factory object set nor serialized
								continue;
							}
							Assembly cpFactoryAssembly = Assembly.Load(cpFactoryAssemblyName);
							string cpFactoryClassType = currentElement.Attributes["Type"].Value;
							this.ConcurrencyPredicateFactoryToUse = (IConcurrencyPredicateFactory)cpFactoryAssembly.CreateInstance(cpFactoryClassType);
							break;
						case "Fields":
							// get all child nodes, 1 node per field
							XmlNodeList fieldNodes = currentElement.ChildNodes;
							for (int i = 0; i < fieldNodes.Count; i++)
							{
								XmlNode currentValueNode = fieldNodes[i].SelectSingleNode("CurrentValue");
								string currentValueTypeName = currentValueNode.Attributes["Type"].Value;
								string currentValueAsString = currentValueNode.InnerText;
								this.Fields[fieldNodes[i].Name].ForcedCurrentValueWrite(typeConverter.XmlValueToObject(currentValueTypeName, currentValueAsString));
								XmlNode isNullNode = fieldNodes[i].SelectSingleNode("IsNull");
								this.Fields[fieldNodes[i].Name].IsNull = (bool)typeConverter.XmlValueToObject("System.Boolean", isNullNode.InnerText);
								XmlNode isChangedNode = fieldNodes[i].SelectSingleNode("IsChanged");
								((EntityField)this.Fields[fieldNodes[i].Name]).ForcedChangedWrite((bool)typeConverter.XmlValueToObject("System.Boolean", isChangedNode.InnerText));
							}
							break;
						case "IsDirty":
							this.Fields.IsDirty = Convert.ToBoolean(currentElement.InnerText);
							break;
						case "EntityState":
							string entityState = currentElement.InnerText;
						switch(entityState)
						{
							case "Deleted":
								this.Fields.State = EntityState.Deleted;
								break;
							case "Fetched":
								this.Fields.State = EntityState.Deleted;
								break;
							case "New":
								this.Fields.State = EntityState.New;
								break;
							case "OutOfSync":
								this.Fields.State = EntityState.OutOfSync;
								break;
						}
							break;
						default:
							// custom property, not a field.
							string elementTypeName = currentElement.Attributes["Type"].Value;
							string xmlValue = currentElement.InnerText;
							properties[currentElement.Name].SetValue(this, typeConverter.XmlValueToObject(elementTypeName, xmlValue));
							break;
					}
				}

				// add the ObjectID of this object, which is now read from XML, to the hashtable
				processedObjectIDs.Add(_objectID, this);
			}
			finally
			{
				_isDeserializing = false;
			}
		}


		/// <summary>
		/// Overrides the GetHashCode routine. It will calculate a hashcode for this entity using the eXclusive OR of the 
		/// hashcodes of the primary key fields in this entity. That hashcode is returned. If no primary key fields are present,
		/// the hashcode of the base class is returned, which will not be unique.
		/// </summary>
		/// <returns>Hashcode for this entity object, based on its primary key field values</returns>
		public override int GetHashCode()
		{
			return ((EntityFields)_fields).GetHashCode();
		}


		/// <summary>
		/// Validates the entity by calling a set IEntityValidator implementing object's Validate() method. If no IEntityValidator object is set
		/// true is returned.
		/// </summary>
		/// <returns>The result of IEntityValidator.Validate(this).</returns>
		/// <remarks>Called by save logic.</remarks>
		/// <exception cref="ORMEntityValidationException">If validation fails</exception>
		public bool Validate()
		{
			if(_entityValidatorToUse!=null)
			{
				return _entityValidatorToUse.Validate(this);
			}
			else
			{
				return true;
			}
		}


		/// <summary>
		/// Converts the EntityFields inside this entity into an EntityFields node with inner nodes for each field.
		/// </summary>
		/// <param name="rootNodeName">name of root element to use when building a complete XML representation of this entity.</param>
		/// <returns>a complete xml representation for this entity</returns>
		protected virtual XmlNode ToXml(string rootNodeName)
		{
			XmlDocument xmlDOM = new XmlDocument();

			// add root node
			XmlNode rootNode = xmlDOM.CreateNode(XmlNodeType.Element, rootNodeName, "");

			// add PK fields as attributes.
			for(int i=0;i<_fields.PrimaryKeyFields.Count;i++)
			{
				IEntityField primaryKeyField = (IEntityField)(_fields.PrimaryKeyFields[i]);

				XmlAttribute attributeToAdd = xmlDOM.CreateAttribute(primaryKeyField.Name);
				attributeToAdd.Value = primaryKeyField.CurrentValue.ToString();
				rootNode.Attributes.Append(attributeToAdd);
			}

			// append fields node
			XmlNode entityFieldsNode = xmlDOM.CreateNode(XmlNodeType.Element, "Fields", "");
			rootNode.AppendChild(entityFieldsNode);

			for(int i=0;i<_fields.Count;i++)
			{
				EntityField field = (EntityField)_fields[i];
				XmlNode fieldNode = xmlDOM.CreateNode(XmlNodeType.Element, field.Name,"");
				XmlNode fieldNodeContents = xmlDOM.ImportNode(field.ToXml(), true);
				fieldNode.AppendChild(fieldNodeContents);
				entityFieldsNode.AppendChild(fieldNode);
			}

			// add info nodes
			XmlNode isDirtyNode = xmlDOM.CreateNode(XmlNodeType.Element, "IsDirty", "");
			isDirtyNode.AppendChild(xmlDOM.CreateTextNode(_fields.IsDirty.ToString()));
			rootNode.AppendChild(isDirtyNode);

			XmlNode isDeletedNode = xmlDOM.CreateNode(XmlNodeType.Element, "IsDeleted", "");
			isDeletedNode.AppendChild(xmlDOM.CreateTextNode(_isDeleted.ToString()));
			rootNode.AppendChild(isDeletedNode);

			// return root node.
			return rootNode;
		}


		/// <summary>
		/// Routine which will flag all subscribers of the EntityContentsChanged event that this entity's contents is changed.
		/// </summary>
		public void FlagMeAsChanged()
		{
			if(EntityContentsChanged!=null)
			{
				EntityContentsChanged(this, new EventArgs());
			}
		}


		/// <summary>
		/// Will check if the entity should refetch itself. Will use the factory pattern trick.
		/// Refetching occurs when the EntityFields are marked OutOfSync and thus not dirty. 
		/// </summary>
		public void CheckForRefetch()
		{
			if(_fields==null)
			{
				// nothing to refetch
				return;
			}

			if(_isAlreadyRefetching || _fields.IsDirty)
			{
				// already refetching or is dirty. No can do. exit
				return;
			}

			if(_fields.State == EntityState.OutOfSync)
			{
				// refetch. 
				try
				{
					_isAlreadyRefetching = true;
					bool wasSuccesful = Refetch();
					if(wasSuccesful)
					{
						// refetch succeeded, update state
						_fields.State = EntityState.Fetched;
					}
				}
				// all exceptions are fatal
				finally
				{
					_isAlreadyRefetching = false;
				}
			}
		}


		/// <summary>
		/// Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. Will not recursively save internal dirty entities. 
		/// Uses, if applicable, the ConcurrencyPredicateFactory to supply the predicate to limit save activity.
		/// </summary>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public bool Save()
		{
			if(_fields == null)
			{
				// nothing to save
				return true;
			}

			if(!_fields.IsDirty)
			{
				// not changed
				return true;
			}

			return Save(GetConcurrencyPredicate(ConcurrencyPredicateType.Save), false);
		}


		/// <summary>
		/// Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. Uses, if applicable, the ConcurrencyPredicateFactory to supply the predicate to limit save activity.
		/// </summary>
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public bool Save(bool recurse)
		{
			if(_fields == null)
			{
				// nothing to save
				return true;
			}

			if(_fields.IsDirty || recurse)
			{
				return Save(GetConcurrencyPredicate(ConcurrencyPredicateType.Save), recurse);
			}
			else
			{
				// not changed
				return true;
			}
		}


		/// <summary>
		/// Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		/// predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		/// concurrency checks, like checks on timestamp column values. Will not recursively save internal dirty entities. 
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is
		/// new. Overrules an optional set ConcurrencyPredicateFactory.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public bool Save(IPredicate updateRestriction)
		{
			if(_fields == null)
			{
				// nothing to save
				return true;
			}

			if(!_fields.IsDirty)
			{
				// not changed
				return true;
			}

			return Save(updateRestriction, false);
		}


		/// <summary>
		/// Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		/// predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		/// concurrency checks, like checks on timestamp column values.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		/// new. Overrules an optional set ConcurrencyPredicateFactory.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <remarks>Do not call this routine directly, use the overloaded version in a derived class as this version doesn't construct a
		/// local transaction during recursive save, this is done in the overloaded version in a derived class.</remarks>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public virtual bool Save(IPredicate updateRestriction, bool recurse)
		{
			if(!(_fields.IsDirty || recurse))
			{
				// not changed, nothing to save
				return true;
			}

			// validate the entity first. If Validate fails, it should throw an exception, exiting the routine.
			Validate();

			ArrayList containedDependingEntities = null;
			ArrayList containedDependentEntities = null;
			ArrayList containedMemberCollections = null;

			if(recurse)
			{
				_containingTransaction.SaveInRecursionStarted();
				_containingTransaction.EntitiesInTransaction.Add(_objectID);

				containedDependingEntities = GetDependingRelatedEntities();
				containedDependentEntities = GetDependentRelatedEntities();
				containedMemberCollections = GetMemberEntityCollections();

				RemoveEntitiesAlreadyInTransaction(containedDependentEntities);

				// via recursion, save all dependent dirty entities FIRST.
				for (int i = 0; i < containedDependentEntities.Count; i++)
				{
					// recurse. Exceptions will bubble up and rollback the transaction started.
					EntityBase currentEntity = (EntityBase)containedDependentEntities[i];
					// add to this transaction.
					_containingTransaction.Add(currentEntity);
					((IEntity)currentEntity).Save(currentEntity.GetConcurrencyPredicate(ConcurrencyPredicateType.Save), true);
				}
			}

			// then try to save ourselves.
			try
			{
				// save the entity.
				bool wasSuccesful = false;

				if(_isNew)
				{
					wasSuccesful = InsertEntity();
				}
				else
				{
					if(updateRestriction==null)
					{
						wasSuccesful = UpdateEntity();
					}
					else
					{
						wasSuccesful = UpdateEntity(updateRestriction);
					}
				}

				if(wasSuccesful)
				{
					// succesful save, accept changes now. Mark entity as OutOfSync and not new
					_fields.State = EntityState.OutOfSync;
					_fields.AcceptChanges();
					_isNew = false;
					FlagAsSaved();
				}
				else
				{
					if(recurse)
					{
						// failed. throw exception
						throw new ORMConcurrencyException("During a recursive save action an entity's save action failed. The entity which failed is enclosed.", this);
					}
				}

				if(recurse)
				{
					RemoveEntitiesAlreadyInTransaction(containedDependingEntities);

					// save all depending entities
					for (int i = 0; i < containedDependingEntities.Count; i++)
					{
						// recurse. Exceptions will bubble up and rollback the transaction started.
						EntityBase currentEntity = (EntityBase)containedDependingEntities[i];
						// add to this transaction.
						_containingTransaction.Add(currentEntity);
						((IEntity)currentEntity).Save(currentEntity.GetConcurrencyPredicate(ConcurrencyPredicateType.Save), true);
					}

					// now save all contained entity collections.
					for (int i = 0; i < containedMemberCollections.Count; i++)
					{
						EntityCollectionBase currentCollection = (EntityCollectionBase)containedMemberCollections[i];
						_containingTransaction.Add(currentCollection);
						((IEntityCollection)currentCollection).SaveMulti(true);
					}

				}

				// done.
				return wasSuccesful;
			}
			catch(ORMConcurrencyException)
			{
				// rethrow the exception
				throw;
			}
			catch(ORMQueryExecutionException)
			{
				// retrow the exception.
				throw;
			}
			catch(Exception ex)
			{
				// encapsulate the exception in a new Application exception.
				throw new ApplicationException("Exception caught during save. See the contents of the InnerException property for details about this exception.", ex);
			}
			finally
			{
				if(recurse)
				{
					_containingTransaction.SaveInRecursionEnded();
				}
			}
		}


		/// <summary>
		/// Will reject (and thus roll back) all changes made to the entity's EntityFields. It rolls back to the initial version. 
		/// </summary>
		public void RejectChanges()
		{
			if(_fields!=null)
			{
				_fields.RejectChanges();
			}
		}


		/// <summary>
		/// When the <see cref="ITransaction"/> in which this IEntity participates is commited, this IEntity can succesfully finish actions performed by this
		/// IEntity. This method is called by <see cref="ITransaction"/>, you should not call it by yourself. When this IEntity doesn't participate in a
		/// transaction it finishes the actions itself, calling this method is not needed.
		/// </summary>
		public void TransactionCommit()
		{
			_isNew = false;
			_fields.AcceptChanges();
			_fields.State = EntityState.OutOfSync;
			_backupFields = null;
		}


		/// <summary>
		/// When the <see cref="ITransaction"/> in which this IEntity participates is rolled back, this IEntity has to roll back its internal variables.
		/// This method is called by <see cref="ITransaction"/>, you should not call it by yourself. 
		/// </summary>
		public void TransactionRollback()
		{
			_fields = _backupFields;
			_isDeleted = _backupIsDeleted;
			_isNew = _backupIsNew;
			_backupFields = null;
		}


		/// <summary>
		/// Compares passed in object with the given object. This is a compare of PK fields. These have to be the same in VALUES. 
		/// When the values are not the same, or the type is not the same as the current type, false is returned, true otherwise.
		/// When this doesn't have any PK fields, all fields are compared. null values are considered as the same value. 
		/// </summary>
		/// <param name="obj">IEntity implementing object of the same type as this which will be compared to the PK values of this. </param>
		/// <returns>True when the PK values of this are the same as the PK values of obj, or when this doesn't have any PK fields, all fields
		/// have the same value as obj's fields. False otherwise.</returns>
		/// <remarks>If this entity or the passed in entity is new, no values are compared, but the physical objects are compared (object.Equals()),
		/// because new entities can look the same, value wise due to identity fields which are all 0, however which are physical different entities 
		/// (object wise)</remarks>
		public override bool Equals(object obj)
		{
			IEntity passedIn = obj as IEntity;
			if(passedIn==null)
			{
				// not the same type, not identical.
				return false;
			}

			if((_fields==null)||(passedIn.Fields==null))
			{
				return false;
			}

			// new entities are always different. If one of the two (this, or passed in object) is new, they have to be tested using reference testing.
			// if that fails, they're not the same. New entities can't be compared using field values
			if(_isNew || passedIn.IsNew)
			{
				// one or both is new, use instance compare.
				return (this==passedIn);
			}

			return ((EntityFields)_fields).Equals(passedIn.Fields);
		}


		/// <summary>
		/// Deletes the Entity from the persistent storage. This method succeeds also when the Entity is not present.
		/// Uses, if applicable, the ConcurrencyPredicateFactory to supply the predicate to limit delete activity.
		/// </summary>
		/// <returns>true if Delete succeeded, false otherwise</returns>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the delete process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public bool Delete()
		{
			return Delete(GetConcurrencyPredicate(ConcurrencyPredicateType.Delete));
		}


		/// <summary>
		/// Deletes the Entity from the persistent storage. This method succeeds also when the Entity is not present.
		/// </summary>
		/// <param name="deleteRestriction">Predicate expression, meant for concurrency checks in a delete query. Overrules the predicate returned
		/// by a set ConcurrencyPredicateFactory object.</param>
		/// <returns>true if Delete succeeded, false otherwise</returns>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the delete process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public virtual bool Delete(IPredicate deleteRestriction)
		{
			_isDeleted = true;
			return true;
		}


		/// <summary>
		/// ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// </summary>
		/// <param name="info">See ISerializable</param>
		/// <param name="context">See ISerialilzable</param>
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_fields", _fields);
			info.AddValue("_isNew", _isNew);
			info.AddValue("_isAlreadyRefetching", _isAlreadyRefetching);
			info.AddValue("_isDeleted", _isDeleted);
			info.AddValue("_validator", _validator);
			info.AddValue("_entityFactoryToUse", _entityFactoryToUse);
			info.AddValue("_relatedEntitySyncInfos", _relatedEntitySyncInfos);
			info.AddValue("_field2RelatedEntity", _field2RelatedEntity);
			info.AddValue("_concurrencyPredicateFactoryToUse", _concurrencyPredicateFactoryToUse);
			info.AddValue("_entityValidatorToUse", _entityValidatorToUse);
		}


		/// <summary>
		/// Creates the requested predicate of the type specified. If no IConcurrencyPredicateFactory instance is stored in this entity instance, null
		/// is returned.
		/// </summary>
		/// <param name="predicateTypeToCreate">The type of predicate to create</param>
		/// <returns>A ready to use predicate to use in the query to execute, or null/Nothing if no IConcurrencyPredicateFactory instance is present, 
		/// in which case the predicate is ignored</returns>
		public virtual IPredicateExpression GetConcurrencyPredicate(ConcurrencyPredicateType predicateTypeToCreate)
		{
			if(_concurrencyPredicateFactoryToUse!=null)
			{
				return _concurrencyPredicateFactoryToUse.CreatePredicate(predicateTypeToCreate, this);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// Gets the current value of the EntityField with the index fieldIndex. Will refetch the complete entity's fields
		/// from the database if necessary (i.e. the entity is outofsync.).
		/// </summary>
		/// <param name="fieldIndex">Index of EntityField to get the current value of</param>
		/// <returns>The current value of the EntityField specified</returns>
		/// <exception cref="ORMEntityIsDeletedException">When the entity is marked as deleted.</exception>
		/// <exception cref="ArgumentOutOfRangeException">When fieldIndex is smaller than 0 or bigger than the amount of fields in the fields collection.</exception>
		public object GetCurrentFieldValue(int fieldIndex)
		{
			if(_isDeleted)
			{
				throw new ORMEntityIsDeletedException("This entity is deleted from the database and can't be used in logic.");
			}

			if((fieldIndex<0)||(fieldIndex>=_fields.Count))
			{
				throw new ArgumentOutOfRangeException("fieldIndex", fieldIndex, "The field index passed is not a valid index in the fields collection of this entity.");
			}

			CheckForRefetch();
			if(_fields!=null)
			{
				return _fields[fieldIndex].CurrentValue;
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// IEditableObject method. Used by databinding.
		/// A succesful edit has been performed. All new values have to be moved to the current value slots.
		/// </summary>
		public void EndEdit()
		{
			if(_fields!=null)
			{
				if(_editCycleInProgress)
				{
					_fields.EndEdit();
					_editCycleInProgress = false;

					if(_isNewViaDataBinding)
					{
						_isNewViaDataBinding=false;
					}

					// check if there is a changed event pending
					if(_pendingChangedEvent)
					{
						// yes. Mark it as changed
						FlagMeAsChanged();
						_pendingChangedEvent=false;
					}
				}
			}
		}


		/// <summary>
		/// IEditableObject method. Used by databinding.
		/// </summary>
		public void CancelEdit()
		{
			if(_fields!=null)
			{
				if(_editCycleInProgress)
				{
					_fields.CancelEdit();
					_editCycleInProgress = false;

					if(_isNewViaDataBinding)
					{
						// remove from parent
						_parentCollection.Remove(this);
					}

					// deny a change
					_pendingChangedEvent = false;
				}
			}
		}

		/// <summary>
		/// IEditableObject method. Used by databinding.
		/// </summary>
		public void BeginEdit()
		{
			if(_fields!=null)
			{
				if(!_editCycleInProgress)
				{
					_fields.BeginEdit();
					_editCycleInProgress = true;
				}
			}
		}


		/// <summary>
		/// Sets the EntityField with the name fieldName to the new value value. Marks also the entityfields as dirty. Will refetch the complete entity's fields
		/// from the database if necessary (i.e. the entity is outofsync.).
		/// </summary>
		/// <param name="fieldName">Name of EntityField to set the new value of</param>
		/// <param name="value">Value to set</param>
		/// <returns>true if the value is actually set, false otherwise.</returns>
		/// <exception cref="ORMValueTypeMismatchException">The value specified is not of the same IEntityField.DataType as the field.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The value specified has a size that is larger than the maximum size defined for the related column in the databas</exception>
		public  bool SetNewFieldValue(string fieldName, object value)
		{
			return SetNewFieldValue(_fields[fieldName].FieldIndex, value);
		}

		
		/// <summary>
		/// Sets the EntityField on index fieldIndex to the new value value. Marks also the entityfields as dirty. Will refetch the complete entity's fields
		/// from the database if necessary (i.e. the entity is outofsync.).
		/// </summary>
		/// <param name="fieldIndex">Index of EntityField to set the new value of</param>
		/// <param name="value">Value to set</param>
		/// <returns>true if the value is actually set, false otherwise.</returns>
		/// <exception cref="ORMValueTypeMismatchException">The value specified is not of the same IEntityField.DataType as the field.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The value specified has a size that is larger than the maximum size defined for the related column in the databas</exception>
		public  bool SetNewFieldValue(int fieldIndex, object value)
		{
			CheckForRefetch();
			bool valueIsSet = false;
			if(_fields!=null)
			{
				IEntityField fieldToSet = _fields[fieldIndex];
				if(ValidateValue(fieldToSet, value, fieldIndex))
				{
					if(_editCycleInProgress)
					{
						// do not control the editing of the field's value with the field's edit cycle routines.
						fieldToSet.CurrentValue = value;
						_fields.IsChangedInThisEditCycle = true;
						_fields.IsDirty=true;
						valueIsSet = true;
					}
					else
					{
						try
						{
							fieldToSet.BeginEdit();
							fieldToSet.CurrentValue = value;
							fieldToSet.EndEdit();
							_fields.IsDirty=true;
							valueIsSet = true;
						}
						catch
						{
							fieldToSet.CancelEdit();
							throw;
						}
					}
				}
			}

			if(valueIsSet)
			{
				if((!_editCycleInProgress)||(_editCycleInProgress && !_isNew)||(_editCycleInProgress && _parentCollection==null))
				{
					// fire the EntityContentsChanged event, if there are subscribers. 
					FlagMeAsChanged();
				}
				else
				{
					// edit cycle in progress, hold the signal till endedit is called
					_pendingChangedEvent = true;
				}
			}

			return valueIsSet;
		}


		/// <summary>
		/// Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect.
		/// </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		/// <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public abstract bool Refetch();

		/// <summary>
		/// Performs the insert action of a new Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected abstract bool InsertEntity();

		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected abstract bool UpdateEntity();

		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected abstract bool UpdateEntity(IPredicate updateRestriction);

		/// <summary>
		/// Sets the internal parameter related to the fieldname passed to the instance relatedEntity. 
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		public abstract void SetRelatedEntity(IEntity relatedEntity, string fieldName);
		
		/// <summary>
		/// Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() 
		/// </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		public abstract void UnsetRelatedEntity(IEntity relatedEntity, string fieldName);

		/// <summary>
		/// Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.
		/// </summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public abstract ArrayList GetDependingRelatedEntities();
		
		/// <summary>
		/// Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.
		/// </summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public abstract ArrayList GetDependentRelatedEntities();
		
		/// <summary>
		/// Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the Save logic to perform recursive saves. Only 1:n related collections are returned.
		/// </summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public abstract ArrayList GetMemberEntityCollections();

		/// <summary>
		/// Synchronizes the PK values of the dataSupplier with the related FK values of this entity. 
		/// </summary>
		/// <param name="relation">the entity relation object which defines the relation between the dataSupplier entity and this entity.</param>
		/// <param name="dataSupplier">the entity related to this entity and which has the PK values for one or more FK fields in this entity.</param>
		protected virtual void SyncFKFields(IEntityRelation relation, IEntity dataSupplier)
		{
			if(dataSupplier==null)
			{
				// nothing to sync
				return;
			}

			// walk the fields in the relation and store data from the dataSupplier into the fields of this entity.
			for (int i = 0; i < relation.AmountFields; i++)
			{
				if(! (_fields[relation.GetFKEntityFieldCore(i).Name].IsPrimaryKey && !_isNew) )
				{
					// we're syncing a field which is not a PK or a PK field and we're new
					string fkFieldName = relation.GetFKEntityFieldCore(i).Name;
					string pkFieldName = relation.GetPKEntityFieldCore(i).Name;
					bool setValue = true;
					if(_fields[fkFieldName].CurrentValue!=null)
					{
						setValue = !_fields[fkFieldName].CurrentValue.Equals(dataSupplier.Fields[pkFieldName].CurrentValue);
					}
					if(setValue)
					{
						_fields[fkFieldName].CurrentValue = dataSupplier.Fields[pkFieldName].CurrentValue;
						// set IsDirty flag
						_fields.IsDirty=true;
					}
				}
			}
		}


		/// <summary>
		/// Will retrieve all stored entity synchronization informatoin for the passed in entity. If no information is
		/// stored, an empty hashtable is returned. All sync info is stored by fieldname
		/// </summary>
		/// <param name="relatedEntity">related entity to retrieve the sync info for</param>
		/// <returns>Hashtable with the sync info, stored per fieldname, set for this entity</returns>
		protected virtual Hashtable GetEntitySyncInformation(IEntity relatedEntity)
		{
			if(_relatedEntitySyncInfos.ContainsKey(relatedEntity.ObjectID))
			{
				return (Hashtable)_relatedEntitySyncInfos[relatedEntity.ObjectID];
			}
			else
			{
				// not found.
				return new Hashtable();
			}
		}


		/// <summary>
		/// Will unset (remove) the passed in information as Entity sync information. If there is no sync information stored for the related entity
		/// after this info has been removed, the complete hashentry is removed.
		/// </summary>
		/// <param name="fieldName">Name of field of this entity mapped onto passed in relation</param>
		/// <param name="relatedEntity">related entity set as value for field with name fieldName</param>
		/// <param name="relation">EntityRelation object which is the relation between this entity and the passed in relatedEntity</param>
		protected virtual void UnsetEntitySyncInformation(string fieldName, IEntity relatedEntity, IEntityRelation relation)
		{
			Hashtable entitySyncInfos = null;

			if(!_field2RelatedEntity.ContainsKey(fieldName))
			{
				// no, nothing to unset
				return;
			}

			Guid setRelatedEntityObjectID = (Guid)_field2RelatedEntity[fieldName];

			if( setRelatedEntityObjectID == relatedEntity.ObjectID)
			{
				// this entity is set as the related entity. remove sync info
				entitySyncInfos = (Hashtable)_relatedEntitySyncInfos[setRelatedEntityObjectID];
				// remove the sync info for the field
				entitySyncInfos.Remove(fieldName);
				// remove fieldname - objectid
				_field2RelatedEntity.Remove(fieldName);
			}
		}


		/// <summary>
		/// Will set the passed in information as Entity sync information. If there is no sync information stored yet for the related entity
		/// then a new entry is created, otherwise it's info is added to the sync information of this entity, if it isn't already present.
		/// If there is already sync information for this field stored for another related entity, that information is removed.
		/// </summary>
		/// <param name="fieldName">Name of field of this entity mapped onto passed in relation</param>
		/// <param name="relatedEntity">related entity set as value for field with name fieldName</param>
		/// <param name="relation">EntityRelation object which is the relation between this entity and the passed in relatedEntity</param>
		protected virtual void SetEntitySyncInformation(string fieldName, IEntity relatedEntity, IEntityRelation relation)
		{
			Hashtable entitySyncInfos = null;

			// first check if there is already sync info for this fieldname
			if(_field2RelatedEntity.ContainsKey(fieldName))
			{
				// yes. Check if it's about the passed in entity
				Guid setRelatedEntityObjectID = (Guid)_field2RelatedEntity[fieldName];
				if(relatedEntity==null)
				{
					// no, remove the sync info for this entity for the field-relation combination
					entitySyncInfos = (Hashtable)_relatedEntitySyncInfos[setRelatedEntityObjectID];
					// remove the sync info for the field
					entitySyncInfos.Remove(fieldName);
					// remove fieldname - objectid
					_field2RelatedEntity.Remove(fieldName);
					// done
					return;
				}

				if( setRelatedEntityObjectID != relatedEntity.ObjectID)
				{
					// no, remove the sync info for this entity for the field-relation combination
					entitySyncInfos = (Hashtable)_relatedEntitySyncInfos[setRelatedEntityObjectID];
					// remove the sync info for the field
					entitySyncInfos.Remove(fieldName);
					// remove fieldname - objectid
					_field2RelatedEntity.Remove(fieldName);
					// continue with routine as normal. 
				}
				else
				{
					// already stored. simply return
					return;
				}
			}

			// check if there is already a bucket for sync infos for this entity
			if(_relatedEntitySyncInfos.ContainsKey(relatedEntity.ObjectID))
			{
				// yes.
				entitySyncInfos = (Hashtable)_relatedEntitySyncInfos[relatedEntity.ObjectID];
			}
			else
			{
				// no
				entitySyncInfos = new Hashtable();
				_relatedEntitySyncInfos.Add(relatedEntity.ObjectID, entitySyncInfos);
			}

			// there is no sync info for this field present, add the combi first
			_field2RelatedEntity.Add(fieldName, relatedEntity.ObjectID);

			// add sync info
			EntitySyncInfoSS newSyncInfo = new EntitySyncInfoSS();
			newSyncInfo.DataSupplyingEntity = relatedEntity;
			newSyncInfo.Relation = relation;
			entitySyncInfos.Add(fieldName, newSyncInfo);
		}


		/// <summary>
		/// Removes entities already in the transaction from the passed in list. This verify is done by comparing GUID
		/// values with the _containingTransaction.EntitiesInTransaction collection. 
		/// </summary>
		/// <param name="containedDirtyEntities">List of dirty entities which are possible targets to save. All entities
		/// already participating in this transaction are removed from this list, because this can cause circles in the recursion</param>
		private void RemoveEntitiesAlreadyInTransaction(ArrayList containedDirtyEntities)
		{
			if(_containingTransaction==null)
			{
				// no transaction going on, return
				return;
			}

			ArrayList entitiesToRemove = new ArrayList();
			for (int i = 0; i < containedDirtyEntities.Count; i++)
			{
				if(_containingTransaction.EntitiesInTransaction.Contains(((IEntity)containedDirtyEntities[i]).ObjectID))
				{
					// already in transaction
					entitiesToRemove.Add(containedDirtyEntities[i]);
				}
			}

			for (int i = 0; i < entitiesToRemove.Count; i++)
			{
				containedDirtyEntities.Remove(entitiesToRemove[i]);
			}
		}


		/// <summary>
		/// Validates the input variable if it is a valid value for the target table field related to the passed in EntityField fieldToValidate.
		/// Primary keys can't be updated when the entity isn't a new entity.
		/// </summary>
		/// <param name="fieldToValidate">EntityField which is the destination of the value to validate</param>
		/// <param name="value">Value to validate</param>
		/// <param name="fieldIndex">The index of ValueDestination in the EntityFields array.</param>
		/// <returns>true if the value is valid, false otherwise</returns>
		/// <exception cref="ORMValueTypeMismatchException">The value specified is not of the same IEntityField.DataType as ValueDestination field.</exception>
		/// <exception cref="ArgumentOutOfRangeException">The value specified has a size that is larger than the maximum size defined for the related column in the databas</exception>
		private bool ValidateValue(IEntityField fieldToValidate, object value, int fieldIndex)
		{
			// Primary key fields can't be updated when this entity isn't a new entity
			if(fieldToValidate.IsPrimaryKey && !_isNew)
			{
				// can't update a primary key
				throw new ORMFieldIsReadonlyException("The field '" + fieldToValidate.Name + "' is part of a Primary Key and can't be updated after it is created in the persistent storage.");
			}

			// first filter out NULL values which are specified for not nullable fields
			if(value==null)
			{
				return fieldToValidate.SourceColumnIsNullable;
			}

			Type typeOfValue = value.GetType();
			if((typeOfValue!=fieldToValidate.DataType)&&(fieldToValidate.DataType!=typeof(object)))
			{
				throw new ORMValueTypeMismatchException("The value " + value.ToString() + " is of type '" + typeOfValue.ToString() + "' while the field is of type '" + fieldToValidate.DataType.ToString() + "'");
			}

			// value can be valid. 
			// use if - then - else tree to check. This is faster than the stringbased compare of type names
			bool wasSuccesful = true;
			string exceptionMessage = "";
			if(fieldToValidate.DataType == typeof(System.String))
			{
				// check length
				string valueAsString = (string)value;
				wasSuccesful = ((valueAsString.Length >= 0) && (valueAsString.Length <= fieldToValidate.SourceColumnMaxLength));
				exceptionMessage = "The value specified will cause an overflow error in the database. Value length: " + valueAsString.Length +". Column max. length: " + fieldToValidate.SourceColumnMaxLength;
			}
			if(fieldToValidate.DataType == typeof(System.Byte[]))
			{
				// check size
				Byte[] valueAsByteArray = (Byte[])value;
				wasSuccesful = ((valueAsByteArray.Length >= 0) && (valueAsByteArray.Length <= fieldToValidate.SourceColumnMaxLength));
				exceptionMessage = "The value specified will cause an overflow error in the database. Value length: " + valueAsByteArray.Length +". Column max. length: " + fieldToValidate.SourceColumnMaxLength;
			}
			// all other types are not causing overflows, since these types are checked by the CLR.

			// If already not valid, throw exception.
			if(!wasSuccesful)
			{
				// throw exception
				throw new ArgumentOutOfRangeException(fieldToValidate.Name, exceptionMessage);
			}

			// perform custom validation. 
			return (wasSuccesful && ValidateValueCustom(fieldIndex, value));
		}


		/// <summary>
		/// Method which will validate, using custom code supplied this class, the field with index fieldIndex if it should accept
		/// the specified value. This routine is only called when standard checks already succeeded, so value isn't null, and value does match the
		/// destination column definition of the EntityField related to fieldIndex.
		/// </summary>
		/// <param name="fieldIndex">Index of field to validate</param>
		/// <param name="value">value to validate</param>
		/// <returns>True if the validation succeeded, false otherwise.</returns>
		private bool ValidateValueCustom(int fieldIndex, object value)
		{
			if(_validator!=null)
			{
				return _validator.Validate(fieldIndex, value);
			}
			else
			{
				return true;
			}
		}


		/// <summary>
		/// Called when this Entity is added to a transaction object. This routine make sure all data currently inside the entity can be
		/// recovered when the transaction is rolled back.
		/// </summary>
		private void TransactionStart()
		{
			// back up vital info
			_backupIsNew = _isNew;
			_backupIsDeleted = _isDeleted;

			// copy EntityFields, if present.
			if(_fields!=null)
			{
				// create copy of efsfields.
				_backupFields = (EntityFields)((EntityFields)_fields).Clone();
			}
		}


		/// <summary>
		/// Initializes the class' members
		/// </summary>
		private void InitClass()
		{
			_fields = null;
			_backupFields = null;
			_containingTransaction = null;
			_isAlreadyRefetching = false;
			_isNew = false;
			_backupIsDeleted = false;
			_isDeleted = false;
			_backupIsNew = false;
			_validator = null;
			_editCycleInProgress = false;
			_entityFactoryToUse = null;
			_parentCollection=null;
			_isNewViaDataBinding=false;
			_pendingChangedEvent = false;
			_objectID = Guid.NewGuid();
			_isSerializing = false;
			_isDeserializing = false;
			_relatedEntitySyncInfos = new Hashtable();
			_field2RelatedEntity = new Hashtable();
			_concurrencyPredicateFactoryToUse = null;
			_entityValidatorToUse = null;
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets / sets isAddedViaDataBinding. Databinding related.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[XmlIgnore]
		internal bool IsNewViaDataBinding
		{
			get
			{
				return _isNewViaDataBinding;
			}
			set
			{
				_isNewViaDataBinding = value;
			}
		}

		/// <summary>
		/// Gets / sets parentCollection. databinding related.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[XmlIgnore]
		internal IEntityCollection ParentCollection
		{
			get
			{
				return _parentCollection;
			}
			set
			{
				_parentCollection = value;
			}
		}


		/// <summary>
		/// The validator object used to validate values for fields. This is a custom validator called after the build-in validations succeed.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public IValidator Validator
		{
			get { return _validator; }
			set { _validator = value; }
		}

		
		/// <summary>
		/// The internal presentation of the data, which is an EntityFields object, which implements <see cref="IEntityFields"/>.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public virtual IEntityFields Fields
		{
			get { return _fields; }
			set 
			{ 
				if(value==null)
				{
					throw new ArgumentNullException("Fields", "Fields can't be set to null");
				}

				if(_fields != null)
				{
					if(value.Count != _fields.Count)
					{
						// different EntityFields object
						throw new ArgumentException("The EntityFields object specified has a different layout than expected");
					}
				}

				_fields = value; 
			}
		}

		/// <summary>
		/// Marker for the entity object if the object is new and should be inserted when saved (true) or read from the
		/// database (false).
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public virtual bool IsNew
		{
			get { return _isNew; }
			set { _isNew = value; }
		}

		/// <summary>
		/// The <see cref="ITransaction"/> this ITransactionalElement implementing object is participating in. Only valid if
		/// <see cref="ParticipatesInTransaction"/> is true. If set to null, the ITransactionalElement is no longer participating
		/// in a transaction.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[XmlIgnore]
		public virtual ITransaction Transaction
		{
			get
			{
				return _containingTransaction;
			}
			set
			{
				if((value!=null)&&(_containingTransaction!=null))
				{
					// already is in a transaction. Ignore
					return;
				}

				_containingTransaction = value;
				if((_containingTransaction!=null)&&(_fields!=null))
				{
					TransactionStart();
				}
			}
		}

		/// <summary>
		/// Flag to check if the ITransactionalElement implementing object is participating in a transaction or not.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[XmlIgnore]
		public virtual bool ParticipatesInTransaction
		{
			get
			{
				return (_containingTransaction!=null);
			}
		}

		/// <summary>
		/// The EntityFactory to use when creating entity objects during a GetMulti() call.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public IEntityFactory EntityFactoryToUse 
		{
			get { return _entityFactoryToUse; }
			set { _entityFactoryToUse = value;}
		}

		/// <summary>
		/// Gets / sets the unique Object ID which is created at runtime when the entity is instantiated. Can be used for external caches.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public virtual Guid ObjectID 
		{
			get {return _objectID;}
			set {_objectID = value;}
		}

		/// <summary>
		/// Returns true if this entity instance is in the middle of a deserialization process, for example during a ReadXml() call.
		/// For internal use only. 
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[XmlIgnore]
		public bool IsDeserializing 
		{
			get { return _isDeserializing; }
			set { _isDeserializing=value;}
		}

		/// <summary>
		/// Returns true if this entity instance is in the middle of a Serialization process, for example during a WriteXml() call.
		/// For internal use only. 
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[XmlIgnore]
		public bool IsSerializing 
		{
			get { return _isSerializing; }
			set { _isSerializing=value;}
		}

		/// <summary>
		/// Gets / sets the IConcurrencyPredicateFactory to use for <see cref="GetConcurrencyPredicate"/>.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public IConcurrencyPredicateFactory ConcurrencyPredicateFactoryToUse
		{
			get
			{
				return _concurrencyPredicateFactoryToUse;
			}
			set
			{
				_concurrencyPredicateFactoryToUse = value;
			}
		}

		/// <summary>
		/// The validator object used to validate the complete entity. Call <see cref="Validate"/> to use this validator.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public IEntityValidator EntityValidatorToUse
		{
			get
			{
				return _entityValidatorToUse;
			}
			set
			{
				_entityValidatorToUse = value;
			}
		}

		/// <summary>
		/// Marker for the entity object if the object is 'dirty' (changed, true) or not (false). Affects/reads .Fields.IsDirty.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[XmlIgnore]
		public bool IsDirty
		{
			get
			{
				if(_isDeserializing || (_fields==null))
				{
					return false;
				}
				return _fields.IsDirty;
			}
			set
			{
				if(_fields!=null)
				{
					_fields.IsDirty = value;
				}
			}
		}

		/// <summary>
		/// List of IEntityField references which form the primary key. Reads/Affects .Fields.PrimaryKeyFields
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		[XmlIgnore]
		public ArrayList PrimaryKeyFields 
		{
			get 
			{
				if(_fields!=null)
				{
					return _fields.PrimaryKeyFields;
				}
				else
				{
					return new ArrayList();
				}
			}
		}

		
	#endregion
	}
}
