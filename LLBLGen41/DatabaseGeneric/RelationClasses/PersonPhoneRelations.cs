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
	/// <summary>Implements the relations factory for the entity: PersonPhone. </summary>
	public partial class PersonPhoneRelations
	{
		/// <summary>CTor</summary>
		public PersonPhoneRelations()
		{
		}

		/// <summary>Gets all relations of the PersonPhoneEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PersonEntityUsingBusinessEntityId);
			toReturn.Add(this.PhoneNumberTypeEntityUsingPhoneNumberTypeId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between PersonPhoneEntity and PersonEntity over the m:1 relation they have, using the relation between the fields:
		/// PersonPhone.BusinessEntityId - Person.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Person", false);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, PersonPhoneFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonPhoneEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between PersonPhoneEntity and PhoneNumberTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// PersonPhone.PhoneNumberTypeId - PhoneNumberType.PhoneNumberTypeId
		/// </summary>
		public virtual IEntityRelation PhoneNumberTypeEntityUsingPhoneNumberTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "PhoneNumberType", false);
				relation.AddEntityFieldPair(PhoneNumberTypeFields.PhoneNumberTypeId, PersonPhoneFields.PhoneNumberTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PhoneNumberTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonPhoneEntity", true);
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
	internal static class StaticPersonPhoneRelations
	{
		internal static readonly IEntityRelation PersonEntityUsingBusinessEntityIdStatic = new PersonPhoneRelations().PersonEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation PhoneNumberTypeEntityUsingPhoneNumberTypeIdStatic = new PersonPhoneRelations().PhoneNumberTypeEntityUsingPhoneNumberTypeId;

		/// <summary>CTor</summary>
		static StaticPersonPhoneRelations()
		{
		}
	}
}
