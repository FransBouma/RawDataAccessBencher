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
	/// <summary>Implements the relations factory for the entity: Location. </summary>
	public partial class LocationRelations
	{
		/// <summary>CTor</summary>
		public LocationRelations()
		{
		}

		/// <summary>Gets all relations of the LocationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductInventoryEntityUsingLocationId);
			toReturn.Add(this.WorkOrderRoutingEntityUsingLocationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between LocationEntity and ProductInventoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Location.LocationId - ProductInventory.LocationId
		/// </summary>
		public virtual IEntityRelation ProductInventoryEntityUsingLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductInventories" , true);
				relation.AddEntityFieldPair(LocationFields.LocationId, ProductInventoryFields.LocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductInventoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between LocationEntity and WorkOrderRoutingEntity over the 1:n relation they have, using the relation between the fields:
		/// Location.LocationId - WorkOrderRouting.LocationId
		/// </summary>
		public virtual IEntityRelation WorkOrderRoutingEntityUsingLocationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "WorkOrderRoutings" , true);
				relation.AddEntityFieldPair(LocationFields.LocationId, WorkOrderRoutingFields.LocationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("LocationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("WorkOrderRoutingEntity", false);
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
	internal static class StaticLocationRelations
	{
		internal static readonly IEntityRelation ProductInventoryEntityUsingLocationIdStatic = new LocationRelations().ProductInventoryEntityUsingLocationId;
		internal static readonly IEntityRelation WorkOrderRoutingEntityUsingLocationIdStatic = new LocationRelations().WorkOrderRoutingEntityUsingLocationId;

		/// <summary>CTor</summary>
		static StaticLocationRelations()
		{
		}
	}
}
