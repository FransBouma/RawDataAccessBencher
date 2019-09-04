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
	/// Entity class which represents the entity 'Customer' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class CustomerEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private CustomerAddressCollection	_customerAddress;
		private bool	_alwaysFetchCustomerAddress, _alreadyFetchedCustomerAddress;
		private SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private AddressCollection _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private AddressTypeCollection _addressType;
		private bool	_alwaysFetchAddressType, _alreadyFetchedAddressType;
		private AddressCollection _address_;
		private bool	_alwaysFetchAddress_, _alreadyFetchedAddress_;
		private AddressCollection _address__;
		private bool	_alwaysFetchAddress__, _alreadyFetchedAddress__;
		private CreditCardCollection _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard;
		private CurrencyRateCollection _currencyRate;
		private bool	_alwaysFetchCurrencyRate, _alreadyFetchedCurrencyRate;
		private SalesPersonCollection _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson;
		private SalesTerritoryCollection _salesTerritory_;
		private bool	_alwaysFetchSalesTerritory_, _alreadyFetchedSalesTerritory_;
		private ShipMethodCollection _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;
		private SalesTerritoryEntity _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory;
		private IndividualEntity _individual;
		private bool	_alwaysFetchIndividual, _alreadyFetchedIndividual;
		private StoreEntity _store;
		private bool	_alwaysFetchStore, _alreadyFetchedStore;
		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when CustomerID changes value. Databinding related.
		/// </summary>
		public event EventHandler CustomerIDChanged;

		/// <summary>
		/// Event which is thrown when TerritoryID changes value. Databinding related.
		/// </summary>
		public event EventHandler TerritoryIDChanged;

		/// <summary>
		/// Event which is thrown when AccountNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler AccountNumberChanged;

		/// <summary>
		/// Event which is thrown when CustomerType changes value. Databinding related.
		/// </summary>
		public event EventHandler CustomerTypeChanged;

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
		public CustomerEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new CustomerEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for Customer which data should be fetched into this Customer object</param>
		public CustomerEntity(System.Int32 customerID)
		{
			InitClassFetch(customerID, new CustomerValidator(), new PropertyDescriptorFactory(), new CustomerEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="validator">The custom validator object for this CustomerEntity</param>
		public CustomerEntity(System.Int32 customerID, CustomerValidator validator)
		{
			InitClassFetch(customerID, validator, new PropertyDescriptorFactory(), new CustomerEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="customerID">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="validator">The custom validator object for this CustomerEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CustomerEntity(System.Int32 customerID, CustomerValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(customerID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CustomerEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private CustomerEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_customerAddress = (CustomerAddressCollection)info.GetValue("_customerAddress", typeof(CustomerAddressCollection));
			_alwaysFetchCustomerAddress = info.GetBoolean("_alwaysFetchCustomerAddress");
			_alreadyFetchedCustomerAddress = info.GetBoolean("_alreadyFetchedCustomerAddress");

			_salesOrderHeader = (SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");

			_address = (AddressCollection)info.GetValue("_address", typeof(AddressCollection));
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");

			_addressType = (AddressTypeCollection)info.GetValue("_addressType", typeof(AddressTypeCollection));
			_alwaysFetchAddressType = info.GetBoolean("_alwaysFetchAddressType");
			_alreadyFetchedAddressType = info.GetBoolean("_alreadyFetchedAddressType");

			_address_ = (AddressCollection)info.GetValue("_address_", typeof(AddressCollection));
			_alwaysFetchAddress_ = info.GetBoolean("_alwaysFetchAddress_");
			_alreadyFetchedAddress_ = info.GetBoolean("_alreadyFetchedAddress_");

			_address__ = (AddressCollection)info.GetValue("_address__", typeof(AddressCollection));
			_alwaysFetchAddress__ = info.GetBoolean("_alwaysFetchAddress__");
			_alreadyFetchedAddress__ = info.GetBoolean("_alreadyFetchedAddress__");

			_creditCard = (CreditCardCollection)info.GetValue("_creditCard", typeof(CreditCardCollection));
			_alwaysFetchCreditCard = info.GetBoolean("_alwaysFetchCreditCard");
			_alreadyFetchedCreditCard = info.GetBoolean("_alreadyFetchedCreditCard");

			_currencyRate = (CurrencyRateCollection)info.GetValue("_currencyRate", typeof(CurrencyRateCollection));
			_alwaysFetchCurrencyRate = info.GetBoolean("_alwaysFetchCurrencyRate");
			_alreadyFetchedCurrencyRate = info.GetBoolean("_alreadyFetchedCurrencyRate");

			_salesPerson = (SalesPersonCollection)info.GetValue("_salesPerson", typeof(SalesPersonCollection));
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");

			_salesTerritory_ = (SalesTerritoryCollection)info.GetValue("_salesTerritory_", typeof(SalesTerritoryCollection));
			_alwaysFetchSalesTerritory_ = info.GetBoolean("_alwaysFetchSalesTerritory_");
			_alreadyFetchedSalesTerritory_ = info.GetBoolean("_alreadyFetchedSalesTerritory_");

			_shipMethod = (ShipMethodCollection)info.GetValue("_shipMethod", typeof(ShipMethodCollection));
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");
			_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
			if(_salesTerritory!=null)
			{
				// rewire event handler.
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");
			_individual = (IndividualEntity)info.GetValue("_individual", typeof(IndividualEntity));
			if(_individual!=null)
			{
				// rewire event handler.
				_individual.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchIndividual = info.GetBoolean("_alwaysFetchIndividual");
			_alreadyFetchedIndividual = info.GetBoolean("_alreadyFetchedIndividual");
			_store = (StoreEntity)info.GetValue("_store", typeof(StoreEntity));
			if(_store!=null)
			{
				// rewire event handler.
				_store.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
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
			_alreadyFetchedCustomerAddress = (_customerAddress.Count > 0);
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);
			_alreadyFetchedAddress = (_address.Count > 0);
			_alreadyFetchedAddressType = (_addressType.Count > 0);
			_alreadyFetchedAddress_ = (_address_.Count > 0);
			_alreadyFetchedAddress__ = (_address__.Count > 0);
			_alreadyFetchedCreditCard = (_creditCard.Count > 0);
			_alreadyFetchedCurrencyRate = (_currencyRate.Count > 0);
			_alreadyFetchedSalesPerson = (_salesPerson.Count > 0);
			_alreadyFetchedSalesTerritory_ = (_salesTerritory_.Count > 0);
			_alreadyFetchedShipMethod = (_shipMethod.Count > 0);
			_alreadyFetchedSalesTerritory = (_salesTerritory != null);
			_alreadyFetchedIndividual = (_individual != null);
			_alreadyFetchedStore = (_store != null);
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
			info.AddValue("_customerAddress", _customerAddress);
			info.AddValue("_alwaysFetchCustomerAddress", _alwaysFetchCustomerAddress);
			info.AddValue("_alreadyFetchedCustomerAddress", _alreadyFetchedCustomerAddress);
			info.AddValue("_salesOrderHeader", _salesOrderHeader);
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_address", _address);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_addressType", _addressType);
			info.AddValue("_alwaysFetchAddressType", _alwaysFetchAddressType);
			info.AddValue("_alreadyFetchedAddressType", _alreadyFetchedAddressType);
			info.AddValue("_address_", _address_);
			info.AddValue("_alwaysFetchAddress_", _alwaysFetchAddress_);
			info.AddValue("_alreadyFetchedAddress_", _alreadyFetchedAddress_);
			info.AddValue("_address__", _address__);
			info.AddValue("_alwaysFetchAddress__", _alwaysFetchAddress__);
			info.AddValue("_alreadyFetchedAddress__", _alreadyFetchedAddress__);
			info.AddValue("_creditCard", _creditCard);
			info.AddValue("_alwaysFetchCreditCard", _alwaysFetchCreditCard);
			info.AddValue("_alreadyFetchedCreditCard", _alreadyFetchedCreditCard);
			info.AddValue("_currencyRate", _currencyRate);
			info.AddValue("_alwaysFetchCurrencyRate", _alwaysFetchCurrencyRate);
			info.AddValue("_alreadyFetchedCurrencyRate", _alreadyFetchedCurrencyRate);
			info.AddValue("_salesPerson", _salesPerson);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
			info.AddValue("_salesTerritory_", _salesTerritory_);
			info.AddValue("_alwaysFetchSalesTerritory_", _alwaysFetchSalesTerritory_);
			info.AddValue("_alreadyFetchedSalesTerritory_", _alreadyFetchedSalesTerritory_);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_salesTerritory", _salesTerritory);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);
			info.AddValue("_individual", _individual);
			info.AddValue("_alwaysFetchIndividual", _alwaysFetchIndividual);
			info.AddValue("_alreadyFetchedIndividual", _alreadyFetchedIndividual);
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
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "CustomerAddress":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_customerAddress.Add(relatedEntity);
					break;
				case "SalesOrderHeader":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesOrderHeader.Add(relatedEntity);
					break;
				case "Individual":
					SetupSyncIndividual(relatedEntity);
					break;
				case "Store":
					SetupSyncStore(relatedEntity);
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
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false);
					break;
				case "CustomerAddress":
					// Remove it from the collection.
					_customerAddress.Remove(relatedEntity);
					break;
				case "SalesOrderHeader":
					// Remove it from the collection.
					_salesOrderHeader.Remove(relatedEntity);
					break;
				case "Individual":
					DesetupSyncIndividual(false);
					break;
				case "Store":
					DesetupSyncStore(false);
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


			
			if(_individual!=null)
			{
				toReturn.Add(_individual);
			}
			
			

			
			if(_store!=null)
			{
				toReturn.Add(_store);
			}
			
			
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
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
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

			toReturn.Add(_customerAddress);
			toReturn.Add(_salesOrderHeader);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("CustomerEntity");
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
		/// <param name="customerID">PK value for Customer which data should be fetched into this Customer object</param>
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
			CustomerDAO dao = DAOFactory.CreateCustomerDAO();
			bool wasSuccesful = dao.DeleteCustomer(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(CustomerFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
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
				_customerAddress.GetMultiManyToOne(null, null, this);
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
				_customerAddress.GetMultiManyToOne(null, null, this, filter);
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
				_customerAddress.GetMultiManyToOne(null, null, this);
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
				_customerAddress.GetMultiManyToOne(null, null, this, filter);
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
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public virtual SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader);
					}
				}
				_salesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, this, null, null, null);
				_salesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader = true;
			}
			return _salesOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public virtual SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader);
					}
				}
				_salesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, this, null, null, null, filter);
				_salesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader = true;
			}
			return _salesOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader);
					}
				}
				_salesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, this, null, null, null);
				_salesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader = true;
			}
			return _salesOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesOrderHeaderCollection GetMultiSalesOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader);
					}
				}
				_salesOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, this, null, null, null, filter);
				_salesOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader = true;
			}
			return _salesOrderHeader;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesOrderHeader'. These settings will be taken into account
		/// when the property SalesOrderHeader is requested or GetMultiSalesOrderHeader is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeader.SortClauses=sortClauses;
			_salesOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_address.GetMultiManyToManyUsingCustomer(this);
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
				_address.GetMultiManyToManyUsingCustomer(this);
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
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressTypeEntity'</returns>
		public virtual AddressTypeCollection GetMultiAddressType(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddressType || forceFetch || _alwaysFetchAddressType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_addressType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressType);
					}
				}
				_addressType.SuppressClearInGetMulti=!forceFetch;
				_addressType.GetMultiManyToManyUsingCustomer(this);
				_addressType.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressType = true;
			}
			return _addressType;
		}


		/// <summary>
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AddressTypeCollection GetMultiAddressType(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressType || forceFetch || _alwaysFetchAddressType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_addressType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressType);
					}
				}
				_addressType.SuppressClearInGetMulti=!forceFetch;
				_addressType.EntityFactoryToUse = entityFactoryToUse;
				_addressType.GetMultiManyToManyUsingCustomer(this);
				_addressType.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressType = true;
			}
			return _addressType;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'AddressType'. These settings will be taken into account
		/// when the property AddressType is requested or GetMultiAddressType is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressType(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressType.SortClauses=sortClauses;
			_addressType.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_address_.GetMultiManyToManyUsingCustomer_(this);
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
				_address_.GetMultiManyToManyUsingCustomer_(this);
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
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public virtual AddressCollection GetMultiAddress__(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddress__ || forceFetch || _alwaysFetchAddress__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_address__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address__);
					}
				}
				_address__.SuppressClearInGetMulti=!forceFetch;
				_address__.GetMultiManyToManyUsingCustomer__(this);
				_address__.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress__ = true;
			}
			return _address__;
		}


		/// <summary>
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AddressCollection GetMultiAddress__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddress__ || forceFetch || _alwaysFetchAddress__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_address__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address__);
					}
				}
				_address__.SuppressClearInGetMulti=!forceFetch;
				_address__.EntityFactoryToUse = entityFactoryToUse;
				_address__.GetMultiManyToManyUsingCustomer__(this);
				_address__.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress__ = true;
			}
			return _address__;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Address__'. These settings will be taken into account
		/// when the property Address__ is requested or GetMultiAddress__ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddress__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_address__.SortClauses=sortClauses;
			_address__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_creditCard.GetMultiManyToManyUsingCustomer(this);
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
				_creditCard.GetMultiManyToManyUsingCustomer(this);
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
		/// Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyRateEntity'</returns>
		public virtual CurrencyRateCollection GetMultiCurrencyRate(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCurrencyRate || forceFetch || _alwaysFetchCurrencyRate) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyRate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyRate);
					}
				}
				_currencyRate.SuppressClearInGetMulti=!forceFetch;
				_currencyRate.GetMultiManyToManyUsingCustomer(this);
				_currencyRate.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyRate = true;
			}
			return _currencyRate;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CurrencyRateCollection GetMultiCurrencyRate(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCurrencyRate || forceFetch || _alwaysFetchCurrencyRate) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyRate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyRate);
					}
				}
				_currencyRate.SuppressClearInGetMulti=!forceFetch;
				_currencyRate.EntityFactoryToUse = entityFactoryToUse;
				_currencyRate.GetMultiManyToManyUsingCustomer(this);
				_currencyRate.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyRate = true;
			}
			return _currencyRate;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'CurrencyRate'. These settings will be taken into account
		/// when the property CurrencyRate is requested or GetMultiCurrencyRate is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrencyRate(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currencyRate.SortClauses=sortClauses;
			_currencyRate.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public virtual SalesPersonCollection GetMultiSalesPerson(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPerson.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPerson);
					}
				}
				_salesPerson.SuppressClearInGetMulti=!forceFetch;
				_salesPerson.GetMultiManyToManyUsingCustomer(this);
				_salesPerson.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson = true;
			}
			return _salesPerson;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesPersonCollection GetMultiSalesPerson(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesPerson || forceFetch || _alwaysFetchSalesPerson) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPerson.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPerson);
					}
				}
				_salesPerson.SuppressClearInGetMulti=!forceFetch;
				_salesPerson.EntityFactoryToUse = entityFactoryToUse;
				_salesPerson.GetMultiManyToManyUsingCustomer(this);
				_salesPerson.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson = true;
			}
			return _salesPerson;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesPerson'. These settings will be taken into account
		/// when the property SalesPerson is requested or GetMultiSalesPerson is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPerson(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPerson.SortClauses=sortClauses;
			_salesPerson.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryEntity'</returns>
		public virtual SalesTerritoryCollection GetMultiSalesTerritory_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesTerritory_ || forceFetch || _alwaysFetchSalesTerritory_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritory_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritory_);
					}
				}
				_salesTerritory_.SuppressClearInGetMulti=!forceFetch;
				_salesTerritory_.GetMultiManyToManyUsingCustomer_(this);
				_salesTerritory_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritory_ = true;
			}
			return _salesTerritory_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesTerritoryCollection GetMultiSalesTerritory_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesTerritory_ || forceFetch || _alwaysFetchSalesTerritory_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritory_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritory_);
					}
				}
				_salesTerritory_.SuppressClearInGetMulti=!forceFetch;
				_salesTerritory_.EntityFactoryToUse = entityFactoryToUse;
				_salesTerritory_.GetMultiManyToManyUsingCustomer_(this);
				_salesTerritory_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritory_ = true;
			}
			return _salesTerritory_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesTerritory_'. These settings will be taken into account
		/// when the property SalesTerritory_ is requested or GetMultiSalesTerritory_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritory_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritory_.SortClauses=sortClauses;
			_salesTerritory_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShipMethodEntity'</returns>
		public virtual ShipMethodCollection GetMultiShipMethod(bool forceFetch)
		{
 			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethod.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethod);
					}
				}
				_shipMethod.SuppressClearInGetMulti=!forceFetch;
				_shipMethod.GetMultiManyToManyUsingCustomer(this);
				_shipMethod.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethod = true;
			}
			return _shipMethod;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ShipMethodCollection GetMultiShipMethod(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethod.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethod);
					}
				}
				_shipMethod.SuppressClearInGetMulti=!forceFetch;
				_shipMethod.EntityFactoryToUse = entityFactoryToUse;
				_shipMethod.GetMultiManyToManyUsingCustomer(this);
				_shipMethod.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethod = true;
			}
			return _shipMethod;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ShipMethod'. These settings will be taken into account
		/// when the property ShipMethod is requested or GetMultiShipMethod is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShipMethod(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shipMethod.SortClauses=sortClauses;
			_shipMethod.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
		/// <summary>
		/// Retrieves the related entity of type 'SalesTerritoryEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'SalesTerritoryEntity' which is related to this entity.</returns>
		public virtual SalesTerritoryEntity GetSingleSalesTerritory()
		{
			return GetSingleSalesTerritory(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'SalesTerritoryEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesTerritoryEntity' which is related to this entity.</returns>
		public virtual SalesTerritoryEntity GetSingleSalesTerritory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesTerritory || forceFetch || _alwaysFetchSalesTerritory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				SalesTerritoryEntity newEntity = new SalesTerritoryEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.TerritoryID);
				this.SalesTerritory = newEntity;

				_alreadyFetchedSalesTerritory = true;
			}
			return _salesTerritory;
		}
	
	
		/// <summary>
		/// Retrieves the related entity of type 'IndividualEntity', using a relation of type '1:1'
		/// </summary>
		/// <returns>A fetched entity of type 'IndividualEntity' which is related to this entity.</returns>
		public virtual IndividualEntity GetSingleIndividual()
		{
			return GetSingleIndividual(false);
		}
		
		
		/// <summary>
		/// Retrieves the related entity of type 'IndividualEntity', using a relation of type '1:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'IndividualEntity' which is related to this entity.</returns>
		public virtual IndividualEntity GetSingleIndividual(bool forceFetch)
		{
 			if( ( !_alreadyFetchedIndividual || forceFetch || _alwaysFetchIndividual) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				IndividualEntity newEntity = new IndividualEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				
				// fetch using PK
				newEntity.FetchUsingPK(this.CustomerID);
				
				
				
				this.Individual = newEntity;

				_alreadyFetchedIndividual = true;
			}
			return _individual;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'StoreEntity', using a relation of type '1:1'
		/// </summary>
		/// <returns>A fetched entity of type 'StoreEntity' which is related to this entity.</returns>
		public virtual StoreEntity GetSingleStore()
		{
			return GetSingleStore(false);
		}
		
		
		/// <summary>
		/// Retrieves the related entity of type 'StoreEntity', using a relation of type '1:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'StoreEntity' which is related to this entity.</returns>
		public virtual StoreEntity GetSingleStore(bool forceFetch)
		{
 			if( ( !_alreadyFetchedStore || forceFetch || _alwaysFetchStore) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				StoreEntity newEntity = new StoreEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				
				// fetch using PK
				newEntity.FetchUsingPK(this.CustomerID);
				
				
				
				this.Store = newEntity;

				_alreadyFetchedStore = true;
			}
			return _store;
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
		/// Event thrower for the TerritoryIDChanged event, which is thrown when TerritoryID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTerritoryIDChanged()
		{
			if(TerritoryIDChanged!=null)
			{
				TerritoryIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the AccountNumberChanged event, which is thrown when AccountNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnAccountNumberChanged()
		{
			if(AccountNumberChanged!=null)
			{
				AccountNumberChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CustomerTypeChanged event, which is thrown when CustomerType changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCustomerTypeChanged()
		{
			if(CustomerTypeChanged!=null)
			{
				CustomerTypeChanged(this, new EventArgs());
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
			CustomerDAO dao = DAOFactory.CreateCustomerDAO();
			return dao.AddCustomer(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CustomerDAO dao = DAOFactory.CreateCustomerDAO();
			return dao.UpdateCustomer(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CustomerDAO dao = DAOFactory.CreateCustomerDAO();
			return dao.UpdateCustomer(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.CustomerEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new CustomerValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="customerID">PK value for Customer which data should be fetched into this Customer object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this CustomerEntity</param>
		private void InitClassFetch(System.Int32 customerID, CustomerValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.CustomerEntity);
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
			_customerAddress = new CustomerAddressCollection(propertyDescriptorFactoryToUse, new CustomerAddressEntityFactory());
			_customerAddress.SetContainingEntityInfo(this, "Customer");
			_alwaysFetchCustomerAddress = false;
			_alreadyFetchedCustomerAddress = false;
			_salesOrderHeader = new SalesOrderHeaderCollection(propertyDescriptorFactoryToUse, new SalesOrderHeaderEntityFactory());
			_salesOrderHeader.SetContainingEntityInfo(this, "Customer");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_address = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_addressType = new AddressTypeCollection(propertyDescriptorFactoryToUse, new AddressTypeEntityFactory());
			_alwaysFetchAddressType = false;
			_alreadyFetchedAddressType = false;
			_address_ = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress_ = false;
			_alreadyFetchedAddress_ = false;
			_address__ = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress__ = false;
			_alreadyFetchedAddress__ = false;
			_creditCard = new CreditCardCollection(propertyDescriptorFactoryToUse, new CreditCardEntityFactory());
			_alwaysFetchCreditCard = false;
			_alreadyFetchedCreditCard = false;
			_currencyRate = new CurrencyRateCollection(propertyDescriptorFactoryToUse, new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRate = false;
			_alreadyFetchedCurrencyRate = false;
			_salesPerson = new SalesPersonCollection(propertyDescriptorFactoryToUse, new SalesPersonEntityFactory());
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
			_salesTerritory_ = new SalesTerritoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritory_ = false;
			_alreadyFetchedSalesTerritory_ = false;
			_shipMethod = new ShipMethodCollection(propertyDescriptorFactoryToUse, new ShipMethodEntityFactory());
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_salesTerritory = null;
			_alwaysFetchSalesTerritory = false;
			_alreadyFetchedSalesTerritory = false;
			_individual = null;
			_alwaysFetchIndividual = false;
			_alreadyFetchedIndividual = false;
			_store = null;
			_alwaysFetchStore = false;
			_alreadyFetchedStore = false;
		}


		/// <summary>
		/// Removes the sync logic for member _salesTerritory
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncSalesTerritory(bool signalRelatedEntity)
		{
			if(_salesTerritory != null)
			{
				// disconnect the entity from this entity
				_salesTerritory.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_salesTerritory.UnsetRelatedEntity(this, "Customer");
				}
				base.UnsetEntitySyncInformation("SalesTerritory", _salesTerritory, CustomerEntity.Relations.SalesTerritoryEntityUsingTerritoryID);
				_salesTerritory = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _salesTerritory
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesTerritory(IEntity relatedEntity)
		{
			DesetupSyncSalesTerritory(true);
			
			if(relatedEntity!=null)
			{
				_salesTerritory = (SalesTerritoryEntity)relatedEntity;
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("SalesTerritory", _salesTerritory, CustomerEntity.Relations.SalesTerritoryEntityUsingTerritoryID);
				if(!_salesTerritory.IsNew)
				{
					// sync now
					base.SyncFKFields(CustomerEntity.Relations.SalesTerritoryEntityUsingTerritoryID, _salesTerritory);
				}
			}

			_alreadyFetchedSalesTerritory = (relatedEntity != null);
		}


		/// <summary>
		/// Removes the sync logic for member _individual
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncIndividual(bool signalRelatedEntity)
		{
			if(_individual != null)
			{
				// disconnect the entity from this entity
				if(signalRelatedEntity)
				{
					_individual.UnsetRelatedEntity(this, "Customer");
				}


				_individual = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _individual
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncIndividual(IEntity relatedEntity)
		{
			DesetupSyncIndividual(true);
			
			if(relatedEntity!=null)
			{
				_individual = (IndividualEntity)relatedEntity;
				


			}

			_alreadyFetchedIndividual = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _store
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncStore(bool signalRelatedEntity)
		{
			if(_store != null)
			{
				// disconnect the entity from this entity
				if(signalRelatedEntity)
				{
					_store.UnsetRelatedEntity(this, "Customer");
				}


				_store = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _store
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStore(IEntity relatedEntity)
		{
			DesetupSyncStore(true);
			
			if(relatedEntity!=null)
			{
				_store = (StoreEntity)relatedEntity;
				


			}

			_alreadyFetchedStore = (relatedEntity != null);
		}


	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="customerID">PK value for Customer which data should be fetched into this Customer object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 customerID)
		{
			CustomerDAO dao = DAOFactory.CreateCustomerDAO();

			// Load EntityFields of Customer
			dao.FetchCustomer(base.Fields, base.Transaction, customerID);

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
		public static CustomerRelations Relations
		{
			get	{ return new CustomerRelations(); }
		}

	
		/// <summary>
		/// The CustomerID property of the Entity Customer
		/// </summary>
		public virtual System.Int32 CustomerID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerFieldIndex.CustomerID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CustomerID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerFieldIndex.CustomerID, value))
				{
					OnCustomerIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The TerritoryID property of the Entity Customer
		/// </summary>
		public virtual System.Int32 TerritoryID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerFieldIndex.TerritoryID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TerritoryID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerFieldIndex.TerritoryID, value))
				{
					OnTerritoryIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The AccountNumber property of the Entity Customer
		/// </summary>
		public virtual System.String AccountNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerFieldIndex.AccountNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AccountNumber because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerFieldIndex.AccountNumber, value))
				{
					OnAccountNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The CustomerType property of the Entity Customer
		/// </summary>
		public virtual System.String CustomerType
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerFieldIndex.CustomerType);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CustomerType because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerFieldIndex.CustomerType, value))
				{
					OnCustomerTypeChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity Customer
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity Customer
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CustomerFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CustomerFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
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
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesOrderHeaderCollection SalesOrderHeader
		{
			get
			{
				return GetMultiSalesOrderHeader(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesOrderHeader. When set to true, SalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeader(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeader
		{
			get
			{
				return _alwaysFetchSalesOrderHeader;
			}
			set
			{
				_alwaysFetchSalesOrderHeader = value;
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
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual AddressTypeCollection AddressType
		{
			get
			{
				return GetMultiAddressType(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for AddressType. When set to true, AddressType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressType is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressType(true).
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
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddress__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual AddressCollection Address__
		{
			get
			{
				return GetMultiAddress__(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Address__. When set to true, Address__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddress__(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress__
		{
			get
			{
				return _alwaysFetchAddress__;
			}
			set
			{
				_alwaysFetchAddress__ = value;
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
		/// Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CurrencyRateCollection CurrencyRate
		{
			get
			{
				return GetMultiCurrencyRate(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CurrencyRate. When set to true, CurrencyRate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRate is accessed. You can always execute
		/// a forced fetch by calling GetMultiCurrencyRate(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencyRate
		{
			get
			{
				return _alwaysFetchCurrencyRate;
			}
			set
			{
				_alwaysFetchCurrencyRate = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPerson()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesPersonCollection SalesPerson
		{
			get
			{
				return GetMultiSalesPerson(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesPerson. When set to true, SalesPerson is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesPerson(true).
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
		/// Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritory_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesTerritoryCollection SalesTerritory_
		{
			get
			{
				return GetMultiSalesTerritory_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesTerritory_. When set to true, SalesTerritory_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesTerritory_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritory_
		{
			get
			{
				return _alwaysFetchSalesTerritory_;
			}
			set
			{
				_alwaysFetchSalesTerritory_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethod()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ShipMethodCollection ShipMethod
		{
			get
			{
				return GetMultiShipMethod(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ShipMethod. When set to true, ShipMethod is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod is accessed. You can always execute
		/// a forced fetch by calling GetMultiShipMethod(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethod
		{
			get
			{
				return _alwaysFetchShipMethod;
			}
			set
			{
				_alwaysFetchShipMethod = value;
			}	
		}
	
	
		/// <summary>
		/// Gets / sets related entity of type 'SalesTerritoryEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesTerritory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get
			{
				return GetSingleSalesTerritory(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesTerritory(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesTerritory != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_salesTerritory.UnsetRelatedEntity(this, "Customer");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "Customer");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesTerritory. When set to true, SalesTerritory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesTerritory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritory
		{
			get
			{
				return _alwaysFetchSalesTerritory;
			}
			set
			{
				_alwaysFetchSalesTerritory = value;
			}	
		}
	
	
		/// <summary>
		/// Gets / sets related entity of type 'IndividualEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleIndividual()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual IndividualEntity Individual
		{
			get
			{
				return GetSingleIndividual(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncIndividual(value);
				}
				else
				{
					if(value==null)
					{
						// unset the sync info with the old value set for Individual. because we specify 'true', this will 
						// result in the signaling of the current value of Individual that the sync info has ended, as well.
						DesetupSyncIndividual(true);
					}
					else
					{
						// Tell related entity its related to us.
						IEntity relatedEntity = (IEntity)value;
						relatedEntity.SetRelatedEntity(this, "Customer");
						// set up syncing information to this new entity. Will take care of current entity.
						SetupSyncIndividual(relatedEntity);
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Individual. When set to true, Individual is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Individual is accessed. You can always execute
		/// a forced fetch by calling GetSingleIndividual(true).
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
		/// Gets / sets related entity of type 'StoreEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStore()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual StoreEntity Store
		{
			get
			{
				return GetSingleStore(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncStore(value);
				}
				else
				{
					if(value==null)
					{
						// unset the sync info with the old value set for Store. because we specify 'true', this will 
						// result in the signaling of the current value of Store that the sync info has ended, as well.
						DesetupSyncStore(true);
					}
					else
					{
						// Tell related entity its related to us.
						IEntity relatedEntity = (IEntity)value;
						relatedEntity.SetRelatedEntity(this, "Customer");
						// set up syncing information to this new entity. Will take care of current entity.
						SetupSyncStore(relatedEntity);
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Store. When set to true, Store is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Store is accessed. You can always execute
		/// a forced fetch by calling GetSingleStore(true).
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
