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
	/// <summary>Implements the relations factory for the entity: CountryRegion. </summary>
	public partial class CountryRegionRelations
	{
		/// <summary>CTor</summary>
		public CountryRegionRelations()
		{
		}

		/// <summary>Gets all relations of the CountryRegionEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CountryRegionCurrencyEntityUsingCountryRegionCode);
			toReturn.Add(this.SalesTerritoryEntityUsingCountryRegionCode);
			toReturn.Add(this.StateProvinceEntityUsingCountryRegionCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CountryRegionEntity and CountryRegionCurrencyEntity over the 1:n relation they have, using the relation between the fields:
		/// CountryRegion.CountryRegionCode - CountryRegionCurrency.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation CountryRegionCurrencyEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "CountryRegionCurrencies" , true);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, CountryRegionCurrencyFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionCurrencyEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CountryRegionEntity and SalesTerritoryEntity over the 1:n relation they have, using the relation between the fields:
		/// CountryRegion.CountryRegionCode - SalesTerritory.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation SalesTerritoryEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesTerritories" , true);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, SalesTerritoryFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CountryRegionEntity and StateProvinceEntity over the 1:n relation they have, using the relation between the fields:
		/// CountryRegion.CountryRegionCode - StateProvince.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StateProvinces" , true);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, StateProvinceFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", false);
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
	internal static class StaticCountryRegionRelations
	{
		internal static readonly IEntityRelation CountryRegionCurrencyEntityUsingCountryRegionCodeStatic = new CountryRegionRelations().CountryRegionCurrencyEntityUsingCountryRegionCode;
		internal static readonly IEntityRelation SalesTerritoryEntityUsingCountryRegionCodeStatic = new CountryRegionRelations().SalesTerritoryEntityUsingCountryRegionCode;
		internal static readonly IEntityRelation StateProvinceEntityUsingCountryRegionCodeStatic = new CountryRegionRelations().StateProvinceEntityUsingCountryRegionCode;

		/// <summary>CTor</summary>
		static StaticCountryRegionRelations()
		{
		}
	}
}
