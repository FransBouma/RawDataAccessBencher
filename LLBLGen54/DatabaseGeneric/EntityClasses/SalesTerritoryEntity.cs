﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v54.HelperClasses;
using AdventureWorks.Dal.Adapter.v54.FactoryClasses;
using AdventureWorks.Dal.Adapter.v54.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v54.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'SalesTerritory'.<br/><br/></summary>
	[Serializable]
	public partial class SalesTerritoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<CustomerEntity> _customers;
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<SalesPersonEntity> _salesPeople;
		private EntityCollection<SalesTerritoryHistoryEntity> _salesTerritoryHistories;
		private EntityCollection<StateProvinceEntity> _stateProvinces;
		private CountryRegionEntity _countryRegion;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static SalesTerritoryEntityStaticMetaData _staticMetaData = new SalesTerritoryEntityStaticMetaData();
		private static SalesTerritoryRelations _relationsFactory = new SalesTerritoryRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegion</summary>
			public static readonly string CountryRegion = "CountryRegion";
			/// <summary>Member name Customers</summary>
			public static readonly string Customers = "Customers";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesPeople</summary>
			public static readonly string SalesPeople = "SalesPeople";
			/// <summary>Member name SalesTerritoryHistories</summary>
			public static readonly string SalesTerritoryHistories = "SalesTerritoryHistories";
			/// <summary>Member name StateProvinces</summary>
			public static readonly string StateProvinces = "StateProvinces";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class SalesTerritoryEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public SalesTerritoryEntityStaticMetaData()
			{
				SetEntityCoreInfo("SalesTerritoryEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesTerritoryEntity, typeof(SalesTerritoryEntity), typeof(SalesTerritoryEntityFactory), false);
				AddNavigatorMetaData<SalesTerritoryEntity, EntityCollection<CustomerEntity>>("Customers", a => a._customers, (a, b) => a._customers = b, a => a.Customers, () => new SalesTerritoryRelations().CustomerEntityUsingTerritoryId, typeof(CustomerEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.CustomerEntity);
				AddNavigatorMetaData<SalesTerritoryEntity, EntityCollection<SalesOrderHeaderEntity>>("SalesOrderHeaders", a => a._salesOrderHeaders, (a, b) => a._salesOrderHeaders = b, a => a.SalesOrderHeaders, () => new SalesTerritoryRelations().SalesOrderHeaderEntityUsingTerritoryId, typeof(SalesOrderHeaderEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesOrderHeaderEntity);
				AddNavigatorMetaData<SalesTerritoryEntity, EntityCollection<SalesPersonEntity>>("SalesPeople", a => a._salesPeople, (a, b) => a._salesPeople = b, a => a.SalesPeople, () => new SalesTerritoryRelations().SalesPersonEntityUsingTerritoryId, typeof(SalesPersonEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesPersonEntity);
				AddNavigatorMetaData<SalesTerritoryEntity, EntityCollection<SalesTerritoryHistoryEntity>>("SalesTerritoryHistories", a => a._salesTerritoryHistories, (a, b) => a._salesTerritoryHistories = b, a => a.SalesTerritoryHistories, () => new SalesTerritoryRelations().SalesTerritoryHistoryEntityUsingTerritoryId, typeof(SalesTerritoryHistoryEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.SalesTerritoryHistoryEntity);
				AddNavigatorMetaData<SalesTerritoryEntity, EntityCollection<StateProvinceEntity>>("StateProvinces", a => a._stateProvinces, (a, b) => a._stateProvinces = b, a => a.StateProvinces, () => new SalesTerritoryRelations().StateProvinceEntityUsingTerritoryId, typeof(StateProvinceEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.StateProvinceEntity);
				AddNavigatorMetaData<SalesTerritoryEntity, CountryRegionEntity>("CountryRegion", "SalesTerritories", (a, b) => a._countryRegion = b, a => a._countryRegion, (a, b) => a.CountryRegion = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticSalesTerritoryRelations.CountryRegionEntityUsingCountryRegionCodeStatic, ()=>new SalesTerritoryRelations().CountryRegionEntityUsingCountryRegionCode, null, new int[] { (int)SalesTerritoryFieldIndex.CountryRegionCode }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.CountryRegionEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static SalesTerritoryEntity()
		{
		}

		/// <summary> CTor</summary>
		public SalesTerritoryEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesTerritoryEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesTerritoryEntity</param>
		public SalesTerritoryEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="territoryId">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		public SalesTerritoryEntity(System.Int32 territoryId) : this(territoryId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="territoryId">PK value for SalesTerritory which data should be fetched into this SalesTerritory object</param>
		/// <param name="validator">The custom validator object for this SalesTerritoryEntity</param>
		public SalesTerritoryEntity(System.Int32 territoryId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.TerritoryId = territoryId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesTerritoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomers() { return CreateRelationInfoForNavigator("Customers"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders() { return CreateRelationInfoForNavigator("SalesOrderHeaders"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPeople() { return CreateRelationInfoForNavigator("SalesPeople"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritoryHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryHistories() { return CreateRelationInfoForNavigator("SalesTerritoryHistories"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'StateProvince' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStateProvinces() { return CreateRelationInfoForNavigator("StateProvinces"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CountryRegion' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegion() { return CreateRelationInfoForNavigator("CountryRegion"); }
		
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
		/// <param name="validator">The validator object for this SalesTerritoryEntity</param>
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
		public static SalesTerritoryRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomers { get { return _staticMetaData.GetPrefetchPathElement("Customers", CommonEntityBase.CreateEntityCollection<CustomerEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders { get { return _staticMetaData.GetPrefetchPathElement("SalesOrderHeaders", CommonEntityBase.CreateEntityCollection<SalesOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPeople { get { return _staticMetaData.GetPrefetchPathElement("SalesPeople", CommonEntityBase.CreateEntityCollection<SalesPersonEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritoryHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryHistories { get { return _staticMetaData.GetPrefetchPathElement("SalesTerritoryHistories", CommonEntityBase.CreateEntityCollection<SalesTerritoryHistoryEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'StateProvince' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStateProvinces { get { return _staticMetaData.GetPrefetchPathElement("StateProvinces", CommonEntityBase.CreateEntityCollection<StateProvinceEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegion' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegion { get { return _staticMetaData.GetPrefetchPathElement("CountryRegion", CommonEntityBase.CreateEntityCollection<CountryRegionEntity>()); } }

		/// <summary>The CostLastYear property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CostLastYear".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.CostLastYear, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CostLastYear, value); }
		}

		/// <summary>The CostYtd property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CostYTD".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CostYtd
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.CostYtd, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CostYtd, value); }
		}

		/// <summary>The CountryRegionCode property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."CountryRegionCode".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.CountryRegionCode, value); }
		}

		/// <summary>The Group property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."Group".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Group
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.Group, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Group, value); }
		}

		/// <summary>The ModifiedDate property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesTerritoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)SalesTerritoryFieldIndex.Name, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Name, value); }
		}

		/// <summary>The Rowguid property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesTerritoryFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.Rowguid, value); }
		}

		/// <summary>The SalesLastYear property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."SalesLastYear".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.SalesLastYear, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.SalesLastYear, value); }
		}

		/// <summary>The SalesYtd property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."SalesYTD".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesYtd
		{
			get { return (System.Decimal)GetValue((int)SalesTerritoryFieldIndex.SalesYtd, true); }
			set	{ SetValue((int)SalesTerritoryFieldIndex.SalesYtd, value); }
		}

		/// <summary>The TerritoryId property of the Entity SalesTerritory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesTerritory"."TerritoryID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 TerritoryId
		{
			get { return (System.Int32)GetValue((int)SalesTerritoryFieldIndex.TerritoryId, true); }
			set { SetValue((int)SalesTerritoryFieldIndex.TerritoryId, value); }		}

		/// <summary>Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> Customers { get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("SalesTerritory", true, false, ref _customers); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders { get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("SalesTerritory", true, false, ref _salesOrderHeaders); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesPersonEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonEntity))]
		public virtual EntityCollection<SalesPersonEntity> SalesPeople { get { return GetOrCreateEntityCollection<SalesPersonEntity, SalesPersonEntityFactory>("SalesTerritory", true, false, ref _salesPeople); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'SalesTerritoryHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryHistoryEntity))]
		public virtual EntityCollection<SalesTerritoryHistoryEntity> SalesTerritoryHistories { get { return GetOrCreateEntityCollection<SalesTerritoryHistoryEntity, SalesTerritoryHistoryEntityFactory>("SalesTerritory", true, false, ref _salesTerritoryHistories); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'StateProvinceEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(StateProvinceEntity))]
		public virtual EntityCollection<StateProvinceEntity> StateProvinces { get { return GetOrCreateEntityCollection<StateProvinceEntity, StateProvinceEntityFactory>("SalesTerritory", true, false, ref _stateProvinces); } }

		/// <summary>Gets / sets related entity of type 'CountryRegionEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CountryRegionEntity CountryRegion
		{
			get { return _countryRegion; }
			set { SetSingleRelatedEntityNavigator(value, "CountryRegion"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum SalesTerritoryFieldIndex
	{
		///<summary>CostLastYear. </summary>
		CostLastYear,
		///<summary>CostYtd. </summary>
		CostYtd,
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>Group. </summary>
		Group,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesLastYear. </summary>
		SalesLastYear,
		///<summary>SalesYtd. </summary>
		SalesYtd,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SalesTerritory. </summary>
	public partial class SalesTerritoryRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and CustomerEntity over the 1:n relation they have, using the relation between the fields: SalesTerritory.TerritoryId - Customer.TerritoryId</summary>
		public virtual IEntityRelation CustomerEntityUsingTerritoryId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Customers", true, new[] { SalesTerritoryFields.TerritoryId, CustomerFields.TerritoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesOrderHeaderEntity over the 1:n relation they have, using the relation between the fields: SalesTerritory.TerritoryId - SalesOrderHeader.TerritoryId</summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingTerritoryId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesOrderHeaders", true, new[] { SalesTerritoryFields.TerritoryId, SalesOrderHeaderFields.TerritoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesPersonEntity over the 1:n relation they have, using the relation between the fields: SalesTerritory.TerritoryId - SalesPerson.TerritoryId</summary>
		public virtual IEntityRelation SalesPersonEntityUsingTerritoryId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesPeople", true, new[] { SalesTerritoryFields.TerritoryId, SalesPersonFields.TerritoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and SalesTerritoryHistoryEntity over the 1:n relation they have, using the relation between the fields: SalesTerritory.TerritoryId - SalesTerritoryHistory.TerritoryId</summary>
		public virtual IEntityRelation SalesTerritoryHistoryEntityUsingTerritoryId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "SalesTerritoryHistories", true, new[] { SalesTerritoryFields.TerritoryId, SalesTerritoryHistoryFields.TerritoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and StateProvinceEntity over the 1:n relation they have, using the relation between the fields: SalesTerritory.TerritoryId - StateProvince.TerritoryId</summary>
		public virtual IEntityRelation StateProvinceEntityUsingTerritoryId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "StateProvinces", true, new[] { SalesTerritoryFields.TerritoryId, StateProvinceFields.TerritoryId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesTerritoryEntity and CountryRegionEntity over the m:1 relation they have, using the relation between the fields: SalesTerritory.CountryRegionCode - CountryRegion.CountryRegionCode</summary>
		public virtual IEntityRelation CountryRegionEntityUsingCountryRegionCode
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "CountryRegion", false, new[] { CountryRegionFields.CountryRegionCode, SalesTerritoryFields.CountryRegionCode }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesTerritoryRelations
	{
		internal static readonly IEntityRelation CustomerEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().CustomerEntityUsingTerritoryId;
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().SalesOrderHeaderEntityUsingTerritoryId;
		internal static readonly IEntityRelation SalesPersonEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().SalesPersonEntityUsingTerritoryId;
		internal static readonly IEntityRelation SalesTerritoryHistoryEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().SalesTerritoryHistoryEntityUsingTerritoryId;
		internal static readonly IEntityRelation StateProvinceEntityUsingTerritoryIdStatic = new SalesTerritoryRelations().StateProvinceEntityUsingTerritoryId;
		internal static readonly IEntityRelation CountryRegionEntityUsingCountryRegionCodeStatic = new SalesTerritoryRelations().CountryRegionEntityUsingCountryRegionCode;

		/// <summary>CTor</summary>
		static StaticSalesTerritoryRelations() { }
	}
}
