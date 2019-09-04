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
	public abstract class EntityCollectionBase : CollectionBase, IEntityCollection, ITransactionalElement, IBindingList, ITypedList, ISerializable
	{
		#region Class Member Declarations
			[NonSerialized]
			private	ITransaction					_containingTransaction;
			private long							_maxNumberOfItemsToReturn;
			private ISortExpression					_sortClauses;
			private IPropertyDescriptorFactory		_propertyDescriptorFactoryToUse;	// complex databinding related
			private Type							_typeOfDirectInheritor;				// complex databinding related
			private IEntityFactory					_entityFactoryToUse;
			private IValidator						_validatorToUse;
			private bool							_suppressClearInGetMulti, _allowNew, _allowRemove, _allowEdit;
			private IEntity							_containingEntity;
			private	string							_containingEntityMappedField;

			[NonSerialized]
			private bool							_allowSorting;
			[NonSerialized]
			private bool							_isSorted;
			[NonSerialized]
			private PropertyDescriptor				_propertySortedOn;
			[NonSerialized]
			private ListSortDirection				_sortDirection;
			[NonSerialized]
			private	ArrayList						_contentInOriginalOrder;			// valid when the collection gets sorted. 
			[NonSerialized]
			private bool							_listOperationInProgress;
			[NonSerialized]
			private bool							_deserializationInProgress;
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
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method. Complex databinding related.</param>
		/// <param name="typeOfDirectInheritor">Type of direct inheriting class. Used in GetItemProperties method. Complex databinding related.</param>
		public EntityCollectionBase(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, Type typeOfDirectInheritor)
		{
			InitClass(propertyDescriptorFactoryToUse, typeOfDirectInheritor, null, null);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method. Complex databinding related.</param>
		/// <param name="typeOfDirectInheritor">Type of direct inheriting class. Used in GetItemProperties method. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call. </param>
		public EntityCollectionBase(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, Type typeOfDirectInheritor, IEntityFactory entityFactoryToUse)
		{
			InitClass(propertyDescriptorFactoryToUse, typeOfDirectInheritor, entityFactoryToUse, null);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method. Complex databinding related.</param>
		/// <param name="typeOfDirectInheritor">Type of direct inheriting class. Used in GetItemProperties method. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call. </param>
		/// <param name="validatorToUse">The validator object to use when creating entity objects during a GetMulti() call.</param>
		public EntityCollectionBase(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, Type typeOfDirectInheritor, 
				IEntityFactory entityFactoryToUse, IValidator validatorToUse)
		{
			InitClass(propertyDescriptorFactoryToUse, typeOfDirectInheritor, entityFactoryToUse, validatorToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected EntityCollectionBase(SerializationInfo info, StreamingContext context)
		{
			InitClass(null, null, null, null);

			try
			{
				_deserializationInProgress=true;

				// deserialize the data back into this instance.
				int amountOfEntitiesInList = info.GetInt32("AmountEntitiesInList");

				_maxNumberOfItemsToReturn = info.GetInt64("_maxNumberOfItemsToReturn");
				_sortClauses = (ISortExpression)info.GetValue("_sortClauses", typeof(ISortExpression));
				_propertyDescriptorFactoryToUse = (IPropertyDescriptorFactory)info.GetValue("_propertyDescriptorFactoryToUse", typeof(IPropertyDescriptorFactory));
				_typeOfDirectInheritor = (System.Type)info.GetValue("_typeOfDirectInheritor", typeof(System.Type));
				_entityFactoryToUse = (IEntityFactory)info.GetValue("_entityFactoryToUse", typeof(IEntityFactory));
				_validatorToUse = (IValidator)info.GetValue("_validatorToUse", typeof(IValidator));
				_suppressClearInGetMulti = info.GetBoolean("_suppressClearInGetMulti");
				_containingEntity = (IEntity)info.GetValue("_containingEntity", typeof(IEntity));
				_containingEntityMappedField = info.GetString("_containingEntityMappedField");
				_allowNew = info.GetBoolean("_allowNew");
				_allowRemove = info.GetBoolean("_allowRemove");
				_allowEdit = info.GetBoolean("_allowEdit");

				for(int i=0;i<amountOfEntitiesInList;i++)
				{
					IEntity entityToAdd = (IEntity)info.GetValue("Entity" + i, typeof(IEntity));
					// add it. It will wire the events automatically.
					this.FastAdd(entityToAdd);
				}
			}
			finally
			{
				_deserializationInProgress = false;
			}
		}


		/// <summary>
		/// Sets the entity information of the entity object containing this collection. Call this method only from
		/// entity classes which contain EntityCollection members, like 'Customer' which contains 'Orders' entity collection.
		/// </summary>
		/// <param name="containingEntity">The entity containing this entity collection as a member variable</param>
		/// <param name="fieldName">The field the containing entity has mapped onto the relation which delivers the entities contained
		/// in this collection</param>
		public void SetContainingEntityInfo(IEntity containingEntity, string fieldName)
		{
			_containingEntity = containingEntity;
			_containingEntityMappedField = fieldName;
		}


		/// <summary>
		/// Converts the Entities inside this entitycollection into an entity node with inner nodes for each field, which is stored in a generic collection node.
		/// </summary>
		/// <returns>XmlNode containing the EntityFields in xml format</returns>
		public virtual XmlNode ToXml()
		{
			// empty
			return null;
		}


		/// <summary>
		/// When the <see cref="ITransaction"/> in which this IEntity participates is commited, this IEntity can succesfully finish actions performed by this
		/// IEntity. This method is called by <see cref="ITransaction"/>, you should not call it by yourself. When this IEntity doesn't participate in a
		/// transaction it finishes the actions itself, calling this method is not needed.
		/// </summary>
		public void TransactionCommit()
		{
			// empty, because entities in this collection are added to the transaction automatically and thus receive this call themselves
		}


		/// <summary>
		/// When the <see cref="ITransaction"/> in which this IEntity participates is rolled back, this IEntity has to roll back its internal variables.
		/// This method is called by <see cref="ITransaction"/>, you should not call it by yourself. 
		/// </summary>
		public void TransactionRollback()
		{
			// empty, because entities in this collection are added to the transaction automatically and thus receive this call themselves
		}


		/// <summary>
		/// Saves all new/dirty Entities in the IEntityCollection in the persistent storage. If this IEntityCollection is added
		/// to a transaction, the save processes will be done in that transaction, if the entity isn't already added to another transaction.
		/// If the entity is already in another transaction, it will use that transaction. If no transaction is present, the saves are done in a
		/// new Transaction (which is created in an inherited method.). Will not recursively save entities inside the collection.
		/// </summary>
		/// <returns>Amount of entities inserted</returns>
		/// <remarks>All exceptions will be bubbled upwards so transaction code can anticipate on exceptions.</remarks>
		public int SaveMulti()
		{
			return SaveMulti(false);
		}


		/// <summary>
		/// Saves all new/dirty Entities in the IEntityCollection in the persistent storage. If this IEntityCollection is added
		/// to a transaction, the save processes will be done in that transaction, if the entity isn't already added to another transaction.
		/// If the entity is already in another transaction, it will use that transaction. If no transaction is present, the saves are done in a
		/// new Transaction (which is created in an inherited method.)
		/// </summary>
		/// <param name="recurse">If true, will recursively save the entities inside the collection</param>
		/// <returns>Amount of entities inserted</returns>
		/// <remarks>All exceptions will be bubbled upwards so transaction code can anticipate on exceptions.</remarks>
		public virtual int SaveMulti(bool recurse)
		{
			int amountSaved = 0;

			for(int i=0;i<List.Count;i++)
			{
				IEntity entityToSave = (IEntity)List[i];
				bool saveEntity = (entityToSave.IsNew || entityToSave.Fields.IsDirty || recurse);

				// do not save this entity twice in a recursive save. It might have been saved already in a recursive save in this transaction.
				if(recurse)
				{
					saveEntity &= !_containingTransaction.EntitiesInTransaction.Contains(entityToSave.ObjectID);
				}
				
				if(saveEntity)
				{
					if(!((ITransactionalElement)List[i]).ParticipatesInTransaction)
					{
						// doesn't participate in a transaction, add it to the current transaction. Has to be available.
						_containingTransaction.Add((ITransactionalElement)List[i]);
					}
					bool wasSuccesful = entityToSave.Save(recurse);
					if(wasSuccesful)
					{
						amountSaved++;
					}
				}
			}
			return amountSaved;
		}


		/// <summary>
		/// Deletes all Entities in the IEntityCollection from the persistent storage. If this IEntityCollection is added
		/// to a transaction, the delete processes will be done in that transaction, if the entity isn't already added to another transaction.
		/// If the entity is already in another transaction, it will use that transaction. If no transaction is present, the deletes are done in a
		/// new Transaction (which is created in an inherited method.)
		/// Deleted entities are marked deleted and are removed from the collection.
		/// </summary>
		/// <returns>Amount of entities deleted</returns>
		/// <remarks>All exceptions will be bubbled upwards so transaction code can anticipate on exceptions.</remarks>
		public virtual int DeleteMulti()
		{
			int amountDeleted = 0;
			ArrayList entitiesToRemove = new ArrayList();

			for(int i=0;i<List.Count;i++)
			{
				IEntity entityToDelete = (IEntity)List[i];
				if(!((ITransactionalElement)List[i]).ParticipatesInTransaction)
				{
					// doesn't participate in a transaction, add it to the current transaction. Has to be available.
					_containingTransaction.Add((ITransactionalElement)List[i]);
				}
				bool wasSuccesful = entityToDelete.Delete();
				if(wasSuccesful)
				{
					// remove it, add it to the removelist
					entitiesToRemove.Add(entityToDelete);
					amountDeleted++;
				}
			}

			// now, remove all entities in the remove list from this list
			for (int i = 0; i < entitiesToRemove.Count; i++)
			{
				List.Remove(entitiesToRemove[i]);
				_contentInOriginalOrder.Remove(entitiesToRemove[i]);
			}

			entitiesToRemove.Clear();

			// flag this list that it is changed
			OnListChanged(0, ListChangedType.Reset);

			return amountDeleted;
		}


		/// <summary>
		/// Adds an IEntity object to the list. Only new entities are added.
		/// </summary>
		/// <param name="entityToAdd">Entity to add</param>
		/// <returns>Index in list</returns>
		public int Add(IEntity entityToAdd)
		{
			if(List.Contains(entityToAdd))
			{
				return List.IndexOf(entityToAdd);
			}
			else
			{
				return FastAdd(entityToAdd);
			}
		}


		/// <summary>
		/// Adds an IEntity object to the list. This version doesn't check for presence of teh passed in entity.
		/// </summary>
		/// <param name="entityToAdd">Entity to add</param>
		/// <returns>Index in list</returns>
		internal int FastAdd(IEntity entityToAdd)
		{
			int index = List.Add(entityToAdd);
			_contentInOriginalOrder.Add(entityToAdd);

			if(!_deserializationInProgress)
			{
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
		/// Inserts an IEntity on position Index. Only new entities are added.
		/// </summary>
		/// <param name="index">Index where to insert the Entity</param>
		/// <param name="entityToAdd">Entity to insert</param>
		public void Insert(int index, IEntity entityToAdd)
		{
			if(!List.Contains(entityToAdd))
			{
				List.Insert(index, entityToAdd);
				if(_isSorted)
				{
					_contentInOriginalOrder.Add(entityToAdd);
				}
				else
				{
					_contentInOriginalOrder.Insert(index, entityToAdd);
				}
				
				if(!_deserializationInProgress)
				{
					if(_containingEntity!=null)
					{
						entityToAdd.SetRelatedEntity(_containingEntity, _containingEntityMappedField);
					}

					OnListChanged(index, ListChangedType.ItemAdded);
				}

				// subscribe to the changed event.
				entityToAdd.EntityContentsChanged +=new EventHandler(EntityInListOnEntityContentsChanged);
			}
		}


		/// <summary>
		/// Remove given IEntity from the list.
		/// </summary>
		/// <param name="entityToRemove">Entity object to remove from list.</param>
		public void Remove(IEntity entityToRemove)
		{
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
			}
		} 


		/// <summary>
		/// Removes the IEntity instance at the index given.
		/// </summary>
		/// <param name="index">Index in list to remove the element.</param>
		public new void RemoveAt(int index)
		{
			IEntity entityToRemove = (IEntity)List[index];

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

			OnListChanged(index, ListChangedType.ItemDeleted);

			// remove subscribtion to the changed event.
			entityToRemove.EntityContentsChanged -= new EventHandler(EntityInListOnEntityContentsChanged);

			base.RemoveAt(index);
		}


		/// <summary>
		/// Returns true if the list contains the given IEntity Object
		/// </summary>
		/// <param name="entityToFind">Entity object to check.</param>
		/// <returns>true if Entity exists in list.</returns>
		public bool Contains(IEntity entityToFind)
		{
			return List.Contains(entityToFind);
		}


		/// <summary>
		/// Performs a clear of the internals and its internal objects.
		/// </summary>
		protected override void OnClear()
		{
			if(!_listOperationInProgress)
			{
				// unset related entity information
				if(_containingEntity!=null)
				{
					for (int i = 0; i < List.Count; i++)
					{
						((IEntity)List[i]).UnsetRelatedEntity(_containingEntity, _containingEntityMappedField);
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
		}



		/// <summary>
		/// Returns index in the list of given IEntity object.
		/// </summary>
		/// <param name="entityToFind">Entity Object to check</param>
		/// <returns>index in list.</returns>
		public int IndexOf(IEntity entityToFind)
		{
			return List.IndexOf(entityToFind);
		}


		/// <summary>
		/// copy the complete list of IEntity objects to an array of IEntity objects.
		/// </summary>
		/// <param name="destination">Array of IEntity Objects wherein the contents of the list will be copied.</param>
		/// <param name="index">Start index to copy from</param>
		public void CopyTo(IEntity[] destination, int index)
		{
			List.CopyTo(destination, index);
		}


		/// <summary>
		/// ITypedList.GetItemProperties implementation. Necessary for Complex databinding. 
		/// </summary>
		/// <param name="listAccessors"></param>
		/// <returns></returns>
		public virtual PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			if((listAccessors==null)||listAccessors.Length==0)
			{
				return _propertyDescriptorFactoryToUse.GetItemProperties(_typeOfDirectInheritor);
			}
			else
			{
				return _propertyDescriptorFactoryToUse.GetItemProperties(listAccessors[listAccessors.Length-1].PropertyType);
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
			info.AddValue("_containingTransaction", null, typeof(ITransaction));
			info.AddValue("_maxNumberOfItemsToReturn", _maxNumberOfItemsToReturn);
			info.AddValue("_sortClauses", _sortClauses, typeof(ISortExpression));
			info.AddValue("_propertyDescriptorFactoryToUse", _propertyDescriptorFactoryToUse);
			info.AddValue("_typeOfDirectInheritor", _typeOfDirectInheritor);
			info.AddValue("_entityFactoryToUse", _entityFactoryToUse);
			info.AddValue("_validatorToUse", _validatorToUse);
			info.AddValue("_suppressClearInGetMulti", _suppressClearInGetMulti);
			info.AddValue("_allowNew", _allowNew);
			info.AddValue("_allowRemove", _allowRemove);
			info.AddValue("_allowEdit", _allowEdit);
			info.AddValue("_containingEntity", _containingEntity, typeof(IEntity));
			info.AddValue("_containingEntityMappedField", _containingEntityMappedField);
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
				IEntityField field = ((IEntity)_contentInOriginalOrder[0]).Fields[property.Name];
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
				IEntity currentEntity = (IEntity)_contentInOriginalOrder[i];
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
				if(((IEntity)List[i]).Fields[property.Name].CurrentValue.Equals(key))
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
		public virtual object AddNew()
		{
			IEntity newEntity = _entityFactoryToUse.Create();
			((EntityBase)newEntity).IsNewViaDataBinding=true;
			((EntityBase)newEntity).ParentCollection=this;
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
		/// Converts the Entities inside this entitycollection into an entity node with inner nodes for each field, which is stored in a generic collection node.
		/// </summary>
		/// <param name="rootNodeName">name of root element to use when building a complete XML representation of this entitycollection.</param>
		/// <returns>a complete xml representation for this entitycollection</returns>
		protected virtual XmlNode ToXml(string rootNodeName)
		{
			XmlDocument xmlDOM = new XmlDocument();

			// add root node
			XmlNode rootNode = xmlDOM.CreateNode(XmlNodeType.Element, rootNodeName, "");

			XmlNode entitiesNode = xmlDOM.CreateNode(XmlNodeType.Element, "Entities", "");
			rootNode.AppendChild(entitiesNode);

			for(int i=0;i<this.Count;i++)
			{
				IEntity entityToEmitInXml = (IEntity)List[i];

				XmlNode nodeToAppend = entityToEmitInXml.ToXml();
				if(nodeToAppend!=null)
				{
					XmlNode importedNode = xmlDOM.ImportNode(nodeToAppend, true);
					entitiesNode.AppendChild(importedNode);
				}
			}

			return rootNode;
		}


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
				EntityBase entity = (EntityBase)List[i];

				XmlNode nodeToAppend = null;
				entity.Entity2Xml("Entity", parentDocument, processedObjectIDs, out nodeToAppend);
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
					if(properties[i].PropertyType.Equals(typeof(IEntityFactory)))
					{
						// .EntityFactoryToUse property
						XmlNode entityFactoryNode = nodeCreator.AddNode(entityCollectionNode, "EntityFactoryToUse");

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
			XmlHelper.SetReadReferencesSS(nodeEntityReferences, processedObjectIDs);
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
								EntityBase referencedEntity = (EntityBase)entityAssembly.CreateInstance(entityTypeName);
								referencedEntity.IsDeserializing=true;
								try
								{
									// convert this entity's xml into data inside this entity
									referencedEntity.Xml2Entity(entityNode, processedObjectIDs, nodeEntityReferences);
									// add to collection.
									this.FastAdd(referencedEntity);
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
							this.EntityFactoryToUse = (IEntityFactory)entityFactoryAssembly.CreateInstance(entityFactoryClassType);
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
			// an entity in the list has changed. Fire the list changed event
			OnListChanged(List.IndexOf((IEntity)sender), ListChangedType.ItemChanged);
		}


		/// <summary>
		/// Inits the class
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method. Complex databinding related.</param>
		/// <param name="typeOfDirectInheritor">Type of direct inheriting class. Used in GetItemProperties method. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call. </param>
		/// <param name="validatorToUse">The validator object to use when new entities are created.</param>
		private void InitClass(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, Type typeOfDirectInheritor, 
				IEntityFactory entityFactoryToUse, IValidator validatorToUse)
		{
			_containingTransaction = null;
			_maxNumberOfItemsToReturn = 0;
			_sortClauses = null;
			_propertyDescriptorFactoryToUse = propertyDescriptorFactoryToUse;
			_typeOfDirectInheritor = typeOfDirectInheritor;
			_entityFactoryToUse = entityFactoryToUse;
			_validatorToUse = validatorToUse;
			_allowNew=true;
			_allowRemove=false;
			_allowEdit=true;
			_allowSorting=false;
			_propertySortedOn = null;
			_isSorted=false;
			_sortDirection = ListSortDirection.Ascending;
			_contentInOriginalOrder = new ArrayList();
			_listOperationInProgress=false;
			_deserializationInProgress = false;
			_suppressClearInGetMulti = false;
			_containingEntity = null;
			_containingEntityMappedField = string.Empty;
		}


		#region Class Property Declarations
		/// <summary>
		/// The <see cref="ITransaction"/> this ITransactionalElement implementing object is participating in. Only valid if
		/// <see cref="ParticipatesInTransaction"/> is true. If set to null, the ITransactionalElement is no longer participating
		/// in a transaction.
		/// </summary>
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
			}
		}

		/// <summary>
		/// Flag to check if the ITransactionalElement implementing object is participating in a transaction or not.
		/// </summary>
		[XmlIgnore]
		public virtual bool ParticipatesInTransaction
		{
			get
			{
				return (_containingTransaction!=null);
			}
		}

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
		/// The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.
		/// </summary>
		[XmlIgnore]
		public long MaxNumberOfItemsToReturn 
		{
			get { return _maxNumberOfItemsToReturn; } 
			set { _maxNumberOfItemsToReturn = value; }
		}
		
		/// <summary>
		/// The order by specifications for the sorting of the resultset when fetching it from the persistent storage.
		/// When not specified, no sorting is applied.
		/// </summary>
		[XmlIgnore]
		public ISortExpression SortClauses 
		{
			get { return _sortClauses; }
			set { _sortClauses = value; }
		}

		/// <summary>
		/// Returns true if this collection contains dirty objects. If this collection contains dirty objects, an 
		/// already filled collection should not be refreshed until a save is performed. This property is calculated in real time
		/// and can be time consuming when the collection contains a lot of objects. Use this property only in cases when the value
		/// of this property is used to do a refetch or not.
		/// </summary>
		[XmlIgnore]
		public bool ContainsDirtyContents
		{
            get 
			{ 
				bool doesContainDirtyEntities = false;
				for(int i=0;i<List.Count;i++)
				{
					doesContainDirtyEntities |= ((IEntity)List[i]).Fields.IsDirty;
				}
				return doesContainDirtyEntities; 
			}
		}

		/// <summary>
		/// The EntityFactory to use when creating entity objects during a GetMulti() call.
		/// </summary>
		public IEntityFactory EntityFactoryToUse 
		{
			get { return _entityFactoryToUse; }
			set { _entityFactoryToUse = value;}
		}

		/// <summary>
		/// Gets / sets the validator object to use when creating entity objects during a GetMulti() call.
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
		/// Surpresses the removal of all contents of the collection in a GetMulti*() call. Used by code in related entities to prevent the removal
		/// of objects when collection properties are accessed.
		/// </summary>
		public bool SuppressClearInGetMulti
		{
			get
			{
				return _suppressClearInGetMulti;
			}
			set
			{
				_suppressClearInGetMulti = value;
			}
		}
		#endregion

	}
}
