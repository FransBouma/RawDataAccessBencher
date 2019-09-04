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
	/// Entity class which represents the entity 'WorkOrder' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class WorkOrderEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private WorkOrderRoutingCollection	_workOrderRouting;
		private bool	_alwaysFetchWorkOrderRouting, _alreadyFetchedWorkOrderRouting;
		private LocationCollection _location;
		private bool	_alwaysFetchLocation, _alreadyFetchedLocation;
		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private ScrapReasonEntity _scrapReason;
		private bool	_alwaysFetchScrapReason, _alreadyFetchedScrapReason;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when WorkOrderID changes value. Databinding related.
		/// </summary>
		public event EventHandler WorkOrderIDChanged;

		/// <summary>
		/// Event which is thrown when ProductID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductIDChanged;

		/// <summary>
		/// Event which is thrown when OrderQty changes value. Databinding related.
		/// </summary>
		public event EventHandler OrderQtyChanged;

		/// <summary>
		/// Event which is thrown when StockedQty changes value. Databinding related.
		/// </summary>
		public event EventHandler StockedQtyChanged;

		/// <summary>
		/// Event which is thrown when ScrappedQty changes value. Databinding related.
		/// </summary>
		public event EventHandler ScrappedQtyChanged;

		/// <summary>
		/// Event which is thrown when StartDate changes value. Databinding related.
		/// </summary>
		public event EventHandler StartDateChanged;

		/// <summary>
		/// Event which is thrown when EndDate changes value. Databinding related.
		/// </summary>
		public event EventHandler EndDateChanged;

		/// <summary>
		/// Event which is thrown when DueDate changes value. Databinding related.
		/// </summary>
		public event EventHandler DueDateChanged;

		/// <summary>
		/// Event which is thrown when ScrapReasonID changes value. Databinding related.
		/// </summary>
		public event EventHandler ScrapReasonIDChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public WorkOrderEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new WorkOrderEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		public WorkOrderEntity(System.Int32 workOrderID)
		{
			InitClassFetch(workOrderID, new WorkOrderValidator(), new PropertyDescriptorFactory(), new WorkOrderEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="validator">The custom validator object for this WorkOrderEntity</param>
		public WorkOrderEntity(System.Int32 workOrderID, WorkOrderValidator validator)
		{
			InitClassFetch(workOrderID, validator, new PropertyDescriptorFactory(), new WorkOrderEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="validator">The custom validator object for this WorkOrderEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public WorkOrderEntity(System.Int32 workOrderID, WorkOrderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(workOrderID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public WorkOrderEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private WorkOrderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_workOrderRouting = (WorkOrderRoutingCollection)info.GetValue("_workOrderRouting", typeof(WorkOrderRoutingCollection));
			_alwaysFetchWorkOrderRouting = info.GetBoolean("_alwaysFetchWorkOrderRouting");
			_alreadyFetchedWorkOrderRouting = info.GetBoolean("_alreadyFetchedWorkOrderRouting");

			_location = (LocationCollection)info.GetValue("_location", typeof(LocationCollection));
			_alwaysFetchLocation = info.GetBoolean("_alwaysFetchLocation");
			_alreadyFetchedLocation = info.GetBoolean("_alreadyFetchedLocation");
			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				// rewire event handler.
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_scrapReason = (ScrapReasonEntity)info.GetValue("_scrapReason", typeof(ScrapReasonEntity));
			if(_scrapReason!=null)
			{
				// rewire event handler.
				_scrapReason.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchScrapReason = info.GetBoolean("_alwaysFetchScrapReason");
			_alreadyFetchedScrapReason = info.GetBoolean("_alreadyFetchedScrapReason");

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
			_alreadyFetchedWorkOrderRouting = (_workOrderRouting.Count > 0);
			_alreadyFetchedLocation = (_location.Count > 0);
			_alreadyFetchedProduct = (_product != null);
			_alreadyFetchedScrapReason = (_scrapReason != null);

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
			info.AddValue("_workOrderRouting", _workOrderRouting);
			info.AddValue("_alwaysFetchWorkOrderRouting", _alwaysFetchWorkOrderRouting);
			info.AddValue("_alreadyFetchedWorkOrderRouting", _alreadyFetchedWorkOrderRouting);
			info.AddValue("_location", _location);
			info.AddValue("_alwaysFetchLocation", _alwaysFetchLocation);
			info.AddValue("_alreadyFetchedLocation", _alreadyFetchedLocation);
			info.AddValue("_product", _product);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_scrapReason", _scrapReason);
			info.AddValue("_alwaysFetchScrapReason", _alwaysFetchScrapReason);
			info.AddValue("_alreadyFetchedScrapReason", _alreadyFetchedScrapReason);

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
				case "Product":
					SetupSyncProduct(relatedEntity);
					break;
				case "ScrapReason":
					SetupSyncScrapReason(relatedEntity);
					break;
				case "WorkOrderRouting":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_workOrderRouting.Add(relatedEntity);
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
				case "Product":
					DesetupSyncProduct(false);
					break;
				case "ScrapReason":
					DesetupSyncScrapReason(false);
					break;
				case "WorkOrderRouting":
					// Remove it from the collection.
					_workOrderRouting.Remove(relatedEntity);
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
			if(_product!=null)
			{
				toReturn.Add(_product);
			}
			if(_scrapReason!=null)
			{
				toReturn.Add(_scrapReason);
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

			toReturn.Add(_workOrderRouting);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("WorkOrderEntity");
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
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 workOrderID)
		{
			return Fetch(workOrderID);
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
			return Fetch(this.WorkOrderID);
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
			WorkOrderDAO dao = DAOFactory.CreateWorkOrderDAO();
			bool wasSuccesful = dao.DeleteWorkOrder(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(WorkOrderFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderRoutingEntity'</returns>
		public virtual WorkOrderRoutingCollection GetMultiWorkOrderRouting(bool forceFetch)
		{
 			if( ( !_alreadyFetchedWorkOrderRouting || forceFetch || _alwaysFetchWorkOrderRouting) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderRouting.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderRouting);
					}
				}
				_workOrderRouting.SuppressClearInGetMulti=!forceFetch;
				_workOrderRouting.GetMultiManyToOne(null, this);
				_workOrderRouting.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderRouting = true;
			}
			return _workOrderRouting;
		}


		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderRoutingEntity'</returns>
		public virtual WorkOrderRoutingCollection GetMultiWorkOrderRouting(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrderRouting || forceFetch || _alwaysFetchWorkOrderRouting) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderRouting.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderRouting);
					}
				}
				_workOrderRouting.SuppressClearInGetMulti=!forceFetch;
				_workOrderRouting.GetMultiManyToOne(null, this, filter);
				_workOrderRouting.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderRouting = true;
			}
			return _workOrderRouting;
		}


		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual WorkOrderRoutingCollection GetMultiWorkOrderRouting(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrderRouting || forceFetch || _alwaysFetchWorkOrderRouting) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderRouting.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderRouting);
					}
				}
				_workOrderRouting.SuppressClearInGetMulti=!forceFetch;
				_workOrderRouting.EntityFactoryToUse = entityFactoryToUse;
				_workOrderRouting.GetMultiManyToOne(null, this);
				_workOrderRouting.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderRouting = true;
			}
			return _workOrderRouting;
		}


		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual WorkOrderRoutingCollection GetMultiWorkOrderRouting(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrderRouting || forceFetch || _alwaysFetchWorkOrderRouting) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrderRouting.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrderRouting);
					}
				}
				_workOrderRouting.SuppressClearInGetMulti=!forceFetch;
				_workOrderRouting.EntityFactoryToUse = entityFactoryToUse;
				_workOrderRouting.GetMultiManyToOne(null, this, filter);
				_workOrderRouting.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrderRouting = true;
			}
			return _workOrderRouting;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'WorkOrderRouting'. These settings will be taken into account
		/// when the property WorkOrderRouting is requested or GetMultiWorkOrderRouting is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrderRouting(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrderRouting.SortClauses=sortClauses;
			_workOrderRouting.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LocationEntity'</returns>
		public virtual LocationCollection GetMultiLocation(bool forceFetch)
		{
 			if( ( !_alreadyFetchedLocation || forceFetch || _alwaysFetchLocation) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_location.ParticipatesInTransaction)
					{
						base.Transaction.Add(_location);
					}
				}
				_location.SuppressClearInGetMulti=!forceFetch;
				_location.GetMultiManyToManyUsingWorkOrder(this);
				_location.SuppressClearInGetMulti=false;
				_alreadyFetchedLocation = true;
			}
			return _location;
		}


		/// <summary>
		/// Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual LocationCollection GetMultiLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedLocation || forceFetch || _alwaysFetchLocation) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_location.ParticipatesInTransaction)
					{
						base.Transaction.Add(_location);
					}
				}
				_location.SuppressClearInGetMulti=!forceFetch;
				_location.EntityFactoryToUse = entityFactoryToUse;
				_location.GetMultiManyToManyUsingWorkOrder(this);
				_location.SuppressClearInGetMulti=false;
				_alreadyFetchedLocation = true;
			}
			return _location;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Location'. These settings will be taken into account
		/// when the property Location is requested or GetMultiLocation is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_location.SortClauses=sortClauses;
			_location.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
		/// <summary>
		/// Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProduct()
		{
			return GetSingleProduct(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProduct(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ProductEntity newEntity = new ProductEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ProductID);
				this.Product = newEntity;

				_alreadyFetchedProduct = true;
			}
			return _product;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'ScrapReasonEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ScrapReasonEntity' which is related to this entity.</returns>
		public virtual ScrapReasonEntity GetSingleScrapReason()
		{
			return GetSingleScrapReason(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ScrapReasonEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ScrapReasonEntity' which is related to this entity.</returns>
		public virtual ScrapReasonEntity GetSingleScrapReason(bool forceFetch)
		{
 			if( ( !_alreadyFetchedScrapReason || forceFetch || _alwaysFetchScrapReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ScrapReasonEntity newEntity = new ScrapReasonEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ScrapReasonID);
				this.ScrapReason = newEntity;

				_alreadyFetchedScrapReason = true;
			}
			return _scrapReason;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the WorkOrderIDChanged event, which is thrown when WorkOrderID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnWorkOrderIDChanged()
		{
			if(WorkOrderIDChanged!=null)
			{
				WorkOrderIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ProductIDChanged event, which is thrown when ProductID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductIDChanged()
		{
			if(ProductIDChanged!=null)
			{
				ProductIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the OrderQtyChanged event, which is thrown when OrderQty changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnOrderQtyChanged()
		{
			if(OrderQtyChanged!=null)
			{
				OrderQtyChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the StockedQtyChanged event, which is thrown when StockedQty changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnStockedQtyChanged()
		{
			if(StockedQtyChanged!=null)
			{
				StockedQtyChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ScrappedQtyChanged event, which is thrown when ScrappedQty changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnScrappedQtyChanged()
		{
			if(ScrappedQtyChanged!=null)
			{
				ScrappedQtyChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the StartDateChanged event, which is thrown when StartDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnStartDateChanged()
		{
			if(StartDateChanged!=null)
			{
				StartDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the EndDateChanged event, which is thrown when EndDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEndDateChanged()
		{
			if(EndDateChanged!=null)
			{
				EndDateChanged(this, new EventArgs());
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
		/// Event thrower for the ScrapReasonIDChanged event, which is thrown when ScrapReasonID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnScrapReasonIDChanged()
		{
			if(ScrapReasonIDChanged!=null)
			{
				ScrapReasonIDChanged(this, new EventArgs());
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
			WorkOrderDAO dao = DAOFactory.CreateWorkOrderDAO();
			return dao.AddWorkOrder(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			WorkOrderDAO dao = DAOFactory.CreateWorkOrderDAO();
			return dao.UpdateWorkOrder(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			WorkOrderDAO dao = DAOFactory.CreateWorkOrderDAO();
			return dao.UpdateWorkOrder(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.WorkOrderEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new WorkOrderValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this WorkOrderEntity</param>
		private void InitClassFetch(System.Int32 workOrderID, WorkOrderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.WorkOrderEntity);
			bool wasSuccesful = Fetch(workOrderID);
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
			_workOrderRouting = new WorkOrderRoutingCollection(propertyDescriptorFactoryToUse, new WorkOrderRoutingEntityFactory());
			_workOrderRouting.SetContainingEntityInfo(this, "WorkOrder");
			_alwaysFetchWorkOrderRouting = false;
			_alreadyFetchedWorkOrderRouting = false;
			_location = new LocationCollection(propertyDescriptorFactoryToUse, new LocationEntityFactory());
			_alwaysFetchLocation = false;
			_alreadyFetchedLocation = false;
			_product = null;
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_scrapReason = null;
			_alwaysFetchScrapReason = false;
			_alreadyFetchedScrapReason = false;

		}


		/// <summary>
		/// Removes the sync logic for member _product
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncProduct(bool signalRelatedEntity)
		{
			if(_product != null)
			{
				// disconnect the entity from this entity
				_product.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_product.UnsetRelatedEntity(this, "WorkOrder");
				}
				base.UnsetEntitySyncInformation("Product", _product, WorkOrderEntity.Relations.ProductEntityUsingProductID);
				_product = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _product
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct(IEntity relatedEntity)
		{
			DesetupSyncProduct(true);
			
			if(relatedEntity!=null)
			{
				_product = (ProductEntity)relatedEntity;
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Product", _product, WorkOrderEntity.Relations.ProductEntityUsingProductID);
				if(!_product.IsNew)
				{
					// sync now
					base.SyncFKFields(WorkOrderEntity.Relations.ProductEntityUsingProductID, _product);
				}
			}

			_alreadyFetchedProduct = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _scrapReason
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncScrapReason(bool signalRelatedEntity)
		{
			if(_scrapReason != null)
			{
				// disconnect the entity from this entity
				_scrapReason.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_scrapReason.UnsetRelatedEntity(this, "WorkOrder");
				}
				base.UnsetEntitySyncInformation("ScrapReason", _scrapReason, WorkOrderEntity.Relations.ScrapReasonEntityUsingScrapReasonID);
				_scrapReason = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _scrapReason
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncScrapReason(IEntity relatedEntity)
		{
			DesetupSyncScrapReason(true);
			
			if(relatedEntity!=null)
			{
				_scrapReason = (ScrapReasonEntity)relatedEntity;
				_scrapReason.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("ScrapReason", _scrapReason, WorkOrderEntity.Relations.ScrapReasonEntityUsingScrapReasonID);
				if(!_scrapReason.IsNew)
				{
					// sync now
					base.SyncFKFields(WorkOrderEntity.Relations.ScrapReasonEntityUsingScrapReasonID, _scrapReason);
				}
			}

			_alreadyFetchedScrapReason = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="workOrderID">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 workOrderID)
		{
			WorkOrderDAO dao = DAOFactory.CreateWorkOrderDAO();

			// Load EntityFields of WorkOrder
			dao.FetchWorkOrder(base.Fields, base.Transaction, workOrderID);

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
		public static WorkOrderRelations Relations
		{
			get	{ return new WorkOrderRelations(); }
		}

	
		/// <summary>
		/// The WorkOrderID property of the Entity WorkOrder
		/// </summary>
		public virtual System.Int32 WorkOrderID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.WorkOrderID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for WorkOrderID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.WorkOrderID, value))
				{
					OnWorkOrderIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductID property of the Entity WorkOrder
		/// </summary>
		public virtual System.Int32 ProductID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.ProductID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.ProductID, value))
				{
					OnProductIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The OrderQty property of the Entity WorkOrder
		/// </summary>
		public virtual System.Int32 OrderQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.OrderQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for OrderQty because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.OrderQty, value))
				{
					OnOrderQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The StockedQty property of the Entity WorkOrder
		/// </summary>
		public virtual System.Int32 StockedQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.StockedQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for StockedQty because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.StockedQty, value))
				{
					OnStockedQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The ScrappedQty property of the Entity WorkOrder
		/// </summary>
		public virtual System.Int16 ScrappedQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.ScrappedQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ScrappedQty because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.ScrappedQty, value))
				{
					OnScrappedQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The StartDate property of the Entity WorkOrder
		/// </summary>
		public virtual System.DateTime StartDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.StartDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for StartDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.StartDate, value))
				{
					OnStartDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The EndDate property of the Entity WorkOrder
		/// </summary>
		public virtual System.DateTime EndDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.EndDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EndDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.EndDate, value))
				{
					OnEndDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The DueDate property of the Entity WorkOrder
		/// </summary>
		public virtual System.DateTime DueDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.DueDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DueDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.DueDate, value))
				{
					OnDueDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The ScrapReasonID property of the Entity WorkOrder
		/// </summary>
		public virtual System.Int16 ScrapReasonID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.ScrapReasonID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ScrapReasonID because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.ScrapReasonID, value))
				{
					OnScrapReasonIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity WorkOrder
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)WorkOrderFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)WorkOrderFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderRoutingEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrderRouting()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual WorkOrderRoutingCollection WorkOrderRouting
		{
			get
			{
				return GetMultiWorkOrderRouting(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for WorkOrderRouting. When set to true, WorkOrderRouting is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrderRouting is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrderRouting(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrderRouting
		{
			get
			{
				return _alwaysFetchWorkOrderRouting;
			}
			set
			{
				_alwaysFetchWorkOrderRouting = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual LocationCollection Location
		{
			get
			{
				return GetMultiLocation(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Location. When set to true, Location is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Location is accessed. You can always execute
		/// a forced fetch by calling GetMultiLocation(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchLocation
		{
			get
			{
				return _alwaysFetchLocation;
			}
			set
			{
				_alwaysFetchLocation = value;
			}	
		}
	
	
		/// <summary>
		/// Gets / sets related entity of type 'ProductEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get
			{
				return GetSingleProduct(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProduct(value);
				}
				else
				{
					if(value==null)
					{
						if(_product != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_product.UnsetRelatedEntity(this, "WorkOrder");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "WorkOrder");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Product. When set to true, Product is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product is accessed. You can always execute
		/// a forced fetch by calling GetSingleProduct(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct
		{
			get
			{
				return _alwaysFetchProduct;
			}
			set
			{
				_alwaysFetchProduct = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'ScrapReasonEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleScrapReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ScrapReasonEntity ScrapReason
		{
			get
			{
				return GetSingleScrapReason(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncScrapReason(value);
				}
				else
				{
					if(value==null)
					{
						if(_scrapReason != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_scrapReason.UnsetRelatedEntity(this, "WorkOrder");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "WorkOrder");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ScrapReason. When set to true, ScrapReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ScrapReason is accessed. You can always execute
		/// a forced fetch by calling GetSingleScrapReason(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchScrapReason
		{
			get
			{
				return _alwaysFetchScrapReason;
			}
			set
			{
				_alwaysFetchScrapReason = value;
			}	
		}
	
	
		#endregion
	}
}
