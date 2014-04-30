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
	/// <summary>Implements the relations factory for the entity: BusinessEntityContact. </summary>
	public partial class BusinessEntityContactRelations
	{
		/// <summary>CTor</summary>
		public BusinessEntityContactRelations()
		{
		}

		/// <summary>Gets all relations of the BusinessEntityContactEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BusinessEntityEntityUsingBusinessEntityId);
			toReturn.Add(this.ContactTypeEntityUsingContactTypeId);
			toReturn.Add(this.PersonEntityUsingPersonId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BusinessEntityContactEntity and BusinessEntityEntity over the m:1 relation they have, using the relation between the fields:
		/// BusinessEntityContact.BusinessEntityId - BusinessEntity.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation BusinessEntityEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BusinessEntity", false);
				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, BusinessEntityContactFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityContactEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BusinessEntityContactEntity and ContactTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// BusinessEntityContact.ContactTypeId - ContactType.ContactTypeId
		/// </summary>
		public virtual IEntityRelation ContactTypeEntityUsingContactTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ContactType", false);
				relation.AddEntityFieldPair(ContactTypeFields.ContactTypeId, BusinessEntityContactFields.ContactTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityContactEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BusinessEntityContactEntity and PersonEntity over the m:1 relation they have, using the relation between the fields:
		/// BusinessEntityContact.PersonId - Person.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Person", false);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, BusinessEntityContactFields.PersonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityContactEntity", true);
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
	internal static class StaticBusinessEntityContactRelations
	{
		internal static readonly IEntityRelation BusinessEntityEntityUsingBusinessEntityIdStatic = new BusinessEntityContactRelations().BusinessEntityEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation ContactTypeEntityUsingContactTypeIdStatic = new BusinessEntityContactRelations().ContactTypeEntityUsingContactTypeId;
		internal static readonly IEntityRelation PersonEntityUsingPersonIdStatic = new BusinessEntityContactRelations().PersonEntityUsingPersonId;

		/// <summary>CTor</summary>
		static StaticBusinessEntityContactRelations()
		{
		}
	}
}
