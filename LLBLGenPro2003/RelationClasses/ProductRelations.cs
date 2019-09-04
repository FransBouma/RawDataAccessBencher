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
// Code is generated on: woensdag 4 september 2019 12:09:46
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;

using LLBL2003.AdventureWorks2008;
using LLBL2003.AdventureWorks2008.FactoryClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.RelationClasses
{
	/// <summary>
	/// Implements the static Relations variant for the entity: Product.
	/// This class is generated. Do not modify.
	/// </summary>
	public class ProductRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ProductRelations()
		{
		}


		#region Class Property Declarations
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and BillOfMaterialsEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - BillOfMaterials.ComponentID
		/// </summary>
		public IEntityRelation BillOfMaterialsEntityUsingComponentID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(BillOfMaterialsFieldIndex.ComponentID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and BillOfMaterialsEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - BillOfMaterials.ProductAssemblyID
		/// </summary>
		public IEntityRelation BillOfMaterialsEntityUsingProductAssemblyID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(BillOfMaterialsFieldIndex.ProductAssemblyID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductCostHistoryEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - ProductCostHistory.ProductID
		/// </summary>
		public IEntityRelation ProductCostHistoryEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(ProductCostHistoryFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductDocumentEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - ProductDocument.ProductID
		/// </summary>
		public IEntityRelation ProductDocumentEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(ProductDocumentFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductInventoryEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - ProductInventory.ProductID
		/// </summary>
		public IEntityRelation ProductInventoryEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(ProductInventoryFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductListPriceHistoryEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - ProductListPriceHistory.ProductID
		/// </summary>
		public IEntityRelation ProductListPriceHistoryEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(ProductListPriceHistoryFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductProductPhotoEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - ProductProductPhoto.ProductID
		/// </summary>
		public IEntityRelation ProductProductPhotoEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(ProductProductPhotoFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductReviewEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - ProductReview.ProductID
		/// </summary>
		public IEntityRelation ProductReviewEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(ProductReviewFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and TransactionHistoryEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - TransactionHistory.ProductID
		/// </summary>
		public IEntityRelation TransactionHistoryEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(TransactionHistoryFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and WorkOrderEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - WorkOrder.ProductID
		/// </summary>
		public IEntityRelation WorkOrderEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(WorkOrderFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductVendorEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - ProductVendor.ProductID
		/// </summary>
		public IEntityRelation ProductVendorEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(ProductVendorFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and PurchaseOrderDetailEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - PurchaseOrderDetail.ProductID
		/// </summary>
		public IEntityRelation PurchaseOrderDetailEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(PurchaseOrderDetailFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ShoppingCartItemEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - ShoppingCartItem.ProductID
		/// </summary>
		public IEntityRelation ShoppingCartItemEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(ShoppingCartItemFieldIndex.ProductID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and SpecialOfferProductEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Product.ProductID - SpecialOfferProduct.ProductID
		/// </summary>
		public IEntityRelation SpecialOfferProductEntityUsingProductID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductFieldIndex.ProductID), 
						EntityFieldFactory.Create(SpecialOfferProductFieldIndex.ProductID));

				return relation;
			}
		}
	
	
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductModelEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// Product.ProductModelID - ProductModel.ProductModelID
		/// </summary>
		public IEntityRelation ProductModelEntityUsingProductModelID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductModelFieldIndex.ProductModelID), 
						EntityFieldFactory.Create(ProductFieldIndex.ProductModelID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and ProductSubcategoryEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// Product.ProductSubcategoryID - ProductSubcategory.ProductSubcategoryID
		/// </summary>
		public IEntityRelation ProductSubcategoryEntityUsingProductSubcategoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ProductSubcategoryFieldIndex.ProductSubcategoryID), 
						EntityFieldFactory.Create(ProductFieldIndex.ProductSubcategoryID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and UnitMeasureEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// Product.SizeUnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public IEntityRelation UnitMeasureEntityUsingSizeUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UnitMeasureFieldIndex.UnitMeasureCode), 
						EntityFieldFactory.Create(ProductFieldIndex.SizeUnitMeasureCode));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between ProductEntity and UnitMeasureEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// Product.WeightUnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public IEntityRelation UnitMeasureEntityUsingWeightUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(UnitMeasureFieldIndex.UnitMeasureCode), 
						EntityFieldFactory.Create(ProductFieldIndex.WeightUnitMeasureCode));

				return relation;
			}
		}
	

		#endregion
	}
}
