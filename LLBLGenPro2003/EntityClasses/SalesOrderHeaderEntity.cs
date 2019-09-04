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
	/// Entity class which represents the entity 'SalesOrderHeader' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class SalesOrderHeaderEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private SalesOrderDetailCollection	_salesOrderDetail;
		private bool	_alwaysFetchSalesOrderDetail, _alreadyFetchedSalesOrderDetail;
		private SalesOrderHeaderSalesReasonCollection	_salesOrderHeaderSalesReason;
		private bool	_alwaysFetchSalesOrderHeaderSalesReason, _alreadyFetchedSalesOrderHeaderSalesReason;
		private SpecialOfferProductCollection _specialOfferProduct;
		private bool	_alwaysFetchSpecialOfferProduct, _alreadyFetchedSpecialOfferProduct;
		private SalesReasonCollection _salesReason;
		private bool	_alwaysFetchSalesReason, _alreadyFetchedSalesReason;
		private AddressEntity _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private AddressEntity _address_;
		private bool	_alwaysFetchAddress_, _alreadyFetchedAddress_;
		private CreditCardEntity _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard;
		private CurrencyRateEntity _currencyRate;
		private bool	_alwaysFetchCurrencyRate, _alreadyFetchedCurrencyRate;
		private CustomerEntity _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer;
		private SalesPersonEntity _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson;
		private SalesTerritoryEntity _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory;
		private ShipMethodEntity _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when SalesOrderID changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesOrderIDChanged;

		/// <summary>
		/// Event which is thrown when RevisionNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler RevisionNumberChanged;

		/// <summary>
		/// Event which is thrown when OrderDate changes value. Databinding related.
		/// </summary>
		public event EventHandler OrderDateChanged;

		/// <summary>
		/// Event which is thrown when DueDate changes value. Databinding related.
		/// </summary>
		public event EventHandler DueDateChanged;

		/// <summary>
		/// Event which is thrown when ShipDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ShipDateChanged;

		/// <summary>
		/// Event which is thrown when Status changes value. Databinding related.
		/// </summary>
		public event EventHandler StatusChanged;

		/// <summary>
		/// Event which is thrown when OnlineOrderFlag changes value. Databinding related.
		/// </summary>
		public event EventHandler OnlineOrderFlagChanged;

		/// <summary>
		/// Event which is thrown when SalesOrderNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesOrderNumberChanged;

		/// <summary>
		/// Event which is thrown when PurchaseOrderNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler PurchaseOrderNumberChanged;

		/// <summary>
		/// Event which is thrown when AccountNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler AccountNumberChanged;

		/// <summary>
		/// Event which is thrown when CustomerID changes value. Databinding related.
		/// </summary>
		public event EventHandler CustomerIDChanged;

		/// <summary>
		/// Event which is thrown when SalesPersonID changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesPersonIDChanged;

		/// <summary>
		/// Event which is thrown when TerritoryID changes value. Databinding related.
		/// </summary>
		public event EventHandler TerritoryIDChanged;

		/// <summary>
		/// Event which is thrown when BillToAddressID changes value. Databinding related.
		/// </summary>
		public event EventHandler BillToAddressIDChanged;

		/// <summary>
		/// Event which is thrown when ShipToAddressID changes value. Databinding related.
		/// </summary>
		public event EventHandler ShipToAddressIDChanged;

		/// <summary>
		/// Event which is thrown when ShipMethodID changes value. Databinding related.
		/// </summary>
		public event EventHandler ShipMethodIDChanged;

		/// <summary>
		/// Event which is thrown when CreditCardID changes value. Databinding related.
		/// </summary>
		public event EventHandler CreditCardIDChanged;

		/// <summary>
		/// Event which is thrown when CreditCardApprovalCode changes value. Databinding related.
		/// </summary>
		public event EventHandler CreditCardApprovalCodeChanged;

		/// <summary>
		/// Event which is thrown when CurrencyRateID changes value. Databinding related.
		/// </summary>
		public event EventHandler CurrencyRateIDChanged;

		/// <summary>
		/// Event which is thrown when SubTotal changes value. Databinding related.
		/// </summary>
		public event EventHandler SubTotalChanged;

		/// <summary>
		/// Event which is thrown when TaxAmt changes value. Databinding related.
		/// </summary>
		public event EventHandler TaxAmtChanged;

		/// <summary>
		/// Event which is thrown when Freight changes value. Databinding related.
		/// </summary>
		public event EventHandler FreightChanged;

		/// <summary>
		/// Event which is thrown when TotalDue changes value. Databinding related.
		/// </summary>
		public event EventHandler TotalDueChanged;

		/// <summary>
		/// Event which is thrown when Comment changes value. Databinding related.
		/// </summary>
		public event EventHandler CommentChanged;

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
		public SalesOrderHeaderEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new SalesOrderHeaderEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID)
		{
			InitClassFetch(salesOrderID, new SalesOrderHeaderValidator(), new PropertyDescriptorFactory(), new SalesOrderHeaderEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID, SalesOrderHeaderValidator validator)
		{
			InitClassFetch(salesOrderID, validator, new PropertyDescriptorFactory(), new SalesOrderHeaderEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesOrderHeaderEntity(System.Int32 salesOrderID, SalesOrderHeaderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(salesOrderID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesOrderHeaderEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private SalesOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_salesOrderDetail = (SalesOrderDetailCollection)info.GetValue("_salesOrderDetail", typeof(SalesOrderDetailCollection));
			_alwaysFetchSalesOrderDetail = info.GetBoolean("_alwaysFetchSalesOrderDetail");
			_alreadyFetchedSalesOrderDetail = info.GetBoolean("_alreadyFetchedSalesOrderDetail");

			_salesOrderHeaderSalesReason = (SalesOrderHeaderSalesReasonCollection)info.GetValue("_salesOrderHeaderSalesReason", typeof(SalesOrderHeaderSalesReasonCollection));
			_alwaysFetchSalesOrderHeaderSalesReason = info.GetBoolean("_alwaysFetchSalesOrderHeaderSalesReason");
			_alreadyFetchedSalesOrderHeaderSalesReason = info.GetBoolean("_alreadyFetchedSalesOrderHeaderSalesReason");

			_specialOfferProduct = (SpecialOfferProductCollection)info.GetValue("_specialOfferProduct", typeof(SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferProduct");
			_alreadyFetchedSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferProduct");

			_salesReason = (SalesReasonCollection)info.GetValue("_salesReason", typeof(SalesReasonCollection));
			_alwaysFetchSalesReason = info.GetBoolean("_alwaysFetchSalesReason");
			_alreadyFetchedSalesReason = info.GetBoolean("_alreadyFetchedSalesReason");
			_address = (AddressEntity)info.GetValue("_address", typeof(AddressEntity));
			if(_address!=null)
			{
				// rewire event handler.
				_address.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");
			_address_ = (AddressEntity)info.GetValue("_address_", typeof(AddressEntity));
			if(_address_!=null)
			{
				// rewire event handler.
				_address_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchAddress_ = info.GetBoolean("_alwaysFetchAddress_");
			_alreadyFetchedAddress_ = info.GetBoolean("_alreadyFetchedAddress_");
			_creditCard = (CreditCardEntity)info.GetValue("_creditCard", typeof(CreditCardEntity));
			if(_creditCard!=null)
			{
				// rewire event handler.
				_creditCard.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchCreditCard = info.GetBoolean("_alwaysFetchCreditCard");
			_alreadyFetchedCreditCard = info.GetBoolean("_alreadyFetchedCreditCard");
			_currencyRate = (CurrencyRateEntity)info.GetValue("_currencyRate", typeof(CurrencyRateEntity));
			if(_currencyRate!=null)
			{
				// rewire event handler.
				_currencyRate.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchCurrencyRate = info.GetBoolean("_alwaysFetchCurrencyRate");
			_alreadyFetchedCurrencyRate = info.GetBoolean("_alreadyFetchedCurrencyRate");
			_customer = (CustomerEntity)info.GetValue("_customer", typeof(CustomerEntity));
			if(_customer!=null)
			{
				// rewire event handler.
				_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");
			_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
			if(_salesPerson!=null)
			{
				// rewire event handler.
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");
			_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
			if(_salesTerritory!=null)
			{
				// rewire event handler.
				_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");
			_shipMethod = (ShipMethodEntity)info.GetValue("_shipMethod", typeof(ShipMethodEntity));
			if(_shipMethod!=null)
			{
				// rewire event handler.
				_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

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
			_alreadyFetchedSalesOrderDetail = (_salesOrderDetail.Count > 0);
			_alreadyFetchedSalesOrderHeaderSalesReason = (_salesOrderHeaderSalesReason.Count > 0);
			_alreadyFetchedSpecialOfferProduct = (_specialOfferProduct.Count > 0);
			_alreadyFetchedSalesReason = (_salesReason.Count > 0);
			_alreadyFetchedAddress = (_address != null);
			_alreadyFetchedAddress_ = (_address_ != null);
			_alreadyFetchedCreditCard = (_creditCard != null);
			_alreadyFetchedCurrencyRate = (_currencyRate != null);
			_alreadyFetchedCustomer = (_customer != null);
			_alreadyFetchedSalesPerson = (_salesPerson != null);
			_alreadyFetchedSalesTerritory = (_salesTerritory != null);
			_alreadyFetchedShipMethod = (_shipMethod != null);

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
			info.AddValue("_salesOrderDetail", _salesOrderDetail);
			info.AddValue("_alwaysFetchSalesOrderDetail", _alwaysFetchSalesOrderDetail);
			info.AddValue("_alreadyFetchedSalesOrderDetail", _alreadyFetchedSalesOrderDetail);
			info.AddValue("_salesOrderHeaderSalesReason", _salesOrderHeaderSalesReason);
			info.AddValue("_alwaysFetchSalesOrderHeaderSalesReason", _alwaysFetchSalesOrderHeaderSalesReason);
			info.AddValue("_alreadyFetchedSalesOrderHeaderSalesReason", _alreadyFetchedSalesOrderHeaderSalesReason);
			info.AddValue("_specialOfferProduct", _specialOfferProduct);
			info.AddValue("_alwaysFetchSpecialOfferProduct", _alwaysFetchSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferProduct", _alreadyFetchedSpecialOfferProduct);
			info.AddValue("_salesReason", _salesReason);
			info.AddValue("_alwaysFetchSalesReason", _alwaysFetchSalesReason);
			info.AddValue("_alreadyFetchedSalesReason", _alreadyFetchedSalesReason);
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
			info.AddValue("_salesPerson", _salesPerson);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
			info.AddValue("_salesTerritory", _salesTerritory);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);

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
				case "Address_":
					SetupSyncAddress_(relatedEntity);
					break;
				case "CreditCard":
					SetupSyncCreditCard(relatedEntity);
					break;
				case "CurrencyRate":
					SetupSyncCurrencyRate(relatedEntity);
					break;
				case "Customer":
					SetupSyncCustomer(relatedEntity);
					break;
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
					break;
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "SalesOrderDetail":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesOrderDetail.Add(relatedEntity);
					break;
				case "SalesOrderHeaderSalesReason":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesOrderHeaderSalesReason.Add(relatedEntity);
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
				case "Address_":
					DesetupSyncAddress_(false);
					break;
				case "CreditCard":
					DesetupSyncCreditCard(false);
					break;
				case "CurrencyRate":
					DesetupSyncCurrencyRate(false);
					break;
				case "Customer":
					DesetupSyncCustomer(false);
					break;
				case "SalesPerson":
					DesetupSyncSalesPerson(false);
					break;
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false);
					break;
				case "SalesOrderDetail":
					// Remove it from the collection.
					_salesOrderDetail.Remove(relatedEntity);
					break;
				case "SalesOrderHeaderSalesReason":
					// Remove it from the collection.
					_salesOrderHeaderSalesReason.Remove(relatedEntity);
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
			if(_address_!=null)
			{
				toReturn.Add(_address_);
			}
			if(_creditCard!=null)
			{
				toReturn.Add(_creditCard);
			}
			if(_currencyRate!=null)
			{
				toReturn.Add(_currencyRate);
			}
			if(_customer!=null)
			{
				toReturn.Add(_customer);
			}
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
			}
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			if(_shipMethod!=null)
			{
				toReturn.Add(_shipMethod);
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

			toReturn.Add(_salesOrderDetail);
			toReturn.Add(_salesOrderHeaderSalesReason);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("SalesOrderHeaderEntity");
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
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID)
		{
			return Fetch(salesOrderID);
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
			return Fetch(this.SalesOrderID);
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
			SalesOrderHeaderDAO dao = DAOFactory.CreateSalesOrderHeaderDAO();
			bool wasSuccesful = dao.DeleteSalesOrderHeader(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(SalesOrderHeaderFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public virtual SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesOrderDetail || forceFetch || _alwaysFetchSalesOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderDetail);
					}
				}
				_salesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_salesOrderDetail.GetMultiManyToOne(this, null);
				_salesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderDetail = true;
			}
			return _salesOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderDetailEntity'</returns>
		public virtual SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderDetail || forceFetch || _alwaysFetchSalesOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderDetail);
					}
				}
				_salesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_salesOrderDetail.GetMultiManyToOne(this, null, filter);
				_salesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderDetail = true;
			}
			return _salesOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesOrderDetail || forceFetch || _alwaysFetchSalesOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderDetail);
					}
				}
				_salesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_salesOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderDetail.GetMultiManyToOne(this, null);
				_salesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderDetail = true;
			}
			return _salesOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesOrderDetailCollection GetMultiSalesOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderDetail || forceFetch || _alwaysFetchSalesOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderDetail);
					}
				}
				_salesOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_salesOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderDetail.GetMultiManyToOne(this, null, filter);
				_salesOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderDetail = true;
			}
			return _salesOrderDetail;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesOrderDetail'. These settings will be taken into account
		/// when the property SalesOrderDetail is requested or GetMultiSalesOrderDetail is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderDetail.SortClauses=sortClauses;
			_salesOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderSalesReasonEntity'</returns>
		public virtual SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReason(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaderSalesReason || forceFetch || _alwaysFetchSalesOrderHeaderSalesReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeaderSalesReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeaderSalesReason);
					}
				}
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaderSalesReason.GetMultiManyToOne(this, null);
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaderSalesReason = true;
			}
			return _salesOrderHeaderSalesReason;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SalesOrderHeaderSalesReasonEntity'</returns>
		public virtual SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReason(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaderSalesReason || forceFetch || _alwaysFetchSalesOrderHeaderSalesReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeaderSalesReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeaderSalesReason);
					}
				}
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaderSalesReason.GetMultiManyToOne(this, null, filter);
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaderSalesReason = true;
			}
			return _salesOrderHeaderSalesReason;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReason(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaderSalesReason || forceFetch || _alwaysFetchSalesOrderHeaderSalesReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeaderSalesReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeaderSalesReason);
					}
				}
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaderSalesReason.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaderSalesReason.GetMultiManyToOne(this, null);
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaderSalesReason = true;
			}
			return _salesOrderHeaderSalesReason;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesOrderHeaderSalesReasonCollection GetMultiSalesOrderHeaderSalesReason(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSalesOrderHeaderSalesReason || forceFetch || _alwaysFetchSalesOrderHeaderSalesReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesOrderHeaderSalesReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesOrderHeaderSalesReason);
					}
				}
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=!forceFetch;
				_salesOrderHeaderSalesReason.EntityFactoryToUse = entityFactoryToUse;
				_salesOrderHeaderSalesReason.GetMultiManyToOne(this, null, filter);
				_salesOrderHeaderSalesReason.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesOrderHeaderSalesReason = true;
			}
			return _salesOrderHeaderSalesReason;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesOrderHeaderSalesReason'. These settings will be taken into account
		/// when the property SalesOrderHeaderSalesReason is requested or GetMultiSalesOrderHeaderSalesReason is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesOrderHeaderSalesReason(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesOrderHeaderSalesReason.SortClauses=sortClauses;
			_salesOrderHeaderSalesReason.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public virtual SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProduct);
					}
				}
				_specialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				_specialOfferProduct.GetMultiManyToManyUsingSalesOrderHeader(this);
				_specialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProduct = true;
			}
			return _specialOfferProduct;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProduct);
					}
				}
				_specialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				_specialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				_specialOfferProduct.GetMultiManyToManyUsingSalesOrderHeader(this);
				_specialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProduct = true;
			}
			return _specialOfferProduct;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SpecialOfferProduct'. These settings will be taken into account
		/// when the property SpecialOfferProduct is requested or GetMultiSpecialOfferProduct is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferProduct.SortClauses=sortClauses;
			_specialOfferProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'SalesReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SalesReasonEntity'</returns>
		public virtual SalesReasonCollection GetMultiSalesReason(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesReason || forceFetch || _alwaysFetchSalesReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesReason);
					}
				}
				_salesReason.SuppressClearInGetMulti=!forceFetch;
				_salesReason.GetMultiManyToManyUsingSalesOrderHeader(this);
				_salesReason.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesReason = true;
			}
			return _salesReason;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SalesReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SalesReasonCollection GetMultiSalesReason(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSalesReason || forceFetch || _alwaysFetchSalesReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_salesReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_salesReason);
					}
				}
				_salesReason.SuppressClearInGetMulti=!forceFetch;
				_salesReason.EntityFactoryToUse = entityFactoryToUse;
				_salesReason.GetMultiManyToManyUsingSalesOrderHeader(this);
				_salesReason.SuppressClearInGetMulti=false;
				_alreadyFetchedSalesReason = true;
			}
			return _salesReason;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SalesReason'. These settings will be taken into account
		/// when the property SalesReason is requested or GetMultiSalesReason is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSalesReason(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_salesReason.SortClauses=sortClauses;
			_salesReason.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				newEntity.FetchUsingPK(this.BillToAddressID);
				this.Address = newEntity;

				_alreadyFetchedAddress = true;
			}
			return _address;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress_()
		{
			return GetSingleAddress_(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'AddressEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'AddressEntity' which is related to this entity.</returns>
		public virtual AddressEntity GetSingleAddress_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddress_ || forceFetch || _alwaysFetchAddress_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				AddressEntity newEntity = new AddressEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ShipToAddressID);
				this.Address_ = newEntity;

				_alreadyFetchedAddress_ = true;
			}
			return _address_;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'CreditCardEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'CreditCardEntity' which is related to this entity.</returns>
		public virtual CreditCardEntity GetSingleCreditCard()
		{
			return GetSingleCreditCard(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'CreditCardEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'CreditCardEntity' which is related to this entity.</returns>
		public virtual CreditCardEntity GetSingleCreditCard(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCreditCard || forceFetch || _alwaysFetchCreditCard) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				CreditCardEntity newEntity = new CreditCardEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.CreditCardID);
				this.CreditCard = newEntity;

				_alreadyFetchedCreditCard = true;
			}
			return _creditCard;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'CurrencyRateEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'CurrencyRateEntity' which is related to this entity.</returns>
		public virtual CurrencyRateEntity GetSingleCurrencyRate()
		{
			return GetSingleCurrencyRate(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'CurrencyRateEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'CurrencyRateEntity' which is related to this entity.</returns>
		public virtual CurrencyRateEntity GetSingleCurrencyRate(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCurrencyRate || forceFetch || _alwaysFetchCurrencyRate) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				CurrencyRateEntity newEntity = new CurrencyRateEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.CurrencyRateID);
				this.CurrencyRate = newEntity;

				_alreadyFetchedCurrencyRate = true;
			}
			return _currencyRate;
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
		/// Retrieves the related entity of type 'ShipMethodEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ShipMethodEntity' which is related to this entity.</returns>
		public virtual ShipMethodEntity GetSingleShipMethod()
		{
			return GetSingleShipMethod(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ShipMethodEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ShipMethodEntity' which is related to this entity.</returns>
		public virtual ShipMethodEntity GetSingleShipMethod(bool forceFetch)
		{
 			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ShipMethodEntity newEntity = new ShipMethodEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ShipMethodID);
				this.ShipMethod = newEntity;

				_alreadyFetchedShipMethod = true;
			}
			return _shipMethod;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the SalesOrderIDChanged event, which is thrown when SalesOrderID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSalesOrderIDChanged()
		{
			if(SalesOrderIDChanged!=null)
			{
				SalesOrderIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the RevisionNumberChanged event, which is thrown when RevisionNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnRevisionNumberChanged()
		{
			if(RevisionNumberChanged!=null)
			{
				RevisionNumberChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the OrderDateChanged event, which is thrown when OrderDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnOrderDateChanged()
		{
			if(OrderDateChanged!=null)
			{
				OrderDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DueDateChanged event, which is thrown when DueDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDueDateChanged()
		{
			if(DueDateChanged!=null)
			{
				DueDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ShipDateChanged event, which is thrown when ShipDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnShipDateChanged()
		{
			if(ShipDateChanged!=null)
			{
				ShipDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the StatusChanged event, which is thrown when Status changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnStatusChanged()
		{
			if(StatusChanged!=null)
			{
				StatusChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the OnlineOrderFlagChanged event, which is thrown when OnlineOrderFlag changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnOnlineOrderFlagChanged()
		{
			if(OnlineOrderFlagChanged!=null)
			{
				OnlineOrderFlagChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SalesOrderNumberChanged event, which is thrown when SalesOrderNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSalesOrderNumberChanged()
		{
			if(SalesOrderNumberChanged!=null)
			{
				SalesOrderNumberChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PurchaseOrderNumberChanged event, which is thrown when PurchaseOrderNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPurchaseOrderNumberChanged()
		{
			if(PurchaseOrderNumberChanged!=null)
			{
				PurchaseOrderNumberChanged(this, new EventArgs());
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
		/// Event thrower for the BillToAddressIDChanged event, which is thrown when BillToAddressID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnBillToAddressIDChanged()
		{
			if(BillToAddressIDChanged!=null)
			{
				BillToAddressIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ShipToAddressIDChanged event, which is thrown when ShipToAddressID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnShipToAddressIDChanged()
		{
			if(ShipToAddressIDChanged!=null)
			{
				ShipToAddressIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ShipMethodIDChanged event, which is thrown when ShipMethodID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnShipMethodIDChanged()
		{
			if(ShipMethodIDChanged!=null)
			{
				ShipMethodIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CreditCardIDChanged event, which is thrown when CreditCardID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCreditCardIDChanged()
		{
			if(CreditCardIDChanged!=null)
			{
				CreditCardIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CreditCardApprovalCodeChanged event, which is thrown when CreditCardApprovalCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCreditCardApprovalCodeChanged()
		{
			if(CreditCardApprovalCodeChanged!=null)
			{
				CreditCardApprovalCodeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CurrencyRateIDChanged event, which is thrown when CurrencyRateID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCurrencyRateIDChanged()
		{
			if(CurrencyRateIDChanged!=null)
			{
				CurrencyRateIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SubTotalChanged event, which is thrown when SubTotal changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSubTotalChanged()
		{
			if(SubTotalChanged!=null)
			{
				SubTotalChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the TaxAmtChanged event, which is thrown when TaxAmt changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTaxAmtChanged()
		{
			if(TaxAmtChanged!=null)
			{
				TaxAmtChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the FreightChanged event, which is thrown when Freight changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnFreightChanged()
		{
			if(FreightChanged!=null)
			{
				FreightChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the TotalDueChanged event, which is thrown when TotalDue changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTotalDueChanged()
		{
			if(TotalDueChanged!=null)
			{
				TotalDueChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CommentChanged event, which is thrown when Comment changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCommentChanged()
		{
			if(CommentChanged!=null)
			{
				CommentChanged(this, new EventArgs());
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
			SalesOrderHeaderDAO dao = DAOFactory.CreateSalesOrderHeaderDAO();
			return dao.AddSalesOrderHeader(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesOrderHeaderDAO dao = DAOFactory.CreateSalesOrderHeaderDAO();
			return dao.UpdateSalesOrderHeader(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesOrderHeaderDAO dao = DAOFactory.CreateSalesOrderHeaderDAO();
			return dao.UpdateSalesOrderHeader(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SalesOrderHeaderEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new SalesOrderHeaderValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this SalesOrderHeaderEntity</param>
		private void InitClassFetch(System.Int32 salesOrderID, SalesOrderHeaderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SalesOrderHeaderEntity);
			bool wasSuccesful = Fetch(salesOrderID);
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
			_salesOrderDetail = new SalesOrderDetailCollection(propertyDescriptorFactoryToUse, new SalesOrderDetailEntityFactory());
			_salesOrderDetail.SetContainingEntityInfo(this, "SalesOrderHeader");
			_alwaysFetchSalesOrderDetail = false;
			_alreadyFetchedSalesOrderDetail = false;
			_salesOrderHeaderSalesReason = new SalesOrderHeaderSalesReasonCollection(propertyDescriptorFactoryToUse, new SalesOrderHeaderSalesReasonEntityFactory());
			_salesOrderHeaderSalesReason.SetContainingEntityInfo(this, "SalesOrderHeader");
			_alwaysFetchSalesOrderHeaderSalesReason = false;
			_alreadyFetchedSalesOrderHeaderSalesReason = false;
			_specialOfferProduct = new SpecialOfferProductCollection(propertyDescriptorFactoryToUse, new SpecialOfferProductEntityFactory());
			_alwaysFetchSpecialOfferProduct = false;
			_alreadyFetchedSpecialOfferProduct = false;
			_salesReason = new SalesReasonCollection(propertyDescriptorFactoryToUse, new SalesReasonEntityFactory());
			_alwaysFetchSalesReason = false;
			_alreadyFetchedSalesReason = false;
			_address = null;
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_address_ = null;
			_alwaysFetchAddress_ = false;
			_alreadyFetchedAddress_ = false;
			_creditCard = null;
			_alwaysFetchCreditCard = false;
			_alreadyFetchedCreditCard = false;
			_currencyRate = null;
			_alwaysFetchCurrencyRate = false;
			_alreadyFetchedCurrencyRate = false;
			_customer = null;
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;
			_salesPerson = null;
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
			_salesTerritory = null;
			_alwaysFetchSalesTerritory = false;
			_alreadyFetchedSalesTerritory = false;
			_shipMethod = null;
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;

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
					_address.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				base.UnsetEntitySyncInformation("Address", _address, SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressID);
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
				base.SetEntitySyncInformation("Address", _address, SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressID);
				if(!_address.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderEntity.Relations.AddressEntityUsingBillToAddressID, _address);
				}
			}

			_alreadyFetchedAddress = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _address_
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncAddress_(bool signalRelatedEntity)
		{
			if(_address_ != null)
			{
				// disconnect the entity from this entity
				_address_.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_address_.UnsetRelatedEntity(this, "SalesOrderHeader_");
				}
				base.UnsetEntitySyncInformation("Address_", _address_, SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressID);
				_address_ = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _address_
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress_(IEntity relatedEntity)
		{
			DesetupSyncAddress_(true);
			
			if(relatedEntity!=null)
			{
				_address_ = (AddressEntity)relatedEntity;
				_address_.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Address_", _address_, SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressID);
				if(!_address_.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderEntity.Relations.AddressEntityUsingShipToAddressID, _address_);
				}
			}

			_alreadyFetchedAddress_ = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _creditCard
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCreditCard(bool signalRelatedEntity)
		{
			if(_creditCard != null)
			{
				// disconnect the entity from this entity
				_creditCard.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_creditCard.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				base.UnsetEntitySyncInformation("CreditCard", _creditCard, SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardID);
				_creditCard = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _creditCard
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCreditCard(IEntity relatedEntity)
		{
			DesetupSyncCreditCard(true);
			
			if(relatedEntity!=null)
			{
				_creditCard = (CreditCardEntity)relatedEntity;
				_creditCard.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("CreditCard", _creditCard, SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardID);
				if(!_creditCard.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderEntity.Relations.CreditCardEntityUsingCreditCardID, _creditCard);
				}
			}

			_alreadyFetchedCreditCard = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _currencyRate
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCurrencyRate(bool signalRelatedEntity)
		{
			if(_currencyRate != null)
			{
				// disconnect the entity from this entity
				_currencyRate.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_currencyRate.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				base.UnsetEntitySyncInformation("CurrencyRate", _currencyRate, SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateID);
				_currencyRate = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _currencyRate
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrencyRate(IEntity relatedEntity)
		{
			DesetupSyncCurrencyRate(true);
			
			if(relatedEntity!=null)
			{
				_currencyRate = (CurrencyRateEntity)relatedEntity;
				_currencyRate.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("CurrencyRate", _currencyRate, SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateID);
				if(!_currencyRate.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderEntity.Relations.CurrencyRateEntityUsingCurrencyRateID, _currencyRate);
				}
			}

			_alreadyFetchedCurrencyRate = (relatedEntity != null);
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
					_customer.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				base.UnsetEntitySyncInformation("Customer", _customer, SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerID);
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
				base.SetEntitySyncInformation("Customer", _customer, SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerID);
				if(!_customer.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderEntity.Relations.CustomerEntityUsingCustomerID, _customer);
				}
			}

			_alreadyFetchedCustomer = (relatedEntity != null);
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
					_salesPerson.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				base.UnsetEntitySyncInformation("SalesPerson", _salesPerson, SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonID);
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
				base.SetEntitySyncInformation("SalesPerson", _salesPerson, SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonID);
				if(!_salesPerson.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderEntity.Relations.SalesPersonEntityUsingSalesPersonID, _salesPerson);
				}
			}

			_alreadyFetchedSalesPerson = (relatedEntity != null);
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
					_salesTerritory.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				base.UnsetEntitySyncInformation("SalesTerritory", _salesTerritory, SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryID);
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
				base.SetEntitySyncInformation("SalesTerritory", _salesTerritory, SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryID);
				if(!_salesTerritory.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderEntity.Relations.SalesTerritoryEntityUsingTerritoryID, _salesTerritory);
				}
			}

			_alreadyFetchedSalesTerritory = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _shipMethod
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncShipMethod(bool signalRelatedEntity)
		{
			if(_shipMethod != null)
			{
				// disconnect the entity from this entity
				_shipMethod.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_shipMethod.UnsetRelatedEntity(this, "SalesOrderHeader");
				}
				base.UnsetEntitySyncInformation("ShipMethod", _shipMethod, SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID);
				_shipMethod = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _shipMethod
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShipMethod(IEntity relatedEntity)
		{
			DesetupSyncShipMethod(true);
			
			if(relatedEntity!=null)
			{
				_shipMethod = (ShipMethodEntity)relatedEntity;
				_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("ShipMethod", _shipMethod, SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID);
				if(!_shipMethod.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, _shipMethod);
				}
			}

			_alreadyFetchedShipMethod = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesOrderID)
		{
			SalesOrderHeaderDAO dao = DAOFactory.CreateSalesOrderHeaderDAO();

			// Load EntityFields of SalesOrderHeader
			dao.FetchSalesOrderHeader(base.Fields, base.Transaction, salesOrderID);

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
		public static SalesOrderHeaderRelations Relations
		{
			get	{ return new SalesOrderHeaderRelations(); }
		}

	
		/// <summary>
		/// The SalesOrderID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 SalesOrderID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.SalesOrderID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesOrderID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.SalesOrderID, value))
				{
					OnSalesOrderIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The RevisionNumber property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Byte RevisionNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.RevisionNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for RevisionNumber because it is set to NULL.");
				}
				return (System.Byte)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.RevisionNumber, value))
				{
					OnRevisionNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The OrderDate property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.DateTime OrderDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.OrderDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for OrderDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.OrderDate, value))
				{
					OnOrderDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The DueDate property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.DateTime DueDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.DueDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DueDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.DueDate, value))
				{
					OnDueDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The ShipDate property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.DateTime ShipDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ShipDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ShipDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ShipDate, value))
				{
					OnShipDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The Status property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Byte Status
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.Status);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Status because it is set to NULL.");
				}
				return (System.Byte)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.Status, value))
				{
					OnStatusChanged();
				}
			}
		}
	
		/// <summary>
		/// The OnlineOrderFlag property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Boolean OnlineOrderFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for OnlineOrderFlag because it is set to NULL.");
				}
				return (System.Boolean)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, value))
				{
					OnOnlineOrderFlagChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesOrderNumber property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.String SalesOrderNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.SalesOrderNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesOrderNumber because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.SalesOrderNumber, value))
				{
					OnSalesOrderNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The PurchaseOrderNumber property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.String PurchaseOrderNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PurchaseOrderNumber because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, value))
				{
					OnPurchaseOrderNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The AccountNumber property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.String AccountNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.AccountNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AccountNumber because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.AccountNumber, value))
				{
					OnAccountNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The CustomerID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 CustomerID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.CustomerID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CustomerID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CustomerID, value))
				{
					OnCustomerIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesPersonID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 SalesPersonID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.SalesPersonID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesPersonID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.SalesPersonID, value))
				{
					OnSalesPersonIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The TerritoryID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 TerritoryID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.TerritoryID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TerritoryID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.TerritoryID, value))
				{
					OnTerritoryIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The BillToAddressID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 BillToAddressID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.BillToAddressID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for BillToAddressID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.BillToAddressID, value))
				{
					OnBillToAddressIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ShipToAddressID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 ShipToAddressID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ShipToAddressID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ShipToAddressID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ShipToAddressID, value))
				{
					OnShipToAddressIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ShipMethodID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 ShipMethodID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ShipMethodID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ShipMethodID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ShipMethodID, value))
				{
					OnShipMethodIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The CreditCardID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 CreditCardID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.CreditCardID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CreditCardID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CreditCardID, value))
				{
					OnCreditCardIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The CreditCardApprovalCode property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.String CreditCardApprovalCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CreditCardApprovalCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, value))
				{
					OnCreditCardApprovalCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The CurrencyRateID property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Int32 CurrencyRateID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.CurrencyRateID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CurrencyRateID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.CurrencyRateID, value))
				{
					OnCurrencyRateIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The SubTotal property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Decimal SubTotal
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.SubTotal);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SubTotal because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.SubTotal, value))
				{
					OnSubTotalChanged();
				}
			}
		}
	
		/// <summary>
		/// The TaxAmt property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Decimal TaxAmt
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.TaxAmt);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TaxAmt because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.TaxAmt, value))
				{
					OnTaxAmtChanged();
				}
			}
		}
	
		/// <summary>
		/// The Freight property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Decimal Freight
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.Freight);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Freight because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.Freight, value))
				{
					OnFreightChanged();
				}
			}
		}
	
		/// <summary>
		/// The TotalDue property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Decimal TotalDue
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.TotalDue);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TotalDue because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.TotalDue, value))
				{
					OnTotalDueChanged();
				}
			}
		}
	
		/// <summary>
		/// The Comment property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.String Comment
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.Comment);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Comment because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.Comment, value))
				{
					OnCommentChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity SalesOrderHeader
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesOrderDetailCollection SalesOrderDetail
		{
			get
			{
				return GetMultiSalesOrderDetail(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesOrderDetail. When set to true, SalesOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderDetail(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderDetail
		{
			get
			{
				return _alwaysFetchSalesOrderDetail;
			}
			set
			{
				_alwaysFetchSalesOrderDetail = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'SalesOrderHeaderSalesReasonEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesOrderHeaderSalesReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesOrderHeaderSalesReasonCollection SalesOrderHeaderSalesReason
		{
			get
			{
				return GetMultiSalesOrderHeaderSalesReason(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesOrderHeaderSalesReason. When set to true, SalesOrderHeaderSalesReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeaderSalesReason is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesOrderHeaderSalesReason(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesOrderHeaderSalesReason
		{
			get
			{
				return _alwaysFetchSalesOrderHeaderSalesReason;
			}
			set
			{
				_alwaysFetchSalesOrderHeaderSalesReason = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SpecialOfferProductCollection SpecialOfferProduct
		{
			get
			{
				return GetMultiSpecialOfferProduct(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SpecialOfferProduct. When set to true, SpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferProduct(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProduct
		{
			get
			{
				return _alwaysFetchSpecialOfferProduct;
			}
			set
			{
				_alwaysFetchSpecialOfferProduct = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'SalesReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSalesReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SalesReasonCollection SalesReason
		{
			get
			{
				return GetMultiSalesReason(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesReason. When set to true, SalesReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesReason is accessed. You can always execute
		/// a forced fetch by calling GetMultiSalesReason(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSalesReason
		{
			get
			{
				return _alwaysFetchSalesReason;
			}
			set
			{
				_alwaysFetchSalesReason = value;
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
							_address.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
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
		/// Gets / sets related entity of type 'AddressEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleAddress_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual AddressEntity Address_
		{
			get
			{
				return GetSingleAddress_(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncAddress_(value);
				}
				else
				{
					if(value==null)
					{
						if(_address_ != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_address_.UnsetRelatedEntity(this, "SalesOrderHeader_");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader_");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Address_. When set to true, Address_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleAddress_(true).
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
		/// Gets / sets related entity of type 'CreditCardEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CreditCardEntity CreditCard
		{
			get
			{
				return GetSingleCreditCard(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCreditCard(value);
				}
				else
				{
					if(value==null)
					{
						if(_creditCard != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_creditCard.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CreditCard. When set to true, CreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCard is accessed. You can always execute
		/// a forced fetch by calling GetSingleCreditCard(true).
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
		/// Gets / sets related entity of type 'CurrencyRateEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCurrencyRate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CurrencyRateEntity CurrencyRate
		{
			get
			{
				return GetSingleCurrencyRate(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCurrencyRate(value);
				}
				else
				{
					if(value==null)
					{
						if(_currencyRate != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_currencyRate.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CurrencyRate. When set to true, CurrencyRate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CurrencyRate is accessed. You can always execute
		/// a forced fetch by calling GetSingleCurrencyRate(true).
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
							_customer.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
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
							_salesPerson.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
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
							_salesTerritory.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
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
		/// Gets / sets related entity of type 'ShipMethodEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShipMethod()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ShipMethodEntity ShipMethod
		{
			get
			{
				return GetSingleShipMethod(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncShipMethod(value);
				}
				else
				{
					if(value==null)
					{
						if(_shipMethod != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_shipMethod.UnsetRelatedEntity(this, "SalesOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeader");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ShipMethod. When set to true, ShipMethod is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod is accessed. You can always execute
		/// a forced fetch by calling GetSingleShipMethod(true).
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
	
	
		#endregion
	}
}
