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
	/// <summary>Implements the relations factory for the entity: PurchaseOrderHeader. </summary>
	public partial class PurchaseOrderHeaderRelations
	{
		/// <summary>CTor</summary>
		public PurchaseOrderHeaderRelations()
		{
		}

		/// <summary>Gets all relations of the PurchaseOrderHeaderEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PurchaseOrderDetailEntityUsingPurchaseOrderId);
			toReturn.Add(this.EmployeeEntityUsingEmployeeId);
			toReturn.Add(this.ShipMethodEntityUsingShipMethodId);
			toReturn.Add(this.VendorEntityUsingVendorId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderHeaderEntity and PurchaseOrderDetailEntity over the 1:n relation they have, using the relation between the fields:
		/// PurchaseOrderHeader.PurchaseOrderId - PurchaseOrderDetail.PurchaseOrderId
		/// </summary>
		public virtual IEntityRelation PurchaseOrderDetailEntityUsingPurchaseOrderId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderDetails" , true);
				relation.AddEntityFieldPair(PurchaseOrderHeaderFields.PurchaseOrderId, PurchaseOrderDetailFields.PurchaseOrderId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderDetailEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderHeaderEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderHeader.EmployeeId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, PurchaseOrderHeaderFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderHeaderEntity and ShipMethodEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderHeader.ShipMethodId - ShipMethod.ShipMethodId
		/// </summary>
		public virtual IEntityRelation ShipMethodEntityUsingShipMethodId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ShipMethod", false);
				relation.AddEntityFieldPair(ShipMethodFields.ShipMethodId, PurchaseOrderHeaderFields.ShipMethodId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShipMethodEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PurchaseOrderHeaderEntity and VendorEntity over the m:1 relation they have, using the relation between the fields:
		/// PurchaseOrderHeader.VendorId - Vendor.VendorId
		/// </summary>
		public virtual IEntityRelation VendorEntityUsingVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Vendor", false);
				relation.AddEntityFieldPair(VendorFields.VendorId, PurchaseOrderHeaderFields.VendorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", true);
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
	internal static class StaticPurchaseOrderHeaderRelations
	{
		internal static readonly IEntityRelation PurchaseOrderDetailEntityUsingPurchaseOrderIdStatic = new PurchaseOrderHeaderRelations().PurchaseOrderDetailEntityUsingPurchaseOrderId;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIdStatic = new PurchaseOrderHeaderRelations().EmployeeEntityUsingEmployeeId;
		internal static readonly IEntityRelation ShipMethodEntityUsingShipMethodIdStatic = new PurchaseOrderHeaderRelations().ShipMethodEntityUsingShipMethodId;
		internal static readonly IEntityRelation VendorEntityUsingVendorIdStatic = new PurchaseOrderHeaderRelations().VendorEntityUsingVendorId;

		/// <summary>CTor</summary>
		static StaticPurchaseOrderHeaderRelations()
		{
		}
	}
}
