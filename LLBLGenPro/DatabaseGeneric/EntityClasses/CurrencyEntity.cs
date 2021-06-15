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
	/// <summary>Entity class which represents the entity 'Currency'.<br/><br/></summary>
	[Serializable]
	public partial class CurrencyEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<CountryRegionCurrencyEntity> _countryRegionCurrencies;
		private EntityCollection<CurrencyRateEntity> _currencyRates;
		private EntityCollection<CurrencyRateEntity> _currencyRates_;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static CurrencyEntityStaticMetaData _staticMetaData = new CurrencyEntityStaticMetaData();
		private static CurrencyRelations _relationsFactory = new CurrencyRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegionCurrencies</summary>
			public static readonly string CountryRegionCurrencies = "CountryRegionCurrencies";
			/// <summary>Member name CurrencyRates</summary>
			public static readonly string CurrencyRates = "CurrencyRates";
			/// <summary>Member name CurrencyRates_</summary>
			public static readonly string CurrencyRates_ = "CurrencyRates_";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class CurrencyEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public CurrencyEntityStaticMetaData()
			{
				SetEntityCoreInfo("CurrencyEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.CurrencyEntity, typeof(CurrencyEntity), typeof(CurrencyEntityFactory), false);
				AddNavigatorMetaData<CurrencyEntity, EntityCollection<CountryRegionCurrencyEntity>>("CountryRegionCurrencies", a => a._countryRegionCurrencies, (a, b) => a._countryRegionCurrencies = b, a => a.CountryRegionCurrencies, () => new CurrencyRelations().CountryRegionCurrencyEntityUsingCurrencyCode, typeof(CountryRegionCurrencyEntity), (int)AdventureWorks.Dal.Adapter.EntityType.CountryRegionCurrencyEntity);
				AddNavigatorMetaData<CurrencyEntity, EntityCollection<CurrencyRateEntity>>("CurrencyRates", a => a._currencyRates, (a, b) => a._currencyRates = b, a => a.CurrencyRates, () => new CurrencyRelations().CurrencyRateEntityUsingFromCurrencyCode, typeof(CurrencyRateEntity), (int)AdventureWorks.Dal.Adapter.EntityType.CurrencyRateEntity);
				AddNavigatorMetaData<CurrencyEntity, EntityCollection<CurrencyRateEntity>>("CurrencyRates_", a => a._currencyRates_, (a, b) => a._currencyRates_ = b, a => a.CurrencyRates_, () => new CurrencyRelations().CurrencyRateEntityUsingToCurrencyCode, typeof(CurrencyRateEntity), (int)AdventureWorks.Dal.Adapter.EntityType.CurrencyRateEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static CurrencyEntity()
		{
		}

		/// <summary> CTor</summary>
		public CurrencyEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CurrencyEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CurrencyEntity</param>
		public CurrencyEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		public CurrencyEntity(System.String currencyCode) : this(currencyCode, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="currencyCode">PK value for Currency which data should be fetched into this Currency object</param>
		/// <param name="validator">The custom validator object for this CurrencyEntity</param>
		public CurrencyEntity(System.String currencyCode, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.CurrencyCode = currencyCode;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected CurrencyEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CountryRegionCurrency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegionCurrencies() { return CreateRelationInfoForNavigator("CountryRegionCurrencies"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRates() { return CreateRelationInfoForNavigator("CurrencyRates"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRates_() { return CreateRelationInfoForNavigator("CurrencyRates_"); }
		
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
		/// <param name="validator">The validator object for this CurrencyEntity</param>
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
		public static CurrencyRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegionCurrency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegionCurrencies { get { return _staticMetaData.GetPrefetchPathElement("CountryRegionCurrencies", CommonEntityBase.CreateEntityCollection<CountryRegionCurrencyEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRates { get { return _staticMetaData.GetPrefetchPathElement("CurrencyRates", CommonEntityBase.CreateEntityCollection<CurrencyRateEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRates_ { get { return _staticMetaData.GetPrefetchPathElement("CurrencyRates_", CommonEntityBase.CreateEntityCollection<CurrencyRateEntity>()); } }

		/// <summary>The CurrencyCode property of the Entity Currency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."CurrencyCode".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CurrencyCode
		{
			get { return (System.String)GetValue((int)CurrencyFieldIndex.CurrencyCode, true); }
			set	{ SetValue((int)CurrencyFieldIndex.CurrencyCode, value); }
		}

		/// <summary>The ModifiedDate property of the Entity Currency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CurrencyFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CurrencyFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity Currency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Currency"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)CurrencyFieldIndex.Name, true); }
			set	{ SetValue((int)CurrencyFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'CountryRegionCurrencyEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CountryRegionCurrencyEntity))]
		public virtual EntityCollection<CountryRegionCurrencyEntity> CountryRegionCurrencies { get { return GetOrCreateEntityCollection<CountryRegionCurrencyEntity, CountryRegionCurrencyEntityFactory>("Currency", true, false, ref _countryRegionCurrencies); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRates { get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("Currency", true, false, ref _currencyRates); } }

		/// <summary>Gets the EntityCollection with the related entities of type 'CurrencyRateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CurrencyRateEntity))]
		public virtual EntityCollection<CurrencyRateEntity> CurrencyRates_ { get { return GetOrCreateEntityCollection<CurrencyRateEntity, CurrencyRateEntityFactory>("Currency_", true, false, ref _currencyRates_); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum CurrencyFieldIndex
	{
		///<summary>CurrencyCode. </summary>
		CurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Currency. </summary>
	public partial class CurrencyRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between CurrencyEntity and CountryRegionCurrencyEntity over the 1:n relation they have, using the relation between the fields: Currency.CurrencyCode - CountryRegionCurrency.CurrencyCode</summary>
		public virtual IEntityRelation CountryRegionCurrencyEntityUsingCurrencyCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "CountryRegionCurrencies", true, new[] { CurrencyFields.CurrencyCode, CountryRegionCurrencyFields.CurrencyCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between CurrencyEntity and CurrencyRateEntity over the 1:n relation they have, using the relation between the fields: Currency.CurrencyCode - CurrencyRate.FromCurrencyCode</summary>
		public virtual IEntityRelation CurrencyRateEntityUsingFromCurrencyCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "CurrencyRates", true, new[] { CurrencyFields.CurrencyCode, CurrencyRateFields.FromCurrencyCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between CurrencyEntity and CurrencyRateEntity over the 1:n relation they have, using the relation between the fields: Currency.CurrencyCode - CurrencyRate.ToCurrencyCode</summary>
		public virtual IEntityRelation CurrencyRateEntityUsingToCurrencyCode
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "CurrencyRates_", true, new[] { CurrencyFields.CurrencyCode, CurrencyRateFields.ToCurrencyCode }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticCurrencyRelations
	{
		internal static readonly IEntityRelation CountryRegionCurrencyEntityUsingCurrencyCodeStatic = new CurrencyRelations().CountryRegionCurrencyEntityUsingCurrencyCode;
		internal static readonly IEntityRelation CurrencyRateEntityUsingFromCurrencyCodeStatic = new CurrencyRelations().CurrencyRateEntityUsingFromCurrencyCode;
		internal static readonly IEntityRelation CurrencyRateEntityUsingToCurrencyCodeStatic = new CurrencyRelations().CurrencyRateEntityUsingToCurrencyCode;

		/// <summary>CTor</summary>
		static StaticCurrencyRelations() { }
	}
}
