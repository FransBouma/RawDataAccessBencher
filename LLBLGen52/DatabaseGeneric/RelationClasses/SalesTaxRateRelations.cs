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
	/// <summary>Implements the relations factory for the entity: SalesTaxRate. </summary>
	public partial class SalesTaxRateRelations
	{
		/// <summary>CTor</summary>
		public SalesTaxRateRelations()
		{
		}

		/// <summary>Gets all relations of the SalesTaxRateEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.StateProvinceEntityUsingStateProvinceId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SalesTaxRateEntity and StateProvinceEntity over the m:1 relation they have, using the relation between the fields:
		/// SalesTaxRate.StateProvinceId - StateProvince.StateProvinceId
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingStateProvinceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "StateProvince", false);
				relation.AddEntityFieldPair(StateProvinceFields.StateProvinceId, SalesTaxRateFields.StateProvinceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesTaxRateEntity", true);
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
	internal static class StaticSalesTaxRateRelations
	{
		internal static readonly IEntityRelation StateProvinceEntityUsingStateProvinceIdStatic = new SalesTaxRateRelations().StateProvinceEntityUsingStateProvinceId;

		/// <summary>CTor</summary>
		static StaticSalesTaxRateRelations()
		{
		}
	}
}
