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
	/// Entity class which represents the entity 'EmployeeDepartmentHistory' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class EmployeeDepartmentHistoryEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations


		private DepartmentEntity _department;
		private bool	_alwaysFetchDepartment, _alreadyFetchedDepartment;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee;
		private ShiftEntity _shift;
		private bool	_alwaysFetchShift, _alreadyFetchedShift;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when EmployeeID changes value. Databinding related.
		/// </summary>
		public event EventHandler EmployeeIDChanged;

		/// <summary>
		/// Event which is thrown when DepartmentID changes value. Databinding related.
		/// </summary>
		public event EventHandler DepartmentIDChanged;

		/// <summary>
		/// Event which is thrown when ShiftID changes value. Databinding related.
		/// </summary>
		public event EventHandler ShiftIDChanged;

		/// <summary>
		/// Event which is thrown when StartDate changes value. Databinding related.
		/// </summary>
		public event EventHandler StartDateChanged;

		/// <summary>
		/// Event which is thrown when EndDate changes value. Databinding related.
		/// </summary>
		public event EventHandler EndDateChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public EmployeeDepartmentHistoryEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new EmployeeDepartmentHistoryEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		public EmployeeDepartmentHistoryEntity(System.Int32 employeeID, System.Int16 departmentID, System.Byte shiftID, System.DateTime startDate)
		{
			InitClassFetch(employeeID, departmentID, shiftID, startDate, new EmployeeDepartmentHistoryValidator(), new PropertyDescriptorFactory(), new EmployeeDepartmentHistoryEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="validator">The custom validator object for this EmployeeDepartmentHistoryEntity</param>
		public EmployeeDepartmentHistoryEntity(System.Int32 employeeID, System.Int16 departmentID, System.Byte shiftID, System.DateTime startDate, EmployeeDepartmentHistoryValidator validator)
		{
			InitClassFetch(employeeID, departmentID, shiftID, startDate, validator, new PropertyDescriptorFactory(), new EmployeeDepartmentHistoryEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="validator">The custom validator object for this EmployeeDepartmentHistoryEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeDepartmentHistoryEntity(System.Int32 employeeID, System.Int16 departmentID, System.Byte shiftID, System.DateTime startDate, EmployeeDepartmentHistoryValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(employeeID, departmentID, shiftID, startDate, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeDepartmentHistoryEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private EmployeeDepartmentHistoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_department = (DepartmentEntity)info.GetValue("_department", typeof(DepartmentEntity));
			if(_department!=null)
			{
				// rewire event handler.
				_department.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchDepartment = info.GetBoolean("_alwaysFetchDepartment");
			_alreadyFetchedDepartment = info.GetBoolean("_alreadyFetchedDepartment");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				// rewire event handler.
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
			_shift = (ShiftEntity)info.GetValue("_shift", typeof(ShiftEntity));
			if(_shift!=null)
			{
				// rewire event handler.
				_shift.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchShift = info.GetBoolean("_alwaysFetchShift");
			_alreadyFetchedShift = info.GetBoolean("_alreadyFetchedShift");

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


			_alreadyFetchedDepartment = (_department != null);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedShift = (_shift != null);

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


			info.AddValue("_department", _department);
			info.AddValue("_alwaysFetchDepartment", _alwaysFetchDepartment);
			info.AddValue("_alreadyFetchedDepartment", _alreadyFetchedDepartment);
			info.AddValue("_employee", _employee);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_shift", _shift);
			info.AddValue("_alwaysFetchShift", _alwaysFetchShift);
			info.AddValue("_alreadyFetchedShift", _alreadyFetchedShift);

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
				case "Department":
					SetupSyncDepartment(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "Shift":
					SetupSyncShift(relatedEntity);
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
				case "Department":
					DesetupSyncDepartment(false);
					break;
				case "Employee":
					DesetupSyncEmployee(false);
					break;
				case "Shift":
					DesetupSyncShift(false);
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
			if(_department!=null)
			{
				toReturn.Add(_department);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_shift!=null)
			{
				toReturn.Add(_shift);
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
			return base.ToXml("EmployeeDepartmentHistoryEntity");
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
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeID, System.Int16 departmentID, System.Byte shiftID, System.DateTime startDate)
		{
			return Fetch(employeeID, departmentID, shiftID, startDate);
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
			return Fetch(this.EmployeeID, this.DepartmentID, this.ShiftID, this.StartDate);
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
			EmployeeDepartmentHistoryDAO dao = DAOFactory.CreateEmployeeDepartmentHistoryDAO();
			bool wasSuccesful = dao.DeleteEmployeeDepartmentHistory(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(EmployeeDepartmentHistoryFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
	
	
		/// <summary>
		/// Retrieves the related entity of type 'DepartmentEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'DepartmentEntity' which is related to this entity.</returns>
		public virtual DepartmentEntity GetSingleDepartment()
		{
			return GetSingleDepartment(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'DepartmentEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'DepartmentEntity' which is related to this entity.</returns>
		public virtual DepartmentEntity GetSingleDepartment(bool forceFetch)
		{
 			if( ( !_alreadyFetchedDepartment || forceFetch || _alwaysFetchDepartment) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				DepartmentEntity newEntity = new DepartmentEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.DepartmentID);
				this.Department = newEntity;

				_alreadyFetchedDepartment = true;
			}
			return _department;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee()
		{
			return GetSingleEmployee(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployee(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.EmployeeID);
				this.Employee = newEntity;

				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'ShiftEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ShiftEntity' which is related to this entity.</returns>
		public virtual ShiftEntity GetSingleShift()
		{
			return GetSingleShift(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ShiftEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ShiftEntity' which is related to this entity.</returns>
		public virtual ShiftEntity GetSingleShift(bool forceFetch)
		{
 			if( ( !_alreadyFetchedShift || forceFetch || _alwaysFetchShift) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ShiftEntity newEntity = new ShiftEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ShiftID);
				this.Shift = newEntity;

				_alreadyFetchedShift = true;
			}
			return _shift;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the EmployeeIDChanged event, which is thrown when EmployeeID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEmployeeIDChanged()
		{
			if(EmployeeIDChanged!=null)
			{
				EmployeeIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DepartmentIDChanged event, which is thrown when DepartmentID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDepartmentIDChanged()
		{
			if(DepartmentIDChanged!=null)
			{
				DepartmentIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ShiftIDChanged event, which is thrown when ShiftID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnShiftIDChanged()
		{
			if(ShiftIDChanged!=null)
			{
				ShiftIDChanged(this, new EventArgs());
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
			EmployeeDepartmentHistoryDAO dao = DAOFactory.CreateEmployeeDepartmentHistoryDAO();
			return dao.AddEmployeeDepartmentHistory(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			EmployeeDepartmentHistoryDAO dao = DAOFactory.CreateEmployeeDepartmentHistoryDAO();
			return dao.UpdateEmployeeDepartmentHistory(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			EmployeeDepartmentHistoryDAO dao = DAOFactory.CreateEmployeeDepartmentHistoryDAO();
			return dao.UpdateEmployeeDepartmentHistory(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.EmployeeDepartmentHistoryEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new EmployeeDepartmentHistoryValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this EmployeeDepartmentHistoryEntity</param>
		private void InitClassFetch(System.Int32 employeeID, System.Int16 departmentID, System.Byte shiftID, System.DateTime startDate, EmployeeDepartmentHistoryValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.EmployeeDepartmentHistoryEntity);
			bool wasSuccesful = Fetch(employeeID, departmentID, shiftID, startDate);
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


			_department = null;
			_alwaysFetchDepartment = false;
			_alreadyFetchedDepartment = false;
			_employee = null;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_shift = null;
			_alwaysFetchShift = false;
			_alreadyFetchedShift = false;

		}


		/// <summary>
		/// Removes the sync logic for member _department
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncDepartment(bool signalRelatedEntity)
		{
			if(_department != null)
			{
				// disconnect the entity from this entity
				_department.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_department.UnsetRelatedEntity(this, "EmployeeDepartmentHistory");
				}
				base.UnsetEntitySyncInformation("Department", _department, EmployeeDepartmentHistoryEntity.Relations.DepartmentEntityUsingDepartmentID);
				_department = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _department
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncDepartment(IEntity relatedEntity)
		{
			DesetupSyncDepartment(true);
			
			if(relatedEntity!=null)
			{
				_department = (DepartmentEntity)relatedEntity;
				_department.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Department", _department, EmployeeDepartmentHistoryEntity.Relations.DepartmentEntityUsingDepartmentID);
				if(!_department.IsNew)
				{
					// sync now
					base.SyncFKFields(EmployeeDepartmentHistoryEntity.Relations.DepartmentEntityUsingDepartmentID, _department);
				}
			}

			_alreadyFetchedDepartment = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _employee
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity)
		{
			if(_employee != null)
			{
				// disconnect the entity from this entity
				_employee.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_employee.UnsetRelatedEntity(this, "EmployeeDepartmentHistory");
				}
				base.UnsetEntitySyncInformation("Employee", _employee, EmployeeDepartmentHistoryEntity.Relations.EmployeeEntityUsingEmployeeID);
				_employee = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _employee
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntity relatedEntity)
		{
			DesetupSyncEmployee(true);
			
			if(relatedEntity!=null)
			{
				_employee = (EmployeeEntity)relatedEntity;
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Employee", _employee, EmployeeDepartmentHistoryEntity.Relations.EmployeeEntityUsingEmployeeID);
				if(!_employee.IsNew)
				{
					// sync now
					base.SyncFKFields(EmployeeDepartmentHistoryEntity.Relations.EmployeeEntityUsingEmployeeID, _employee);
				}
			}

			_alreadyFetchedEmployee = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _shift
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncShift(bool signalRelatedEntity)
		{
			if(_shift != null)
			{
				// disconnect the entity from this entity
				_shift.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_shift.UnsetRelatedEntity(this, "EmployeeDepartmentHistory");
				}
				base.UnsetEntitySyncInformation("Shift", _shift, EmployeeDepartmentHistoryEntity.Relations.ShiftEntityUsingShiftID);
				_shift = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _shift
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShift(IEntity relatedEntity)
		{
			DesetupSyncShift(true);
			
			if(relatedEntity!=null)
			{
				_shift = (ShiftEntity)relatedEntity;
				_shift.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Shift", _shift, EmployeeDepartmentHistoryEntity.Relations.ShiftEntityUsingShiftID);
				if(!_shift.IsNew)
				{
					// sync now
					base.SyncFKFields(EmployeeDepartmentHistoryEntity.Relations.ShiftEntityUsingShiftID, _shift);
				}
			}

			_alreadyFetchedShift = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="employeeID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="departmentID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="shiftID">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <param name="startDate">PK value for EmployeeDepartmentHistory which data should be fetched into this EmployeeDepartmentHistory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 employeeID, System.Int16 departmentID, System.Byte shiftID, System.DateTime startDate)
		{
			EmployeeDepartmentHistoryDAO dao = DAOFactory.CreateEmployeeDepartmentHistoryDAO();

			// Load EntityFields of EmployeeDepartmentHistory
			dao.FetchEmployeeDepartmentHistory(base.Fields, base.Transaction, employeeID, departmentID, shiftID, startDate);

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
		public static EmployeeDepartmentHistoryRelations Relations
		{
			get	{ return new EmployeeDepartmentHistoryRelations(); }
		}

	
		/// <summary>
		/// The EmployeeID property of the Entity EmployeeDepartmentHistory
		/// </summary>
		public virtual System.Int32 EmployeeID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeDepartmentHistoryFieldIndex.EmployeeID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EmployeeID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeDepartmentHistoryFieldIndex.EmployeeID, value))
				{
					OnEmployeeIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The DepartmentID property of the Entity EmployeeDepartmentHistory
		/// </summary>
		public virtual System.Int16 DepartmentID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeDepartmentHistoryFieldIndex.DepartmentID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DepartmentID because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeDepartmentHistoryFieldIndex.DepartmentID, value))
				{
					OnDepartmentIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ShiftID property of the Entity EmployeeDepartmentHistory
		/// </summary>
		public virtual System.Byte ShiftID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeDepartmentHistoryFieldIndex.ShiftID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ShiftID because it is set to NULL.");
				}
				return (System.Byte)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeDepartmentHistoryFieldIndex.ShiftID, value))
				{
					OnShiftIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The StartDate property of the Entity EmployeeDepartmentHistory
		/// </summary>
		public virtual System.DateTime StartDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeDepartmentHistoryFieldIndex.StartDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for StartDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeDepartmentHistoryFieldIndex.StartDate, value))
				{
					OnStartDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The EndDate property of the Entity EmployeeDepartmentHistory
		/// </summary>
		public virtual System.DateTime EndDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeDepartmentHistoryFieldIndex.EndDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EndDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeDepartmentHistoryFieldIndex.EndDate, value))
				{
					OnEndDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity EmployeeDepartmentHistory
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
	
	
		/// <summary>
		/// Gets / sets related entity of type 'DepartmentEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleDepartment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual DepartmentEntity Department
		{
			get
			{
				return GetSingleDepartment(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncDepartment(value);
				}
				else
				{
					if(value==null)
					{
						if(_department != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_department.UnsetRelatedEntity(this, "EmployeeDepartmentHistory");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "EmployeeDepartmentHistory");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Department. When set to true, Department is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Department is accessed. You can always execute
		/// a forced fetch by calling GetSingleDepartment(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchDepartment
		{
			get
			{
				return _alwaysFetchDepartment;
			}
			set
			{
				_alwaysFetchDepartment = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get
			{
				return GetSingleEmployee(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					if(value==null)
					{
						if(_employee != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_employee.UnsetRelatedEntity(this, "EmployeeDepartmentHistory");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "EmployeeDepartmentHistory");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployee(true).
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
		/// Gets / sets related entity of type 'ShiftEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleShift()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ShiftEntity Shift
		{
			get
			{
				return GetSingleShift(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncShift(value);
				}
				else
				{
					if(value==null)
					{
						if(_shift != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_shift.UnsetRelatedEntity(this, "EmployeeDepartmentHistory");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "EmployeeDepartmentHistory");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Shift. When set to true, Shift is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Shift is accessed. You can always execute
		/// a forced fetch by calling GetSingleShift(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchShift
		{
			get
			{
				return _alwaysFetchShift;
			}
			set
			{
				_alwaysFetchShift = value;
			}	
		}
	
	
		#endregion
	}
}
