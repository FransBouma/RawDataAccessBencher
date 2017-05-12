///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v52;
using AdventureWorks.Dal.Adapter.v52.FactoryClasses;
using AdventureWorks.Dal.Adapter.v52.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v52.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SalesOrderDetail. </summary>
	public partial class SalesOrderDetailRelations
	{
		/// <summary>CTor</summary>
		public SalesOrderDetailRelations()
		{
		}

		/// <summary>Gets all relations of the SalesOrderDetailEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderHeaderEntityUsingSalesOrderId);
			toReturn.Add(this.SpecialOfferProductEntityUsingProductIdSpecialOfferId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SalesOrderDetailEntity and SalesOrderHeaderEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderDetail.SalesOrderId - SalesOrderHeader.SalesOrderId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingSalesOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesOrderHeader", false);
				relation.AddEntityFieldPair(SalesOrderHeaderFields.SalesOrderId, SalesOrderDetailFields.SalesOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between SalesOrderDetailEntity and SpecialOfferProductEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesOrderDetail.ProductId - SpecialOfferProduct.ProductId
		/// SalesOrderDetail.SpecialOfferId - SpecialOfferProduct.SpecialOfferId
		/// </summary>
		public virtual IEntityRelation SpecialOfferProductEntityUsingProductIdSpecialOfferId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SpecialOfferProduct", false);
				relation.AddEntityFieldPair(SpecialOfferProductFields.ProductId, SalesOrderDetailFields.ProductId);
				relation.AddEntityFieldPair(SpecialOfferProductFields.SpecialOfferId, SalesOrderDetailFields.SpecialOfferId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecialOfferProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderDetailEntity", true);
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
	internal static class StaticSalesOrderDetailRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingSalesOrderIdStatic = new SalesOrderDetailRelations().SalesOrderHeaderEntityUsingSalesOrderId;
		internal static readonly IEntityRelation SpecialOfferProductEntityUsingProductIdSpecialOfferIdStatic = new SalesOrderDetailRelations().SpecialOfferProductEntityUsingProductIdSpecialOfferId;

		/// <summary>CTor</summary>
		static StaticSalesOrderDetailRelations()
		{
		}
	}
}
