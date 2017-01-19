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
using AdventureWorks.Dal.Adapter.v51;
using AdventureWorks.Dal.Adapter.v51.FactoryClasses;
using AdventureWorks.Dal.Adapter.v51.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v51.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: WorkOrder. </summary>
	public partial class WorkOrderRelations
	{
		/// <summary>CTor</summary>
		public WorkOrderRelations()
		{
		}

		/// <summary>Gets all relations of the WorkOrderEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.WorkOrderRoutingEntityUsingWorkOrderId);
			toReturn.Add(this.ProductEntityUsingProductId);
			toReturn.Add(this.ScrapReasonEntityUsingScrapReasonId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and WorkOrderRoutingEntity over the 1:n relation they have, using the relation between the fields:
		/// WorkOrder.WorkOrderId - WorkOrderRouting.WorkOrderId
		/// </summary>
		public virtual IEntityRelation WorkOrderRoutingEntityUsingWorkOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrderRoutings" , true);
				relation.AddEntityFieldPair(WorkOrderFields.WorkOrderId, WorkOrderRoutingFields.WorkOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderRoutingEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrder.ProductId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, WorkOrderFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and ScrapReasonEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrder.ScrapReasonId - ScrapReason.ScrapReasonId
		/// </summary>
		public virtual IEntityRelation ScrapReasonEntityUsingScrapReasonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ScrapReason", false);
				relation.AddEntityFieldPair(ScrapReasonFields.ScrapReasonId, WorkOrderFields.ScrapReasonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ScrapReasonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", true);
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
	internal static class StaticWorkOrderRelations
	{
		internal static readonly IEntityRelation WorkOrderRoutingEntityUsingWorkOrderIdStatic = new WorkOrderRelations().WorkOrderRoutingEntityUsingWorkOrderId;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new WorkOrderRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation ScrapReasonEntityUsingScrapReasonIdStatic = new WorkOrderRelations().ScrapReasonEntityUsingScrapReasonId;

		/// <summary>CTor</summary>
		static StaticWorkOrderRelations()
		{
		}
	}
}
