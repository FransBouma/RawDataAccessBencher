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
	/// Entity class which represents the entity 'AddressType' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class AddressTypeEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private VendorAddressCollection	_vendorAddress;
		private bool	_alwaysFetchVendorAddress, _alreadyFetchedVendorAddress;
		private CustomerAddressCollection	_customerAddress;
		private bool	_alwaysFetchCustomerAddress, _alreadyFetchedCustomerAddress;
		private AddressCollection _address_;
		private bool	_alwaysFetchAddress_, _alreadyFetchedAddress_;
		private VendorCollection _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor;
		private AddressCollection _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private CustomerCollection _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when AddressTypeID changes value. Databinding related.
		/// </summary>
		public event EventHandler AddressTypeIDChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

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
		public AddressTypeEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new AddressTypeEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		public AddressTypeEntity(System.Int32 addressTypeID)
		{
			InitClassFetch(addressTypeID, new AddressTypeValidator(), new PropertyDescriptorFactory(), new AddressTypeEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="validator">The custom validator object for this AddressTypeEntity</param>
		public AddressTypeEntity(System.Int32 addressTypeID, AddressTypeValidator validator)
		{
			InitClassFetch(addressTypeID, validator, new PropertyDescriptorFactory(), new AddressTypeEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="validator">The custom validator object for this AddressTypeEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public AddressTypeEntity(System.Int32 addressTypeID, AddressTypeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(addressTypeID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public AddressTypeEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private AddressTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_vendorAddress = (VendorAddressCollection)info.GetValue("_vendorAddress", typeof(VendorAddressCollection));
			_alwaysFetchVendorAddress = info.GetBoolean("_alwaysFetchVendorAddress");
			_alreadyFetchedVendorAddress = info.GetBoolean("_alreadyFetchedVendorAddress");

			_customerAddress = (CustomerAddressCollection)info.GetValue("_customerAddress", typeof(CustomerAddressCollection));
			_alwaysFetchCustomerAddress = info.GetBoolean("_alwaysFetchCustomerAddress");
			_alreadyFetchedCustomerAddress = info.GetBoolean("_alreadyFetchedCustomerAddress");

			_address_ = (AddressCollection)info.GetValue("_address_", typeof(AddressCollection));
			_alwaysFetchAddress_ = info.GetBoolean("_alwaysFetchAddress_");
			_alreadyFetchedAddress_ = info.GetBoolean("_alreadyFetchedAddress_");

			_vendor = (VendorCollection)info.GetValue("_vendor", typeof(VendorCollection));
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");

			_address = (AddressCollection)info.GetValue("_address", typeof(AddressCollection));
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");

			_customer = (CustomerCollection)info.GetValue("_customer", typeof(CustomerCollection));
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
			_alreadyFetchedVendorAddress = (_vendorAddress.Count > 0);
			_alreadyFetchedCustomerAddress = (_customerAddress.Count > 0);
			_alreadyFetchedAddress_ = (_address_.Count > 0);
			_alreadyFetchedVendor = (_vendor.Count > 0);
			_alreadyFetchedAddress = (_address.Count > 0);
			_alreadyFetchedCustomer = (_customer.Count > 0);


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
			info.AddValue("_vendorAddress", _vendorAddress);
			info.AddValue("_alwaysFetchVendorAddress", _alwaysFetchVendorAddress);
			info.AddValue("_alreadyFetchedVendorAddress", _alreadyFetchedVendorAddress);
			info.AddValue("_customerAddress", _customerAddress);
			info.AddValue("_alwaysFetchCustomerAddress", _alwaysFetchCustomerAddress);
			info.AddValue("_alreadyFetchedCustomerAddress", _alreadyFetchedCustomerAddress);
			info.AddValue("_address_", _address_);
			info.AddValue("_alwaysFetchAddress_", _alwaysFetchAddress_);
			info.AddValue("_alreadyFetchedAddress_", _alreadyFetchedAddress_);
			info.AddValue("_vendor", _vendor);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);
			info.AddValue("_address", _address);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
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

				case "VendorAddress":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_vendorAddress.Add(relatedEntity);
					break;
				case "CustomerAddress":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_customerAddress.Add(relatedEntity);
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

				case "VendorAddress":
					// Remove it from the collection.
					_vendorAddress.Remove(relatedEntity);
					break;
				case "CustomerAddress":
					// Remove it from the collection.
					_customerAddress.Remove(relatedEntity);
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

			toReturn.Add(_vendorAddress);
			toReturn.Add(_customerAddress);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("AddressTypeEntity");
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
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressTypeID)
		{
			return Fetch(addressTypeID);
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
			return Fetch(this.AddressTypeID);
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
			AddressTypeDAO dao = DAOFactory.CreateAddressTypeDAO();
			bool wasSuccesful = dao.DeleteAddressType(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(AddressTypeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public virtual VendorAddressCollection GetMultiVendorAddress(bool forceFetch)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				_vendorAddress.GetMultiManyToOne(null, this, null);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public virtual VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				_vendorAddress.GetMultiManyToOne(null, this, null, filter);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				_vendorAddress.EntityFactoryToUse = entityFactoryToUse;
				_vendorAddress.GetMultiManyToOne(null, this, null);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				_vendorAddress.EntityFactoryToUse = entityFactoryToUse;
				_vendorAddress.GetMultiManyToOne(null, this, null, filter);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'VendorAddress'. These settings will be taken into account
		/// when the property VendorAddress is requested or GetMultiVendorAddress is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorAddress.SortClauses=sortClauses;
			_vendorAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public virtual CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCustomerAddress || forceFetch || _alwaysFetchCustomerAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerAddress);
					}
				}
				_customerAddress.SuppressClearInGetMulti=!forceFetch;
				_customerAddress.GetMultiManyToOne(null, this, null);
				_customerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerAddress = true;
			}
			return _customerAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerAddressEntity'</returns>
		public virtual CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomerAddress || forceFetch || _alwaysFetchCustomerAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerAddress);
					}
				}
				_customerAddress.SuppressClearInGetMulti=!forceFetch;
				_customerAddress.GetMultiManyToOne(null, this, null, filter);
				_customerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerAddress = true;
			}
			return _customerAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomerAddress || forceFetch || _alwaysFetchCustomerAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerAddress);
					}
				}
				_customerAddress.SuppressClearInGetMulti=!forceFetch;
				_customerAddress.EntityFactoryToUse = entityFactoryToUse;
				_customerAddress.GetMultiManyToOne(null, this, null);
				_customerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerAddress = true;
			}
			return _customerAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CustomerAddressCollection GetMultiCustomerAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCustomerAddress || forceFetch || _alwaysFetchCustomerAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customerAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customerAddress);
					}
				}
				_customerAddress.SuppressClearInGetMulti=!forceFetch;
				_customerAddress.EntityFactoryToUse = entityFactoryToUse;
				_customerAddress.GetMultiManyToOne(null, this, null, filter);
				_customerAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomerAddress = true;
			}
			return _customerAddress;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'CustomerAddress'. These settings will be taken into account
		/// when the property CustomerAddress is requested or GetMultiCustomerAddress is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomerAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customerAddress.SortClauses=sortClauses;
			_customerAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public virtual AddressCollection GetMultiAddress_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddress_ || forceFetch || _alwaysFetchAddress_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_address_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address_);
					}
				}
				_address_.SuppressClearInGetMulti=!forceFetch;
				_address_.GetMultiManyToManyUsingAddressType_(this);
				_address_.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress_ = true;
			}
			return _address_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AddressCollection GetMultiAddress_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddress_ || forceFetch || _alwaysFetchAddress_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_address_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address_);
					}
				}
				_address_.SuppressClearInGetMulti=!forceFetch;
				_address_.EntityFactoryToUse = entityFactoryToUse;
				_address_.GetMultiManyToManyUsingAddressType_(this);
				_address_.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress_ = true;
			}
			return _address_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Address_'. These settings will be taken into account
		/// when the property Address_ is requested or GetMultiAddress_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddress_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_address_.SortClauses=sortClauses;
			_address_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_vendor.GetMultiManyToManyUsingAddressType(this);
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
				_vendor.GetMultiManyToManyUsingAddressType(this);
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
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public virtual AddressCollection GetMultiAddress(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_address.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address);
					}
				}
				_address.SuppressClearInGetMulti=!forceFetch;
				_address.GetMultiManyToManyUsingAddressType(this);
				_address.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress = true;
			}
			return _address;
		}


		/// <summary>
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AddressCollection GetMultiAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_address.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address);
					}
				}
				_address.SuppressClearInGetMulti=!forceFetch;
				_address.EntityFactoryToUse = entityFactoryToUse;
				_address.GetMultiManyToManyUsingAddressType(this);
				_address.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress = true;
			}
			return _address;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Address'. These settings will be taken into account
		/// when the property Address is requested or GetMultiAddress is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_address.SortClauses=sortClauses;
			_address.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public virtual CustomerCollection GetMultiCustomer(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customer.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customer);
					}
				}
				_customer.SuppressClearInGetMulti=!forceFetch;
				_customer.GetMultiManyToManyUsingAddressType(this);
				_customer.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer = true;
			}
			return _customer;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CustomerCollection GetMultiCustomer(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomer || forceFetch || _alwaysFetchCustomer) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customer.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customer);
					}
				}
				_customer.SuppressClearInGetMulti=!forceFetch;
				_customer.EntityFactoryToUse = entityFactoryToUse;
				_customer.GetMultiManyToManyUsingAddressType(this);
				_customer.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer = true;
			}
			return _customer;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Customer'. These settings will be taken into account
		/// when the property Customer is requested or GetMultiCustomer is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomer(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customer.SortClauses=sortClauses;
			_customer.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
	
	
		#region Data binding change event raising methods
	
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
			AddressTypeDAO dao = DAOFactory.CreateAddressTypeDAO();
			return dao.AddAddressType(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			AddressTypeDAO dao = DAOFactory.CreateAddressTypeDAO();
			return dao.UpdateAddressType(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AddressTypeDAO dao = DAOFactory.CreateAddressTypeDAO();
			return dao.UpdateAddressType(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.AddressTypeEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new AddressTypeValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this AddressTypeEntity</param>
		private void InitClassFetch(System.Int32 addressTypeID, AddressTypeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.AddressTypeEntity);
			bool wasSuccesful = Fetch(addressTypeID);
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
			_vendorAddress = new VendorAddressCollection(propertyDescriptorFactoryToUse, new VendorAddressEntityFactory());
			_vendorAddress.SetContainingEntityInfo(this, "AddressType");
			_alwaysFetchVendorAddress = false;
			_alreadyFetchedVendorAddress = false;
			_customerAddress = new CustomerAddressCollection(propertyDescriptorFactoryToUse, new CustomerAddressEntityFactory());
			_customerAddress.SetContainingEntityInfo(this, "AddressType");
			_alwaysFetchCustomerAddress = false;
			_alreadyFetchedCustomerAddress = false;
			_address_ = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress_ = false;
			_alreadyFetchedAddress_ = false;
			_vendor = new VendorCollection(propertyDescriptorFactoryToUse, new VendorEntityFactory());
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;
			_address = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_customer = new CustomerCollection(propertyDescriptorFactoryToUse, new CustomerEntityFactory());
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="addressTypeID">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 addressTypeID)
		{
			AddressTypeDAO dao = DAOFactory.CreateAddressTypeDAO();

			// Load EntityFields of AddressType
			dao.FetchAddressType(base.Fields, base.Transaction, addressTypeID);

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
		public static AddressTypeRelations Relations
		{
			get	{ return new AddressTypeRelations(); }
		}

	
		/// <summary>
		/// The AddressTypeID property of the Entity AddressType
		/// </summary>
		public virtual System.Int32 AddressTypeID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressTypeFieldIndex.AddressTypeID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AddressTypeID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressTypeFieldIndex.AddressTypeID, value))
				{
					OnAddressTypeIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity AddressType
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressTypeFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressTypeFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity AddressType
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressTypeFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressTypeFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity AddressType
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressTypeFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressTypeFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual VendorAddressCollection VendorAddress
		{
			get
			{
				return GetMultiVendorAddress(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for VendorAddress. When set to true, VendorAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorAddress(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorAddress
		{
			get
			{
				return _alwaysFetchVendorAddress;
			}
			set
			{
				_alwaysFetchVendorAddress = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'CustomerAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomerAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CustomerAddressCollection CustomerAddress
		{
			get
			{
				return GetMultiCustomerAddress(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CustomerAddress. When set to true, CustomerAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CustomerAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomerAddress(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomerAddress
		{
			get
			{
				return _alwaysFetchCustomerAddress;
			}
			set
			{
				_alwaysFetchCustomerAddress = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddress_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual AddressCollection Address_
		{
			get
			{
				return GetMultiAddress_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Address_. When set to true, Address_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddress_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress_
		{
			get
			{
				return _alwaysFetchAddress_;
			}
			set
			{
				_alwaysFetchAddress_ = value;
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
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual AddressCollection Address
		{
			get
			{
				return GetMultiAddress(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Address. When set to true, Address is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddress(true).
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
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CustomerCollection Customer
		{
			get
			{
				return GetMultiCustomer(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Customer. When set to true, Customer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomer(true).
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
