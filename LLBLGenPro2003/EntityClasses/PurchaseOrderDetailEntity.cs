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
	/// Entity class which represents the entity 'PurchaseOrderDetail' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class PurchaseOrderDetailEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations


		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private PurchaseOrderHeaderEntity _purchaseOrderHeader;
		private bool	_alwaysFetchPurchaseOrderHeader, _alreadyFetchedPurchaseOrderHeader;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when PurchaseOrderID changes value. Databinding related.
		/// </summary>
		public event EventHandler PurchaseOrderIDChanged;

		/// <summary>
		/// Event which is thrown when PurchaseOrderDetailID changes value. Databinding related.
		/// </summary>
		public event EventHandler PurchaseOrderDetailIDChanged;

		/// <summary>
		/// Event which is thrown when DueDate changes value. Databinding related.
		/// </summary>
		public event EventHandler DueDateChanged;

		/// <summary>
		/// Event which is thrown when OrderQty changes value. Databinding related.
		/// </summary>
		public event EventHandler OrderQtyChanged;

		/// <summary>
		/// Event which is thrown when ProductID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductIDChanged;

		/// <summary>
		/// Event which is thrown when UnitPrice changes value. Databinding related.
		/// </summary>
		public event EventHandler UnitPriceChanged;

		/// <summary>
		/// Event which is thrown when LineTotal changes value. Databinding related.
		/// </summary>
		public event EventHandler LineTotalChanged;

		/// <summary>
		/// Event which is thrown when ReceivedQty changes value. Databinding related.
		/// </summary>
		public event EventHandler ReceivedQtyChanged;

		/// <summary>
		/// Event which is thrown when RejectedQty changes value. Databinding related.
		/// </summary>
		public event EventHandler RejectedQtyChanged;

		/// <summary>
		/// Event which is thrown when StockedQty changes value. Databinding related.
		/// </summary>
		public event EventHandler StockedQtyChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public PurchaseOrderDetailEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new PurchaseOrderDetailEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		public PurchaseOrderDetailEntity(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID)
		{
			InitClassFetch(purchaseOrderID, purchaseOrderDetailID, new PurchaseOrderDetailValidator(), new PropertyDescriptorFactory(), new PurchaseOrderDetailEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderDetailEntity</param>
		public PurchaseOrderDetailEntity(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, PurchaseOrderDetailValidator validator)
		{
			InitClassFetch(purchaseOrderID, purchaseOrderDetailID, validator, new PropertyDescriptorFactory(), new PurchaseOrderDetailEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderDetailEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public PurchaseOrderDetailEntity(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, PurchaseOrderDetailValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(purchaseOrderID, purchaseOrderDetailID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public PurchaseOrderDetailEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private PurchaseOrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				// rewire event handler.
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_purchaseOrderHeader = (PurchaseOrderHeaderEntity)info.GetValue("_purchaseOrderHeader", typeof(PurchaseOrderHeaderEntity));
			if(_purchaseOrderHeader!=null)
			{
				// rewire event handler.
				_purchaseOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchPurchaseOrderHeader = info.GetBoolean("_alwaysFetchPurchaseOrderHeader");
			_alreadyFetchedPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedPurchaseOrderHeader");

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


			_alreadyFetchedProduct = (_product != null);
			_alreadyFetchedPurchaseOrderHeader = (_purchaseOrderHeader != null);

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


			info.AddValue("_product", _product);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_purchaseOrderHeader", _purchaseOrderHeader);
			info.AddValue("_alwaysFetchPurchaseOrderHeader", _alwaysFetchPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedPurchaseOrderHeader", _alreadyFetchedPurchaseOrderHeader);

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
				case "PurchaseOrderHeader":
					SetupSyncPurchaseOrderHeader(relatedEntity);
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
				case "PurchaseOrderHeader":
					DesetupSyncPurchaseOrderHeader(false);
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
			if(_purchaseOrderHeader!=null)
			{
				toReturn.Add(_purchaseOrderHeader);
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
			return base.ToXml("PurchaseOrderDetailEntity");
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
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID)
		{
			return Fetch(purchaseOrderID, purchaseOrderDetailID);
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
			return Fetch(this.PurchaseOrderID, this.PurchaseOrderDetailID);
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
			PurchaseOrderDetailDAO dao = DAOFactory.CreatePurchaseOrderDetailDAO();
			bool wasSuccesful = dao.DeletePurchaseOrderDetail(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(PurchaseOrderDetailFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
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
		/// Retrieves the related entity of type 'PurchaseOrderHeaderEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'PurchaseOrderHeaderEntity' which is related to this entity.</returns>
		public virtual PurchaseOrderHeaderEntity GetSinglePurchaseOrderHeader()
		{
			return GetSinglePurchaseOrderHeader(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'PurchaseOrderHeaderEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'PurchaseOrderHeaderEntity' which is related to this entity.</returns>
		public virtual PurchaseOrderHeaderEntity GetSinglePurchaseOrderHeader(bool forceFetch)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				PurchaseOrderHeaderEntity newEntity = new PurchaseOrderHeaderEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.PurchaseOrderID);
				this.PurchaseOrderHeader = newEntity;

				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
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
		/// Event thrower for the PurchaseOrderDetailIDChanged event, which is thrown when PurchaseOrderDetailID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPurchaseOrderDetailIDChanged()
		{
			if(PurchaseOrderDetailIDChanged!=null)
			{
				PurchaseOrderDetailIDChanged(this, new EventArgs());
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
		/// Event thrower for the UnitPriceChanged event, which is thrown when UnitPrice changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnUnitPriceChanged()
		{
			if(UnitPriceChanged!=null)
			{
				UnitPriceChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the LineTotalChanged event, which is thrown when LineTotal changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnLineTotalChanged()
		{
			if(LineTotalChanged!=null)
			{
				LineTotalChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ReceivedQtyChanged event, which is thrown when ReceivedQty changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnReceivedQtyChanged()
		{
			if(ReceivedQtyChanged!=null)
			{
				ReceivedQtyChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the RejectedQtyChanged event, which is thrown when RejectedQty changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnRejectedQtyChanged()
		{
			if(RejectedQtyChanged!=null)
			{
				RejectedQtyChanged(this, new EventArgs());
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
			PurchaseOrderDetailDAO dao = DAOFactory.CreatePurchaseOrderDetailDAO();
			return dao.AddPurchaseOrderDetail(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			PurchaseOrderDetailDAO dao = DAOFactory.CreatePurchaseOrderDetailDAO();
			return dao.UpdatePurchaseOrderDetail(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			PurchaseOrderDetailDAO dao = DAOFactory.CreatePurchaseOrderDetailDAO();
			return dao.UpdatePurchaseOrderDetail(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.PurchaseOrderDetailEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new PurchaseOrderDetailValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this PurchaseOrderDetailEntity</param>
		private void InitClassFetch(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID, PurchaseOrderDetailValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.PurchaseOrderDetailEntity);
			bool wasSuccesful = Fetch(purchaseOrderID, purchaseOrderDetailID);
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


			_product = null;
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_purchaseOrderHeader = null;
			_alwaysFetchPurchaseOrderHeader = false;
			_alreadyFetchedPurchaseOrderHeader = false;

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
					_product.UnsetRelatedEntity(this, "PurchaseOrderDetail");
				}
				base.UnsetEntitySyncInformation("Product", _product, PurchaseOrderDetailEntity.Relations.ProductEntityUsingProductID);
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
				base.SetEntitySyncInformation("Product", _product, PurchaseOrderDetailEntity.Relations.ProductEntityUsingProductID);
				if(!_product.IsNew)
				{
					// sync now
					base.SyncFKFields(PurchaseOrderDetailEntity.Relations.ProductEntityUsingProductID, _product);
				}
			}

			_alreadyFetchedProduct = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _purchaseOrderHeader
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncPurchaseOrderHeader(bool signalRelatedEntity)
		{
			if(_purchaseOrderHeader != null)
			{
				// disconnect the entity from this entity
				_purchaseOrderHeader.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_purchaseOrderHeader.UnsetRelatedEntity(this, "PurchaseOrderDetail");
				}
				base.UnsetEntitySyncInformation("PurchaseOrderHeader", _purchaseOrderHeader, PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID);
				_purchaseOrderHeader = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _purchaseOrderHeader
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPurchaseOrderHeader(IEntity relatedEntity)
		{
			DesetupSyncPurchaseOrderHeader(true);
			
			if(relatedEntity!=null)
			{
				_purchaseOrderHeader = (PurchaseOrderHeaderEntity)relatedEntity;
				_purchaseOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("PurchaseOrderHeader", _purchaseOrderHeader, PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID);
				if(!_purchaseOrderHeader.IsNew)
				{
					// sync now
					base.SyncFKFields(PurchaseOrderDetailEntity.Relations.PurchaseOrderHeaderEntityUsingPurchaseOrderID, _purchaseOrderHeader);
				}
			}

			_alreadyFetchedPurchaseOrderHeader = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="purchaseOrderID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <param name="purchaseOrderDetailID">PK value for PurchaseOrderDetail which data should be fetched into this PurchaseOrderDetail object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 purchaseOrderID, System.Int32 purchaseOrderDetailID)
		{
			PurchaseOrderDetailDAO dao = DAOFactory.CreatePurchaseOrderDetailDAO();

			// Load EntityFields of PurchaseOrderDetail
			dao.FetchPurchaseOrderDetail(base.Fields, base.Transaction, purchaseOrderID, purchaseOrderDetailID);

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
		public static PurchaseOrderDetailRelations Relations
		{
			get	{ return new PurchaseOrderDetailRelations(); }
		}

	
		/// <summary>
		/// The PurchaseOrderID property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Int32 PurchaseOrderID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PurchaseOrderID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderID, value))
				{
					OnPurchaseOrderIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The PurchaseOrderDetailID property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Int32 PurchaseOrderDetailID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PurchaseOrderDetailID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID, value))
				{
					OnPurchaseOrderDetailIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The DueDate property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.DateTime DueDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.DueDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DueDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.DueDate, value))
				{
					OnDueDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The OrderQty property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Int16 OrderQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.OrderQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for OrderQty because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.OrderQty, value))
				{
					OnOrderQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductID property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Int32 ProductID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.ProductID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.ProductID, value))
				{
					OnProductIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The UnitPrice property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Decimal UnitPrice
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.UnitPrice);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for UnitPrice because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.UnitPrice, value))
				{
					OnUnitPriceChanged();
				}
			}
		}
	
		/// <summary>
		/// The LineTotal property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Decimal LineTotal
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.LineTotal);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for LineTotal because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.LineTotal, value))
				{
					OnLineTotalChanged();
				}
			}
		}
	
		/// <summary>
		/// The ReceivedQty property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Decimal ReceivedQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.ReceivedQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ReceivedQty because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.ReceivedQty, value))
				{
					OnReceivedQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The RejectedQty property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Decimal RejectedQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.RejectedQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for RejectedQty because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.RejectedQty, value))
				{
					OnRejectedQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The StockedQty property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.Decimal StockedQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.StockedQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for StockedQty because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.StockedQty, value))
				{
					OnStockedQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity PurchaseOrderDetail
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)PurchaseOrderDetailFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)PurchaseOrderDetailFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
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
							_product.UnsetRelatedEntity(this, "PurchaseOrderDetail");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "PurchaseOrderDetail");
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
		/// Gets / sets related entity of type 'PurchaseOrderHeaderEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSinglePurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual PurchaseOrderHeaderEntity PurchaseOrderHeader
		{
			get
			{
				return GetSinglePurchaseOrderHeader(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncPurchaseOrderHeader(value);
				}
				else
				{
					if(value==null)
					{
						if(_purchaseOrderHeader != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_purchaseOrderHeader.UnsetRelatedEntity(this, "PurchaseOrderDetail");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "PurchaseOrderDetail");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for PurchaseOrderHeader. When set to true, PurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetSinglePurchaseOrderHeader(true).
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
	
	
		#endregion
	}
}
