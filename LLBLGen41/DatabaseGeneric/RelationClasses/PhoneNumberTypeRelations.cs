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
	/// <summary>Implements the relations factory for the entity: PhoneNumberType. </summary>
	public partial class PhoneNumberTypeRelations
	{
		/// <summary>CTor</summary>
		public PhoneNumberTypeRelations()
		{
		}

		/// <summary>Gets all relations of the PhoneNumberTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.PersonPhoneEntityUsingPhoneNumberTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PhoneNumberTypeEntity and PersonPhoneEntity over the 1:n relation they have, using the relation between the fields:
		/// PhoneNumberType.PhoneNumberTypeId - PersonPhone.PhoneNumberTypeId
		/// </summary>
		public virtual IEntityRelation PersonPhoneEntityUsingPhoneNumberTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PersonPhones" , true);
				relation.AddEntityFieldPair(PhoneNumberTypeFields.PhoneNumberTypeId, PersonPhoneFields.PhoneNumberTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PhoneNumberTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonPhoneEntity", false);
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
	internal static class StaticPhoneNumberTypeRelations
	{
		internal static readonly IEntityRelation PersonPhoneEntityUsingPhoneNumberTypeIdStatic = new PhoneNumberTypeRelations().PersonPhoneEntityUsingPhoneNumberTypeId;

		/// <summary>CTor</summary>
		static StaticPhoneNumberTypeRelations()
		{
		}
	}
}
