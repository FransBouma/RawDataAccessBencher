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
	/// Entity class which represents the entity 'SalesPerson' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class SalesPersonEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private SalesPersonQuotaHistoryCollection	_salesPersonQuotaHistory;
		private bool	_alwaysFetchSalesPersonQuotaHistory, _alreadyFetchedSalesPersonQuotaHistory;
		private SalesTerritoryHistoryCollection	_salesTerritoryHistory;
		private bool	_alwaysFetchSalesTerritoryHistory, _alreadyFetchedSalesTerritoryHistory;
		private StoreCollection	_store;
		private bool	_alwaysFetchStore, _alreadyFetchedStore;
		private AddressCollection _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private AddressCollection _address_;
		private bool	_alwaysFetchAddress_, _alreadyFetchedAddress_;
		private CreditCardCollection _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard;
		private CurrencyRateCollection _currencyRate;
		private bool	_alwaysFetchCurrencyRate, _alreadyFetchedCurrencyRate;
		private CustomerCollection _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer;
		private SalesTerritoryCollection _salesTerritory_;
		private bool	_alwaysFetchSalesTerritory_, _alreadyFetchedSalesTerritory_;
		private ShipMethodCollection _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;
		private SalesTerritoryCollection _salesTerritory__;
		private bool	_alwaysFetchSalesTerritory__, _alreadyFetchedSalesTerritory__;
		private SalesTerritoryEntity _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee;
		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when SalesPersonID changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesPersonIDChanged;

		/// <summary>
		/// Event which is thrown when TerritoryID changes value. Databinding related.
		/// </summary>
		public event EventHandler TerritoryIDChanged;

		/// <summary>
		/// Event which is thrown when SalesQuota changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesQuotaChanged;

		/// <summary>
		/// Event which is thrown when Bonus changes value. Databinding related.
		/// </summary>
		public event EventHandler BonusChanged;

		/// <summary>
		/// Event which is thrown when CommissionPct changes value. Databinding related.
		/// </summary>
		public event EventHandler CommissionPctChanged;

		/// <summary>
		/// Event which is thrown when SalesYTD changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesYTDChanged;

		/// <summary>
		/// Event which is thrown when SalesLastYear changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesLastYearChanged;

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
		public SalesPersonEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new SalesPersonEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesPersonID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		public SalesPersonEntity(System.Int32 salesPersonID)
		{
			InitClassFetch(salesPersonID, new SalesPersonValidator(), new PropertyDescriptorFactory(), new SalesPersonEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesPersonID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		public SalesPersonEntity(System.Int32 salesPersonID, SalesPersonValidator validator)
		{
			InitClassFetch(salesPersonID, validator, new PropertyDescriptorFactory(), new SalesPersonEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesPersonID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesPersonEntity(System.Int32 salesPersonID, SalesPersonValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(salesPersonID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesPersonEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private SalesPersonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_salesOrderHeader = (SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");

			_salesPersonQuotaHistory = (SalesPersonQuotaHistoryCollection)info.GetValue("_salesPersonQuotaHistory", typeof(SalesPersonQuotaHistoryCollection));
			_alwaysFetchSalesPersonQuotaHistory = info.GetBoolean("_alwaysFetchSalesPersonQuotaHistory");
			_alreadyFetchedSalesPersonQuotaHistory = info.GetBoolean("_alreadyFetchedSalesPersonQuotaHistory");

			_salesTerritoryHistory = (SalesTerritoryHistoryCollection)info.GetValue("_salesTerritoryHistory", typeof(SalesTerritoryHistoryCollection));
			_alwaysFetchSalesTerritoryHistory = info.GetBoolean("_alwaysFetchSalesTerritoryHistory");
			_alreadyFetchedSalesTerritoryHistory = info.GetBoolean("_alreadyFetchedSalesTerritoryHistory");

			_store = (StoreCollection)info.GetValue("_store", typeof(StoreCollection));
			_alwaysFetchStore = info.GetBoolean("_alwaysFetchStore");
			_alreadyFetchedStore = info.GetBoolean("_alreadyFetchedStore");

			_address = (AddressCollection)info.GetValue("_address", typeof(AddressCollection));
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");

			_address_ = (AddressCollection)info.GetValue("_address_", typeof(AddressCollection));
			_alwaysFetchAddress_ = info.GetBoolean("_alwaysFetchAddress_");
			_alreadyFetchedAddress_ = info.GetBoolean("_alreadyFetchedAddress_");

			_creditCard = (CreditCardCollection)info.GetValue("_creditCard", typeof(CreditCardCollection));
			_alwaysFetchCreditCard = info.GetBoolean("_alwaysFetchCreditCard");
			_alreadyFetchedCreditCard = info.GetBoolean("_alreadyFetchedCreditCard");

			_currencyRate = (CurrencyRateCollection)info.GetValue("_currencyRate", typeof(CurrencyRateCollection));
			_alwaysFetchCurrencyRate = info.GetBoolean("_alwaysFetchCurrencyRate");
			_alreadyFetchedCurrencyRate = info.GetBoolean("_alreadyFetchedCurrencyRate");

			_customer = (CustomerCollection)info.GetValue("_customer", typeof(CustomerCollection));
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

			_salesTerritory_ = (SalesTerritoryCollection)info.GetValue("_salesTerritory_", typeof(SalesTerritoryCollection));
			_alwaysFetchSalesTerritory_ = info.GetBoolean("_alwaysFetchSalesTerritory_");
			_alreadyFetchedSalesTerritory_ = info.GetBoolean("_alreadyFetchedSalesTerritory_");

			_shipMethod = (ShipMethodCollection)info.GetValue("_shipMethod", typeof(ShipMethodCollection));
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

			_salesTerritory__ = (SalesTerritoryCollection)info.GetValue("_salesTerritory__", typeof(SalesTerritoryCollection));
			_alwaysFetchSalesTerritory__ = info.GetBoolean("_alwaysFetchSalesTerritory__");
			_alreadyFetchedSalesTerritory__ = info.GetBoolean("_alreadyFetchedSalesTerritory__");
			_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
			if(_salesTerritory!=null)
			{
				// rewire event handler.
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				// rewire event handler.
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
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
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);
			_alreadyFetchedSalesPersonQuotaHistory = (_salesPersonQuotaHistory.Count > 0);
			_alreadyFetchedSalesTerritoryHistory = (_salesTerritoryHistory.Count > 0);
			_alreadyFetchedStore = (_store.Count > 0);
			_alreadyFetchedAddress = (_address.Count > 0);
			_alreadyFetchedAddress_ = (_address_.Count > 0);
			_alreadyFetchedCreditCard = (_creditCard.Count > 0);
			_alreadyFetchedCurrencyRate = (_currencyRate.Count > 0);
			_alreadyFetchedCustomer = (_customer.Count > 0);
			_alreadyFetchedSalesTerritory_ = (_salesTerritory_.Count > 0);
			_alreadyFetchedShipMethod = (_shipMethod.Count > 0);
			_alreadyFetchedSalesTerritory__ = (_salesTerritory__.Count > 0);
			_alreadyFetchedSalesTerritory = (_salesTerritory != null);
			_alreadyFetchedEmployee = (_employee != null);
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
			info.AddValue("_salesOrderHeader", _salesOrderHeader);
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_salesPersonQuotaHistory", _salesPersonQuotaHistory);
			info.AddValue("_alwaysFetchSalesPersonQuotaHistory", _alwaysFetchSalesPersonQuotaHistory);
			info.AddValue("_alreadyFetchedSalesPersonQuotaHistory", _alreadyFetchedSalesPersonQuotaHistory);
			info.AddValue("_salesTerritoryHistory", _salesTerritoryHistory);
			info.AddValue("_alwaysFetchSalesTerritoryHistory", _alwaysFetchSalesTerritoryHistory);
			info.AddValue("_alreadyFetchedSalesTerritoryHistory", _alreadyFetchedSalesTerritoryHistory);
			info.AddValue("_store", _store);
			info.AddValue("_alwaysFetchStore", _alwaysFetchStore);
			info.AddValue("_alreadyFetchedStore", _alreadyFetchedStore);
			info.AddValue("_address", _address);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_address_", _address_);
			info.AddValue("_alwaysFetchAddress_", _alwaysFetchAddress_);
			info.AddValue("_alreadyFetchedAddress_", _alreadyFetchedAddress_);
			info.AddValue("_creditCard", _creditCard);
			info.AddValue("_alwaysFetchCreditCard", _alwaysFetchCreditCard);
			info.AddValue("_alreadyFetchedCreditCard", _alreadyFetchedCreditCard);
			info.AddValue("_currencyRate", _currencyRate);
			info.AddValue("_alwaysFetchCurrencyRate", _alwaysFetchCurrencyRate);
			info.AddValue("_alreadyFetchedCurrencyRate", _alreadyFetchedCurrencyRate);
			info.AddValue("_customer", _customer);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);
			info.AddValue("_salesTerritory_", _salesTerritory_);
			info.AddValue("_alwaysFetchSalesTerritory_", _alwaysFetchSalesTerritory_);
			info.AddValue("_alreadyFetchedSalesTerritory_", _alreadyFetchedSalesTerritory_);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_salesTerritory__", _salesTerritory__);
			info.AddValue("_alwaysFetchSalesTerritory__", _alwaysFetchSalesTerritory__);
			info.AddValue("_alreadyFetchedSalesTerritory__", _alreadyFetchedSalesTerritory__);
			info.AddValue("_salesTerritory", _salesTerritory);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);
			info.AddValue("_employee", _employee);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
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
				case "SalesOrderHeader":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesOrderHeader.Add(relatedEntity);
					break;
				case "SalesPersonQuotaHistory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesPersonQuotaHistory.Add(relatedEntity);
					break;
				case "SalesTerritoryHistory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesTerritoryHistory.Add(relatedEntity);
					break;
				case "Store":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_store.Add(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
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
				case "SalesOrderHeader":
					// Remove it from the collection.
					_salesOrderHeader.Remove(relatedEntity);
					break;
				case "SalesPersonQuotaHistory":
					// Remove it from the collection.
					_salesPersonQuotaHistory.Remove(relatedEntity);
					break;
				case "SalesTerritoryHistory":
					// Remove it from the collection.
					_salesTerritoryHistory.Remove(relatedEntity);
					break;
				case "Store":
					// Remove it from the collection.
					_store.Remove(relatedEntity);
					break;
				case "Employee":
					DesetupSyncEmployee(false);
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
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}

			
			if(_employee!=null)
			{
				toReturn.Add(_employee);
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

			toReturn.Add(_salesOrderHeader);
			toReturn.Add(_salesPersonQuotaHistory);
			toReturn.Add(_salesTerritoryHistory);
			toReturn.Add(_store);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("SalesPersonEntity");
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
		/// <param name="salesPersonID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesPersonID)
		{
			return Fetch(salesPersonID);
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
			return Fetch(this.SalesPersonID);
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
			SalesPersonDAO dao = DAOFactory.CreateSalesPersonDAO();
			bool wasSuccesful = dao.DeleteSalesPerson(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(SalesPersonFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, this, null, null);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, this, null, null, filter);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, this, null, null);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, this, null, null, filter);
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
		/// Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonQuotaHistoryEntity'</returns>
		public virtual SalesPersonQuotaHistoryCollection GetMultiSalesPersonQuotaHistory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesPersonQuotaHistory || forceFetch || _alwaysFetchSalesPersonQuotaHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPersonQuotaHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPersonQuotaHistory);
					}
				}
				_salesPersonQuotaHistory.SuppressClearInGetMulti=!forceFetch;
				_salesPersonQuotaHistory.GetMultiManyToOne(this);
				_salesPersonQuotaHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPersonQuotaHistory = true;
			}
			return _salesPersonQuotaHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonQuotaHistoryEntity'</returns>
		public virtual SalesPersonQuotaHistoryCollection GetMultiSalesPersonQuotaHistory(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesPersonQuotaHistory || forceFetch || _alwaysFetchSalesPersonQuotaHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPersonQuotaHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPersonQuotaHistory);
					}
				}
				_salesPersonQuotaHistory.SuppressClearInGetMulti=!forceFetch;
				_salesPersonQuotaHistory.GetMultiManyToOne(this, filter);
				_salesPersonQuotaHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPersonQuotaHistory = true;
			}
			return _salesPersonQuotaHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesPersonQuotaHistoryCollection GetMultiSalesPersonQuotaHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesPersonQuotaHistory || forceFetch || _alwaysFetchSalesPersonQuotaHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPersonQuotaHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPersonQuotaHistory);
					}
				}
				_salesPersonQuotaHistory.SuppressClearInGetMulti=!forceFetch;
				_salesPersonQuotaHistory.EntityFactoryToUse = entityFactoryToUse;
				_salesPersonQuotaHistory.GetMultiManyToOne(this);
				_salesPersonQuotaHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPersonQuotaHistory = true;
			}
			return _salesPersonQuotaHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesPersonQuotaHistoryCollection GetMultiSalesPersonQuotaHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesPersonQuotaHistory || forceFetch || _alwaysFetchSalesPersonQuotaHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPersonQuotaHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPersonQuotaHistory);
					}
				}
				_salesPersonQuotaHistory.SuppressClearInGetMulti=!forceFetch;
				_salesPersonQuotaHistory.EntityFactoryToUse = entityFactoryToUse;
				_salesPersonQuotaHistory.GetMultiManyToOne(this, filter);
				_salesPersonQuotaHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPersonQuotaHistory = true;
			}
			return _salesPersonQuotaHistory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesPersonQuotaHistory'. These settings will be taken into account
		/// when the property SalesPersonQuotaHistory is requested or GetMultiSalesPersonQuotaHistory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPersonQuotaHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPersonQuotaHistory.SortClauses=sortClauses;
			_salesPersonQuotaHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryHistoryEntity'</returns>
		public virtual SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesTerritoryHistory || forceFetch || _alwaysFetchSalesTerritoryHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritoryHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritoryHistory);
					}
				}
				_salesTerritoryHistory.SuppressClearInGetMulti=!forceFetch;
				_salesTerritoryHistory.GetMultiManyToOne(this, null);
				_salesTerritoryHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryHistory = true;
			}
			return _salesTerritoryHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryHistoryEntity'</returns>
		public virtual SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistory(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesTerritoryHistory || forceFetch || _alwaysFetchSalesTerritoryHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritoryHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritoryHistory);
					}
				}
				_salesTerritoryHistory.SuppressClearInGetMulti=!forceFetch;
				_salesTerritoryHistory.GetMultiManyToOne(this, null, filter);
				_salesTerritoryHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryHistory = true;
			}
			return _salesTerritoryHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesTerritoryHistory || forceFetch || _alwaysFetchSalesTerritoryHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritoryHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritoryHistory);
					}
				}
				_salesTerritoryHistory.SuppressClearInGetMulti=!forceFetch;
				_salesTerritoryHistory.EntityFactoryToUse = entityFactoryToUse;
				_salesTerritoryHistory.GetMultiManyToOne(this, null);
				_salesTerritoryHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryHistory = true;
			}
			return _salesTerritoryHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesTerritoryHistoryCollection GetMultiSalesTerritoryHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesTerritoryHistory || forceFetch || _alwaysFetchSalesTerritoryHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritoryHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritoryHistory);
					}
				}
				_salesTerritoryHistory.SuppressClearInGetMulti=!forceFetch;
				_salesTerritoryHistory.EntityFactoryToUse = entityFactoryToUse;
				_salesTerritoryHistory.GetMultiManyToOne(this, null, filter);
				_salesTerritoryHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritoryHistory = true;
			}
			return _salesTerritoryHistory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesTerritoryHistory'. These settings will be taken into account
		/// when the property SalesTerritoryHistory is requested or GetMultiSalesTerritoryHistory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritoryHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritoryHistory.SortClauses=sortClauses;
			_salesTerritoryHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.
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
				_store.GetMultiManyToOne(this);
				_store.SuppressClearInGetMulti=false;
				_alreadyFetchedStore = true;
			}
			return _store;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StoreEntity'</returns>
		public virtual StoreCollection GetMultiStore(bool forceFetch, IPredicateExpression filter)
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
				_store.GetMultiManyToOne(this, filter);
				_store.SuppressClearInGetMulti=false;
				_alreadyFetchedStore = true;
			}
			return _store;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
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
				_store.GetMultiManyToOne(this);
				_store.SuppressClearInGetMulti=false;
				_alreadyFetchedStore = true;
			}
			return _store;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual StoreCollection GetMultiStore(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
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
				_store.GetMultiManyToOne(this, filter);
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
				_address.GetMultiManyToManyUsingSalesPerson(this);
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
				_address.GetMultiManyToManyUsingSalesPerson(this);
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
				_address_.GetMultiManyToManyUsingSalesPerson_(this);
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
				_address_.GetMultiManyToManyUsingSalesPerson_(this);
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
				_creditCard.GetMultiManyToManyUsingSalesPerson(this);
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
				_creditCard.GetMultiManyToManyUsingSalesPerson(this);
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
				_currencyRate.GetMultiManyToManyUsingSalesPerson(this);
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
				_currencyRate.GetMultiManyToManyUsingSalesPerson(this);
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
				_customer.GetMultiManyToManyUsingSalesPerson(this);
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
				_customer.GetMultiManyToManyUsingSalesPerson(this);
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
				_salesTerritory_.GetMultiManyToManyUsingSalesPerson_(this);
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
				_salesTerritory_.GetMultiManyToManyUsingSalesPerson_(this);
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
				_shipMethod.GetMultiManyToManyUsingSalesPerson(this);
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
				_shipMethod.GetMultiManyToManyUsingSalesPerson(this);
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
		/// Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesTerritoryEntity'</returns>
		public virtual SalesTerritoryCollection GetMultiSalesTerritory__(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesTerritory__ || forceFetch || _alwaysFetchSalesTerritory__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritory__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritory__);
					}
				}
				_salesTerritory__.SuppressClearInGetMulti=!forceFetch;
				_salesTerritory__.GetMultiManyToManyUsingSalesPerson__(this);
				_salesTerritory__.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritory__ = true;
			}
			return _salesTerritory__;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesTerritoryCollection GetMultiSalesTerritory__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesTerritory__ || forceFetch || _alwaysFetchSalesTerritory__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritory__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritory__);
					}
				}
				_salesTerritory__.SuppressClearInGetMulti=!forceFetch;
				_salesTerritory__.EntityFactoryToUse = entityFactoryToUse;
				_salesTerritory__.GetMultiManyToManyUsingSalesPerson__(this);
				_salesTerritory__.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritory__ = true;
			}
			return _salesTerritory__;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesTerritory__'. These settings will be taken into account
		/// when the property SalesTerritory__ is requested or GetMultiSalesTerritory__ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritory__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritory__.SortClauses=sortClauses;
			_salesTerritory__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
		/// Retrieves the related entity of type 'EmployeeEntity', using a relation of type '1:1'
		/// </summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee()
		{
			return GetSingleEmployee(false);
		}
		
		
		/// <summary>
		/// Retrieves the related entity of type 'EmployeeEntity', using a relation of type '1:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				
				// fetch using PK
				newEntity.FetchUsingPK(this.SalesPersonID);
				
				
				
				this.Employee = newEntity;

				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}
	
	
		#region Data binding change event raising methods
	
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
		/// Event thrower for the SalesQuotaChanged event, which is thrown when SalesQuota changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSalesQuotaChanged()
		{
			if(SalesQuotaChanged!=null)
			{
				SalesQuotaChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the BonusChanged event, which is thrown when Bonus changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnBonusChanged()
		{
			if(BonusChanged!=null)
			{
				BonusChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CommissionPctChanged event, which is thrown when CommissionPct changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCommissionPctChanged()
		{
			if(CommissionPctChanged!=null)
			{
				CommissionPctChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SalesYTDChanged event, which is thrown when SalesYTD changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSalesYTDChanged()
		{
			if(SalesYTDChanged!=null)
			{
				SalesYTDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SalesLastYearChanged event, which is thrown when SalesLastYear changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSalesLastYearChanged()
		{
			if(SalesLastYearChanged!=null)
			{
				SalesLastYearChanged(this, new EventArgs());
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
			SalesPersonDAO dao = DAOFactory.CreateSalesPersonDAO();
			return dao.AddSalesPerson(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesPersonDAO dao = DAOFactory.CreateSalesPersonDAO();
			return dao.UpdateSalesPerson(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesPersonDAO dao = DAOFactory.CreateSalesPersonDAO();
			return dao.UpdateSalesPerson(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SalesPersonEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new SalesPersonValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="salesPersonID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this SalesPersonEntity</param>
		private void InitClassFetch(System.Int32 salesPersonID, SalesPersonValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SalesPersonEntity);
			bool wasSuccesful = Fetch(salesPersonID);
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
			_salesOrderHeader = new SalesOrderHeaderCollection(propertyDescriptorFactoryToUse, new SalesOrderHeaderEntityFactory());
			_salesOrderHeader.SetContainingEntityInfo(this, "SalesPerson");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_salesPersonQuotaHistory = new SalesPersonQuotaHistoryCollection(propertyDescriptorFactoryToUse, new SalesPersonQuotaHistoryEntityFactory());
			_salesPersonQuotaHistory.SetContainingEntityInfo(this, "SalesPerson");
			_alwaysFetchSalesPersonQuotaHistory = false;
			_alreadyFetchedSalesPersonQuotaHistory = false;
			_salesTerritoryHistory = new SalesTerritoryHistoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryHistoryEntityFactory());
			_salesTerritoryHistory.SetContainingEntityInfo(this, "SalesPerson");
			_alwaysFetchSalesTerritoryHistory = false;
			_alreadyFetchedSalesTerritoryHistory = false;
			_store = new StoreCollection(propertyDescriptorFactoryToUse, new StoreEntityFactory());
			_store.SetContainingEntityInfo(this, "SalesPerson");
			_alwaysFetchStore = false;
			_alreadyFetchedStore = false;
			_address = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_address_ = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress_ = false;
			_alreadyFetchedAddress_ = false;
			_creditCard = new CreditCardCollection(propertyDescriptorFactoryToUse, new CreditCardEntityFactory());
			_alwaysFetchCreditCard = false;
			_alreadyFetchedCreditCard = false;
			_currencyRate = new CurrencyRateCollection(propertyDescriptorFactoryToUse, new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRate = false;
			_alreadyFetchedCurrencyRate = false;
			_customer = new CustomerCollection(propertyDescriptorFactoryToUse, new CustomerEntityFactory());
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;
			_salesTerritory_ = new SalesTerritoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritory_ = false;
			_alreadyFetchedSalesTerritory_ = false;
			_shipMethod = new ShipMethodCollection(propertyDescriptorFactoryToUse, new ShipMethodEntityFactory());
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_salesTerritory__ = new SalesTerritoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritory__ = false;
			_alreadyFetchedSalesTerritory__ = false;
			_salesTerritory = null;
			_alwaysFetchSalesTerritory = false;
			_alreadyFetchedSalesTerritory = false;
			_employee = null;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
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
					_salesTerritory.UnsetRelatedEntity(this, "SalesPerson");
				}
				base.UnsetEntitySyncInformation("SalesTerritory", _salesTerritory, SalesPersonEntity.Relations.SalesTerritoryEntityUsingTerritoryID);
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
				base.SetEntitySyncInformation("SalesTerritory", _salesTerritory, SalesPersonEntity.Relations.SalesTerritoryEntityUsingTerritoryID);
				if(!_salesTerritory.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesPersonEntity.Relations.SalesTerritoryEntityUsingTerritoryID, _salesTerritory);
				}
			}

			_alreadyFetchedSalesTerritory = (relatedEntity != null);
		}


		/// <summary>
		/// Removes the sync logic for member _employee
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity)
		{
			if(_employee != null)
			{
				// disconnect the entity from this entity
				if(signalRelatedEntity)
				{
					_employee.UnsetRelatedEntity(this, "SalesPerson");
				}

				_employee.AfterSave-=new EventHandler(OnEntityAfterSave);
				base.UnsetEntitySyncInformation("Employee", _employee, SalesPersonEntity.Relations.EmployeeEntityUsingSalesPersonID);

				_employee = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _employee
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntity relatedEntity)
		{
			DesetupSyncEmployee(true);
			
			if(relatedEntity!=null)
			{
				_employee = (EmployeeEntity)relatedEntity;
				
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Employee", _employee, SalesPersonEntity.Relations.EmployeeEntityUsingSalesPersonID);
				if(!_employee.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesPersonEntity.Relations.EmployeeEntityUsingSalesPersonID, _employee);
				}

			}

			_alreadyFetchedEmployee = (relatedEntity != null);
		}


	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="salesPersonID">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesPersonID)
		{
			SalesPersonDAO dao = DAOFactory.CreateSalesPersonDAO();

			// Load EntityFields of SalesPerson
			dao.FetchSalesPerson(base.Fields, base.Transaction, salesPersonID);

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
		public static SalesPersonRelations Relations
		{
			get	{ return new SalesPersonRelations(); }
		}

	
		/// <summary>
		/// The SalesPersonID property of the Entity SalesPerson
		/// </summary>
		public virtual System.Int32 SalesPersonID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.SalesPersonID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesPersonID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.SalesPersonID, value))
				{
					OnSalesPersonIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The TerritoryID property of the Entity SalesPerson
		/// </summary>
		public virtual System.Int32 TerritoryID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.TerritoryID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TerritoryID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.TerritoryID, value))
				{
					OnTerritoryIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesQuota property of the Entity SalesPerson
		/// </summary>
		public virtual System.Decimal SalesQuota
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.SalesQuota);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesQuota because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.SalesQuota, value))
				{
					OnSalesQuotaChanged();
				}
			}
		}
	
		/// <summary>
		/// The Bonus property of the Entity SalesPerson
		/// </summary>
		public virtual System.Decimal Bonus
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.Bonus);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Bonus because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.Bonus, value))
				{
					OnBonusChanged();
				}
			}
		}
	
		/// <summary>
		/// The CommissionPct property of the Entity SalesPerson
		/// </summary>
		public virtual System.Decimal CommissionPct
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.CommissionPct);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CommissionPct because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.CommissionPct, value))
				{
					OnCommissionPctChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesYTD property of the Entity SalesPerson
		/// </summary>
		public virtual System.Decimal SalesYTD
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.SalesYTD);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesYTD because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.SalesYTD, value))
				{
					OnSalesYTDChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesLastYear property of the Entity SalesPerson
		/// </summary>
		public virtual System.Decimal SalesLastYear
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.SalesLastYear);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesLastYear because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.SalesLastYear, value))
				{
					OnSalesLastYearChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity SalesPerson
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity SalesPerson
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesPersonFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesPersonFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
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
		/// Retrieves all related entities of type 'SalesPersonQuotaHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPersonQuotaHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesPersonQuotaHistoryCollection SalesPersonQuotaHistory
		{
			get
			{
				return GetMultiSalesPersonQuotaHistory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesPersonQuotaHistory. When set to true, SalesPersonQuotaHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPersonQuotaHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesPersonQuotaHistory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPersonQuotaHistory
		{
			get
			{
				return _alwaysFetchSalesPersonQuotaHistory;
			}
			set
			{
				_alwaysFetchSalesPersonQuotaHistory = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritoryHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesTerritoryHistoryCollection SalesTerritoryHistory
		{
			get
			{
				return GetMultiSalesTerritoryHistory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesTerritoryHistory. When set to true, SalesTerritoryHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritoryHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesTerritoryHistory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritoryHistory
		{
			get
			{
				return _alwaysFetchSalesTerritoryHistory;
			}
			set
			{
				_alwaysFetchSalesTerritoryHistory = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'StoreEntity' using a relation of type '1:n'.
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
		/// Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritory__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesTerritoryCollection SalesTerritory__
		{
			get
			{
				return GetMultiSalesTerritory__(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesTerritory__. When set to true, SalesTerritory__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesTerritory__(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesTerritory__
		{
			get
			{
				return _alwaysFetchSalesTerritory__;
			}
			set
			{
				_alwaysFetchSalesTerritory__ = value;
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
							_salesTerritory.UnsetRelatedEntity(this, "SalesPerson");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesPerson");
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
		/// Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get
			{
				return GetSingleEmployee(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					if(value==null)
					{
						// unset the sync info with the old value set for Employee. because we specify 'true', this will 
						// result in the signaling of the current value of Employee that the sync info has ended, as well.
						DesetupSyncEmployee(true);
					}
					else
					{
						// Tell related entity its related to us.
						IEntity relatedEntity = (IEntity)value;
						relatedEntity.SetRelatedEntity(this, "SalesPerson");
						// set up syncing information to this new entity. Will take care of current entity.
						SetupSyncEmployee(relatedEntity);
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee(true).
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
	
		#endregion
	}
}
