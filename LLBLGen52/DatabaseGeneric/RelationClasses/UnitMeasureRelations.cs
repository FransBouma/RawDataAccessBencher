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
	/// <summary>Implements the relations factory for the entity: UnitMeasure. </summary>
	public partial class UnitMeasureRelations
	{
		/// <summary>CTor</summary>
		public UnitMeasureRelations()
		{
		}

		/// <summary>Gets all relations of the UnitMeasureEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BillOfMaterialEntityUsingUnitMeasureCode);
			toReturn.Add(this.ProductEntityUsingSizeUnitMeasureCode);
			toReturn.Add(this.ProductEntityUsingWeightUnitMeasureCode);
			toReturn.Add(this.ProductVendorEntityUsingUnitMeasureCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and BillOfMaterialEntity over the 1:n relation they have, using the relation between the fields:
		/// UnitMeasure.UnitMeasureCode - BillOfMaterial.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation BillOfMaterialEntityUsingUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BillOfMaterials" , true);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, BillOfMaterialFields.UnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BillOfMaterialEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// UnitMeasure.UnitMeasureCode - Product.SizeUnitMeasureCode
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingSizeUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Products" , true);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductFields.SizeUnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductEntity over the 1:n relation they have, using the relation between the fields:
		/// UnitMeasure.UnitMeasureCode - Product.WeightUnitMeasureCode
		/// </summary>
		public virtual IEntityRelation ProductEntityUsingWeightUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Products_" , true);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductFields.WeightUnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between UnitMeasureEntity and ProductVendorEntity over the 1:n relation they have, using the relation between the fields:
		/// UnitMeasure.UnitMeasureCode - ProductVendor.UnitMeasureCode
		/// </summary>
		public virtual IEntityRelation ProductVendorEntityUsingUnitMeasureCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductVendors" , true);
				relation.AddEntityFieldPair(UnitMeasureFields.UnitMeasureCode, ProductVendorFields.UnitMeasureCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("UnitMeasureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductVendorEntity", false);
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
	internal static class StaticUnitMeasureRelations
	{
		internal static readonly IEntityRelation BillOfMaterialEntityUsingUnitMeasureCodeStatic = new UnitMeasureRelations().BillOfMaterialEntityUsingUnitMeasureCode;
		internal static readonly IEntityRelation ProductEntityUsingSizeUnitMeasureCodeStatic = new UnitMeasureRelations().ProductEntityUsingSizeUnitMeasureCode;
		internal static readonly IEntityRelation ProductEntityUsingWeightUnitMeasureCodeStatic = new UnitMeasureRelations().ProductEntityUsingWeightUnitMeasureCode;
		internal static readonly IEntityRelation ProductVendorEntityUsingUnitMeasureCodeStatic = new UnitMeasureRelations().ProductVendorEntityUsingUnitMeasureCode;

		/// <summary>CTor</summary>
		static StaticUnitMeasureRelations()
		{
		}
	}
}
