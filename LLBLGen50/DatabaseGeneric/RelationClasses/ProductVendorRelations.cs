///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v50;
using AdventureWorks.Dal.Adapter.v50.FactoryClasses;
using AdventureWorks.Dal.Adapter.v50.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v50.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductVendor. </summary>
	public partial class ProductVendorRelations
	{
		/// <summary>CTor</summary>
		public ProductVendorRelations()
		{
		}

		/// <summary>Gets all relations of the ProductVendorEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingProductId);
			toReturn.Add(this.UnitMeasureEntityUsingUnitMeasureCode);
			toReturn.Add(this.VendorEntityUsingVendorId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ProductVendorEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductVendor.ProductId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, ProductVendorFields.ProductId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductVendorEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductVendor.UnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation UnitMeasureEntityUsingUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UnitMeasure", false);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductVendorFields.UnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ProductVendorEntity and VendorEntity over the m:1 relation they have, using the relation between the fields:
		/// ProductVendor.VendorId - Vendor.VendorId
		/// </summary>
		public virtual IEntityRelation VendorEntityUsingVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Vendor", false);
				relation.AddEntityFieldPair(VendorFields.VendorId, ProductVendorFields.VendorId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", true);
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
	internal static class StaticProductVendorRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new ProductVendorRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation UnitMeasureEntityUsingUnitMeasureCodeStatic = new ProductVendorRelations().UnitMeasureEntityUsingUnitMeasureCode;
		internal static readonly IEntityRelation VendorEntityUsingVendorIdStatic = new ProductVendorRelations().VendorEntityUsingVendorId;

		/// <summary>CTor</summary>
		static StaticProductVendorRelations()
		{
		}
	}
}
