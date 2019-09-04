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
	/// Entity class which represents the entity 'Contact' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ContactEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private EmployeeCollection	_employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee;
		private VendorContactCollection	_vendorContact;
		private bool	_alwaysFetchVendorContact, _alreadyFetchedVendorContact;
		private ContactCreditCardCollection	_contactCreditCard;
		private bool	_alwaysFetchContactCreditCard, _alreadyFetchedContactCreditCard;
		private IndividualCollection	_individual;
		private bool	_alwaysFetchIndividual, _alreadyFetchedIndividual;
		private StoreContactCollection	_storeContact;
		private bool	_alwaysFetchStoreContact, _alreadyFetchedStoreContact;
		private EmployeeCollection _employee_;
		private bool	_alwaysFetchEmployee_, _alreadyFetchedEmployee_;
		private ContactTypeCollection _contactType_;
		private bool	_alwaysFetchContactType_, _alreadyFetchedContactType_;
		private VendorCollection _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor;
		private CreditCardCollection _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard;
		private ContactTypeCollection _contactType;
		private bool	_alwaysFetchContactType, _alreadyFetchedContactType;
		private StoreCollection _store;
		private bool	_alwaysFetchStore, _alreadyFetchedStore;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ContactID changes value. Databinding related.
		/// </summary>
		public event EventHandler ContactIDChanged;

		/// <summary>
		/// Event which is thrown when NameStyle changes value. Databinding related.
		/// </summary>
		public event EventHandler NameStyleChanged;

		/// <summary>
		/// Event which is thrown when Title changes value. Databinding related.
		/// </summary>
		public event EventHandler TitleChanged;

		/// <summary>
		/// Event which is thrown when FirstName changes value. Databinding related.
		/// </summary>
		public event EventHandler FirstNameChanged;

		/// <summary>
		/// Event which is thrown when MiddleName changes value. Databinding related.
		/// </summary>
		public event EventHandler MiddleNameChanged;

		/// <summary>
		/// Event which is thrown when LastName changes value. Databinding related.
		/// </summary>
		public event EventHandler LastNameChanged;

		/// <summary>
		/// Event which is thrown when Suffix changes value. Databinding related.
		/// </summary>
		public event EventHandler SuffixChanged;

		/// <summary>
		/// Event which is thrown when EmailAddress changes value. Databinding related.
		/// </summary>
		public event EventHandler EmailAddressChanged;

		/// <summary>
		/// Event which is thrown when EmailPromotion changes value. Databinding related.
		/// </summary>
		public event EventHandler EmailPromotionChanged;

		/// <summary>
		/// Event which is thrown when Phone changes value. Databinding related.
		/// </summary>
		public event EventHandler PhoneChanged;

		/// <summary>
		/// Event which is thrown when PasswordHash changes value. Databinding related.
		/// </summary>
		public event EventHandler PasswordHashChanged;

		/// <summary>
		/// Event which is thrown when PasswordSalt changes value. Databinding related.
		/// </summary>
		public event EventHandler PasswordSaltChanged;

		/// <summary>
		/// Event which is thrown when AdditionalContactInfo changes value. Databinding related.
		/// </summary>
		public event EventHandler AdditionalContactInfoChanged;

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
		public ContactEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ContactEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		public ContactEntity(System.Int32 contactID)
		{
			InitClassFetch(contactID, new ContactValidator(), new PropertyDescriptorFactory(), new ContactEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The custom validator object for this ContactEntity</param>
		public ContactEntity(System.Int32 contactID, ContactValidator validator)
		{
			InitClassFetch(contactID, validator, new PropertyDescriptorFactory(), new ContactEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="validator">The custom validator object for this ContactEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ContactEntity(System.Int32 contactID, ContactValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(contactID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ContactEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ContactEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_employee = (EmployeeCollection)info.GetValue("_employee", typeof(EmployeeCollection));
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");

			_vendorContact = (VendorContactCollection)info.GetValue("_vendorContact", typeof(VendorContactCollection));
			_alwaysFetchVendorContact = info.GetBoolean("_alwaysFetchVendorContact");
			_alreadyFetchedVendorContact = info.GetBoolean("_alreadyFetchedVendorContact");

			_contactCreditCard = (ContactCreditCardCollection)info.GetValue("_contactCreditCard", typeof(ContactCreditCardCollection));
			_alwaysFetchContactCreditCard = info.GetBoolean("_alwaysFetchContactCreditCard");
			_alreadyFetchedContactCreditCard = info.GetBoolean("_alreadyFetchedContactCreditCard");

			_individual = (IndividualCollection)info.GetValue("_individual", typeof(IndividualCollection));
			_alwaysFetchIndividual = info.GetBoolean("_alwaysFetchIndividual");
			_alreadyFetchedIndividual = info.GetBoolean("_alreadyFetchedIndividual");

			_storeContact = (StoreContactCollection)info.GetValue("_storeContact", typeof(StoreContactCollection));
			_alwaysFetchStoreContact = info.GetBoolean("_alwaysFetchStoreContact");
			_alreadyFetchedStoreContact = info.GetBoolean("_alreadyFetchedStoreContact");

			_employee_ = (EmployeeCollection)info.GetValue("_employee_", typeof(EmployeeCollection));
			_alwaysFetchEmployee_ = info.GetBoolean("_alwaysFetchEmployee_");
			_alreadyFetchedEmployee_ = info.GetBoolean("_alreadyFetchedEmployee_");

			_contactType_ = (ContactTypeCollection)info.GetValue("_contactType_", typeof(ContactTypeCollection));
			_alwaysFetchContactType_ = info.GetBoolean("_alwaysFetchContactType_");
			_alreadyFetchedContactType_ = info.GetBoolean("_alreadyFetchedContactType_");

			_vendor = (VendorCollection)info.GetValue("_vendor", typeof(VendorCollection));
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");

			_creditCard = (CreditCardCollection)info.GetValue("_creditCard", typeof(CreditCardCollection));
			_alwaysFetchCreditCard = info.GetBoolean("_alwaysFetchCreditCard");
			_alreadyFetchedCreditCard = info.GetBoolean("_alreadyFetchedCreditCard");

			_contactType = (ContactTypeCollection)info.GetValue("_contactType", typeof(ContactTypeCollection));
			_alwaysFetchContactType = info.GetBoolean("_alwaysFetchContactType");
			_alreadyFetchedContactType = info.GetBoolean("_alreadyFetchedContactType");

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
			_alreadyFetchedEmployee = (_employee.Count > 0);
			_alreadyFetchedVendorContact = (_vendorContact.Count > 0);
			_alreadyFetchedContactCreditCard = (_contactCreditCard.Count > 0);
			_alreadyFetchedIndividual = (_individual.Count > 0);
			_alreadyFetchedStoreContact = (_storeContact.Count > 0);
			_alreadyFetchedEmployee_ = (_employee_.Count > 0);
			_alreadyFetchedContactType_ = (_contactType_.Count > 0);
			_alreadyFetchedVendor = (_vendor.Count > 0);
			_alreadyFetchedCreditCard = (_creditCard.Count > 0);
			_alreadyFetchedContactType = (_contactType.Count > 0);
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
			info.AddValue("_employee", _employee);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_vendorContact", _vendorContact);
			info.AddValue("_alwaysFetchVendorContact", _alwaysFetchVendorContact);
			info.AddValue("_alreadyFetchedVendorContact", _alreadyFetchedVendorContact);
			info.AddValue("_contactCreditCard", _contactCreditCard);
			info.AddValue("_alwaysFetchContactCreditCard", _alwaysFetchContactCreditCard);
			info.AddValue("_alreadyFetchedContactCreditCard", _alreadyFetchedContactCreditCard);
			info.AddValue("_individual", _individual);
			info.AddValue("_alwaysFetchIndividual", _alwaysFetchIndividual);
			info.AddValue("_alreadyFetchedIndividual", _alreadyFetchedIndividual);
			info.AddValue("_storeContact", _storeContact);
			info.AddValue("_alwaysFetchStoreContact", _alwaysFetchStoreContact);
			info.AddValue("_alreadyFetchedStoreContact", _alreadyFetchedStoreContact);
			info.AddValue("_employee_", _employee_);
			info.AddValue("_alwaysFetchEmployee_", _alwaysFetchEmployee_);
			info.AddValue("_alreadyFetchedEmployee_", _alreadyFetchedEmployee_);
			info.AddValue("_contactType_", _contactType_);
			info.AddValue("_alwaysFetchContactType_", _alwaysFetchContactType_);
			info.AddValue("_alreadyFetchedContactType_", _alreadyFetchedContactType_);
			info.AddValue("_vendor", _vendor);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);
			info.AddValue("_creditCard", _creditCard);
			info.AddValue("_alwaysFetchCreditCard", _alwaysFetchCreditCard);
			info.AddValue("_alreadyFetchedCreditCard", _alreadyFetchedCreditCard);
			info.AddValue("_contactType", _contactType);
			info.AddValue("_alwaysFetchContactType", _alwaysFetchContactType);
			info.AddValue("_alreadyFetchedContactType", _alreadyFetchedContactType);
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

				case "Employee":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_employee.Add(relatedEntity);
					break;
				case "VendorContact":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_vendorContact.Add(relatedEntity);
					break;
				case "ContactCreditCard":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_contactCreditCard.Add(relatedEntity);
					break;
				case "Individual":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_individual.Add(relatedEntity);
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

				case "Employee":
					// Remove it from the collection.
					_employee.Remove(relatedEntity);
					break;
				case "VendorContact":
					// Remove it from the collection.
					_vendorContact.Remove(relatedEntity);
					break;
				case "ContactCreditCard":
					// Remove it from the collection.
					_contactCreditCard.Remove(relatedEntity);
					break;
				case "Individual":
					// Remove it from the collection.
					_individual.Remove(relatedEntity);
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

			toReturn.Add(_employee);
			toReturn.Add(_vendorContact);
			toReturn.Add(_contactCreditCard);
			toReturn.Add(_individual);
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
			return base.ToXml("ContactEntity");
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
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID)
		{
			return Fetch(contactID);
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
			return Fetch(this.ContactID);
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
			ContactDAO dao = DAOFactory.CreateContactDAO();
			bool wasSuccesful = dao.DeleteContact(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ContactFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public virtual EmployeeCollection GetMultiEmployee(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee);
					}
				}
				_employee.SuppressClearInGetMulti=!forceFetch;
				_employee.GetMultiManyToOne(this, null);
				_employee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public virtual EmployeeCollection GetMultiEmployee(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee);
					}
				}
				_employee.SuppressClearInGetMulti=!forceFetch;
				_employee.GetMultiManyToOne(this, null, filter);
				_employee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeCollection GetMultiEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee);
					}
				}
				_employee.SuppressClearInGetMulti=!forceFetch;
				_employee.EntityFactoryToUse = entityFactoryToUse;
				_employee.GetMultiManyToOne(this, null);
				_employee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeCollection GetMultiEmployee(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee);
					}
				}
				_employee.SuppressClearInGetMulti=!forceFetch;
				_employee.EntityFactoryToUse = entityFactoryToUse;
				_employee.GetMultiManyToOne(this, null, filter);
				_employee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Employee'. These settings will be taken into account
		/// when the property Employee is requested or GetMultiEmployee is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employee.SortClauses=sortClauses;
			_employee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_vendorContact.GetMultiManyToOne(this, null, null);
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
				_vendorContact.GetMultiManyToOne(this, null, null, filter);
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
				_vendorContact.GetMultiManyToOne(this, null, null);
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
				_vendorContact.GetMultiManyToOne(this, null, null, filter);
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
		/// Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactCreditCardEntity'</returns>
		public virtual ContactCreditCardCollection GetMultiContactCreditCard(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContactCreditCard || forceFetch || _alwaysFetchContactCreditCard) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCreditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCreditCard);
					}
				}
				_contactCreditCard.SuppressClearInGetMulti=!forceFetch;
				_contactCreditCard.GetMultiManyToOne(this, null);
				_contactCreditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCreditCard = true;
			}
			return _contactCreditCard;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ContactCreditCardEntity'</returns>
		public virtual ContactCreditCardCollection GetMultiContactCreditCard(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedContactCreditCard || forceFetch || _alwaysFetchContactCreditCard) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCreditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCreditCard);
					}
				}
				_contactCreditCard.SuppressClearInGetMulti=!forceFetch;
				_contactCreditCard.GetMultiManyToOne(this, null, filter);
				_contactCreditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCreditCard = true;
			}
			return _contactCreditCard;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactCreditCardCollection GetMultiContactCreditCard(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactCreditCard || forceFetch || _alwaysFetchContactCreditCard) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCreditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCreditCard);
					}
				}
				_contactCreditCard.SuppressClearInGetMulti=!forceFetch;
				_contactCreditCard.EntityFactoryToUse = entityFactoryToUse;
				_contactCreditCard.GetMultiManyToOne(this, null);
				_contactCreditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCreditCard = true;
			}
			return _contactCreditCard;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactCreditCardCollection GetMultiContactCreditCard(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedContactCreditCard || forceFetch || _alwaysFetchContactCreditCard) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactCreditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactCreditCard);
					}
				}
				_contactCreditCard.SuppressClearInGetMulti=!forceFetch;
				_contactCreditCard.EntityFactoryToUse = entityFactoryToUse;
				_contactCreditCard.GetMultiManyToOne(this, null, filter);
				_contactCreditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedContactCreditCard = true;
			}
			return _contactCreditCard;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ContactCreditCard'. These settings will be taken into account
		/// when the property ContactCreditCard is requested or GetMultiContactCreditCard is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactCreditCard(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactCreditCard.SortClauses=sortClauses;
			_contactCreditCard.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IndividualEntity'</returns>
		public virtual IndividualCollection GetMultiIndividual(bool forceFetch)
		{
 			if( ( !_alreadyFetchedIndividual || forceFetch || _alwaysFetchIndividual) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_individual.ParticipatesInTransaction)
					{
						base.Transaction.Add(_individual);
					}
				}
				_individual.SuppressClearInGetMulti=!forceFetch;
				_individual.GetMultiManyToOne(this);
				_individual.SuppressClearInGetMulti=false;
				_alreadyFetchedIndividual = true;
			}
			return _individual;
		}


		/// <summary>
		/// Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'IndividualEntity'</returns>
		public virtual IndividualCollection GetMultiIndividual(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIndividual || forceFetch || _alwaysFetchIndividual) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_individual.ParticipatesInTransaction)
					{
						base.Transaction.Add(_individual);
					}
				}
				_individual.SuppressClearInGetMulti=!forceFetch;
				_individual.GetMultiManyToOne(this, filter);
				_individual.SuppressClearInGetMulti=false;
				_alreadyFetchedIndividual = true;
			}
			return _individual;
		}


		/// <summary>
		/// Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual IndividualCollection GetMultiIndividual(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedIndividual || forceFetch || _alwaysFetchIndividual) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_individual.ParticipatesInTransaction)
					{
						base.Transaction.Add(_individual);
					}
				}
				_individual.SuppressClearInGetMulti=!forceFetch;
				_individual.EntityFactoryToUse = entityFactoryToUse;
				_individual.GetMultiManyToOne(this);
				_individual.SuppressClearInGetMulti=false;
				_alreadyFetchedIndividual = true;
			}
			return _individual;
		}


		/// <summary>
		/// Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual IndividualCollection GetMultiIndividual(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedIndividual || forceFetch || _alwaysFetchIndividual) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_individual.ParticipatesInTransaction)
					{
						base.Transaction.Add(_individual);
					}
				}
				_individual.SuppressClearInGetMulti=!forceFetch;
				_individual.EntityFactoryToUse = entityFactoryToUse;
				_individual.GetMultiManyToOne(this, filter);
				_individual.SuppressClearInGetMulti=false;
				_alreadyFetchedIndividual = true;
			}
			return _individual;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Individual'. These settings will be taken into account
		/// when the property Individual is requested or GetMultiIndividual is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIndividual(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_individual.SortClauses=sortClauses;
			_individual.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_storeContact.GetMultiManyToOne(this, null, null);
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
				_storeContact.GetMultiManyToOne(this, null, null, filter);
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
				_storeContact.GetMultiManyToOne(this, null, null);
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
				_storeContact.GetMultiManyToOne(this, null, null, filter);
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
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public virtual EmployeeCollection GetMultiEmployee_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployee_ || forceFetch || _alwaysFetchEmployee_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employee_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee_);
					}
				}
				_employee_.SuppressClearInGetMulti=!forceFetch;
				_employee_.GetMultiManyToManyUsingContact_(this);
				_employee_.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee_ = true;
			}
			return _employee_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeCollection GetMultiEmployee_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployee_ || forceFetch || _alwaysFetchEmployee_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employee_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee_);
					}
				}
				_employee_.SuppressClearInGetMulti=!forceFetch;
				_employee_.EntityFactoryToUse = entityFactoryToUse;
				_employee_.GetMultiManyToManyUsingContact_(this);
				_employee_.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee_ = true;
			}
			return _employee_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Employee_'. These settings will be taken into account
		/// when the property Employee_ is requested or GetMultiEmployee_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployee_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employee_.SortClauses=sortClauses;
			_employee_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactTypeEntity'</returns>
		public virtual ContactTypeCollection GetMultiContactType_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContactType_ || forceFetch || _alwaysFetchContactType_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactType_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactType_);
					}
				}
				_contactType_.SuppressClearInGetMulti=!forceFetch;
				_contactType_.GetMultiManyToManyUsingContact_(this);
				_contactType_.SuppressClearInGetMulti=false;
				_alreadyFetchedContactType_ = true;
			}
			return _contactType_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactTypeCollection GetMultiContactType_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactType_ || forceFetch || _alwaysFetchContactType_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactType_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactType_);
					}
				}
				_contactType_.SuppressClearInGetMulti=!forceFetch;
				_contactType_.EntityFactoryToUse = entityFactoryToUse;
				_contactType_.GetMultiManyToManyUsingContact_(this);
				_contactType_.SuppressClearInGetMulti=false;
				_alreadyFetchedContactType_ = true;
			}
			return _contactType_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ContactType_'. These settings will be taken into account
		/// when the property ContactType_ is requested or GetMultiContactType_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactType_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactType_.SortClauses=sortClauses;
			_contactType_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_vendor.GetMultiManyToManyUsingContact(this);
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
				_vendor.GetMultiManyToManyUsingContact(this);
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
		/// Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CreditCardEntity'</returns>
		public virtual CreditCardCollection GetMultiCreditCard(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCreditCard || forceFetch || _alwaysFetchCreditCard) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_creditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_creditCard);
					}
				}
				_creditCard.SuppressClearInGetMulti=!forceFetch;
				_creditCard.GetMultiManyToManyUsingContact(this);
				_creditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedCreditCard = true;
			}
			return _creditCard;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CreditCardCollection GetMultiCreditCard(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCreditCard || forceFetch || _alwaysFetchCreditCard) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_creditCard.ParticipatesInTransaction)
					{
						base.Transaction.Add(_creditCard);
					}
				}
				_creditCard.SuppressClearInGetMulti=!forceFetch;
				_creditCard.EntityFactoryToUse = entityFactoryToUse;
				_creditCard.GetMultiManyToManyUsingContact(this);
				_creditCard.SuppressClearInGetMulti=false;
				_alreadyFetchedCreditCard = true;
			}
			return _creditCard;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'CreditCard'. These settings will be taken into account
		/// when the property CreditCard is requested or GetMultiCreditCard is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCreditCard(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_creditCard.SortClauses=sortClauses;
			_creditCard.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_contactType.GetMultiManyToManyUsingContact(this);
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
				_contactType.GetMultiManyToManyUsingContact(this);
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
				_store.GetMultiManyToManyUsingContact(this);
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
				_store.GetMultiManyToManyUsingContact(this);
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
		/// Event thrower for the ContactIDChanged event, which is thrown when ContactID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnContactIDChanged()
		{
			if(ContactIDChanged!=null)
			{
				ContactIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the NameStyleChanged event, which is thrown when NameStyle changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnNameStyleChanged()
		{
			if(NameStyleChanged!=null)
			{
				NameStyleChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the TitleChanged event, which is thrown when Title changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTitleChanged()
		{
			if(TitleChanged!=null)
			{
				TitleChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the FirstNameChanged event, which is thrown when FirstName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnFirstNameChanged()
		{
			if(FirstNameChanged!=null)
			{
				FirstNameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the MiddleNameChanged event, which is thrown when MiddleName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnMiddleNameChanged()
		{
			if(MiddleNameChanged!=null)
			{
				MiddleNameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the LastNameChanged event, which is thrown when LastName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnLastNameChanged()
		{
			if(LastNameChanged!=null)
			{
				LastNameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SuffixChanged event, which is thrown when Suffix changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSuffixChanged()
		{
			if(SuffixChanged!=null)
			{
				SuffixChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the EmailAddressChanged event, which is thrown when EmailAddress changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEmailAddressChanged()
		{
			if(EmailAddressChanged!=null)
			{
				EmailAddressChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the EmailPromotionChanged event, which is thrown when EmailPromotion changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEmailPromotionChanged()
		{
			if(EmailPromotionChanged!=null)
			{
				EmailPromotionChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PhoneChanged event, which is thrown when Phone changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPhoneChanged()
		{
			if(PhoneChanged!=null)
			{
				PhoneChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PasswordHashChanged event, which is thrown when PasswordHash changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPasswordHashChanged()
		{
			if(PasswordHashChanged!=null)
			{
				PasswordHashChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PasswordSaltChanged event, which is thrown when PasswordSalt changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPasswordSaltChanged()
		{
			if(PasswordSaltChanged!=null)
			{
				PasswordSaltChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the AdditionalContactInfoChanged event, which is thrown when AdditionalContactInfo changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnAdditionalContactInfoChanged()
		{
			if(AdditionalContactInfoChanged!=null)
			{
				AdditionalContactInfoChanged(this, new EventArgs());
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
			ContactDAO dao = DAOFactory.CreateContactDAO();
			return dao.AddContact(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ContactDAO dao = DAOFactory.CreateContactDAO();
			return dao.UpdateContact(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ContactDAO dao = DAOFactory.CreateContactDAO();
			return dao.UpdateContact(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ContactEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ContactValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ContactEntity</param>
		private void InitClassFetch(System.Int32 contactID, ContactValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ContactEntity);
			bool wasSuccesful = Fetch(contactID);
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
			_employee = new EmployeeCollection(propertyDescriptorFactoryToUse, new EmployeeEntityFactory());
			_employee.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_vendorContact = new VendorContactCollection(propertyDescriptorFactoryToUse, new VendorContactEntityFactory());
			_vendorContact.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchVendorContact = false;
			_alreadyFetchedVendorContact = false;
			_contactCreditCard = new ContactCreditCardCollection(propertyDescriptorFactoryToUse, new ContactCreditCardEntityFactory());
			_contactCreditCard.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchContactCreditCard = false;
			_alreadyFetchedContactCreditCard = false;
			_individual = new IndividualCollection(propertyDescriptorFactoryToUse, new IndividualEntityFactory());
			_individual.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchIndividual = false;
			_alreadyFetchedIndividual = false;
			_storeContact = new StoreContactCollection(propertyDescriptorFactoryToUse, new StoreContactEntityFactory());
			_storeContact.SetContainingEntityInfo(this, "Contact");
			_alwaysFetchStoreContact = false;
			_alreadyFetchedStoreContact = false;
			_employee_ = new EmployeeCollection(propertyDescriptorFactoryToUse, new EmployeeEntityFactory());
			_alwaysFetchEmployee_ = false;
			_alreadyFetchedEmployee_ = false;
			_contactType_ = new ContactTypeCollection(propertyDescriptorFactoryToUse, new ContactTypeEntityFactory());
			_alwaysFetchContactType_ = false;
			_alreadyFetchedContactType_ = false;
			_vendor = new VendorCollection(propertyDescriptorFactoryToUse, new VendorEntityFactory());
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;
			_creditCard = new CreditCardCollection(propertyDescriptorFactoryToUse, new CreditCardEntityFactory());
			_alwaysFetchCreditCard = false;
			_alreadyFetchedCreditCard = false;
			_contactType = new ContactTypeCollection(propertyDescriptorFactoryToUse, new ContactTypeEntityFactory());
			_alwaysFetchContactType = false;
			_alreadyFetchedContactType = false;
			_store = new StoreCollection(propertyDescriptorFactoryToUse, new StoreEntityFactory());
			_alwaysFetchStore = false;
			_alreadyFetchedStore = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="contactID">PK value for Contact which data should be fetched into this Contact object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 contactID)
		{
			ContactDAO dao = DAOFactory.CreateContactDAO();

			// Load EntityFields of Contact
			dao.FetchContact(base.Fields, base.Transaction, contactID);

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
		public static ContactRelations Relations
		{
			get	{ return new ContactRelations(); }
		}

	
		/// <summary>
		/// The ContactID property of the Entity Contact
		/// </summary>
		public virtual System.Int32 ContactID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.ContactID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ContactID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.ContactID, value))
				{
					OnContactIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The NameStyle property of the Entity Contact
		/// </summary>
		public virtual System.Boolean NameStyle
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.NameStyle);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for NameStyle because it is set to NULL.");
				}
				return (System.Boolean)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.NameStyle, value))
				{
					OnNameStyleChanged();
				}
			}
		}
	
		/// <summary>
		/// The Title property of the Entity Contact
		/// </summary>
		public virtual System.String Title
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.Title);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Title because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.Title, value))
				{
					OnTitleChanged();
				}
			}
		}
	
		/// <summary>
		/// The FirstName property of the Entity Contact
		/// </summary>
		public virtual System.String FirstName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.FirstName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for FirstName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.FirstName, value))
				{
					OnFirstNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The MiddleName property of the Entity Contact
		/// </summary>
		public virtual System.String MiddleName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.MiddleName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for MiddleName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.MiddleName, value))
				{
					OnMiddleNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The LastName property of the Entity Contact
		/// </summary>
		public virtual System.String LastName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.LastName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for LastName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.LastName, value))
				{
					OnLastNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The Suffix property of the Entity Contact
		/// </summary>
		public virtual System.String Suffix
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.Suffix);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Suffix because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.Suffix, value))
				{
					OnSuffixChanged();
				}
			}
		}
	
		/// <summary>
		/// The EmailAddress property of the Entity Contact
		/// </summary>
		public virtual System.String EmailAddress
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.EmailAddress);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EmailAddress because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.EmailAddress, value))
				{
					OnEmailAddressChanged();
				}
			}
		}
	
		/// <summary>
		/// The EmailPromotion property of the Entity Contact
		/// </summary>
		public virtual System.Int32 EmailPromotion
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.EmailPromotion);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EmailPromotion because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.EmailPromotion, value))
				{
					OnEmailPromotionChanged();
				}
			}
		}
	
		/// <summary>
		/// The Phone property of the Entity Contact
		/// </summary>
		public virtual System.String Phone
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.Phone);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Phone because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.Phone, value))
				{
					OnPhoneChanged();
				}
			}
		}
	
		/// <summary>
		/// The PasswordHash property of the Entity Contact
		/// </summary>
		public virtual System.String PasswordHash
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.PasswordHash);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PasswordHash because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.PasswordHash, value))
				{
					OnPasswordHashChanged();
				}
			}
		}
	
		/// <summary>
		/// The PasswordSalt property of the Entity Contact
		/// </summary>
		public virtual System.String PasswordSalt
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.PasswordSalt);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PasswordSalt because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.PasswordSalt, value))
				{
					OnPasswordSaltChanged();
				}
			}
		}
	
		/// <summary>
		/// The AdditionalContactInfo property of the Entity Contact
		/// </summary>
		public virtual System.String AdditionalContactInfo
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.AdditionalContactInfo);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AdditionalContactInfo because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.AdditionalContactInfo, value))
				{
					OnAdditionalContactInfoChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity Contact
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity Contact
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual EmployeeCollection Employee
		{
			get
			{
				return GetMultiEmployee(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployee(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get
			{
				return _alwaysFetchEmployee;
			}
			set
			{
				_alwaysFetchEmployee = value;
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
		/// Retrieves all related entities of type 'ContactCreditCardEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ContactCreditCardCollection ContactCreditCard
		{
			get
			{
				return GetMultiContactCreditCard(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ContactCreditCard. When set to true, ContactCreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactCreditCard is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactCreditCard(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContactCreditCard
		{
			get
			{
				return _alwaysFetchContactCreditCard;
			}
			set
			{
				_alwaysFetchContactCreditCard = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'IndividualEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIndividual()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual IndividualCollection Individual
		{
			get
			{
				return GetMultiIndividual(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Individual. When set to true, Individual is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Individual is accessed. You can always execute
		/// a forced fetch by calling GetMultiIndividual(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchIndividual
		{
			get
			{
				return _alwaysFetchIndividual;
			}
			set
			{
				_alwaysFetchIndividual = value;
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
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployee_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual EmployeeCollection Employee_
		{
			get
			{
				return GetMultiEmployee_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Employee_. When set to true, Employee_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployee_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee_
		{
			get
			{
				return _alwaysFetchEmployee_;
			}
			set
			{
				_alwaysFetchEmployee_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactType_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ContactTypeCollection ContactType_
		{
			get
			{
				return GetMultiContactType_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ContactType_. When set to true, ContactType_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactType_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactType_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContactType_
		{
			get
			{
				return _alwaysFetchContactType_;
			}
			set
			{
				_alwaysFetchContactType_ = value;
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
		/// Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CreditCardCollection CreditCard
		{
			get
			{
				return GetMultiCreditCard(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CreditCard. When set to true, CreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCard is accessed. You can always execute
		/// a forced fetch by calling GetMultiCreditCard(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCreditCard
		{
			get
			{
				return _alwaysFetchCreditCard;
			}
			set
			{
				_alwaysFetchCreditCard = value;
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
