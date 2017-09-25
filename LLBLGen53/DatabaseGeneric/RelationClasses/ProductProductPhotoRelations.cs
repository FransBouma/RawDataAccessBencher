///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.3
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v53;
using AdventureWorks.Dal.Adapter.v53.FactoryClasses;
using AdventureWorks.Dal.Adapter.v53.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v53.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductProductPhoto. </summary>
	public partial class ProductProductPhotoRelations
	{
		/// <summary>CTor</summary>
		public ProductProductPhotoRelations()
		{
		}

		/// <summary>Gets all relations of the ProductProductPhotoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductId);
			toReturn.Add(this.ProductPhotoEntityUsingProductPhotoId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ProductProductPhotoEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductProductPhoto.ProductId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductProductPhotoFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductProductPhotoEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductProductPhotoEntity and ProductPhotoEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductProductPhoto.ProductPhotoId - ProductPhoto.ProductPhotoId
		/// </summary>
		public virtual IEntityRelation ProductPhotoEntityUsingProductPhotoId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ProductPhoto", false);
				relation.AddEntityFieldPair(ProductPhotoFields.ProductPhotoId, ProductProductPhotoFields.ProductPhotoId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductPhotoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductProductPhotoEntity", true);
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
	internal static class StaticProductProductPhotoRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new ProductProductPhotoRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation ProductPhotoEntityUsingProductPhotoIdStatic = new ProductProductPhotoRelations().ProductPhotoEntityUsingProductPhotoId;

		/// <summary>CTor</summary>
		static StaticProductProductPhotoRelations()
		{
		}
	}
}
