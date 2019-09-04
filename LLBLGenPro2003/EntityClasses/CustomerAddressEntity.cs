///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//
// Do not try to run this code on another version of the database than the database
// which was used to generate this code. This means that when you used f.e. SqlServer 2000
// to generate this code, it is likely that you will not be able to use that code on
// SqlServer 7 due to SQL syntax mismatches. Most code is generic code which will work
// with any database, but some code relies on a specific database type/vendor/version used. 
// This code is located in the DaoClasses which target a specific specified database. Also all
// classes target a specific specified Dynamic Query Engine (DQE) in the using/imports
// directives. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2003.1
// Code is generated on: woensdag 4 september 2019 12:09:45
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Data;

using LLBL2003.AdventureWorks2008;
using LLBL2003.AdventureWorks2008.FactoryClasses;
using LLBL2003.AdventureWorks2008.CollectionClasses;
using LLBL2003.AdventureWorks2008.DaoClasses;
using LLBL2003.AdventureWorks2008.RelationClasses;
using LLBL2003.AdventureWorks2008.ValidatorClasses;
using LLBL2003.AdventureWorks2008.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.EntityClasses
{
	/// <summary>
	/// Entity class which represents the entity 'CustomerAddress' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class CustomerAddressEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations


		private AddressEntity _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private AddressTypeEntity _addressType;
		private bool	_alwaysFetchAddressType, _alreadyFetchedAddressType;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when CustomerID changes value. Databinding related.
		/// </summary>
		public event EventHandler CustomerIDChanged;

		/// <summary>
		/// Event which is thrown when AddressID changes value. Databinding related.
		/// </summary>
		public event EventHandler AddressIDChanged;

		/// <summary>
		/// Event which is thrown when AddressTypeID changes value. Databinding related.
		/// </summary>
		public event EventHandler AddressTypeIDChanged;

		/// <summary>
		/// Event which is thrown when Rowguid changes value. Databinding related.
		/// </summary>
		public event EventHandler RowguidChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public CustomerAddressEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new CustomerAddressEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		public CustomerAddressEntity(System.Int32 customerID, System.Int32 addressID)
		{
			InitClassFetch(customerID, addressID, new CustomerAddressValidator(), new PropertyDescriptorFactory(), new CustomerAddressEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="validator">The custom validator object for this CustomerAddressEntity</param>
		public CustomerAddressEntity(System.Int32 customerID, System.Int32 addressID, CustomerAddressValidator validator)
		{
			InitClassFetch(customerID, addressID, validator, new PropertyDescriptorFactory(), new CustomerAddressEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="validator">The custom validator object for this CustomerAddressEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CustomerAddressEntity(System.Int32 customerID, System.Int32 addressID, CustomerAddressValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(customerID, addressID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CustomerAddressEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private CustomerAddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_address = (AddressEntity)info.GetValue("_address", typeof(AddressEntity));
			if(_address!=null)
			{
				// rewire event handler.
				_address.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");
			_addressType = (AddressTypeEntity)info.GetValue("_addressType", typeof(AddressTypeEntity));
			if(_addressType!=null)
			{
				// rewire event handler.
				_addressType.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchAddressType = info.GetBoolean("_alwaysFetchAddressType");
			_alreadyFetchedAddressType = info.GetBoolean("_alreadyFetchedAddressType");
			_customer = (CustomerEntity)info.GetValue("_customer", typeof(CustomerEntity));
			if(_customer!=null)
			{
				// rewire event handler.
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

		}
		
		
		/// <summary>
		/// Will perform post-ReadXml actions as well as the normal ReadXml() actions, performed by the base class.
		/// </summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element
		/// of the entity's Xml data</param>
		public override void ReadXml(System.Xml.XmlNode node)
		{
			base.ReadXml (node);

			// walk the contained data objects to see if they're fetched. If so, set the flags to true.


			_alreadyFetchedAddress = (_address != null);
			_alreadyFetchedAddressType = (_addressType != null);
			_alreadyFetchedCustomer = (_customer != null);

		}

		
		/// <summary>
		/// Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		/// predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		/// concurrency checks, like checks on timestamp column values.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <remarks>Do not call this routine directly, use the overloaded version in a derived class as this version doesn't construct a
		/// local transaction during recursive save, this is done in the overloaded version in a derived class.</remarks>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public override bool Save(IPredicate updateRestriction, bool recurse)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;

			if(recurse)
			{
				if(!base.ParticipatesInTransaction)
				{
					// Start local transaction
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "SaveRecursively");
					// Add ourselves
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				// perform the save action(s)
				bool result = base.Save(updateRestriction, recurse);

				// only commit a transaction which is started here.
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}

				return result;
			}
			catch
			{
				// exception caught. roll back a transaction started here.
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				// bubble exception 
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
			}
		}


		/// <summary>
		/// ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize
		/// the rest.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{


			info.AddValue("_address", _address);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_addressType", _addressType);
			info.AddValue("_alwaysFetchAddressType", _alwaysFetchAddressType);
			info.AddValue("_alreadyFetchedAddressType", _alreadyFetchedAddressType);
			info.AddValue("_customer", _customer);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);

			base.GetObjectData(info, context);
		}


		/// <summary>
		/// Sets the internal parameter related to the fieldname passed to the instance relatedEntity. 
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Address":
					SetupSyncAddress(relatedEntity);
					break;
				case "AddressType":
					SetupSyncAddressType(relatedEntity);
					break;
				case "Customer":
					SetupSyncCustomer(relatedEntity);
					break;


				default:
					// do nothing
					break;
			}
		}
		
		
		/// <summary>
		/// Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() 
		/// </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Address":
					DesetupSyncAddress(false);
					break;
				case "AddressType":
					DesetupSyncAddressType(false);
					break;
				case "Customer":
					DesetupSyncCustomer(false);
					break;


				default:
					// do nothing
					break;
			}
		}


		/// <summary>
		/// Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.
		/// </summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override ArrayList GetDependingRelatedEntities()
		{
			ArrayList toReturn = new ArrayList();


			return toReturn;
		}
		
		
		/// <summary>
		/// Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.
		/// </summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override ArrayList GetDependentRelatedEntities()
		{
			ArrayList toReturn = new ArrayList();

			// each related entity which is dirty, is added to the collection, and will be saved first.
			if(_address!=null)
			{
				toReturn.Add(_address);
			}
			if(_addressType!=null)
			{
				toReturn.Add(_addressType);
			}
			if(_customer!=null)
			{
				toReturn.Add(_customer);
			}

			return toReturn;
		}
		
		
		/// <summary>
		/// Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.
		/// </summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();


		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("CustomerAddressEntity");
		}


		/// <summary>
		/// Returns a unique hashcode for this entity which is unique for this type. It is based on the primary key values
		/// of this entity. If no primary key values are available, the hashcode of the object is returned.
		/// </summary>
		/// <returns>unique hashcode based on the values of the primary key values of this entity</returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

	
	
		/// <summary>
		/// Fetches the contents of this entity from the persistent storage using the primary key.
		/// </summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID, System.Int32 addressID)
		{
			return Fetch(customerID, addressID);
		}


		/// <summary>
		/// Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. 
		/// </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		/// <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public override bool Refetch()
		{
			return Fetch(this.CustomerID, this.AddressID);
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
		public override bool Delete(IPredicate deleteRestriction)
		{
			CustomerAddressDAO dao = DAOFactory.CreateCustomerAddressDAO();
			bool wasSuccesful = dao.DeleteCustomerAddress(base.Fields, base.Transaction, deleteRestriction);
			if(wasSuccesful)
			{
				base.Delete(deleteRestriction);
			}
			return wasSuccesful;
		}
	

		/// <summary>
		/// Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, because the current value can't be set to NULL.
		/// If the current value for the field with the index fieldIndex is set to <i>null</i>, you can simply test
		/// against <i>null</i> to see if the <i>current value</i> of the field is null. 
		/// </summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(CustomerAddressFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
	
	
		/// <summary>
		/// Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress()
		{
			return GetSingleAddress(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				AddressEntity newEntity = new AddressEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.AddressID);
				this.Address = newEntity;

				_alreadyFetchedAddress = true;
			}
			return _address;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'AddressTypeEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'AddressTypeEntity' which is related to this entity.</returns>
		public virtual AddressTypeEntity GetSingleAddressType()
		{
			return GetSingleAddressType(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'AddressTypeEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressTypeEntity' which is related to this entity.</returns>
		public virtual AddressTypeEntity GetSingleAddressType(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddressType || forceFetch || _alwaysFetchAddressType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				AddressTypeEntity newEntity = new AddressTypeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.AddressTypeID);
				this.AddressType = newEntity;

				_alreadyFetchedAddressType = true;
			}
			return _addressType;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomer()
		{
			return GetSingleCustomer(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'CustomerEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomer(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				CustomerEntity newEntity = new CustomerEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.CustomerID);
				this.Customer = newEntity;

				_alreadyFetchedCustomer = true;
			}
			return _customer;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the CustomerIDChanged event, which is thrown when CustomerID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCustomerIDChanged()
		{
			if(CustomerIDChanged!=null)
			{
				CustomerIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the AddressIDChanged event, which is thrown when AddressID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnAddressIDChanged()
		{
			if(AddressIDChanged!=null)
			{
				AddressIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the AddressTypeIDChanged event, which is thrown when AddressTypeID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnAddressTypeIDChanged()
		{
			if(AddressTypeIDChanged!=null)
			{
				AddressTypeIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the RowguidChanged event, which is thrown when Rowguid changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnRowguidChanged()
		{
			if(RowguidChanged!=null)
			{
				RowguidChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ModifiedDateChanged event, which is thrown when ModifiedDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnModifiedDateChanged()
		{
			if(ModifiedDateChanged!=null)
			{
				ModifiedDateChanged(this, new EventArgs());
			}
		}
	
		#endregion


		/// <summary>
		/// Event handler which is called by a related entity after that entity is persisted.
		/// </summary>
		/// <param name="sender">IEntity instance</param>
		/// <param name="e"></param>
		protected virtual void OnEntityAfterSave(object sender, EventArgs e)
		{
			IEntity persistedEntity = (IEntity)sender;

			ArrayList entitySyncInfos = new ArrayList(((Hashtable)base.GetEntitySyncInformation(persistedEntity)).Values);
			for (int i = 0; i < entitySyncInfos.Count; i++)
			{
				EntitySyncInfoSS currentSyncInfo = (EntitySyncInfoSS)entitySyncInfos[i];
				base.SyncFKFields(currentSyncInfo.Relation, currentSyncInfo.DataSupplyingEntity);
			}
		}


		/// <summary>
		/// Performs the insert action of a new Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			CustomerAddressDAO dao = DAOFactory.CreateCustomerAddressDAO();
			return dao.AddCustomerAddress(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CustomerAddressDAO dao = DAOFactory.CreateCustomerAddressDAO();
			return dao.UpdateCustomerAddress(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CustomerAddressDAO dao = DAOFactory.CreateCustomerAddressDAO();
			return dao.UpdateCustomerAddress(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.CustomerAddressEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new CustomerAddressValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this CustomerAddressEntity</param>
		private void InitClassFetch(System.Int32 customerID, System.Int32 addressID, CustomerAddressValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.CustomerAddressEntity);
			bool wasSuccesful = Fetch(customerID, addressID);
			base.IsNew = !wasSuccesful;
			base.Validator = validator;
			base.EntityFactoryToUse = entityFactoryToUse;
		}
	

		/// <summary>
		/// Initializes the class members
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassMembers(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{


			_address = null;
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_addressType = null;
			_alwaysFetchAddressType = false;
			_alreadyFetchedAddressType = false;
			_customer = null;
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;

		}


		/// <summary>
		/// Removes the sync logic for member _address
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncAddress(bool signalRelatedEntity)
		{
			if(_address != null)
			{
				// disconnect the entity from this entity
				_address.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_address.UnsetRelatedEntity(this, "CustomerAddress");
				}
				base.UnsetEntitySyncInformation("Address", _address, CustomerAddressEntity.Relations.AddressEntityUsingAddressID);
				_address = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _address
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress(IEntity relatedEntity)
		{
			DesetupSyncAddress(true);
			
			if(relatedEntity!=null)
			{
				_address = (AddressEntity)relatedEntity;
				_address.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Address", _address, CustomerAddressEntity.Relations.AddressEntityUsingAddressID);
				if(!_address.IsNew)
				{
					// sync now
					base.SyncFKFields(CustomerAddressEntity.Relations.AddressEntityUsingAddressID, _address);
				}
			}

			_alreadyFetchedAddress = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _addressType
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncAddressType(bool signalRelatedEntity)
		{
			if(_addressType != null)
			{
				// disconnect the entity from this entity
				_addressType.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_addressType.UnsetRelatedEntity(this, "CustomerAddress");
				}
				base.UnsetEntitySyncInformation("AddressType", _addressType, CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID);
				_addressType = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _addressType
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddressType(IEntity relatedEntity)
		{
			DesetupSyncAddressType(true);
			
			if(relatedEntity!=null)
			{
				_addressType = (AddressTypeEntity)relatedEntity;
				_addressType.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("AddressType", _addressType, CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID);
				if(!_addressType.IsNew)
				{
					// sync now
					base.SyncFKFields(CustomerAddressEntity.Relations.AddressTypeEntityUsingAddressTypeID, _addressType);
				}
			}

			_alreadyFetchedAddressType = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _customer
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCustomer(bool signalRelatedEntity)
		{
			if(_customer != null)
			{
				// disconnect the entity from this entity
				_customer.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_customer.UnsetRelatedEntity(this, "CustomerAddress");
				}
				base.UnsetEntitySyncInformation("Customer", _customer, CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID);
				_customer = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _customer
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomer(IEntity relatedEntity)
		{
			DesetupSyncCustomer(true);
			
			if(relatedEntity!=null)
			{
				_customer = (CustomerEntity)relatedEntity;
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Customer", _customer, CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID);
				if(!_customer.IsNew)
				{
					// sync now
					base.SyncFKFields(CustomerAddressEntity.Relations.CustomerEntityUsingCustomerID, _customer);
				}
			}

			_alreadyFetchedCustomer = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="customerID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <param name="addressID">PK value for CustomerAddress which data should be fetched into this CustomerAddress object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 customerID, System.Int32 addressID)
		{
			CustomerAddressDAO dao = DAOFactory.CreateCustomerAddressDAO();

			// Load EntityFields of CustomerAddress
			dao.FetchCustomerAddress(base.Fields, base.Transaction, customerID, addressID);

			bool fetchResult = false;
			if(base.Fields.State == EntityState.Fetched)
			{
				base.IsNew = false;
				fetchResult = true;
			}

			return fetchResult;
		}
	
	
		#region Class Property Declarations
		/// <summary>
		/// The relations object holding all relations of this entity with other entity classes.
		/// </summary>
		public static CustomerAddressRelations Relations
		{
			get	{ return new CustomerAddressRelations(); }
		}

	
		/// <summary>
		/// The CustomerID property of the Entity CustomerAddress
		/// </summary>
		public virtual System.Int32 CustomerID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerAddressFieldIndex.CustomerID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CustomerID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerAddressFieldIndex.CustomerID, value))
				{
					OnCustomerIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The AddressID property of the Entity CustomerAddress
		/// </summary>
		public virtual System.Int32 AddressID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerAddressFieldIndex.AddressID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AddressID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerAddressFieldIndex.AddressID, value))
				{
					OnAddressIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The AddressTypeID property of the Entity CustomerAddress
		/// </summary>
		public virtual System.Int32 AddressTypeID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerAddressFieldIndex.AddressTypeID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AddressTypeID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerAddressFieldIndex.AddressTypeID, value))
				{
					OnAddressTypeIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity CustomerAddress
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerAddressFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerAddressFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity CustomerAddress
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerAddressFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerAddressFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
	
	
		/// <summary>
		/// Gets / sets related entity of type 'AddressEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressEntity Address
		{
			get
			{
				return GetSingleAddress(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddress(value);
				}
				else
				{
					if(value==null)
					{
						if(_address != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_address.UnsetRelatedEntity(this, "CustomerAddress");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "CustomerAddress");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Address. When set to true, Address is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddress(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress
		{
			get
			{
				return _alwaysFetchAddress;
			}
			set
			{
				_alwaysFetchAddress = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'AddressTypeEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddressType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressTypeEntity AddressType
		{
			get
			{
				return GetSingleAddressType(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddressType(value);
				}
				else
				{
					if(value==null)
					{
						if(_addressType != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_addressType.UnsetRelatedEntity(this, "CustomerAddress");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "CustomerAddress");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for AddressType. When set to true, AddressType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressType is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddressType(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressType
		{
			get
			{
				return _alwaysFetchAddressType;
			}
			set
			{
				_alwaysFetchAddressType = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'CustomerEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCustomer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CustomerEntity Customer
		{
			get
			{
				return GetSingleCustomer(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCustomer(value);
				}
				else
				{
					if(value==null)
					{
						if(_customer != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_customer.UnsetRelatedEntity(this, "CustomerAddress");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "CustomerAddress");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Customer. When set to true, Customer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer is accessed. You can always execute
		/// a forced fetch by calling GetSingleCustomer(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomer
		{
			get
			{
				return _alwaysFetchCustomer;
			}
			set
			{
				_alwaysFetchCustomer = value;
			}	
		}
	
	
		#endregion
	}
}
