///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v50;
using AdventureWorks.Dal.Adapter.v50.FactoryClasses;
using AdventureWorks.Dal.Adapter.v50.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v50.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductCategory. </summary>
	public partial class ProductCategoryRelations
	{
		/// <summary>CTor</summary>
		public ProductCategoryRelations()
		{
		}

		/// <summary>Gets all relations of the ProductCategoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductSubcategoryEntityUsingProductCategoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductCategoryEntity and ProductSubcategoryEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductCategory.ProductCategoryId - ProductSubcategory.ProductCategoryId
		/// </summary>
		public virtual IEntityRelation ProductSubcategoryEntityUsingProductCategoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductSubcategories" , true);
				relation.AddEntityFieldPair(ProductCategoryFields.ProductCategoryId, ProductSubcategoryFields.ProductCategoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductCategoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductSubcategoryEntity", false);
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
	internal static class StaticProductCategoryRelations
	{
		internal static readonly IEntityRelation ProductSubcategoryEntityUsingProductCategoryIdStatic = new ProductCategoryRelations().ProductSubcategoryEntityUsingProductCategoryId;

		/// <summary>CTor</summary>
		static StaticProductCategoryRelations()
		{
		}
	}
}
