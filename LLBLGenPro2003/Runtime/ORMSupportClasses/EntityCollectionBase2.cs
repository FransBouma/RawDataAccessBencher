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
using System.ComponentModel;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Reflection;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Implementation of the entity collection base class.
	/// </summary>
	[ListBindable(true)]
	[Serializable]
	public abstract class EntityCollectionBase2 : CollectionBase, IEntityCollection2, IBindingList, ITypedList, ISerializable
	{
		#region Class Member Declarations
		private IEntityFactory2		_entityFactoryToUse;
		private IValidator			_validatorToUse;
		private bool				_allowNew, _allowRemove, _allowEdit, _isReadOnly, _containsDirtyContents, _doNotPerformAddIfPresent;
		private IEntity2			_containingEntity;
		private	string				_containingEntityMappedField;

		[NonSerialized]
		private ArrayList			_dirtyEntities;
		[NonSerialized]
		private bool				_allowSorting;
		[NonSerialized]
		private bool				_isSorted;
		[NonSerialized]
		private PropertyDescriptor	_propertySortedOn;
		[NonSerialized]
		private ListSortDirection	_sortDirection;
		[NonSerialized]
		private	ArrayList			_contentInOriginalOrder;			// valid when the collection gets sorted. 
		[NonSerialized]
		private bool				_listOperationInProgress;
		[NonSerialized]
		private bool				_deserializationInProgress;
		#endregion

		#region Event Declarations
		/// <summary>
		/// Event which is used in complex databinding.
		/// </summary>
		public event System.ComponentModel.ListChangedEventHandler ListChanged;
		/// <summary>
		/// Event which is fired if Remove or RemoveAt(index) is called and the remove is not yet executed.
		/// 'sender' is the object that will be removed from the list.
		/// </summary>
		public event EventHandler BeforeRemove;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		/// <remarks>En</remarks>
		public EntityCollectionBase2()
		{
			InitClass(null, null);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="entityFactoryToUse">The entity factory object to use when this collection has to construct new objects.
		/// This is the case when the collection is bound to a grid-like control for example.</param>
		public EntityCollectionBase2(IEntityFactory2 entityFactoryToUse)
		{
			InitClass(entityFactoryToUse, null);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="entityFactoryToUse">The entity factory object to use when this collection has to construct new objects.
		/// This is the case when the collection is bound to a grid-like control for example.</param>
		/// <param name="validatorToUse">The validator object to use for new entities constructed using the entity factory. Ignored when null</param>
		public EntityCollectionBase2(IEntityFactory2 entityFactoryToUse, IValidator validatorToUse)
		{
			InitClass(entityFactoryToUse, validatorToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EntityCollectionBase2(SerializationInfo info, StreamingContext context)
		{
			InitClass(null, null);

			try
			{
				_deserializationInProgress=true;

				// deserialize the data back into this instance.
				int amountOfEntitiesInList = info.GetInt32("AmountEntitiesInList");

				_entityFactoryToUse = (IEntityFactory2)info.GetValue("_entityFactoryToUse", typeof(IEntityFactory2));
				_validatorToUse = (IValidator)info.GetValue("_validatorToUse", typeof(IValidator));
				_allowNew = info.GetBoolean("_allowNew");
				_allowRemove = info.GetBoolean("_allowRemove");
				_allowEdit = info.GetBoolean("_allowEdit");
				_containingEntity = (IEntity2)info.GetValue("_containingEntity", typeof(IEntity2));
				_containingEntityMappedField = info.GetString("_containingEntityMappedField");
				_doNotPerformAddIfPresent = info.GetBoolean("_doNotPerformAddIfPresent");
				_containsDirtyContents = info.GetBoolean("_containsDirtyContents");
				bool readOnlyValue = info.GetBoolean("_isReadOnly");

				for(int i=0;i<amountOfEntitiesInList;i++)
				{
					IEntity2 entityToAdd = (IEntity2)info.GetValue("Entity" + i, typeof(IEntity2));
					// add it. It will wire the events automatically.
					this.Add(entityToAdd);
				}

				// set readonly now, otherwise it will affect Add.
				_isReadOnly = readOnlyValue;
			}
				// all exceptions are fatal
			finally
			{
				_deserializationInProgress=false;
			}
		}


		/// <summary>
		/// Sets the entity information of the entity object containing this collection. Call this method only from
		/// entity classes which contain EntityCollection members, like 'Customer' which contains 'Orders' entity collection.
		/// </summary>
		/// <param name="containingEntity">The entity containing this entity collection as a member variable</param>
		/// <param name="fieldName">The field the containing entity has mapped onto the relation which delivers the entities contained
		/// in this collection</param>
		public void SetContainingEntityInfo(IEntity2 containingEntity, string fieldName)
		{
			_containingEntity = containingEntity;
			_containingEntityMappedField = fieldName;
		}


		/// <summary>
		/// Adds an IEntity2 object to the list. Only new entities are added.
		/// </summary>
		/// <param name="entityToAdd">Entity2 to add</param>
		/// <returns>Index in list</returns>
		/// <exception cref="InvalidOperationException">If this collection is marked as ReadOnly</exception>
		public int Add(IEntity2 entityToAdd)
		{
			if(_isReadOnly)
			{
				throw new InvalidOperationException("This collection is read-only.");
			}

			if(_doNotPerformAddIfPresent && !_deserializationInProgress)
			{
				if(List.Contains(entityToAdd))
				{
					return List.IndexOf(entityToAdd);
				}
			}

			// it has to be added, add it.
			int index = List.Add(entityToAdd);
			_contentInOriginalOrder.Add(entityToAdd);

			if(!_deserializationInProgress)
			{
				if(entityToAdd.IsDirty)
				{
					_containsDirtyContents=true;
					_dirtyEntities.Add(entityToAdd);
				}

				if(_containingEntity!=null)
				{
					entityToAdd.SetRelatedEntity(_containingEntity, _containingEntityMappedField);
				}

				OnListChanged(index, ListChangedType.ItemAdded);
			}

			// subscribe to the changed event.
			entityToAdd.EntityContentsChanged +=new EventHandler(EntityInListOnEntityContentsChanged);
			return index;
		}


		/// <summary>
		/// Inserts an IEntity2 on position Index. Only new entities are added.
		/// </summary>
		/// <param name="index">Index where to insert the Entity2</param>
		/// <param name="entityToAdd">Entity2 to insert</param>
		/// <exception cref="InvalidOperationException">If this collection is marked as ReadOnly</exception>
		public void Insert(int index, IEntity2 entityToAdd)
		{
			if(_isReadOnly)
			{
				throw new InvalidOperationException("This collection is read-only.");
			}

			bool insertTheEntity = true;
			if(_doNotPerformAddIfPresent)
			{
				insertTheEntity = !List.Contains(entityToAdd);
			}

			if(insertTheEntity)
			{
				List.Insert(index, entityToAdd);
				if(!_deserializationInProgress)
				{
					if(entityToAdd.IsDirty)
					{
						_containsDirtyContents=true;
						_dirtyEntities.Add(entityToAdd);
					}

					if(_containingEntity!=null)
					{
						entityToAdd.SetRelatedEntity(_containingEntity, _containingEntityMappedField);
					}

					OnListChanged(index, ListChangedType.ItemAdded);
				}

				if(_isSorted)
				{
					_contentInOriginalOrder.Add(entityToAdd);
				}
				else
				{
					_contentInOriginalOrder.Insert(index, entityToAdd);
				}
				// subscribe to the changed event.
				entityToAdd.EntityContentsChanged +=new EventHandler(EntityInListOnEntityContentsChanged);
			}
		}


		/// <summary>
		/// Remove given IEntity2 from the list.
		/// </summary>
		/// <param name="entityToRemove">Entity2 object to remove from list.</param>
		/// <exception cref="InvalidOperationException">If this collection is marked as ReadOnly</exception>
		public void Remove(IEntity2 entityToRemove)
		{
			if(_isReadOnly)
			{
				throw new InvalidOperationException("This collection is read-only.");
			}

			int index = List.IndexOf(entityToRemove);
			if(index >=0)
			{
				if(BeforeRemove!=null)
				{
					BeforeRemove(entityToRemove, new EventArgs());
				}
				List.Remove(entityToRemove);
				_contentInOriginalOrder.Remove(entityToRemove);

				if(_containingEntity!=null)
				{
					entityToRemove.UnsetRelatedEntity(_containingEntity, _containingEntityMappedField);
				}

				OnListChanged(index, ListChangedType.ItemDeleted);
				// remove subscribtion to the changed event.
				entityToRemove.EntityContentsChanged -= new EventHandler(EntityInListOnEntityContentsChanged);

				if(_dirtyEntities.Contains(entityToRemove))
				{
					_dirtyEntities.Remove(entityToRemove);
					if(_dirtyEntities.Count<=0)
					{
						_containsDirtyContents=false;
					}
				}
			}
		} 


		/// <summary>
		/// Removes the IEntity2 instance at the index given.
		/// </summary>
		/// <param name="index">Index in list to remove the element</param>
		/// <exception cref="InvalidOperationException">If this collection is marked as ReadOnly</exception>
		public new void RemoveAt(int index)
		{
			if(_isReadOnly)
			{
				throw new InvalidOperationException("This collection is read-only.");
			}

			IEntity2 entityToRemove = (IEntity2)List[index];

			if(_isSorted)
			{
				_contentInOriginalOrder.RemoveAt(_contentInOriginalOrder.IndexOf(List[index]));
			}
			else
			{
				_contentInOriginalOrder.RemoveAt(index);
			}
			if(BeforeRemove!=null)
			{
				BeforeRemove(entityToRemove, new EventArgs());
			}

			if(_containingEntity!=null)
			{
				entityToRemove.UnsetRelatedEntity(_containingEntity, _containingEntityMappedField);
			}

			base.RemoveAt(index);

			OnListChanged(index, ListChangedType.ItemDeleted);
			// remove subscribtion to the changed event.
			entityToRemove.EntityContentsChanged -= new EventHandler(EntityInListOnEntityContentsChanged);

			if(_dirtyEntities.Contains(entityToRemove))
			{
				_dirtyEntities.Remove(entityToRemove);
				if(_dirtyEntities.Count<=0)
				{
					_containsDirtyContents=false;
				}
			}
		}


		/// <summary>
		/// Returns true if the list contains the given IEntity2 Object
		/// </summary>
		/// <param name="entityToFind">Entity2 object to check.</param>
		/// <returns>true if Entity2 exists in list.</returns>
		public bool Contains(IEntity2 entityToFind)
		{
			return List.Contains(entityToFind);
		}


		/// <summary>
		/// Returns index in the list of given IEntity2 object.
		/// </summary>
		/// <param name="entityToFind">Entity2 Object to check</param>
		/// <returns>index in list.</returns>
		public int IndexOf(IEntity2 entityToFind)
		{
			return List.IndexOf(entityToFind);
		}


		/// <summary>
		/// Performs a clear of the internals and its internal objects.
		/// </summary>
		protected override void OnClear()
		{
			if(!_listOperationInProgress)
			{
				if(_isReadOnly)
				{
					throw new InvalidOperationException("This collection is read-only.");
				}
				
				// unset related entity information
				if(_containingEntity!=null)
				{
					for (int i = 0; i < List.Count; i++)
					{
						((IEntity2)List[i]).UnsetRelatedEntity(_containingEntity, _containingEntityMappedField);
					}
				}

				_contentInOriginalOrder.Clear();
			}
			base.OnClear ();
		}


		/// <summary>
		/// Performs signaling of a list change, unless _listOperationInProgress is set to true
		/// </summary>
		protected override void OnClearComplete()
		{
			base.OnClearComplete();
			_isSorted=false;
			_propertySortedOn=null;
			_sortDirection=ListSortDirection.Ascending;
			if(_listOperationInProgress)
			{
				return;
			}
			OnListChanged(0, ListChangedType.Reset);
			_dirtyEntities.Clear();
			_containsDirtyContents = false;
		}


		/// <summary>
		/// copy the complete list of IEntity2 objects to an array of IEntity2 objects.
		/// </summary>
		/// <param name="destination">Array of IEntity2 Objects wherein the contents of the list will be copied.</param>
		/// <param name="index">Start index to copy from</param>
		public void CopyTo(IEntity2[] destination, int index)
		{
			List.CopyTo(destination, index);
		}


		/// <summary>
		/// ITypedList.GetItemProperties implementation. Necessary for Complex databinding. 
		/// </summary>
		/// <param name="listAccessors">Data to determine which property descriptor set to create</param>
		/// <returns>collection of property descriptors which will be used to create property related objects, like columns in a bound grid.</returns>
		/// <remarks>This is the version which will simply create property descriptors using the instance at index 0 or if there is no
		/// entity at index 0, using a temp one using the entity factory object. If no entity factory is present, an empty list
		/// is returned. Calling this version of the method should only be done when listAccessors is null or empty. In other
		/// cases, the <i>derived class</i> should use the listAccessors[length-1] PropertyDescriptor, check its TypeContainedAttribute
		/// attribute and read the type included in there to construct the property descriptors. In that situation, do not call
		/// <i>this</i> method version.</remarks>
		/// <exception cref="InvalidOperationException">When listAccessors is not empty. In that situation a derived class
		/// should use an instance of the type found in the TypeContainedAttribute attribute to construct the properties.</exception>
		public virtual PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			if((List.Count==0)&&(_entityFactoryToUse==null))
			{
				// can't create any descriptors
				return new PropertyDescriptorCollection(null);
			}

			// determine the type of the entity to return the properties of.
			if((listAccessors==null)||listAccessors.Length==0)
			{
				// this collection. create property descriptors. First check if there are objects in this collection. If not, create a new one
				IEntity2 propertySupplierEntity = null;
				if(List.Count>0)
				{
					propertySupplierEntity = (IEntity2)List[0];
				}
				else
				{
					if(_entityFactoryToUse==null)
					{
						// no factory, no entities. Can't determine properties.
						return new PropertyDescriptorCollection(null);
					}
					propertySupplierEntity = _entityFactoryToUse.Create();
				}

				Type typeOfEntity = propertySupplierEntity.GetType();
				return GetPropertyDescriptors(propertySupplierEntity, typeOfEntity);
			}
			else
			{
				// a collection which is reachable using an instance of this collection and its properties. (like Customer.Orders[0].Products )
				// this routine can't and shouldn't handle that situation. Throw exception
				throw new InvalidOperationException("listAccessors is not empty, do not call this base class method version in that situation.");
			}
		}


		/// <summary>
		/// ITypedList member
		/// </summary>
		/// <param name="listAccessors"></param>
		/// <returns></returns>
		public virtual string GetListName(PropertyDescriptor[] listAccessors)
		{
			return "";
		}


		/// <summary>
		/// ISerializable member. 
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_entityFactoryToUse", _entityFactoryToUse);
			info.AddValue("_validatorToUse", _validatorToUse);
			info.AddValue("_allowNew", _allowNew);
			info.AddValue("_allowRemove", _allowRemove);
			info.AddValue("_allowEdit", _allowEdit);
			info.AddValue("_isReadOnly", _isReadOnly);
			info.AddValue("_containingEntity", _containingEntity);
			info.AddValue("_containingEntityMappedField", _containingEntityMappedField);
			info.AddValue("_doNotPerformAddIfPresent", _doNotPerformAddIfPresent);
			info.AddValue("_containsDirtyContents", _containsDirtyContents);
			info.AddValue("AmountEntitiesInList", this.Count);

			if(this.Count > 0)
			{
				// serialize the entities
				for(int i=0;i<this.Count;i++)
				{
					info.AddValue("Entity" + i, List[i]);
				}
			}
		}


		/// <summary>
		/// Constructs the actual property descriptor collection.
		/// </summary>
		/// <param name="entityToCheck">entity instance which properties should be included in the collection</param>
		/// <param name="typeOfEntity">full type of the entity</param>
		/// <returns>filled in property descriptor collection</returns>
		public abstract PropertyDescriptorCollection GetPropertyDescriptors(IEntity2 entityToCheck, Type typeOfEntity);


		#region IBindingList methods
		/// <summary>
		/// IBindingList member. 
		/// </summary>
		/// <exception cref="NotSupportedException">thrown when called. Not supported.</exception>
		public virtual void AddIndex(PropertyDescriptor property)
		{
			throw new NotSupportedException("AddIndex is not supported.");
		}


		/// <summary>
		/// IBindingList member. Sorts on entity fields only. Ignores other fields.
		/// </summary>
		/// <exception cref="NotSupportedException">thrown when called and SupportsSorting is set to false.</exception>
		public virtual void ApplySort(PropertyDescriptor property, System.ComponentModel.ListSortDirection direction)
		{
			if(!_allowSorting)
			{
				throw new NotSupportedException("ApplySort requires that SupportsSorting is set to true.");
			}

			if(List.Count<=0)
			{
				return;
			}

			// test if the supplied property is part of IEntityFields
			try
			{
				IEntityFieldCore field = ((IEntity2)_contentInOriginalOrder[0]).Fields[property.Name];
			}
			catch(ArgumentException)
			{
				// name not existend. do not sort
				return;
			}

			_listOperationInProgress=true;
			// do sorting. Use sorted list for this, with key the value, and as value an array list of indices.
			SortedList sorter = new SortedList(_contentInOriginalOrder.Count);
			ArrayList indices = null;
			for (int i = 0; i < _contentInOriginalOrder.Count; i++)
			{
				IEntity2 currentEntity = (IEntity2)_contentInOriginalOrder[i];
				if(sorter.ContainsKey(currentEntity.Fields[property.Name].CurrentValue))
				{
					// already there, add index to arraylist with indices
					indices = (ArrayList)sorter[currentEntity.Fields[property.Name].CurrentValue];
				}
				else
				{
					indices = new ArrayList();
					sorter.Add(currentEntity.Fields[property.Name].CurrentValue, indices);
				}

				indices.Add(i);
			}

			// sorted list contains indices in ASCENDING order. Check the direction to read from front to back or from back to front.
			ArrayList newList = new ArrayList(_contentInOriginalOrder.Count);
			if(direction==ListSortDirection.Ascending)
			{
				// front to back
				for (int i = 0; i < sorter.Count; i++)
				{
					ArrayList indicesStored = (ArrayList)sorter.GetByIndex(i);
					for (int j = 0; j < indicesStored.Count; j++)
					{
						newList.Add(_contentInOriginalOrder[(int)indicesStored[j]]);
					}
				}
			}
			else
			{
				// back to front
				for (int i = sorter.Count-1; i >= 0; i--)
				{
					ArrayList indicesStored = (ArrayList)sorter.GetByIndex(i);
					for (int j = indicesStored.Count-1; j >= 0; j--)
					{
						newList.Add(_contentInOriginalOrder[(int)indicesStored[j]]);
					}
				}
			}

			// newList contains objects in new Order. Clear list first, then insert the items again.
			List.Clear();
			for (int i = 0; i < newList.Count; i++)
			{
				List.Add(newList[i]);
			}

			_listOperationInProgress=false;
			_isSorted=true;
			_propertySortedOn = property;
			_sortDirection = direction;

			// done. signal list change
			OnListChanged(0, ListChangedType.Reset);
		}


		/// <summary>
		/// IBindingList member. 
		/// </summary>
		/// <remarks>Does a linear search through all the loaded entities in this collection.</remarks>
		public virtual int Find(PropertyDescriptor property, object key)
		{
			int index = -1;
			for (int i = 0; i < List.Count; i++)
			{
				if(((IEntity2)List[i]).Fields[property.Name].CurrentValue.Equals(key))
				{
					index=i;
					break;
				}
			}

			return index;
		}


		/// <summary>
		/// IBindingList member. 
		/// </summary>
		/// <exception cref="NotSupportedException">thrown when called and SupportsSorting is set to false.</exception>
		public virtual void RemoveSort()
		{
			if(!_allowSorting)
			{
				throw new NotSupportedException("RemoveSort requires that SupportsSorting is set to true.");
			}

			if(!_isSorted)
			{
				return;
			}

			if(List.Count<=0)
			{
				return;
			}

			_listOperationInProgress=true;
			List.Clear();
			for (int i = 0; i < _contentInOriginalOrder.Count; i++)
			{
				List.Add(_contentInOriginalOrder[i]);
			}
			_listOperationInProgress=false;
			_isSorted=false;
			_propertySortedOn = null;
			_sortDirection = ListSortDirection.Ascending;

			// done. signal list change
			OnListChanged(0, ListChangedType.Reset);
		}


		/// <summary>
		/// IBindingList member. Will add a new entity to the list, will set its parent collection property so CancelEdit will remove
		/// it from the list again, and will set its flag that it is added by databinding. 
		/// </summary>
		/// <remarks>Do not call this method from your own code. This is a databinding ONLY method.</remarks>
		/// <exception cref="InvalidOperationException">If this collection is set to ReadOnly</exception>
		public virtual object AddNew()
		{
			if(_isReadOnly)
			{
				throw new InvalidOperationException("This collection is read-only.");
			}

			IEntity2 newEntity = _entityFactoryToUse.Create();
			((EntityBase2)newEntity).IsNewViaDataBinding=true;
			((EntityBase2)newEntity).ParentCollection=this;
			if(_validatorToUse!=null)
			{
				newEntity.Validator = _validatorToUse;
			}
			this.Add(newEntity);
			return newEntity;
		}


		/// <summary>
		/// IBindingList member. 
		/// </summary>
		/// <exception cref="NotSupportedException">thrown when called. Not supported.</exception>
		public virtual void RemoveIndex(PropertyDescriptor property)
		{
			throw new NotSupportedException("RemoveIndex is not supported.");
		}
		#endregion


		/// <summary>
		/// Converts this entity collection to XML, recursively. Uses "EntityCollection" for the rootnode name
		/// </summary>
		/// <param name="entityCollectionXml">The complete outer XML as string, representing this complete entity object, including containing data.</param>
		public void WriteXml(out string entityCollectionXml)
		{
			WriteXml("EntityCollection", out entityCollectionXml);
		}


		/// <summary>
		/// Converts this entity collection to XML. Uses "EntityCollection" for the rootnode name
		/// </summary>
		/// <param name="parentDocument">the XmlDocument which will contain the node this method will create. This document is required
		/// to create the new node object</param>
		/// <param name="entityCollectionNode">The XmlNode representing this complete entitycollection object, including containing data.</param>
		public void WriteXml(XmlDocument parentDocument, out XmlNode entityCollectionNode)
		{
			WriteXml("EntityCollection", parentDocument, out entityCollectionNode);
		}


		/// <summary>
		/// Converts this entity collection to XML. 
		/// </summary>
		/// <param name="rootNodeName">name of root element to use when building a complete XML representation of this entity collection.</param>
		/// <param name="entityCollectionXml">The complete outer XML as string, representing this complete entity object, including containing data.</param>
		public void WriteXml(string rootNodeName, out string entityCollectionXml)
		{
			XmlNode entityCollectionNode = null;
			WriteXml(rootNodeName, new XmlDocument(), out entityCollectionNode);
			entityCollectionXml = entityCollectionNode.OuterXml;
		}


		/// <summary>
		/// Converts this entity collection to XML. 
		/// </summary>
		/// <param name="rootNodeName">name of root element to use when building a complete XML representation of this entity collection.</param>
		/// <param name="parentDocument">the XmlDocument which will contain the node this method will create. This document is required
		/// to create the new node object</param>
		/// <param name="entityCollectionNode">The XmlNode representing this complete entitycollection object, including containing data.</param>
		public virtual void WriteXml(string rootNodeName, XmlDocument parentDocument, out XmlNode entityCollectionNode)
		{
			EntityCollection2Xml(rootNodeName, parentDocument, new Hashtable(), out entityCollectionNode);
		}


		/// <summary>
		/// Produces the actual XML for this entity collection, recursively. Because it recurses through contained entities, 
		/// it keeps track of which objects are processed so cyclic references are not resulting in cyclic recursion and thus a crash. 
		/// </summary>
		/// <param name="rootNodeName">name of root element to use when building a complete XML representation of this entity collection.</param>
		/// <param name="parentDocument">the XmlDocument which will contain the node this method will create. This document is required
		/// to create the new node object</param>
		/// <param name="processedObjectIDs">Hashtable with ObjectIDs of all the objects already processed. If an entity's ObjectID is in the
		/// hashtable's key list, a ProcessedObjectReference tag is emitted and the entity will not recurse further. </param>
		/// <param name="entityCollectionNode">The XmlNode representing this complete entitycollection object, including containing data.</param>
		internal void EntityCollection2Xml(string rootNodeName, XmlDocument parentDocument, Hashtable processedObjectIDs, out XmlNode entityCollectionNode)		
		{
			XmlHelper nodeCreator = new XmlHelper();

			// add root node
			entityCollectionNode = parentDocument.CreateNode(XmlNodeType.Element, rootNodeName, "");
			XmlNode entitiesNode = nodeCreator.AddNode(entityCollectionNode, "Entities");

			for(int i=0;i<this.Count;i++)
			{
				EntityBase2 entity = (EntityBase2)List[i];

				XmlNode nodeToAppend = null;
				entity.Entity2Xml(entity.LLBLGenProEntityName, parentDocument, processedObjectIDs, out nodeToAppend);
				entitiesNode.AppendChild(nodeToAppend);
			}

			// add assembly and type as attributes
			nodeCreator.AddAttribute(entityCollectionNode, "Assembly", this.GetType().Assembly.FullName);
			nodeCreator.AddAttribute(entityCollectionNode, "Type", this.GetType().FullName);

			// get properties of this IEntityCollection2 implementing object
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this);
			for (int i = 0; i < properties.Count; i++)
			{
				if(properties[i].Attributes.Contains(new XmlIgnoreAttribute()))
				{
					// ignore this property
					continue;
				}

				if(properties[i].PropertyType.IsInterface)
				{
					// check for EntityFactory
					if(properties[i].PropertyType.Equals(typeof(IEntityFactory2)))
					{
						// .EntityFactoryToUse property
						XmlNode entityFactoryNode = nodeCreator.AddNode(entityCollectionNode, "EntityFactoryToUse");

						IEntityFactory2 entityFactory = properties[i].GetValue(this) as IEntityFactory2;
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
						XmlNode validatorNode = nodeCreator.AddNode(entityCollectionNode, "Validator");
						IValidator entityValidator = properties[i].GetValue(this) as IValidator;
						if(entityValidator==null)
						{
							nodeCreator.AddAttribute(validatorNode, "Assembly", "Unknown");
						}
						else
						{
							nodeCreator.AddAttribute(validatorNode, "Assembly", entityValidator.GetType().Assembly.FullName);
							nodeCreator.AddAttribute(validatorNode, "Type", entityValidator.GetType().FullName);
						}
						// done with this property
						continue;
					}
				}

				// Normal not yet handled property. Add it.
				XmlNode childNode = nodeCreator.AddNode(entityCollectionNode, properties[i].Name);
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
						valueAsString = properties[i].GetValue(this).ToString();
						break;
				}
				childNode.AppendChild(parentDocument.CreateTextNode(valueAsString));
			}
		}


		/// <summary>
		/// Will fill the entity collection and its containing members (recursively) with the data stored in the XmlNode passed in. The XmlNode has to
		/// be filled with Xml in the format written by IEntityCollection2.WriteXml() and the Xml has to be compatible with the structure of this entity collection.
		/// </summary>
		/// <param name="xmlData">string with Xml data which should be read into this entity collection and its members. This string has to be in the
		/// correct format and should be loadable into a new XmlDocument without problems</param>
		public void ReadXml(string xmlData)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xmlData);
			ReadXml(doc.DocumentElement);
		}


		/// <summary>
		/// Will fill the entity collection and its containing members (recursively) with the data stored in the XmlNode passed in. The XmlNode has to
		/// be filled with Xml in the format written by IEntityCollection2.WriteXml() and the Xml has to be compatible with the structure of this entity collection.
		/// </summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element
		/// of the entity collection's Xml data</param>
		public virtual void ReadXml(XmlNode node)
		{
			ArrayList nodeEntityReferences = new ArrayList();
			Hashtable processedObjectIDs = new Hashtable();
			Xml2EntityCollection(node, processedObjectIDs, nodeEntityReferences);

			// walk all references found and set them to the correct objects.
			XmlHelper.SetReadReferences(nodeEntityReferences, processedObjectIDs);
		}


		/// <summary>
		/// Performs the actual conversion from Xml to entity collection data. 
		/// </summary>
		/// <param name="node">current node which points to an entity collection node.</param>
		/// <param name="processedObjectIDs">ObjectID's of all entities instantiated</param>
		/// <param name="nodeEntityReferences">Arraylist with all the references to entity objects we probably do not yet have instantiated. This list
		/// is traversed after the xml tree has been processed. (not done by this routine, but by the caller)</param>
		internal void Xml2EntityCollection(XmlNode node, Hashtable processedObjectIDs, ArrayList nodeEntityReferences)
		{
			try
			{
				_deserializationInProgress = true;
				XmlHelper typeConverter = new XmlHelper();

				// get this instance's properties.
				PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(this);

				// first walk the subnodes and process only the direct childs, skipping entity collections and entity references.
				foreach(XmlNode currentElement in node.ChildNodes)
				{
					switch(currentElement.Name)
					{
						case "Entities":
							// first test if this node is empty
							if(currentElement.ChildNodes.Count<=0)
							{
								// is empty
								continue;
							}

							// get all child nodes and de-serialize them one by one.
							XmlNodeList entityNodes = currentElement.ChildNodes;
							foreach(XmlNode entityNode in entityNodes)
							{
								// check if this node is a reference node
								if(entityNode.Name=="ProcessedObjectReference")
								{
									NodeEntityReference newReference = new NodeEntityReference();
									newReference.ObjectID = new Guid(entityNode.Attributes["ObjectID"].Value);
									newReference.PropertyHoldingInstance = this;
									newReference.IsCollectionAdd=true;
									newReference.ReferencingProperty = null;
									nodeEntityReferences.Add(newReference);
									// done with this node.
									break;
								}

								// get type and assembly for entity instance.
								string entityAssemblyName = entityNode.Attributes["Assembly"].Value;
								string entityTypeName = entityNode.Attributes["Type"].Value;
								// load assembly
								Assembly entityAssembly = Assembly.Load(entityAssemblyName);
								// create instance
								EntityBase2 referencedEntity = (EntityBase2)entityAssembly.CreateInstance(entityTypeName);
								referencedEntity.IsDeserializing=true;
								try
								{
									// convert this entity's xml into data inside this entity
									referencedEntity.Xml2Entity(entityNode, processedObjectIDs, nodeEntityReferences);
									// add to collection.
									this.Add(referencedEntity);
								}
								finally
								{
									referencedEntity.IsDeserializing=false;
								}
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
							this.ValidatorToUse = (IValidator)validatorAssembly.CreateInstance(validatorClassType);
							break;
						case "EntityFactoryToUse":
							string entityFactoryAssemblyName = currentElement.Attributes["Assembly"].Value;
							if(entityFactoryAssemblyName=="Unknown")
							{
								// no entityfactory set nor serialized
								continue;
							}
							Assembly entityFactoryAssembly = Assembly.Load(entityFactoryAssemblyName);
							string entityFactoryClassType = currentElement.Attributes["Type"].Value;
							this.EntityFactoryToUse = (IEntityFactory2)entityFactoryAssembly.CreateInstance(entityFactoryClassType);
							break;
						default:
							// custom property, not a field.
							string elementTypeName = currentElement.Attributes["Type"].Value;
							string xmlValue = currentElement.InnerText;
							properties[currentElement.Name].SetValue(this, typeConverter.XmlValueToObject(elementTypeName, xmlValue));
							break;
					}
				}
			}
			finally
			{
				_deserializationInProgress = false;
			}
		}


		/// <summary>
		/// Called when the List is changed and the event should be raised.
		/// </summary>
		/// <param name="index">Index of object causing the list change</param>
		/// <param name="typeOfChange">The type of change to reflect to subscribers</param>
		protected void OnListChanged(int index, ListChangedType typeOfChange)
		{
			if(ListChanged!=null)
			{
				ListChanged(this, new ListChangedEventArgs(typeOfChange, index));
			}
		}


		/// <summary>
		/// Event handler for the EntityContentsChanged event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void EntityInListOnEntityContentsChanged(object sender, EventArgs e)
		{
			// an entity in the list has changed. Fire the list changed event and mark it as changed, plus mark the collection as a collection with dirty
			// contents
			IEntity2 dirtyEntity = (IEntity2)sender;
			_containsDirtyContents = true;
			if(!_dirtyEntities.Contains(dirtyEntity))
			{
				_dirtyEntities.Add(dirtyEntity);
			}
			OnListChanged(List.IndexOf(dirtyEntity), ListChangedType.ItemChanged);
		}


		/// <summary>
		/// Inits the class
		/// </summary>
		/// <param name="entityFactoryToUse">The EntityFactory2 to use when creating entity objects when a bound control is adding a new entity. </param>
		/// <param name="validatorToUse">The validator object to use when new entities are created using the entity factory. Ignored when null</param>
		private void InitClass(IEntityFactory2 entityFactoryToUse, IValidator validatorToUse)
		{
			_entityFactoryToUse = entityFactoryToUse;
			_validatorToUse = validatorToUse;
			_allowNew=true;
			_allowEdit=true;
			_allowRemove=false;
			_allowSorting=false;
			_propertySortedOn = null;
			_isSorted=false;
			_sortDirection = ListSortDirection.Ascending;
			_contentInOriginalOrder = new ArrayList();
			_listOperationInProgress=false;
			_isReadOnly = false;
			_containingEntity = null;
			_containingEntityMappedField = string.Empty;
			_deserializationInProgress=false;
			_dirtyEntities = new ArrayList();
			_containsDirtyContents = false;
			_doNotPerformAddIfPresent = true;
		}


		/// <summary>
		/// Sets the related entity of the passed in entity to the entity this collection is related to.
		/// </summary>
		/// <param name="entity"></param>
		private void SetRelatedEntity(IEntity2 entity)
		{
			if(!_deserializationInProgress)
			{
				if(_containingEntity!=null)
				{
					entity.SetRelatedEntity(_containingEntity, _containingEntityMappedField);
				}

			}
		}


		#region Class Property Declarations
		/// <summary>
		/// IBindingList property. Default: true
		/// </summary>
		public virtual bool AllowNew
		{
			get
			{
				return _allowNew;
			}
			set
			{
				_allowNew = value;
			}
		}

		/// <summary>
		/// IBindingList property. Default: null.
		/// </summary>
		[XmlIgnore]
		public virtual PropertyDescriptor SortProperty
		{
			get
			{
				return _propertySortedOn;
			}
		}

		/// <summary>
		/// IBindingList property. Default: false
		/// </summary>
		public virtual bool SupportsSorting
		{
			get
			{
				return _allowSorting;
			}
			set
			{
				_allowSorting = value;
			}
		}

		/// <summary>
		/// IBindingList property. Default: false
		/// </summary>
		[XmlIgnore]
		public virtual bool IsSorted
		{
			get
			{
				return _isSorted;
			}
		}

		/// <summary>
		/// IBindingList property. Default: false
		/// </summary>
		public virtual bool AllowRemove
		{
			get
			{
				return _allowRemove;
			}
			set
			{
				_allowRemove = value;
			}
		}

		/// <summary>
		/// IBindingList property. Default: true
		/// </summary>
		public virtual bool SupportsSearching
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		/// IBindingList property. Default: Ascending.
		/// </summary>
		[XmlIgnore]
		public virtual ListSortDirection SortDirection
		{
			get
			{
				return _sortDirection;
			}
		}

		/// <summary>
		/// IBindingList property. Default: true
		/// </summary>
		public virtual bool AllowEdit
		{
			get
			{
				return _allowEdit;
			}
			set
			{
				_allowEdit = value;
			}
		}

		/// <summary>
		/// IBindingList property. Default: supported
		/// </summary>
		public virtual bool SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		/// Items contained by this collection. This is the SORTED collection (if sorted). Remove sorting first to get the original list.
		/// </summary>
		[XmlIgnore]
		public virtual IList Items
		{
			get { return List; }
		}


		/// <summary>
		/// Returns the collection of entities which are flagged as dirty. 
		/// </summary>
		[XmlIgnore]
		public ArrayList DirtyEntities
		{
			get
			{
				return _dirtyEntities;
			}
		}


		/// <summary>
		/// Returns true if this collection contains dirty objects. If this collection contains dirty objects, an 
		/// already filled collection should not be refreshed until a save is performed. 
		/// Set operation is for XML Deserialization.
		/// </summary>
		[XmlIgnore]
		public bool ContainsDirtyContents
		{
			get 
			{ 
				return _containsDirtyContents;
			}
			set
			{
				_containsDirtyContents = value;
			}
		}

	
		/// <summary>
		/// The EntityFactory2 to use when creating entity objects when bound to a grid and AddNew is enabled.
		/// </summary>
		public IEntityFactory2 EntityFactoryToUse 
		{
			get { return _entityFactoryToUse; }
			set { _entityFactoryToUse = value;}
		}

		/// <summary>
		/// Gets / sets the validator object to use when creating entity objects using the entity factory.
		/// </summary>
		public IValidator ValidatorToUse
		{
			get
			{
				return _validatorToUse;
			}
			set
			{
				_validatorToUse = value;
			}
		}

		/// <summary>
		/// Simple indexer. 
		/// </summary>
		/// <exception cref="InvalidOperationException">When a value is Set and the collection is marked ReadOnly</exception>
		[XmlIgnore]
		public virtual IEntity2 this [int index]
		{
			get { return (IEntity2)List[index]; }
			set 
			{ 
				if(_isReadOnly)
				{
					throw new InvalidOperationException("This collection is read-only");
				}
				List[index]=value;
				if(!_deserializationInProgress)
				{
					if(_containingEntity!=null)
					{
						((IEntity2)value).SetRelatedEntity(_containingEntity, _containingEntityMappedField);
					}

					OnListChanged(index, ListChangedType.ItemAdded);
				}
			}
		}

		/// <summary>
		/// The amount of IEntity2 elements in this entity collection
		/// </summary>
		public new int Count 
		{
			get { return base.Count;}
		}


		/// <summary>
		/// Get / set the readonly flag for this collection. If set to true, it will affect IBindingList parameters as well.
		/// </summary>
		public bool IsReadOnly 
		{
			get { return _isReadOnly;}
			set 
			{ 
				_isReadOnly = value;
				_allowNew = !value;
				_allowRemove = !value;
				_allowEdit = !value;
			}
		}


		/// <summary>
		/// sets the internal flag to say that this collection is being deserialized.
		/// </summary>
		[XmlIgnore]
		internal bool DeserializationInProgress
		{
			set
			{
				_deserializationInProgress = value;
			}
		}
	
		/// <summary>
		/// When set to true, an entity passed to Add() or Insert() will be tested if it's already present. If so, the index is returned and the
		/// object is not added again. If set to false (default: true) this check is not performed. Setting this property to true can slow down fetch logic.
		/// DataAccessAdapter's fetch logic sets this property to false during a multi-entity fetch.
		/// </summary>
		public bool DoNotPerformAddIfPresent
		{
			get
			{
				return _doNotPerformAddIfPresent;
			}
			set
			{
				_doNotPerformAddIfPresent = value;
			}
		}
		#endregion

	}
}
