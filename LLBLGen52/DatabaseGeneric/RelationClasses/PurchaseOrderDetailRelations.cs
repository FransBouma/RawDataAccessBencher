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
	/// <summary>Implements the relations factory for the entity: PurchaseOrderDetail. </summary>
	public partial class PurchaseOrderDetailRelations
	{
		/// <summary>CTor</summary>
		public PurchaseOrderDetailRelations()
		{
		}

		/// <summary>Gets all relations of the PurchaseOrderDetailEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductId);
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingPurchaseOrderId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderDetailEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderDetail.ProductId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, PurchaseOrderDetailFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderDetailEntity and PurchaseOrderHeaderEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderDetail.PurchaseOrderId - PurchaseOrderHeader.PurchaseOrderId
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingPurchaseOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PurchaseOrderHeader", false);
				relation.AddEntityFieldPair(PurchaseOrderHeaderFields.PurchaseOrderId, PurchaseOrderDetailFields.PurchaseOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", true);
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
	internal static class StaticPurchaseOrderDetailRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new PurchaseOrderDetailRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingPurchaseOrderIdStatic = new PurchaseOrderDetailRelations().PurchaseOrderHeaderEntityUsingPurchaseOrderId;

		/// <summary>CTor</summary>
		static StaticPurchaseOrderDetailRelations()
		{
		}
	}
}
