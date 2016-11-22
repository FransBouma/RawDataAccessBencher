///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
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
	/// <summary>Implements the relations factory for the entity: StateProvince. </summary>
	public partial class StateProvinceRelations
	{
		/// <summary>CTor</summary>
		public StateProvinceRelations()
		{
		}

		/// <summary>Gets all relations of the StateProvinceEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AddressEntityUsingStateProvinceId);
			toReturn.Add(this.SalesTaxRateEntityUsingStateProvinceId);
			toReturn.Add(this.CountryRegionEntityUsingCountryRegionCode);
			toReturn.Add(this.SalesTerritoryEntityUsingTerritoryId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between StateProvinceEntity and AddressEntity over the 1:n relation they have, using the relation between the fields:
		/// StateProvince.StateProvinceId - Address.StateProvinceId
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingStateProvinceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Addresses" , true);
				relation.AddEntityFieldPair(StateProvinceFields.StateProvinceId, AddressFields.StateProvinceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StateProvinceEntity and SalesTaxRateEntity over the 1:n relation they have, using the relation between the fields:
		/// StateProvince.StateProvinceId - SalesTaxRate.StateProvinceId
		/// </summary>
		public virtual IEntityRelation SalesTaxRateEntityUsingStateProvinceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesTaxRates" , true);
				relation.AddEntityFieldPair(StateProvinceFields.StateProvinceId, SalesTaxRateFields.StateProvinceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTaxRateEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between StateProvinceEntity and CountryRegionEntity over the m:1 relation they have, using the relation between the fields:
		/// StateProvince.CountryRegionCode - CountryRegion.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation CountryRegionEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CountryRegion", false);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, StateProvinceFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between StateProvinceEntity and SalesTerritoryEntity over the m:1 relation they have, using the relation between the fields:
		/// StateProvince.TerritoryId - SalesTerritory.TerritoryId
		/// </summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesTerritory", false);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, StateProvinceFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", true);
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
	internal static class StaticStateProvinceRelations
	{
		internal static readonly IEntityRelation AddressEntityUsingStateProvinceIdStatic = new StateProvinceRelations().AddressEntityUsingStateProvinceId;
		internal static readonly IEntityRelation SalesTaxRateEntityUsingStateProvinceIdStatic = new StateProvinceRelations().SalesTaxRateEntityUsingStateProvinceId;
		internal static readonly IEntityRelation CountryRegionEntityUsingCountryRegionCodeStatic = new StateProvinceRelations().CountryRegionEntityUsingCountryRegionCode;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingTerritoryIdStatic = new StateProvinceRelations().SalesTerritoryEntityUsingTerritoryId;

		/// <summary>CTor</summary>
		static StaticStateProvinceRelations()
		{
		}
	}
}
