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
	/// Entity class which represents the entity 'Store' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class StoreEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private StoreContactCollection	_storeContact;
		private bool	_alwaysFetchStoreContact, _alreadyFetchedStoreContact;
		private ContactCollection _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact;
		private ContactTypeCollection _contactType;
		private bool	_alwaysFetchContactType, _alreadyFetchedContactType;
		private SalesPersonEntity _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer;
		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when CustomerID changes value. Databinding related.
		/// </summary>
		public event EventHandler CustomerIDChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

		/// <summary>
		/// Event which is thrown when SalesPersonID changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesPersonIDChanged;

		/// <summary>
		/// Event which is thrown when Demographics changes value. Databinding related.
		/// </summary>
		public event EventHandler DemographicsChanged;

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
		public StoreEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new StoreEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		public StoreEntity(System.Int32 customerID)
		{
			InitClassFetch(customerID, new StoreValidator(), new PropertyDescriptorFactory(), new StoreEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="validator">The custom validator object for this StoreEntity</param>
		public StoreEntity(System.Int32 customerID, StoreValidator validator)
		{
			InitClassFetch(customerID, validator, new PropertyDescriptorFactory(), new StoreEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="validator">The custom validator object for this StoreEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public StoreEntity(System.Int32 customerID, StoreValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(customerID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public StoreEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private StoreEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_storeContact = (StoreContactCollection)info.GetValue("_storeContact", typeof(StoreContactCollection));
			_alwaysFetchStoreContact = info.GetBoolean("_alwaysFetchStoreContact");
			_alreadyFetchedStoreContact = info.GetBoolean("_alreadyFetchedStoreContact");

			_contact = (ContactCollection)info.GetValue("_contact", typeof(ContactCollection));
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");

			_contactType = (ContactTypeCollection)info.GetValue("_contactType", typeof(ContactTypeCollection));
			_alwaysFetchContactType = info.GetBoolean("_alwaysFetchContactType");
			_alreadyFetchedContactType = info.GetBoolean("_alreadyFetchedContactType");
			_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
			if(_salesPerson!=null)
			{
				// rewire event handler.
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");
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
			_alreadyFetchedStoreContact = (_storeContact.Count > 0);
			_alreadyFetchedContact = (_contact.Count > 0);
			_alreadyFetchedContactType = (_contactType.Count > 0);
			_alreadyFetchedSalesPerson = (_salesPerson != null);
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
			info.AddValue("_storeContact", _storeContact);
			info.AddValue("_alwaysFetchStoreContact", _alwaysFetchStoreContact);
			info.AddValue("_alreadyFetchedStoreContact", _alreadyFetchedStoreContact);
			info.AddValue("_contact", _contact);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_contactType", _contactType);
			info.AddValue("_alwaysFetchContactType", _alwaysFetchContactType);
			info.AddValue("_alreadyFetchedContactType", _alreadyFetchedContactType);
			info.AddValue("_salesPerson", _salesPerson);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
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
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
					break;
				case "StoreContact":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_storeContact.Add(relatedEntity);
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
				case "SalesPerson":
					DesetupSyncSalesPerson(false);
					break;
				case "StoreContact":
					// Remove it from the collection.
					_storeContact.Remove(relatedEntity);
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
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
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

			toReturn.Add(_storeContact);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("StoreEntity");
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
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 customerID)
		{
			return Fetch(customerID);
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
			return Fetch(this.CustomerID);
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
			StoreDAO dao = DAOFactory.CreateStoreDAO();
			bool wasSuccesful = dao.DeleteStore(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(StoreFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreContactEntity'</returns>
		public virtual StoreContactCollection GetMultiStoreContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedStoreContact || forceFetch || _alwaysFetchStoreContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_storeContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_storeContact);
					}
				}
				_storeContact.SuppressClearInGetMulti=!forceFetch;
				_storeContact.GetMultiManyToOne(null, null, this);
				_storeContact.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreContact = true;
			}
			return _storeContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StoreContactEntity'</returns>
		public virtual StoreContactCollection GetMultiStoreContact(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStoreContact || forceFetch || _alwaysFetchStoreContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_storeContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_storeContact);
					}
				}
				_storeContact.SuppressClearInGetMulti=!forceFetch;
				_storeContact.GetMultiManyToOne(null, null, this, filter);
				_storeContact.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreContact = true;
			}
			return _storeContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual StoreContactCollection GetMultiStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedStoreContact || forceFetch || _alwaysFetchStoreContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_storeContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_storeContact);
					}
				}
				_storeContact.SuppressClearInGetMulti=!forceFetch;
				_storeContact.EntityFactoryToUse = entityFactoryToUse;
				_storeContact.GetMultiManyToOne(null, null, this);
				_storeContact.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreContact = true;
			}
			return _storeContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual StoreContactCollection GetMultiStoreContact(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStoreContact || forceFetch || _alwaysFetchStoreContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_storeContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_storeContact);
					}
				}
				_storeContact.SuppressClearInGetMulti=!forceFetch;
				_storeContact.EntityFactoryToUse = entityFactoryToUse;
				_storeContact.GetMultiManyToOne(null, null, this, filter);
				_storeContact.SuppressClearInGetMulti=false;
				_alreadyFetchedStoreContact = true;
			}
			return _storeContact;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'StoreContact'. These settings will be taken into account
		/// when the property StoreContact is requested or GetMultiStoreContact is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStoreContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_storeContact.SortClauses=sortClauses;
			_storeContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public virtual ContactCollection GetMultiContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contact);
					}
				}
				_contact.SuppressClearInGetMulti=!forceFetch;
				_contact.GetMultiManyToManyUsingStore(this);
				_contact.SuppressClearInGetMulti=false;
				_alreadyFetchedContact = true;
			}
			return _contact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactCollection GetMultiContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contact);
					}
				}
				_contact.SuppressClearInGetMulti=!forceFetch;
				_contact.EntityFactoryToUse = entityFactoryToUse;
				_contact.GetMultiManyToManyUsingStore(this);
				_contact.SuppressClearInGetMulti=false;
				_alreadyFetchedContact = true;
			}
			return _contact;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Contact'. These settings will be taken into account
		/// when the property Contact is requested or GetMultiContact is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contact.SortClauses=sortClauses;
			_contact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactTypeEntity'</returns>
		public virtual ContactTypeCollection GetMultiContactType(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContactType || forceFetch || _alwaysFetchContactType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactType);
					}
				}
				_contactType.SuppressClearInGetMulti=!forceFetch;
				_contactType.GetMultiManyToManyUsingStore(this);
				_contactType.SuppressClearInGetMulti=false;
				_alreadyFetchedContactType = true;
			}
			return _contactType;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactTypeCollection GetMultiContactType(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactType || forceFetch || _alwaysFetchContactType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactType);
					}
				}
				_contactType.SuppressClearInGetMulti=!forceFetch;
				_contactType.EntityFactoryToUse = entityFactoryToUse;
				_contactType.GetMultiManyToManyUsingStore(this);
				_contactType.SuppressClearInGetMulti=false;
				_alreadyFetchedContactType = true;
			}
			return _contactType;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ContactType'. These settings will be taken into account
		/// when the property ContactType is requested or GetMultiContactType is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactType(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactType.SortClauses=sortClauses;
			_contactType.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
		/// <summary>
		/// Retrieves the related entity of type 'SalesPersonEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public virtual SalesPersonEntity GetSingleSalesPerson()
		{
			return GetSingleSalesPerson(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'SalesPersonEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public virtual SalesPersonEntity GetSingleSalesPerson(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				SalesPersonEntity newEntity = new SalesPersonEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.SalesPersonID);
				this.SalesPerson = newEntity;

				_alreadyFetchedSalesPerson = true;
			}
			return _salesPerson;
		}
	
	
		/// <summary>
		/// Retrieves the related entity of type 'CustomerEntity', using a relation of type '1:1'
		/// </summary>
		/// <returns>A fetched entity of type 'CustomerEntity' which is related to this entity.</returns>
		public virtual CustomerEntity GetSingleCustomer()
		{
			return GetSingleCustomer(false);
		}
		
		
		/// <summary>
		/// Retrieves the related entity of type 'CustomerEntity', using a relation of type '1:1'
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
				
				// fetch using PK
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
		/// Event thrower for the NameChanged event, which is thrown when Name changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnNameChanged()
		{
			if(NameChanged!=null)
			{
				NameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SalesPersonIDChanged event, which is thrown when SalesPersonID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSalesPersonIDChanged()
		{
			if(SalesPersonIDChanged!=null)
			{
				SalesPersonIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DemographicsChanged event, which is thrown when Demographics changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDemographicsChanged()
		{
			if(DemographicsChanged!=null)
			{
				DemographicsChanged(this, new EventArgs());
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
			StoreDAO dao = DAOFactory.CreateStoreDAO();
			return dao.AddStore(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			StoreDAO dao = DAOFactory.CreateStoreDAO();
			return dao.UpdateStore(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			StoreDAO dao = DAOFactory.CreateStoreDAO();
			return dao.UpdateStore(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.StoreEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new StoreValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this StoreEntity</param>
		private void InitClassFetch(System.Int32 customerID, StoreValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.StoreEntity);
			bool wasSuccesful = Fetch(customerID);
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
			_storeContact = new StoreContactCollection(propertyDescriptorFactoryToUse, new StoreContactEntityFactory());
			_storeContact.SetContainingEntityInfo(this, "Store");
			_alwaysFetchStoreContact = false;
			_alreadyFetchedStoreContact = false;
			_contact = new ContactCollection(propertyDescriptorFactoryToUse, new ContactEntityFactory());
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_contactType = new ContactTypeCollection(propertyDescriptorFactoryToUse, new ContactTypeEntityFactory());
			_alwaysFetchContactType = false;
			_alreadyFetchedContactType = false;
			_salesPerson = null;
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
			_customer = null;
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;
		}


		/// <summary>
		/// Removes the sync logic for member _salesPerson
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncSalesPerson(bool signalRelatedEntity)
		{
			if(_salesPerson != null)
			{
				// disconnect the entity from this entity
				_salesPerson.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_salesPerson.UnsetRelatedEntity(this, "Store");
				}
				base.UnsetEntitySyncInformation("SalesPerson", _salesPerson, StoreEntity.Relations.SalesPersonEntityUsingSalesPersonID);
				_salesPerson = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _salesPerson
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesPerson(IEntity relatedEntity)
		{
			DesetupSyncSalesPerson(true);
			
			if(relatedEntity!=null)
			{
				_salesPerson = (SalesPersonEntity)relatedEntity;
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("SalesPerson", _salesPerson, StoreEntity.Relations.SalesPersonEntityUsingSalesPersonID);
				if(!_salesPerson.IsNew)
				{
					// sync now
					base.SyncFKFields(StoreEntity.Relations.SalesPersonEntityUsingSalesPersonID, _salesPerson);
				}
			}

			_alreadyFetchedSalesPerson = (relatedEntity != null);
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
				if(signalRelatedEntity)
				{
					_customer.UnsetRelatedEntity(this, "Store");
				}

				_customer.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Customer", _customer, StoreEntity.Relations.CustomerEntityUsingCustomerID);

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
				base.SetEntitySyncInformation("Customer", _customer, StoreEntity.Relations.CustomerEntityUsingCustomerID);
				if(!_customer.IsNew)
				{
					// sync now
					base.SyncFKFields(StoreEntity.Relations.CustomerEntityUsingCustomerID, _customer);
				}

			}

			_alreadyFetchedCustomer = (relatedEntity != null);
		}


	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="customerID">PK value for Store which data should be fetched into this Store object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 customerID)
		{
			StoreDAO dao = DAOFactory.CreateStoreDAO();

			// Load EntityFields of Store
			dao.FetchStore(base.Fields, base.Transaction, customerID);

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
		public static StoreRelations Relations
		{
			get	{ return new StoreRelations(); }
		}

	
		/// <summary>
		/// The CustomerID property of the Entity Store
		/// </summary>
		public virtual System.Int32 CustomerID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StoreFieldIndex.CustomerID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CustomerID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)StoreFieldIndex.CustomerID, value))
				{
					OnCustomerIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity Store
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StoreFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)StoreFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesPersonID property of the Entity Store
		/// </summary>
		public virtual System.Int32 SalesPersonID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StoreFieldIndex.SalesPersonID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesPersonID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)StoreFieldIndex.SalesPersonID, value))
				{
					OnSalesPersonIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Demographics property of the Entity Store
		/// </summary>
		public virtual System.String Demographics
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StoreFieldIndex.Demographics);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Demographics because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)StoreFieldIndex.Demographics, value))
				{
					OnDemographicsChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity Store
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StoreFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)StoreFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity Store
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)StoreFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)StoreFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'StoreContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStoreContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual StoreContactCollection StoreContact
		{
			get
			{
				return GetMultiStoreContact(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for StoreContact. When set to true, StoreContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StoreContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiStoreContact(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchStoreContact
		{
			get
			{
				return _alwaysFetchStoreContact;
			}
			set
			{
				_alwaysFetchStoreContact = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ContactCollection Contact
		{
			get
			{
				return GetMultiContact(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContact(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContact
		{
			get
			{
				return _alwaysFetchContact;
			}
			set
			{
				_alwaysFetchContact = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ContactTypeCollection ContactType
		{
			get
			{
				return GetMultiContactType(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ContactType. When set to true, ContactType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactType is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactType(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContactType
		{
			get
			{
				return _alwaysFetchContactType;
			}
			set
			{
				_alwaysFetchContactType = value;
			}	
		}
	
	
		/// <summary>
		/// Gets / sets related entity of type 'SalesPersonEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesPerson()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get
			{
				return GetSingleSalesPerson(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesPerson(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesPerson != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_salesPerson.UnsetRelatedEntity(this, "Store");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "Store");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesPerson. When set to true, SalesPerson is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesPerson(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPerson
		{
			get
			{
				return _alwaysFetchSalesPerson;
			}
			set
			{
				_alwaysFetchSalesPerson = value;
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
						// unset the sync info with the old value set for Customer. because we specify 'true', this will 
						// result in the signaling of the current value of Customer that the sync info has ended, as well.
						DesetupSyncCustomer(true);
					}
					else
					{
						// Tell related entity its related to us.
						IEntity relatedEntity = (IEntity)value;
						relatedEntity.SetRelatedEntity(this, "Store");
						// set up syncing information to this new entity. Will take care of current entity.
						SetupSyncCustomer(relatedEntity);
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
