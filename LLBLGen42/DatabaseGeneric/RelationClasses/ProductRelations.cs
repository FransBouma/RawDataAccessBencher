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
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v42;
using AdventureWorks.Dal.Adapter.v42.FactoryClasses;
using AdventureWorks.Dal.Adapter.v42.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v42.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Product. </summary>
	public partial class ProductRelations
	{
		/// <summary>CTor</summary>
		public ProductRelations()
		{
		}

		/// <summary>Gets all relations of the ProductEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BillOfMaterialEntityUsingComponentId);
			toReturn.Add(this.BillOfMaterialEntityUsingProductAssemblyId);
			toReturn.Add(this.ProductCostHistoryEntityUsingProductId);
			toReturn.Add(this.ProductDocumentEntityUsingProductId);
			toReturn.Add(this.ProductInventoryEntityUsingProductId);
			toReturn.Add(this.ProductListPriceHistoryEntityUsingProductId);
			toReturn.Add(this.ProductProductPhotoEntityUsingProductId);
			toReturn.Add(this.ProductReviewEntityUsingProductId);
			toReturn.Add(this.ProductVendorEntityUsingProductId);
			toReturn.Add(this.PurchaseOrderDetailEntityUsingProductId);
			toReturn.Add(this.ShoppingCartItemEntityUsingProductId);
			toReturn.Add(this.SpecialOfferProductEntityUsingProductId);
			toReturn.Add(this.TransactionHistoryEntityUsingProductId);
			toReturn.Add(this.WorkOrderEntityUsingProductId);
			toReturn.Add(this.ProductModelEntityUsingProductModelId);
			toReturn.Add(this.ProductSubcategoryEntityUsingProductSubcategoryId);
			toReturn.Add(this.UnitMeasureEntityUsingSizeUnitMeasureCode);
			toReturn.Add(this.UnitMeasureEntityUsingWeightUnitMeasureCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and BillOfMaterialEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - BillOfMaterial.ComponentId
		/// </summary>
		public virtual IEntityRelation BillOfMaterialEntityUsingComponentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BillOfMaterials" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, BillOfMaterialFields.ComponentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and BillOfMaterialEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - BillOfMaterial.ProductAssemblyId
		/// </summary>
		public virtual IEntityRelation BillOfMaterialEntityUsingProductAssemblyId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BillOfMaterials_" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, BillOfMaterialFields.ProductAssemblyId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductCostHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ProductCostHistory.ProductId
		/// </summary>
		public virtual IEntityRelation ProductCostHistoryEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductCostHistories" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductCostHistoryFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductCostHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductDocumentEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ProductDocument.ProductId
		/// </summary>
		public virtual IEntityRelation ProductDocumentEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductDocuments" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductDocumentFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductDocumentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductInventoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ProductInventory.ProductId
		/// </summary>
		public virtual IEntityRelation ProductInventoryEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductInventories" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductInventoryFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductInventoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductListPriceHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ProductListPriceHistory.ProductId
		/// </summary>
		public virtual IEntityRelation ProductListPriceHistoryEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductListPriceHistories" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductListPriceHistoryFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductListPriceHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductProductPhotoEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ProductProductPhoto.ProductId
		/// </summary>
		public virtual IEntityRelation ProductProductPhotoEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductProductPhotos" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductProductPhotoFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductProductPhotoEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductReviewEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ProductReview.ProductId
		/// </summary>
		public virtual IEntityRelation ProductReviewEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductReviews" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductReviewFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductReviewEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ProductVendor.ProductId
		/// </summary>
		public virtual IEntityRelation ProductVendorEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductVendors" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductVendorFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and PurchaseOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - PurchaseOrderDetail.ProductId
		/// </summary>
		public virtual IEntityRelation PurchaseOrderDetailEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderDetails" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, PurchaseOrderDetailFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ShoppingCartItemEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - ShoppingCartItem.ProductId
		/// </summary>
		public virtual IEntityRelation ShoppingCartItemEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ShoppingCartItems" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, ShoppingCartItemFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShoppingCartItemEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and SpecialOfferProductEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - SpecialOfferProduct.ProductId
		/// </summary>
		public virtual IEntityRelation SpecialOfferProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SpecialOfferProducts" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, SpecialOfferProductFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and TransactionHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - TransactionHistory.ProductId
		/// </summary>
		public virtual IEntityRelation TransactionHistoryEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "TransactionHistories" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, TransactionHistoryFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TransactionHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductEntity and WorkOrderEntity over the 1:n relation they have, using the relation between the fields:
		/// Product.ProductId - WorkOrder.ProductId
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrders" , true);
				relation.AddEntityFieldPair(ProductFields.ProductId, WorkOrderFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductModelEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.ProductModelId - ProductModel.ProductModelId
		/// </summary>
		public virtual IEntityRelation ProductModelEntityUsingProductModelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductModel", false);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelId, ProductFields.ProductModelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and ProductSubcategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.ProductSubcategoryId - ProductSubcategory.ProductSubcategoryId
		/// </summary>
		public virtual IEntityRelation ProductSubcategoryEntityUsingProductSubcategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductSubcategory", false);
				relation.AddEntityFieldPair(ProductSubcategoryFields.ProductSubcategoryId, ProductFields.ProductSubcategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSubcategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.SizeUnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation UnitMeasureEntityUsingSizeUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UnitMeasure", false);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductFields.SizeUnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields:
		/// Product.WeightUnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation UnitMeasureEntityUsingWeightUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UnitMeasure_", false);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductFields.WeightUnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductRelations
	{
		internal static readonly IEntityRelation BillOfMaterialEntityUsingComponentIdStatic = new ProductRelations().BillOfMaterialEntityUsingComponentId;
		internal static readonly IEntityRelation BillOfMaterialEntityUsingProductAssemblyIdStatic = new ProductRelations().BillOfMaterialEntityUsingProductAssemblyId;
		internal static readonly IEntityRelation ProductCostHistoryEntityUsingProductIdStatic = new ProductRelations().ProductCostHistoryEntityUsingProductId;
		internal static readonly IEntityRelation ProductDocumentEntityUsingProductIdStatic = new ProductRelations().ProductDocumentEntityUsingProductId;
		internal static readonly IEntityRelation ProductInventoryEntityUsingProductIdStatic = new ProductRelations().ProductInventoryEntityUsingProductId;
		internal static readonly IEntityRelation ProductListPriceHistoryEntityUsingProductIdStatic = new ProductRelations().ProductListPriceHistoryEntityUsingProductId;
		internal static readonly IEntityRelation ProductProductPhotoEntityUsingProductIdStatic = new ProductRelations().ProductProductPhotoEntityUsingProductId;
		internal static readonly IEntityRelation ProductReviewEntityUsingProductIdStatic = new ProductRelations().ProductReviewEntityUsingProductId;
		internal static readonly IEntityRelation ProductVendorEntityUsingProductIdStatic = new ProductRelations().ProductVendorEntityUsingProductId;
		internal static readonly IEntityRelation PurchaseOrderDetailEntityUsingProductIdStatic = new ProductRelations().PurchaseOrderDetailEntityUsingProductId;
		internal static readonly IEntityRelation ShoppingCartItemEntityUsingProductIdStatic = new ProductRelations().ShoppingCartItemEntityUsingProductId;
		internal static readonly IEntityRelation SpecialOfferProductEntityUsingProductIdStatic = new ProductRelations().SpecialOfferProductEntityUsingProductId;
		internal static readonly IEntityRelation TransactionHistoryEntityUsingProductIdStatic = new ProductRelations().TransactionHistoryEntityUsingProductId;
		internal static readonly IEntityRelation WorkOrderEntityUsingProductIdStatic = new ProductRelations().WorkOrderEntityUsingProductId;
		internal static readonly IEntityRelation ProductModelEntityUsingProductModelIdStatic = new ProductRelations().ProductModelEntityUsingProductModelId;
		internal static readonly IEntityRelation ProductSubcategoryEntityUsingProductSubcategoryIdStatic = new ProductRelations().ProductSubcategoryEntityUsingProductSubcategoryId;
		internal static readonly IEntityRelation UnitMeasureEntityUsingSizeUnitMeasureCodeStatic = new ProductRelations().UnitMeasureEntityUsingSizeUnitMeasureCode;
		internal static readonly IEntityRelation UnitMeasureEntityUsingWeightUnitMeasureCodeStatic = new ProductRelations().UnitMeasureEntityUsingWeightUnitMeasureCode;

		/// <summary>CTor</summary>
		static StaticProductRelations()
		{
		}
	}
}
