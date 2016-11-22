///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
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
using AdventureWorks.Dal.Adapter.v51;
using AdventureWorks.Dal.Adapter.v51.HelperClasses;
using AdventureWorks.Dal.Adapter.v51.FactoryClasses;
using AdventureWorks.Dal.Adapter.v51.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v51.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'SalesOrderDetail'.<br/><br/></summary>
	[Serializable]
	public partial class SalesOrderDetailEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SalesOrderHeaderEntity _salesOrderHeader;
		private SpecialOfferProductEntity _specialOfferProduct;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesOrderHeader</summary>
			public static readonly string SalesOrderHeader = "SalesOrderHeader";
			/// <summary>Member name SpecialOfferProduct</summary>
			public static readonly string SpecialOfferProduct = "SpecialOfferProduct";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesOrderDetailEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SalesOrderDetailEntity():base("SalesOrderDetailEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesOrderDetailEntity(IEntityFields2 fields):base("SalesOrderDetailEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesOrderDetailEntity</param>
		public SalesOrderDetailEntity(IValidator validator):base("SalesOrderDetailEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="salesOrderDetailId">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderId">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailId, System.Int32 salesOrderId):base("SalesOrderDetailEntity")
		{
			InitClassEmpty(null, null);
			this.SalesOrderDetailId = salesOrderDetailId;
			this.SalesOrderId = salesOrderId;
		}

		/// <summary> CTor</summary>
		/// <param name="salesOrderDetailId">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="salesOrderId">PK value for SalesOrderDetail which data should be fetched into this SalesOrderDetail object</param>
		/// <param name="validator">The custom validator object for this SalesOrderDetailEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesOrderDetailEntity(System.Int32 salesOrderDetailId, System.Int32 salesOrderId, IValidator validator):base("SalesOrderDetailEntity")
		{
			InitClassEmpty(validator, null);
			this.SalesOrderDetailId = salesOrderDetailId;
			this.SalesOrderId = salesOrderId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SalesOrderDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_salesOrderHeader = (SalesOrderHeaderEntity)info.GetValue("_salesOrderHeader", typeof(SalesOrderHeaderEntity));
				if(_salesOrderHeader!=null)
				{
					_salesOrderHeader.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_specialOfferProduct = (SpecialOfferProductEntity)info.GetValue("_specialOfferProduct", typeof(SpecialOfferProductEntity));
				if(_specialOfferProduct!=null)
				{
					_specialOfferProduct.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SalesOrderDetailFieldIndex)fieldIndex)
			{
				case SalesOrderDetailFieldIndex.ProductId:
					DesetupSyncSpecialOfferProduct(true, false);
					break;
				case SalesOrderDetailFieldIndex.SalesOrderId:
					DesetupSyncSalesOrderHeader(true, false);
					break;
				case SalesOrderDetailFieldIndex.SpecialOfferId:
					DesetupSyncSpecialOfferProduct(true, false);
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
				case "SalesOrderHeader":
					this.SalesOrderHeader = (SalesOrderHeaderEntity)entity;
					break;
				case "SpecialOfferProduct":
					this.SpecialOfferProduct = (SpecialOfferProductEntity)entity;
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
				case "SalesOrderHeader":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesOrderId);
					break;
				case "SpecialOfferProduct":
					toReturn.Add(Relations.SpecialOfferProductEntityUsingProductIdSpecialOfferId);
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
				case "SalesOrderHeader":
					SetupSyncSalesOrderHeader(relatedEntity);
					break;
				case "SpecialOfferProduct":
					SetupSyncSpecialOfferProduct(relatedEntity);
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
				case "SalesOrderHeader":
					DesetupSyncSalesOrderHeader(false, true);
					break;
				case "SpecialOfferProduct":
					DesetupSyncSpecialOfferProduct(false, true);
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
			if(_salesOrderHeader!=null)
			{
				toReturn.Add(_salesOrderHeader);
			}
			if(_specialOfferProduct!=null)
			{
				toReturn.Add(_specialOfferProduct);
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
				info.AddValue("_salesOrderHeader", (!this.MarkedForDeletion?_salesOrderHeader:null));
				info.AddValue("_specialOfferProduct", (!this.MarkedForDeletion?_specialOfferProduct:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesOrderDetailRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeader()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.SalesOrderId, null, ComparisonOperator.Equal, this.SalesOrderId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SpecialOfferProduct' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSpecialOfferProduct()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SpecialOfferProductFields.ProductId, null, ComparisonOperator.Equal, this.ProductId));
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SpecialOfferProductFields.SpecialOfferId, null, ComparisonOperator.Equal, this.SpecialOfferId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderDetailEntityFactory));
		}
#if !CF
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
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("SalesOrderHeader", _salesOrderHeader);
			toReturn.Add("SpecialOfferProduct", _specialOfferProduct);
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
			_fieldsCustomProperties.Add("CarrierTrackingNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LineTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrderQty", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesOrderDetailId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesOrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SpecialOfferId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitPrice", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("UnitPriceDiscount", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _salesOrderHeader</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesOrderHeader(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesOrderHeader, new PropertyChangedEventHandler( OnSalesOrderHeaderPropertyChanged ), "SalesOrderHeader", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderDetailRelations.SalesOrderHeaderEntityUsingSalesOrderIdStatic, true, signalRelatedEntity, "SalesOrderDetails", resetFKFields, new int[] { (int)SalesOrderDetailFieldIndex.SalesOrderId } );
			_salesOrderHeader = null;
		}

		/// <summary> setups the sync logic for member _salesOrderHeader</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesOrderHeader(IEntityCore relatedEntity)
		{
			if(_salesOrderHeader!=relatedEntity)
			{
				DesetupSyncSalesOrderHeader(true, true);
				_salesOrderHeader = (SalesOrderHeaderEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesOrderHeader, new PropertyChangedEventHandler( OnSalesOrderHeaderPropertyChanged ), "SalesOrderHeader", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderDetailRelations.SalesOrderHeaderEntityUsingSalesOrderIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesOrderHeaderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _specialOfferProduct</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSpecialOfferProduct(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _specialOfferProduct, new PropertyChangedEventHandler( OnSpecialOfferProductPropertyChanged ), "SpecialOfferProduct", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderDetailRelations.SpecialOfferProductEntityUsingProductIdSpecialOfferIdStatic, true, signalRelatedEntity, "SalesOrderDetails", resetFKFields, new int[] { (int)SalesOrderDetailFieldIndex.ProductId, (int)SalesOrderDetailFieldIndex.SpecialOfferId } );
			_specialOfferProduct = null;
		}

		/// <summary> setups the sync logic for member _specialOfferProduct</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSpecialOfferProduct(IEntityCore relatedEntity)
		{
			if(_specialOfferProduct!=relatedEntity)
			{
				DesetupSyncSpecialOfferProduct(true, true);
				_specialOfferProduct = (SpecialOfferProductEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _specialOfferProduct, new PropertyChangedEventHandler( OnSpecialOfferProductPropertyChanged ), "SpecialOfferProduct", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderDetailRelations.SpecialOfferProductEntityUsingProductIdSpecialOfferIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSpecialOfferProductPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
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

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static SalesOrderDetailRelations Relations
		{
			get	{ return new SalesOrderDetailRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeader
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))),	(IEntityRelation)GetRelationsForField("SalesOrderHeader")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderDetailEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, 0, null, null, null, null, "SalesOrderHeader", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SpecialOfferProduct' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSpecialOfferProduct
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SpecialOfferProductEntityFactory))),	(IEntityRelation)GetRelationsForField("SpecialOfferProduct")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderDetailEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.SpecialOfferProductEntity, 0, null, null, null, null, "SpecialOfferProduct", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CarrierTrackingNumber property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."CarrierTrackingNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CarrierTrackingNumber
		{
			get { return (System.String)GetValue((int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, value); }
		}

		/// <summary> The LineTotal property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."LineTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 38, 6, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal LineTotal
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.LineTotal, true); }

		}

		/// <summary> The ModifiedDate property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderDetailFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The OrderQty property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."OrderQty"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 OrderQty
		{
			get { return (System.Int16)GetValue((int)SalesOrderDetailFieldIndex.OrderQty, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.OrderQty, value); }
		}

		/// <summary> The ProductId property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.ProductId, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.ProductId, value); }
		}

		/// <summary> The Rowguid property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesOrderDetailFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.Rowguid, value); }
		}

		/// <summary> The SalesOrderDetailId property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SalesOrderDetailID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesOrderDetailId
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SalesOrderDetailId, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.SalesOrderDetailId, value); }
		}

		/// <summary> The SalesOrderId property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SalesOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesOrderId
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SalesOrderId, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.SalesOrderId, value); }
		}

		/// <summary> The SpecialOfferId property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."SpecialOfferID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 SpecialOfferId
		{
			get { return (System.Int32)GetValue((int)SalesOrderDetailFieldIndex.SpecialOfferId, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.SpecialOfferId, value); }
		}

		/// <summary> The UnitPrice property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."UnitPrice"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPrice
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.UnitPrice, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.UnitPrice, value); }
		}

		/// <summary> The UnitPriceDiscount property of the Entity SalesOrderDetail<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderDetail"."UnitPriceDiscount"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal UnitPriceDiscount
		{
			get { return (System.Decimal)GetValue((int)SalesOrderDetailFieldIndex.UnitPriceDiscount, true); }
			set	{ SetValue((int)SalesOrderDetailFieldIndex.UnitPriceDiscount, value); }
		}

		/// <summary> Gets / sets related entity of type 'SalesOrderHeaderEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SalesOrderHeaderEntity SalesOrderHeader
		{
			get	{ return _salesOrderHeader; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSalesOrderHeader(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderDetails", "SalesOrderHeader", _salesOrderHeader, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SpecialOfferProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SpecialOfferProductEntity SpecialOfferProduct
		{
			get	{ return _specialOfferProduct; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSpecialOfferProduct(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderDetails", "SpecialOfferProduct", _specialOfferProduct, true); 
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
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v51.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderDetailEntity; }
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
