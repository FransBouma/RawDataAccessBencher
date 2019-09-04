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
	/// Entity class which represents the entity 'SalesTerritory' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class SalesTerritoryEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private StateProvinceCollection	_stateProvince;
		private bool	_alwaysFetchStateProvince, _alreadyFetchedStateProvince;
		private CustomerCollection	_customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer;
		private SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private SalesPersonCollection	_salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson;
		private SalesTerritoryHistoryCollection	_salesTerritoryHistory;
		private bool	_alwaysFetchSalesTerritoryHistory, _alreadyFetchedSalesTerritoryHistory;
		private CountryRegionCollection _countryRegion;
		private bool	_alwaysFetchCountryRegion, _alreadyFetchedCountryRegion;
		private AddressCollection _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private AddressCollection _address_;
		private bool	_alwaysFetchAddress_, _alreadyFetchedAddress_;
		private CreditCardCollection _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard;
		private CurrencyRateCollection _currencyRate;
		private bool	_alwaysFetchCurrencyRate, _alreadyFetchedCurrencyRate;
		private CustomerCollection _customer_;
		private bool	_alwaysFetchCustomer_, _alreadyFetchedCustomer_;
		private SalesPersonCollection _salesPerson_;
		private bool	_alwaysFetchSalesPerson_, _alreadyFetchedSalesPerson_;
		private ShipMethodCollection _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;
		private SalesPersonCollection _salesPerson__;
		private bool	_alwaysFetchSalesPerson__, _alreadyFetchedSalesPerson__;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when TerritoryID changes value. Databinding related.
		/// </summary>
		public event EventHandler TerritoryIDChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

		/// <summary>
		/// Event which is thrown when CountryRegionCode changes value. Databinding related.
		/// </summary>
		public event EventHandler CountryRegionCodeChanged;

		/// <summary>
		/// Event which is thrown when Group changes value. Databinding related.
		/// </summary>
		public event EventHandler GroupChanged;

		/// <summary>
		/// Event which is thrown when SalesYTD changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesYTDChanged;

		/// <summary>
		/// Event which is thrown when SalesLastYear changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesLastYearChanged;

		/// <summary>
		/// Event which is thrown when CostYTD changes value. Databinding related.
		/// </summary>
		public event EventHandler CostYTDChanged;

		/// <summary>
		/// Event which is thrown when CostLastYear changes value. Databinding related.
		/// </summary>
		public event EventHandler CostLastYearChanged;

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
		public SalesTerritoryEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new SalesTerritoryEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		public SalesTerritoryEntity(System.Int32 territoryID)
		{
			InitClassFetch(territoryID, new SalesTerritoryValidator(), new PropertyDescriptorFactory(), new SalesTerritoryEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="validator">The custom validator object for this SalesTerritoryEntity</param>
		public SalesTerritoryEntity(System.Int32 territoryID, SalesTerritoryValidator validator)
		{
			InitClassFetch(territoryID, validator, new PropertyDescriptorFactory(), new SalesTerritoryEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="validator">The custom validator object for this SalesTerritoryEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesTerritoryEntity(System.Int32 territoryID, SalesTerritoryValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(territoryID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesTerritoryEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private SalesTerritoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_stateProvince = (StateProvinceCollection)info.GetValue("_stateProvince", typeof(StateProvinceCollection));
			_alwaysFetchStateProvince = info.GetBoolean("_alwaysFetchStateProvince");
			_alreadyFetchedStateProvince = info.GetBoolean("_alreadyFetchedStateProvince");

			_customer = (CustomerCollection)info.GetValue("_customer", typeof(CustomerCollection));
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

			_salesOrderHeader = (SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");

			_salesPerson = (SalesPersonCollection)info.GetValue("_salesPerson", typeof(SalesPersonCollection));
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");

			_salesTerritoryHistory = (SalesTerritoryHistoryCollection)info.GetValue("_salesTerritoryHistory", typeof(SalesTerritoryHistoryCollection));
			_alwaysFetchSalesTerritoryHistory = info.GetBoolean("_alwaysFetchSalesTerritoryHistory");
			_alreadyFetchedSalesTerritoryHistory = info.GetBoolean("_alreadyFetchedSalesTerritoryHistory");

			_countryRegion = (CountryRegionCollection)info.GetValue("_countryRegion", typeof(CountryRegionCollection));
			_alwaysFetchCountryRegion = info.GetBoolean("_alwaysFetchCountryRegion");
			_alreadyFetchedCountryRegion = info.GetBoolean("_alreadyFetchedCountryRegion");

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

			_customer_ = (CustomerCollection)info.GetValue("_customer_", typeof(CustomerCollection));
			_alwaysFetchCustomer_ = info.GetBoolean("_alwaysFetchCustomer_");
			_alreadyFetchedCustomer_ = info.GetBoolean("_alreadyFetchedCustomer_");

			_salesPerson_ = (SalesPersonCollection)info.GetValue("_salesPerson_", typeof(SalesPersonCollection));
			_alwaysFetchSalesPerson_ = info.GetBoolean("_alwaysFetchSalesPerson_");
			_alreadyFetchedSalesPerson_ = info.GetBoolean("_alreadyFetchedSalesPerson_");

			_shipMethod = (ShipMethodCollection)info.GetValue("_shipMethod", typeof(ShipMethodCollection));
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

			_salesPerson__ = (SalesPersonCollection)info.GetValue("_salesPerson__", typeof(SalesPersonCollection));
			_alwaysFetchSalesPerson__ = info.GetBoolean("_alwaysFetchSalesPerson__");
			_alreadyFetchedSalesPerson__ = info.GetBoolean("_alreadyFetchedSalesPerson__");


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
			_alreadyFetchedStateProvince = (_stateProvince.Count > 0);
			_alreadyFetchedCustomer = (_customer.Count > 0);
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);
			_alreadyFetchedSalesPerson = (_salesPerson.Count > 0);
			_alreadyFetchedSalesTerritoryHistory = (_salesTerritoryHistory.Count > 0);
			_alreadyFetchedCountryRegion = (_countryRegion.Count > 0);
			_alreadyFetchedAddress = (_address.Count > 0);
			_alreadyFetchedAddress_ = (_address_.Count > 0);
			_alreadyFetchedCreditCard = (_creditCard.Count > 0);
			_alreadyFetchedCurrencyRate = (_currencyRate.Count > 0);
			_alreadyFetchedCustomer_ = (_customer_.Count > 0);
			_alreadyFetchedSalesPerson_ = (_salesPerson_.Count > 0);
			_alreadyFetchedShipMethod = (_shipMethod.Count > 0);
			_alreadyFetchedSalesPerson__ = (_salesPerson__.Count > 0);


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
			info.AddValue("_stateProvince", _stateProvince);
			info.AddValue("_alwaysFetchStateProvince", _alwaysFetchStateProvince);
			info.AddValue("_alreadyFetchedStateProvince", _alreadyFetchedStateProvince);
			info.AddValue("_customer", _customer);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);
			info.AddValue("_salesOrderHeader", _salesOrderHeader);
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_salesPerson", _salesPerson);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
			info.AddValue("_salesTerritoryHistory", _salesTerritoryHistory);
			info.AddValue("_alwaysFetchSalesTerritoryHistory", _alwaysFetchSalesTerritoryHistory);
			info.AddValue("_alreadyFetchedSalesTerritoryHistory", _alreadyFetchedSalesTerritoryHistory);
			info.AddValue("_countryRegion", _countryRegion);
			info.AddValue("_alwaysFetchCountryRegion", _alwaysFetchCountryRegion);
			info.AddValue("_alreadyFetchedCountryRegion", _alreadyFetchedCountryRegion);
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
			info.AddValue("_customer_", _customer_);
			info.AddValue("_alwaysFetchCustomer_", _alwaysFetchCustomer_);
			info.AddValue("_alreadyFetchedCustomer_", _alreadyFetchedCustomer_);
			info.AddValue("_salesPerson_", _salesPerson_);
			info.AddValue("_alwaysFetchSalesPerson_", _alwaysFetchSalesPerson_);
			info.AddValue("_alreadyFetchedSalesPerson_", _alreadyFetchedSalesPerson_);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_salesPerson__", _salesPerson__);
			info.AddValue("_alwaysFetchSalesPerson__", _alwaysFetchSalesPerson__);
			info.AddValue("_alreadyFetchedSalesPerson__", _alreadyFetchedSalesPerson__);


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

				case "StateProvince":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_stateProvince.Add(relatedEntity);
					break;
				case "Customer":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_customer.Add(relatedEntity);
					break;
				case "SalesOrderHeader":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesOrderHeader.Add(relatedEntity);
					break;
				case "SalesPerson":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesPerson.Add(relatedEntity);
					break;
				case "SalesTerritoryHistory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesTerritoryHistory.Add(relatedEntity);
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

				case "StateProvince":
					// Remove it from the collection.
					_stateProvince.Remove(relatedEntity);
					break;
				case "Customer":
					// Remove it from the collection.
					_customer.Remove(relatedEntity);
					break;
				case "SalesOrderHeader":
					// Remove it from the collection.
					_salesOrderHeader.Remove(relatedEntity);
					break;
				case "SalesPerson":
					// Remove it from the collection.
					_salesPerson.Remove(relatedEntity);
					break;
				case "SalesTerritoryHistory":
					// Remove it from the collection.
					_salesTerritoryHistory.Remove(relatedEntity);
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

			toReturn.Add(_stateProvince);
			toReturn.Add(_customer);
			toReturn.Add(_salesOrderHeader);
			toReturn.Add(_salesPerson);
			toReturn.Add(_salesTerritoryHistory);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("SalesTerritoryEntity");
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
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 territoryID)
		{
			return Fetch(territoryID);
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
			return Fetch(this.TerritoryID);
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
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			bool wasSuccesful = dao.DeleteSalesTerritory(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(SalesTerritoryFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'StateProvinceEntity'</returns>
		public virtual StateProvinceCollection GetMultiStateProvince(bool forceFetch)
		{
 			if( ( !_alreadyFetchedStateProvince || forceFetch || _alwaysFetchStateProvince) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_stateProvince.ParticipatesInTransaction)
					{
						base.Transaction.Add(_stateProvince);
					}
				}
				_stateProvince.SuppressClearInGetMulti=!forceFetch;
				_stateProvince.GetMultiManyToOne(null, this);
				_stateProvince.SuppressClearInGetMulti=false;
				_alreadyFetchedStateProvince = true;
			}
			return _stateProvince;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'StateProvinceEntity'</returns>
		public virtual StateProvinceCollection GetMultiStateProvince(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStateProvince || forceFetch || _alwaysFetchStateProvince) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_stateProvince.ParticipatesInTransaction)
					{
						base.Transaction.Add(_stateProvince);
					}
				}
				_stateProvince.SuppressClearInGetMulti=!forceFetch;
				_stateProvince.GetMultiManyToOne(null, this, filter);
				_stateProvince.SuppressClearInGetMulti=false;
				_alreadyFetchedStateProvince = true;
			}
			return _stateProvince;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual StateProvinceCollection GetMultiStateProvince(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedStateProvince || forceFetch || _alwaysFetchStateProvince) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_stateProvince.ParticipatesInTransaction)
					{
						base.Transaction.Add(_stateProvince);
					}
				}
				_stateProvince.SuppressClearInGetMulti=!forceFetch;
				_stateProvince.EntityFactoryToUse = entityFactoryToUse;
				_stateProvince.GetMultiManyToOne(null, this);
				_stateProvince.SuppressClearInGetMulti=false;
				_alreadyFetchedStateProvince = true;
			}
			return _stateProvince;
		}


		/// <summary>
		/// Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual StateProvinceCollection GetMultiStateProvince(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedStateProvince || forceFetch || _alwaysFetchStateProvince) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_stateProvince.ParticipatesInTransaction)
					{
						base.Transaction.Add(_stateProvince);
					}
				}
				_stateProvince.SuppressClearInGetMulti=!forceFetch;
				_stateProvince.EntityFactoryToUse = entityFactoryToUse;
				_stateProvince.GetMultiManyToOne(null, this, filter);
				_stateProvince.SuppressClearInGetMulti=false;
				_alreadyFetchedStateProvince = true;
			}
			return _stateProvince;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'StateProvince'. These settings will be taken into account
		/// when the property StateProvince is requested or GetMultiStateProvince is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersStateProvince(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_stateProvince.SortClauses=sortClauses;
			_stateProvince.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.
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
				_customer.GetMultiManyToOne(this);
				_customer.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer = true;
			}
			return _customer;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public virtual CustomerCollection GetMultiCustomer(bool forceFetch, IPredicateExpression filter)
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
				_customer.GetMultiManyToOne(this, filter);
				_customer.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer = true;
			}
			return _customer;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
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
				_customer.GetMultiManyToOne(this);
				_customer.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer = true;
			}
			return _customer;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CustomerCollection GetMultiCustomer(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
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
				_customer.GetMultiManyToOne(this, filter);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, null, this, null);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, null, this, null, filter);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, null, this, null);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, null, null, null, this, null, filter);
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
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.
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
				_salesPerson.GetMultiManyToOne(this);
				_salesPerson.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson = true;
			}
			return _salesPerson;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public virtual SalesPersonCollection GetMultiSalesPerson(bool forceFetch, IPredicateExpression filter)
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
				_salesPerson.GetMultiManyToOne(this, filter);
				_salesPerson.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson = true;
			}
			return _salesPerson;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
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
				_salesPerson.GetMultiManyToOne(this);
				_salesPerson.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson = true;
			}
			return _salesPerson;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesPersonCollection GetMultiSalesPerson(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
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
				_salesPerson.GetMultiManyToOne(this, filter);
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
				_salesTerritoryHistory.GetMultiManyToOne(null, this);
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
				_salesTerritoryHistory.GetMultiManyToOne(null, this, filter);
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
				_salesTerritoryHistory.GetMultiManyToOne(null, this);
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
				_salesTerritoryHistory.GetMultiManyToOne(null, this, filter);
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
		/// Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionEntity'</returns>
		public virtual CountryRegionCollection GetMultiCountryRegion(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCountryRegion || forceFetch || _alwaysFetchCountryRegion) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegion.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegion);
					}
				}
				_countryRegion.SuppressClearInGetMulti=!forceFetch;
				_countryRegion.GetMultiManyToManyUsingSalesTerritory(this);
				_countryRegion.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegion = true;
			}
			return _countryRegion;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CountryRegionCollection GetMultiCountryRegion(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCountryRegion || forceFetch || _alwaysFetchCountryRegion) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegion.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegion);
					}
				}
				_countryRegion.SuppressClearInGetMulti=!forceFetch;
				_countryRegion.EntityFactoryToUse = entityFactoryToUse;
				_countryRegion.GetMultiManyToManyUsingSalesTerritory(this);
				_countryRegion.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegion = true;
			}
			return _countryRegion;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'CountryRegion'. These settings will be taken into account
		/// when the property CountryRegion is requested or GetMultiCountryRegion is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCountryRegion(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_countryRegion.SortClauses=sortClauses;
			_countryRegion.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_address.GetMultiManyToManyUsingSalesTerritory(this);
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
				_address.GetMultiManyToManyUsingSalesTerritory(this);
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
				_address_.GetMultiManyToManyUsingSalesTerritory_(this);
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
				_address_.GetMultiManyToManyUsingSalesTerritory_(this);
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
				_creditCard.GetMultiManyToManyUsingSalesTerritory(this);
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
				_creditCard.GetMultiManyToManyUsingSalesTerritory(this);
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
				_currencyRate.GetMultiManyToManyUsingSalesTerritory(this);
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
				_currencyRate.GetMultiManyToManyUsingSalesTerritory(this);
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
		public virtual CustomerCollection GetMultiCustomer_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCustomer_ || forceFetch || _alwaysFetchCustomer_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customer_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customer_);
					}
				}
				_customer_.SuppressClearInGetMulti=!forceFetch;
				_customer_.GetMultiManyToManyUsingSalesTerritory_(this);
				_customer_.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer_ = true;
			}
			return _customer_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CustomerCollection GetMultiCustomer_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomer_ || forceFetch || _alwaysFetchCustomer_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customer_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customer_);
					}
				}
				_customer_.SuppressClearInGetMulti=!forceFetch;
				_customer_.EntityFactoryToUse = entityFactoryToUse;
				_customer_.GetMultiManyToManyUsingSalesTerritory_(this);
				_customer_.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer_ = true;
			}
			return _customer_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Customer_'. These settings will be taken into account
		/// when the property Customer_ is requested or GetMultiCustomer_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomer_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customer_.SortClauses=sortClauses;
			_customer_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public virtual SalesPersonCollection GetMultiSalesPerson_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesPerson_ || forceFetch || _alwaysFetchSalesPerson_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPerson_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPerson_);
					}
				}
				_salesPerson_.SuppressClearInGetMulti=!forceFetch;
				_salesPerson_.GetMultiManyToManyUsingSalesTerritory_(this);
				_salesPerson_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson_ = true;
			}
			return _salesPerson_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesPersonCollection GetMultiSalesPerson_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesPerson_ || forceFetch || _alwaysFetchSalesPerson_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPerson_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPerson_);
					}
				}
				_salesPerson_.SuppressClearInGetMulti=!forceFetch;
				_salesPerson_.EntityFactoryToUse = entityFactoryToUse;
				_salesPerson_.GetMultiManyToManyUsingSalesTerritory_(this);
				_salesPerson_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson_ = true;
			}
			return _salesPerson_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesPerson_'. These settings will be taken into account
		/// when the property SalesPerson_ is requested or GetMultiSalesPerson_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPerson_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPerson_.SortClauses=sortClauses;
			_salesPerson_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_shipMethod.GetMultiManyToManyUsingSalesTerritory(this);
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
				_shipMethod.GetMultiManyToManyUsingSalesTerritory(this);
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
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesPersonEntity'</returns>
		public virtual SalesPersonCollection GetMultiSalesPerson__(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesPerson__ || forceFetch || _alwaysFetchSalesPerson__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPerson__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPerson__);
					}
				}
				_salesPerson__.SuppressClearInGetMulti=!forceFetch;
				_salesPerson__.GetMultiManyToManyUsingSalesTerritory__(this);
				_salesPerson__.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson__ = true;
			}
			return _salesPerson__;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesPersonCollection GetMultiSalesPerson__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesPerson__ || forceFetch || _alwaysFetchSalesPerson__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesPerson__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesPerson__);
					}
				}
				_salesPerson__.SuppressClearInGetMulti=!forceFetch;
				_salesPerson__.EntityFactoryToUse = entityFactoryToUse;
				_salesPerson__.GetMultiManyToManyUsingSalesTerritory__(this);
				_salesPerson__.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesPerson__ = true;
			}
			return _salesPerson__;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesPerson__'. These settings will be taken into account
		/// when the property SalesPerson__ is requested or GetMultiSalesPerson__ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesPerson__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesPerson__.SortClauses=sortClauses;
			_salesPerson__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
	
	
		#region Data binding change event raising methods
	
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
		/// Event thrower for the CountryRegionCodeChanged event, which is thrown when CountryRegionCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCountryRegionCodeChanged()
		{
			if(CountryRegionCodeChanged!=null)
			{
				CountryRegionCodeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the GroupChanged event, which is thrown when Group changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnGroupChanged()
		{
			if(GroupChanged!=null)
			{
				GroupChanged(this, new EventArgs());
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
		/// Event thrower for the CostYTDChanged event, which is thrown when CostYTD changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCostYTDChanged()
		{
			if(CostYTDChanged!=null)
			{
				CostYTDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CostLastYearChanged event, which is thrown when CostLastYear changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCostLastYearChanged()
		{
			if(CostLastYearChanged!=null)
			{
				CostLastYearChanged(this, new EventArgs());
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
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.AddSalesTerritory(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.UpdateSalesTerritory(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();
			return dao.UpdateSalesTerritory(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SalesTerritoryEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new SalesTerritoryValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this SalesTerritoryEntity</param>
		private void InitClassFetch(System.Int32 territoryID, SalesTerritoryValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SalesTerritoryEntity);
			bool wasSuccesful = Fetch(territoryID);
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
			_stateProvince = new StateProvinceCollection(propertyDescriptorFactoryToUse, new StateProvinceEntityFactory());
			_stateProvince.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchStateProvince = false;
			_alreadyFetchedStateProvince = false;
			_customer = new CustomerCollection(propertyDescriptorFactoryToUse, new CustomerEntityFactory());
			_customer.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;
			_salesOrderHeader = new SalesOrderHeaderCollection(propertyDescriptorFactoryToUse, new SalesOrderHeaderEntityFactory());
			_salesOrderHeader.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_salesPerson = new SalesPersonCollection(propertyDescriptorFactoryToUse, new SalesPersonEntityFactory());
			_salesPerson.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
			_salesTerritoryHistory = new SalesTerritoryHistoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryHistoryEntityFactory());
			_salesTerritoryHistory.SetContainingEntityInfo(this, "SalesTerritory");
			_alwaysFetchSalesTerritoryHistory = false;
			_alreadyFetchedSalesTerritoryHistory = false;
			_countryRegion = new CountryRegionCollection(propertyDescriptorFactoryToUse, new CountryRegionEntityFactory());
			_alwaysFetchCountryRegion = false;
			_alreadyFetchedCountryRegion = false;
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
			_customer_ = new CustomerCollection(propertyDescriptorFactoryToUse, new CustomerEntityFactory());
			_alwaysFetchCustomer_ = false;
			_alreadyFetchedCustomer_ = false;
			_salesPerson_ = new SalesPersonCollection(propertyDescriptorFactoryToUse, new SalesPersonEntityFactory());
			_alwaysFetchSalesPerson_ = false;
			_alreadyFetchedSalesPerson_ = false;
			_shipMethod = new ShipMethodCollection(propertyDescriptorFactoryToUse, new ShipMethodEntityFactory());
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_salesPerson__ = new SalesPersonCollection(propertyDescriptorFactoryToUse, new SalesPersonEntityFactory());
			_alwaysFetchSalesPerson__ = false;
			_alreadyFetchedSalesPerson__ = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="territoryID">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 territoryID)
		{
			SalesTerritoryDAO dao = DAOFactory.CreateSalesTerritoryDAO();

			// Load EntityFields of SalesTerritory
			dao.FetchSalesTerritory(base.Fields, base.Transaction, territoryID);

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
		public static SalesTerritoryRelations Relations
		{
			get	{ return new SalesTerritoryRelations(); }
		}

	
		/// <summary>
		/// The TerritoryID property of the Entity SalesTerritory
		/// </summary>
		public virtual System.Int32 TerritoryID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.TerritoryID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TerritoryID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.TerritoryID, value))
				{
					OnTerritoryIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity SalesTerritory
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The CountryRegionCode property of the Entity SalesTerritory
		/// </summary>
		public virtual System.String CountryRegionCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.CountryRegionCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CountryRegionCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.CountryRegionCode, value))
				{
					OnCountryRegionCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The Group property of the Entity SalesTerritory
		/// </summary>
		public virtual System.String Group
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.Group);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Group because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.Group, value))
				{
					OnGroupChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesYTD property of the Entity SalesTerritory
		/// </summary>
		public virtual System.Decimal SalesYTD
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.SalesYTD);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesYTD because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.SalesYTD, value))
				{
					OnSalesYTDChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesLastYear property of the Entity SalesTerritory
		/// </summary>
		public virtual System.Decimal SalesLastYear
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.SalesLastYear);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesLastYear because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.SalesLastYear, value))
				{
					OnSalesLastYearChanged();
				}
			}
		}
	
		/// <summary>
		/// The CostYTD property of the Entity SalesTerritory
		/// </summary>
		public virtual System.Decimal CostYTD
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.CostYTD);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CostYTD because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.CostYTD, value))
				{
					OnCostYTDChanged();
				}
			}
		}
	
		/// <summary>
		/// The CostLastYear property of the Entity SalesTerritory
		/// </summary>
		public virtual System.Decimal CostLastYear
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.CostLastYear);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CostLastYear because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.CostLastYear, value))
				{
					OnCostLastYearChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity SalesTerritory
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity SalesTerritory
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesTerritoryFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesTerritoryFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'StateProvinceEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiStateProvince()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual StateProvinceCollection StateProvince
		{
			get
			{
				return GetMultiStateProvince(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for StateProvince. When set to true, StateProvince is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvince is accessed. You can always execute
		/// a forced fetch by calling GetMultiStateProvince(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchStateProvince
		{
			get
			{
				return _alwaysFetchStateProvince;
			}
			set
			{
				_alwaysFetchStateProvince = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type '1:n'.
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
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type '1:n'.
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
		/// Retrieves all related entities of type 'CountryRegionEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCountryRegion()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CountryRegionCollection CountryRegion
		{
			get
			{
				return GetMultiCountryRegion(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CountryRegion. When set to true, CountryRegion is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CountryRegion is accessed. You can always execute
		/// a forced fetch by calling GetMultiCountryRegion(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCountryRegion
		{
			get
			{
				return _alwaysFetchCountryRegion;
			}
			set
			{
				_alwaysFetchCountryRegion = value;
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomer_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CustomerCollection Customer_
		{
			get
			{
				return GetMultiCustomer_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Customer_. When set to true, Customer_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomer_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomer_
		{
			get
			{
				return _alwaysFetchCustomer_;
			}
			set
			{
				_alwaysFetchCustomer_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPerson_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesPersonCollection SalesPerson_
		{
			get
			{
				return GetMultiSalesPerson_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesPerson_. When set to true, SalesPerson_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesPerson_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPerson_
		{
			get
			{
				return _alwaysFetchSalesPerson_;
			}
			set
			{
				_alwaysFetchSalesPerson_ = value;
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
		/// Retrieves all related entities of type 'SalesPersonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesPerson__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesPersonCollection SalesPerson__
		{
			get
			{
				return GetMultiSalesPerson__(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesPerson__. When set to true, SalesPerson__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesPerson__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesPerson__(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesPerson__
		{
			get
			{
				return _alwaysFetchSalesPerson__;
			}
			set
			{
				_alwaysFetchSalesPerson__ = value;
			}	
		}
	
	
	
		#endregion
	}
}
