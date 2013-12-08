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
	/// <summary>Implements the relations factory for the entity: StoreContact. </summary>
	public partial class StoreContactRelations
	{
		/// <summary>CTor</summary>
		public StoreContactRelations()
		{
		}

		/// <summary>Gets all relations of the StoreContactEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ContactEntityUsingContactId);
			toReturn.Add(this.ContactTypeEntityUsingContactTypeId);
			toReturn.Add(this.StoreEntityUsingCustomerId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between StoreContactEntity and ContactEntity over the m:1 relation they have, using the relation between the fields:
		/// StoreContact.ContactId - Contact.ContactId
		/// </summary>
		public virtual IEntityRelation ContactEntityUsingContactId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Contact", false);
				relation.AddEntityFieldPair(ContactFields.ContactId, StoreContactFields.ContactId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between StoreContactEntity and ContactTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// StoreContact.ContactTypeId - ContactType.ContactTypeId
		/// </summary>
		public virtual IEntityRelation ContactTypeEntityUsingContactTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "ContactType", false);
				relation.AddEntityFieldPair(ContactTypeFields.ContactTypeId, StoreContactFields.ContactTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ContactTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between StoreContactEntity and StoreEntity over the m:1 relation they have, using the relation between the fields:
		/// StoreContact.CustomerId - Store.CustomerId
		/// </summary>
		public virtual IEntityRelation StoreEntityUsingCustomerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Store", false);
				relation.AddEntityFieldPair(StoreFields.CustomerId, StoreContactFields.CustomerId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreContactEntity", true);
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
	internal static class StaticStoreContactRelations
	{
		internal static readonly IEntityRelation ContactEntityUsingContactIdStatic = new StoreContactRelations().ContactEntityUsingContactId;
		internal static readonly IEntityRelation ContactTypeEntityUsingContactTypeIdStatic = new StoreContactRelations().ContactTypeEntityUsingContactTypeId;
		internal static readonly IEntityRelation StoreEntityUsingCustomerIdStatic = new StoreContactRelations().StoreEntityUsingCustomerId;

		/// <summary>CTor</summary>
		static StaticStoreContactRelations()
		{
		}
	}
}
