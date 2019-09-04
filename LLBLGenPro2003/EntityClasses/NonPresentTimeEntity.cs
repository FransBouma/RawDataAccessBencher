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
	/// Entity class which represents the entity 'NonPresentTime' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class NonPresentTimeEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations


		private ReasonEntity _reason;
		private bool	_alwaysFetchReason, _alreadyFetchedReason;
		private NonPresentTimeHeaderEntity _nonPresentTimeHeader;
		private bool	_alwaysFetchNonPresentTimeHeader, _alreadyFetchedNonPresentTimeHeader;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ID changes value. Databinding related.
		/// </summary>
		public event EventHandler IDChanged;

		/// <summary>
		/// Event which is thrown when HeaderID changes value. Databinding related.
		/// </summary>
		public event EventHandler HeaderIDChanged;

		/// <summary>
		/// Event which is thrown when ReasonID changes value. Databinding related.
		/// </summary>
		public event EventHandler ReasonIDChanged;

		/// <summary>
		/// Event which is thrown when DateStart changes value. Databinding related.
		/// </summary>
		public event EventHandler DateStartChanged;

		/// <summary>
		/// Event which is thrown when DateEnd changes value. Databinding related.
		/// </summary>
		public event EventHandler DateEndChanged;

		/// <summary>
		/// Event which is thrown when Notes changes value. Databinding related.
		/// </summary>
		public event EventHandler NotesChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public NonPresentTimeEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new NonPresentTimeEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for NonPresentTime which data should be fetched into this NonPresentTime object</param>
		public NonPresentTimeEntity(System.Int32 iD)
		{
			InitClassFetch(iD, new NonPresentTimeValidator(), new PropertyDescriptorFactory(), new NonPresentTimeEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for NonPresentTime which data should be fetched into this NonPresentTime object</param>
		/// <param name="validator">The custom validator object for this NonPresentTimeEntity</param>
		public NonPresentTimeEntity(System.Int32 iD, NonPresentTimeValidator validator)
		{
			InitClassFetch(iD, validator, new PropertyDescriptorFactory(), new NonPresentTimeEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for NonPresentTime which data should be fetched into this NonPresentTime object</param>
		/// <param name="validator">The custom validator object for this NonPresentTimeEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public NonPresentTimeEntity(System.Int32 iD, NonPresentTimeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(iD, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public NonPresentTimeEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private NonPresentTimeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_reason = (ReasonEntity)info.GetValue("_reason", typeof(ReasonEntity));
			if(_reason!=null)
			{
				// rewire event handler.
				_reason.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchReason = info.GetBoolean("_alwaysFetchReason");
			_alreadyFetchedReason = info.GetBoolean("_alreadyFetchedReason");
			_nonPresentTimeHeader = (NonPresentTimeHeaderEntity)info.GetValue("_nonPresentTimeHeader", typeof(NonPresentTimeHeaderEntity));
			if(_nonPresentTimeHeader!=null)
			{
				// rewire event handler.
				_nonPresentTimeHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchNonPresentTimeHeader = info.GetBoolean("_alwaysFetchNonPresentTimeHeader");
			_alreadyFetchedNonPresentTimeHeader = info.GetBoolean("_alreadyFetchedNonPresentTimeHeader");

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


			_alreadyFetchedReason = (_reason != null);
			_alreadyFetchedNonPresentTimeHeader = (_nonPresentTimeHeader != null);

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


			info.AddValue("_reason", _reason);
			info.AddValue("_alwaysFetchReason", _alwaysFetchReason);
			info.AddValue("_alreadyFetchedReason", _alreadyFetchedReason);
			info.AddValue("_nonPresentTimeHeader", _nonPresentTimeHeader);
			info.AddValue("_alwaysFetchNonPresentTimeHeader", _alwaysFetchNonPresentTimeHeader);
			info.AddValue("_alreadyFetchedNonPresentTimeHeader", _alreadyFetchedNonPresentTimeHeader);

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
				case "Reason":
					SetupSyncReason(relatedEntity);
					break;
				case "NonPresentTimeHeader":
					SetupSyncNonPresentTimeHeader(relatedEntity);
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
				case "Reason":
					DesetupSyncReason(false);
					break;
				case "NonPresentTimeHeader":
					DesetupSyncNonPresentTimeHeader(false);
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
			if(_reason!=null)
			{
				toReturn.Add(_reason);
			}
			if(_nonPresentTimeHeader!=null)
			{
				toReturn.Add(_nonPresentTimeHeader);
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
			return base.ToXml("NonPresentTimeEntity");
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
		/// <param name="iD">PK value for NonPresentTime which data should be fetched into this NonPresentTime object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 iD)
		{
			return Fetch(iD);
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
			return Fetch(this.ID);
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
			NonPresentTimeDAO dao = DAOFactory.CreateNonPresentTimeDAO();
			bool wasSuccesful = dao.DeleteNonPresentTime(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(NonPresentTimeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
	
	
		/// <summary>
		/// Retrieves the related entity of type 'ReasonEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ReasonEntity' which is related to this entity.</returns>
		public virtual ReasonEntity GetSingleReason()
		{
			return GetSingleReason(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ReasonEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ReasonEntity' which is related to this entity.</returns>
		public virtual ReasonEntity GetSingleReason(bool forceFetch)
		{
 			if( ( !_alreadyFetchedReason || forceFetch || _alwaysFetchReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ReasonEntity newEntity = new ReasonEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ReasonID);
				this.Reason = newEntity;

				_alreadyFetchedReason = true;
			}
			return _reason;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'NonPresentTimeHeaderEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'NonPresentTimeHeaderEntity' which is related to this entity.</returns>
		public virtual NonPresentTimeHeaderEntity GetSingleNonPresentTimeHeader()
		{
			return GetSingleNonPresentTimeHeader(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'NonPresentTimeHeaderEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'NonPresentTimeHeaderEntity' which is related to this entity.</returns>
		public virtual NonPresentTimeHeaderEntity GetSingleNonPresentTimeHeader(bool forceFetch)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader || forceFetch || _alwaysFetchNonPresentTimeHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				NonPresentTimeHeaderEntity newEntity = new NonPresentTimeHeaderEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.HeaderID);
				this.NonPresentTimeHeader = newEntity;

				_alreadyFetchedNonPresentTimeHeader = true;
			}
			return _nonPresentTimeHeader;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the IDChanged event, which is thrown when ID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnIDChanged()
		{
			if(IDChanged!=null)
			{
				IDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the HeaderIDChanged event, which is thrown when HeaderID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnHeaderIDChanged()
		{
			if(HeaderIDChanged!=null)
			{
				HeaderIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ReasonIDChanged event, which is thrown when ReasonID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnReasonIDChanged()
		{
			if(ReasonIDChanged!=null)
			{
				ReasonIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DateStartChanged event, which is thrown when DateStart changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDateStartChanged()
		{
			if(DateStartChanged!=null)
			{
				DateStartChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DateEndChanged event, which is thrown when DateEnd changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDateEndChanged()
		{
			if(DateEndChanged!=null)
			{
				DateEndChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the NotesChanged event, which is thrown when Notes changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnNotesChanged()
		{
			if(NotesChanged!=null)
			{
				NotesChanged(this, new EventArgs());
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
			NonPresentTimeDAO dao = DAOFactory.CreateNonPresentTimeDAO();
			return dao.AddNonPresentTime(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			NonPresentTimeDAO dao = DAOFactory.CreateNonPresentTimeDAO();
			return dao.UpdateNonPresentTime(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			NonPresentTimeDAO dao = DAOFactory.CreateNonPresentTimeDAO();
			return dao.UpdateNonPresentTime(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.NonPresentTimeEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new NonPresentTimeValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="iD">PK value for NonPresentTime which data should be fetched into this NonPresentTime object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this NonPresentTimeEntity</param>
		private void InitClassFetch(System.Int32 iD, NonPresentTimeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.NonPresentTimeEntity);
			bool wasSuccesful = Fetch(iD);
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


			_reason = null;
			_alwaysFetchReason = false;
			_alreadyFetchedReason = false;
			_nonPresentTimeHeader = null;
			_alwaysFetchNonPresentTimeHeader = false;
			_alreadyFetchedNonPresentTimeHeader = false;

		}


		/// <summary>
		/// Removes the sync logic for member _reason
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncReason(bool signalRelatedEntity)
		{
			if(_reason != null)
			{
				// disconnect the entity from this entity
				_reason.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_reason.UnsetRelatedEntity(this, "NonPresentTime");
				}
				base.UnsetEntitySyncInformation("Reason", _reason, NonPresentTimeEntity.Relations.ReasonEntityUsingReasonID);
				_reason = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _reason
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncReason(IEntity relatedEntity)
		{
			DesetupSyncReason(true);
			
			if(relatedEntity!=null)
			{
				_reason = (ReasonEntity)relatedEntity;
				_reason.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Reason", _reason, NonPresentTimeEntity.Relations.ReasonEntityUsingReasonID);
				if(!_reason.IsNew)
				{
					// sync now
					base.SyncFKFields(NonPresentTimeEntity.Relations.ReasonEntityUsingReasonID, _reason);
				}
			}

			_alreadyFetchedReason = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _nonPresentTimeHeader
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncNonPresentTimeHeader(bool signalRelatedEntity)
		{
			if(_nonPresentTimeHeader != null)
			{
				// disconnect the entity from this entity
				_nonPresentTimeHeader.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_nonPresentTimeHeader.UnsetRelatedEntity(this, "NonPresentTime");
				}
				base.UnsetEntitySyncInformation("NonPresentTimeHeader", _nonPresentTimeHeader, NonPresentTimeEntity.Relations.NonPresentTimeHeaderEntityUsingHeaderID);
				_nonPresentTimeHeader = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _nonPresentTimeHeader
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncNonPresentTimeHeader(IEntity relatedEntity)
		{
			DesetupSyncNonPresentTimeHeader(true);
			
			if(relatedEntity!=null)
			{
				_nonPresentTimeHeader = (NonPresentTimeHeaderEntity)relatedEntity;
				_nonPresentTimeHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("NonPresentTimeHeader", _nonPresentTimeHeader, NonPresentTimeEntity.Relations.NonPresentTimeHeaderEntityUsingHeaderID);
				if(!_nonPresentTimeHeader.IsNew)
				{
					// sync now
					base.SyncFKFields(NonPresentTimeEntity.Relations.NonPresentTimeHeaderEntityUsingHeaderID, _nonPresentTimeHeader);
				}
			}

			_alreadyFetchedNonPresentTimeHeader = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="iD">PK value for NonPresentTime which data should be fetched into this NonPresentTime object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 iD)
		{
			NonPresentTimeDAO dao = DAOFactory.CreateNonPresentTimeDAO();

			// Load EntityFields of NonPresentTime
			dao.FetchNonPresentTime(base.Fields, base.Transaction, iD);

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
		public static NonPresentTimeRelations Relations
		{
			get	{ return new NonPresentTimeRelations(); }
		}

	
		/// <summary>
		/// The ID property of the Entity NonPresentTime
		/// </summary>
		public virtual System.Int32 ID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeFieldIndex.ID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeFieldIndex.ID, value))
				{
					OnIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The HeaderID property of the Entity NonPresentTime
		/// </summary>
		public virtual System.Int32 HeaderID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeFieldIndex.HeaderID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for HeaderID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeFieldIndex.HeaderID, value))
				{
					OnHeaderIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ReasonID property of the Entity NonPresentTime
		/// </summary>
		public virtual System.Int32 ReasonID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeFieldIndex.ReasonID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ReasonID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeFieldIndex.ReasonID, value))
				{
					OnReasonIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The DateStart property of the Entity NonPresentTime
		/// </summary>
		public virtual System.DateTime DateStart
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeFieldIndex.DateStart);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DateStart because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeFieldIndex.DateStart, value))
				{
					OnDateStartChanged();
				}
			}
		}
	
		/// <summary>
		/// The DateEnd property of the Entity NonPresentTime
		/// </summary>
		public virtual System.DateTime DateEnd
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeFieldIndex.DateEnd);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DateEnd because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeFieldIndex.DateEnd, value))
				{
					OnDateEndChanged();
				}
			}
		}
	
		/// <summary>
		/// The Notes property of the Entity NonPresentTime
		/// </summary>
		public virtual System.String Notes
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeFieldIndex.Notes);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Notes because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeFieldIndex.Notes, value))
				{
					OnNotesChanged();
				}
			}
		}
	
	
	
	
		/// <summary>
		/// Gets / sets related entity of type 'ReasonEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ReasonEntity Reason
		{
			get
			{
				return GetSingleReason(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncReason(value);
				}
				else
				{
					if(value==null)
					{
						if(_reason != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_reason.UnsetRelatedEntity(this, "NonPresentTime");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "NonPresentTime");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Reason. When set to true, Reason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Reason is accessed. You can always execute
		/// a forced fetch by calling GetSingleReason(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchReason
		{
			get
			{
				return _alwaysFetchReason;
			}
			set
			{
				_alwaysFetchReason = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'NonPresentTimeHeaderEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleNonPresentTimeHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual NonPresentTimeHeaderEntity NonPresentTimeHeader
		{
			get
			{
				return GetSingleNonPresentTimeHeader(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncNonPresentTimeHeader(value);
				}
				else
				{
					if(value==null)
					{
						if(_nonPresentTimeHeader != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_nonPresentTimeHeader.UnsetRelatedEntity(this, "NonPresentTime");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "NonPresentTime");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for NonPresentTimeHeader. When set to true, NonPresentTimeHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time NonPresentTimeHeader is accessed. You can always execute
		/// a forced fetch by calling GetSingleNonPresentTimeHeader(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchNonPresentTimeHeader
		{
			get
			{
				return _alwaysFetchNonPresentTimeHeader;
			}
			set
			{
				_alwaysFetchNonPresentTimeHeader = value;
			}	
		}
	
	
		#endregion
	}
}