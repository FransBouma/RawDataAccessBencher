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
	/// Entity class which represents the entity 'ContactType' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ContactTypeEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private VendorContactCollection	_vendorContact;
		private bool	_alwaysFetchVendorContact, _alreadyFetchedVendorContact;
		private StoreContactCollection	_storeContact;
		private bool	_alwaysFetchStoreContact, _alreadyFetchedStoreContact;
		private ContactCollection _contact_;
		private bool	_alwaysFetchContact_, _alreadyFetchedContact_;
		private VendorCollection _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor;
		private ContactCollection _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact;
		private StoreCollection _store;
		private bool	_alwaysFetchStore, _alreadyFetchedStore;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ContactTypeID changes value. Databinding related.
		/// </summary>
		public event EventHandler ContactTypeIDChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public ContactTypeEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ContactTypeEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		public ContactTypeEntity(System.Int32 contactTypeID)
		{
			InitClassFetch(contactTypeID, new ContactTypeValidator(), new PropertyDescriptorFactory(), new ContactTypeEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="validator">The custom validator object for this ContactTypeEntity</param>
		public ContactTypeEntity(System.Int32 contactTypeID, ContactTypeValidator validator)
		{
			InitClassFetch(contactTypeID, validator, new PropertyDescriptorFactory(), new ContactTypeEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="validator">The custom validator object for this ContactTypeEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ContactTypeEntity(System.Int32 contactTypeID, ContactTypeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(contactTypeID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ContactTypeEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ContactTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_vendorContact = (VendorContactCollection)info.GetValue("_vendorContact", typeof(VendorContactCollection));
			_alwaysFetchVendorContact = info.GetBoolean("_alwaysFetchVendorContact");
			_alreadyFetchedVendorContact = info.GetBoolean("_alreadyFetchedVendorContact");

			_storeContact = (StoreContactCollection)info.GetValue("_storeContact", typeof(StoreContactCollection));
			_alwaysFetchStoreContact = info.GetBoolean("_alwaysFetchStoreContact");
			_alreadyFetchedStoreContact = info.GetBoolean("_alreadyFetchedStoreContact");

			_contact_ = (ContactCollection)info.GetValue("_contact_", typeof(ContactCollection));
			_alwaysFetchContact_ = info.GetBoolean("_alwaysFetchContact_");
			_alreadyFetchedContact_ = info.GetBoolean("_alreadyFetchedContact_");

			_vendor = (VendorCollection)info.GetValue("_vendor", typeof(VendorCollection));
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");

			_contact = (ContactCollection)info.GetValue("_contact", typeof(ContactCollection));
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");

			_store = (StoreCollection)info.GetValue("_store", typeof(StoreCollection));
			_alwaysFetchStore = info.GetBoolean("_alwaysFetchStore");
			_alreadyFetchedStore = info.GetBoolean("_alreadyFetchedStore");


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
			_alreadyFetchedVendorContact = (_vendorContact.Count > 0);
			_alreadyFetchedStoreContact = (_storeContact.Count > 0);
			_alreadyFetchedContact_ = (_contact_.Count > 0);
			_alreadyFetchedVendor = (_vendor.Count > 0);
			_alreadyFetchedContact = (_contact.Count > 0);
			_alreadyFetchedStore = (_store.Count > 0);


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
			info.AddValue("_vendorContact", _vendorContact);
			info.AddValue("_alwaysFetchVendorContact", _alwaysFetchVendorContact);
			info.AddValue("_alreadyFetchedVendorContact", _alreadyFetchedVendorContact);
			info.AddValue("_storeContact", _storeContact);
			info.AddValue("_alwaysFetchStoreContact", _alwaysFetchStoreContact);
			info.AddValue("_alreadyFetchedStoreContact", _alreadyFetchedStoreContact);
			info.AddValue("_contact_", _contact_);
			info.AddValue("_alwaysFetchContact_", _alwaysFetchContact_);
			info.AddValue("_alreadyFetchedContact_", _alreadyFetchedContact_);
			info.AddValue("_vendor", _vendor);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);
			info.AddValue("_contact", _contact);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_store", _store);
			info.AddValue("_alwaysFetchStore", _alwaysFetchStore);
			info.AddValue("_alreadyFetchedStore", _alreadyFetchedStore);


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

				case "VendorContact":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_vendorContact.Add(relatedEntity);
					break;
				case "StoreContact":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_storeContact.Add(relatedEntity);
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

				case "VendorContact":
					// Remove it from the collection.
					_vendorContact.Remove(relatedEntity);
					break;
				case "StoreContact":
					// Remove it from the collection.
					_storeContact.Remove(relatedEntity);
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

			toReturn.Add(_vendorContact);
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
			return base.ToXml("ContactTypeEntity");
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
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactTypeID)
		{
			return Fetch(contactTypeID);
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
			return Fetch(this.ContactTypeID);
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
			ContactTypeDAO dao = DAOFactory.CreateContactTypeDAO();
			bool wasSuccesful = dao.DeleteContactType(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ContactTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public virtual VendorContactCollection GetMultiVendorContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				_vendorContact.GetMultiManyToOne(null, this, null);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public virtual VendorContactCollection GetMultiVendorContact(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				_vendorContact.GetMultiManyToOne(null, this, null, filter);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				_vendorContact.EntityFactoryToUse = entityFactoryToUse;
				_vendorContact.GetMultiManyToOne(null, this, null);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				_vendorContact.EntityFactoryToUse = entityFactoryToUse;
				_vendorContact.GetMultiManyToOne(null, this, null, filter);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'VendorContact'. These settings will be taken into account
		/// when the property VendorContact is requested or GetMultiVendorContact is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorContact.SortClauses=sortClauses;
			_vendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_storeContact.GetMultiManyToOne(null, this, null);
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
				_storeContact.GetMultiManyToOne(null, this, null, filter);
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
				_storeContact.GetMultiManyToOne(null, this, null);
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
				_storeContact.GetMultiManyToOne(null, this, null, filter);
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
		public virtual ContactCollection GetMultiContact_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContact_ || forceFetch || _alwaysFetchContact_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contact_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contact_);
					}
				}
				_contact_.SuppressClearInGetMulti=!forceFetch;
				_contact_.GetMultiManyToManyUsingContactType_(this);
				_contact_.SuppressClearInGetMulti=false;
				_alreadyFetchedContact_ = true;
			}
			return _contact_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactCollection GetMultiContact_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContact_ || forceFetch || _alwaysFetchContact_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contact_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contact_);
					}
				}
				_contact_.SuppressClearInGetMulti=!forceFetch;
				_contact_.EntityFactoryToUse = entityFactoryToUse;
				_contact_.GetMultiManyToManyUsingContactType_(this);
				_contact_.SuppressClearInGetMulti=false;
				_alreadyFetchedContact_ = true;
			}
			return _contact_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Contact_'. These settings will be taken into account
		/// when the property Contact_ is requested or GetMultiContact_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContact_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contact_.SortClauses=sortClauses;
			_contact_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorEntity'</returns>
		public virtual VendorCollection GetMultiVendor(bool forceFetch)
		{
 			if( ( !_alreadyFetchedVendor || forceFetch || _alwaysFetchVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendor);
					}
				}
				_vendor.SuppressClearInGetMulti=!forceFetch;
				_vendor.GetMultiManyToManyUsingContactType(this);
				_vendor.SuppressClearInGetMulti=false;
				_alreadyFetchedVendor = true;
			}
			return _vendor;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorCollection GetMultiVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendor || forceFetch || _alwaysFetchVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendor);
					}
				}
				_vendor.SuppressClearInGetMulti=!forceFetch;
				_vendor.EntityFactoryToUse = entityFactoryToUse;
				_vendor.GetMultiManyToManyUsingContactType(this);
				_vendor.SuppressClearInGetMulti=false;
				_alreadyFetchedVendor = true;
			}
			return _vendor;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Vendor'. These settings will be taken into account
		/// when the property Vendor is requested or GetMultiVendor is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendor.SortClauses=sortClauses;
			_vendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_contact.GetMultiManyToManyUsingContactType(this);
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
				_contact.GetMultiManyToManyUsingContactType(this);
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
		/// Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public virtual StoreCollection GetMultiStore(bool forceFetch)
		{
 			if( ( !_alreadyFetchedStore || forceFetch || _alwaysFetchStore) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_store.ParticipatesInTransaction)
					{
						base.Transaction.Add(_store);
					}
				}
				_store.SuppressClearInGetMulti=!forceFetch;
				_store.GetMultiManyToManyUsingContactType(this);
				_store.SuppressClearInGetMulti=false;
				_alreadyFetchedStore = true;
			}
			return _store;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual StoreCollection GetMultiStore(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedStore || forceFetch || _alwaysFetchStore) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_store.ParticipatesInTransaction)
					{
						base.Transaction.Add(_store);
					}
				}
				_store.SuppressClearInGetMulti=!forceFetch;
				_store.EntityFactoryToUse = entityFactoryToUse;
				_store.GetMultiManyToManyUsingContactType(this);
				_store.SuppressClearInGetMulti=false;
				_alreadyFetchedStore = true;
			}
			return _store;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Store'. These settings will be taken into account
		/// when the property Store is requested or GetMultiStore is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStore(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_store.SortClauses=sortClauses;
			_store.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the ContactTypeIDChanged event, which is thrown when ContactTypeID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnContactTypeIDChanged()
		{
			if(ContactTypeIDChanged!=null)
			{
				ContactTypeIDChanged(this, new EventArgs());
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
			ContactTypeDAO dao = DAOFactory.CreateContactTypeDAO();
			return dao.AddContactType(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ContactTypeDAO dao = DAOFactory.CreateContactTypeDAO();
			return dao.UpdateContactType(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ContactTypeDAO dao = DAOFactory.CreateContactTypeDAO();
			return dao.UpdateContactType(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ContactTypeEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ContactTypeValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ContactTypeEntity</param>
		private void InitClassFetch(System.Int32 contactTypeID, ContactTypeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ContactTypeEntity);
			bool wasSuccesful = Fetch(contactTypeID);
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
			_vendorContact = new VendorContactCollection(propertyDescriptorFactoryToUse, new VendorContactEntityFactory());
			_vendorContact.SetContainingEntityInfo(this, "ContactType");
			_alwaysFetchVendorContact = false;
			_alreadyFetchedVendorContact = false;
			_storeContact = new StoreContactCollection(propertyDescriptorFactoryToUse, new StoreContactEntityFactory());
			_storeContact.SetContainingEntityInfo(this, "ContactType");
			_alwaysFetchStoreContact = false;
			_alreadyFetchedStoreContact = false;
			_contact_ = new ContactCollection(propertyDescriptorFactoryToUse, new ContactEntityFactory());
			_alwaysFetchContact_ = false;
			_alreadyFetchedContact_ = false;
			_vendor = new VendorCollection(propertyDescriptorFactoryToUse, new VendorEntityFactory());
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;
			_contact = new ContactCollection(propertyDescriptorFactoryToUse, new ContactEntityFactory());
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_store = new StoreCollection(propertyDescriptorFactoryToUse, new StoreEntityFactory());
			_alwaysFetchStore = false;
			_alreadyFetchedStore = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="contactTypeID">PK value for ContactType which data should be fetched into this ContactType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 contactTypeID)
		{
			ContactTypeDAO dao = DAOFactory.CreateContactTypeDAO();

			// Load EntityFields of ContactType
			dao.FetchContactType(base.Fields, base.Transaction, contactTypeID);

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
		public static ContactTypeRelations Relations
		{
			get	{ return new ContactTypeRelations(); }
		}

	
		/// <summary>
		/// The ContactTypeID property of the Entity ContactType
		/// </summary>
		public virtual System.Int32 ContactTypeID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactTypeFieldIndex.ContactTypeID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ContactTypeID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactTypeFieldIndex.ContactTypeID, value))
				{
					OnContactTypeIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity ContactType
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactTypeFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactTypeFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity ContactType
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactTypeFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactTypeFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual VendorContactCollection VendorContact
		{
			get
			{
				return GetMultiVendorContact(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for VendorContact. When set to true, VendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorContact(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorContact
		{
			get
			{
				return _alwaysFetchVendorContact;
			}
			set
			{
				_alwaysFetchVendorContact = value;
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContact_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ContactCollection Contact_
		{
			get
			{
				return GetMultiContact_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Contact_. When set to true, Contact_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiContact_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContact_
		{
			get
			{
				return _alwaysFetchContact_;
			}
			set
			{
				_alwaysFetchContact_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual VendorCollection Vendor
		{
			get
			{
				return GetMultiVendor(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Vendor. When set to true, Vendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendor(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchVendor
		{
			get
			{
				return _alwaysFetchVendor;
			}
			set
			{
				_alwaysFetchVendor = value;
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
		/// Retrieves all related entities of type 'StoreEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStore()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual StoreCollection Store
		{
			get
			{
				return GetMultiStore(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Store. When set to true, Store is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Store is accessed. You can always execute
		/// a forced fetch by calling GetMultiStore(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchStore
		{
			get
			{
				return _alwaysFetchStore;
			}
			set
			{
				_alwaysFetchStore = value;
			}	
		}
	
	
	
		#endregion
	}
}
