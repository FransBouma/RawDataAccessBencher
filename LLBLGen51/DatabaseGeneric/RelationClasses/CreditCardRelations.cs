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
using AdventureWorks.Dal.Adapter.v51;
using AdventureWorks.Dal.Adapter.v51.FactoryClasses;
using AdventureWorks.Dal.Adapter.v51.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v51.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: CreditCard. </summary>
	public partial class CreditCardRelations
	{
		/// <summary>CTor</summary>
		public CreditCardRelations()
		{
		}

		/// <summary>Gets all relations of the CreditCardEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ContactCreditCardEntityUsingCreditCardId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingCreditCardId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CreditCardEntity and ContactCreditCardEntity over the 1:n relation they have, using the relation between the fields:
		/// CreditCard.CreditCardId - ContactCreditCard.CreditCardId
		/// </summary>
		public virtual IEntityRelation ContactCreditCardEntityUsingCreditCardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ContactCreditCards" , true);
				relation.AddEntityFieldPair(CreditCardFields.CreditCardId, ContactCreditCardFields.CreditCardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CreditCardEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactCreditCardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between CreditCardEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// CreditCard.CreditCardId - SalesOrderHeader.CreditCardId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingCreditCardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(CreditCardFields.CreditCardId, SalesOrderHeaderFields.CreditCardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CreditCardEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
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
	internal static class StaticCreditCardRelations
	{
		internal static readonly IEntityRelation ContactCreditCardEntityUsingCreditCardIdStatic = new CreditCardRelations().ContactCreditCardEntityUsingCreditCardId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingCreditCardIdStatic = new CreditCardRelations().SalesOrderHeaderEntityUsingCreditCardId;

		/// <summary>CTor</summary>
		static StaticCreditCardRelations()
		{
		}
	}
}
