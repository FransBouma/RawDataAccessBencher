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
	/// Entity class which represents the entity 'CurrencyRate' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class CurrencyRateEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private SalesOrderHeaderCollection	_salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private AddressCollection _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private AddressCollection _address_;
		private bool	_alwaysFetchAddress_, _alreadyFetchedAddress_;
		private CreditCardCollection _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard;
		private CustomerCollection _customer;
		private bool	_alwaysFetchCustomer, _alreadyFetchedCustomer;
		private SalesPersonCollection _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson;
		private SalesTerritoryCollection _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory;
		private ShipMethodCollection _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;
		private CurrencyEntity _currency;
		private bool	_alwaysFetchCurrency, _alreadyFetchedCurrency;
		private CurrencyEntity _currency_;
		private bool	_alwaysFetchCurrency_, _alreadyFetchedCurrency_;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when CurrencyRateID changes value. Databinding related.
		/// </summary>
		public event EventHandler CurrencyRateIDChanged;

		/// <summary>
		/// Event which is thrown when CurrencyRateDate changes value. Databinding related.
		/// </summary>
		public event EventHandler CurrencyRateDateChanged;

		/// <summary>
		/// Event which is thrown when FromCurrencyCode changes value. Databinding related.
		/// </summary>
		public event EventHandler FromCurrencyCodeChanged;

		/// <summary>
		/// Event which is thrown when ToCurrencyCode changes value. Databinding related.
		/// </summary>
		public event EventHandler ToCurrencyCodeChanged;

		/// <summary>
		/// Event which is thrown when AverageRate changes value. Databinding related.
		/// </summary>
		public event EventHandler AverageRateChanged;

		/// <summary>
		/// Event which is thrown when EndOfDayRate changes value. Databinding related.
		/// </summary>
		public event EventHandler EndOfDayRateChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public CurrencyRateEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new CurrencyRateEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		public CurrencyRateEntity(System.Int32 currencyRateID)
		{
			InitClassFetch(currencyRateID, new CurrencyRateValidator(), new PropertyDescriptorFactory(), new CurrencyRateEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="validator">The custom validator object for this CurrencyRateEntity</param>
		public CurrencyRateEntity(System.Int32 currencyRateID, CurrencyRateValidator validator)
		{
			InitClassFetch(currencyRateID, validator, new PropertyDescriptorFactory(), new CurrencyRateEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="validator">The custom validator object for this CurrencyRateEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CurrencyRateEntity(System.Int32 currencyRateID, CurrencyRateValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(currencyRateID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CurrencyRateEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private CurrencyRateEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_salesOrderHeader = (SalesOrderHeaderCollection)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderCollection));
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");

			_address = (AddressCollection)info.GetValue("_address", typeof(AddressCollection));
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");

			_address_ = (AddressCollection)info.GetValue("_address_", typeof(AddressCollection));
			_alwaysFetchAddress_ = info.GetBoolean("_alwaysFetchAddress_");
			_alreadyFetchedAddress_ = info.GetBoolean("_alreadyFetchedAddress_");

			_creditCard = (CreditCardCollection)info.GetValue("_creditCard", typeof(CreditCardCollection));
			_alwaysFetchCreditCard = info.GetBoolean("_alwaysFetchCreditCard");
			_alreadyFetchedCreditCard = info.GetBoolean("_alreadyFetchedCreditCard");

			_customer = (CustomerCollection)info.GetValue("_customer", typeof(CustomerCollection));
			_alwaysFetchCustomer = info.GetBoolean("_alwaysFetchCustomer");
			_alreadyFetchedCustomer = info.GetBoolean("_alreadyFetchedCustomer");

			_salesPerson = (SalesPersonCollection)info.GetValue("_salesPerson", typeof(SalesPersonCollection));
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");

			_salesTerritory = (SalesTerritoryCollection)info.GetValue("_salesTerritory", typeof(SalesTerritoryCollection));
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");

			_shipMethod = (ShipMethodCollection)info.GetValue("_shipMethod", typeof(ShipMethodCollection));
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");
			_currency = (CurrencyEntity)info.GetValue("_currency", typeof(CurrencyEntity));
			if(_currency!=null)
			{
				// rewire event handler.
				_currency.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchCurrency = info.GetBoolean("_alwaysFetchCurrency");
			_alreadyFetchedCurrency = info.GetBoolean("_alreadyFetchedCurrency");
			_currency_ = (CurrencyEntity)info.GetValue("_currency_", typeof(CurrencyEntity));
			if(_currency_!=null)
			{
				// rewire event handler.
				_currency_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchCurrency_ = info.GetBoolean("_alwaysFetchCurrency_");
			_alreadyFetchedCurrency_ = info.GetBoolean("_alreadyFetchedCurrency_");

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
			_alreadyFetchedAddress = (_address.Count > 0);
			_alreadyFetchedAddress_ = (_address_.Count > 0);
			_alreadyFetchedCreditCard = (_creditCard.Count > 0);
			_alreadyFetchedCustomer = (_customer.Count > 0);
			_alreadyFetchedSalesPerson = (_salesPerson.Count > 0);
			_alreadyFetchedSalesTerritory = (_salesTerritory.Count > 0);
			_alreadyFetchedShipMethod = (_shipMethod.Count > 0);
			_alreadyFetchedCurrency = (_currency != null);
			_alreadyFetchedCurrency_ = (_currency_ != null);

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
			info.AddValue("_address", _address);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_address_", _address_);
			info.AddValue("_alwaysFetchAddress_", _alwaysFetchAddress_);
			info.AddValue("_alreadyFetchedAddress_", _alreadyFetchedAddress_);
			info.AddValue("_creditCard", _creditCard);
			info.AddValue("_alwaysFetchCreditCard", _alwaysFetchCreditCard);
			info.AddValue("_alreadyFetchedCreditCard", _alreadyFetchedCreditCard);
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
			info.AddValue("_currency", _currency);
			info.AddValue("_alwaysFetchCurrency", _alwaysFetchCurrency);
			info.AddValue("_alreadyFetchedCurrency", _alreadyFetchedCurrency);
			info.AddValue("_currency_", _currency_);
			info.AddValue("_alwaysFetchCurrency_", _alwaysFetchCurrency_);
			info.AddValue("_alreadyFetchedCurrency_", _alreadyFetchedCurrency_);

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
				case "Currency":
					SetupSyncCurrency(relatedEntity);
					break;
				case "Currency_":
					SetupSyncCurrency_(relatedEntity);
					break;
				case "SalesOrderHeader":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_salesOrderHeader.Add(relatedEntity);
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
				case "Currency":
					DesetupSyncCurrency(false);
					break;
				case "Currency_":
					DesetupSyncCurrency_(false);
					break;
				case "SalesOrderHeader":
					// Remove it from the collection.
					_salesOrderHeader.Remove(relatedEntity);
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
			if(_currency!=null)
			{
				toReturn.Add(_currency);
			}
			if(_currency_!=null)
			{
				toReturn.Add(_currency_);
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
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("CurrencyRateEntity");
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
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 currencyRateID)
		{
			return Fetch(currencyRateID);
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
			return Fetch(this.CurrencyRateID);
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
			CurrencyRateDAO dao = DAOFactory.CreateCurrencyRateDAO();
			bool wasSuccesful = dao.DeleteCurrencyRate(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(CurrencyRateFieldIndex fieldIndex)
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, this, null, null, null, null);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, this, null, null, null, null, filter);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, this, null, null, null, null);
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
				_salesOrderHeader.GetMultiManyToOne(null, null, null, this, null, null, null, null, filter);
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
				_address.GetMultiManyToManyUsingCurrencyRate(this);
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
				_address.GetMultiManyToManyUsingCurrencyRate(this);
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
				_address_.GetMultiManyToManyUsingCurrencyRate_(this);
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
				_address_.GetMultiManyToManyUsingCurrencyRate_(this);
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
				_creditCard.GetMultiManyToManyUsingCurrencyRate(this);
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
				_creditCard.GetMultiManyToManyUsingCurrencyRate(this);
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
				_customer.GetMultiManyToManyUsingCurrencyRate(this);
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
				_customer.GetMultiManyToManyUsingCurrencyRate(this);
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
				_salesPerson.GetMultiManyToManyUsingCurrencyRate(this);
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
				_salesPerson.GetMultiManyToManyUsingCurrencyRate(this);
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
				_salesTerritory.GetMultiManyToManyUsingCurrencyRate(this);
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
				_salesTerritory.GetMultiManyToManyUsingCurrencyRate(this);
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
				_shipMethod.GetMultiManyToManyUsingCurrencyRate(this);
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
				_shipMethod.GetMultiManyToManyUsingCurrencyRate(this);
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
		/// Retrieves the related entity of type 'CurrencyEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'CurrencyEntity' which is related to this entity.</returns>
		public virtual CurrencyEntity GetSingleCurrency()
		{
			return GetSingleCurrency(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'CurrencyEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'CurrencyEntity' which is related to this entity.</returns>
		public virtual CurrencyEntity GetSingleCurrency(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCurrency || forceFetch || _alwaysFetchCurrency) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				CurrencyEntity newEntity = new CurrencyEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.FromCurrencyCode);
				this.Currency = newEntity;

				_alreadyFetchedCurrency = true;
			}
			return _currency;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'CurrencyEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'CurrencyEntity' which is related to this entity.</returns>
		public virtual CurrencyEntity GetSingleCurrency_()
		{
			return GetSingleCurrency_(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'CurrencyEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'CurrencyEntity' which is related to this entity.</returns>
		public virtual CurrencyEntity GetSingleCurrency_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCurrency_ || forceFetch || _alwaysFetchCurrency_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				CurrencyEntity newEntity = new CurrencyEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ToCurrencyCode);
				this.Currency_ = newEntity;

				_alreadyFetchedCurrency_ = true;
			}
			return _currency_;
		}
	
	
	
		#region Data binding change event raising methods
	
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
		/// Event thrower for the CurrencyRateDateChanged event, which is thrown when CurrencyRateDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCurrencyRateDateChanged()
		{
			if(CurrencyRateDateChanged!=null)
			{
				CurrencyRateDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the FromCurrencyCodeChanged event, which is thrown when FromCurrencyCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnFromCurrencyCodeChanged()
		{
			if(FromCurrencyCodeChanged!=null)
			{
				FromCurrencyCodeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ToCurrencyCodeChanged event, which is thrown when ToCurrencyCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnToCurrencyCodeChanged()
		{
			if(ToCurrencyCodeChanged!=null)
			{
				ToCurrencyCodeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the AverageRateChanged event, which is thrown when AverageRate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnAverageRateChanged()
		{
			if(AverageRateChanged!=null)
			{
				AverageRateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the EndOfDayRateChanged event, which is thrown when EndOfDayRate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEndOfDayRateChanged()
		{
			if(EndOfDayRateChanged!=null)
			{
				EndOfDayRateChanged(this, new EventArgs());
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
			CurrencyRateDAO dao = DAOFactory.CreateCurrencyRateDAO();
			return dao.AddCurrencyRate(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CurrencyRateDAO dao = DAOFactory.CreateCurrencyRateDAO();
			return dao.UpdateCurrencyRate(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CurrencyRateDAO dao = DAOFactory.CreateCurrencyRateDAO();
			return dao.UpdateCurrencyRate(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.CurrencyRateEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new CurrencyRateValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this CurrencyRateEntity</param>
		private void InitClassFetch(System.Int32 currencyRateID, CurrencyRateValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.CurrencyRateEntity);
			bool wasSuccesful = Fetch(currencyRateID);
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
			_salesOrderHeader.SetContainingEntityInfo(this, "CurrencyRate");
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_address = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_address_ = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress_ = false;
			_alreadyFetchedAddress_ = false;
			_creditCard = new CreditCardCollection(propertyDescriptorFactoryToUse, new CreditCardEntityFactory());
			_alwaysFetchCreditCard = false;
			_alreadyFetchedCreditCard = false;
			_customer = new CustomerCollection(propertyDescriptorFactoryToUse, new CustomerEntityFactory());
			_alwaysFetchCustomer = false;
			_alreadyFetchedCustomer = false;
			_salesPerson = new SalesPersonCollection(propertyDescriptorFactoryToUse, new SalesPersonEntityFactory());
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
			_salesTerritory = new SalesTerritoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritory = false;
			_alreadyFetchedSalesTerritory = false;
			_shipMethod = new ShipMethodCollection(propertyDescriptorFactoryToUse, new ShipMethodEntityFactory());
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_currency = null;
			_alwaysFetchCurrency = false;
			_alreadyFetchedCurrency = false;
			_currency_ = null;
			_alwaysFetchCurrency_ = false;
			_alreadyFetchedCurrency_ = false;

		}


		/// <summary>
		/// Removes the sync logic for member _currency
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCurrency(bool signalRelatedEntity)
		{
			if(_currency != null)
			{
				// disconnect the entity from this entity
				_currency.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_currency.UnsetRelatedEntity(this, "CurrencyRate");
				}
				base.UnsetEntitySyncInformation("Currency", _currency, CurrencyRateEntity.Relations.CurrencyEntityUsingFromCurrencyCode);
				_currency = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _currency
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrency(IEntity relatedEntity)
		{
			DesetupSyncCurrency(true);
			
			if(relatedEntity!=null)
			{
				_currency = (CurrencyEntity)relatedEntity;
				_currency.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Currency", _currency, CurrencyRateEntity.Relations.CurrencyEntityUsingFromCurrencyCode);
				if(!_currency.IsNew)
				{
					// sync now
					base.SyncFKFields(CurrencyRateEntity.Relations.CurrencyEntityUsingFromCurrencyCode, _currency);
				}
			}

			_alreadyFetchedCurrency = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _currency_
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCurrency_(bool signalRelatedEntity)
		{
			if(_currency_ != null)
			{
				// disconnect the entity from this entity
				_currency_.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_currency_.UnsetRelatedEntity(this, "CurrencyRate_");
				}
				base.UnsetEntitySyncInformation("Currency_", _currency_, CurrencyRateEntity.Relations.CurrencyEntityUsingToCurrencyCode);
				_currency_ = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _currency_
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrency_(IEntity relatedEntity)
		{
			DesetupSyncCurrency_(true);
			
			if(relatedEntity!=null)
			{
				_currency_ = (CurrencyEntity)relatedEntity;
				_currency_.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Currency_", _currency_, CurrencyRateEntity.Relations.CurrencyEntityUsingToCurrencyCode);
				if(!_currency_.IsNew)
				{
					// sync now
					base.SyncFKFields(CurrencyRateEntity.Relations.CurrencyEntityUsingToCurrencyCode, _currency_);
				}
			}

			_alreadyFetchedCurrency_ = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="currencyRateID">PK value for CurrencyRate which data should be fetched into this CurrencyRate object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 currencyRateID)
		{
			CurrencyRateDAO dao = DAOFactory.CreateCurrencyRateDAO();

			// Load EntityFields of CurrencyRate
			dao.FetchCurrencyRate(base.Fields, base.Transaction, currencyRateID);

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
		public static CurrencyRateRelations Relations
		{
			get	{ return new CurrencyRateRelations(); }
		}

	
		/// <summary>
		/// The CurrencyRateID property of the Entity CurrencyRate
		/// </summary>
		public virtual System.Int32 CurrencyRateID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CurrencyRateFieldIndex.CurrencyRateID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CurrencyRateID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CurrencyRateFieldIndex.CurrencyRateID, value))
				{
					OnCurrencyRateIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The CurrencyRateDate property of the Entity CurrencyRate
		/// </summary>
		public virtual System.DateTime CurrencyRateDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CurrencyRateFieldIndex.CurrencyRateDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CurrencyRateDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CurrencyRateFieldIndex.CurrencyRateDate, value))
				{
					OnCurrencyRateDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The FromCurrencyCode property of the Entity CurrencyRate
		/// </summary>
		public virtual System.String FromCurrencyCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CurrencyRateFieldIndex.FromCurrencyCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for FromCurrencyCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CurrencyRateFieldIndex.FromCurrencyCode, value))
				{
					OnFromCurrencyCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The ToCurrencyCode property of the Entity CurrencyRate
		/// </summary>
		public virtual System.String ToCurrencyCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CurrencyRateFieldIndex.ToCurrencyCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ToCurrencyCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CurrencyRateFieldIndex.ToCurrencyCode, value))
				{
					OnToCurrencyCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The AverageRate property of the Entity CurrencyRate
		/// </summary>
		public virtual System.Decimal AverageRate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CurrencyRateFieldIndex.AverageRate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AverageRate because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CurrencyRateFieldIndex.AverageRate, value))
				{
					OnAverageRateChanged();
				}
			}
		}
	
		/// <summary>
		/// The EndOfDayRate property of the Entity CurrencyRate
		/// </summary>
		public virtual System.Decimal EndOfDayRate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CurrencyRateFieldIndex.EndOfDayRate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EndOfDayRate because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CurrencyRateFieldIndex.EndOfDayRate, value))
				{
					OnEndOfDayRateChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity CurrencyRate
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CurrencyRateFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CurrencyRateFieldIndex.ModifiedDate, value))
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
		/// Gets / sets related entity of type 'CurrencyEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCurrency()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CurrencyEntity Currency
		{
			get
			{
				return GetSingleCurrency(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCurrency(value);
				}
				else
				{
					if(value==null)
					{
						if(_currency != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_currency.UnsetRelatedEntity(this, "CurrencyRate");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "CurrencyRate");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Currency. When set to true, Currency is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Currency is accessed. You can always execute
		/// a forced fetch by calling GetSingleCurrency(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrency
		{
			get
			{
				return _alwaysFetchCurrency;
			}
			set
			{
				_alwaysFetchCurrency = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'CurrencyEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCurrency_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CurrencyEntity Currency_
		{
			get
			{
				return GetSingleCurrency_(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCurrency_(value);
				}
				else
				{
					if(value==null)
					{
						if(_currency_ != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_currency_.UnsetRelatedEntity(this, "CurrencyRate_");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "CurrencyRate_");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Currency_. When set to true, Currency_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Currency_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleCurrency_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCurrency_
		{
			get
			{
				return _alwaysFetchCurrency_;
			}
			set
			{
				_alwaysFetchCurrency_ = value;
			}	
		}
	
	
		#endregion
	}
}
