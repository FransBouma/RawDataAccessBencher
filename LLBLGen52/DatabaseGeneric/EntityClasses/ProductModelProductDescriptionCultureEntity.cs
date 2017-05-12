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
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v52;
using AdventureWorks.Dal.Adapter.v52.HelperClasses;
using AdventureWorks.Dal.Adapter.v52.FactoryClasses;
using AdventureWorks.Dal.Adapter.v52.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v52.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'ProductModelProductDescriptionCulture'.<br/><br/></summary>
	[Serializable]
	public partial class ProductModelProductDescriptionCultureEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private CultureEntity _culture;
		private ProductDescriptionEntity _productDescription;
		private ProductModelEntity _productModel;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

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
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static ProductModelProductDescriptionCultureEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public ProductModelProductDescriptionCultureEntity():base("ProductModelProductDescriptionCultureEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductModelProductDescriptionCultureEntity(IEntityFields2 fields):base("ProductModelProductDescriptionCultureEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductModelProductDescriptionCultureEntity</param>
		public ProductModelProductDescriptionCultureEntity(IValidator validator):base("ProductModelProductDescriptionCultureEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="cultureId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productModelId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductModelProductDescriptionCultureEntity(System.String cultureId, System.Int32 productDescriptionId, System.Int32 productModelId):base("ProductModelProductDescriptionCultureEntity")
		{
			InitClassEmpty(null, null);
			this.CultureId = cultureId;
			this.ProductDescriptionId = productDescriptionId;
			this.ProductModelId = productModelId;
		}

		/// <summary> CTor</summary>
		/// <param name="cultureId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productModelId">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="validator">The custom validator object for this ProductModelProductDescriptionCultureEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public ProductModelProductDescriptionCultureEntity(System.String cultureId, System.Int32 productDescriptionId, System.Int32 productModelId, IValidator validator):base("ProductModelProductDescriptionCultureEntity")
		{
			InitClassEmpty(validator, null);
			this.CultureId = cultureId;
			this.ProductDescriptionId = productDescriptionId;
			this.ProductModelId = productModelId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected ProductModelProductDescriptionCultureEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_culture = (CultureEntity)info.GetValue("_culture", typeof(CultureEntity));
				if(_culture!=null)
				{
					_culture.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_productDescription = (ProductDescriptionEntity)info.GetValue("_productDescription", typeof(ProductDescriptionEntity));
				if(_productDescription!=null)
				{
					_productDescription.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_productModel = (ProductModelEntity)info.GetValue("_productModel", typeof(ProductModelEntity));
				if(_productModel!=null)
				{
					_productModel.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((ProductModelProductDescriptionCultureFieldIndex)fieldIndex)
			{
				case ProductModelProductDescriptionCultureFieldIndex.CultureId:
					DesetupSyncCulture(true, false);
					break;
				case ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionId:
					DesetupSyncProductDescription(true, false);
					break;
				case ProductModelProductDescriptionCultureFieldIndex.ProductModelId:
					DesetupSyncProductModel(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "Culture":
					this.Culture = (CultureEntity)entity;
					break;
				case "ProductDescription":
					this.ProductDescription = (ProductDescriptionEntity)entity;
					break;
				case "ProductModel":
					this.ProductModel = (ProductModelEntity)entity;
					break;
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				case "Culture":
					toReturn.Add(Relations.CultureEntityUsingCultureId);
					break;
				case "ProductDescription":
					toReturn.Add(Relations.ProductDescriptionEntityUsingProductDescriptionId);
					break;
				case "ProductModel":
					toReturn.Add(Relations.ProductModelEntityUsingProductModelId);
					break;
				default:
					break;				
			}
			return toReturn;
		}

		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}

		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "Culture":
					SetupSyncCulture(relatedEntity);
					break;
				case "ProductDescription":
					SetupSyncProductDescription(relatedEntity);
					break;
				case "ProductModel":
					SetupSyncProductModel(relatedEntity);
					break;
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				case "Culture":
					DesetupSyncCulture(false, true);
					break;
				case "ProductDescription":
					DesetupSyncProductDescription(false, true);
					break;
				case "ProductModel":
					DesetupSyncProductModel(false, true);
					break;
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_culture!=null)
			{
				toReturn.Add(_culture);
			}
			if(_productDescription!=null)
			{
				toReturn.Add(_productDescription);
			}
			if(_productModel!=null)
			{
				toReturn.Add(_productModel);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				info.AddValue("_culture", (!this.MarkedForDeletion?_culture:null));
				info.AddValue("_productDescription", (!this.MarkedForDeletion?_productDescription:null));
				info.AddValue("_productModel", (!this.MarkedForDeletion?_productModel:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new ProductModelProductDescriptionCultureRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Culture' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCulture()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CultureFields.CultureId, null, ComparisonOperator.Equal, this.CultureId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ProductDescription' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductDescription()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductDescriptionFields.ProductDescriptionId, null, ComparisonOperator.Equal, this.ProductDescriptionId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ProductModel' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductModel()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductModelFields.ProductModelId, null, ComparisonOperator.Equal, this.ProductModelId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(ProductModelProductDescriptionCultureEntityFactory));
		}

		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Culture", _culture);
			toReturn.Add("ProductDescription", _productDescription);
			toReturn.Add("ProductModel", _productModel);
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CultureId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductDescriptionId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductModelId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _culture</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCulture(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _culture, new PropertyChangedEventHandler( OnCulturePropertyChanged ), "Culture", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticProductModelProductDescriptionCultureRelations.CultureEntityUsingCultureIdStatic, true, signalRelatedEntity, "ProductModelProductDescriptionCultures", resetFKFields, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.CultureId } );
			_culture = null;
		}

		/// <summary> setups the sync logic for member _culture</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCulture(IEntityCore relatedEntity)
		{
			if(_culture!=relatedEntity)
			{
				DesetupSyncCulture(true, true);
				_culture = (CultureEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _culture, new PropertyChangedEventHandler( OnCulturePropertyChanged ), "Culture", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticProductModelProductDescriptionCultureRelations.CultureEntityUsingCultureIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCulturePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _productDescription</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductDescription(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productDescription, new PropertyChangedEventHandler( OnProductDescriptionPropertyChanged ), "ProductDescription", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticProductModelProductDescriptionCultureRelations.ProductDescriptionEntityUsingProductDescriptionIdStatic, true, signalRelatedEntity, "ProductModelProductDescriptionCultures", resetFKFields, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionId } );
			_productDescription = null;
		}

		/// <summary> setups the sync logic for member _productDescription</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductDescription(IEntityCore relatedEntity)
		{
			if(_productDescription!=relatedEntity)
			{
				DesetupSyncProductDescription(true, true);
				_productDescription = (ProductDescriptionEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productDescription, new PropertyChangedEventHandler( OnProductDescriptionPropertyChanged ), "ProductDescription", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticProductModelProductDescriptionCultureRelations.ProductDescriptionEntityUsingProductDescriptionIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductDescriptionPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _productModel</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProductModel(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticProductModelProductDescriptionCultureRelations.ProductModelEntityUsingProductModelIdStatic, true, signalRelatedEntity, "ProductModelProductDescriptionCultures", resetFKFields, new int[] { (int)ProductModelProductDescriptionCultureFieldIndex.ProductModelId } );
			_productModel = null;
		}

		/// <summary> setups the sync logic for member _productModel</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductModel(IEntityCore relatedEntity)
		{
			if(_productModel!=relatedEntity)
			{
				DesetupSyncProductModel(true, true);
				_productModel = (ProductModelEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _productModel, new PropertyChangedEventHandler( OnProductModelPropertyChanged ), "ProductModel", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticProductModelProductDescriptionCultureRelations.ProductModelEntityUsingProductModelIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductModelPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
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

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static ProductModelProductDescriptionCultureRelations Relations
		{
			get	{ return new ProductModelProductDescriptionCultureRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Culture' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCulture
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CultureEntityFactory))),	(IEntityRelation)GetRelationsForField("Culture")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.ProductModelProductDescriptionCultureEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.CultureEntity, 0, null, null, null, null, "Culture", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductDescription' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductDescription
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductDescriptionEntityFactory))),	(IEntityRelation)GetRelationsForField("ProductDescription")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.ProductModelProductDescriptionCultureEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.ProductDescriptionEntity, 0, null, null, null, null, "ProductDescription", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductModel' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductModel
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductModelEntityFactory))),	(IEntityRelation)GetRelationsForField("ProductModel")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.ProductModelProductDescriptionCultureEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.ProductModelEntity, 0, null, null, null, null, "ProductModel", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The CultureId property of the Entity ProductModelProductDescriptionCulture<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."CultureID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 6<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CultureId
		{
			get { return (System.String)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.CultureId, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.CultureId, value); }
		}

		/// <summary> The ModifiedDate property of the Entity ProductModelProductDescriptionCulture<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The ProductDescriptionId property of the Entity ProductModelProductDescriptionCulture<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ProductDescriptionID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductDescriptionId
		{
			get { return (System.Int32)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionId, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionId, value); }
		}

		/// <summary> The ProductModelId property of the Entity ProductModelProductDescriptionCulture<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductModelProductDescriptionCulture"."ProductModelID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductModelId
		{
			get { return (System.Int32)GetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductModelId, true); }
			set	{ SetValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductModelId, value); }
		}

		/// <summary> Gets / sets related entity of type 'CultureEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CultureEntity Culture
		{
			get	{ return _culture; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCulture(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ProductModelProductDescriptionCultures", "Culture", _culture, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ProductDescriptionEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductDescriptionEntity ProductDescription
		{
			get	{ return _productDescription; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProductDescription(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ProductModelProductDescriptionCultures", "ProductDescription", _productDescription, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ProductModelEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductModelEntity ProductModel
		{
			get	{ return _productModel; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProductModel(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "ProductModelProductDescriptionCultures", "ProductModel", _productModel, true); 
				}
			}
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v52.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v52.EntityType.ProductModelProductDescriptionCultureEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Included code

		#endregion
	}
}
