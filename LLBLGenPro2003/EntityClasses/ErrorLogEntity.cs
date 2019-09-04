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
	/// Entity class which represents the entity 'ErrorLog' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ErrorLogEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations




		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ErrorLogID changes value. Databinding related.
		/// </summary>
		public event EventHandler ErrorLogIDChanged;

		/// <summary>
		/// Event which is thrown when ErrorTime changes value. Databinding related.
		/// </summary>
		public event EventHandler ErrorTimeChanged;

		/// <summary>
		/// Event which is thrown when UserName changes value. Databinding related.
		/// </summary>
		public event EventHandler UserNameChanged;

		/// <summary>
		/// Event which is thrown when ErrorNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler ErrorNumberChanged;

		/// <summary>
		/// Event which is thrown when ErrorSeverity changes value. Databinding related.
		/// </summary>
		public event EventHandler ErrorSeverityChanged;

		/// <summary>
		/// Event which is thrown when ErrorState changes value. Databinding related.
		/// </summary>
		public event EventHandler ErrorStateChanged;

		/// <summary>
		/// Event which is thrown when ErrorProcedure changes value. Databinding related.
		/// </summary>
		public event EventHandler ErrorProcedureChanged;

		/// <summary>
		/// Event which is thrown when ErrorLine changes value. Databinding related.
		/// </summary>
		public event EventHandler ErrorLineChanged;

		/// <summary>
		/// Event which is thrown when ErrorMessage changes value. Databinding related.
		/// </summary>
		public event EventHandler ErrorMessageChanged;

		/// <summary>
		/// Event which is thrown when TesTField changes value. Databinding related.
		/// </summary>
		public event EventHandler TesTFieldChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public ErrorLogEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ErrorLogEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="errorLogID">PK value for ErrorLog which data should be fetched into this ErrorLog object</param>
		public ErrorLogEntity(System.Int32 errorLogID)
		{
			InitClassFetch(errorLogID, new ErrorLogValidator(), new PropertyDescriptorFactory(), new ErrorLogEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="errorLogID">PK value for ErrorLog which data should be fetched into this ErrorLog object</param>
		/// <param name="validator">The custom validator object for this ErrorLogEntity</param>
		public ErrorLogEntity(System.Int32 errorLogID, ErrorLogValidator validator)
		{
			InitClassFetch(errorLogID, validator, new PropertyDescriptorFactory(), new ErrorLogEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="errorLogID">PK value for ErrorLog which data should be fetched into this ErrorLog object</param>
		/// <param name="validator">The custom validator object for this ErrorLogEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ErrorLogEntity(System.Int32 errorLogID, ErrorLogValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(errorLogID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ErrorLogEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ErrorLogEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
			return base.ToXml("ErrorLogEntity");
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
		/// <param name="errorLogID">PK value for ErrorLog which data should be fetched into this ErrorLog object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 errorLogID)
		{
			return Fetch(errorLogID);
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
			return Fetch(this.ErrorLogID);
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
			ErrorLogDAO dao = DAOFactory.CreateErrorLogDAO();
			bool wasSuccesful = dao.DeleteErrorLog(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ErrorLogFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
	
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the ErrorLogIDChanged event, which is thrown when ErrorLogID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnErrorLogIDChanged()
		{
			if(ErrorLogIDChanged!=null)
			{
				ErrorLogIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ErrorTimeChanged event, which is thrown when ErrorTime changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnErrorTimeChanged()
		{
			if(ErrorTimeChanged!=null)
			{
				ErrorTimeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the UserNameChanged event, which is thrown when UserName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnUserNameChanged()
		{
			if(UserNameChanged!=null)
			{
				UserNameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ErrorNumberChanged event, which is thrown when ErrorNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnErrorNumberChanged()
		{
			if(ErrorNumberChanged!=null)
			{
				ErrorNumberChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ErrorSeverityChanged event, which is thrown when ErrorSeverity changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnErrorSeverityChanged()
		{
			if(ErrorSeverityChanged!=null)
			{
				ErrorSeverityChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ErrorStateChanged event, which is thrown when ErrorState changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnErrorStateChanged()
		{
			if(ErrorStateChanged!=null)
			{
				ErrorStateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ErrorProcedureChanged event, which is thrown when ErrorProcedure changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnErrorProcedureChanged()
		{
			if(ErrorProcedureChanged!=null)
			{
				ErrorProcedureChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ErrorLineChanged event, which is thrown when ErrorLine changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnErrorLineChanged()
		{
			if(ErrorLineChanged!=null)
			{
				ErrorLineChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ErrorMessageChanged event, which is thrown when ErrorMessage changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnErrorMessageChanged()
		{
			if(ErrorMessageChanged!=null)
			{
				ErrorMessageChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the TesTFieldChanged event, which is thrown when TesTField changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTesTFieldChanged()
		{
			if(TesTFieldChanged!=null)
			{
				TesTFieldChanged(this, new EventArgs());
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
			ErrorLogDAO dao = DAOFactory.CreateErrorLogDAO();
			return dao.AddErrorLog(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ErrorLogDAO dao = DAOFactory.CreateErrorLogDAO();
			return dao.UpdateErrorLog(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ErrorLogDAO dao = DAOFactory.CreateErrorLogDAO();
			return dao.UpdateErrorLog(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ErrorLogEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ErrorLogValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="errorLogID">PK value for ErrorLog which data should be fetched into this ErrorLog object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ErrorLogEntity</param>
		private void InitClassFetch(System.Int32 errorLogID, ErrorLogValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ErrorLogEntity);
			bool wasSuccesful = Fetch(errorLogID);
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
		/// <param name="errorLogID">PK value for ErrorLog which data should be fetched into this ErrorLog object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 errorLogID)
		{
			ErrorLogDAO dao = DAOFactory.CreateErrorLogDAO();

			// Load EntityFields of ErrorLog
			dao.FetchErrorLog(base.Fields, base.Transaction, errorLogID);

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
		public static ErrorLogRelations Relations
		{
			get	{ return new ErrorLogRelations(); }
		}

	
		/// <summary>
		/// The ErrorLogID property of the Entity ErrorLog
		/// </summary>
		public virtual System.Int32 ErrorLogID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.ErrorLogID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ErrorLogID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.ErrorLogID, value))
				{
					OnErrorLogIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ErrorTime property of the Entity ErrorLog
		/// </summary>
		public virtual System.DateTime ErrorTime
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.ErrorTime);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ErrorTime because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.ErrorTime, value))
				{
					OnErrorTimeChanged();
				}
			}
		}
	
		/// <summary>
		/// The UserName property of the Entity ErrorLog
		/// </summary>
		public virtual System.String UserName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.UserName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for UserName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.UserName, value))
				{
					OnUserNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The ErrorNumber property of the Entity ErrorLog
		/// </summary>
		public virtual System.Int32 ErrorNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.ErrorNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ErrorNumber because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.ErrorNumber, value))
				{
					OnErrorNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The ErrorSeverity property of the Entity ErrorLog
		/// </summary>
		public virtual System.Int32 ErrorSeverity
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.ErrorSeverity);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ErrorSeverity because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.ErrorSeverity, value))
				{
					OnErrorSeverityChanged();
				}
			}
		}
	
		/// <summary>
		/// The ErrorState property of the Entity ErrorLog
		/// </summary>
		public virtual System.Int32 ErrorState
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.ErrorState);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ErrorState because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.ErrorState, value))
				{
					OnErrorStateChanged();
				}
			}
		}
	
		/// <summary>
		/// The ErrorProcedure property of the Entity ErrorLog
		/// </summary>
		public virtual System.String ErrorProcedure
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.ErrorProcedure);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ErrorProcedure because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.ErrorProcedure, value))
				{
					OnErrorProcedureChanged();
				}
			}
		}
	
		/// <summary>
		/// The ErrorLine property of the Entity ErrorLog
		/// </summary>
		public virtual System.Int32 ErrorLine
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.ErrorLine);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ErrorLine because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.ErrorLine, value))
				{
					OnErrorLineChanged();
				}
			}
		}
	
		/// <summary>
		/// The ErrorMessage property of the Entity ErrorLog
		/// </summary>
		public virtual System.String ErrorMessage
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.ErrorMessage);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ErrorMessage because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.ErrorMessage, value))
				{
					OnErrorMessageChanged();
				}
			}
		}
	
		/// <summary>
		/// The TesTField property of the Entity ErrorLog
		/// </summary>
		public virtual System.Int32 TesTField
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ErrorLogFieldIndex.TesTField);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TesTField because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ErrorLogFieldIndex.TesTField, value))
				{
					OnTesTFieldChanged();
				}
			}
		}
	
	
	
	
	
		#endregion
	}
}
