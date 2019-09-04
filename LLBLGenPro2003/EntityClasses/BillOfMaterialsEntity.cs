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
	/// Entity class which represents the entity 'BillOfMaterials' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class BillOfMaterialsEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations


		private ProductEntity _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private ProductEntity _product_;
		private bool	_alwaysFetchProduct_, _alreadyFetchedProduct_;
		private UnitMeasureEntity _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when BillOfMaterialsID changes value. Databinding related.
		/// </summary>
		public event EventHandler BillOfMaterialsIDChanged;

		/// <summary>
		/// Event which is thrown when ProductAssemblyID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductAssemblyIDChanged;

		/// <summary>
		/// Event which is thrown when ComponentID changes value. Databinding related.
		/// </summary>
		public event EventHandler ComponentIDChanged;

		/// <summary>
		/// Event which is thrown when StartDate changes value. Databinding related.
		/// </summary>
		public event EventHandler StartDateChanged;

		/// <summary>
		/// Event which is thrown when EndDate changes value. Databinding related.
		/// </summary>
		public event EventHandler EndDateChanged;

		/// <summary>
		/// Event which is thrown when UnitMeasureCode changes value. Databinding related.
		/// </summary>
		public event EventHandler UnitMeasureCodeChanged;

		/// <summary>
		/// Event which is thrown when BOMLevel changes value. Databinding related.
		/// </summary>
		public event EventHandler BOMLevelChanged;

		/// <summary>
		/// Event which is thrown when PerAssemblyQty changes value. Databinding related.
		/// </summary>
		public event EventHandler PerAssemblyQtyChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public BillOfMaterialsEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new BillOfMaterialsEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterials which data should be fetched into this BillOfMaterials object</param>
		public BillOfMaterialsEntity(System.Int32 billOfMaterialsID)
		{
			InitClassFetch(billOfMaterialsID, new BillOfMaterialsValidator(), new PropertyDescriptorFactory(), new BillOfMaterialsEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterials which data should be fetched into this BillOfMaterials object</param>
		/// <param name="validator">The custom validator object for this BillOfMaterialsEntity</param>
		public BillOfMaterialsEntity(System.Int32 billOfMaterialsID, BillOfMaterialsValidator validator)
		{
			InitClassFetch(billOfMaterialsID, validator, new PropertyDescriptorFactory(), new BillOfMaterialsEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterials which data should be fetched into this BillOfMaterials object</param>
		/// <param name="validator">The custom validator object for this BillOfMaterialsEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public BillOfMaterialsEntity(System.Int32 billOfMaterialsID, BillOfMaterialsValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(billOfMaterialsID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public BillOfMaterialsEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private BillOfMaterialsEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
			if(_product!=null)
			{
				// rewire event handler.
				_product.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");
			_product_ = (ProductEntity)info.GetValue("_product_", typeof(ProductEntity));
			if(_product_!=null)
			{
				// rewire event handler.
				_product_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProduct_ = info.GetBoolean("_alwaysFetchProduct_");
			_alreadyFetchedProduct_ = info.GetBoolean("_alreadyFetchedProduct_");
			_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
			if(_unitMeasure!=null)
			{
				// rewire event handler.
				_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");

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
			_alreadyFetchedProduct_ = (_product_ != null);
			_alreadyFetchedUnitMeasure = (_unitMeasure != null);

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
			info.AddValue("_product_", _product_);
			info.AddValue("_alwaysFetchProduct_", _alwaysFetchProduct_);
			info.AddValue("_alreadyFetchedProduct_", _alreadyFetchedProduct_);
			info.AddValue("_unitMeasure", _unitMeasure);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);

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
				case "Product_":
					SetupSyncProduct_(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
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
				case "Product_":
					DesetupSyncProduct_(false);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false);
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
			if(_product_!=null)
			{
				toReturn.Add(_product_);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
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
			return base.ToXml("BillOfMaterialsEntity");
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
		/// <param name="billOfMaterialsID">PK value for BillOfMaterials which data should be fetched into this BillOfMaterials object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 billOfMaterialsID)
		{
			return Fetch(billOfMaterialsID);
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
			return Fetch(this.BillOfMaterialsID);
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
			BillOfMaterialsDAO dao = DAOFactory.CreateBillOfMaterialsDAO();
			bool wasSuccesful = dao.DeleteBillOfMaterials(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(BillOfMaterialsFieldIndex fieldIndex)
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
				newEntity.FetchUsingPK(this.ComponentID);
				this.Product = newEntity;

				_alreadyFetchedProduct = true;
			}
			return _product;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProduct_()
		{
			return GetSingleProduct_(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ProductEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductEntity' which is related to this entity.</returns>
		public virtual ProductEntity GetSingleProduct_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProduct_ || forceFetch || _alwaysFetchProduct_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ProductEntity newEntity = new ProductEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ProductAssemblyID);
				this.Product_ = newEntity;

				_alreadyFetchedProduct_ = true;
			}
			return _product_;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure()
		{
			return GetSingleUnitMeasure(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUnitMeasure || forceFetch || _alwaysFetchUnitMeasure) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.UnitMeasureCode);
				this.UnitMeasure = newEntity;

				_alreadyFetchedUnitMeasure = true;
			}
			return _unitMeasure;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the BillOfMaterialsIDChanged event, which is thrown when BillOfMaterialsID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnBillOfMaterialsIDChanged()
		{
			if(BillOfMaterialsIDChanged!=null)
			{
				BillOfMaterialsIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ProductAssemblyIDChanged event, which is thrown when ProductAssemblyID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductAssemblyIDChanged()
		{
			if(ProductAssemblyIDChanged!=null)
			{
				ProductAssemblyIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ComponentIDChanged event, which is thrown when ComponentID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnComponentIDChanged()
		{
			if(ComponentIDChanged!=null)
			{
				ComponentIDChanged(this, new EventArgs());
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
		/// Event thrower for the UnitMeasureCodeChanged event, which is thrown when UnitMeasureCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnUnitMeasureCodeChanged()
		{
			if(UnitMeasureCodeChanged!=null)
			{
				UnitMeasureCodeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the BOMLevelChanged event, which is thrown when BOMLevel changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnBOMLevelChanged()
		{
			if(BOMLevelChanged!=null)
			{
				BOMLevelChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PerAssemblyQtyChanged event, which is thrown when PerAssemblyQty changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPerAssemblyQtyChanged()
		{
			if(PerAssemblyQtyChanged!=null)
			{
				PerAssemblyQtyChanged(this, new EventArgs());
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
			BillOfMaterialsDAO dao = DAOFactory.CreateBillOfMaterialsDAO();
			return dao.AddBillOfMaterials(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			BillOfMaterialsDAO dao = DAOFactory.CreateBillOfMaterialsDAO();
			return dao.UpdateBillOfMaterials(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			BillOfMaterialsDAO dao = DAOFactory.CreateBillOfMaterialsDAO();
			return dao.UpdateBillOfMaterials(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.BillOfMaterialsEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new BillOfMaterialsValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterials which data should be fetched into this BillOfMaterials object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this BillOfMaterialsEntity</param>
		private void InitClassFetch(System.Int32 billOfMaterialsID, BillOfMaterialsValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.BillOfMaterialsEntity);
			bool wasSuccesful = Fetch(billOfMaterialsID);
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
			_product_ = null;
			_alwaysFetchProduct_ = false;
			_alreadyFetchedProduct_ = false;
			_unitMeasure = null;
			_alwaysFetchUnitMeasure = false;
			_alreadyFetchedUnitMeasure = false;

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
					_product.UnsetRelatedEntity(this, "BillOfMaterials");
				}
				base.UnsetEntitySyncInformation("Product", _product, BillOfMaterialsEntity.Relations.ProductEntityUsingComponentID);
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
				base.SetEntitySyncInformation("Product", _product, BillOfMaterialsEntity.Relations.ProductEntityUsingComponentID);
				if(!_product.IsNew)
				{
					// sync now
					base.SyncFKFields(BillOfMaterialsEntity.Relations.ProductEntityUsingComponentID, _product);
				}
			}

			_alreadyFetchedProduct = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _product_
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncProduct_(bool signalRelatedEntity)
		{
			if(_product_ != null)
			{
				// disconnect the entity from this entity
				_product_.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_product_.UnsetRelatedEntity(this, "BillOfMaterials_");
				}
				base.UnsetEntitySyncInformation("Product_", _product_, BillOfMaterialsEntity.Relations.ProductEntityUsingProductAssemblyID);
				_product_ = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _product_
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct_(IEntity relatedEntity)
		{
			DesetupSyncProduct_(true);
			
			if(relatedEntity!=null)
			{
				_product_ = (ProductEntity)relatedEntity;
				_product_.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Product_", _product_, BillOfMaterialsEntity.Relations.ProductEntityUsingProductAssemblyID);
				if(!_product_.IsNew)
				{
					// sync now
					base.SyncFKFields(BillOfMaterialsEntity.Relations.ProductEntityUsingProductAssemblyID, _product_);
				}
			}

			_alreadyFetchedProduct_ = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _unitMeasure
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncUnitMeasure(bool signalRelatedEntity)
		{
			if(_unitMeasure != null)
			{
				// disconnect the entity from this entity
				_unitMeasure.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_unitMeasure.UnsetRelatedEntity(this, "BillOfMaterials");
				}
				base.UnsetEntitySyncInformation("UnitMeasure", _unitMeasure, BillOfMaterialsEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode);
				_unitMeasure = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _unitMeasure
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure(IEntity relatedEntity)
		{
			DesetupSyncUnitMeasure(true);
			
			if(relatedEntity!=null)
			{
				_unitMeasure = (UnitMeasureEntity)relatedEntity;
				_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("UnitMeasure", _unitMeasure, BillOfMaterialsEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode);
				if(!_unitMeasure.IsNew)
				{
					// sync now
					base.SyncFKFields(BillOfMaterialsEntity.Relations.UnitMeasureEntityUsingUnitMeasureCode, _unitMeasure);
				}
			}

			_alreadyFetchedUnitMeasure = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="billOfMaterialsID">PK value for BillOfMaterials which data should be fetched into this BillOfMaterials object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 billOfMaterialsID)
		{
			BillOfMaterialsDAO dao = DAOFactory.CreateBillOfMaterialsDAO();

			// Load EntityFields of BillOfMaterials
			dao.FetchBillOfMaterials(base.Fields, base.Transaction, billOfMaterialsID);

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
		public static BillOfMaterialsRelations Relations
		{
			get	{ return new BillOfMaterialsRelations(); }
		}

	
		/// <summary>
		/// The BillOfMaterialsID property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.Int32 BillOfMaterialsID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.BillOfMaterialsID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for BillOfMaterialsID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.BillOfMaterialsID, value))
				{
					OnBillOfMaterialsIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductAssemblyID property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.Int32 ProductAssemblyID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.ProductAssemblyID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductAssemblyID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.ProductAssemblyID, value))
				{
					OnProductAssemblyIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ComponentID property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.Int32 ComponentID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.ComponentID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ComponentID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.ComponentID, value))
				{
					OnComponentIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The StartDate property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.DateTime StartDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.StartDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for StartDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.StartDate, value))
				{
					OnStartDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The EndDate property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.DateTime EndDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.EndDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EndDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.EndDate, value))
				{
					OnEndDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The UnitMeasureCode property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.String UnitMeasureCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.UnitMeasureCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for UnitMeasureCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.UnitMeasureCode, value))
				{
					OnUnitMeasureCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The BOMLevel property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.Int16 BOMLevel
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.BOMLevel);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for BOMLevel because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.BOMLevel, value))
				{
					OnBOMLevelChanged();
				}
			}
		}
	
		/// <summary>
		/// The PerAssemblyQty property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.Decimal PerAssemblyQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.PerAssemblyQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PerAssemblyQty because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.PerAssemblyQty, value))
				{
					OnPerAssemblyQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity BillOfMaterials
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)BillOfMaterialsFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)BillOfMaterialsFieldIndex.ModifiedDate, value))
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
							_product.UnsetRelatedEntity(this, "BillOfMaterials");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "BillOfMaterials");
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
		/// Gets / sets related entity of type 'ProductEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProduct_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductEntity Product_
		{
			get
			{
				return GetSingleProduct_(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProduct_(value);
				}
				else
				{
					if(value==null)
					{
						if(_product_ != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_product_.UnsetRelatedEntity(this, "BillOfMaterials_");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "BillOfMaterials_");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Product_. When set to true, Product_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleProduct_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct_
		{
			get
			{
				return _alwaysFetchProduct_;
			}
			set
			{
				_alwaysFetchProduct_ = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get
			{
				return GetSingleUnitMeasure(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					if(value==null)
					{
						if(_unitMeasure != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_unitMeasure.UnsetRelatedEntity(this, "BillOfMaterials");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "BillOfMaterials");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UnitMeasure. When set to true, UnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure is accessed. You can always execute
		/// a forced fetch by calling GetSingleUnitMeasure(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure
		{
			get
			{
				return _alwaysFetchUnitMeasure;
			}
			set
			{
				_alwaysFetchUnitMeasure = value;
			}	
		}
	
	
		#endregion
	}
}
