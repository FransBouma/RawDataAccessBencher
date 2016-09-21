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
	/// <summary>Implements the relations factory for the entity: Person. </summary>
	public partial class PersonRelations
	{
		/// <summary>CTor</summary>
		public PersonRelations()
		{
		}

		/// <summary>Gets all relations of the PersonEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BusinessEntityContactEntityUsingPersonId);
			toReturn.Add(this.ContactCreditCardEntityUsingContactId);
			toReturn.Add(this.CustomerEntityUsingPersonId);
			toReturn.Add(this.EmailAddressEntityUsingBusinessEntityId);
			toReturn.Add(this.PersonPhoneEntityUsingBusinessEntityId);
			toReturn.Add(this.BusinessEntityEntityUsingBusinessEntityId);
			toReturn.Add(this.EmployeeEntityUsingEmployeeId);
			toReturn.Add(this.PasswordEntityUsingBusinessEntityId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and BusinessEntityContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.BusinessEntityId - BusinessEntityContact.PersonId
		/// </summary>
		public virtual IEntityRelation BusinessEntityContactEntityUsingPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BusinessEntityContacts" , true);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, BusinessEntityContactFields.PersonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityContactEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and ContactCreditCardEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.BusinessEntityId - ContactCreditCard.ContactId
		/// </summary>
		public virtual IEntityRelation ContactCreditCardEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ContactCreditCards" , true);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, ContactCreditCardFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactCreditCardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and CustomerEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.BusinessEntityId - Customer.PersonId
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Customers" , true);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, CustomerFields.PersonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and EmailAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.BusinessEntityId - EmailAddress.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation EmailAddressEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmailAddresses" , true);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, EmailAddressFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmailAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and PersonPhoneEntity over the 1:n relation they have, using the relation between the fields:
		/// Person.BusinessEntityId - PersonPhone.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PersonPhoneEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PersonPhones" , true);
				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, PersonPhoneFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonPhoneEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and BusinessEntityEntity over the 1:1 relation they have, using the relation between the fields:
		/// Person.BusinessEntityId - BusinessEntity.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation BusinessEntityEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "BusinessEntity", false);



				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, PersonFields.BusinessEntityId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and EmployeeEntity over the 1:1 relation they have, using the relation between the fields:
		/// Person.BusinessEntityId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Employee", true);

				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, EmployeeFields.EmployeeId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between PersonEntity and PasswordEntity over the 1:1 relation they have, using the relation between the fields:
		/// Person.BusinessEntityId - Password.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PasswordEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Password", true);

				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, PasswordFields.BusinessEntityId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PasswordEntity", false);
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
	internal static class StaticPersonRelations
	{
		internal static readonly IEntityRelation BusinessEntityContactEntityUsingPersonIdStatic = new PersonRelations().BusinessEntityContactEntityUsingPersonId;
		internal static readonly IEntityRelation ContactCreditCardEntityUsingContactIdStatic = new PersonRelations().ContactCreditCardEntityUsingContactId;
		internal static readonly IEntityRelation CustomerEntityUsingPersonIdStatic = new PersonRelations().CustomerEntityUsingPersonId;
		internal static readonly IEntityRelation EmailAddressEntityUsingBusinessEntityIdStatic = new PersonRelations().EmailAddressEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation PersonPhoneEntityUsingBusinessEntityIdStatic = new PersonRelations().PersonPhoneEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation BusinessEntityEntityUsingBusinessEntityIdStatic = new PersonRelations().BusinessEntityEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIdStatic = new PersonRelations().EmployeeEntityUsingEmployeeId;
		internal static readonly IEntityRelation PasswordEntityUsingBusinessEntityIdStatic = new PersonRelations().PasswordEntityUsingBusinessEntityId;

		/// <summary>CTor</summary>
		static StaticPersonRelations()
		{
		}
	}
}
