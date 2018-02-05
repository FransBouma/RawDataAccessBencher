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
	/// <summary>Entity class which represents the entity 'WorkOrder'.<br/><br/></summary>
	[Serializable]
	public partial class WorkOrderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<WorkOrderRoutingEntity> _workOrderRoutings;
		private ProductEntity _product;
		private ScrapReasonEntity _scrapReason;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static WorkOrderEntityStaticMetaData _staticMetaData = new WorkOrderEntityStaticMetaData();
		private static WorkOrderRelations _relationsFactory = new WorkOrderRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name ScrapReason</summary>
			public static readonly string ScrapReason = "ScrapReason";
			/// <summary>Member name WorkOrderRoutings</summary>
			public static readonly string WorkOrderRoutings = "WorkOrderRoutings";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class WorkOrderEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public WorkOrderEntityStaticMetaData()
			{
				SetEntityCoreInfo("WorkOrderEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.WorkOrderEntity, typeof(WorkOrderEntity), typeof(WorkOrderEntityFactory), false);
				AddNavigatorMetaData<WorkOrderEntity, EntityCollection<WorkOrderRoutingEntity>>("WorkOrderRoutings", a => a._workOrderRoutings, (a, b) => a._workOrderRoutings = b, a => a.WorkOrderRoutings, () => new WorkOrderRelations().WorkOrderRoutingEntityUsingWorkOrderId, typeof(WorkOrderRoutingEntity), (int)AdventureWorks.Dal.Adapter.v54.EntityType.WorkOrderRoutingEntity);
				AddNavigatorMetaData<WorkOrderEntity, ProductEntity>("Product", "WorkOrders", (a, b) => a._product = b, a => a._product, (a, b) => a.Product = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticWorkOrderRelations.ProductEntityUsingProductIdStatic, ()=>new WorkOrderRelations().ProductEntityUsingProductId, null, new int[] { (int)WorkOrderFieldIndex.ProductId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductEntity);
				AddNavigatorMetaData<WorkOrderEntity, ScrapReasonEntity>("ScrapReason", "WorkOrders", (a, b) => a._scrapReason = b, a => a._scrapReason, (a, b) => a.ScrapReason = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticWorkOrderRelations.ScrapReasonEntityUsingScrapReasonIdStatic, ()=>new WorkOrderRelations().ScrapReasonEntityUsingScrapReasonId, null, new int[] { (int)WorkOrderFieldIndex.ScrapReasonId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ScrapReasonEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static WorkOrderEntity()
		{
		}

		/// <summary> CTor</summary>
		public WorkOrderEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public WorkOrderEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this WorkOrderEntity</param>
		public WorkOrderEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		public WorkOrderEntity(System.Int32 workOrderId) : this(workOrderId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="workOrderId">PK value for WorkOrder which data should be fetched into this WorkOrder object</param>
		/// <param name="validator">The custom validator object for this WorkOrderEntity</param>
		public WorkOrderEntity(System.Int32 workOrderId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.WorkOrderId = workOrderId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected WorkOrderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'WorkOrderRouting' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrderRoutings() { return CreateRelationInfoForNavigator("WorkOrderRoutings"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct() { return CreateRelationInfoForNavigator("Product"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ScrapReason' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoScrapReason() { return CreateRelationInfoForNavigator("ScrapReason"); }
		
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
		/// <param name="validator">The validator object for this WorkOrderEntity</param>
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
		public static WorkOrderRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrderRouting' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrderRoutings { get { return _staticMetaData.GetPrefetchPathElement("WorkOrderRoutings", CommonEntityBase.CreateEntityCollection<WorkOrderRoutingEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct { get { return _staticMetaData.GetPrefetchPathElement("Product", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ScrapReason' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathScrapReason { get { return _staticMetaData.GetPrefetchPathElement("ScrapReason", CommonEntityBase.CreateEntityCollection<ScrapReasonEntity>()); } }

		/// <summary>The DueDate property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."DueDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderFieldIndex.DueDate, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.DueDate, value); }
		}

		/// <summary>The EndDate property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."EndDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> EndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderFieldIndex.EndDate, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.EndDate, value); }
		}

		/// <summary>The ModifiedDate property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The OrderQty property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."OrderQty".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 OrderQty
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.OrderQty, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.OrderQty, value); }
		}

		/// <summary>The ProductId property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.ProductId, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.ProductId, value); }
		}

		/// <summary>The ScrappedQty property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ScrappedQty".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 ScrappedQty
		{
			get { return (System.Int16)GetValue((int)WorkOrderFieldIndex.ScrappedQty, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.ScrappedQty, value); }
		}

		/// <summary>The ScrapReasonId property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."ScrapReasonID".<br/>Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> ScrapReasonId
		{
			get { return (Nullable<System.Int16>)GetValue((int)WorkOrderFieldIndex.ScrapReasonId, false); }
			set	{ SetValue((int)WorkOrderFieldIndex.ScrapReasonId, value); }
		}

		/// <summary>The StartDate property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."StartDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime StartDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderFieldIndex.StartDate, true); }
			set	{ SetValue((int)WorkOrderFieldIndex.StartDate, value); }
		}

		/// <summary>The StockedQty property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."StockedQty".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 StockedQty
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.StockedQty, true); }
		}

		/// <summary>The WorkOrderId property of the Entity WorkOrder<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrder"."WorkOrderID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 WorkOrderId
		{
			get { return (System.Int32)GetValue((int)WorkOrderFieldIndex.WorkOrderId, true); }
			set { SetValue((int)WorkOrderFieldIndex.WorkOrderId, value); }		}

		/// <summary>Gets the EntityCollection with the related entities of type 'WorkOrderRoutingEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(WorkOrderRoutingEntity))]
		public virtual EntityCollection<WorkOrderRoutingEntity> WorkOrderRoutings { get { return GetOrCreateEntityCollection<WorkOrderRoutingEntity, WorkOrderRoutingEntityFactory>("WorkOrder", true, false, ref _workOrderRoutings); } }

		/// <summary>Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get { return _product; }
			set { SetSingleRelatedEntityNavigator(value, "Product"); }
		}

		/// <summary>Gets / sets related entity of type 'ScrapReasonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ScrapReasonEntity ScrapReason
		{
			get { return _scrapReason; }
			set { SetSingleRelatedEntityNavigator(value, "ScrapReason"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum WorkOrderFieldIndex
	{
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ScrappedQty. </summary>
		ScrappedQty,
		///<summary>ScrapReasonId. </summary>
		ScrapReasonId,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>StockedQty. </summary>
		StockedQty,
		///<summary>WorkOrderId. </summary>
		WorkOrderId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: WorkOrder. </summary>
	public partial class WorkOrderRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and WorkOrderRoutingEntity over the 1:n relation they have, using the relation between the fields: WorkOrder.WorkOrderId - WorkOrderRouting.WorkOrderId</summary>
		public virtual IEntityRelation WorkOrderRoutingEntityUsingWorkOrderId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "WorkOrderRoutings", true, new[] { WorkOrderFields.WorkOrderId, WorkOrderRoutingFields.WorkOrderId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and ProductEntity over the m:1 relation they have, using the relation between the fields: WorkOrder.ProductId - Product.ProductId</summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Product", false, new[] { ProductFields.ProductId, WorkOrderFields.ProductId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between WorkOrderEntity and ScrapReasonEntity over the m:1 relation they have, using the relation between the fields: WorkOrder.ScrapReasonId - ScrapReason.ScrapReasonId</summary>
		public virtual IEntityRelation ScrapReasonEntityUsingScrapReasonId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "ScrapReason", false, new[] { ScrapReasonFields.ScrapReasonId, WorkOrderFields.ScrapReasonId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticWorkOrderRelations
	{
		internal static readonly IEntityRelation WorkOrderRoutingEntityUsingWorkOrderIdStatic = new WorkOrderRelations().WorkOrderRoutingEntityUsingWorkOrderId;
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new WorkOrderRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation ScrapReasonEntityUsingScrapReasonIdStatic = new WorkOrderRelations().ScrapReasonEntityUsingScrapReasonId;

		/// <summary>CTor</summary>
		static StaticWorkOrderRelations() { }
	}
}
