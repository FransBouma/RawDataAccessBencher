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
	/// <summary>Entity class which represents the entity 'SpecialOfferProduct'.<br/><br/></summary>
	[Serializable]
	public partial class SpecialOfferProductEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SalesOrderDetailEntity> _salesOrderDetails;
		private ProductEntity _product;
		private SpecialOfferEntity _specialOffer;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name SpecialOffer</summary>
			public static readonly string SpecialOffer = "SpecialOffer";
			/// <summary>Member name SalesOrderDetails</summary>
			public static readonly string SalesOrderDetails = "SalesOrderDetails";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SpecialOfferProductEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SpecialOfferProductEntity():base("SpecialOfferProductEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SpecialOfferProductEntity(IEntityFields2 fields):base("SpecialOfferProductEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SpecialOfferProductEntity</param>
		public SpecialOfferProductEntity(IValidator validator):base("SpecialOfferProductEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="productId">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferId">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SpecialOfferProductEntity(System.Int32 productId, System.Int32 specialOfferId):base("SpecialOfferProductEntity")
		{
			InitClassEmpty(null, null);
			this.ProductId = productId;
			this.SpecialOfferId = specialOfferId;
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="specialOfferId">PK value for SpecialOfferProduct which data should be fetched into this SpecialOfferProduct object</param>
		/// <param name="validator">The custom validator object for this SpecialOfferProductEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SpecialOfferProductEntity(System.Int32 productId, System.Int32 specialOfferId, IValidator validator):base("SpecialOfferProductEntity")
		{
			InitClassEmpty(validator, null);
			this.ProductId = productId;
			this.SpecialOfferId = specialOfferId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SpecialOfferProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_salesOrderDetails = (EntityCollection<SalesOrderDetailEntity>)info.GetValue("_salesOrderDetails", typeof(EntityCollection<SalesOrderDetailEntity>));
				_product = (ProductEntity)info.GetValue("_product", typeof(ProductEntity));
				if(_product!=null)
				{
					_product.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_specialOffer = (SpecialOfferEntity)info.GetValue("_specialOffer", typeof(SpecialOfferEntity));
				if(_specialOffer!=null)
				{
					_specialOffer.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SpecialOfferProductFieldIndex)fieldIndex)
			{
				case SpecialOfferProductFieldIndex.ProductId:
					DesetupSyncProduct(true, false);
					break;
				case SpecialOfferProductFieldIndex.SpecialOfferId:
					DesetupSyncSpecialOffer(true, false);
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
				case "Product":
					this.Product = (ProductEntity)entity;
					break;
				case "SpecialOffer":
					this.SpecialOffer = (SpecialOfferEntity)entity;
					break;
				case "SalesOrderDetails":
					this.SalesOrderDetails.Add((SalesOrderDetailEntity)entity);
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
				case "Product":
					toReturn.Add(Relations.ProductEntityUsingProductId);
					break;
				case "SpecialOffer":
					toReturn.Add(Relations.SpecialOfferEntityUsingSpecialOfferId);
					break;
				case "SalesOrderDetails":
					toReturn.Add(Relations.SalesOrderDetailEntityUsingProductIdSpecialOfferId);
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
				case "Product":
					SetupSyncProduct(relatedEntity);
					break;
				case "SpecialOffer":
					SetupSyncSpecialOffer(relatedEntity);
					break;
				case "SalesOrderDetails":
					this.SalesOrderDetails.Add((SalesOrderDetailEntity)relatedEntity);
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
				case "Product":
					DesetupSyncProduct(false, true);
					break;
				case "SpecialOffer":
					DesetupSyncSpecialOffer(false, true);
					break;
				case "SalesOrderDetails":
					this.PerformRelatedEntityRemoval(this.SalesOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_product!=null)
			{
				toReturn.Add(_product);
			}
			if(_specialOffer!=null)
			{
				toReturn.Add(_specialOffer);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SalesOrderDetails);
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
				info.AddValue("_salesOrderDetails", ((_salesOrderDetails!=null) && (_salesOrderDetails.Count>0) && !this.MarkedForDeletion)?_salesOrderDetails:null);
				info.AddValue("_product", (!this.MarkedForDeletion?_product:null));
				info.AddValue("_specialOffer", (!this.MarkedForDeletion?_specialOffer:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SpecialOfferProductRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderDetails()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderDetailFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderDetailFields.SpecialOfferId, null, ComparisonOperator.Equal, this.SpecialOfferId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SpecialOffer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOffer()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SpecialOfferFields.SpecialOfferId, null, ComparisonOperator.Equal, this.SpecialOfferId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferProductEntityFactory));
		}

		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._salesOrderDetails);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._salesOrderDetails = (EntityCollection<SalesOrderDetailEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._salesOrderDetails != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderDetailEntityFactory))) : null);
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Product", _product);
			toReturn.Add("SpecialOffer", _specialOffer);
			toReturn.Add("SalesOrderDetails", _salesOrderDetails);
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
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SpecialOfferId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _product</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticSpecialOfferProductRelations.ProductEntityUsingProductIdStatic, true, signalRelatedEntity, "SpecialOfferProducts", resetFKFields, new int[] { (int)SpecialOfferProductFieldIndex.ProductId } );
			_product = null;
		}

		/// <summary> setups the sync logic for member _product</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProduct(IEntityCore relatedEntity)
		{
			if(_product!=relatedEntity)
			{
				DesetupSyncProduct(true, true);
				_product = (ProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _product, new PropertyChangedEventHandler( OnProductPropertyChanged ), "Product", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticSpecialOfferProductRelations.ProductEntityUsingProductIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnProductPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _specialOffer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSpecialOffer(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _specialOffer, new PropertyChangedEventHandler( OnSpecialOfferPropertyChanged ), "SpecialOffer", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticSpecialOfferProductRelations.SpecialOfferEntityUsingSpecialOfferIdStatic, true, signalRelatedEntity, "SpecialOfferProducts", resetFKFields, new int[] { (int)SpecialOfferProductFieldIndex.SpecialOfferId } );
			_specialOffer = null;
		}

		/// <summary> setups the sync logic for member _specialOffer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSpecialOffer(IEntityCore relatedEntity)
		{
			if(_specialOffer!=relatedEntity)
			{
				DesetupSyncSpecialOffer(true, true);
				_specialOffer = (SpecialOfferEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _specialOffer, new PropertyChangedEventHandler( OnSpecialOfferPropertyChanged ), "SpecialOffer", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticSpecialOfferProductRelations.SpecialOfferEntityUsingSpecialOfferIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSpecialOfferPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SpecialOfferProductEntity</param>
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
		public  static SpecialOfferProductRelations Relations
		{
			get	{ return new SpecialOfferProductRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderDetails
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderDetailEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderDetails")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SpecialOfferProductEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesOrderDetailEntity, 0, null, null, null, null, "SalesOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ProductEntityFactory))),	(IEntityRelation)GetRelationsForField("Product")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SpecialOfferProductEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.ProductEntity, 0, null, null, null, null, "Product", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOffer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOffer
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferEntityFactory))),	(IEntityRelation)GetRelationsForField("SpecialOffer")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SpecialOfferProductEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.SpecialOfferEntity, 0, null, null, null, null, "SpecialOffer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ModifiedDate property of the Entity SpecialOfferProduct<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SpecialOfferProductFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The ProductId property of the Entity SpecialOfferProduct<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)SpecialOfferProductFieldIndex.ProductId, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.ProductId, value); }
		}

		/// <summary> The Rowguid property of the Entity SpecialOfferProduct<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SpecialOfferProductFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.Rowguid, value); }
		}

		/// <summary> The SpecialOfferId property of the Entity SpecialOfferProduct<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SpecialOfferProduct"."SpecialOfferID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SpecialOfferId
		{
			get { return (System.Int32)GetValue((int)SpecialOfferProductFieldIndex.SpecialOfferId, true); }
			set	{ SetValue((int)SpecialOfferProductFieldIndex.SpecialOfferId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderDetailEntity))]
		public virtual EntityCollection<SalesOrderDetailEntity> SalesOrderDetails
		{
			get { return GetOrCreateEntityCollection<SalesOrderDetailEntity, SalesOrderDetailEntityFactory>("SpecialOfferProduct", true, false, ref _salesOrderDetails);	}
		}

		/// <summary> Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get	{ return _product; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncProduct(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SpecialOfferProducts", "Product", _product, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SpecialOfferEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SpecialOfferEntity SpecialOffer
		{
			get	{ return _specialOffer; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSpecialOffer(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SpecialOfferProducts", "SpecialOffer", _specialOffer, true); 
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
			get { return (int)AdventureWorks.Dal.Adapter.v52.EntityType.SpecialOfferProductEntity; }
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
