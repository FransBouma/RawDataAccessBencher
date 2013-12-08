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
	/// <summary>Implements the relations factory for the entity: Contact. </summary>
	public partial class ContactRelations
	{
		/// <summary>CTor</summary>
		public ContactRelations()
		{
		}

		/// <summary>Gets all relations of the ContactEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ContactCreditCardEntityUsingContactId);
			toReturn.Add(this.EmployeeEntityUsingContactId);
			toReturn.Add(this.IndividualEntityUsingContactId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingContactId);
			toReturn.Add(this.StoreContactEntityUsingContactId);
			toReturn.Add(this.VendorContactEntityUsingContactId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and ContactCreditCardEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - ContactCreditCard.ContactId
		/// </summary>
		public virtual IEntityRelation ContactCreditCardEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ContactCreditCards" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, ContactCreditCardFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactCreditCardEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and EmployeeEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - Employee.ContactId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Employees" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, EmployeeFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and IndividualEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - Individual.ContactId
		/// </summary>
		public virtual IEntityRelation IndividualEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Individuals" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, IndividualFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IndividualEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - SalesOrderHeader.ContactId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, SalesOrderHeaderFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and StoreContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - StoreContact.ContactId
		/// </summary>
		public virtual IEntityRelation StoreContactEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "StoreContacts" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, StoreContactFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between ContactEntity and VendorContactEntity over the 1:n relation they have, using the relation between the fields:
		/// Contact.ContactId - VendorContact.ContactId
		/// </summary>
		public virtual IEntityRelation VendorContactEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "VendorContacts" , true);
				relation.AddEntityFieldPair(ContactFields.ContactId, VendorContactFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorContactEntity", false);
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
	internal static class StaticContactRelations
	{
		internal static readonly IEntityRelation ContactCreditCardEntityUsingContactIdStatic = new ContactRelations().ContactCreditCardEntityUsingContactId;
		internal static readonly IEntityRelation EmployeeEntityUsingContactIdStatic = new ContactRelations().EmployeeEntityUsingContactId;
		internal static readonly IEntityRelation IndividualEntityUsingContactIdStatic = new ContactRelations().IndividualEntityUsingContactId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingContactIdStatic = new ContactRelations().SalesOrderHeaderEntityUsingContactId;
		internal static readonly IEntityRelation StoreContactEntityUsingContactIdStatic = new ContactRelations().StoreContactEntityUsingContactId;
		internal static readonly IEntityRelation VendorContactEntityUsingContactIdStatic = new ContactRelations().VendorContactEntityUsingContactId;

		/// <summary>CTor</summary>
		static StaticContactRelations()
		{
		}
	}
}
