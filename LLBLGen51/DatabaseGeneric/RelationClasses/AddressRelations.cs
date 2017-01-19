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
using AdventureWorks.Dal.Adapter.v51;
using AdventureWorks.Dal.Adapter.v51.FactoryClasses;
using AdventureWorks.Dal.Adapter.v51.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v51.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Address. </summary>
	public partial class AddressRelations
	{
		/// <summary>CTor</summary>
		public AddressRelations()
		{
		}

		/// <summary>Gets all relations of the AddressEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.BusinessEntityAddressEntityUsingAddressId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingBillToAddressId);
			toReturn.Add(this.SalesOrderHeaderEntityUsingShipToAddressId);
			toReturn.Add(this.StateProvinceEntityUsingStateProvinceId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and BusinessEntityAddressEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - BusinessEntityAddress.AddressId
		/// </summary>
		public virtual IEntityRelation BusinessEntityAddressEntityUsingAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "BusinessEntityAddresses" , true);
				relation.AddEntityFieldPair(AddressFields.AddressId, BusinessEntityAddressFields.AddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityAddressEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - SalesOrderHeader.BillToAddressId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingBillToAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders" , true);
				relation.AddEntityFieldPair(AddressFields.AddressId, SalesOrderHeaderFields.BillToAddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between AddressEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Address.AddressId - SalesOrderHeader.ShipToAddressId
		/// </summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingShipToAddressId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "SalesOrderHeaders_" , true);
				relation.AddEntityFieldPair(AddressFields.AddressId, SalesOrderHeaderFields.ShipToAddressId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesOrderHeaderEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between AddressEntity and StateProvinceEntity over the m:1 relation they have, using the relation between the fields:
		/// Address.StateProvinceId - StateProvince.StateProvinceId
		/// </summary>
		public virtual IEntityRelation StateProvinceEntityUsingStateProvinceId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "StateProvince", false);
				relation.AddEntityFieldPair(StateProvinceFields.StateProvinceId, AddressFields.StateProvinceId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StateProvinceEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("AddressEntity", true);
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
	internal static class StaticAddressRelations
	{
		internal static readonly IEntityRelation BusinessEntityAddressEntityUsingAddressIdStatic = new AddressRelations().BusinessEntityAddressEntityUsingAddressId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingBillToAddressIdStatic = new AddressRelations().SalesOrderHeaderEntityUsingBillToAddressId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingShipToAddressIdStatic = new AddressRelations().SalesOrderHeaderEntityUsingShipToAddressId;
		internal static readonly IEntityRelation StateProvinceEntityUsingStateProvinceIdStatic = new AddressRelations().StateProvinceEntityUsingStateProvinceId;

		/// <summary>CTor</summary>
		static StaticAddressRelations()
		{
		}
	}
}
