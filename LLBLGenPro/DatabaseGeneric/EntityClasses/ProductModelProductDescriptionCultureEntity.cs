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
	/// <summary>Entity class which represents the entity 'ProductModelProductDescriptionCulture'.<br/><br/></summary>
	[Serializable]
	public partial class ProductModelProductDescriptionCultureEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private CultureEntity _culture;
		private ProductDescriptionEntity _productDescription;
		private ProductModelEntity _productModel;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProductModelProductDescriptionCultureEntityStaticMetaData _staticMetaData = new ProductModelProductDescriptionCultureEntityStaticMetaData();
		private static ProductModelProductDescriptionCultureRelations _relationsFactory = new ProductModelProductDescriptionCultureRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Culture</summary>
			public static readonly string Culture = "Culture";
			/// <summary>Member name ProductDescription</summary>
			public static readonly string ProductDescription = "ProductDescription";
			/// <summary>Member name ProductModel</summary>
			public static readonly string ProductModel = "ProductModel";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductModelProductDescriptionCultureEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductModelProductDescriptionCultureEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductModelProductDescriptionCultureEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.ProductModelProductDescriptionCultureEntity, typeof(ProductModelProductDescriptionCultureEntity), typeof(ProductModelProductDescriptionCultureEntityFactory), false);
				AddNavigatorMetaData<ProductModelProductDescriptionCultureEntity, CultureEntity>("Culture", "ProductModelProductDescriptionCultures", (a, b) => a._culture = b, a => a._culture, (a, b) => a.Culture = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticProductModelProductDescriptionCultureRelations.CultureEntityUsingCultureIdStatic, ()=>new ProductModelProductDescriptionCultureRelations().CultureEntityUsingCultureId, null, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.CultureId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.CultureEntity);
				AddNavigatorMetaData<ProductModelProductDescriptionCultureEntity, ProductDescriptionEntity>("ProductDescription", "ProductModelProductDescriptionCultures", (a, b) => a._productDescription = b, a => a._productDescription, (a, b) => a.ProductDescription = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticProductModelProductDescriptionCultureRelations.ProductDescriptionEntityUsingProductDescriptionIdStatic, ()=>new ProductModelProductDescriptionCultureRelations().ProductDescriptionEntityUsingProductDescriptionId, null, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.ProductDescriptionEntity);
				AddNavigatorMetaData<ProductModelProductDescriptionCultureEntity, ProductModelEntity>("ProductModel", "ProductModelProductDescriptionCultures", (a, b) => a._productModel = b, a => a._productModel, (a, b) => a.ProductModel = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticProductModelProductDescriptionCultureRelations.ProductModelEntityUsingProductModelIdStatic, ()=>new ProductModelProductDescriptionCultureRelations().ProductModelEntityUsingProductModelId, null, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.ProductModelId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.ProductModelEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProductModelProductDescriptionCultureEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProductModelProductDescriptionCultureEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductModelProductDescriptionCultureEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductModelProductDescriptionCultureEntity</param>
		public ProductModelProductDescriptionCultureEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="cultureId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productModelId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		public ProductModelProductDescriptionCultureEntity(System.String cultureId, System.Int32 productDescriptionId, System.Int32 productModelId) : this(cultureId, productDescriptionId, productModelId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="cultureId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productModelId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="validator">The custom validator object for this ProductModelProductDescriptionCultureEntity</param>
		public ProductModelProductDescriptionCultureEntity(System.String cultureId, System.Int32 productDescriptionId, System.Int32 productModelId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.CultureId = cultureId;
			this.ProductDescriptionId = productDescriptionId;
			this.ProductModelId = productModelId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductModelProductDescriptionCultureEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Culture' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCulture() { return CreateRelationInfoForNavigator("Culture"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ProductDescription' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductDescription() { return CreateRelationInfoForNavigator("ProductDescription"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ProductModel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModel() { return CreateRelationInfoForNavigator("ProductModel"); }
		
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
		/// <param name="validator">The validator object for this ProductModelProductDescriptionCultureEntity</param>
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
		public static ProductModelProductDescriptionCultureRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Culture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCulture { get { return _staticMetaData.GetPrefetchPathElement("Culture", CommonEntityBase.CreateEntityCollection<CultureEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductDescription' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductDescription { get { return _staticMetaData.GetPrefetchPathElement("ProductDescription", CommonEntityBase.CreateEntityCollection<ProductDescriptionEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModel { get { return _staticMetaData.GetPrefetchPathElement("ProductModel", CommonEntityBase.CreateEntityCollection<ProductModelEntity>()); } }

		/// <summary>The CultureId property of the Entity ProductModelProductDescriptionCulture<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."CultureID".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 6.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CultureId
		{
			get { return (System.String)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.CultureId, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.CultureId, value); }
		}

		/// <summary>The ModifiedDate property of the Entity ProductModelProductDescriptionCulture<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The ProductDescriptionId property of the Entity ProductModelProductDescriptionCulture<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ProductDescriptionID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductDescriptionId
		{
			get { return (System.Int32)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionId, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionId, value); }
		}

		/// <summary>The ProductModelId property of the Entity ProductModelProductDescriptionCulture<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ProductModelID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductModelId
		{
			get { return (System.Int32)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductModelId, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductModelId, value); }
		}

		/// <summary>Gets / sets related entity of type 'CultureEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CultureEntity Culture
		{
			get { return _culture; }
			set { SetSingleRelatedEntityNavigator(value, "Culture"); }
		}

		/// <summary>Gets / sets related entity of type 'ProductDescriptionEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductDescriptionEntity ProductDescription
		{
			get { return _productDescription; }
			set { SetSingleRelatedEntityNavigator(value, "ProductDescription"); }
		}

		/// <summary>Gets / sets related entity of type 'ProductModelEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductModelEntity ProductModel
		{
			get { return _productModel; }
			set { SetSingleRelatedEntityNavigator(value, "ProductModel"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum ProductModelProductDescriptionCultureFieldIndex
	{
		///<summary>CultureId. </summary>
		CultureId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductDescriptionId. </summary>
		ProductDescriptionId,
		///<summary>ProductModelId. </summary>
		ProductModelId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductModelProductDescriptionCulture. </summary>
	public partial class ProductModelProductDescriptionCultureRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between ProductModelProductDescriptionCultureEntity and CultureEntity over the m:1 relation they have, using the relation between the fields: ProductModelProductDescriptionCulture.CultureId - Culture.CultureId</summary>
		public virtual IEntityRelation CultureEntityUsingCultureId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Culture", false, new[] { CultureFields.CultureId, ProductModelProductDescriptionCultureFields.CultureId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductModelProductDescriptionCultureEntity and ProductDescriptionEntity over the m:1 relation they have, using the relation between the fields: ProductModelProductDescriptionCulture.ProductDescriptionId - ProductDescription.ProductDescriptionId</summary>
		public virtual IEntityRelation ProductDescriptionEntityUsingProductDescriptionId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "ProductDescription", false, new[] { ProductDescriptionFields.ProductDescriptionId, ProductModelProductDescriptionCultureFields.ProductDescriptionId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductModelProductDescriptionCultureEntity and ProductModelEntity over the m:1 relation they have, using the relation between the fields: ProductModelProductDescriptionCulture.ProductModelId - ProductModel.ProductModelId</summary>
		public virtual IEntityRelation ProductModelEntityUsingProductModelId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "ProductModel", false, new[] { ProductModelFields.ProductModelId, ProductModelProductDescriptionCultureFields.ProductModelId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductModelProductDescriptionCultureRelations
	{
		internal static readonly IEntityRelation CultureEntityUsingCultureIdStatic = new ProductModelProductDescriptionCultureRelations().CultureEntityUsingCultureId;
		internal static readonly IEntityRelation ProductDescriptionEntityUsingProductDescriptionIdStatic = new ProductModelProductDescriptionCultureRelations().ProductDescriptionEntityUsingProductDescriptionId;
		internal static readonly IEntityRelation ProductModelEntityUsingProductModelIdStatic = new ProductModelProductDescriptionCultureRelations().ProductModelEntityUsingProductModelId;

		/// <summary>CTor</summary>
		static StaticProductModelProductDescriptionCultureRelations() { }
	}
}
