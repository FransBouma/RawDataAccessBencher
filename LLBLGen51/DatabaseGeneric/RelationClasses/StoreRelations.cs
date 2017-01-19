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
	/// <summary>Implements the relations factory for the entity: Store. </summary>
	public partial class StoreRelations
	{
		/// <summary>CTor</summary>
		public StoreRelations()
		{
		}

		/// <summary>Gets all relations of the StoreEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.CustomerEntityUsingStoreId);
			toReturn.Add(this.BusinessEntityEntityUsingCustomerId);
			toReturn.Add(this.SalesPersonEntityUsingSalesPersonId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and CustomerEntity over the 1:n relation they have, using the relation between the fields:
		/// Store.CustomerId - Customer.StoreId
		/// </summary>
		public virtual IEntityRelation CustomerEntityUsingStoreId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Customers" , true);
				relation.AddEntityFieldPair(StoreFields.CustomerId, CustomerFields.StoreId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CustomerEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and BusinessEntityEntity over the 1:1 relation they have, using the relation between the fields:
		/// Store.CustomerId - BusinessEntity.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation BusinessEntityEntityUsingCustomerId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "BusinessEntity", false);



				relation.AddEntityFieldPair(BusinessEntityFields.BusinessEntityId, StoreFields.CustomerId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("BusinessEntityEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and SalesPersonEntity over the m:1 relation they have, using the relation between the fields:
		/// Store.SalesPersonId - SalesPerson.SalesPersonId
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingSalesPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SalesPerson", false);
				relation.AddEntityFieldPair(SalesPersonFields.SalesPersonId, StoreFields.SalesPersonId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("StoreEntity", true);
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
	internal static class StaticStoreRelations
	{
		internal static readonly IEntityRelation CustomerEntityUsingStoreIdStatic = new StoreRelations().CustomerEntityUsingStoreId;
		internal static readonly IEntityRelation BusinessEntityEntityUsingCustomerIdStatic = new StoreRelations().BusinessEntityEntityUsingCustomerId;
		internal static readonly IEntityRelation SalesPersonEntityUsingSalesPersonIdStatic = new StoreRelations().SalesPersonEntityUsingSalesPersonId;

		/// <summary>CTor</summary>
		static StaticStoreRelations()
		{
		}
	}
}
