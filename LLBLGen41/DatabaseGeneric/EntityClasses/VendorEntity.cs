///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.v41;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using AdventureWorks.Dal.Adapter.v41.FactoryClasses;
using AdventureWorks.Dal.Adapter.v41.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v41.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Vendor'.<br/><br/></summary>
	[Serializable]
	public partial class VendorEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<ProductVendorEntity> _productVendors;
		private EntityCollection<PurchaseOrderHeaderEntity> _purchaseOrderHeaders;
		private BusinessEntityEntity _businessEntity;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name ProductVendors</summary>
			public static readonly string ProductVendors = "ProductVendors";
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name BusinessEntity</summary>
			public static readonly string BusinessEntity = "BusinessEntity";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static VendorEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public VendorEntity():base("VendorEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public VendorEntity(IEntityFields2 fields):base("VendorEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this VendorEntity</param>
		public VendorEntity(IValidator validator):base("VendorEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="vendorId">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public VendorEntity(System.Int32 vendorId):base("VendorEntity")
		{
			InitClassEmpty(null, null);
			this.VendorId = vendorId;
		}

		/// <summary> CTor</summary>
		/// <param name="vendorId">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="validator">The custom validator object for this VendorEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public VendorEntity(System.Int32 vendorId, IValidator validator):base("VendorEntity")
		{
			InitClassEmpty(validator, null);
			this.VendorId = vendorId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected VendorEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_productVendors = (EntityCollection<ProductVendorEntity>)info.GetValue("_productVendors", typeof(EntityCollection<ProductVendorEntity>));
				_purchaseOrderHeaders = (EntityCollection<PurchaseOrderHeaderEntity>)info.GetValue("_purchaseOrderHeaders", typeof(EntityCollection<PurchaseOrderHeaderEntity>));
				_businessEntity = (BusinessEntityEntity)info.GetValue("_businessEntity", typeof(BusinessEntityEntity));
				if(_businessEntity!=null)
				{
					_businessEntity.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((VendorFieldIndex)fieldIndex)
			{
				case VendorFieldIndex.VendorId:
					DesetupSyncBusinessEntity(true, false);
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
				case "ProductVendors":
					this.ProductVendors.Add((ProductVendorEntity)entity);
					break;
				case "PurchaseOrderHeaders":
					this.PurchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)entity);
					break;
				case "BusinessEntity":
					this.BusinessEntity = (BusinessEntityEntity)entity;
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
				case "ProductVendors":
					toReturn.Add(Relations.ProductVendorEntityUsingVendorId);
					break;
				case "PurchaseOrderHeaders":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingVendorId);
					break;
				case "BusinessEntity":
					toReturn.Add(Relations.BusinessEntityEntityUsingVendorId);
					break;
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
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
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "ProductVendors":
					this.ProductVendors.Add((ProductVendorEntity)relatedEntity);
					break;
				case "PurchaseOrderHeaders":
					this.PurchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)relatedEntity);
					break;
				case "BusinessEntity":
					SetupSyncBusinessEntity(relatedEntity);
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
				case "ProductVendors":
					this.PerformRelatedEntityRemoval(this.ProductVendors, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderHeaders":
					this.PerformRelatedEntityRemoval(this.PurchaseOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BusinessEntity":
					DesetupSyncBusinessEntity(false, true);
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
			if(_businessEntity!=null)
			{
				toReturn.Add(_businessEntity);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.ProductVendors);
			toReturn.Add(this.PurchaseOrderHeaders);
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
				info.AddValue("_productVendors", ((_productVendors!=null) && (_productVendors.Count>0) && !this.MarkedForDeletion)?_productVendors:null);
				info.AddValue("_purchaseOrderHeaders", ((_purchaseOrderHeaders!=null) && (_purchaseOrderHeaders.Count>0) && !this.MarkedForDeletion)?_purchaseOrderHeaders:null);
				info.AddValue("_businessEntity", (!this.MarkedForDeletion?_businessEntity:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new VendorRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ProductVendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProductVendors()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ProductVendorFields.VendorId, null, ComparisonOperator.Equal, this.VendorId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PurchaseOrderHeaderFields.VendorId, null, ComparisonOperator.Equal, this.VendorId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'BusinessEntity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntity()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BusinessEntityFields.BusinessEntityId, null, ComparisonOperator.Equal, this.VendorId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._productVendors);
			collectionsQueue.Enqueue(this._purchaseOrderHeaders);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._productVendors = (EntityCollection<ProductVendorEntity>) collectionsQueue.Dequeue();
			this._purchaseOrderHeaders = (EntityCollection<PurchaseOrderHeaderEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._productVendors != null);
			toReturn |=(this._purchaseOrderHeaders != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ProductVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductVendorEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PurchaseOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("ProductVendors", _productVendors);
			toReturn.Add("PurchaseOrderHeaders", _purchaseOrderHeaders);
			toReturn.Add("BusinessEntity", _businessEntity);
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
			_fieldsCustomProperties.Add("AccountNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ActiveFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CreditRating", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PreferredVendorStatus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PurchasingWebServiceUrl", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VendorId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _businessEntity</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBusinessEntity(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _businessEntity, new PropertyChangedEventHandler( OnBusinessEntityPropertyChanged ), "BusinessEntity", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticVendorRelations.BusinessEntityEntityUsingVendorIdStatic, true, signalRelatedEntity, "Vendor", false, new int[] { (int)VendorFieldIndex.VendorId } );
			_businessEntity = null;
		}
		
		/// <summary> setups the sync logic for member _businessEntity</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncBusinessEntity(IEntityCore relatedEntity)
		{
			if(_businessEntity!=relatedEntity)
			{
				DesetupSyncBusinessEntity(true, true);
				_businessEntity = (BusinessEntityEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _businessEntity, new PropertyChangedEventHandler( OnBusinessEntityPropertyChanged ), "BusinessEntity", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticVendorRelations.BusinessEntityEntityUsingVendorIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnBusinessEntityPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this VendorEntity</param>
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
		public  static VendorRelations Relations
		{
			get	{ return new VendorRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ProductVendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProductVendors
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ProductVendorEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ProductVendorEntityFactory))), (IEntityRelation)GetRelationsForField("ProductVendors")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.ProductVendorEntity, 0, null, null, null, null, "ProductVendors", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderHeaders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PurchaseOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("PurchaseOrderHeaders")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, null, "PurchaseOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntity
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityEntityFactory))), (IEntityRelation)GetRelationsForField("BusinessEntity")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityEntity, 0, null, null, null, null, "BusinessEntity", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The AccountNumber property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."AccountNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.AccountNumber, true); }
			set	{ SetValue((int)VendorFieldIndex.AccountNumber, value); }
		}

		/// <summary> The ActiveFlag property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."ActiveFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean ActiveFlag
		{
			get { return (System.Boolean)GetValue((int)VendorFieldIndex.ActiveFlag, true); }
			set	{ SetValue((int)VendorFieldIndex.ActiveFlag, value); }
		}

		/// <summary> The CreditRating property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."CreditRating"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte CreditRating
		{
			get { return (System.Byte)GetValue((int)VendorFieldIndex.CreditRating, true); }
			set	{ SetValue((int)VendorFieldIndex.CreditRating, value); }
		}

		/// <summary> The ModifiedDate property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)VendorFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)VendorFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.Name, true); }
			set	{ SetValue((int)VendorFieldIndex.Name, value); }
		}

		/// <summary> The PreferredVendorStatus property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."PreferredVendorStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean PreferredVendorStatus
		{
			get { return (System.Boolean)GetValue((int)VendorFieldIndex.PreferredVendorStatus, true); }
			set	{ SetValue((int)VendorFieldIndex.PreferredVendorStatus, value); }
		}

		/// <summary> The PurchasingWebServiceUrl property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."PurchasingWebServiceURL"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 1024<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PurchasingWebServiceUrl
		{
			get { return (System.String)GetValue((int)VendorFieldIndex.PurchasingWebServiceUrl, true); }
			set	{ SetValue((int)VendorFieldIndex.PurchasingWebServiceUrl, value); }
		}

		/// <summary> The VendorId property of the Entity Vendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Vendor"."BusinessEntityID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 VendorId
		{
			get { return (System.Int32)GetValue((int)VendorFieldIndex.VendorId, true); }
			set	{ SetValue((int)VendorFieldIndex.VendorId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ProductVendorEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ProductVendorEntity))]
		public virtual EntityCollection<ProductVendorEntity> ProductVendors
		{
			get { return GetOrCreateEntityCollection<ProductVendorEntity, ProductVendorEntityFactory>("Vendor", true, false, ref _productVendors);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PurchaseOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderHeaderEntity))]
		public virtual EntityCollection<PurchaseOrderHeaderEntity> PurchaseOrderHeaders
		{
			get { return GetOrCreateEntityCollection<PurchaseOrderHeaderEntity, PurchaseOrderHeaderEntityFactory>("Vendor", true, false, ref _purchaseOrderHeaders);	}
		}

		/// <summary> Gets / sets related entity of type 'BusinessEntityEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual BusinessEntityEntity BusinessEntity
		{
			get { return _businessEntity; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncBusinessEntity(value);
					CallSetRelatedEntityDuringDeserialization(value, "Vendor");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_businessEntity !=null);
						DesetupSyncBusinessEntity(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("BusinessEntity");
						}
					}
					else
					{
						if(_businessEntity!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "Vendor");
							SetupSyncBusinessEntity(value);
						}
					}
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
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v41.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v41.EntityType.VendorEntity; }
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
