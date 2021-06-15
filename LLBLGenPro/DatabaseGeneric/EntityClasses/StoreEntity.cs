﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.8.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Store'.<br/><br/></summary>
	[Serializable]
	public partial class StoreEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<CustomerEntity> _customers;
		private SalesPersonEntity _salesPerson;
		private BusinessEntityEntity _businessEntity;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static StoreEntityStaticMetaData _staticMetaData = new StoreEntityStaticMetaData();
		private static StoreRelations _relationsFactory = new StoreRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
			/// <summary>Member name Customers</summary>
			public static readonly string Customers = "Customers";
			/// <summary>Member name BusinessEntity</summary>
			public static readonly string BusinessEntity = "BusinessEntity";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class StoreEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public StoreEntityStaticMetaData()
			{
				SetEntityCoreInfo("StoreEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.StoreEntity, typeof(StoreEntity), typeof(StoreEntityFactory), false);
				AddNavigatorMetaData<StoreEntity, EntityCollection<CustomerEntity>>("Customers", a => a._customers, (a, b) => a._customers = b, a => a.Customers, () => new StoreRelations().CustomerEntityUsingStoreId, typeof(CustomerEntity), (int)AdventureWorks.Dal.Adapter.EntityType.CustomerEntity);
				AddNavigatorMetaData<StoreEntity, SalesPersonEntity>("SalesPerson", "Stores", (a, b) => a._salesPerson = b, a => a._salesPerson, (a, b) => a.SalesPerson = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticStoreRelations.SalesPersonEntityUsingSalesPersonIdStatic, ()=>new StoreRelations().SalesPersonEntityUsingSalesPersonId, null, new int[] { (int)StoreFieldIndex.SalesPersonId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.SalesPersonEntity);
				AddNavigatorMetaData<StoreEntity, BusinessEntityEntity>("BusinessEntity", "Store", (a, b) => a._businessEntity = b, a => a._businessEntity, (a, b) => a.BusinessEntity = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticStoreRelations.BusinessEntityEntityUsingCustomerIdStatic, ()=>new StoreRelations().BusinessEntityEntityUsingCustomerId, null, new int[] { (int)StoreFieldIndex.CustomerId }, null, false, (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static StoreEntity()
		{
		}

		/// <summary> CTor</summary>
		public StoreEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public StoreEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this StoreEntity</param>
		public StoreEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="customerId">PK value for Store which data should be fetched into this Store object</param>
		public StoreEntity(System.Int32 customerId) : this(customerId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="customerId">PK value for Store which data should be fetched into this Store object</param>
		/// <param name="validator">The custom validator object for this StoreEntity</param>
		public StoreEntity(System.Int32 customerId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.CustomerId = customerId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected StoreEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomers() { return CreateRelationInfoForNavigator("Customers"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPerson() { return CreateRelationInfoForNavigator("SalesPerson"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'BusinessEntity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntity() { return CreateRelationInfoForNavigator("BusinessEntity"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this StoreEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static StoreRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomers { get { return _staticMetaData.GetPrefetchPathElement("Customers", CommonEntityBase.CreateEntityCollection<CustomerEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPerson { get { return _staticMetaData.GetPrefetchPathElement("SalesPerson", CommonEntityBase.CreateEntityCollection<SalesPersonEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntity { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntity", CommonEntityBase.CreateEntityCollection<BusinessEntityEntity>()); } }

		/// <summary>The CustomerId property of the Entity Store<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Store"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 CustomerId
		{
			get { return (System.Int32)GetValue((int)StoreFieldIndex.CustomerId, true); }
			set	{ SetValue((int)StoreFieldIndex.CustomerId, value); }
		}

		/// <summary>The Demographics property of the Entity Store<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Store"."Demographics".<br/>Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Demographics
		{
			get { return (System.String)GetValue((int)StoreFieldIndex.Demographics, true); }
			set	{ SetValue((int)StoreFieldIndex.Demographics, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Store<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Store"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)StoreFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)StoreFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity Store<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Store"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)StoreFieldIndex.Name, true); }
			set	{ SetValue((int)StoreFieldIndex.Name, value); }
		}

		/// <summary>The Rowguid property of the Entity Store<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Store"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)StoreFieldIndex.Rowguid, true); }
			set	{ SetValue((int)StoreFieldIndex.Rowguid, value); }
		}

		/// <summary>The SalesPersonId property of the Entity Store<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Store"."SalesPersonID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SalesPersonId
		{
			get { return (Nullable<System.Int32>)GetValue((int)StoreFieldIndex.SalesPersonId, false); }
			set	{ SetValue((int)StoreFieldIndex.SalesPersonId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> Customers { get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("Store", true, false, ref _customers); } }

		/// <summary>Gets / sets related entity of type 'SalesPersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get { return _salesPerson; }
			set { SetSingleRelatedEntityNavigator(value, "SalesPerson"); }
		}

		/// <summary>Gets / sets related entity of type 'BusinessEntityEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/></summary>
		[Browsable(false)]
		public virtual BusinessEntityEntity BusinessEntity
		{
			get { return _businessEntity; }
			set { SetSingleRelatedEntityNavigator(value, "BusinessEntity"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum StoreFieldIndex
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>Demographics. </summary>
		Demographics,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesPersonId. </summary>
		SalesPersonId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Store. </summary>
	public partial class StoreRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between StoreEntity and CustomerEntity over the 1:n relation they have, using the relation between the fields: Store.CustomerId - Customer.StoreId</summary>
		public virtual IEntityRelation CustomerEntityUsingStoreId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Customers", true, new[] { StoreFields.CustomerId, CustomerFields.StoreId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and BusinessEntityEntity over the 1:1 relation they have, using the relation between the fields: Store.CustomerId - BusinessEntity.BusinessEntityId</summary>
		public virtual IEntityRelation BusinessEntityEntityUsingCustomerId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToOne, "BusinessEntity", false, new[] { BusinessEntityFields.BusinessEntityId, StoreFields.CustomerId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between StoreEntity and SalesPersonEntity over the m:1 relation they have, using the relation between the fields: Store.SalesPersonId - SalesPerson.SalesPersonId</summary>
		public virtual IEntityRelation SalesPersonEntityUsingSalesPersonId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "SalesPerson", false, new[] { SalesPersonFields.SalesPersonId, StoreFields.SalesPersonId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticStoreRelations
	{
		internal static readonly IEntityRelation CustomerEntityUsingStoreIdStatic = new StoreRelations().CustomerEntityUsingStoreId;
		internal static readonly IEntityRelation BusinessEntityEntityUsingCustomerIdStatic = new StoreRelations().BusinessEntityEntityUsingCustomerId;
		internal static readonly IEntityRelation SalesPersonEntityUsingSalesPersonIdStatic = new StoreRelations().SalesPersonEntityUsingSalesPersonId;

		/// <summary>CTor</summary>
		static StaticStoreRelations() { }
	}
}
