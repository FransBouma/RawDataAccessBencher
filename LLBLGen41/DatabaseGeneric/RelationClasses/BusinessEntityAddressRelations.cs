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
	/// <summary>Implements the relations factory for the entity: BusinessEntityAddress. </summary>
	public partial class BusinessEntityAddressRelations
	{
		/// <summary>CTor</summary>
		public BusinessEntityAddressRelations()
		{
		}

		/// <summary>Gets all relations of the BusinessEntityAddressEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.AddressEntityUsingAddressId);
			toReturn.Add(this.AddressTypeEntityUsingAddressTypeId);
			toReturn.Add(this.BusinessEntityEntityUsingBusinessEntityId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between BusinessEntityAddressEntity and AddressEntity over the m:1 relation they have, using the relation between the fields:
		/// BusinessEntityAddress.AddressId - Address.AddressId
		/// </summary>
		public virtual IEntityRelation AddressEntityUsingAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Address", false);
				relation.AddEntityFieldPair(AddressFields.AddressId, BusinessEntityAddressFields.AddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityAddressEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BusinessEntityAddressEntity and AddressTypeEntity over the m:1 relation they have, using the relation between the fields:
		/// BusinessEntityAddress.AddressTypeId - AddressType.AddressTypeId
		/// </summary>
		public virtual IEntityRelation AddressTypeEntityUsingAddressTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "AddressType", false);
				relation.AddEntityFieldPair(AddressTypeFields.AddressTypeId, BusinessEntityAddressFields.AddressTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressTypeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityAddressEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between BusinessEntityAddressEntity and BusinessEntityEntity over the m:1 relation they have, using the relation between the fields:
		/// BusinessEntityAddress.BusinessEntityId - BusinessEntity.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation BusinessEntityEntityUsingBusinessEntityId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "BusinessEntity", false);
				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, BusinessEntityAddressFields.BusinessEntityId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityAddressEntity", true);
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
	internal static class StaticBusinessEntityAddressRelations
	{
		internal static readonly IEntityRelation AddressEntityUsingAddressIdStatic = new BusinessEntityAddressRelations().AddressEntityUsingAddressId;
		internal static readonly IEntityRelation AddressTypeEntityUsingAddressTypeIdStatic = new BusinessEntityAddressRelations().AddressTypeEntityUsingAddressTypeId;
		internal static readonly IEntityRelation BusinessEntityEntityUsingBusinessEntityIdStatic = new BusinessEntityAddressRelations().BusinessEntityEntityUsingBusinessEntityId;

		/// <summary>CTor</summary>
		static StaticBusinessEntityAddressRelations()
		{
		}
	}
}
