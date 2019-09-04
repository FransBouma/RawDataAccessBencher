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
	/// Entity class which represents the entity 'Employee' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class EmployeeEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private EmployeeCollection	_employeeManagerID;
		private bool	_alwaysFetchEmployeeManagerID, _alreadyFetchedEmployeeManagerID;
		private EmployeeAddressCollection	_employeeAddress;
		private bool	_alwaysFetchEmployeeAddress, _alreadyFetchedEmployeeAddress;
		private EmployeeDepartmentHistoryCollection	_employeeDepartmentHistory;
		private bool	_alwaysFetchEmployeeDepartmentHistory, _alreadyFetchedEmployeeDepartmentHistory;
		private EmployeePayHistoryCollection	_employeePayHistory;
		private bool	_alwaysFetchEmployeePayHistory, _alreadyFetchedEmployeePayHistory;
		private JobCandidateCollection	_jobCandidate;
		private bool	_alwaysFetchJobCandidate, _alreadyFetchedJobCandidate;
		private PurchaseOrderHeaderCollection	_purchaseOrderHeader;
		private bool	_alwaysFetchPurchaseOrderHeader, _alreadyFetchedPurchaseOrderHeader;
		private ContactCollection _contact_;
		private bool	_alwaysFetchContact_, _alreadyFetchedContact_;
		private AddressCollection _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private DepartmentCollection _department;
		private bool	_alwaysFetchDepartment, _alreadyFetchedDepartment;
		private ShiftCollection _shift;
		private bool	_alwaysFetchShift, _alreadyFetchedShift;
		private ShipMethodCollection _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;
		private VendorCollection _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor;
		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact;
		private EmployeeEntity _employeeEmployeeID;
		private bool	_alwaysFetchEmployeeEmployeeID, _alreadyFetchedEmployeeEmployeeID;
		private SalesPersonEntity _salesPerson;
		private bool	_alwaysFetchSalesPerson, _alreadyFetchedSalesPerson;
		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when EmployeeID changes value. Databinding related.
		/// </summary>
		public event EventHandler EmployeeIDChanged;

		/// <summary>
		/// Event which is thrown when NationalIDNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler NationalIDNumberChanged;

		/// <summary>
		/// Event which is thrown when ContactID changes value. Databinding related.
		/// </summary>
		public event EventHandler ContactIDChanged;

		/// <summary>
		/// Event which is thrown when LoginID changes value. Databinding related.
		/// </summary>
		public event EventHandler LoginIDChanged;

		/// <summary>
		/// Event which is thrown when ManagerID changes value. Databinding related.
		/// </summary>
		public event EventHandler ManagerIDChanged;

		/// <summary>
		/// Event which is thrown when Title changes value. Databinding related.
		/// </summary>
		public event EventHandler TitleChanged;

		/// <summary>
		/// Event which is thrown when BirthDate changes value. Databinding related.
		/// </summary>
		public event EventHandler BirthDateChanged;

		/// <summary>
		/// Event which is thrown when MaritalStatus changes value. Databinding related.
		/// </summary>
		public event EventHandler MaritalStatusChanged;

		/// <summary>
		/// Event which is thrown when Gender changes value. Databinding related.
		/// </summary>
		public event EventHandler GenderChanged;

		/// <summary>
		/// Event which is thrown when HireDate changes value. Databinding related.
		/// </summary>
		public event EventHandler HireDateChanged;

		/// <summary>
		/// Event which is thrown when SalariedFlag changes value. Databinding related.
		/// </summary>
		public event EventHandler SalariedFlagChanged;

		/// <summary>
		/// Event which is thrown when VacationHours changes value. Databinding related.
		/// </summary>
		public event EventHandler VacationHoursChanged;

		/// <summary>
		/// Event which is thrown when SickLeaveHours changes value. Databinding related.
		/// </summary>
		public event EventHandler SickLeaveHoursChanged;

		/// <summary>
		/// Event which is thrown when CurrentFlag changes value. Databinding related.
		/// </summary>
		public event EventHandler CurrentFlagChanged;

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
		public EmployeeEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new EmployeeEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		public EmployeeEntity(System.Int32 employeeID)
		{
			InitClassFetch(employeeID, new EmployeeValidator(), new PropertyDescriptorFactory(), new EmployeeEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(System.Int32 employeeID, EmployeeValidator validator)
		{
			InitClassFetch(employeeID, validator, new PropertyDescriptorFactory(), new EmployeeEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeEntity(System.Int32 employeeID, EmployeeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(employeeID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public EmployeeEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_employeeManagerID = (EmployeeCollection)info.GetValue("_employeeManagerID", typeof(EmployeeCollection));
			_alwaysFetchEmployeeManagerID = info.GetBoolean("_alwaysFetchEmployeeManagerID");
			_alreadyFetchedEmployeeManagerID = info.GetBoolean("_alreadyFetchedEmployeeManagerID");

			_employeeAddress = (EmployeeAddressCollection)info.GetValue("_employeeAddress", typeof(EmployeeAddressCollection));
			_alwaysFetchEmployeeAddress = info.GetBoolean("_alwaysFetchEmployeeAddress");
			_alreadyFetchedEmployeeAddress = info.GetBoolean("_alreadyFetchedEmployeeAddress");

			_employeeDepartmentHistory = (EmployeeDepartmentHistoryCollection)info.GetValue("_employeeDepartmentHistory", typeof(EmployeeDepartmentHistoryCollection));
			_alwaysFetchEmployeeDepartmentHistory = info.GetBoolean("_alwaysFetchEmployeeDepartmentHistory");
			_alreadyFetchedEmployeeDepartmentHistory = info.GetBoolean("_alreadyFetchedEmployeeDepartmentHistory");

			_employeePayHistory = (EmployeePayHistoryCollection)info.GetValue("_employeePayHistory", typeof(EmployeePayHistoryCollection));
			_alwaysFetchEmployeePayHistory = info.GetBoolean("_alwaysFetchEmployeePayHistory");
			_alreadyFetchedEmployeePayHistory = info.GetBoolean("_alreadyFetchedEmployeePayHistory");

			_jobCandidate = (JobCandidateCollection)info.GetValue("_jobCandidate", typeof(JobCandidateCollection));
			_alwaysFetchJobCandidate = info.GetBoolean("_alwaysFetchJobCandidate");
			_alreadyFetchedJobCandidate = info.GetBoolean("_alreadyFetchedJobCandidate");

			_purchaseOrderHeader = (PurchaseOrderHeaderCollection)info.GetValue("_purchaseOrderHeader", typeof(PurchaseOrderHeaderCollection));
			_alwaysFetchPurchaseOrderHeader = info.GetBoolean("_alwaysFetchPurchaseOrderHeader");
			_alreadyFetchedPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedPurchaseOrderHeader");

			_contact_ = (ContactCollection)info.GetValue("_contact_", typeof(ContactCollection));
			_alwaysFetchContact_ = info.GetBoolean("_alwaysFetchContact_");
			_alreadyFetchedContact_ = info.GetBoolean("_alreadyFetchedContact_");

			_address = (AddressCollection)info.GetValue("_address", typeof(AddressCollection));
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");

			_department = (DepartmentCollection)info.GetValue("_department", typeof(DepartmentCollection));
			_alwaysFetchDepartment = info.GetBoolean("_alwaysFetchDepartment");
			_alreadyFetchedDepartment = info.GetBoolean("_alreadyFetchedDepartment");

			_shift = (ShiftCollection)info.GetValue("_shift", typeof(ShiftCollection));
			_alwaysFetchShift = info.GetBoolean("_alwaysFetchShift");
			_alreadyFetchedShift = info.GetBoolean("_alreadyFetchedShift");

			_shipMethod = (ShipMethodCollection)info.GetValue("_shipMethod", typeof(ShipMethodCollection));
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

			_vendor = (VendorCollection)info.GetValue("_vendor", typeof(VendorCollection));
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");
			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				// rewire event handler.
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");
			_employeeEmployeeID = (EmployeeEntity)info.GetValue("_employeeEmployeeID", typeof(EmployeeEntity));
			if(_employeeEmployeeID!=null)
			{
				// rewire event handler.
				_employeeEmployeeID.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchEmployeeEmployeeID = info.GetBoolean("_alwaysFetchEmployeeEmployeeID");
			_alreadyFetchedEmployeeEmployeeID = info.GetBoolean("_alreadyFetchedEmployeeEmployeeID");
			_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
			if(_salesPerson!=null)
			{
				// rewire event handler.
				_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchSalesPerson = info.GetBoolean("_alwaysFetchSalesPerson");
			_alreadyFetchedSalesPerson = info.GetBoolean("_alreadyFetchedSalesPerson");
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
			_alreadyFetchedEmployeeManagerID = (_employeeManagerID.Count > 0);
			_alreadyFetchedEmployeeAddress = (_employeeAddress.Count > 0);
			_alreadyFetchedEmployeeDepartmentHistory = (_employeeDepartmentHistory.Count > 0);
			_alreadyFetchedEmployeePayHistory = (_employeePayHistory.Count > 0);
			_alreadyFetchedJobCandidate = (_jobCandidate.Count > 0);
			_alreadyFetchedPurchaseOrderHeader = (_purchaseOrderHeader.Count > 0);
			_alreadyFetchedContact_ = (_contact_.Count > 0);
			_alreadyFetchedAddress = (_address.Count > 0);
			_alreadyFetchedDepartment = (_department.Count > 0);
			_alreadyFetchedShift = (_shift.Count > 0);
			_alreadyFetchedShipMethod = (_shipMethod.Count > 0);
			_alreadyFetchedVendor = (_vendor.Count > 0);
			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedEmployeeEmployeeID = (_employeeEmployeeID != null);
			_alreadyFetchedSalesPerson = (_salesPerson != null);
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
			info.AddValue("_employeeManagerID", _employeeManagerID);
			info.AddValue("_alwaysFetchEmployeeManagerID", _alwaysFetchEmployeeManagerID);
			info.AddValue("_alreadyFetchedEmployeeManagerID", _alreadyFetchedEmployeeManagerID);
			info.AddValue("_employeeAddress", _employeeAddress);
			info.AddValue("_alwaysFetchEmployeeAddress", _alwaysFetchEmployeeAddress);
			info.AddValue("_alreadyFetchedEmployeeAddress", _alreadyFetchedEmployeeAddress);
			info.AddValue("_employeeDepartmentHistory", _employeeDepartmentHistory);
			info.AddValue("_alwaysFetchEmployeeDepartmentHistory", _alwaysFetchEmployeeDepartmentHistory);
			info.AddValue("_alreadyFetchedEmployeeDepartmentHistory", _alreadyFetchedEmployeeDepartmentHistory);
			info.AddValue("_employeePayHistory", _employeePayHistory);
			info.AddValue("_alwaysFetchEmployeePayHistory", _alwaysFetchEmployeePayHistory);
			info.AddValue("_alreadyFetchedEmployeePayHistory", _alreadyFetchedEmployeePayHistory);
			info.AddValue("_jobCandidate", _jobCandidate);
			info.AddValue("_alwaysFetchJobCandidate", _alwaysFetchJobCandidate);
			info.AddValue("_alreadyFetchedJobCandidate", _alreadyFetchedJobCandidate);
			info.AddValue("_purchaseOrderHeader", _purchaseOrderHeader);
			info.AddValue("_alwaysFetchPurchaseOrderHeader", _alwaysFetchPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedPurchaseOrderHeader", _alreadyFetchedPurchaseOrderHeader);
			info.AddValue("_contact_", _contact_);
			info.AddValue("_alwaysFetchContact_", _alwaysFetchContact_);
			info.AddValue("_alreadyFetchedContact_", _alreadyFetchedContact_);
			info.AddValue("_address", _address);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_department", _department);
			info.AddValue("_alwaysFetchDepartment", _alwaysFetchDepartment);
			info.AddValue("_alreadyFetchedDepartment", _alreadyFetchedDepartment);
			info.AddValue("_shift", _shift);
			info.AddValue("_alwaysFetchShift", _alwaysFetchShift);
			info.AddValue("_alreadyFetchedShift", _alreadyFetchedShift);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_vendor", _vendor);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);
			info.AddValue("_contact", _contact);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_employeeEmployeeID", _employeeEmployeeID);
			info.AddValue("_alwaysFetchEmployeeEmployeeID", _alwaysFetchEmployeeEmployeeID);
			info.AddValue("_alreadyFetchedEmployeeEmployeeID", _alreadyFetchedEmployeeEmployeeID);
			info.AddValue("_salesPerson", _salesPerson);
			info.AddValue("_alwaysFetchSalesPerson", _alwaysFetchSalesPerson);
			info.AddValue("_alreadyFetchedSalesPerson", _alreadyFetchedSalesPerson);
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
				case "Contact":
					SetupSyncContact(relatedEntity);
					break;
				case "EmployeeEmployeeID":
					SetupSyncEmployeeEmployeeID(relatedEntity);
					break;
				case "EmployeeManagerID":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_employeeManagerID.Add(relatedEntity);
					break;
				case "EmployeeAddress":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_employeeAddress.Add(relatedEntity);
					break;
				case "EmployeeDepartmentHistory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_employeeDepartmentHistory.Add(relatedEntity);
					break;
				case "EmployeePayHistory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_employeePayHistory.Add(relatedEntity);
					break;
				case "JobCandidate":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_jobCandidate.Add(relatedEntity);
					break;
				case "PurchaseOrderHeader":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_purchaseOrderHeader.Add(relatedEntity);
					break;
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
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
				case "Contact":
					DesetupSyncContact(false);
					break;
				case "EmployeeEmployeeID":
					DesetupSyncEmployeeEmployeeID(false);
					break;
				case "EmployeeManagerID":
					// Remove it from the collection.
					_employeeManagerID.Remove(relatedEntity);
					break;
				case "EmployeeAddress":
					// Remove it from the collection.
					_employeeAddress.Remove(relatedEntity);
					break;
				case "EmployeeDepartmentHistory":
					// Remove it from the collection.
					_employeeDepartmentHistory.Remove(relatedEntity);
					break;
				case "EmployeePayHistory":
					// Remove it from the collection.
					_employeePayHistory.Remove(relatedEntity);
					break;
				case "JobCandidate":
					// Remove it from the collection.
					_jobCandidate.Remove(relatedEntity);
					break;
				case "PurchaseOrderHeader":
					// Remove it from the collection.
					_purchaseOrderHeader.Remove(relatedEntity);
					break;
				case "SalesPerson":
					DesetupSyncSalesPerson(false);
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


			
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
			}
			
			
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
			if(_contact!=null)
			{
				toReturn.Add(_contact);
			}
			if(_employeeEmployeeID!=null)
			{
				toReturn.Add(_employeeEmployeeID);
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

			toReturn.Add(_employeeManagerID);
			toReturn.Add(_employeeAddress);
			toReturn.Add(_employeeDepartmentHistory);
			toReturn.Add(_employeePayHistory);
			toReturn.Add(_jobCandidate);
			toReturn.Add(_purchaseOrderHeader);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("EmployeeEntity");
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
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 employeeID)
		{
			return Fetch(employeeID);
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
			return Fetch(this.EmployeeID);
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			bool wasSuccesful = dao.DeleteEmployee(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(EmployeeFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public virtual EmployeeCollection GetMultiEmployeeManagerID(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployeeManagerID || forceFetch || _alwaysFetchEmployeeManagerID) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeManagerID.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeManagerID);
					}
				}
				_employeeManagerID.SuppressClearInGetMulti=!forceFetch;
				_employeeManagerID.GetMultiManyToOne(null, this);
				_employeeManagerID.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeManagerID = true;
			}
			return _employeeManagerID;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public virtual EmployeeCollection GetMultiEmployeeManagerID(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeManagerID || forceFetch || _alwaysFetchEmployeeManagerID) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeManagerID.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeManagerID);
					}
				}
				_employeeManagerID.SuppressClearInGetMulti=!forceFetch;
				_employeeManagerID.GetMultiManyToOne(null, this, filter);
				_employeeManagerID.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeManagerID = true;
			}
			return _employeeManagerID;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeCollection GetMultiEmployeeManagerID(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeManagerID || forceFetch || _alwaysFetchEmployeeManagerID) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeManagerID.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeManagerID);
					}
				}
				_employeeManagerID.SuppressClearInGetMulti=!forceFetch;
				_employeeManagerID.EntityFactoryToUse = entityFactoryToUse;
				_employeeManagerID.GetMultiManyToOne(null, this);
				_employeeManagerID.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeManagerID = true;
			}
			return _employeeManagerID;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeCollection GetMultiEmployeeManagerID(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeManagerID || forceFetch || _alwaysFetchEmployeeManagerID) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeManagerID.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeManagerID);
					}
				}
				_employeeManagerID.SuppressClearInGetMulti=!forceFetch;
				_employeeManagerID.EntityFactoryToUse = entityFactoryToUse;
				_employeeManagerID.GetMultiManyToOne(null, this, filter);
				_employeeManagerID.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeManagerID = true;
			}
			return _employeeManagerID;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'EmployeeManagerID'. These settings will be taken into account
		/// when the property EmployeeManagerID is requested or GetMultiEmployeeManagerID is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeManagerID(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeManagerID.SortClauses=sortClauses;
			_employeeManagerID.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_employeeAddress.GetMultiManyToOne(null, this);
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
				_employeeAddress.GetMultiManyToOne(null, this, filter);
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
				_employeeAddress.GetMultiManyToOne(null, this);
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
				_employeeAddress.GetMultiManyToOne(null, this, filter);
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
		/// Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeDepartmentHistoryEntity'</returns>
		public virtual EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployeeDepartmentHistory || forceFetch || _alwaysFetchEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeDepartmentHistory);
					}
				}
				_employeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				_employeeDepartmentHistory.GetMultiManyToOne(null, this, null);
				_employeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeDepartmentHistory = true;
			}
			return _employeeDepartmentHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeDepartmentHistoryEntity'</returns>
		public virtual EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeDepartmentHistory || forceFetch || _alwaysFetchEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeDepartmentHistory);
					}
				}
				_employeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				_employeeDepartmentHistory.GetMultiManyToOne(null, this, null, filter);
				_employeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeDepartmentHistory = true;
			}
			return _employeeDepartmentHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeeDepartmentHistory || forceFetch || _alwaysFetchEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeDepartmentHistory);
					}
				}
				_employeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				_employeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				_employeeDepartmentHistory.GetMultiManyToOne(null, this, null);
				_employeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeDepartmentHistory = true;
			}
			return _employeeDepartmentHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeDepartmentHistoryCollection GetMultiEmployeeDepartmentHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeeDepartmentHistory || forceFetch || _alwaysFetchEmployeeDepartmentHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeeDepartmentHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeeDepartmentHistory);
					}
				}
				_employeeDepartmentHistory.SuppressClearInGetMulti=!forceFetch;
				_employeeDepartmentHistory.EntityFactoryToUse = entityFactoryToUse;
				_employeeDepartmentHistory.GetMultiManyToOne(null, this, null, filter);
				_employeeDepartmentHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeeDepartmentHistory = true;
			}
			return _employeeDepartmentHistory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'EmployeeDepartmentHistory'. These settings will be taken into account
		/// when the property EmployeeDepartmentHistory is requested or GetMultiEmployeeDepartmentHistory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeeDepartmentHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeeDepartmentHistory.SortClauses=sortClauses;
			_employeeDepartmentHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeePayHistoryEntity'</returns>
		public virtual EmployeePayHistoryCollection GetMultiEmployeePayHistory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployeePayHistory || forceFetch || _alwaysFetchEmployeePayHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeePayHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeePayHistory);
					}
				}
				_employeePayHistory.SuppressClearInGetMulti=!forceFetch;
				_employeePayHistory.GetMultiManyToOne(this);
				_employeePayHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeePayHistory = true;
			}
			return _employeePayHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'EmployeePayHistoryEntity'</returns>
		public virtual EmployeePayHistoryCollection GetMultiEmployeePayHistory(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeePayHistory || forceFetch || _alwaysFetchEmployeePayHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeePayHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeePayHistory);
					}
				}
				_employeePayHistory.SuppressClearInGetMulti=!forceFetch;
				_employeePayHistory.GetMultiManyToOne(this, filter);
				_employeePayHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeePayHistory = true;
			}
			return _employeePayHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeePayHistoryCollection GetMultiEmployeePayHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployeePayHistory || forceFetch || _alwaysFetchEmployeePayHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeePayHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeePayHistory);
					}
				}
				_employeePayHistory.SuppressClearInGetMulti=!forceFetch;
				_employeePayHistory.EntityFactoryToUse = entityFactoryToUse;
				_employeePayHistory.GetMultiManyToOne(this);
				_employeePayHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeePayHistory = true;
			}
			return _employeePayHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeePayHistoryCollection GetMultiEmployeePayHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedEmployeePayHistory || forceFetch || _alwaysFetchEmployeePayHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employeePayHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employeePayHistory);
					}
				}
				_employeePayHistory.SuppressClearInGetMulti=!forceFetch;
				_employeePayHistory.EntityFactoryToUse = entityFactoryToUse;
				_employeePayHistory.GetMultiManyToOne(this, filter);
				_employeePayHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployeePayHistory = true;
			}
			return _employeePayHistory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'EmployeePayHistory'. These settings will be taken into account
		/// when the property EmployeePayHistory is requested or GetMultiEmployeePayHistory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployeePayHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employeePayHistory.SortClauses=sortClauses;
			_employeePayHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'JobCandidateEntity'</returns>
		public virtual JobCandidateCollection GetMultiJobCandidate(bool forceFetch)
		{
 			if( ( !_alreadyFetchedJobCandidate || forceFetch || _alwaysFetchJobCandidate) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_jobCandidate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_jobCandidate);
					}
				}
				_jobCandidate.SuppressClearInGetMulti=!forceFetch;
				_jobCandidate.GetMultiManyToOne(this);
				_jobCandidate.SuppressClearInGetMulti=false;
				_alreadyFetchedJobCandidate = true;
			}
			return _jobCandidate;
		}


		/// <summary>
		/// Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'JobCandidateEntity'</returns>
		public virtual JobCandidateCollection GetMultiJobCandidate(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedJobCandidate || forceFetch || _alwaysFetchJobCandidate) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_jobCandidate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_jobCandidate);
					}
				}
				_jobCandidate.SuppressClearInGetMulti=!forceFetch;
				_jobCandidate.GetMultiManyToOne(this, filter);
				_jobCandidate.SuppressClearInGetMulti=false;
				_alreadyFetchedJobCandidate = true;
			}
			return _jobCandidate;
		}


		/// <summary>
		/// Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual JobCandidateCollection GetMultiJobCandidate(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedJobCandidate || forceFetch || _alwaysFetchJobCandidate) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_jobCandidate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_jobCandidate);
					}
				}
				_jobCandidate.SuppressClearInGetMulti=!forceFetch;
				_jobCandidate.EntityFactoryToUse = entityFactoryToUse;
				_jobCandidate.GetMultiManyToOne(this);
				_jobCandidate.SuppressClearInGetMulti=false;
				_alreadyFetchedJobCandidate = true;
			}
			return _jobCandidate;
		}


		/// <summary>
		/// Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual JobCandidateCollection GetMultiJobCandidate(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedJobCandidate || forceFetch || _alwaysFetchJobCandidate) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_jobCandidate.ParticipatesInTransaction)
					{
						base.Transaction.Add(_jobCandidate);
					}
				}
				_jobCandidate.SuppressClearInGetMulti=!forceFetch;
				_jobCandidate.EntityFactoryToUse = entityFactoryToUse;
				_jobCandidate.GetMultiManyToOne(this, filter);
				_jobCandidate.SuppressClearInGetMulti=false;
				_alreadyFetchedJobCandidate = true;
			}
			return _jobCandidate;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'JobCandidate'. These settings will be taken into account
		/// when the property JobCandidate is requested or GetMultiJobCandidate is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersJobCandidate(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_jobCandidate.SortClauses=sortClauses;
			_jobCandidate.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public virtual PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeader.GetMultiManyToOne(this, null, null);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public virtual PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeader.GetMultiManyToOne(this, null, null, filter);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderHeader.GetMultiManyToOne(this, null, null);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderHeader.GetMultiManyToOne(this, null, null, filter);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'PurchaseOrderHeader'. These settings will be taken into account
		/// when the property PurchaseOrderHeader is requested or GetMultiPurchaseOrderHeader is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderHeader.SortClauses=sortClauses;
			_purchaseOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public virtual ContactCollection GetMultiContact_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContact_ || forceFetch || _alwaysFetchContact_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contact_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contact_);
					}
				}
				_contact_.SuppressClearInGetMulti=!forceFetch;
				_contact_.GetMultiManyToManyUsingEmployee_(this);
				_contact_.SuppressClearInGetMulti=false;
				_alreadyFetchedContact_ = true;
			}
			return _contact_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactCollection GetMultiContact_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContact_ || forceFetch || _alwaysFetchContact_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contact_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contact_);
					}
				}
				_contact_.SuppressClearInGetMulti=!forceFetch;
				_contact_.EntityFactoryToUse = entityFactoryToUse;
				_contact_.GetMultiManyToManyUsingEmployee_(this);
				_contact_.SuppressClearInGetMulti=false;
				_alreadyFetchedContact_ = true;
			}
			return _contact_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Contact_'. These settings will be taken into account
		/// when the property Contact_ is requested or GetMultiContact_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContact_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contact_.SortClauses=sortClauses;
			_contact_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_address.GetMultiManyToManyUsingEmployee(this);
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
				_address.GetMultiManyToManyUsingEmployee(this);
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
		/// Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DepartmentEntity'</returns>
		public virtual DepartmentCollection GetMultiDepartment(bool forceFetch)
		{
 			if( ( !_alreadyFetchedDepartment || forceFetch || _alwaysFetchDepartment) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_department.ParticipatesInTransaction)
					{
						base.Transaction.Add(_department);
					}
				}
				_department.SuppressClearInGetMulti=!forceFetch;
				_department.GetMultiManyToManyUsingEmployee(this);
				_department.SuppressClearInGetMulti=false;
				_alreadyFetchedDepartment = true;
			}
			return _department;
		}


		/// <summary>
		/// Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual DepartmentCollection GetMultiDepartment(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDepartment || forceFetch || _alwaysFetchDepartment) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_department.ParticipatesInTransaction)
					{
						base.Transaction.Add(_department);
					}
				}
				_department.SuppressClearInGetMulti=!forceFetch;
				_department.EntityFactoryToUse = entityFactoryToUse;
				_department.GetMultiManyToManyUsingEmployee(this);
				_department.SuppressClearInGetMulti=false;
				_alreadyFetchedDepartment = true;
			}
			return _department;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Department'. These settings will be taken into account
		/// when the property Department is requested or GetMultiDepartment is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDepartment(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_department.SortClauses=sortClauses;
			_department.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShiftEntity'</returns>
		public virtual ShiftCollection GetMultiShift(bool forceFetch)
		{
 			if( ( !_alreadyFetchedShift || forceFetch || _alwaysFetchShift) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shift.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shift);
					}
				}
				_shift.SuppressClearInGetMulti=!forceFetch;
				_shift.GetMultiManyToManyUsingEmployee(this);
				_shift.SuppressClearInGetMulti=false;
				_alreadyFetchedShift = true;
			}
			return _shift;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ShiftCollection GetMultiShift(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShift || forceFetch || _alwaysFetchShift) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shift.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shift);
					}
				}
				_shift.SuppressClearInGetMulti=!forceFetch;
				_shift.EntityFactoryToUse = entityFactoryToUse;
				_shift.GetMultiManyToManyUsingEmployee(this);
				_shift.SuppressClearInGetMulti=false;
				_alreadyFetchedShift = true;
			}
			return _shift;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Shift'. These settings will be taken into account
		/// when the property Shift is requested or GetMultiShift is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShift(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shift.SortClauses=sortClauses;
			_shift.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_shipMethod.GetMultiManyToManyUsingEmployee(this);
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
				_shipMethod.GetMultiManyToManyUsingEmployee(this);
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
				_vendor.GetMultiManyToManyUsingEmployee(this);
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
				_vendor.GetMultiManyToManyUsingEmployee(this);
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
		/// Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public virtual ContactEntity GetSingleContact()
		{
			return GetSingleContact(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public virtual ContactEntity GetSingleContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ContactEntity newEntity = new ContactEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ContactID);
				this.Contact = newEntity;

				_alreadyFetchedContact = true;
			}
			return _contact;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployeeEmployeeID()
		{
			return GetSingleEmployeeEmployeeID(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'EmployeeEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'EmployeeEntity' which is related to this entity.</returns>
		public virtual EmployeeEntity GetSingleEmployeeEmployeeID(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployeeEmployeeID || forceFetch || _alwaysFetchEmployeeEmployeeID) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				EmployeeEntity newEntity = new EmployeeEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ManagerID);
				this.EmployeeEmployeeID = newEntity;

				_alreadyFetchedEmployeeEmployeeID = true;
			}
			return _employeeEmployeeID;
		}
	
	
		/// <summary>
		/// Retrieves the related entity of type 'SalesPersonEntity', using a relation of type '1:1'
		/// </summary>
		/// <returns>A fetched entity of type 'SalesPersonEntity' which is related to this entity.</returns>
		public virtual SalesPersonEntity GetSingleSalesPerson()
		{
			return GetSingleSalesPerson(false);
		}
		
		
		/// <summary>
		/// Retrieves the related entity of type 'SalesPersonEntity', using a relation of type '1:1'
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
				
				// fetch using PK
				newEntity.FetchUsingPK(this.EmployeeID);
				
				
				
				this.SalesPerson = newEntity;

				_alreadyFetchedSalesPerson = true;
			}
			return _salesPerson;
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
		/// Event thrower for the NationalIDNumberChanged event, which is thrown when NationalIDNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnNationalIDNumberChanged()
		{
			if(NationalIDNumberChanged!=null)
			{
				NationalIDNumberChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ContactIDChanged event, which is thrown when ContactID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnContactIDChanged()
		{
			if(ContactIDChanged!=null)
			{
				ContactIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the LoginIDChanged event, which is thrown when LoginID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnLoginIDChanged()
		{
			if(LoginIDChanged!=null)
			{
				LoginIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ManagerIDChanged event, which is thrown when ManagerID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnManagerIDChanged()
		{
			if(ManagerIDChanged!=null)
			{
				ManagerIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the TitleChanged event, which is thrown when Title changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTitleChanged()
		{
			if(TitleChanged!=null)
			{
				TitleChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the BirthDateChanged event, which is thrown when BirthDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnBirthDateChanged()
		{
			if(BirthDateChanged!=null)
			{
				BirthDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the MaritalStatusChanged event, which is thrown when MaritalStatus changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnMaritalStatusChanged()
		{
			if(MaritalStatusChanged!=null)
			{
				MaritalStatusChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the GenderChanged event, which is thrown when Gender changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnGenderChanged()
		{
			if(GenderChanged!=null)
			{
				GenderChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the HireDateChanged event, which is thrown when HireDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnHireDateChanged()
		{
			if(HireDateChanged!=null)
			{
				HireDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SalariedFlagChanged event, which is thrown when SalariedFlag changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSalariedFlagChanged()
		{
			if(SalariedFlagChanged!=null)
			{
				SalariedFlagChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the VacationHoursChanged event, which is thrown when VacationHours changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnVacationHoursChanged()
		{
			if(VacationHoursChanged!=null)
			{
				VacationHoursChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SickLeaveHoursChanged event, which is thrown when SickLeaveHours changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSickLeaveHoursChanged()
		{
			if(SickLeaveHoursChanged!=null)
			{
				SickLeaveHoursChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CurrentFlagChanged event, which is thrown when CurrentFlag changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCurrentFlagChanged()
		{
			if(CurrentFlagChanged!=null)
			{
				CurrentFlagChanged(this, new EventArgs());
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
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.AddEmployee(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.UpdateEmployee(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();
			return dao.UpdateEmployee(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.EmployeeEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new EmployeeValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
		private void InitClassFetch(System.Int32 employeeID, EmployeeValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.EmployeeEntity);
			bool wasSuccesful = Fetch(employeeID);
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
			_employeeManagerID = new EmployeeCollection(propertyDescriptorFactoryToUse, new EmployeeEntityFactory());
			_employeeManagerID.SetContainingEntityInfo(this, "EmployeeEmployeeID");
			_alwaysFetchEmployeeManagerID = false;
			_alreadyFetchedEmployeeManagerID = false;
			_employeeAddress = new EmployeeAddressCollection(propertyDescriptorFactoryToUse, new EmployeeAddressEntityFactory());
			_employeeAddress.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchEmployeeAddress = false;
			_alreadyFetchedEmployeeAddress = false;
			_employeeDepartmentHistory = new EmployeeDepartmentHistoryCollection(propertyDescriptorFactoryToUse, new EmployeeDepartmentHistoryEntityFactory());
			_employeeDepartmentHistory.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchEmployeeDepartmentHistory = false;
			_alreadyFetchedEmployeeDepartmentHistory = false;
			_employeePayHistory = new EmployeePayHistoryCollection(propertyDescriptorFactoryToUse, new EmployeePayHistoryEntityFactory());
			_employeePayHistory.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchEmployeePayHistory = false;
			_alreadyFetchedEmployeePayHistory = false;
			_jobCandidate = new JobCandidateCollection(propertyDescriptorFactoryToUse, new JobCandidateEntityFactory());
			_jobCandidate.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchJobCandidate = false;
			_alreadyFetchedJobCandidate = false;
			_purchaseOrderHeader = new PurchaseOrderHeaderCollection(propertyDescriptorFactoryToUse, new PurchaseOrderHeaderEntityFactory());
			_purchaseOrderHeader.SetContainingEntityInfo(this, "Employee");
			_alwaysFetchPurchaseOrderHeader = false;
			_alreadyFetchedPurchaseOrderHeader = false;
			_contact_ = new ContactCollection(propertyDescriptorFactoryToUse, new ContactEntityFactory());
			_alwaysFetchContact_ = false;
			_alreadyFetchedContact_ = false;
			_address = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_department = new DepartmentCollection(propertyDescriptorFactoryToUse, new DepartmentEntityFactory());
			_alwaysFetchDepartment = false;
			_alreadyFetchedDepartment = false;
			_shift = new ShiftCollection(propertyDescriptorFactoryToUse, new ShiftEntityFactory());
			_alwaysFetchShift = false;
			_alreadyFetchedShift = false;
			_shipMethod = new ShipMethodCollection(propertyDescriptorFactoryToUse, new ShipMethodEntityFactory());
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_vendor = new VendorCollection(propertyDescriptorFactoryToUse, new VendorEntityFactory());
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;
			_contact = null;
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_employeeEmployeeID = null;
			_alwaysFetchEmployeeEmployeeID = false;
			_alreadyFetchedEmployeeEmployeeID = false;
			_salesPerson = null;
			_alwaysFetchSalesPerson = false;
			_alreadyFetchedSalesPerson = false;
		}


		/// <summary>
		/// Removes the sync logic for member _contact
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncContact(bool signalRelatedEntity)
		{
			if(_contact != null)
			{
				// disconnect the entity from this entity
				_contact.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_contact.UnsetRelatedEntity(this, "Employee");
				}
				base.UnsetEntitySyncInformation("Contact", _contact, EmployeeEntity.Relations.ContactEntityUsingContactID);
				_contact = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _contact
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntity relatedEntity)
		{
			DesetupSyncContact(true);
			
			if(relatedEntity!=null)
			{
				_contact = (ContactEntity)relatedEntity;
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Contact", _contact, EmployeeEntity.Relations.ContactEntityUsingContactID);
				if(!_contact.IsNew)
				{
					// sync now
					base.SyncFKFields(EmployeeEntity.Relations.ContactEntityUsingContactID, _contact);
				}
			}

			_alreadyFetchedContact = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _employeeEmployeeID
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncEmployeeEmployeeID(bool signalRelatedEntity)
		{
			if(_employeeEmployeeID != null)
			{
				// disconnect the entity from this entity
				_employeeEmployeeID.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_employeeEmployeeID.UnsetRelatedEntity(this, "EmployeeManagerID");
				}
				base.UnsetEntitySyncInformation("EmployeeEmployeeID", _employeeEmployeeID, EmployeeEntity.Relations.EmployeeEntityUsingManagerID);
				_employeeEmployeeID = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _employeeEmployeeID
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployeeEmployeeID(IEntity relatedEntity)
		{
			DesetupSyncEmployeeEmployeeID(true);
			
			if(relatedEntity!=null)
			{
				_employeeEmployeeID = (EmployeeEntity)relatedEntity;
				_employeeEmployeeID.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("EmployeeEmployeeID", _employeeEmployeeID, EmployeeEntity.Relations.EmployeeEntityUsingManagerID);
				if(!_employeeEmployeeID.IsNew)
				{
					// sync now
					base.SyncFKFields(EmployeeEntity.Relations.EmployeeEntityUsingManagerID, _employeeEmployeeID);
				}
			}

			_alreadyFetchedEmployeeEmployeeID = (relatedEntity != null);
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
				if(signalRelatedEntity)
				{
					_salesPerson.UnsetRelatedEntity(this, "Employee");
				}


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
				


			}

			_alreadyFetchedSalesPerson = (relatedEntity != null);
		}


	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="employeeID">PK value for Employee which data should be fetched into this Employee object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 employeeID)
		{
			EmployeeDAO dao = DAOFactory.CreateEmployeeDAO();

			// Load EntityFields of Employee
			dao.FetchEmployee(base.Fields, base.Transaction, employeeID);

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
		public static EmployeeRelations Relations
		{
			get	{ return new EmployeeRelations(); }
		}

	
		/// <summary>
		/// The EmployeeID property of the Entity Employee
		/// </summary>
		public virtual System.Int32 EmployeeID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.EmployeeID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EmployeeID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.EmployeeID, value))
				{
					OnEmployeeIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The NationalIDNumber property of the Entity Employee
		/// </summary>
		public virtual System.String NationalIDNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.NationalIDNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for NationalIDNumber because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.NationalIDNumber, value))
				{
					OnNationalIDNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The ContactID property of the Entity Employee
		/// </summary>
		public virtual System.Int32 ContactID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.ContactID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ContactID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.ContactID, value))
				{
					OnContactIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The LoginID property of the Entity Employee
		/// </summary>
		public virtual System.String LoginID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.LoginID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for LoginID because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.LoginID, value))
				{
					OnLoginIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ManagerID property of the Entity Employee
		/// </summary>
		public virtual System.Int32 ManagerID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.ManagerID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ManagerID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.ManagerID, value))
				{
					OnManagerIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Title property of the Entity Employee
		/// </summary>
		public virtual System.String Title
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.Title);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Title because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.Title, value))
				{
					OnTitleChanged();
				}
			}
		}
	
		/// <summary>
		/// The BirthDate property of the Entity Employee
		/// </summary>
		public virtual System.DateTime BirthDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.BirthDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for BirthDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.BirthDate, value))
				{
					OnBirthDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The MaritalStatus property of the Entity Employee
		/// </summary>
		public virtual System.String MaritalStatus
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.MaritalStatus);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for MaritalStatus because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.MaritalStatus, value))
				{
					OnMaritalStatusChanged();
				}
			}
		}
	
		/// <summary>
		/// The Gender property of the Entity Employee
		/// </summary>
		public virtual System.String Gender
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.Gender);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Gender because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.Gender, value))
				{
					OnGenderChanged();
				}
			}
		}
	
		/// <summary>
		/// The HireDate property of the Entity Employee
		/// </summary>
		public virtual System.DateTime HireDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.HireDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for HireDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.HireDate, value))
				{
					OnHireDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The SalariedFlag property of the Entity Employee
		/// </summary>
		public virtual System.Boolean SalariedFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.SalariedFlag);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SalariedFlag because it is set to NULL.");
				}
				return (System.Boolean)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.SalariedFlag, value))
				{
					OnSalariedFlagChanged();
				}
			}
		}
	
		/// <summary>
		/// The VacationHours property of the Entity Employee
		/// </summary>
		public virtual System.Int16 VacationHours
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.VacationHours);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for VacationHours because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.VacationHours, value))
				{
					OnVacationHoursChanged();
				}
			}
		}
	
		/// <summary>
		/// The SickLeaveHours property of the Entity Employee
		/// </summary>
		public virtual System.Int16 SickLeaveHours
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.SickLeaveHours);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SickLeaveHours because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.SickLeaveHours, value))
				{
					OnSickLeaveHoursChanged();
				}
			}
		}
	
		/// <summary>
		/// The CurrentFlag property of the Entity Employee
		/// </summary>
		public virtual System.Boolean CurrentFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.CurrentFlag);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CurrentFlag because it is set to NULL.");
				}
				return (System.Boolean)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.CurrentFlag, value))
				{
					OnCurrentFlagChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity Employee
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity Employee
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)EmployeeFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)EmployeeFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeManagerID()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual EmployeeCollection EmployeeManagerID
		{
			get
			{
				return GetMultiEmployeeManagerID(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for EmployeeManagerID. When set to true, EmployeeManagerID is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeManagerID is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeManagerID(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeManagerID
		{
			get
			{
				return _alwaysFetchEmployeeManagerID;
			}
			set
			{
				_alwaysFetchEmployeeManagerID = value;
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
		/// Retrieves all related entities of type 'EmployeeDepartmentHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeeDepartmentHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual EmployeeDepartmentHistoryCollection EmployeeDepartmentHistory
		{
			get
			{
				return GetMultiEmployeeDepartmentHistory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for EmployeeDepartmentHistory. When set to true, EmployeeDepartmentHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeDepartmentHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeeDepartmentHistory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeDepartmentHistory
		{
			get
			{
				return _alwaysFetchEmployeeDepartmentHistory;
			}
			set
			{
				_alwaysFetchEmployeeDepartmentHistory = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeePayHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployeePayHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual EmployeePayHistoryCollection EmployeePayHistory
		{
			get
			{
				return GetMultiEmployeePayHistory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for EmployeePayHistory. When set to true, EmployeePayHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeePayHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployeePayHistory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeePayHistory
		{
			get
			{
				return _alwaysFetchEmployeePayHistory;
			}
			set
			{
				_alwaysFetchEmployeePayHistory = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'JobCandidateEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiJobCandidate()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual JobCandidateCollection JobCandidate
		{
			get
			{
				return GetMultiJobCandidate(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for JobCandidate. When set to true, JobCandidate is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time JobCandidate is accessed. You can always execute
		/// a forced fetch by calling GetMultiJobCandidate(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchJobCandidate
		{
			get
			{
				return _alwaysFetchJobCandidate;
			}
			set
			{
				_alwaysFetchJobCandidate = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual PurchaseOrderHeaderCollection PurchaseOrderHeader
		{
			get
			{
				return GetMultiPurchaseOrderHeader(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for PurchaseOrderHeader. When set to true, PurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderHeader(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeader
		{
			get
			{
				return _alwaysFetchPurchaseOrderHeader;
			}
			set
			{
				_alwaysFetchPurchaseOrderHeader = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContact_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ContactCollection Contact_
		{
			get
			{
				return GetMultiContact_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Contact_. When set to true, Contact_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiContact_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContact_
		{
			get
			{
				return _alwaysFetchContact_;
			}
			set
			{
				_alwaysFetchContact_ = value;
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
		/// Retrieves all related entities of type 'DepartmentEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDepartment()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual DepartmentCollection Department
		{
			get
			{
				return GetMultiDepartment(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Department. When set to true, Department is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Department is accessed. You can always execute
		/// a forced fetch by calling GetMultiDepartment(true).
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
		/// Retrieves all related entities of type 'ShiftEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShift()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ShiftCollection Shift
		{
			get
			{
				return GetMultiShift(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Shift. When set to true, Shift is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Shift is accessed. You can always execute
		/// a forced fetch by calling GetMultiShift(true).
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
		/// Gets / sets related entity of type 'ContactEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ContactEntity Contact
		{
			get
			{
				return GetSingleContact(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncContact(value);
				}
				else
				{
					if(value==null)
					{
						if(_contact != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_contact.UnsetRelatedEntity(this, "Employee");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "Employee");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute
		/// a forced fetch by calling GetSingleContact(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContact
		{
			get
			{
				return _alwaysFetchContact;
			}
			set
			{
				_alwaysFetchContact = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'EmployeeEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleEmployeeEmployeeID()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual EmployeeEntity EmployeeEmployeeID
		{
			get
			{
				return GetSingleEmployeeEmployeeID(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncEmployeeEmployeeID(value);
				}
				else
				{
					if(value==null)
					{
						if(_employeeEmployeeID != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_employeeEmployeeID.UnsetRelatedEntity(this, "EmployeeManagerID");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "EmployeeManagerID");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for EmployeeEmployeeID. When set to true, EmployeeEmployeeID is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time EmployeeEmployeeID is accessed. You can always execute
		/// a forced fetch by calling GetSingleEmployeeEmployeeID(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployeeEmployeeID
		{
			get
			{
				return _alwaysFetchEmployeeEmployeeID;
			}
			set
			{
				_alwaysFetchEmployeeEmployeeID = value;
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
						// unset the sync info with the old value set for SalesPerson. because we specify 'true', this will 
						// result in the signaling of the current value of SalesPerson that the sync info has ended, as well.
						DesetupSyncSalesPerson(true);
					}
					else
					{
						// Tell related entity its related to us.
						IEntity relatedEntity = (IEntity)value;
						relatedEntity.SetRelatedEntity(this, "Employee");
						// set up syncing information to this new entity. Will take care of current entity.
						SetupSyncSalesPerson(relatedEntity);
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
	
		#endregion
	}
}
