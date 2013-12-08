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
	/// <summary>Implements the relations factory for the entity: CurrencyRate. </summary>
	public partial class CurrencyRateRelations
	{
		/// <summary>CTor</summary>
		public CurrencyRateRelations()
		{
		}

		/// <summary>Gets all relations of the CurrencyRateEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SalesOrderHeaderEntityUsingCurrencyRateId);
			toReturn.Add(this.CurrencyEntityUsingFromCurrencyCode);
			toReturn.Add(this.CurrencyEntityUsingToCurrencyCode);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// CurrencyRate.CurrencyRateId - SalesOrderHeader.CurrencyRateId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingCurrencyRateId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(CurrencyRateFields.CurrencyRateId, SalesOrderHeaderFields.CurrencyRateId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and CurrencyEntity over the m:1 relation they have, using the relation between the fields:
		/// CurrencyRate.FromCurrencyCode - Currency.CurrencyCode
		/// </summary>
		public virtual IEntityRelation CurrencyEntityUsingFromCurrencyCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Currency", false);
				relation.AddEntityFieldPair(CurrencyFields.CurrencyCode, CurrencyRateFields.FromCurrencyCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between CurrencyRateEntity and CurrencyEntity over the m:1 relation they have, using the relation between the fields:
		/// CurrencyRate.ToCurrencyCode - Currency.CurrencyCode
		/// </summary>
		public virtual IEntityRelation CurrencyEntityUsingToCurrencyCode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Currency_", false);
				relation.AddEntityFieldPair(CurrencyFields.CurrencyCode, CurrencyRateFields.ToCurrencyCode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CurrencyRateEntity", true);
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
	internal static class StaticCurrencyRateRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingCurrencyRateIdStatic = new CurrencyRateRelations().SalesOrderHeaderEntityUsingCurrencyRateId;
		internal static readonly IEntityRelation CurrencyEntityUsingFromCurrencyCodeStatic = new CurrencyRateRelations().CurrencyEntityUsingFromCurrencyCode;
		internal static readonly IEntityRelation CurrencyEntityUsingToCurrencyCodeStatic = new CurrencyRateRelations().CurrencyEntityUsingToCurrencyCode;

		/// <summary>CTor</summary>
		static StaticCurrencyRateRelations()
		{
		}
	}
}
