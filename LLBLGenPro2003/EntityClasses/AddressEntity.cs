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
	/// Entity class which represents the entity 'Address' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class AddressEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private EmployeeAddressCollection	_employeeAddress;
		private bool	_alwaysFetchEmployeeAddress, _alreadyFetchedEmployeeAddress;
		private VendorAddressCollection	_vendorAddress;
		private bool	_alwaysFetchVendorAddress, _alreadyFetchedVendorAddress;
		private CustomerAddressCollection	_customerAddress;
		private bool	_alwaysFetchCustomerAddress, _alreadyFetchedCustomerAddress;
		private SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private SalesOrderHeaderCollection	_salesOrderHeader_;
		private bool	_alwaysFetchSalesOrderHeader_, _alreadyFetchedSalesOrderHeader_;
		private EmployeeCollection _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee;
		private AddressTypeCollection _addressType_;
		private bool	_alwaysFetchAddressType_, _alreadyFetchedAddressType_;
		private VendorCollection _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor;
		private AddressTypeCollection _addressType;
		private bool	_alwaysFetchAddressType, _alreadyFetchedAddressType;
		private CustomerCollection _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer;
		private CreditCardCollection _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard;
		private CurrencyRateCollection _currencyRate;
		private bool	_alwaysFetchCurrencyRate, _alreadyFetchedCurrencyRate;
		private CustomerCollection _customer_;
		private bool	_alwaysFetchCustomer_, _alreadyFetchedCustomer_;
		private SalesPersonCollection _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson;
		private SalesTerritoryCollection _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory;
		private ShipMethodCollection _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;
		private CreditCardCollection _creditCard_;
		private bool	_alwaysFetchCreditCard_, _alreadyFetchedCreditCard_;
		private CurrencyRateCollection _currencyRate_;
		private bool	_alwaysFetchCurrencyRate_, _alreadyFetchedCurrencyRate_;
		private CustomerCollection _customer__;
		private bool	_alwaysFetchCustomer__, _alreadyFetchedCustomer__;
		private SalesPersonCollection _salesPerson_;
		private bool	_alwaysFetchSalesPerson_, _alreadyFetchedSalesPerson_;
		private SalesTerritoryCollection _salesTerritory_;
		private bool	_alwaysFetchSalesTerritory_, _alreadyFetchedSalesTerritory_;
		private ShipMethodCollection _shipMethod_;
		private bool	_alwaysFetchShipMethod_, _alreadyFetchedShipMethod_;
		private StateProvinceEntity _stateProvince;
		private bool	_alwaysFetchStateProvince, _alreadyFetchedStateProvince;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when AddressID changes value. Databinding related.
		/// </summary>
		public event EventHandler AddressIDChanged;

		/// <summary>
		/// Event which is thrown when AddressLine1 changes value. Databinding related.
		/// </summary>
		public event EventHandler AddressLine1Changed;

		/// <summary>
		/// Event which is thrown when AddressLine2 changes value. Databinding related.
		/// </summary>
		public event EventHandler AddressLine2Changed;

		/// <summary>
		/// Event which is thrown when City changes value. Databinding related.
		/// </summary>
		public event EventHandler CityChanged;

		/// <summary>
		/// Event which is thrown when StateProvinceID changes value. Databinding related.
		/// </summary>
		public event EventHandler StateProvinceIDChanged;

		/// <summary>
		/// Event which is thrown when PostalCode changes value. Databinding related.
		/// </summary>
		public event EventHandler PostalCodeChanged;

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
		public AddressEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new AddressEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		public AddressEntity(System.Int32 addressID)
		{
			InitClassFetch(addressID, new AddressValidator(), new PropertyDescriptorFactory(), new AddressEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		public AddressEntity(System.Int32 addressID, AddressValidator validator)
		{
			InitClassFetch(addressID, validator, new PropertyDescriptorFactory(), new AddressEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="validator">The custom validator object for this AddressEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public AddressEntity(System.Int32 addressID, AddressValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(addressID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public AddressEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private AddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_employeeAddress = (EmployeeAddressCollection)info.GetValue("_employeeAddress", typeof(EmployeeAddressCollection));
			_alwaysFetchEmployeeAddress = info.GetBoolean("_alwaysFetchEmployeeAddress");
			_alreadyFetchedEmployeeAddress = info.GetBoolean("_alreadyFetchedEmployeeAddress");

			_vendorAddress = (VendorAddressCollection)info.GetValue("_vendorAddress", typeof(VendorAddressCollection));
			_alwaysFetchVendorAddress = info.GetBoolean("_alwaysFetchVendorAddress");
			_alreadyFetchedVendorAddress = info.GetBoolean("_alreadyFetchedVendorAddress");

			_customerAddress = (CustomerAddressCollection)info.GetValue("_customerAddress", typeof(CustomerAddressCollection));
			_alwaysFetchCustomerAddress = info.GetBoolean("_alwaysFetchCustomerAddress");
			_alreadyFetchedCustomerAddress = info.GetBoolean("_alreadyFetchedCustomerAddress");

			_salesOrderHeader = (SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");

			_salesOrderHeader_ = (SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader_", typeof(SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader_ = info.GetBoolean("_alwaysFetchSalesOrderHeader_");
			_alreadyFetchedSalesOrderHeader_ = info.GetBoolean("_alreadyFetchedSalesOrderHeader_");

			_employee = (EmployeeCollection)info.GetValue("_employee", typeof(EmployeeCollection));
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");

			_addressType_ = (AddressTypeCollection)info.GetValue("_addressType_", typeof(AddressTypeCollection));
			_alwaysFetchAddressType_ = info.GetBoolean("_alwaysFetchAddressType_");
			_alreadyFetchedAddressType_ = info.GetBoolean("_alreadyFetchedAddressType_");

			_vendor = (VendorCollection)info.GetValue("_vendor", typeof(VendorCollection));
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");

			_addressType = (AddressTypeCollection)info.GetValue("_addressType", typeof(AddressTypeCollection));
			_alwaysFetchAddressType = info.GetBoolean("_alwaysFetchAddressType");
			_alreadyFetchedAddressType = info.GetBoolean("_alreadyFetchedAddressType");

			_customer = (CustomerCollection)info.GetValue("_customer", typeof(CustomerCollection));
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

			_creditCard = (CreditCardCollection)info.GetValue("_creditCard", typeof(CreditCardCollection));
			_alwaysFetchCreditCard = info.GetBoolean("_alwaysFetchCreditCard");
			_alreadyFetchedCreditCard = info.GetBoolean("_alreadyFetchedCreditCard");

			_currencyRate = (CurrencyRateCollection)info.GetValue("_currencyRate", typeof(CurrencyRateCollection));
			_alwaysFetchCurrencyRate = info.GetBoolean("_alwaysFetchCurrencyRate");
			_alreadyFetchedCurrencyRate = info.GetBoolean("_alreadyFetchedCurrencyRate");

			_customer_ = (CustomerCollection)info.GetValue("_customer_", typeof(CustomerCollection));
			_alwaysFetchCustomer_ = info.GetBoolean("_alwaysFetchCustomer_");
			_alreadyFetchedCustomer_ = info.GetBoolean("_alreadyFetchedCustomer_");

			_salesPerson = (SalesPersonCollection)info.GetValue("_salesPerson", typeof(SalesPersonCollection));
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");

			_salesTerritory = (SalesTerritoryCollection)info.GetValue("_salesTerritory", typeof(SalesTerritoryCollection));
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");

			_shipMethod = (ShipMethodCollection)info.GetValue("_shipMethod", typeof(ShipMethodCollection));
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

			_creditCard_ = (CreditCardCollection)info.GetValue("_creditCard_", typeof(CreditCardCollection));
			_alwaysFetchCreditCard_ = info.GetBoolean("_alwaysFetchCreditCard_");
			_alreadyFetchedCreditCard_ = info.GetBoolean("_alreadyFetchedCreditCard_");

			_currencyRate_ = (CurrencyRateCollection)info.GetValue("_currencyRate_", typeof(CurrencyRateCollection));
			_alwaysFetchCurrencyRate_ = info.GetBoolean("_alwaysFetchCurrencyRate_");
			_alreadyFetchedCurrencyRate_ = info.GetBoolean("_alreadyFetchedCurrencyRate_");

			_customer__ = (CustomerCollection)info.GetValue("_customer__", typeof(CustomerCollection));
			_alwaysFetchCustomer__ = info.GetBoolean("_alwaysFetchCustomer__");
			_alreadyFetchedCustomer__ = info.GetBoolean("_alreadyFetchedCustomer__");

			_salesPerson_ = (SalesPersonCollection)info.GetValue("_salesPerson_", typeof(SalesPersonCollection));
			_alwaysFetchSalesPerson_ = info.GetBoolean("_alwaysFetchSalesPerson_");
			_alreadyFetchedSalesPerson_ = info.GetBoolean("_alreadyFetchedSalesPerson_");

			_salesTerritory_ = (SalesTerritoryCollection)info.GetValue("_salesTerritory_", typeof(SalesTerritoryCollection));
			_alwaysFetchSalesTerritory_ = info.GetBoolean("_alwaysFetchSalesTerritory_");
			_alreadyFetchedSalesTerritory_ = info.GetBoolean("_alreadyFetchedSalesTerritory_");

			_shipMethod_ = (ShipMethodCollection)info.GetValue("_shipMethod_", typeof(ShipMethodCollection));
			_alwaysFetchShipMethod_ = info.GetBoolean("_alwaysFetchShipMethod_");
			_alreadyFetchedShipMethod_ = info.GetBoolean("_alreadyFetchedShipMethod_");
			_stateProvince = (StateProvinceEntity)info.GetValue("_stateProvince", typeof(StateProvinceEntity));
			if(_stateProvince!=null)
			{
				// rewire event handler.
				_stateProvince.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchStateProvince = info.GetBoolean("_alwaysFetchStateProvince");
			_alreadyFetchedStateProvince = info.GetBoolean("_alreadyFetchedStateProvince");

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
			_alreadyFetchedEmployeeAddress = (_employeeAddress.Count > 0);
			_alreadyFetchedVendorAddress = (_vendorAddress.Count > 0);
			_alreadyFetchedCustomerAddress = (_customerAddress.Count > 0);
			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader.Count > 0);
			_alreadyFetchedSalesOrderHeader_ = (_salesOrderHeader_.Count > 0);
			_alreadyFetchedEmployee = (_employee.Count > 0);
			_alreadyFetchedAddressType_ = (_addressType_.Count > 0);
			_alreadyFetchedVendor = (_vendor.Count > 0);
			_alreadyFetchedAddressType = (_addressType.Count > 0);
			_alreadyFetchedCustomer = (_customer.Count > 0);
			_alreadyFetchedCreditCard = (_creditCard.Count > 0);
			_alreadyFetchedCurrencyRate = (_currencyRate.Count > 0);
			_alreadyFetchedCustomer_ = (_customer_.Count > 0);
			_alreadyFetchedSalesPerson = (_salesPerson.Count > 0);
			_alreadyFetchedSalesTerritory = (_salesTerritory.Count > 0);
			_alreadyFetchedShipMethod = (_shipMethod.Count > 0);
			_alreadyFetchedCreditCard_ = (_creditCard_.Count > 0);
			_alreadyFetchedCurrencyRate_ = (_currencyRate_.Count > 0);
			_alreadyFetchedCustomer__ = (_customer__.Count > 0);
			_alreadyFetchedSalesPerson_ = (_salesPerson_.Count > 0);
			_alreadyFetchedSalesTerritory_ = (_salesTerritory_.Count > 0);
			_alreadyFetchedShipMethod_ = (_shipMethod_.Count > 0);
			_alreadyFetchedStateProvince = (_stateProvince != null);

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
			info.AddValue("_employeeAddress", _employeeAddress);
			info.AddValue("_alwaysFetchEmployeeAddress", _alwaysFetchEmployeeAddress);
			info.AddValue("_alreadyFetchedEmployeeAddress", _alreadyFetchedEmployeeAddress);
			info.AddValue("_vendorAddress", _vendorAddress);
			info.AddValue("_alwaysFetchVendorAddress", _alwaysFetchVendorAddress);
			info.AddValue("_alreadyFetchedVendorAddress", _alreadyFetchedVendorAddress);
			info.AddValue("_customerAddress", _customerAddress);
			info.AddValue("_alwaysFetchCustomerAddress", _alwaysFetchCustomerAddress);
			info.AddValue("_alreadyFetchedCustomerAddress", _alreadyFetchedCustomerAddress);
			info.AddValue("_salesOrderHeader", _salesOrderHeader);
			info.AddValue("_alwaysFetchSalesOrderHeader", _alwaysFetchSalesOrderHeader);
			info.AddValue("_alreadyFetchedSalesOrderHeader", _alreadyFetchedSalesOrderHeader);
			info.AddValue("_salesOrderHeader_", _salesOrderHeader_);
			info.AddValue("_alwaysFetchSalesOrderHeader_", _alwaysFetchSalesOrderHeader_);
			info.AddValue("_alreadyFetchedSalesOrderHeader_", _alreadyFetchedSalesOrderHeader_);
			info.AddValue("_employee", _employee);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_addressType_", _addressType_);
			info.AddValue("_alwaysFetchAddressType_", _alwaysFetchAddressType_);
			info.AddValue("_alreadyFetchedAddressType_", _alreadyFetchedAddressType_);
			info.AddValue("_vendor", _vendor);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);
			info.AddValue("_addressType", _addressType);
			info.AddValue("_alwaysFetchAddressType", _alwaysFetchAddressType);
			info.AddValue("_alreadyFetchedAddressType", _alreadyFetchedAddressType);
			info.AddValue("_customer", _customer);
			info.AddValue("_alwaysFetchCustomer", _alwaysFetchCustomer);
			info.AddValue("_alreadyFetchedCustomer", _alreadyFetchedCustomer);
			info.AddValue("_creditCard", _creditCard);
			info.AddValue("_alwaysFetchCreditCard", _alwaysFetchCreditCard);
			info.AddValue("_alreadyFetchedCreditCard", _alreadyFetchedCreditCard);
			info.AddValue("_currencyRate", _currencyRate);
			info.AddValue("_alwaysFetchCurrencyRate", _alwaysFetchCurrencyRate);
			info.AddValue("_alreadyFetchedCurrencyRate", _alreadyFetchedCurrencyRate);
			info.AddValue("_customer_", _customer_);
			info.AddValue("_alwaysFetchCustomer_", _alwaysFetchCustomer_);
			info.AddValue("_alreadyFetchedCustomer_", _alreadyFetchedCustomer_);
			info.AddValue("_salesPerson", _salesPerson);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
			info.AddValue("_salesTerritory", _salesTerritory);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_creditCard_", _creditCard_);
			info.AddValue("_alwaysFetchCreditCard_", _alwaysFetchCreditCard_);
			info.AddValue("_alreadyFetchedCreditCard_", _alreadyFetchedCreditCard_);
			info.AddValue("_currencyRate_", _currencyRate_);
			info.AddValue("_alwaysFetchCurrencyRate_", _alwaysFetchCurrencyRate_);
			info.AddValue("_alreadyFetchedCurrencyRate_", _alreadyFetchedCurrencyRate_);
			info.AddValue("_customer__", _customer__);
			info.AddValue("_alwaysFetchCustomer__", _alwaysFetchCustomer__);
			info.AddValue("_alreadyFetchedCustomer__", _alreadyFetchedCustomer__);
			info.AddValue("_salesPerson_", _salesPerson_);
			info.AddValue("_alwaysFetchSalesPerson_", _alwaysFetchSalesPerson_);
			info.AddValue("_alreadyFetchedSalesPerson_", _alreadyFetchedSalesPerson_);
			info.AddValue("_salesTerritory_", _salesTerritory_);
			info.AddValue("_alwaysFetchSalesTerritory_", _alwaysFetchSalesTerritory_);
			info.AddValue("_alreadyFetchedSalesTerritory_", _alreadyFetchedSalesTerritory_);
			info.AddValue("_shipMethod_", _shipMethod_);
			info.AddValue("_alwaysFetchShipMethod_", _alwaysFetchShipMethod_);
			info.AddValue("_alreadyFetchedShipMethod_", _alreadyFetchedShipMethod_);
			info.AddValue("_stateProvince", _stateProvince);
			info.AddValue("_alwaysFetchStateProvince", _alwaysFetchStateProvince);
			info.AddValue("_alreadyFetchedStateProvince", _alreadyFetchedStateProvince);

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
					SetupSyncStateProvince(relatedEntity);
					break;
				case "EmployeeAddress":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_employeeAddress.Add(relatedEntity);
					break;
				case "VendorAddress":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_vendorAddress.Add(relatedEntity);
					break;
				case "CustomerAddress":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_customerAddress.Add(relatedEntity);
					break;
				case "SalesOrderHeader":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesOrderHeader.Add(relatedEntity);
					break;
				case "SalesOrderHeader_":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesOrderHeader_.Add(relatedEntity);
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
					DesetupSyncStateProvince(false);
					break;
				case "EmployeeAddress":
					// Remove it from the collection.
					_employeeAddress.Remove(relatedEntity);
					break;
				case "VendorAddress":
					// Remove it from the collection.
					_vendorAddress.Remove(relatedEntity);
					break;
				case "CustomerAddress":
					// Remove it from the collection.
					_customerAddress.Remove(relatedEntity);
					break;
				case "SalesOrderHeader":
					// Remove it from the collection.
					_salesOrderHeader.Remove(relatedEntity);
					break;
				case "SalesOrderHeader_":
					// Remove it from the collection.
					_salesOrderHeader_.Remove(relatedEntity);
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
			if(_stateProvince!=null)
			{
				toReturn.Add(_stateProvince);
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

			toReturn.Add(_employeeAddress);
			toReturn.Add(_vendorAddress);
			toReturn.Add(_customerAddress);
			toReturn.Add(_salesOrderHeader);
			toReturn.Add(_salesOrderHeader_);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("AddressEntity");
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
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 addressID)
		{
			return Fetch(addressID);
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
			return Fetch(this.AddressID);
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
			AddressDAO dao = DAOFactory.CreateAddressDAO();
			bool wasSuccesful = dao.DeleteAddress(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(AddressFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeAddressEntity'</returns>
		public virtual EmployeeAddressCollection GetMultiEmployeeAddress(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployeeAddress || forceFetch || _alwaysFetchEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeAddress);
					}
				}
				_employeeAddress.SuppressClearInGetMulti=!forceFetch;
				_employeeAddress.GetMultiManyToOne(this, null);
				_employeeAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeAddress = true;
			}
			return _employeeAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeAddressEntity'</returns>
		public virtual EmployeeAddressCollection GetMultiEmployeeAddress(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeAddress || forceFetch || _alwaysFetchEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeAddress);
					}
				}
				_employeeAddress.SuppressClearInGetMulti=!forceFetch;
				_employeeAddress.GetMultiManyToOne(this, null, filter);
				_employeeAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeAddress = true;
			}
			return _employeeAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeAddressCollection GetMultiEmployeeAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeAddress || forceFetch || _alwaysFetchEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeAddress);
					}
				}
				_employeeAddress.SuppressClearInGetMulti=!forceFetch;
				_employeeAddress.EntityFactoryToUse = entityFactoryToUse;
				_employeeAddress.GetMultiManyToOne(this, null);
				_employeeAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeAddress = true;
			}
			return _employeeAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeAddressCollection GetMultiEmployeeAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeAddress || forceFetch || _alwaysFetchEmployeeAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeAddress);
					}
				}
				_employeeAddress.SuppressClearInGetMulti=!forceFetch;
				_employeeAddress.EntityFactoryToUse = entityFactoryToUse;
				_employeeAddress.GetMultiManyToOne(this, null, filter);
				_employeeAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeAddress = true;
			}
			return _employeeAddress;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'EmployeeAddress'. These settings will be taken into account
		/// when the property EmployeeAddress is requested or GetMultiEmployeeAddress is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeAddress.SortClauses=sortClauses;
			_employeeAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_vendorAddress.GetMultiManyToOne(this, null, null);
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
				_vendorAddress.GetMultiManyToOne(this, null, null, filter);
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
				_vendorAddress.GetMultiManyToOne(this, null, null);
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
				_vendorAddress.GetMultiManyToOne(this, null, null, filter);
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
				_customerAddress.GetMultiManyToOne(this, null, null);
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
				_customerAddress.GetMultiManyToOne(this, null, null, filter);
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
				_customerAddress.GetMultiManyToOne(this, null, null);
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
				_customerAddress.GetMultiManyToOne(this, null, null, filter);
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
				_salesOrderHeader.GetMultiManyToOne(this, null, null, null, null, null, null, null);
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
				_salesOrderHeader.GetMultiManyToOne(this, null, null, null, null, null, null, null, filter);
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
				_salesOrderHeader.GetMultiManyToOne(this, null, null, null, null, null, null, null);
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
				_salesOrderHeader.GetMultiManyToOne(this, null, null, null, null, null, null, null, filter);
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
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public virtual SalesOrderHeaderCollection GetMultiSalesOrderHeader_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader_ || forceFetch || _alwaysFetchSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader_);
					}
				}
				_salesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader_.GetMultiManyToOne(null, this, null, null, null, null, null, null);
				_salesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader_ = true;
			}
			return _salesOrderHeader_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderEntity'</returns>
		public virtual SalesOrderHeaderCollection GetMultiSalesOrderHeader_(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader_ || forceFetch || _alwaysFetchSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader_);
					}
				}
				_salesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader_.GetMultiManyToOne(null, this, null, null, null, null, null, null, filter);
				_salesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader_ = true;
			}
			return _salesOrderHeader_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesOrderHeaderCollection GetMultiSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader_ || forceFetch || _alwaysFetchSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader_);
					}
				}
				_salesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeader_.GetMultiManyToOne(null, this, null, null, null, null, null, null);
				_salesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader_ = true;
			}
			return _salesOrderHeader_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesOrderHeaderCollection GetMultiSalesOrderHeader_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader_ || forceFetch || _alwaysFetchSalesOrderHeader_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeader_);
					}
				}
				_salesOrderHeader_.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeader_.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeader_.GetMultiManyToOne(null, this, null, null, null, null, null, null, filter);
				_salesOrderHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeader_ = true;
			}
			return _salesOrderHeader_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesOrderHeader_'. These settings will be taken into account
		/// when the property SalesOrderHeader_ is requested or GetMultiSalesOrderHeader_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeader_.SortClauses=sortClauses;
			_salesOrderHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
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
				_employee.GetMultiManyToManyUsingAddress(this);
				_employee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
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
				_employee.GetMultiManyToManyUsingAddress(this);
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
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressTypeEntity'</returns>
		public virtual AddressTypeCollection GetMultiAddressType_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddressType_ || forceFetch || _alwaysFetchAddressType_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_addressType_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressType_);
					}
				}
				_addressType_.SuppressClearInGetMulti=!forceFetch;
				_addressType_.GetMultiManyToManyUsingAddress_(this);
				_addressType_.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressType_ = true;
			}
			return _addressType_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AddressTypeCollection GetMultiAddressType_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressType_ || forceFetch || _alwaysFetchAddressType_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_addressType_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressType_);
					}
				}
				_addressType_.SuppressClearInGetMulti=!forceFetch;
				_addressType_.EntityFactoryToUse = entityFactoryToUse;
				_addressType_.GetMultiManyToManyUsingAddress_(this);
				_addressType_.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressType_ = true;
			}
			return _addressType_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'AddressType_'. These settings will be taken into account
		/// when the property AddressType_ is requested or GetMultiAddressType_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressType_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressType_.SortClauses=sortClauses;
			_addressType_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_vendor.GetMultiManyToManyUsingAddress(this);
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
				_vendor.GetMultiManyToManyUsingAddress(this);
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
				_addressType.GetMultiManyToManyUsingAddress(this);
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
				_addressType.GetMultiManyToManyUsingAddress(this);
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
				_customer.GetMultiManyToManyUsingAddress(this);
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
				_customer.GetMultiManyToManyUsingAddress(this);
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
				_creditCard.GetMultiManyToManyUsingAddress(this);
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
				_creditCard.GetMultiManyToManyUsingAddress(this);
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
				_currencyRate.GetMultiManyToManyUsingAddress(this);
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
				_currencyRate.GetMultiManyToManyUsingAddress(this);
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
				_customer_.GetMultiManyToManyUsingAddress_(this);
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
				_customer_.GetMultiManyToManyUsingAddress_(this);
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
				_salesPerson.GetMultiManyToManyUsingAddress(this);
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
				_salesPerson.GetMultiManyToManyUsingAddress(this);
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
		public virtual SalesTerritoryCollection GetMultiSalesTerritory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesTerritory || forceFetch || _alwaysFetchSalesTerritory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritory);
					}
				}
				_salesTerritory.SuppressClearInGetMulti=!forceFetch;
				_salesTerritory.GetMultiManyToManyUsingAddress(this);
				_salesTerritory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritory = true;
			}
			return _salesTerritory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesTerritoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesTerritoryCollection GetMultiSalesTerritory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesTerritory || forceFetch || _alwaysFetchSalesTerritory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesTerritory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesTerritory);
					}
				}
				_salesTerritory.SuppressClearInGetMulti=!forceFetch;
				_salesTerritory.EntityFactoryToUse = entityFactoryToUse;
				_salesTerritory.GetMultiManyToManyUsingAddress(this);
				_salesTerritory.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesTerritory = true;
			}
			return _salesTerritory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesTerritory'. These settings will be taken into account
		/// when the property SalesTerritory is requested or GetMultiSalesTerritory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesTerritory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesTerritory.SortClauses=sortClauses;
			_salesTerritory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_shipMethod.GetMultiManyToManyUsingAddress(this);
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
				_shipMethod.GetMultiManyToManyUsingAddress(this);
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
		/// Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CreditCardEntity'</returns>
		public virtual CreditCardCollection GetMultiCreditCard_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCreditCard_ || forceFetch || _alwaysFetchCreditCard_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_creditCard_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_creditCard_);
					}
				}
				_creditCard_.SuppressClearInGetMulti=!forceFetch;
				_creditCard_.GetMultiManyToManyUsingAddress_(this);
				_creditCard_.SuppressClearInGetMulti=false;
				_alreadyFetchedCreditCard_ = true;
			}
			return _creditCard_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CreditCardCollection GetMultiCreditCard_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCreditCard_ || forceFetch || _alwaysFetchCreditCard_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_creditCard_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_creditCard_);
					}
				}
				_creditCard_.SuppressClearInGetMulti=!forceFetch;
				_creditCard_.EntityFactoryToUse = entityFactoryToUse;
				_creditCard_.GetMultiManyToManyUsingAddress_(this);
				_creditCard_.SuppressClearInGetMulti=false;
				_alreadyFetchedCreditCard_ = true;
			}
			return _creditCard_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'CreditCard_'. These settings will be taken into account
		/// when the property CreditCard_ is requested or GetMultiCreditCard_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCreditCard_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_creditCard_.SortClauses=sortClauses;
			_creditCard_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyRateEntity'</returns>
		public virtual CurrencyRateCollection GetMultiCurrencyRate_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCurrencyRate_ || forceFetch || _alwaysFetchCurrencyRate_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyRate_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyRate_);
					}
				}
				_currencyRate_.SuppressClearInGetMulti=!forceFetch;
				_currencyRate_.GetMultiManyToManyUsingAddress_(this);
				_currencyRate_.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyRate_ = true;
			}
			return _currencyRate_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CurrencyRateCollection GetMultiCurrencyRate_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCurrencyRate_ || forceFetch || _alwaysFetchCurrencyRate_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_currencyRate_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currencyRate_);
					}
				}
				_currencyRate_.SuppressClearInGetMulti=!forceFetch;
				_currencyRate_.EntityFactoryToUse = entityFactoryToUse;
				_currencyRate_.GetMultiManyToManyUsingAddress_(this);
				_currencyRate_.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrencyRate_ = true;
			}
			return _currencyRate_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'CurrencyRate_'. These settings will be taken into account
		/// when the property CurrencyRate_ is requested or GetMultiCurrencyRate_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrencyRate_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currencyRate_.SortClauses=sortClauses;
			_currencyRate_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CustomerEntity'</returns>
		public virtual CustomerCollection GetMultiCustomer__(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCustomer__ || forceFetch || _alwaysFetchCustomer__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customer__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customer__);
					}
				}
				_customer__.SuppressClearInGetMulti=!forceFetch;
				_customer__.GetMultiManyToManyUsingAddress__(this);
				_customer__.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer__ = true;
			}
			return _customer__;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CustomerCollection GetMultiCustomer__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCustomer__ || forceFetch || _alwaysFetchCustomer__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_customer__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_customer__);
					}
				}
				_customer__.SuppressClearInGetMulti=!forceFetch;
				_customer__.EntityFactoryToUse = entityFactoryToUse;
				_customer__.GetMultiManyToManyUsingAddress__(this);
				_customer__.SuppressClearInGetMulti=false;
				_alreadyFetchedCustomer__ = true;
			}
			return _customer__;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Customer__'. These settings will be taken into account
		/// when the property Customer__ is requested or GetMultiCustomer__ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCustomer__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_customer__.SortClauses=sortClauses;
			_customer__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_salesPerson_.GetMultiManyToManyUsingAddress_(this);
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
				_salesPerson_.GetMultiManyToManyUsingAddress_(this);
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
				_salesTerritory_.GetMultiManyToManyUsingAddress_(this);
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
				_salesTerritory_.GetMultiManyToManyUsingAddress_(this);
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
		public virtual ShipMethodCollection GetMultiShipMethod_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedShipMethod_ || forceFetch || _alwaysFetchShipMethod_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethod_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethod_);
					}
				}
				_shipMethod_.SuppressClearInGetMulti=!forceFetch;
				_shipMethod_.GetMultiManyToManyUsingAddress_(this);
				_shipMethod_.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethod_ = true;
			}
			return _shipMethod_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ShipMethodCollection GetMultiShipMethod_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShipMethod_ || forceFetch || _alwaysFetchShipMethod_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethod_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethod_);
					}
				}
				_shipMethod_.SuppressClearInGetMulti=!forceFetch;
				_shipMethod_.EntityFactoryToUse = entityFactoryToUse;
				_shipMethod_.GetMultiManyToManyUsingAddress_(this);
				_shipMethod_.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethod_ = true;
			}
			return _shipMethod_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ShipMethod_'. These settings will be taken into account
		/// when the property ShipMethod_ is requested or GetMultiShipMethod_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShipMethod_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shipMethod_.SortClauses=sortClauses;
			_shipMethod_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
		/// <summary>
		/// Retrieves the related entity of type 'StateProvinceEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'StateProvinceEntity' which is related to this entity.</returns>
		public virtual StateProvinceEntity GetSingleStateProvince()
		{
			return GetSingleStateProvince(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'StateProvinceEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'StateProvinceEntity' which is related to this entity.</returns>
		public virtual StateProvinceEntity GetSingleStateProvince(bool forceFetch)
		{
 			if( ( !_alreadyFetchedStateProvince || forceFetch || _alwaysFetchStateProvince) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				StateProvinceEntity newEntity = new StateProvinceEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.StateProvinceID);
				this.StateProvince = newEntity;

				_alreadyFetchedStateProvince = true;
			}
			return _stateProvince;
		}
	
	
	
		#region Data binding change event raising methods
	
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
		/// Event thrower for the AddressLine1Changed event, which is thrown when AddressLine1 changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnAddressLine1Changed()
		{
			if(AddressLine1Changed!=null)
			{
				AddressLine1Changed(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the AddressLine2Changed event, which is thrown when AddressLine2 changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnAddressLine2Changed()
		{
			if(AddressLine2Changed!=null)
			{
				AddressLine2Changed(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CityChanged event, which is thrown when City changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCityChanged()
		{
			if(CityChanged!=null)
			{
				CityChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the StateProvinceIDChanged event, which is thrown when StateProvinceID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnStateProvinceIDChanged()
		{
			if(StateProvinceIDChanged!=null)
			{
				StateProvinceIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PostalCodeChanged event, which is thrown when PostalCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPostalCodeChanged()
		{
			if(PostalCodeChanged!=null)
			{
				PostalCodeChanged(this, new EventArgs());
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
			AddressDAO dao = DAOFactory.CreateAddressDAO();
			return dao.AddAddress(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			AddressDAO dao = DAOFactory.CreateAddressDAO();
			return dao.UpdateAddress(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			AddressDAO dao = DAOFactory.CreateAddressDAO();
			return dao.UpdateAddress(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.AddressEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new AddressValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this AddressEntity</param>
		private void InitClassFetch(System.Int32 addressID, AddressValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.AddressEntity);
			bool wasSuccesful = Fetch(addressID);
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
			_employeeAddress = new EmployeeAddressCollection(propertyDescriptorFactoryToUse, new EmployeeAddressEntityFactory());
			_employeeAddress.SetContainingEntityInfo(this, "Address");
			_alwaysFetchEmployeeAddress = false;
			_alreadyFetchedEmployeeAddress = false;
			_vendorAddress = new VendorAddressCollection(propertyDescriptorFactoryToUse, new VendorAddressEntityFactory());
			_vendorAddress.SetContainingEntityInfo(this, "Address");
			_alwaysFetchVendorAddress = false;
			_alreadyFetchedVendorAddress = false;
			_customerAddress = new CustomerAddressCollection(propertyDescriptorFactoryToUse, new CustomerAddressEntityFactory());
			_customerAddress.SetContainingEntityInfo(this, "Address");
			_alwaysFetchCustomerAddress = false;
			_alreadyFetchedCustomerAddress = false;
			_salesOrderHeader = new SalesOrderHeaderCollection(propertyDescriptorFactoryToUse, new SalesOrderHeaderEntityFactory());
			_salesOrderHeader.SetContainingEntityInfo(this, "Address");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_salesOrderHeader_ = new SalesOrderHeaderCollection(propertyDescriptorFactoryToUse, new SalesOrderHeaderEntityFactory());
			_salesOrderHeader_.SetContainingEntityInfo(this, "Address_");
			_alwaysFetchSalesOrderHeader_ = false;
			_alreadyFetchedSalesOrderHeader_ = false;
			_employee = new EmployeeCollection(propertyDescriptorFactoryToUse, new EmployeeEntityFactory());
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_addressType_ = new AddressTypeCollection(propertyDescriptorFactoryToUse, new AddressTypeEntityFactory());
			_alwaysFetchAddressType_ = false;
			_alreadyFetchedAddressType_ = false;
			_vendor = new VendorCollection(propertyDescriptorFactoryToUse, new VendorEntityFactory());
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;
			_addressType = new AddressTypeCollection(propertyDescriptorFactoryToUse, new AddressTypeEntityFactory());
			_alwaysFetchAddressType = false;
			_alreadyFetchedAddressType = false;
			_customer = new CustomerCollection(propertyDescriptorFactoryToUse, new CustomerEntityFactory());
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;
			_creditCard = new CreditCardCollection(propertyDescriptorFactoryToUse, new CreditCardEntityFactory());
			_alwaysFetchCreditCard = false;
			_alreadyFetchedCreditCard = false;
			_currencyRate = new CurrencyRateCollection(propertyDescriptorFactoryToUse, new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRate = false;
			_alreadyFetchedCurrencyRate = false;
			_customer_ = new CustomerCollection(propertyDescriptorFactoryToUse, new CustomerEntityFactory());
			_alwaysFetchCustomer_ = false;
			_alreadyFetchedCustomer_ = false;
			_salesPerson = new SalesPersonCollection(propertyDescriptorFactoryToUse, new SalesPersonEntityFactory());
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
			_salesTerritory = new SalesTerritoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritory = false;
			_alreadyFetchedSalesTerritory = false;
			_shipMethod = new ShipMethodCollection(propertyDescriptorFactoryToUse, new ShipMethodEntityFactory());
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_creditCard_ = new CreditCardCollection(propertyDescriptorFactoryToUse, new CreditCardEntityFactory());
			_alwaysFetchCreditCard_ = false;
			_alreadyFetchedCreditCard_ = false;
			_currencyRate_ = new CurrencyRateCollection(propertyDescriptorFactoryToUse, new CurrencyRateEntityFactory());
			_alwaysFetchCurrencyRate_ = false;
			_alreadyFetchedCurrencyRate_ = false;
			_customer__ = new CustomerCollection(propertyDescriptorFactoryToUse, new CustomerEntityFactory());
			_alwaysFetchCustomer__ = false;
			_alreadyFetchedCustomer__ = false;
			_salesPerson_ = new SalesPersonCollection(propertyDescriptorFactoryToUse, new SalesPersonEntityFactory());
			_alwaysFetchSalesPerson_ = false;
			_alreadyFetchedSalesPerson_ = false;
			_salesTerritory_ = new SalesTerritoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritory_ = false;
			_alreadyFetchedSalesTerritory_ = false;
			_shipMethod_ = new ShipMethodCollection(propertyDescriptorFactoryToUse, new ShipMethodEntityFactory());
			_alwaysFetchShipMethod_ = false;
			_alreadyFetchedShipMethod_ = false;
			_stateProvince = null;
			_alwaysFetchStateProvince = false;
			_alreadyFetchedStateProvince = false;

		}


		/// <summary>
		/// Removes the sync logic for member _stateProvince
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncStateProvince(bool signalRelatedEntity)
		{
			if(_stateProvince != null)
			{
				// disconnect the entity from this entity
				_stateProvince.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_stateProvince.UnsetRelatedEntity(this, "Address");
				}
				base.UnsetEntitySyncInformation("StateProvince", _stateProvince, AddressEntity.Relations.StateProvinceEntityUsingStateProvinceID);
				_stateProvince = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _stateProvince
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncStateProvince(IEntity relatedEntity)
		{
			DesetupSyncStateProvince(true);
			
			if(relatedEntity!=null)
			{
				_stateProvince = (StateProvinceEntity)relatedEntity;
				_stateProvince.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("StateProvince", _stateProvince, AddressEntity.Relations.StateProvinceEntityUsingStateProvinceID);
				if(!_stateProvince.IsNew)
				{
					// sync now
					base.SyncFKFields(AddressEntity.Relations.StateProvinceEntityUsingStateProvinceID, _stateProvince);
				}
			}

			_alreadyFetchedStateProvince = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="addressID">PK value for Address which data should be fetched into this Address object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 addressID)
		{
			AddressDAO dao = DAOFactory.CreateAddressDAO();

			// Load EntityFields of Address
			dao.FetchAddress(base.Fields, base.Transaction, addressID);

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
		public static AddressRelations Relations
		{
			get	{ return new AddressRelations(); }
		}

	
		/// <summary>
		/// The AddressID property of the Entity Address
		/// </summary>
		public virtual System.Int32 AddressID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressFieldIndex.AddressID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AddressID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressFieldIndex.AddressID, value))
				{
					OnAddressIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The AddressLine1 property of the Entity Address
		/// </summary>
		public virtual System.String AddressLine1
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressFieldIndex.AddressLine1);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AddressLine1 because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressFieldIndex.AddressLine1, value))
				{
					OnAddressLine1Changed();
				}
			}
		}
	
		/// <summary>
		/// The AddressLine2 property of the Entity Address
		/// </summary>
		public virtual System.String AddressLine2
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressFieldIndex.AddressLine2);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AddressLine2 because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressFieldIndex.AddressLine2, value))
				{
					OnAddressLine2Changed();
				}
			}
		}
	
		/// <summary>
		/// The City property of the Entity Address
		/// </summary>
		public virtual System.String City
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressFieldIndex.City);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for City because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressFieldIndex.City, value))
				{
					OnCityChanged();
				}
			}
		}
	
		/// <summary>
		/// The StateProvinceID property of the Entity Address
		/// </summary>
		public virtual System.Int32 StateProvinceID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressFieldIndex.StateProvinceID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for StateProvinceID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressFieldIndex.StateProvinceID, value))
				{
					OnStateProvinceIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The PostalCode property of the Entity Address
		/// </summary>
		public virtual System.String PostalCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressFieldIndex.PostalCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PostalCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressFieldIndex.PostalCode, value))
				{
					OnPostalCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity Address
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity Address
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)AddressFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)AddressFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual EmployeeAddressCollection EmployeeAddress
		{
			get
			{
				return GetMultiEmployeeAddress(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for EmployeeAddress. When set to true, EmployeeAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeAddress(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeAddress
		{
			get
			{
				return _alwaysFetchEmployeeAddress;
			}
			set
			{
				_alwaysFetchEmployeeAddress = value;
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
		/// Retrieves all related entities of type 'SalesOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesOrderHeaderCollection SalesOrderHeader_
		{
			get
			{
				return GetMultiSalesOrderHeader_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesOrderHeader_. When set to true, SalesOrderHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeader_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeader_
		{
			get
			{
				return _alwaysFetchSalesOrderHeader_;
			}
			set
			{
				_alwaysFetchSalesOrderHeader_ = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
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
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressType_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual AddressTypeCollection AddressType_
		{
			get
			{
				return GetMultiAddressType_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for AddressType_. When set to true, AddressType_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressType_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressType_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressType_
		{
			get
			{
				return _alwaysFetchAddressType_;
			}
			set
			{
				_alwaysFetchAddressType_ = value;
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesTerritory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesTerritoryCollection SalesTerritory
		{
			get
			{
				return GetMultiSalesTerritory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesTerritory. When set to true, SalesTerritory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesTerritory is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesTerritory(true).
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
		/// Retrieves all related entities of type 'CreditCardEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCreditCard_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CreditCardCollection CreditCard_
		{
			get
			{
				return GetMultiCreditCard_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CreditCard_. When set to true, CreditCard_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCard_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCreditCard_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCreditCard_
		{
			get
			{
				return _alwaysFetchCreditCard_;
			}
			set
			{
				_alwaysFetchCreditCard_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'CurrencyRateEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrencyRate_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CurrencyRateCollection CurrencyRate_
		{
			get
			{
				return GetMultiCurrencyRate_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CurrencyRate_. When set to true, CurrencyRate_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRate_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCurrencyRate_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrencyRate_
		{
			get
			{
				return _alwaysFetchCurrencyRate_;
			}
			set
			{
				_alwaysFetchCurrencyRate_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'CustomerEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCustomer__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CustomerCollection Customer__
		{
			get
			{
				return GetMultiCustomer__(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Customer__. When set to true, Customer__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Customer__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiCustomer__(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCustomer__
		{
			get
			{
				return _alwaysFetchCustomer__;
			}
			set
			{
				_alwaysFetchCustomer__ = value;
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
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethod_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ShipMethodCollection ShipMethod_
		{
			get
			{
				return GetMultiShipMethod_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ShipMethod_. When set to true, ShipMethod_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiShipMethod_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethod_
		{
			get
			{
				return _alwaysFetchShipMethod_;
			}
			set
			{
				_alwaysFetchShipMethod_ = value;
			}	
		}
	
	
		/// <summary>
		/// Gets / sets related entity of type 'StateProvinceEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleStateProvince()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual StateProvinceEntity StateProvince
		{
			get
			{
				return GetSingleStateProvince(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncStateProvince(value);
				}
				else
				{
					if(value==null)
					{
						if(_stateProvince != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_stateProvince.UnsetRelatedEntity(this, "Address");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "Address");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for StateProvince. When set to true, StateProvince is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time StateProvince is accessed. You can always execute
		/// a forced fetch by calling GetSingleStateProvince(true).
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
	
	
		#endregion
	}
}
