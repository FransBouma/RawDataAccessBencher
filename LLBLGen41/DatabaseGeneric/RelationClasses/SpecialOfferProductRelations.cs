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
	/// <summary>Implements the relations factory for the entity: SpecialOfferProduct. </summary>
	public partial class SpecialOfferProductRelations
	{
		/// <summary>CTor</summary>
		public SpecialOfferProductRelations()
		{
		}

		/// <summary>Gets all relations of the SpecialOfferProductEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderDetailEntityUsingProductIdSpecialOfferId);
			toReturn.Add(this.ProductEntityUsingProductId);
			toReturn.Add(this.SpecialOfferEntityUsingSpecialOfferId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and SalesOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// SpecialOfferProduct.ProductId - SalesOrderDetail.ProductId
		/// SpecialOfferProduct.SpecialOfferId - SalesOrderDetail.SpecialOfferId
		/// </summary>
		public virtual IEntityRelation SalesOrderDetailEntityUsingProductIdSpecialOfferId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderDetails" , true);
				relation.AddEntityFieldPair(SpecialOfferProductFields.ProductId, SalesOrderDetailFields.ProductId);
				relation.AddEntityFieldPair(SpecialOfferProductFields.SpecialOfferId, SalesOrderDetailFields.SpecialOfferId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// SpecialOfferProduct.ProductId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, SpecialOfferProductFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SpecialOfferProductEntity and SpecialOfferEntity over the m:1 relation they have, using the relation between the fields:
		/// SpecialOfferProduct.SpecialOfferId - SpecialOffer.SpecialOfferId
		/// </summary>
		public virtual IEntityRelation SpecialOfferEntityUsingSpecialOfferId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SpecialOffer", false);
				relation.AddEntityFieldPair(SpecialOfferFields.SpecialOfferId, SpecialOfferProductFields.SpecialOfferId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", true);
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
	internal static class StaticSpecialOfferProductRelations
	{
		internal static readonly IEntityRelation SalesOrderDetailEntityUsingProductIdSpecialOfferIdStatic = new SpecialOfferProductRelations().SalesOrderDetailEntityUsingProductIdSpecialOfferId;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new SpecialOfferProductRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation SpecialOfferEntityUsingSpecialOfferIdStatic = new SpecialOfferProductRelations().SpecialOfferEntityUsingSpecialOfferId;

		/// <summary>CTor</summary>
		static StaticSpecialOfferProductRelations()
		{
		}
	}
}
