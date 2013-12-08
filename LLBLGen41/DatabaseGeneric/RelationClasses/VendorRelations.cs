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
	/// <summary>Implements the relations factory for the entity: Vendor. </summary>
	public partial class VendorRelations
	{
		/// <summary>CTor</summary>
		public VendorRelations()
		{
		}

		/// <summary>Gets all relations of the VendorEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductVendorEntityUsingVendorId);
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingVendorId);
			toReturn.Add(this.VendorAddressEntityUsingVendorId);
			toReturn.Add(this.VendorContactEntityUsingVendorId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.VendorId - ProductVendor.VendorId
		/// </summary>
		public virtual IEntityRelation ProductVendorEntityUsingVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductVendors" , true);
				relation.AddEntityFieldPair(VendorFields.VendorId, ProductVendorFields.VendorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.VendorId - PurchaseOrderHeader.VendorId
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderHeaders" , true);
				relation.AddEntityFieldPair(VendorFields.VendorId, PurchaseOrderHeaderFields.VendorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and VendorAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.VendorId - VendorAddress.VendorId
		/// </summary>
		public virtual IEntityRelation VendorAddressEntityUsingVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorAddresses" , true);
				relation.AddEntityFieldPair(VendorFields.VendorId, VendorAddressFields.VendorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between VendorEntity and VendorContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Vendor.VendorId - VendorContact.VendorId
		/// </summary>
		public virtual IEntityRelation VendorContactEntityUsingVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorContacts" , true);
				relation.AddEntityFieldPair(VendorFields.VendorId, VendorContactFields.VendorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorContactEntity", false);
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
	internal static class StaticVendorRelations
	{
		internal static readonly IEntityRelation ProductVendorEntityUsingVendorIdStatic = new VendorRelations().ProductVendorEntityUsingVendorId;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingVendorIdStatic = new VendorRelations().PurchaseOrderHeaderEntityUsingVendorId;
		internal static readonly IEntityRelation VendorAddressEntityUsingVendorIdStatic = new VendorRelations().VendorAddressEntityUsingVendorId;
		internal static readonly IEntityRelation VendorContactEntityUsingVendorIdStatic = new VendorRelations().VendorContactEntityUsingVendorId;

		/// <summary>CTor</summary>
		static StaticVendorRelations()
		{
		}
	}
}
