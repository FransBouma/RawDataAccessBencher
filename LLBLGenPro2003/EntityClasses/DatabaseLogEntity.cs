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
	/// Entity class which represents the entity 'DatabaseLog' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class DatabaseLogEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations




		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when DatabaseLogID changes value. Databinding related.
		/// </summary>
		public event EventHandler DatabaseLogIDChanged;

		/// <summary>
		/// Event which is thrown when PostTime changes value. Databinding related.
		/// </summary>
		public event EventHandler PostTimeChanged;

		/// <summary>
		/// Event which is thrown when DatabaseUser changes value. Databinding related.
		/// </summary>
		public event EventHandler DatabaseUserChanged;

		/// <summary>
		/// Event which is thrown when Event changes value. Databinding related.
		/// </summary>
		public event EventHandler EventChanged;

		/// <summary>
		/// Event which is thrown when Schema changes value. Databinding related.
		/// </summary>
		public event EventHandler SchemaChanged;

		/// <summary>
		/// Event which is thrown when Object changes value. Databinding related.
		/// </summary>
		public event EventHandler ObjectChanged;

		/// <summary>
		/// Event which is thrown when TSQL changes value. Databinding related.
		/// </summary>
		public event EventHandler TSQLChanged;

		/// <summary>
		/// Event which is thrown when XmlEvent changes value. Databinding related.
		/// </summary>
		public event EventHandler XmlEventChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public DatabaseLogEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new DatabaseLogEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="databaseLogID">PK value for DatabaseLog which data should be fetched into this DatabaseLog object</param>
		public DatabaseLogEntity(System.Int32 databaseLogID)
		{
			InitClassFetch(databaseLogID, new DatabaseLogValidator(), new PropertyDescriptorFactory(), new DatabaseLogEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="databaseLogID">PK value for DatabaseLog which data should be fetched into this DatabaseLog object</param>
		/// <param name="validator">The custom validator object for this DatabaseLogEntity</param>
		public DatabaseLogEntity(System.Int32 databaseLogID, DatabaseLogValidator validator)
		{
			InitClassFetch(databaseLogID, validator, new PropertyDescriptorFactory(), new DatabaseLogEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="databaseLogID">PK value for DatabaseLog which data should be fetched into this DatabaseLog object</param>
		/// <param name="validator">The custom validator object for this DatabaseLogEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public DatabaseLogEntity(System.Int32 databaseLogID, DatabaseLogValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(databaseLogID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public DatabaseLogEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private DatabaseLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{




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


		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("DatabaseLogEntity");
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
		/// <param name="databaseLogID">PK value for DatabaseLog which data should be fetched into this DatabaseLog object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 databaseLogID)
		{
			return Fetch(databaseLogID);
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
			return Fetch(this.DatabaseLogID);
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
			DatabaseLogDAO dao = DAOFactory.CreateDatabaseLogDAO();
			bool wasSuccesful = dao.DeleteDatabaseLog(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(DatabaseLogFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
	
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the DatabaseLogIDChanged event, which is thrown when DatabaseLogID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDatabaseLogIDChanged()
		{
			if(DatabaseLogIDChanged!=null)
			{
				DatabaseLogIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PostTimeChanged event, which is thrown when PostTime changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPostTimeChanged()
		{
			if(PostTimeChanged!=null)
			{
				PostTimeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DatabaseUserChanged event, which is thrown when DatabaseUser changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDatabaseUserChanged()
		{
			if(DatabaseUserChanged!=null)
			{
				DatabaseUserChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the EventChanged event, which is thrown when Event changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEventChanged()
		{
			if(EventChanged!=null)
			{
				EventChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SchemaChanged event, which is thrown when Schema changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSchemaChanged()
		{
			if(SchemaChanged!=null)
			{
				SchemaChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ObjectChanged event, which is thrown when Object changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnObjectChanged()
		{
			if(ObjectChanged!=null)
			{
				ObjectChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the TSQLChanged event, which is thrown when TSQL changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTSQLChanged()
		{
			if(TSQLChanged!=null)
			{
				TSQLChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the XmlEventChanged event, which is thrown when XmlEvent changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnXmlEventChanged()
		{
			if(XmlEventChanged!=null)
			{
				XmlEventChanged(this, new EventArgs());
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
			DatabaseLogDAO dao = DAOFactory.CreateDatabaseLogDAO();
			return dao.AddDatabaseLog(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			DatabaseLogDAO dao = DAOFactory.CreateDatabaseLogDAO();
			return dao.UpdateDatabaseLog(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DatabaseLogDAO dao = DAOFactory.CreateDatabaseLogDAO();
			return dao.UpdateDatabaseLog(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.DatabaseLogEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new DatabaseLogValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="databaseLogID">PK value for DatabaseLog which data should be fetched into this DatabaseLog object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this DatabaseLogEntity</param>
		private void InitClassFetch(System.Int32 databaseLogID, DatabaseLogValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.DatabaseLogEntity);
			bool wasSuccesful = Fetch(databaseLogID);
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




		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="databaseLogID">PK value for DatabaseLog which data should be fetched into this DatabaseLog object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 databaseLogID)
		{
			DatabaseLogDAO dao = DAOFactory.CreateDatabaseLogDAO();

			// Load EntityFields of DatabaseLog
			dao.FetchDatabaseLog(base.Fields, base.Transaction, databaseLogID);

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
		public static DatabaseLogRelations Relations
		{
			get	{ return new DatabaseLogRelations(); }
		}

	
		/// <summary>
		/// The DatabaseLogID property of the Entity DatabaseLog
		/// </summary>
		public virtual System.Int32 DatabaseLogID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DatabaseLogFieldIndex.DatabaseLogID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DatabaseLogID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DatabaseLogFieldIndex.DatabaseLogID, value))
				{
					OnDatabaseLogIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The PostTime property of the Entity DatabaseLog
		/// </summary>
		public virtual System.DateTime PostTime
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DatabaseLogFieldIndex.PostTime);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PostTime because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DatabaseLogFieldIndex.PostTime, value))
				{
					OnPostTimeChanged();
				}
			}
		}
	
		/// <summary>
		/// The DatabaseUser property of the Entity DatabaseLog
		/// </summary>
		public virtual System.String DatabaseUser
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DatabaseLogFieldIndex.DatabaseUser);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DatabaseUser because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DatabaseLogFieldIndex.DatabaseUser, value))
				{
					OnDatabaseUserChanged();
				}
			}
		}
	
		/// <summary>
		/// The Event property of the Entity DatabaseLog
		/// </summary>
		public virtual System.String Event
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DatabaseLogFieldIndex.Event);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Event because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DatabaseLogFieldIndex.Event, value))
				{
					OnEventChanged();
				}
			}
		}
	
		/// <summary>
		/// The Schema property of the Entity DatabaseLog
		/// </summary>
		public virtual System.String Schema
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DatabaseLogFieldIndex.Schema);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Schema because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DatabaseLogFieldIndex.Schema, value))
				{
					OnSchemaChanged();
				}
			}
		}
	
		/// <summary>
		/// The Object property of the Entity DatabaseLog
		/// </summary>
		public virtual System.String Object
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DatabaseLogFieldIndex.Object);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Object because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DatabaseLogFieldIndex.Object, value))
				{
					OnObjectChanged();
				}
			}
		}
	
		/// <summary>
		/// The TSQL property of the Entity DatabaseLog
		/// </summary>
		public virtual System.String TSQL
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DatabaseLogFieldIndex.TSQL);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TSQL because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DatabaseLogFieldIndex.TSQL, value))
				{
					OnTSQLChanged();
				}
			}
		}
	
		/// <summary>
		/// The XmlEvent property of the Entity DatabaseLog
		/// </summary>
		public virtual System.String XmlEvent
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DatabaseLogFieldIndex.XmlEvent);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for XmlEvent because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DatabaseLogFieldIndex.XmlEvent, value))
				{
					OnXmlEventChanged();
				}
			}
		}
	
	
	
	
	
		#endregion
	}
}
