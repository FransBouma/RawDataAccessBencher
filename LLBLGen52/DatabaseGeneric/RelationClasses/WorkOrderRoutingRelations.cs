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
	/// <summary>Implements the relations factory for the entity: WorkOrderRouting. </summary>
	public partial class WorkOrderRoutingRelations
	{
		/// <summary>CTor</summary>
		public WorkOrderRoutingRelations()
		{
		}

		/// <summary>Gets all relations of the WorkOrderRoutingEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.LocationEntityUsingLocationId);
			toReturn.Add(this.WorkOrderEntityUsingWorkOrderId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between WorkOrderRoutingEntity and LocationEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrderRouting.LocationId - Location.LocationId
		/// </summary>
		public virtual IEntityRelation LocationEntityUsingLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Location", false);
				relation.AddEntityFieldPair(LocationFields.LocationId, WorkOrderRoutingFields.LocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocationEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderRoutingEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between WorkOrderRoutingEntity and WorkOrderEntity over the m:1 relation they have, using the relation between the fields:
		/// WorkOrderRouting.WorkOrderId - WorkOrder.WorkOrderId
		/// </summary>
		public virtual IEntityRelation WorkOrderEntityUsingWorkOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "WorkOrder", false);
				relation.AddEntityFieldPair(WorkOrderFields.WorkOrderId, WorkOrderRoutingFields.WorkOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderRoutingEntity", true);
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
	internal static class StaticWorkOrderRoutingRelations
	{
		internal static readonly IEntityRelation LocationEntityUsingLocationIdStatic = new WorkOrderRoutingRelations().LocationEntityUsingLocationId;
		internal static readonly IEntityRelation WorkOrderEntityUsingWorkOrderIdStatic = new WorkOrderRoutingRelations().WorkOrderEntityUsingWorkOrderId;

		/// <summary>CTor</summary>
		static StaticWorkOrderRoutingRelations()
		{
		}
	}
}
