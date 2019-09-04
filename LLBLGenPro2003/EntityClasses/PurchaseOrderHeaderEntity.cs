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
	/// Entity class which represents the entity 'PurchaseOrderHeader' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class PurchaseOrderHeaderEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private PurchaseOrderDetailCollection	_purchaseOrderDetail;
		private bool	_alwaysFetchPurchaseOrderDetail, _alreadyFetchedPurchaseOrderDetail;
		private ProductCollection _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private EmployeeEntity _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee;
		private ShipMethodEntity _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;
		private VendorEntity _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when PurchaseOrderID changes value. Databinding related.
		/// </summary>
		public event EventHandler PurchaseOrderIDChanged;

		/// <summary>
		/// Event which is thrown when RevisionNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler RevisionNumberChanged;

		/// <summary>
		/// Event which is thrown when Status changes value. Databinding related.
		/// </summary>
		public event EventHandler StatusChanged;

		/// <summary>
		/// Event which is thrown when EmployeeID changes value. Databinding related.
		/// </summary>
		public event EventHandler EmployeeIDChanged;

		/// <summary>
		/// Event which is thrown when VendorID changes value. Databinding related.
		/// </summary>
		public event EventHandler VendorIDChanged;

		/// <summary>
		/// Event which is thrown when ShipMethodID changes value. Databinding related.
		/// </summary>
		public event EventHandler ShipMethodIDChanged;

		/// <summary>
		/// Event which is thrown when OrderDate changes value. Databinding related.
		/// </summary>
		public event EventHandler OrderDateChanged;

		/// <summary>
		/// Event which is thrown when ShipDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ShipDateChanged;

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
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public PurchaseOrderHeaderEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new PurchaseOrderHeaderEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID)
		{
			InitClassFetch(purchaseOrderID, new PurchaseOrderHeaderValidator(), new PropertyDescriptorFactory(), new PurchaseOrderHeaderEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderHeaderEntity</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID, PurchaseOrderHeaderValidator validator)
		{
			InitClassFetch(purchaseOrderID, validator, new PropertyDescriptorFactory(), new PurchaseOrderHeaderEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderHeaderEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderID, PurchaseOrderHeaderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(purchaseOrderID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public PurchaseOrderHeaderEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private PurchaseOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_purchaseOrderDetail = (PurchaseOrderDetailCollection)info.GetValue("_purchaseOrderDetail", typeof(PurchaseOrderDetailCollection));
			_alwaysFetchPurchaseOrderDetail = info.GetBoolean("_alwaysFetchPurchaseOrderDetail");
			_alreadyFetchedPurchaseOrderDetail = info.GetBoolean("_alreadyFetchedPurchaseOrderDetail");

			_product = (ProductCollection)info.GetValue("_product", typeof(ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
			if(_employee!=null)
			{
				// rewire event handler.
				_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");
			_shipMethod = (ShipMethodEntity)info.GetValue("_shipMethod", typeof(ShipMethodEntity));
			if(_shipMethod!=null)
			{
				// rewire event handler.
				_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");
			_vendor = (VendorEntity)info.GetValue("_vendor", typeof(VendorEntity));
			if(_vendor!=null)
			{
				// rewire event handler.
				_vendor.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");

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
			_alreadyFetchedPurchaseOrderDetail = (_purchaseOrderDetail.Count > 0);
			_alreadyFetchedProduct = (_product.Count > 0);
			_alreadyFetchedEmployee = (_employee != null);
			_alreadyFetchedShipMethod = (_shipMethod != null);
			_alreadyFetchedVendor = (_vendor != null);

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
			info.AddValue("_purchaseOrderDetail", _purchaseOrderDetail);
			info.AddValue("_alwaysFetchPurchaseOrderDetail", _alwaysFetchPurchaseOrderDetail);
			info.AddValue("_alreadyFetchedPurchaseOrderDetail", _alreadyFetchedPurchaseOrderDetail);
			info.AddValue("_product", _product);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_employee", _employee);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_vendor", _vendor);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);

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
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
					break;
				case "PurchaseOrderDetail":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_purchaseOrderDetail.Add(relatedEntity);
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
				case "Employee":
					DesetupSyncEmployee(false);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false);
					break;
				case "Vendor":
					DesetupSyncVendor(false);
					break;
				case "PurchaseOrderDetail":
					// Remove it from the collection.
					_purchaseOrderDetail.Remove(relatedEntity);
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
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_shipMethod!=null)
			{
				toReturn.Add(_shipMethod);
			}
			if(_vendor!=null)
			{
				toReturn.Add(_vendor);
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

			toReturn.Add(_purchaseOrderDetail);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("PurchaseOrderHeaderEntity");
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
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID)
		{
			return Fetch(purchaseOrderID);
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
			return Fetch(this.PurchaseOrderID);
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
			PurchaseOrderHeaderDAO dao = DAOFactory.CreatePurchaseOrderHeaderDAO();
			bool wasSuccesful = dao.DeletePurchaseOrderHeader(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(PurchaseOrderHeaderFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public virtual PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetail.GetMultiManyToOne(null, this);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public virtual PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetail.GetMultiManyToOne(null, this, filter);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderDetail.GetMultiManyToOne(null, this);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderDetail.GetMultiManyToOne(null, this, filter);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'PurchaseOrderDetail'. These settings will be taken into account
		/// when the property PurchaseOrderDetail is requested or GetMultiPurchaseOrderDetail is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderDetail.SortClauses=sortClauses;
			_purchaseOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public virtual ProductCollection GetMultiProduct(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product);
					}
				}
				_product.SuppressClearInGetMulti=!forceFetch;
				_product.GetMultiManyToManyUsingPurchaseOrderHeader(this);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCollection GetMultiProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product);
					}
				}
				_product.SuppressClearInGetMulti=!forceFetch;
				_product.EntityFactoryToUse = entityFactoryToUse;
				_product.GetMultiManyToManyUsingPurchaseOrderHeader(this);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Product'. These settings will be taken into account
		/// when the property Product is requested or GetMultiProduct is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product.SortClauses=sortClauses;
			_product.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
	
		/// <summary>
		/// Retrieves the related entity of type 'VendorEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'VendorEntity' which is related to this entity.</returns>
		public virtual VendorEntity GetSingleVendor()
		{
			return GetSingleVendor(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'VendorEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'VendorEntity' which is related to this entity.</returns>
		public virtual VendorEntity GetSingleVendor(bool forceFetch)
		{
 			if( ( !_alreadyFetchedVendor || forceFetch || _alwaysFetchVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				VendorEntity newEntity = new VendorEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.VendorID);
				this.Vendor = newEntity;

				_alreadyFetchedVendor = true;
			}
			return _vendor;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the PurchaseOrderIDChanged event, which is thrown when PurchaseOrderID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPurchaseOrderIDChanged()
		{
			if(PurchaseOrderIDChanged!=null)
			{
				PurchaseOrderIDChanged(this, new EventArgs());
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
		/// Event thrower for the VendorIDChanged event, which is thrown when VendorID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnVendorIDChanged()
		{
			if(VendorIDChanged!=null)
			{
				VendorIDChanged(this, new EventArgs());
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
			PurchaseOrderHeaderDAO dao = DAOFactory.CreatePurchaseOrderHeaderDAO();
			return dao.AddPurchaseOrderHeader(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			PurchaseOrderHeaderDAO dao = DAOFactory.CreatePurchaseOrderHeaderDAO();
			return dao.UpdatePurchaseOrderHeader(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			PurchaseOrderHeaderDAO dao = DAOFactory.CreatePurchaseOrderHeaderDAO();
			return dao.UpdatePurchaseOrderHeader(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.PurchaseOrderHeaderEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new PurchaseOrderHeaderValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this PurchaseOrderHeaderEntity</param>
		private void InitClassFetch(System.Int32 purchaseOrderID, PurchaseOrderHeaderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.PurchaseOrderHeaderEntity);
			bool wasSuccesful = Fetch(purchaseOrderID);
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
			_purchaseOrderDetail = new PurchaseOrderDetailCollection(propertyDescriptorFactoryToUse, new PurchaseOrderDetailEntityFactory());
			_purchaseOrderDetail.SetContainingEntityInfo(this, "PurchaseOrderHeader");
			_alwaysFetchPurchaseOrderDetail = false;
			_alreadyFetchedPurchaseOrderDetail = false;
			_product = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_employee = null;
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_shipMethod = null;
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_vendor = null;
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;

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
					_employee.UnsetRelatedEntity(this, "PurchaseOrderHeader");
				}
				base.UnsetEntitySyncInformation("Employee", _employee, PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeID);
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
				base.SetEntitySyncInformation("Employee", _employee, PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeID);
				if(!_employee.IsNew)
				{
					// sync now
					base.SyncFKFields(PurchaseOrderHeaderEntity.Relations.EmployeeEntityUsingEmployeeID, _employee);
				}
			}

			_alreadyFetchedEmployee = (relatedEntity != null);
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
					_shipMethod.UnsetRelatedEntity(this, "PurchaseOrderHeader");
				}
				base.UnsetEntitySyncInformation("ShipMethod", _shipMethod, PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID);
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
				base.SetEntitySyncInformation("ShipMethod", _shipMethod, PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID);
				if(!_shipMethod.IsNew)
				{
					// sync now
					base.SyncFKFields(PurchaseOrderHeaderEntity.Relations.ShipMethodEntityUsingShipMethodID, _shipMethod);
				}
			}

			_alreadyFetchedShipMethod = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _vendor
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncVendor(bool signalRelatedEntity)
		{
			if(_vendor != null)
			{
				// disconnect the entity from this entity
				_vendor.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_vendor.UnsetRelatedEntity(this, "PurchaseOrderHeader");
				}
				base.UnsetEntitySyncInformation("Vendor", _vendor, PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorID);
				_vendor = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _vendor
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVendor(IEntity relatedEntity)
		{
			DesetupSyncVendor(true);
			
			if(relatedEntity!=null)
			{
				_vendor = (VendorEntity)relatedEntity;
				_vendor.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Vendor", _vendor, PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorID);
				if(!_vendor.IsNew)
				{
					// sync now
					base.SyncFKFields(PurchaseOrderHeaderEntity.Relations.VendorEntityUsingVendorID, _vendor);
				}
			}

			_alreadyFetchedVendor = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 purchaseOrderID)
		{
			PurchaseOrderHeaderDAO dao = DAOFactory.CreatePurchaseOrderHeaderDAO();

			// Load EntityFields of PurchaseOrderHeader
			dao.FetchPurchaseOrderHeader(base.Fields, base.Transaction, purchaseOrderID);

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
		public static PurchaseOrderHeaderRelations Relations
		{
			get	{ return new PurchaseOrderHeaderRelations(); }
		}

	
		/// <summary>
		/// The PurchaseOrderID property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Int32 PurchaseOrderID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PurchaseOrderID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.PurchaseOrderID, value))
				{
					OnPurchaseOrderIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The RevisionNumber property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Byte RevisionNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.RevisionNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for RevisionNumber because it is set to NULL.");
				}
				return (System.Byte)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.RevisionNumber, value))
				{
					OnRevisionNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The Status property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Byte Status
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.Status);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Status because it is set to NULL.");
				}
				return (System.Byte)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.Status, value))
				{
					OnStatusChanged();
				}
			}
		}
	
		/// <summary>
		/// The EmployeeID property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Int32 EmployeeID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.EmployeeID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EmployeeID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.EmployeeID, value))
				{
					OnEmployeeIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The VendorID property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Int32 VendorID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.VendorID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for VendorID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.VendorID, value))
				{
					OnVendorIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ShipMethodID property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Int32 ShipMethodID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.ShipMethodID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ShipMethodID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.ShipMethodID, value))
				{
					OnShipMethodIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The OrderDate property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.DateTime OrderDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.OrderDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for OrderDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.OrderDate, value))
				{
					OnOrderDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The ShipDate property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.DateTime ShipDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.ShipDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ShipDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.ShipDate, value))
				{
					OnShipDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The SubTotal property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Decimal SubTotal
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.SubTotal);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SubTotal because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.SubTotal, value))
				{
					OnSubTotalChanged();
				}
			}
		}
	
		/// <summary>
		/// The TaxAmt property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Decimal TaxAmt
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.TaxAmt);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TaxAmt because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.TaxAmt, value))
				{
					OnTaxAmtChanged();
				}
			}
		}
	
		/// <summary>
		/// The Freight property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Decimal Freight
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.Freight);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Freight because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.Freight, value))
				{
					OnFreightChanged();
				}
			}
		}
	
		/// <summary>
		/// The TotalDue property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.Decimal TotalDue
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.TotalDue);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for TotalDue because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.TotalDue, value))
				{
					OnTotalDueChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity PurchaseOrderHeader
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderHeaderFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderHeaderFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual PurchaseOrderDetailCollection PurchaseOrderDetail
		{
			get
			{
				return GetMultiPurchaseOrderDetail(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for PurchaseOrderDetail. When set to true, PurchaseOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderDetail(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderDetail
		{
			get
			{
				return _alwaysFetchPurchaseOrderDetail;
			}
			set
			{
				_alwaysFetchPurchaseOrderDetail = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductCollection Product
		{
			get
			{
				return GetMultiProduct(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Product. When set to true, Product is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct(true).
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
							_employee.UnsetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "PurchaseOrderHeader");
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
							_shipMethod.UnsetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "PurchaseOrderHeader");
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
	
		/// <summary>
		/// Gets / sets related entity of type 'VendorEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get
			{
				return GetSingleVendor(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncVendor(value);
				}
				else
				{
					if(value==null)
					{
						if(_vendor != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_vendor.UnsetRelatedEntity(this, "PurchaseOrderHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "PurchaseOrderHeader");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Vendor. When set to true, Vendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vendor is accessed. You can always execute
		/// a forced fetch by calling GetSingleVendor(true).
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
	
	
		#endregion
	}
}
