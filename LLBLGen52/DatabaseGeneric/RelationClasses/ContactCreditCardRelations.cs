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
	/// <summary>Implements the relations factory for the entity: ContactCreditCard. </summary>
	public partial class ContactCreditCardRelations
	{
		/// <summary>CTor</summary>
		public ContactCreditCardRelations()
		{
		}

		/// <summary>Gets all relations of the ContactCreditCardEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CreditCardEntityUsingCreditCardId);
			toReturn.Add(this.PersonEntityUsingContactId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between ContactCreditCardEntity and CreditCardEntity over the m:1 relation they have, using the relation between the fields:
		/// ContactCreditCard.CreditCardId - CreditCard.CreditCardId
		/// </summary>
		public virtual IEntityRelation CreditCardEntityUsingCreditCardId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "CreditCard", false);
				relation.AddEntityFieldPair(CreditCardFields.CreditCardId, ContactCreditCardFields.CreditCardId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CreditCardEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactCreditCardEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between ContactCreditCardEntity and PersonEntity over the m:1 relation they have, using the relation between the fields:
		/// ContactCreditCard.ContactId - Person.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Person", false);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, ContactCreditCardFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactCreditCardEntity", true);
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
	internal static class StaticContactCreditCardRelations
	{
		internal static readonly IEntityRelation CreditCardEntityUsingCreditCardIdStatic = new ContactCreditCardRelations().CreditCardEntityUsingCreditCardId;
		internal static readonly IEntityRelation PersonEntityUsingContactIdStatic = new ContactCreditCardRelations().PersonEntityUsingContactId;

		/// <summary>CTor</summary>
		static StaticContactCreditCardRelations()
		{
		}
	}
}
