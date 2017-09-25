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
	/// <summary>Implements the relations factory for the entity: ShipMethod. </summary>
	public partial class ShipMethodRelations
	{
		/// <summary>CTor</summary>
		public ShipMethodRelations()
		{
		}

		/// <summary>Gets all relations of the ShipMethodEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingShipMethodId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingShipMethodId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ShipMethodEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// ShipMethod.ShipMethodId - PurchaseOrderHeader.ShipMethodId
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingShipMethodId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderHeaders" , true);
				relation.AddEntityFieldPair(ShipMethodFields.ShipMethodId, PurchaseOrderHeaderFields.ShipMethodId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShipMethodEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ShipMethodEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// ShipMethod.ShipMethodId - SalesOrderHeader.ShipMethodId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingShipMethodId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(ShipMethodFields.ShipMethodId, SalesOrderHeaderFields.ShipMethodId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShipMethodEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
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
	internal static class StaticShipMethodRelations
	{
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingShipMethodIdStatic = new ShipMethodRelations().PurchaseOrderHeaderEntityUsingShipMethodId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingShipMethodIdStatic = new ShipMethodRelations().SalesOrderHeaderEntityUsingShipMethodId;

		/// <summary>CTor</summary>
		static StaticShipMethodRelations()
		{
		}
	}
}
