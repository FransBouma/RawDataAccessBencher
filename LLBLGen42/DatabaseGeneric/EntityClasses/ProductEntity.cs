///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v42;
using AdventureWorks.Dal.Adapter.v42.HelperClasses;
using AdventureWorks.Dal.Adapter.v42.FactoryClasses;
using AdventureWorks.Dal.Adapter.v42.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v42.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Entity class which represents the entity 'Product'.<br/><br/></summary>
	[Serializable]
	public partial class ProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<BillOfMaterialEntity> _billOfMaterials;
		private EntityCollection<BillOfMaterialEntity> _billOfMaterials_;
		private EntityCollection<ProductCostHistoryEntity> _productCostHistories;
		private EntityCollection<ProductDocumentEntity> _productDocuments;
		private EntityCollection<ProductInventoryEntity> _productInventories;
		private EntityCollection<ProductListPriceHistoryEntity> _productListPriceHistories;
		private EntityCollection<ProductProductPhotoEntity> _productProductPhotos;
		private EntityCollection<ProductReviewEntity> _productReviews;
		private EntityCollection<ProductVendorEntity> _productVendors;
		private EntityCollection<PurchaseOrderDetailEntity> _purchaseOrderDetails;
		private EntityCollection<ShoppingCartItemEntity> _shoppingCartItems;
		private EntityCollection<SpecialOfferProductEntity> _specialOfferProducts;
		private EntityCollection<TransactionHistoryEntity> _transactionHistories;
		private EntityCollection<WorkOrderEntity> _workOrders;
		private ProductModelEntity _productModel;
		private ProductSubcategoryEntity _productSubcategory;
		private UnitMeasureEntity _unitMeasure;
		private UnitMeasureEntity _unitMeasure_;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductModel</summary>
			public static readonly string ProductModel = "ProductModel";
			/// <summary>Member name ProductSubcategory</summary>
			public static readonly string ProductSubcategory = "ProductSubcategory";
			/// <summary>Member name UnitMeasure</summary>
			public static readonly string UnitMeasure = "UnitMeasure";
			/// <summary>Member name UnitMeasure_</summary>
			public static readonly string UnitMeasure_ = "UnitMeasure_";
			/// <summary>Member name BillOfMaterials</summary>
			public static readonly string BillOfMaterials = "BillOfMaterials";
			/// <summary>Member name BillOfMaterials_</summary>
			public static readonly string BillOfMaterials_ = "BillOfMaterials_";
			/// <summary>Member name ProductCostHistories</summary>
			public static readonly string ProductCostHistories = "ProductCostHistories";
			/// <summary>Member name ProductDocuments</summary>
			public static readonly string ProductDocuments = "ProductDocuments";
			/// <summary>Member name ProductInventories</summary>
			public static readonly string ProductInventories = "ProductInventories";
			/// <summary>Member name ProductListPriceHistories</summary>
			public static readonly string ProductListPriceHistories = "ProductListPriceHistories";
			/// <summary>Member name ProductProductPhotos</summary>
			public static readonly string ProductProductPhotos = "ProductProductPhotos";
			/// <summary>Member name ProductReviews</summary>
			public static readonly string ProductReviews = "ProductReviews";
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
			/// <summary>Member name PurchaseOrderDetails</summary>
			public static readonly string PurchaseOrderDetails = "PurchaseOrderDetails";
			/// <summary>Member name ShoppingCartItems</summary>
			public static readonly string ShoppingCartItems = "ShoppingCartItems";
			/// <summary>Member name SpecialOfferProducts</summary>
			public static readonly string SpecialOfferProducts = "SpecialOfferProducts";
			/// <summary>Member name TransactionHistories</summary>
			public static readonly string TransactionHistories = "TransactionHistories";
			/// <summary>Member name WorkOrders</summary>
			public static readonly string WorkOrders = "WorkOrders";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ProductEntity():base("ProductEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductEntity(IEntityFields2 fields):base("ProductEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(IValidator validator):base("ProductEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductEntity(System.Int32 productId):base("ProductEntity")
		{
			InitClassEmpty(null, null);
			this.ProductId = productId;
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductEntity(System.Int32 productId, IValidator validator):base("ProductEntity")
		{
			InitClassEmpty(validator, null);
			this.ProductId = productId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_billOfMaterials = (EntityCollection<BillOfMaterialEntity>)info.GetValue("_billOfMaterials", typeof(EntityCollection<BillOfMaterialEntity>));
				_billOfMaterials_ = (EntityCollection<BillOfMaterialEntity>)info.GetValue("_billOfMaterials_", typeof(EntityCollection<BillOfMaterialEntity>));
				_productCostHistories = (EntityCollection<ProductCostHistoryEntity>)info.GetValue("_productCostHistories", typeof(EntityCollection<ProductCostHistoryEntity>));
				_productDocuments = (EntityCollection<ProductDocumentEntity>)info.GetValue("_productDocuments", typeof(EntityCollection<ProductDocumentEntity>));
				_productInventories = (EntityCollection<ProductInventoryEntity>)info.GetValue("_productInventories", typeof(EntityCollection<ProductInventoryEntity>));
				_productListPriceHistories = (EntityCollection<ProductListPriceHistoryEntity>)info.GetValue("_productListPriceHistories", typeof(EntityCollection<ProductListPriceHistoryEntity>));
				_productProductPhotos = (EntityCollection<ProductProductPhotoEntity>)info.GetValue("_productProductPhotos", typeof(EntityCollection<ProductProductPhotoEntity>));
				_productReviews = (EntityCollection<ProductReviewEntity>)info.GetValue("_productReviews", typeof(EntityCollection<ProductReviewEntity>));
				_productVendors = (EntityCollection<ProductVendorEntity>)info.GetValue("_productVendors", typeof(EntityCollection<ProductVendorEntity>));
				_purchaseOrderDetails = (EntityCollection<PurchaseOrderDetailEntity>)info.GetValue("_purchaseOrderDetails", typeof(EntityCollection<PurchaseOrderDetailEntity>));
				_shoppingCartItems = (EntityCollection<ShoppingCartItemEntity>)info.GetValue("_shoppingCartItems", typeof(EntityCollection<ShoppingCartItemEntity>));
				_specialOfferProducts = (EntityCollection<SpecialOfferProductEntity>)info.GetValue("_specialOfferProducts", typeof(EntityCollection<SpecialOfferProductEntity>));
				_transactionHistories = (EntityCollection<TransactionHistoryEntity>)info.GetValue("_transactionHistories", typeof(EntityCollection<TransactionHistoryEntity>));
				_workOrders = (EntityCollection<WorkOrderEntity>)info.GetValue("_workOrders", typeof(EntityCollection<WorkOrderEntity>));
				_productModel = (ProductModelEntity)info.GetValue("_productModel", typeof(ProductModelEntity));
				if(_productModel!=null)
				{
					_productModel.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_productSubcategory = (ProductSubcategoryEntity)info.GetValue("_productSubcategory", typeof(ProductSubcategoryEntity));
				if(_productSubcategory!=null)
				{
					_productSubcategory.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
				if(_unitMeasure!=null)
				{
					_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_unitMeasure_ = (UnitMeasureEntity)info.GetValue("_unitMeasure_", typeof(UnitMeasureEntity));
				if(_unitMeasure_!=null)
				{
					_unitMeasure_.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductFieldIndex)fieldIndex)
			{
				case ProductFieldIndex.ProductModelId:
					DesetupSyncProductModel(true, false);
					break;
				case ProductFieldIndex.ProductSubcategoryId:
					DesetupSyncProductSubcategory(true, false);
					break;
				case ProductFieldIndex.SizeUnitMeasureCode:
					DesetupSyncUnitMeasure(true, false);
					break;
				case ProductFieldIndex.WeightUnitMeasureCode:
					DesetupSyncUnitMeasure_(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "ProductModel":
					this.ProductModel = (ProductModelEntity)entity;
					break;
				case "ProductSubcategory":
					this.ProductSubcategory = (ProductSubcategoryEntity)entity;
					break;
				case "UnitMeasure":
					this.UnitMeasure = (UnitMeasureEntity)entity;
					break;
				case "UnitMeasure_":
					this.UnitMeasure_ = (UnitMeasureEntity)entity;
					break;
				case "BillOfMaterials":
					this.BillOfMaterials.Add((BillOfMaterialEntity)entity);
					break;
				case "BillOfMaterials_":
					this.BillOfMaterials_.Add((BillOfMaterialEntity)entity);
					break;
				case "ProductCostHistories":
					this.ProductCostHistories.Add((ProductCostHistoryEntity)entity);
					break;
				case "ProductDocuments":
					this.ProductDocuments.Add((ProductDocumentEntity)entity);
					break;
				case "ProductInventories":
					this.ProductInventories.Add((ProductInventoryEntity)entity);
					break;
				case "ProductListPriceHistories":
					this.ProductListPriceHistories.Add((ProductListPriceHistoryEntity)entity);
					break;
				case "ProductProductPhotos":
					this.ProductProductPhotos.Add((ProductProductPhotoEntity)entity);
					break;
				case "ProductReviews":
					this.ProductReviews.Add((ProductReviewEntity)entity);
					break;
				case "ProductVendors":
					this.ProductVendors.Add((ProductVendorEntity)entity);
					break;
				case "PurchaseOrderDetails":
					this.PurchaseOrderDetails.Add((PurchaseOrderDetailEntity)entity);
					break;
				case "ShoppingCartItems":
					this.ShoppingCartItems.Add((ShoppingCartItemEntity)entity);
					break;
				case "SpecialOfferProducts":
					this.SpecialOfferProducts.Add((SpecialOfferProductEntity)entity);
					break;
				case "TransactionHistories":
					this.TransactionHistories.Add((TransactionHistoryEntity)entity);
					break;
				case "WorkOrders":
					this.WorkOrders.Add((WorkOrderEntity)entity);
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "ProductModel":
					toReturn.Add(Relations.ProductModelEntityUsingProductModelId);
					break;
				case "ProductSubcategory":
					toReturn.Add(Relations.ProductSubcategoryEntityUsingProductSubcategoryId);
					break;
				case "UnitMeasure":
					toReturn.Add(Relations.UnitMeasureEntityUsingSizeUnitMeasureCode);
					break;
				case "UnitMeasure_":
					toReturn.Add(Relations.UnitMeasureEntityUsingWeightUnitMeasureCode);
					break;
				case "BillOfMaterials":
					toReturn.Add(Relations.BillOfMaterialEntityUsingComponentId);
					break;
				case "BillOfMaterials_":
					toReturn.Add(Relations.BillOfMaterialEntityUsingProductAssemblyId);
					break;
				case "ProductCostHistories":
					toReturn.Add(Relations.ProductCostHistoryEntityUsingProductId);
					break;
				case "ProductDocuments":
					toReturn.Add(Relations.ProductDocumentEntityUsingProductId);
					break;
				case "ProductInventories":
					toReturn.Add(Relations.ProductInventoryEntityUsingProductId);
					break;
				case "ProductListPriceHistories":
					toReturn.Add(Relations.ProductListPriceHistoryEntityUsingProductId);
					break;
				case "ProductProductPhotos":
					toReturn.Add(Relations.ProductProductPhotoEntityUsingProductId);
					break;
				case "ProductReviews":
					toReturn.Add(Relations.ProductReviewEntityUsingProductId);
					break;
				case "ProductVendors":
					toReturn.Add(Relations.ProductVendorEntityUsingProductId);
					break;
				case "PurchaseOrderDetails":
					toReturn.Add(Relations.PurchaseOrderDetailEntityUsingProductId);
					break;
				case "ShoppingCartItems":
					toReturn.Add(Relations.ShoppingCartItemEntityUsingProductId);
					break;
				case "SpecialOfferProducts":
					toReturn.Add(Relations.SpecialOfferProductEntityUsingProductId);
					break;
				case "TransactionHistories":
					toReturn.Add(Relations.TransactionHistoryEntityUsingProductId);
					break;
				case "WorkOrders":
					toReturn.Add(Relations.WorkOrderEntityUsingProductId);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ProductModel":
					SetupSyncProductModel(relatedEntity);
					break;
				case "ProductSubcategory":
					SetupSyncProductSubcategory(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
					break;
				case "UnitMeasure_":
					SetupSyncUnitMeasure_(relatedEntity);
					break;
				case "BillOfMaterials":
					this.BillOfMaterials.Add((BillOfMaterialEntity)relatedEntity);
					break;
				case "BillOfMaterials_":
					this.BillOfMaterials_.Add((BillOfMaterialEntity)relatedEntity);
					break;
				case "ProductCostHistories":
					this.ProductCostHistories.Add((ProductCostHistoryEntity)relatedEntity);
					break;
				case "ProductDocuments":
					this.ProductDocuments.Add((ProductDocumentEntity)relatedEntity);
					break;
				case "ProductInventories":
					this.ProductInventories.Add((ProductInventoryEntity)relatedEntity);
					break;
				case "ProductListPriceHistories":
					this.ProductListPriceHistories.Add((ProductListPriceHistoryEntity)relatedEntity);
					break;
				case "ProductProductPhotos":
					this.ProductProductPhotos.Add((ProductProductPhotoEntity)relatedEntity);
					break;
				case "ProductReviews":
					this.ProductReviews.Add((ProductReviewEntity)relatedEntity);
					break;
				case "ProductVendors":
					this.ProductVendors.Add((ProductVendorEntity)relatedEntity);
					break;
				case "PurchaseOrderDetails":
					this.PurchaseOrderDetails.Add((PurchaseOrderDetailEntity)relatedEntity);
					break;
				case "ShoppingCartItems":
					this.ShoppingCartItems.Add((ShoppingCartItemEntity)relatedEntity);
					break;
				case "SpecialOfferProducts":
					this.SpecialOfferProducts.Add((SpecialOfferProductEntity)relatedEntity);
					break;
				case "TransactionHistories":
					this.TransactionHistories.Add((TransactionHistoryEntity)relatedEntity);
					break;
				case "WorkOrders":
					this.WorkOrders.Add((WorkOrderEntity)relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "ProductModel":
					DesetupSyncProductModel(false, true);
					break;
				case "ProductSubcategory":
					DesetupSyncProductSubcategory(false, true);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false, true);
					break;
				case "UnitMeasure_":
					DesetupSyncUnitMeasure_(false, true);
					break;
				case "BillOfMaterials":
					this.PerformRelatedEntityRemoval(this.BillOfMaterials, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BillOfMaterials_":
					this.PerformRelatedEntityRemoval(this.BillOfMaterials_, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductCostHistories":
					this.PerformRelatedEntityRemoval(this.ProductCostHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductDocuments":
					this.PerformRelatedEntityRemoval(this.ProductDocuments, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductInventories":
					this.PerformRelatedEntityRemoval(this.ProductInventories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductListPriceHistories":
					this.PerformRelatedEntityRemoval(this.ProductListPriceHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductProductPhotos":
					this.PerformRelatedEntityRemoval(this.ProductProductPhotos, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductReviews":
					this.PerformRelatedEntityRemoval(this.ProductReviews, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ProductVendors":
					this.PerformRelatedEntityRemoval(this.ProductVendors, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderDetails":
					this.PerformRelatedEntityRemoval(this.PurchaseOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ShoppingCartItems":
					this.PerformRelatedEntityRemoval(this.ShoppingCartItems, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SpecialOfferProducts":
					this.PerformRelatedEntityRemoval(this.SpecialOfferProducts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "TransactionHistories":
					this.PerformRelatedEntityRemoval(this.TransactionHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "WorkOrders":
					this.PerformRelatedEntityRemoval(this.WorkOrders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_productModel!=null)
			{
				toReturn.Add(_productModel);
			}
			if(_productSubcategory!=null)
			{
				toReturn.Add(_productSubcategory);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
			}
			if(_unitMeasure_!=null)
			{
				toReturn.Add(_unitMeasure_);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.BillOfMaterials);
			toReturn.Add(this.BillOfMaterials_);
			toReturn.Add(this.ProductCostHistories);
			toReturn.Add(this.ProductDocuments);
			toReturn.Add(this.ProductInventories);
			toReturn.Add(this.ProductListPriceHistories);
			toReturn.Add(this.ProductProductPhotos);
			toReturn.Add(this.ProductReviews);
			toReturn.Add(this.ProductVendors);
			toReturn.Add(this.PurchaseOrderDetails);
			toReturn.Add(this.ShoppingCartItems);
			toReturn.Add(this.SpecialOfferProducts);
			toReturn.Add(this.TransactionHistories);
			toReturn.Add(this.WorkOrders);
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_billOfMaterials", ((_billOfMaterials!=null) && (_billOfMaterials.Count>0) && !this.MarkedForDeletion)?_billOfMaterials:null);
				info.AddValue("_billOfMaterials_", ((_billOfMaterials_!=null) && (_billOfMaterials_.Count>0) && !this.MarkedForDeletion)?_billOfMaterials_:null);
				info.AddValue("_productCostHistories", ((_productCostHistories!=null) && (_productCostHistories.Count>0) && !this.MarkedForDeletion)?_productCostHistories:null);
				info.AddValue("_productDocuments", ((_productDocuments!=null) && (_productDocuments.Count>0) && !this.MarkedForDeletion)?_productDocuments:null);
				info.AddValue("_productInventories", ((_productInventories!=null) && (_productInventories.Count>0) && !this.MarkedForDeletion)?_productInventories:null);
				info.AddValue("_productListPriceHistories", ((_productListPriceHistories!=null) && (_productListPriceHistories.Count>0) && !this.MarkedForDeletion)?_productListPriceHistories:null);
				info.AddValue("_productProductPhotos", ((_productProductPhotos!=null) && (_productProductPhotos.Count>0) && !this.MarkedForDeletion)?_productProductPhotos:null);
				info.AddValue("_productReviews", ((_productReviews!=null) && (_productReviews.Count>0) && !this.MarkedForDeletion)?_productReviews:null);
				info.AddValue("_productVendors", ((_productVendors!=null) && (_productVendors.Count>0) && !this.MarkedForDeletion)?_productVendors:null);
				info.AddValue("_purchaseOrderDetails", ((_purchaseOrderDetails!=null) && (_purchaseOrderDetails.Count>0) && !this.MarkedForDeletion)?_purchaseOrderDetails:null);
				info.AddValue("_shoppingCartItems", ((_shoppingCartItems!=null) && (_shoppingCartItems.Count>0) && !this.MarkedForDeletion)?_shoppingCartItems:null);
				info.AddValue("_specialOfferProducts", ((_specialOfferProducts!=null) && (_specialOfferProducts.Count>0) && !this.MarkedForDeletion)?_specialOfferProducts:null);
				info.AddValue("_transactionHistories", ((_transactionHistories!=null) && (_transactionHistories.Count>0) && !this.MarkedForDeletion)?_transactionHistories:null);
				info.AddValue("_workOrders", ((_workOrders!=null) && (_workOrders.Count>0) && !this.MarkedForDeletion)?_workOrders:null);
				info.AddValue("_productModel", (!this.MarkedForDeletion?_productModel:null));
				info.AddValue("_productSubcategory", (!this.MarkedForDeletion?_productSubcategory:null));
				info.AddValue("_unitMeasure", (!this.MarkedForDeletion?_unitMeasure:null));
				info.AddValue("_unitMeasure_", (!this.MarkedForDeletion?_unitMeasure_:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BillOfMaterial' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBillOfMaterials()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BillOfMaterialFields.ComponentId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BillOfMaterial' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBillOfMaterials_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BillOfMaterialFields.ProductAssemblyId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductCostHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductCostHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductCostHistoryFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductDocument' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductDocuments()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductDocumentFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductInventory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductInventories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductInventoryFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductListPriceHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductListPriceHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductListPriceHistoryFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductProductPhoto' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductProductPhotos()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductProductPhotoFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductReview' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductReviews()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductReviewFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductVendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductVendors()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductVendorFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderDetails()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PurchaseOrderDetailFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ShoppingCartItem' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShoppingCartItems()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShoppingCartItemFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SpecialOfferProduct' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOfferProducts()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SpecialOfferProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'TransactionHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTransactionHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TransactionHistoryFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'WorkOrder' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ProductModel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModel()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ProductSubcategory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductSubcategory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductSubcategoryFields.ProductSubcategoryId, null, ComparisonOperator.Equal, this.ProductSubcategoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasure()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.SizeUnitMeasureCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasure_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(UnitMeasureFields.UnitMeasureCode, null, ComparisonOperator.Equal, this.WeightUnitMeasureCode));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._billOfMaterials);
			collectionsQueue.Enqueue(this._billOfMaterials_);
			collectionsQueue.Enqueue(this._productCostHistories);
			collectionsQueue.Enqueue(this._productDocuments);
			collectionsQueue.Enqueue(this._productInventories);
			collectionsQueue.Enqueue(this._productListPriceHistories);
			collectionsQueue.Enqueue(this._productProductPhotos);
			collectionsQueue.Enqueue(this._productReviews);
			collectionsQueue.Enqueue(this._productVendors);
			collectionsQueue.Enqueue(this._purchaseOrderDetails);
			collectionsQueue.Enqueue(this._shoppingCartItems);
			collectionsQueue.Enqueue(this._specialOfferProducts);
			collectionsQueue.Enqueue(this._transactionHistories);
			collectionsQueue.Enqueue(this._workOrders);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._billOfMaterials = (EntityCollection<BillOfMaterialEntity>) collectionsQueue.Dequeue();
			this._billOfMaterials_ = (EntityCollection<BillOfMaterialEntity>) collectionsQueue.Dequeue();
			this._productCostHistories = (EntityCollection<ProductCostHistoryEntity>) collectionsQueue.Dequeue();
			this._productDocuments = (EntityCollection<ProductDocumentEntity>) collectionsQueue.Dequeue();
			this._productInventories = (EntityCollection<ProductInventoryEntity>) collectionsQueue.Dequeue();
			this._productListPriceHistories = (EntityCollection<ProductListPriceHistoryEntity>) collectionsQueue.Dequeue();
			this._productProductPhotos = (EntityCollection<ProductProductPhotoEntity>) collectionsQueue.Dequeue();
			this._productReviews = (EntityCollection<ProductReviewEntity>) collectionsQueue.Dequeue();
			this._productVendors = (EntityCollection<ProductVendorEntity>) collectionsQueue.Dequeue();
			this._purchaseOrderDetails = (EntityCollection<PurchaseOrderDetailEntity>) collectionsQueue.Dequeue();
			this._shoppingCartItems = (EntityCollection<ShoppingCartItemEntity>) collectionsQueue.Dequeue();
			this._specialOfferProducts = (EntityCollection<SpecialOfferProductEntity>) collectionsQueue.Dequeue();
			this._transactionHistories = (EntityCollection<TransactionHistoryEntity>) collectionsQueue.Dequeue();
			this._workOrders = (EntityCollection<WorkOrderEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._billOfMaterials != null);
			toReturn |=(this._billOfMaterials_ != null);
			toReturn |=(this._productCostHistories != null);
			toReturn |=(this._productDocuments != null);
			toReturn |=(this._productInventories != null);
			toReturn |=(this._productListPriceHistories != null);
			toReturn |=(this._productProductPhotos != null);
			toReturn |=(this._productReviews != null);
			toReturn |=(this._productVendors != null);
			toReturn |=(this._purchaseOrderDetails != null);
			toReturn |=(this._shoppingCartItems != null);
			toReturn |=(this._specialOfferProducts != null);
			toReturn |=(this._transactionHistories != null);
			toReturn |=(this._workOrders != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductCostHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductCostHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductDocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductDocumentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductInventoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductInventoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductListPriceHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductListPriceHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductProductPhotoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductProductPhotoEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductReviewEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductReviewEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductVendorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PurchaseOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderDetailEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ShoppingCartItemEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShoppingCartItemEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SpecialOfferProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferProductEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TransactionHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TransactionHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductModel", _productModel);
			toReturn.Add("ProductSubcategory", _productSubcategory);
			toReturn.Add("UnitMeasure", _unitMeasure);
			toReturn.Add("UnitMeasure_", _unitMeasure_);
			toReturn.Add("BillOfMaterials", _billOfMaterials);
			toReturn.Add("BillOfMaterials_", _billOfMaterials_);
			toReturn.Add("ProductCostHistories", _productCostHistories);
			toReturn.Add("ProductDocuments", _productDocuments);
			toReturn.Add("ProductInventories", _productInventories);
			toReturn.Add("ProductListPriceHistories", _productListPriceHistories);
			toReturn.Add("ProductProductPhotos", _productProductPhotos);
			toReturn.Add("ProductReviews", _productReviews);
			toReturn.Add("ProductVendors", _productVendors);
			toReturn.Add("PurchaseOrderDetails", _purchaseOrderDetails);
			toReturn.Add("ShoppingCartItems", _shoppingCartItems);
			toReturn.Add("SpecialOfferProducts", _specialOfferProducts);
			toReturn.Add("TransactionHistories", _transactionHistories);
			toReturn.Add("WorkOrders", _workOrders);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Class", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Color", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DaysToManufacture", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DiscontinuedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FinishedGoodsFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ListPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MakeFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductLine", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductModelId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductSubcategoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ReorderPoint", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SafetyStockLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SellEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SellStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Size", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SizeUnitMeasureCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StandardCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Style", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Weight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("WeightUnitMeasureCode", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _productModel</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductModel(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticProductRelations.ProductModelEntityUsingProductModelIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.ProductModelId } );
			_productModel = null;
		}

		/// <summary> setups the sync logic for member _productModel</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductModel(IEntityCore relatedEntity)
		{
			if(_productModel!=relatedEntity)
			{
				DesetupSyncProductModel(true, true);
				_productModel = (ProductModelEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticProductRelations.ProductModelEntityUsingProductModelIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductModelPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _productSubcategory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductSubcategory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productSubcategory, new PropertyChangedEventHandler( OnProductSubcategoryPropertyChanged ), "ProductSubcategory", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticProductRelations.ProductSubcategoryEntityUsingProductSubcategoryIdStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.ProductSubcategoryId } );
			_productSubcategory = null;
		}

		/// <summary> setups the sync logic for member _productSubcategory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductSubcategory(IEntityCore relatedEntity)
		{
			if(_productSubcategory!=relatedEntity)
			{
				DesetupSyncProductSubcategory(true, true);
				_productSubcategory = (ProductSubcategoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productSubcategory, new PropertyChangedEventHandler( OnProductSubcategoryPropertyChanged ), "ProductSubcategory", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticProductRelations.ProductSubcategoryEntityUsingProductSubcategoryIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductSubcategoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _unitMeasure</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingSizeUnitMeasureCodeStatic, true, signalRelatedEntity, "Products", resetFKFields, new int[] { (int)ProductFieldIndex.SizeUnitMeasureCode } );
			_unitMeasure = null;
		}

		/// <summary> setups the sync logic for member _unitMeasure</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure(IEntityCore relatedEntity)
		{
			if(_unitMeasure!=relatedEntity)
			{
				DesetupSyncUnitMeasure(true, true);
				_unitMeasure = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _unitMeasure, new PropertyChangedEventHandler( OnUnitMeasurePropertyChanged ), "UnitMeasure", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingSizeUnitMeasureCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUnitMeasurePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _unitMeasure_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncUnitMeasure_(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _unitMeasure_, new PropertyChangedEventHandler( OnUnitMeasure_PropertyChanged ), "UnitMeasure_", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingWeightUnitMeasureCodeStatic, true, signalRelatedEntity, "Products_", resetFKFields, new int[] { (int)ProductFieldIndex.WeightUnitMeasureCode } );
			_unitMeasure_ = null;
		}

		/// <summary> setups the sync logic for member _unitMeasure_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure_(IEntityCore relatedEntity)
		{
			if(_unitMeasure_!=relatedEntity)
			{
				DesetupSyncUnitMeasure_(true, true);
				_unitMeasure_ = (UnitMeasureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _unitMeasure_, new PropertyChangedEventHandler( OnUnitMeasure_PropertyChanged ), "UnitMeasure_", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticProductRelations.UnitMeasureEntityUsingWeightUnitMeasureCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnUnitMeasure_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BillOfMaterial' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBillOfMaterials
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))), (IEntityRelation)GetRelationsForField("BillOfMaterials")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.BillOfMaterialEntity, 0, null, null, null, null, "BillOfMaterials", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BillOfMaterial' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBillOfMaterials_
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BillOfMaterialEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BillOfMaterialEntityFactory))), (IEntityRelation)GetRelationsForField("BillOfMaterials_")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.BillOfMaterialEntity, 0, null, null, null, null, "BillOfMaterials_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductCostHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductCostHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductCostHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductCostHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("ProductCostHistories")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductCostHistoryEntity, 0, null, null, null, null, "ProductCostHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductDocument' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductDocuments
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductDocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductDocumentEntityFactory))), (IEntityRelation)GetRelationsForField("ProductDocuments")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductDocumentEntity, 0, null, null, null, null, "ProductDocuments", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductInventory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductInventories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductInventoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductInventoryEntityFactory))), (IEntityRelation)GetRelationsForField("ProductInventories")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductInventoryEntity, 0, null, null, null, null, "ProductInventories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductListPriceHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductListPriceHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductListPriceHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductListPriceHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("ProductListPriceHistories")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductListPriceHistoryEntity, 0, null, null, null, null, "ProductListPriceHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductProductPhoto' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductProductPhotos
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductProductPhotoEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductProductPhotoEntityFactory))), (IEntityRelation)GetRelationsForField("ProductProductPhotos")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductProductPhotoEntity, 0, null, null, null, null, "ProductProductPhotos", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductReview' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductReviews
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductReviewEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductReviewEntityFactory))), (IEntityRelation)GetRelationsForField("ProductReviews")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductReviewEntity, 0, null, null, null, null, "ProductReviews", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductVendors
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductVendorEntityFactory))), (IEntityRelation)GetRelationsForField("ProductVendors")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductVendorEntity, 0, null, null, null, null, "ProductVendors", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderDetails
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PurchaseOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderDetailEntityFactory))), (IEntityRelation)GetRelationsForField("PurchaseOrderDetails")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.PurchaseOrderDetailEntity, 0, null, null, null, null, "PurchaseOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShoppingCartItem' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShoppingCartItems
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ShoppingCartItemEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ShoppingCartItemEntityFactory))), (IEntityRelation)GetRelationsForField("ShoppingCartItems")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ShoppingCartItemEntity, 0, null, null, null, null, "ShoppingCartItems", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOfferProducts
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SpecialOfferProductEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferProductEntityFactory))), (IEntityRelation)GetRelationsForField("SpecialOfferProducts")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.SpecialOfferProductEntity, 0, null, null, null, null, "SpecialOfferProducts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TransactionHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTransactionHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<TransactionHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TransactionHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("TransactionHistories")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.TransactionHistoryEntity, 0, null, null, null, null, "TransactionHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<WorkOrderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))), (IEntityRelation)GetRelationsForField("WorkOrders")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.WorkOrderEntity, 0, null, null, null, null, "WorkOrders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModel
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))),	(IEntityRelation)GetRelationsForField("ProductModel")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductModelEntity, 0, null, null, null, null, "ProductModel", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductSubcategory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductSubcategory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductSubcategoryEntityFactory))),	(IEntityRelation)GetRelationsForField("ProductSubcategory")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductSubcategoryEntity, 0, null, null, null, null, "ProductSubcategory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasure
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))),	(IEntityRelation)GetRelationsForField("UnitMeasure")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.UnitMeasureEntity, 0, null, null, null, null, "UnitMeasure", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasure_
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(UnitMeasureEntityFactory))),	(IEntityRelation)GetRelationsForField("UnitMeasure_")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.UnitMeasureEntity, 0, null, null, null, null, "UnitMeasure_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Class property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Class"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Class
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Class, true); }
			set	{ SetValue((int)ProductFieldIndex.Class, value); }
		}

		/// <summary> The Color property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Color"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Color
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Color, true); }
			set	{ SetValue((int)ProductFieldIndex.Color, value); }
		}

		/// <summary> The DaysToManufacture property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DaysToManufacture"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 DaysToManufacture
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.DaysToManufacture, true); }
			set	{ SetValue((int)ProductFieldIndex.DaysToManufacture, value); }
		}

		/// <summary> The DiscontinuedDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."DiscontinuedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> DiscontinuedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.DiscontinuedDate, false); }
			set	{ SetValue((int)ProductFieldIndex.DiscontinuedDate, value); }
		}

		/// <summary> The FinishedGoodsFlag property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."FinishedGoodsFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean FinishedGoodsFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.FinishedGoodsFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.FinishedGoodsFlag, value); }
		}

		/// <summary> The ListPrice property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ListPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ListPrice
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.ListPrice, true); }
			set	{ SetValue((int)ProductFieldIndex.ListPrice, value); }
		}

		/// <summary> The MakeFlag property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."MakeFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean MakeFlag
		{
			get { return (System.Boolean)GetValue((int)ProductFieldIndex.MakeFlag, true); }
			set	{ SetValue((int)ProductFieldIndex.MakeFlag, value); }
		}

		/// <summary> The ModifiedDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Name, true); }
			set	{ SetValue((int)ProductFieldIndex.Name, value); }
		}

		/// <summary> The ProductId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductId, value); }
		}

		/// <summary> The ProductLine property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductLine"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ProductLine
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductLine, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductLine, value); }
		}

		/// <summary> The ProductModelId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductModelId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductModelId, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductModelId, value); }
		}

		/// <summary> The ProductNumber property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ProductNumber
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.ProductNumber, true); }
			set	{ SetValue((int)ProductFieldIndex.ProductNumber, value); }
		}

		/// <summary> The ProductSubcategoryId property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ProductSubcategoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProductSubcategoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductFieldIndex.ProductSubcategoryId, false); }
			set	{ SetValue((int)ProductFieldIndex.ProductSubcategoryId, value); }
		}

		/// <summary> The ReorderPoint property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."ReorderPoint"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ReorderPoint
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.ReorderPoint, true); }
			set	{ SetValue((int)ProductFieldIndex.ReorderPoint, value); }
		}

		/// <summary> The Rowguid property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)ProductFieldIndex.Rowguid, true); }
			set	{ SetValue((int)ProductFieldIndex.Rowguid, value); }
		}

		/// <summary> The SafetyStockLevel property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SafetyStockLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SafetyStockLevel
		{
			get { return (System.Int16)GetValue((int)ProductFieldIndex.SafetyStockLevel, true); }
			set	{ SetValue((int)ProductFieldIndex.SafetyStockLevel, value); }
		}

		/// <summary> The SellEndDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> SellEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductFieldIndex.SellEndDate, false); }
			set	{ SetValue((int)ProductFieldIndex.SellEndDate, value); }
		}

		/// <summary> The SellStartDate property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SellStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime SellStartDate
		{
			get { return (System.DateTime)GetValue((int)ProductFieldIndex.SellStartDate, true); }
			set	{ SetValue((int)ProductFieldIndex.SellStartDate, value); }
		}

		/// <summary> The Size property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Size"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 5<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Size
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Size, true); }
			set	{ SetValue((int)ProductFieldIndex.Size, value); }
		}

		/// <summary> The SizeUnitMeasureCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."SizeUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String SizeUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.SizeUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.SizeUnitMeasureCode, value); }
		}

		/// <summary> The StandardCost property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."StandardCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StandardCost
		{
			get { return (System.Decimal)GetValue((int)ProductFieldIndex.StandardCost, true); }
			set	{ SetValue((int)ProductFieldIndex.StandardCost, value); }
		}

		/// <summary> The Style property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Style"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Style
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.Style, true); }
			set	{ SetValue((int)ProductFieldIndex.Style, value); }
		}

		/// <summary> The Weight property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."Weight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 8, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Weight
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductFieldIndex.Weight, false); }
			set	{ SetValue((int)ProductFieldIndex.Weight, value); }
		}

		/// <summary> The WeightUnitMeasureCode property of the Entity Product<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Product"."WeightUnitMeasureCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String WeightUnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductFieldIndex.WeightUnitMeasureCode, true); }
			set	{ SetValue((int)ProductFieldIndex.WeightUnitMeasureCode, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BillOfMaterialEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BillOfMaterialEntity))]
		public virtual EntityCollection<BillOfMaterialEntity> BillOfMaterials
		{
			get { return GetOrCreateEntityCollection<BillOfMaterialEntity, BillOfMaterialEntityFactory>("Product", true, false, ref _billOfMaterials);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BillOfMaterialEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BillOfMaterialEntity))]
		public virtual EntityCollection<BillOfMaterialEntity> BillOfMaterials_
		{
			get { return GetOrCreateEntityCollection<BillOfMaterialEntity, BillOfMaterialEntityFactory>("Product_", true, false, ref _billOfMaterials_);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductCostHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductCostHistoryEntity))]
		public virtual EntityCollection<ProductCostHistoryEntity> ProductCostHistories
		{
			get { return GetOrCreateEntityCollection<ProductCostHistoryEntity, ProductCostHistoryEntityFactory>("Product", true, false, ref _productCostHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductDocumentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductDocumentEntity))]
		public virtual EntityCollection<ProductDocumentEntity> ProductDocuments
		{
			get { return GetOrCreateEntityCollection<ProductDocumentEntity, ProductDocumentEntityFactory>("Product", true, false, ref _productDocuments);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductInventoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductInventoryEntity))]
		public virtual EntityCollection<ProductInventoryEntity> ProductInventories
		{
			get { return GetOrCreateEntityCollection<ProductInventoryEntity, ProductInventoryEntityFactory>("Product", true, false, ref _productInventories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductListPriceHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductListPriceHistoryEntity))]
		public virtual EntityCollection<ProductListPriceHistoryEntity> ProductListPriceHistories
		{
			get { return GetOrCreateEntityCollection<ProductListPriceHistoryEntity, ProductListPriceHistoryEntityFactory>("Product", true, false, ref _productListPriceHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductProductPhotoEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductProductPhotoEntity))]
		public virtual EntityCollection<ProductProductPhotoEntity> ProductProductPhotos
		{
			get { return GetOrCreateEntityCollection<ProductProductPhotoEntity, ProductProductPhotoEntityFactory>("Product", true, false, ref _productProductPhotos);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductReviewEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductReviewEntity))]
		public virtual EntityCollection<ProductReviewEntity> ProductReviews
		{
			get { return GetOrCreateEntityCollection<ProductReviewEntity, ProductReviewEntityFactory>("Product", true, false, ref _productReviews);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductVendorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductVendorEntity))]
		public virtual EntityCollection<ProductVendorEntity> ProductVendors
		{
			get { return GetOrCreateEntityCollection<ProductVendorEntity, ProductVendorEntityFactory>("Product", true, false, ref _productVendors);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PurchaseOrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderDetailEntity))]
		public virtual EntityCollection<PurchaseOrderDetailEntity> PurchaseOrderDetails
		{
			get { return GetOrCreateEntityCollection<PurchaseOrderDetailEntity, PurchaseOrderDetailEntityFactory>("Product", true, false, ref _purchaseOrderDetails);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ShoppingCartItemEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ShoppingCartItemEntity))]
		public virtual EntityCollection<ShoppingCartItemEntity> ShoppingCartItems
		{
			get { return GetOrCreateEntityCollection<ShoppingCartItemEntity, ShoppingCartItemEntityFactory>("Product", true, false, ref _shoppingCartItems);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SpecialOfferProductEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SpecialOfferProductEntity))]
		public virtual EntityCollection<SpecialOfferProductEntity> SpecialOfferProducts
		{
			get { return GetOrCreateEntityCollection<SpecialOfferProductEntity, SpecialOfferProductEntityFactory>("Product", true, false, ref _specialOfferProducts);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TransactionHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TransactionHistoryEntity))]
		public virtual EntityCollection<TransactionHistoryEntity> TransactionHistories
		{
			get { return GetOrCreateEntityCollection<TransactionHistoryEntity, TransactionHistoryEntityFactory>("Product", true, false, ref _transactionHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'WorkOrderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(WorkOrderEntity))]
		public virtual EntityCollection<WorkOrderEntity> WorkOrders
		{
			get { return GetOrCreateEntityCollection<WorkOrderEntity, WorkOrderEntityFactory>("Product", true, false, ref _workOrders);	}
		}

		/// <summary> Gets / sets related entity of type 'ProductModelEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductModelEntity ProductModel
		{
			get	{ return _productModel; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProductModel(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "ProductModel", _productModel, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ProductSubcategoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductSubcategoryEntity ProductSubcategory
		{
			get	{ return _productSubcategory; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProductSubcategory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "ProductSubcategory", _productSubcategory, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get	{ return _unitMeasure; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products", "UnitMeasure", _unitMeasure, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'UnitMeasureEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure_
		{
			get	{ return _unitMeasure_; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncUnitMeasure_(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "Products_", "UnitMeasure_", _unitMeasure_, true); 
				}
			}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v42.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v42.EntityType.ProductEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
