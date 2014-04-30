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
	/// <summary>Implements the relations factory for the entity: AddressType. </summary>
	public partial class AddressTypeRelations
	{
		/// <summary>CTor</summary>
		public AddressTypeRelations()
		{
		}

		/// <summary>Gets all relations of the AddressTypeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BusinessEntityAddressEntityUsingAddressTypeId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AddressTypeEntity and BusinessEntityAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// AddressType.AddressTypeId - BusinessEntityAddress.AddressTypeId
		/// </summary>
		public virtual IEntityRelation BusinessEntityAddressEntityUsingAddressTypeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BusinessEntityAddresses" , true);
				relation.AddEntityFieldPair(AddressTypeFields.AddressTypeId, BusinessEntityAddressFields.AddressTypeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressTypeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityAddressEntity", false);
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
	internal static class StaticAddressTypeRelations
	{
		internal static readonly IEntityRelation BusinessEntityAddressEntityUsingAddressTypeIdStatic = new AddressTypeRelations().BusinessEntityAddressEntityUsingAddressTypeId;

		/// <summary>CTor</summary>
		static StaticAddressTypeRelations()
		{
		}
	}
}
