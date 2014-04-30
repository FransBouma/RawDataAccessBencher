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
	/// <summary>Implements the relations factory for the entity: ProductModel. </summary>
	public partial class ProductModelRelations
	{
		/// <summary>CTor</summary>
		public ProductModelRelations()
		{
		}

		/// <summary>Gets all relations of the ProductModelEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductModelId);
			toReturn.Add(this.ProductModelIllustrationEntityUsingProductModelId);
			toReturn.Add(this.ProductModelProductDescriptionCultureEntityUsingProductModelId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductModel.ProductModelId - Product.ProductModelId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductModelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Products" , true);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelId, ProductFields.ProductModelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductModelIllustrationEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductModel.ProductModelId - ProductModelIllustration.ProductModelId
		/// </summary>
		public virtual IEntityRelation ProductModelIllustrationEntityUsingProductModelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductModelIllustrations" , true);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelId, ProductModelIllustrationFields.ProductModelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelIllustrationEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ProductModelEntity and ProductModelProductDescriptionCultureEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductModel.ProductModelId - ProductModelProductDescriptionCulture.ProductModelId
		/// </summary>
		public virtual IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductModelId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductModelProductDescriptionCultures" , true);
				relation.AddEntityFieldPair(ProductModelFields.ProductModelId, ProductModelProductDescriptionCultureFields.ProductModelId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelProductDescriptionCultureEntity", false);
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
	internal static class StaticProductModelRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductModelIdStatic = new ProductModelRelations().ProductEntityUsingProductModelId;
		internal static readonly IEntityRelation ProductModelIllustrationEntityUsingProductModelIdStatic = new ProductModelRelations().ProductModelIllustrationEntityUsingProductModelId;
		internal static readonly IEntityRelation ProductModelProductDescriptionCultureEntityUsingProductModelIdStatic = new ProductModelRelations().ProductModelProductDescriptionCultureEntityUsingProductModelId;

		/// <summary>CTor</summary>
		static StaticProductModelRelations()
		{
		}
	}
}
