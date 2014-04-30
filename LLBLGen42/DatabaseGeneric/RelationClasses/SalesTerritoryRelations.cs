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
	/// <summary>Implements the relations factory for the entity: SalesTerritory. </summary>
	public partial class SalesTerritoryRelations
	{
		/// <summary>CTor</summary>
		public SalesTerritoryRelations()
		{
		}

		/// <summary>Gets all relations of the SalesTerritoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CustomerEntityUsingTerritoryId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingTerritoryId);
			toReturn.Add(this.SalesPersonEntityUsingTerritoryId);
			toReturn.Add(this.SalesTerritoryHistoryEntityUsingTerritoryId);
			toReturn.Add(this.StateProvinceEntityUsingTerritoryId);
			toReturn.Add(this.CountryRegionEntityUsingCountryRegionCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and CustomerEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryId - Customer.TerritoryId
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Customers" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, CustomerFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryId - SalesOrderHeader.TerritoryId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, SalesOrderHeaderFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesPersonEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryId - SalesPerson.TerritoryId
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesPeople" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, SalesPersonFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesTerritoryHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryId - SalesTerritoryHistory.TerritoryId
		/// </summary>
		public virtual IEntityRelation SalesTerritoryHistoryEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesTerritoryHistories" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, SalesTerritoryHistoryFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and StateProvinceEntity over the 1:n relation they have, using the relation between the fields:
		/// SalesTerritory.TerritoryId - StateProvince.TerritoryId
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingTerritoryId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StateProvinces" , true);
				relation.AddEntityFieldPair(SalesTerritoryFields.TerritoryId, StateProvinceFields.TerritoryId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and CountryRegionEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesTerritory.CountryRegionCode - CountryRegion.CountryRegionCode
		/// </summary>
		public virtual IEntityRelation CountryRegionEntityUsingCountryRegionCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CountryRegion", false);
				relation.AddEntityFieldPair(CountryRegionFields.CountryRegionCode, SalesTerritoryFields.CountryRegionCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CountryRegionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTerritoryEntity", true);
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
	internal static class StaticSalesTerritoryRelations
	{
		internal static readonly IEntityRelation CustomerEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().CustomerEntityUsingTerritoryId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().SalesOrderHeaderEntityUsingTerritoryId;
		internal static readonly IEntityRelation SalesPersonEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().SalesPersonEntityUsingTerritoryId;
		internal static readonly IEntityRelation SalesTerritoryHistoryEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().SalesTerritoryHistoryEntityUsingTerritoryId;
		internal static readonly IEntityRelation StateProvinceEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().StateProvinceEntityUsingTerritoryId;
		internal static readonly IEntityRelation CountryRegionEntityUsingCountryRegionCodeStatic = new SalesTerritoryRelations().CountryRegionEntityUsingCountryRegionCode;

		/// <summary>CTor</summary>
		static StaticSalesTerritoryRelations()
		{
		}
	}
}
