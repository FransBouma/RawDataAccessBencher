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
	/// <summary>Implements the relations factory for the entity: ProductPhoto. </summary>
	public partial class ProductPhotoRelations
	{
		/// <summary>CTor</summary>
		public ProductPhotoRelations()
		{
		}

		/// <summary>Gets all relations of the ProductPhotoEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductProductPhotoEntityUsingProductPhotoId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ProductPhotoEntity and ProductProductPhotoEntity over the 1:n relation they have, using the relation between the fields:
		/// ProductPhoto.ProductPhotoId - ProductProductPhoto.ProductPhotoId
		/// </summary>
		public virtual IEntityRelation ProductProductPhotoEntityUsingProductPhotoId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductProductPhotos" , true);
				relation.AddEntityFieldPair(ProductPhotoFields.ProductPhotoId, ProductProductPhotoFields.ProductPhotoId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductPhotoEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductProductPhotoEntity", false);
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
	internal static class StaticProductPhotoRelations
	{
		internal static readonly IEntityRelation ProductProductPhotoEntityUsingProductPhotoIdStatic = new ProductPhotoRelations().ProductProductPhotoEntityUsingProductPhotoId;

		/// <summary>CTor</summary>
		static StaticProductPhotoRelations()
		{
		}
	}
}
