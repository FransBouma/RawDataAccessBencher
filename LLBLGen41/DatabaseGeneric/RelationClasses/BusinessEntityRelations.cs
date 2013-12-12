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
	/// <summary>Implements the relations factory for the entity: BusinessEntity. </summary>
	public partial class BusinessEntityRelations
	{
		/// <summary>CTor</summary>
		public BusinessEntityRelations()
		{
		}

		/// <summary>Gets all relations of the BusinessEntityEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BusinessEntityAddressEntityUsingBusinessEntityId);
			toReturn.Add(this.BusinessEntityContactEntityUsingBusinessEntityId);
			toReturn.Add(this.PersonEntityUsingBusinessEntityId);
			toReturn.Add(this.StoreEntityUsingCustomerId);
			toReturn.Add(this.VendorEntityUsingVendorId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and BusinessEntityAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// BusinessEntity.BusinessEntityId - BusinessEntityAddress.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation BusinessEntityAddressEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BusinessEntityAddresses" , true);
				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, BusinessEntityAddressFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and BusinessEntityContactEntity over the 1:n relation they have, using the relation between the fields:
		/// BusinessEntity.BusinessEntityId - BusinessEntityContact.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation BusinessEntityContactEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BusinessEntityContacts" , true);
				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, BusinessEntityContactFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityContactEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and PersonEntity over the 1:1 relation they have, using the relation between the fields:
		/// BusinessEntity.BusinessEntityId - Person.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Person", true);

				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, PersonFields.BusinessEntityId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and StoreEntity over the 1:1 relation they have, using the relation between the fields:
		/// BusinessEntity.BusinessEntityId - Store.CustomerId
		/// </summary>
		public virtual IEntityRelation StoreEntityUsingCustomerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Store", true);

				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, StoreFields.CustomerId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityEntity and VendorEntity over the 1:1 relation they have, using the relation between the fields:
		/// BusinessEntity.BusinessEntityId - Vendor.VendorId
		/// </summary>
		public virtual IEntityRelation VendorEntityUsingVendorId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Vendor", true);

				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, VendorFields.VendorId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("VendorEntity", false);
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
	internal static class StaticBusinessEntityRelations
	{
		internal static readonly IEntityRelation BusinessEntityAddressEntityUsingBusinessEntityIdStatic = new BusinessEntityRelations().BusinessEntityAddressEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation BusinessEntityContactEntityUsingBusinessEntityIdStatic = new BusinessEntityRelations().BusinessEntityContactEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation PersonEntityUsingBusinessEntityIdStatic = new BusinessEntityRelations().PersonEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation StoreEntityUsingCustomerIdStatic = new BusinessEntityRelations().StoreEntityUsingCustomerId;
		internal static readonly IEntityRelation VendorEntityUsingVendorIdStatic = new BusinessEntityRelations().VendorEntityUsingVendorId;

		/// <summary>CTor</summary>
		static StaticBusinessEntityRelations()
		{
		}
	}
}
