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
	/// <summary>Entity class which represents the entity 'TransactionHistory'.<br/><br/></summary>
	[Serializable]
	public partial class TransactionHistoryEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private ProductEntity _product;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static TransactionHistoryEntityStaticMetaData _staticMetaData = new TransactionHistoryEntityStaticMetaData();
		private static TransactionHistoryRelations _relationsFactory = new TransactionHistoryRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TransactionHistoryEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TransactionHistoryEntityStaticMetaData()
			{
				SetEntityCoreInfo("TransactionHistoryEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.v54.EntityType.TransactionHistoryEntity, typeof(TransactionHistoryEntity), typeof(TransactionHistoryEntityFactory), false);
				AddNavigatorMetaData<TransactionHistoryEntity, ProductEntity>("Product", "TransactionHistories", (a, b) => a._product = b, a => a._product, (a, b) => a.Product = b, AdventureWorks.Dal.Adapter.v54.RelationClasses.StaticTransactionHistoryRelations.ProductEntityUsingProductIdStatic, ()=>new TransactionHistoryRelations().ProductEntityUsingProductId, null, new int[] { (int)TransactionHistoryFieldIndex.ProductId }, null, true, (int)AdventureWorks.Dal.Adapter.v54.EntityType.ProductEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TransactionHistoryEntity()
		{
		}

		/// <summary> CTor</summary>
		public TransactionHistoryEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TransactionHistoryEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TransactionHistoryEntity</param>
		public TransactionHistoryEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="transactionId">PK value for TransactionHistory which data should be fetched into this TransactionHistory object</param>
		public TransactionHistoryEntity(System.Int32 transactionId) : this(transactionId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="transactionId">PK value for TransactionHistory which data should be fetched into this TransactionHistory object</param>
		/// <param name="validator">The custom validator object for this TransactionHistoryEntity</param>
		public TransactionHistoryEntity(System.Int32 transactionId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.TransactionId = transactionId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TransactionHistoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct() { return CreateRelationInfoForNavigator("Product"); }
		
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
		/// <param name="validator">The validator object for this TransactionHistoryEntity</param>
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
		public static TransactionHistoryRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct { get { return _staticMetaData.GetPrefetchPathElement("Product", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>The ActualCost property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."ActualCost".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal ActualCost
		{
			get { return (System.Decimal)GetValue((int)TransactionHistoryFieldIndex.ActualCost, true); }
			set	{ SetValue((int)TransactionHistoryFieldIndex.ActualCost, value); }
		}

		/// <summary>The ModifiedDate property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)TransactionHistoryFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)TransactionHistoryFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ProductId property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)TransactionHistoryFieldIndex.ProductId, true); }
			set	{ SetValue((int)TransactionHistoryFieldIndex.ProductId, value); }
		}

		/// <summary>The Quantity property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."Quantity".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 Quantity
		{
			get { return (System.Int32)GetValue((int)TransactionHistoryFieldIndex.Quantity, true); }
			set	{ SetValue((int)TransactionHistoryFieldIndex.Quantity, value); }
		}

		/// <summary>The ReferenceOrderId property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."ReferenceOrderID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ReferenceOrderId
		{
			get { return (System.Int32)GetValue((int)TransactionHistoryFieldIndex.ReferenceOrderId, true); }
			set	{ SetValue((int)TransactionHistoryFieldIndex.ReferenceOrderId, value); }
		}

		/// <summary>The ReferenceOrderLineId property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."ReferenceOrderLineID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ReferenceOrderLineId
		{
			get { return (System.Int32)GetValue((int)TransactionHistoryFieldIndex.ReferenceOrderLineId, true); }
			set	{ SetValue((int)TransactionHistoryFieldIndex.ReferenceOrderLineId, value); }
		}

		/// <summary>The TransactionDate property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."TransactionDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime TransactionDate
		{
			get { return (System.DateTime)GetValue((int)TransactionHistoryFieldIndex.TransactionDate, true); }
			set	{ SetValue((int)TransactionHistoryFieldIndex.TransactionDate, value); }
		}

		/// <summary>The TransactionId property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."TransactionID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 TransactionId
		{
			get { return (System.Int32)GetValue((int)TransactionHistoryFieldIndex.TransactionId, true); }
			set { SetValue((int)TransactionHistoryFieldIndex.TransactionId, value); }		}

		/// <summary>The TransactionType property of the Entity TransactionHistory<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TransactionHistory"."TransactionType".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String TransactionType
		{
			get { return (System.String)GetValue((int)TransactionHistoryFieldIndex.TransactionType, true); }
			set	{ SetValue((int)TransactionHistoryFieldIndex.TransactionType, value); }
		}

		/// <summary>Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get { return _product; }
			set { SetSingleRelatedEntityNavigator(value, "Product"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AdventureWorks.Dal.Adapter.v54
{
	public enum TransactionHistoryFieldIndex
	{
		///<summary>ActualCost. </summary>
		ActualCost,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>ReferenceOrderId. </summary>
		ReferenceOrderId,
		///<summary>ReferenceOrderLineId. </summary>
		ReferenceOrderLineId,
		///<summary>TransactionDate. </summary>
		TransactionDate,
		///<summary>TransactionId. </summary>
		TransactionId,
		///<summary>TransactionType. </summary>
		TransactionType,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.v54.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: TransactionHistory. </summary>
	public partial class TransactionHistoryRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between TransactionHistoryEntity and ProductEntity over the m:1 relation they have, using the relation between the fields: TransactionHistory.ProductId - Product.ProductId</summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Product", false, new[] { ProductFields.ProductId, TransactionHistoryFields.ProductId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTransactionHistoryRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new TransactionHistoryRelations().ProductEntityUsingProductId;

		/// <summary>CTor</summary>
		static StaticTransactionHistoryRelations() { }
	}
}
