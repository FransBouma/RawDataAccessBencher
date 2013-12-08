///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v41;
using AdventureWorks.Dal.Adapter.v41.FactoryClasses;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v41.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductSubcategory. </summary>
	public partial class ProductSubcategoryRelations
	{
		/// <summary>CTor</summary>
		public ProductSubcategoryRelations()
		{
		}

		/// <summary>Gets all relations of the ProductSubcategoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductSubcategoryId);
			toReturn.Add(this.ProductCategoryEntityUsingProductCategoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductSubcategoryEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductSubcategory.ProductSubcategoryId - Product.ProductSubcategoryId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductSubcategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Products" , true);
				relation.AddEntityFieldPair(ProductSubcategoryFields.ProductSubcategoryId, ProductFields.ProductSubcategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSubcategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between ProductSubcategoryEntity and ProductCategoryEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductSubcategory.ProductCategoryId - ProductCategory.ProductCategoryId
		/// </summary>
		public virtual IEntityRelation ProductCategoryEntityUsingProductCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductCategory", false);
				relation.AddEntityFieldPair(ProductCategoryFields.ProductCategoryId, ProductSubcategoryFields.ProductCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductCategoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSubcategoryEntity", true);
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
	internal static class StaticProductSubcategoryRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductSubcategoryIdStatic = new ProductSubcategoryRelations().ProductEntityUsingProductSubcategoryId;
		internal static readonly IEntityRelation ProductCategoryEntityUsingProductCategoryIdStatic = new ProductSubcategoryRelations().ProductCategoryEntityUsingProductCategoryId;

		/// <summary>CTor</summary>
		static StaticProductSubcategoryRelations()
		{
		}
	}
}
