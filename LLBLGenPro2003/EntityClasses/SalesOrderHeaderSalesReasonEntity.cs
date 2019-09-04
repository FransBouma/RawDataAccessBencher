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
	/// Entity class which represents the entity 'SalesOrderHeaderSalesReason' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class SalesOrderHeaderSalesReasonEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations


		private SalesOrderHeaderEntity _salesOrderHeader;
		private bool	_alwaysFetchSalesOrderHeader, _alreadyFetchedSalesOrderHeader;
		private SalesReasonEntity _salesReason;
		private bool	_alwaysFetchSalesReason, _alreadyFetchedSalesReason;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when SalesOrderID changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesOrderIDChanged;

		/// <summary>
		/// Event which is thrown when SalesReasonID changes value. Databinding related.
		/// </summary>
		public event EventHandler SalesReasonIDChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public SalesOrderHeaderSalesReasonEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new SalesOrderHeaderSalesReasonEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		public SalesOrderHeaderSalesReasonEntity(System.Int32 salesOrderID, System.Int32 salesReasonID)
		{
			InitClassFetch(salesOrderID, salesReasonID, new SalesOrderHeaderSalesReasonValidator(), new PropertyDescriptorFactory(), new SalesOrderHeaderSalesReasonEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderSalesReasonEntity</param>
		public SalesOrderHeaderSalesReasonEntity(System.Int32 salesOrderID, System.Int32 salesReasonID, SalesOrderHeaderSalesReasonValidator validator)
		{
			InitClassFetch(salesOrderID, salesReasonID, validator, new PropertyDescriptorFactory(), new SalesOrderHeaderSalesReasonEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderSalesReasonEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesOrderHeaderSalesReasonEntity(System.Int32 salesOrderID, System.Int32 salesReasonID, SalesOrderHeaderSalesReasonValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(salesOrderID, salesReasonID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SalesOrderHeaderSalesReasonEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private SalesOrderHeaderSalesReasonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_salesOrderHeader = (SalesOrderHeaderEntity)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderEntity));
			if(_salesOrderHeader!=null)
			{
				// rewire event handler.
				_salesOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchSalesOrderHeader = info.GetBoolean("_alwaysFetchSalesOrderHeader");
			_alreadyFetchedSalesOrderHeader = info.GetBoolean("_alreadyFetchedSalesOrderHeader");
			_salesReason = (SalesReasonEntity)info.GetValue("_salesReason", typeof(SalesReasonEntity));
			if(_salesReason!=null)
			{
				// rewire event handler.
				_salesReason.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchSalesReason = info.GetBoolean("_alwaysFetchSalesReason");
			_alreadyFetchedSalesReason = info.GetBoolean("_alreadyFetchedSalesReason");

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


			_alreadyFetchedSalesOrderHeader = (_salesOrderHeader != null);
			_alreadyFetchedSalesReason = (_salesReason != null);

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
			info.AddValue("_salesReason", _salesReason);
			info.AddValue("_alwaysFetchSalesReason", _alwaysFetchSalesReason);
			info.AddValue("_alreadyFetchedSalesReason", _alreadyFetchedSalesReason);

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
				case "SalesOrderHeader":
					SetupSyncSalesOrderHeader(relatedEntity);
					break;
				case "SalesReason":
					SetupSyncSalesReason(relatedEntity);
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
				case "SalesOrderHeader":
					DesetupSyncSalesOrderHeader(false);
					break;
				case "SalesReason":
					DesetupSyncSalesReason(false);
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
			if(_salesOrderHeader!=null)
			{
				toReturn.Add(_salesOrderHeader);
			}
			if(_salesReason!=null)
			{
				toReturn.Add(_salesReason);
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


		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("SalesOrderHeaderSalesReasonEntity");
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
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 salesOrderID, System.Int32 salesReasonID)
		{
			return Fetch(salesOrderID, salesReasonID);
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
			return Fetch(this.SalesOrderID, this.SalesReasonID);
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
			SalesOrderHeaderSalesReasonDAO dao = DAOFactory.CreateSalesOrderHeaderSalesReasonDAO();
			bool wasSuccesful = dao.DeleteSalesOrderHeaderSalesReason(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(SalesOrderHeaderSalesReasonFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
	
	
		/// <summary>
		/// Retrieves the related entity of type 'SalesOrderHeaderEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'SalesOrderHeaderEntity' which is related to this entity.</returns>
		public virtual SalesOrderHeaderEntity GetSingleSalesOrderHeader()
		{
			return GetSingleSalesOrderHeader(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'SalesOrderHeaderEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesOrderHeaderEntity' which is related to this entity.</returns>
		public virtual SalesOrderHeaderEntity GetSingleSalesOrderHeader(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesOrderHeader || forceFetch || _alwaysFetchSalesOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				SalesOrderHeaderEntity newEntity = new SalesOrderHeaderEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.SalesOrderID);
				this.SalesOrderHeader = newEntity;

				_alreadyFetchedSalesOrderHeader = true;
			}
			return _salesOrderHeader;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'SalesReasonEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'SalesReasonEntity' which is related to this entity.</returns>
		public virtual SalesReasonEntity GetSingleSalesReason()
		{
			return GetSingleSalesReason(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'SalesReasonEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'SalesReasonEntity' which is related to this entity.</returns>
		public virtual SalesReasonEntity GetSingleSalesReason(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSalesReason || forceFetch || _alwaysFetchSalesReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				SalesReasonEntity newEntity = new SalesReasonEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.SalesReasonID);
				this.SalesReason = newEntity;

				_alreadyFetchedSalesReason = true;
			}
			return _salesReason;
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
		/// Event thrower for the SalesReasonIDChanged event, which is thrown when SalesReasonID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSalesReasonIDChanged()
		{
			if(SalesReasonIDChanged!=null)
			{
				SalesReasonIDChanged(this, new EventArgs());
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
			SalesOrderHeaderSalesReasonDAO dao = DAOFactory.CreateSalesOrderHeaderSalesReasonDAO();
			return dao.AddSalesOrderHeaderSalesReason(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SalesOrderHeaderSalesReasonDAO dao = DAOFactory.CreateSalesOrderHeaderSalesReasonDAO();
			return dao.UpdateSalesOrderHeaderSalesReason(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SalesOrderHeaderSalesReasonDAO dao = DAOFactory.CreateSalesOrderHeaderSalesReasonDAO();
			return dao.UpdateSalesOrderHeaderSalesReason(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SalesOrderHeaderSalesReasonEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new SalesOrderHeaderSalesReasonValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this SalesOrderHeaderSalesReasonEntity</param>
		private void InitClassFetch(System.Int32 salesOrderID, System.Int32 salesReasonID, SalesOrderHeaderSalesReasonValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SalesOrderHeaderSalesReasonEntity);
			bool wasSuccesful = Fetch(salesOrderID, salesReasonID);
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


			_salesOrderHeader = null;
			_alwaysFetchSalesOrderHeader = false;
			_alreadyFetchedSalesOrderHeader = false;
			_salesReason = null;
			_alwaysFetchSalesReason = false;
			_alreadyFetchedSalesReason = false;

		}


		/// <summary>
		/// Removes the sync logic for member _salesOrderHeader
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncSalesOrderHeader(bool signalRelatedEntity)
		{
			if(_salesOrderHeader != null)
			{
				// disconnect the entity from this entity
				_salesOrderHeader.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_salesOrderHeader.UnsetRelatedEntity(this, "SalesOrderHeaderSalesReason");
				}
				base.UnsetEntitySyncInformation("SalesOrderHeader", _salesOrderHeader, SalesOrderHeaderSalesReasonEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID);
				_salesOrderHeader = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _salesOrderHeader
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesOrderHeader(IEntity relatedEntity)
		{
			DesetupSyncSalesOrderHeader(true);
			
			if(relatedEntity!=null)
			{
				_salesOrderHeader = (SalesOrderHeaderEntity)relatedEntity;
				_salesOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("SalesOrderHeader", _salesOrderHeader, SalesOrderHeaderSalesReasonEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID);
				if(!_salesOrderHeader.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderSalesReasonEntity.Relations.SalesOrderHeaderEntityUsingSalesOrderID, _salesOrderHeader);
				}
			}

			_alreadyFetchedSalesOrderHeader = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _salesReason
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncSalesReason(bool signalRelatedEntity)
		{
			if(_salesReason != null)
			{
				// disconnect the entity from this entity
				_salesReason.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_salesReason.UnsetRelatedEntity(this, "SalesOrderHeaderSalesReason");
				}
				base.UnsetEntitySyncInformation("SalesReason", _salesReason, SalesOrderHeaderSalesReasonEntity.Relations.SalesReasonEntityUsingSalesReasonID);
				_salesReason = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _salesReason
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesReason(IEntity relatedEntity)
		{
			DesetupSyncSalesReason(true);
			
			if(relatedEntity!=null)
			{
				_salesReason = (SalesReasonEntity)relatedEntity;
				_salesReason.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("SalesReason", _salesReason, SalesOrderHeaderSalesReasonEntity.Relations.SalesReasonEntityUsingSalesReasonID);
				if(!_salesReason.IsNew)
				{
					// sync now
					base.SyncFKFields(SalesOrderHeaderSalesReasonEntity.Relations.SalesReasonEntityUsingSalesReasonID, _salesReason);
				}
			}

			_alreadyFetchedSalesReason = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="salesOrderID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <param name="salesReasonID">PK value for SalesOrderHeaderSalesReason which data should be fetched into this SalesOrderHeaderSalesReason object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 salesOrderID, System.Int32 salesReasonID)
		{
			SalesOrderHeaderSalesReasonDAO dao = DAOFactory.CreateSalesOrderHeaderSalesReasonDAO();

			// Load EntityFields of SalesOrderHeaderSalesReason
			dao.FetchSalesOrderHeaderSalesReason(base.Fields, base.Transaction, salesOrderID, salesReasonID);

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
		public static SalesOrderHeaderSalesReasonRelations Relations
		{
			get	{ return new SalesOrderHeaderSalesReasonRelations(); }
		}

	
		/// <summary>
		/// The SalesOrderID property of the Entity SalesOrderHeaderSalesReason
		/// </summary>
		public virtual System.Int32 SalesOrderID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesOrderID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID, value))
				{
					OnSalesOrderIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalesReasonID property of the Entity SalesOrderHeaderSalesReason
		/// </summary>
		public virtual System.Int32 SalesReasonID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalesReasonID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID, value))
				{
					OnSalesReasonIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity SalesOrderHeaderSalesReason
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
	
	
		/// <summary>
		/// Gets / sets related entity of type 'SalesOrderHeaderEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesOrderHeaderEntity SalesOrderHeader
		{
			get
			{
				return GetSingleSalesOrderHeader(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesOrderHeader(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesOrderHeader != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_salesOrderHeader.UnsetRelatedEntity(this, "SalesOrderHeaderSalesReason");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeaderSalesReason");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesOrderHeader. When set to true, SalesOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesOrderHeader(true).
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
		/// Gets / sets related entity of type 'SalesReasonEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleSalesReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual SalesReasonEntity SalesReason
		{
			get
			{
				return GetSingleSalesReason(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncSalesReason(value);
				}
				else
				{
					if(value==null)
					{
						if(_salesReason != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_salesReason.UnsetRelatedEntity(this, "SalesOrderHeaderSalesReason");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "SalesOrderHeaderSalesReason");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SalesReason. When set to true, SalesReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SalesReason is accessed. You can always execute
		/// a forced fetch by calling GetSingleSalesReason(true).
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
	
	
		#endregion
	}
}
