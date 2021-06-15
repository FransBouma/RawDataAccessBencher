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
	/// <summary>Entity class which represents the entity 'SalesOrderDetail'.<br/><br/></summary>
	[Serializable]
	public partial class SalesOrderDetailEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private SalesOrderHeaderEntity _salesOrderHeader;
		private SpecialOfferProductEntity _specialOfferProduct;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static SalesOrderDetailEntityStaticMetaData _staticMetaData = new SalesOrderDetailEntityStaticMetaData();
		private static SalesOrderDetailRelations _relationsFactory = new SalesOrderDetailRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesOrderHeader</summary>
			public static readonly string SalesOrderHeader = "SalesOrderHeader";
			/// <summary>Member name SpecialOfferProduct</summary>
			public static readonly string SpecialOfferProduct = "SpecialOfferProduct";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class SalesOrderDetailEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public SalesOrderDetailEntityStaticMetaData()
			{
				SetEntityCoreInfo("SalesOrderDetailEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.SalesOrderDetailEntity, typeof(SalesOrderDetailEntity), typeof(SalesOrderDetailEntityFactory), false);
				AddNavigatorMetaData<SalesOrderDetailEntity, SalesOrderHeaderEntity>("SalesOrderHeader", "SalesOrderDetails", (a, b) => a._salesOrderHeader = b, a => a._salesOrderHeader, (a, b) => a.SalesOrderHeader = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticSalesOrderDetailRelations.SalesOrderHeaderEntityUsingSalesOrderIdStatic, ()=>new SalesOrderDetailRelations().SalesOrderHeaderEntityUsingSalesOrderId, null, new int[] { (int)SalesOrderDetailFieldIndex.SalesOrderId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.SalesOrderHeaderEntity);
				AddNavigatorMetaData<SalesOrderDetailEntity, SpecialOfferProductEntity>("SpecialOfferProduct", "SalesOrderDetails", (a, b) => a._specialOfferProduct = b, a => a._specialOfferProduct, (a, b) => a.SpecialOfferProduct = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticSalesOrderDetailRelations.SpecialOfferProductEntityUsingProductIdSpecialOfferIdStatic, ()=>new SalesOrderDetailRelations().SpecialOfferProductEntityUsingProductIdSpecialOfferId, null, new int[] { (int)SalesOrderDetailFieldIndex.ProductId, (int)SalesOrderDetailFieldIndex.SpecialOfferId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.SpecialOfferProductEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static SalesOrderDetailEntity()
		{
		}

		/// <summary> CTor</summary>
		public SalesOrderDetailEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesOrderDetailEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesOrderDetailEntity</param>
		public SalesOrderDetailEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="salesOrderDetailId">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderId">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailId, System.Int32 salesOrderId) : this(salesOrderDetailId, salesOrderId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="salesOrderDetailId">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderId">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="validator">The custom validator object for this SalesOrderDetailEntity</param>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailId, System.Int32 salesOrderId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.SalesOrderDetailId = salesOrderDetailId;
			this.SalesOrderId = salesOrderId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeader() { return CreateRelationInfoForNavigator("SalesOrderHeader"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SpecialOfferProduct' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOfferProduct() { return CreateRelationInfoForNavigator("SpecialOfferProduct"); }
		
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
		/// <param name="validator">The validator object for this SalesOrderDetailEntity</param>
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
		public static SalesOrderDetailRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeader { get { return _staticMetaData.GetPrefetchPathElement("SalesOrderHeader", CommonEntityBase.CreateEntityCollection<SalesOrderHeaderEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOfferProduct { get { return _staticMetaData.GetPrefetchPathElement("SpecialOfferProduct", CommonEntityBase.CreateEntityCollection<SpecialOfferProductEntity>()); } }

		/// <summary>The CarrierTrackingNumber property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."CarrierTrackingNumber".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CarrierTrackingNumber
		{
			get { return (System.String)GetValue((int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, value); }
		}

		/// <summary>The LineTotal property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."LineTotal".<br/>Table field type characteristics (type, precision, scale, length): Decimal, 38, 6, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal LineTotal
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.LineTotal, true); }
		}

		/// <summary>The ModifiedDate property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderDetailFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The OrderQty property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."OrderQty".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 OrderQty
		{
			get { return (System.Int16)GetValue((int)SalesOrderDetailFieldIndex.OrderQty, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.OrderQty, value); }
		}

		/// <summary>The ProductId property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.ProductId, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.ProductId, value); }
		}

		/// <summary>The Rowguid property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesOrderDetailFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.Rowguid, value); }
		}

		/// <summary>The SalesOrderDetailId property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SalesOrderDetailID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesOrderDetailId
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SalesOrderDetailId, true); }
			set { SetValue((int)SalesOrderDetailFieldIndex.SalesOrderDetailId, value); }		}

		/// <summary>The SalesOrderId property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SalesOrderID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesOrderId
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SalesOrderId, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.SalesOrderId, value); }
		}

		/// <summary>The SpecialOfferId property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SpecialOfferID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 SpecialOfferId
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SpecialOfferId, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.SpecialOfferId, value); }
		}

		/// <summary>The UnitPrice property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."UnitPrice".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.UnitPrice, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.UnitPrice, value); }
		}

		/// <summary>The UnitPriceDiscount property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."UnitPriceDiscount".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPriceDiscount
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.UnitPriceDiscount, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.UnitPriceDiscount, value); }
		}

		/// <summary>Gets / sets related entity of type 'SalesOrderHeaderEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SalesOrderHeaderEntity SalesOrderHeader
		{
			get { return _salesOrderHeader; }
			set { SetSingleRelatedEntityNavigator(value, "SalesOrderHeader"); }
		}

		/// <summary>Gets / sets related entity of type 'SpecialOfferProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SpecialOfferProductEntity SpecialOfferProduct
		{
			get { return _specialOfferProduct; }
			set { SetSingleRelatedEntityNavigator(value, "SpecialOfferProduct"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum SalesOrderDetailFieldIndex
	{
		///<summary>CarrierTrackingNumber. </summary>
		CarrierTrackingNumber,
		///<summary>LineTotal. </summary>
		LineTotal,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesOrderDetailId. </summary>
		SalesOrderDetailId,
		///<summary>SalesOrderId. </summary>
		SalesOrderId,
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		///<summary>UnitPriceDiscount. </summary>
		UnitPriceDiscount,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SalesOrderDetail. </summary>
	public partial class SalesOrderDetailRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between SalesOrderDetailEntity and SalesOrderHeaderEntity over the m:1 relation they have, using the relation between the fields: SalesOrderDetail.SalesOrderId - SalesOrderHeader.SalesOrderId</summary>
		public virtual IEntityRelation SalesOrderHeaderEntityUsingSalesOrderId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "SalesOrderHeader", false, new[] { SalesOrderHeaderFields.SalesOrderId, SalesOrderDetailFields.SalesOrderId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between SalesOrderDetailEntity and SpecialOfferProductEntity over the m:1 relation they have, using the relation between the fields: SalesOrderDetail.ProductId - SpecialOfferProduct.ProductId, SalesOrderDetail.SpecialOfferId - SpecialOfferProduct.SpecialOfferId</summary>
		public virtual IEntityRelation SpecialOfferProductEntityUsingProductIdSpecialOfferId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "SpecialOfferProduct", false, new[] { SpecialOfferProductFields.ProductId, SalesOrderDetailFields.ProductId, SpecialOfferProductFields.SpecialOfferId, SalesOrderDetailFields.SpecialOfferId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSalesOrderDetailRelations
	{
		internal static readonly IEntityRelation SalesOrderHeaderEntityUsingSalesOrderIdStatic = new SalesOrderDetailRelations().SalesOrderHeaderEntityUsingSalesOrderId;
		internal static readonly IEntityRelation SpecialOfferProductEntityUsingProductIdSpecialOfferIdStatic = new SalesOrderDetailRelations().SpecialOfferProductEntityUsingProductIdSpecialOfferId;

		/// <summary>CTor</summary>
		static StaticSalesOrderDetailRelations() { }
	}
}
