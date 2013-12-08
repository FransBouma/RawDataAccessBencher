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
	/// <summary>Implements the relations factory for the entity: BillOfMaterial. </summary>
	public partial class BillOfMaterialRelations
	{
		/// <summary>CTor</summary>
		public BillOfMaterialRelations()
		{
		}

		/// <summary>Gets all relations of the BillOfMaterialEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductEntityUsingComponentId);
			toReturn.Add(this.ProductEntityUsingProductAssemblyId);
			toReturn.Add(this.UnitMeasureEntityUsingUnitMeasureCode);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterial.ComponentId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingComponentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, BillOfMaterialFields.ComponentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialEntity and ProductEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterial.ProductAssemblyId - Product.ProductId
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingProductAssemblyId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Product_", false);
				relation.AddEntityFieldPair(ProductFields.ProductId, BillOfMaterialFields.ProductAssemblyId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BillOfMaterialEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields:
		/// BillOfMaterial.UnitMeasureCode - UnitMeasure.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation UnitMeasureEntityUsingUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "UnitMeasure", false);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, BillOfMaterialFields.UnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", true);
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
	internal static class StaticBillOfMaterialRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingComponentIdStatic = new BillOfMaterialRelations().ProductEntityUsingComponentId;
		internal static readonly IEntityRelation ProductEntityUsingProductAssemblyIdStatic = new BillOfMaterialRelations().ProductEntityUsingProductAssemblyId;
		internal static readonly IEntityRelation UnitMeasureEntityUsingUnitMeasureCodeStatic = new BillOfMaterialRelations().UnitMeasureEntityUsingUnitMeasureCode;

		/// <summary>CTor</summary>
		static StaticBillOfMaterialRelations()
		{
		}
	}
}
