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
	/// Entity class which represents the entity 'CountryRegion' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class CountryRegionEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private StateProvinceCollection	_stateProvince;
		private bool	_alwaysFetchStateProvince, _alreadyFetchedStateProvince;
		private CountryRegionCurrencyCollection	_countryRegionCurrency;
		private bool	_alwaysFetchCountryRegionCurrency, _alreadyFetchedCountryRegionCurrency;
		private SalesTerritoryCollection _salesTerritory;
		private bool	_alwaysFetchSalesTerritory, _alreadyFetchedSalesTerritory;
		private CurrencyCollection _currency;
		private bool	_alwaysFetchCurrency, _alreadyFetchedCurrency;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when CountryRegionCode changes value. Databinding related.
		/// </summary>
		public event EventHandler CountryRegionCodeChanged;

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
		public CountryRegionEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new CountryRegionEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		public CountryRegionEntity(System.String countryRegionCode)
		{
			InitClassFetch(countryRegionCode, new CountryRegionValidator(), new PropertyDescriptorFactory(), new CountryRegionEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		public CountryRegionEntity(System.String countryRegionCode, CountryRegionValidator validator)
		{
			InitClassFetch(countryRegionCode, validator, new PropertyDescriptorFactory(), new CountryRegionEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="validator">The custom validator object for this CountryRegionEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CountryRegionEntity(System.String countryRegionCode, CountryRegionValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(countryRegionCode, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public CountryRegionEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private CountryRegionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_stateProvince = (StateProvinceCollection)info.GetValue("_stateProvince", typeof(StateProvinceCollection));
			_alwaysFetchStateProvince = info.GetBoolean("_alwaysFetchStateProvince");
			_alreadyFetchedStateProvince = info.GetBoolean("_alreadyFetchedStateProvince");

			_countryRegionCurrency = (CountryRegionCurrencyCollection)info.GetValue("_countryRegionCurrency", typeof(CountryRegionCurrencyCollection));
			_alwaysFetchCountryRegionCurrency = info.GetBoolean("_alwaysFetchCountryRegionCurrency");
			_alreadyFetchedCountryRegionCurrency = info.GetBoolean("_alreadyFetchedCountryRegionCurrency");

			_salesTerritory = (SalesTerritoryCollection)info.GetValue("_salesTerritory", typeof(SalesTerritoryCollection));
			_alwaysFetchSalesTerritory = info.GetBoolean("_alwaysFetchSalesTerritory");
			_alreadyFetchedSalesTerritory = info.GetBoolean("_alreadyFetchedSalesTerritory");

			_currency = (CurrencyCollection)info.GetValue("_currency", typeof(CurrencyCollection));
			_alwaysFetchCurrency = info.GetBoolean("_alwaysFetchCurrency");
			_alreadyFetchedCurrency = info.GetBoolean("_alreadyFetchedCurrency");


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
			_alreadyFetchedCountryRegionCurrency = (_countryRegionCurrency.Count > 0);
			_alreadyFetchedSalesTerritory = (_salesTerritory.Count > 0);
			_alreadyFetchedCurrency = (_currency.Count > 0);


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
			info.AddValue("_countryRegionCurrency", _countryRegionCurrency);
			info.AddValue("_alwaysFetchCountryRegionCurrency", _alwaysFetchCountryRegionCurrency);
			info.AddValue("_alreadyFetchedCountryRegionCurrency", _alreadyFetchedCountryRegionCurrency);
			info.AddValue("_salesTerritory", _salesTerritory);
			info.AddValue("_alwaysFetchSalesTerritory", _alwaysFetchSalesTerritory);
			info.AddValue("_alreadyFetchedSalesTerritory", _alreadyFetchedSalesTerritory);
			info.AddValue("_currency", _currency);
			info.AddValue("_alwaysFetchCurrency", _alwaysFetchCurrency);
			info.AddValue("_alreadyFetchedCurrency", _alreadyFetchedCurrency);


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
				case "CountryRegionCurrency":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_countryRegionCurrency.Add(relatedEntity);
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
				case "CountryRegionCurrency":
					// Remove it from the collection.
					_countryRegionCurrency.Remove(relatedEntity);
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
			toReturn.Add(_countryRegionCurrency);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("CountryRegionEntity");
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
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String countryRegionCode)
		{
			return Fetch(countryRegionCode);
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
			return Fetch(this.CountryRegionCode);
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
			CountryRegionDAO dao = DAOFactory.CreateCountryRegionDAO();
			bool wasSuccesful = dao.DeleteCountryRegion(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(CountryRegionFieldIndex fieldIndex)
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
				_stateProvince.GetMultiManyToOne(this, null);
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
				_stateProvince.GetMultiManyToOne(this, null, filter);
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
				_stateProvince.GetMultiManyToOne(this, null);
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
				_stateProvince.GetMultiManyToOne(this, null, filter);
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
		/// Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionCurrencyEntity'</returns>
		public virtual CountryRegionCurrencyCollection GetMultiCountryRegionCurrency(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCountryRegionCurrency || forceFetch || _alwaysFetchCountryRegionCurrency) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegionCurrency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegionCurrency);
					}
				}
				_countryRegionCurrency.SuppressClearInGetMulti=!forceFetch;
				_countryRegionCurrency.GetMultiManyToOne(this, null);
				_countryRegionCurrency.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegionCurrency = true;
			}
			return _countryRegionCurrency;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'CountryRegionCurrencyEntity'</returns>
		public virtual CountryRegionCurrencyCollection GetMultiCountryRegionCurrency(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCountryRegionCurrency || forceFetch || _alwaysFetchCountryRegionCurrency) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegionCurrency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegionCurrency);
					}
				}
				_countryRegionCurrency.SuppressClearInGetMulti=!forceFetch;
				_countryRegionCurrency.GetMultiManyToOne(this, null, filter);
				_countryRegionCurrency.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegionCurrency = true;
			}
			return _countryRegionCurrency;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CountryRegionCurrencyCollection GetMultiCountryRegionCurrency(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCountryRegionCurrency || forceFetch || _alwaysFetchCountryRegionCurrency) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegionCurrency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegionCurrency);
					}
				}
				_countryRegionCurrency.SuppressClearInGetMulti=!forceFetch;
				_countryRegionCurrency.EntityFactoryToUse = entityFactoryToUse;
				_countryRegionCurrency.GetMultiManyToOne(this, null);
				_countryRegionCurrency.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegionCurrency = true;
			}
			return _countryRegionCurrency;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CountryRegionCurrencyCollection GetMultiCountryRegionCurrency(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedCountryRegionCurrency || forceFetch || _alwaysFetchCountryRegionCurrency) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_countryRegionCurrency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_countryRegionCurrency);
					}
				}
				_countryRegionCurrency.SuppressClearInGetMulti=!forceFetch;
				_countryRegionCurrency.EntityFactoryToUse = entityFactoryToUse;
				_countryRegionCurrency.GetMultiManyToOne(this, null, filter);
				_countryRegionCurrency.SuppressClearInGetMulti=false;
				_alreadyFetchedCountryRegionCurrency = true;
			}
			return _countryRegionCurrency;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'CountryRegionCurrency'. These settings will be taken into account
		/// when the property CountryRegionCurrency is requested or GetMultiCountryRegionCurrency is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCountryRegionCurrency(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_countryRegionCurrency.SortClauses=sortClauses;
			_countryRegionCurrency.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_salesTerritory.GetMultiManyToManyUsingCountryRegion(this);
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
				_salesTerritory.GetMultiManyToManyUsingCountryRegion(this);
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
		/// Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CurrencyEntity'</returns>
		public virtual CurrencyCollection GetMultiCurrency(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCurrency || forceFetch || _alwaysFetchCurrency) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_currency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currency);
					}
				}
				_currency.SuppressClearInGetMulti=!forceFetch;
				_currency.GetMultiManyToManyUsingCountryRegion(this);
				_currency.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrency = true;
			}
			return _currency;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CurrencyCollection GetMultiCurrency(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCurrency || forceFetch || _alwaysFetchCurrency) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_currency.ParticipatesInTransaction)
					{
						base.Transaction.Add(_currency);
					}
				}
				_currency.SuppressClearInGetMulti=!forceFetch;
				_currency.EntityFactoryToUse = entityFactoryToUse;
				_currency.GetMultiManyToManyUsingCountryRegion(this);
				_currency.SuppressClearInGetMulti=false;
				_alreadyFetchedCurrency = true;
			}
			return _currency;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Currency'. These settings will be taken into account
		/// when the property Currency is requested or GetMultiCurrency is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCurrency(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_currency.SortClauses=sortClauses;
			_currency.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
	
	
		#region Data binding change event raising methods
	
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
			CountryRegionDAO dao = DAOFactory.CreateCountryRegionDAO();
			return dao.AddCountryRegion(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			CountryRegionDAO dao = DAOFactory.CreateCountryRegionDAO();
			return dao.UpdateCountryRegion(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			CountryRegionDAO dao = DAOFactory.CreateCountryRegionDAO();
			return dao.UpdateCountryRegion(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.CountryRegionEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new CountryRegionValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this CountryRegionEntity</param>
		private void InitClassFetch(System.String countryRegionCode, CountryRegionValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.CountryRegionEntity);
			bool wasSuccesful = Fetch(countryRegionCode);
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
			_stateProvince.SetContainingEntityInfo(this, "CountryRegion");
			_alwaysFetchStateProvince = false;
			_alreadyFetchedStateProvince = false;
			_countryRegionCurrency = new CountryRegionCurrencyCollection(propertyDescriptorFactoryToUse, new CountryRegionCurrencyEntityFactory());
			_countryRegionCurrency.SetContainingEntityInfo(this, "CountryRegion");
			_alwaysFetchCountryRegionCurrency = false;
			_alreadyFetchedCountryRegionCurrency = false;
			_salesTerritory = new SalesTerritoryCollection(propertyDescriptorFactoryToUse, new SalesTerritoryEntityFactory());
			_alwaysFetchSalesTerritory = false;
			_alreadyFetchedSalesTerritory = false;
			_currency = new CurrencyCollection(propertyDescriptorFactoryToUse, new CurrencyEntityFactory());
			_alwaysFetchCurrency = false;
			_alreadyFetchedCurrency = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="countryRegionCode">PK value for CountryRegion which data should be fetched into this CountryRegion object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String countryRegionCode)
		{
			CountryRegionDAO dao = DAOFactory.CreateCountryRegionDAO();

			// Load EntityFields of CountryRegion
			dao.FetchCountryRegion(base.Fields, base.Transaction, countryRegionCode);

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
		public static CountryRegionRelations Relations
		{
			get	{ return new CountryRegionRelations(); }
		}

	
		/// <summary>
		/// The CountryRegionCode property of the Entity CountryRegion
		/// </summary>
		public virtual System.String CountryRegionCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CountryRegionFieldIndex.CountryRegionCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CountryRegionCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CountryRegionFieldIndex.CountryRegionCode, value))
				{
					OnCountryRegionCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity CountryRegion
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CountryRegionFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CountryRegionFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity CountryRegion
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)CountryRegionFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)CountryRegionFieldIndex.ModifiedDate, value))
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
		/// Retrieves all related entities of type 'CountryRegionCurrencyEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCountryRegionCurrency()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CountryRegionCurrencyCollection CountryRegionCurrency
		{
			get
			{
				return GetMultiCountryRegionCurrency(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CountryRegionCurrency. When set to true, CountryRegionCurrency is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CountryRegionCurrency is accessed. You can always execute
		/// a forced fetch by calling GetMultiCountryRegionCurrency(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCountryRegionCurrency
		{
			get
			{
				return _alwaysFetchCountryRegionCurrency;
			}
			set
			{
				_alwaysFetchCountryRegionCurrency = value;
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
		/// Retrieves all related entities of type 'CurrencyEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCurrency()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CurrencyCollection Currency
		{
			get
			{
				return GetMultiCurrency(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Currency. When set to true, Currency is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Currency is accessed. You can always execute
		/// a forced fetch by calling GetMultiCurrency(true).
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
	
	
	
		#endregion
	}
}
