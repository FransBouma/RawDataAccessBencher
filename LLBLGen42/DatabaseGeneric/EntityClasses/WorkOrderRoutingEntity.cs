///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
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
using AdventureWorks.Dal.Adapter.v42;
using AdventureWorks.Dal.Adapter.v42.HelperClasses;
using AdventureWorks.Dal.Adapter.v42.FactoryClasses;
using AdventureWorks.Dal.Adapter.v42.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v42.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'WorkOrderRouting'.<br/><br/></summary>
	[Serializable]
	public partial class WorkOrderRoutingEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private LocationEntity _location;
		private WorkOrderEntity _workOrder;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Location</summary>
			public static readonly string Location = "Location";
			/// <summary>Member name WorkOrder</summary>
			public static readonly string WorkOrder = "WorkOrder";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static WorkOrderRoutingEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public WorkOrderRoutingEntity():base("WorkOrderRoutingEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public WorkOrderRoutingEntity(IEntityFields2 fields):base("WorkOrderRoutingEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this WorkOrderRoutingEntity</param>
		public WorkOrderRoutingEntity(IValidator validator):base("WorkOrderRoutingEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productId">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderId">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public WorkOrderRoutingEntity(System.Int16 operationSequence, System.Int32 productId, System.Int32 workOrderId):base("WorkOrderRoutingEntity")
		{
			InitClassEmpty(null, null);
			this.OperationSequence = operationSequence;
			this.ProductId = productId;
			this.WorkOrderId = workOrderId;
		}

		/// <summary> CTor</summary>
		/// <param name="operationSequence">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="productId">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="workOrderId">PK value for WorkOrderRouting which data should be fetched into this WorkOrderRouting object</param>
		/// <param name="validator">The custom validator object for this WorkOrderRoutingEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public WorkOrderRoutingEntity(System.Int16 operationSequence, System.Int32 productId, System.Int32 workOrderId, IValidator validator):base("WorkOrderRoutingEntity")
		{
			InitClassEmpty(validator, null);
			this.OperationSequence = operationSequence;
			this.ProductId = productId;
			this.WorkOrderId = workOrderId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected WorkOrderRoutingEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_location = (LocationEntity)info.GetValue("_location", typeof(LocationEntity));
				if(_location!=null)
				{
					_location.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_workOrder = (WorkOrderEntity)info.GetValue("_workOrder", typeof(WorkOrderEntity));
				if(_workOrder!=null)
				{
					_workOrder.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((WorkOrderRoutingFieldIndex)fieldIndex)
			{
				case WorkOrderRoutingFieldIndex.LocationId:
					DesetupSyncLocation(true, false);
					break;
				case WorkOrderRoutingFieldIndex.WorkOrderId:
					DesetupSyncWorkOrder(true, false);
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
				case "Location":
					this.Location = (LocationEntity)entity;
					break;
				case "WorkOrder":
					this.WorkOrder = (WorkOrderEntity)entity;
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
				case "Location":
					toReturn.Add(Relations.LocationEntityUsingLocationId);
					break;
				case "WorkOrder":
					toReturn.Add(Relations.WorkOrderEntityUsingWorkOrderId);
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
				case "Location":
					SetupSyncLocation(relatedEntity);
					break;
				case "WorkOrder":
					SetupSyncWorkOrder(relatedEntity);
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
				case "Location":
					DesetupSyncLocation(false, true);
					break;
				case "WorkOrder":
					DesetupSyncWorkOrder(false, true);
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
			if(_location!=null)
			{
				toReturn.Add(_location);
			}
			if(_workOrder!=null)
			{
				toReturn.Add(_workOrder);
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
				info.AddValue("_location", (!this.MarkedForDeletion?_location:null));
				info.AddValue("_workOrder", (!this.MarkedForDeletion?_workOrder:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new WorkOrderRoutingRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Location' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoLocation()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(LocationFields.LocationId, null, ComparisonOperator.Equal, this.LocationId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'WorkOrder' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoWorkOrder()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(WorkOrderFields.WorkOrderId, null, ComparisonOperator.Equal, this.WorkOrderId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderRoutingEntityFactory));
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
			toReturn.Add("Location", _location);
			toReturn.Add("WorkOrder", _workOrder);
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
			_fieldsCustomProperties.Add("ActualCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ActualEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ActualResourceHrs", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ActualStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LocationId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OperationSequence", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PlannedCost", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ProductId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ScheduledEndDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ScheduledStartDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("WorkOrderId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _location</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncLocation(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _location, new PropertyChangedEventHandler( OnLocationPropertyChanged ), "Location", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticWorkOrderRoutingRelations.LocationEntityUsingLocationIdStatic, true, signalRelatedEntity, "WorkOrderRoutings", resetFKFields, new int[] { (int)WorkOrderRoutingFieldIndex.LocationId } );
			_location = null;
		}

		/// <summary> setups the sync logic for member _location</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncLocation(IEntityCore relatedEntity)
		{
			if(_location!=relatedEntity)
			{
				DesetupSyncLocation(true, true);
				_location = (LocationEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _location, new PropertyChangedEventHandler( OnLocationPropertyChanged ), "Location", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticWorkOrderRoutingRelations.LocationEntityUsingLocationIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnLocationPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _workOrder</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncWorkOrder(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticWorkOrderRoutingRelations.WorkOrderEntityUsingWorkOrderIdStatic, true, signalRelatedEntity, "WorkOrderRoutings", resetFKFields, new int[] { (int)WorkOrderRoutingFieldIndex.WorkOrderId } );
			_workOrder = null;
		}

		/// <summary> setups the sync logic for member _workOrder</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncWorkOrder(IEntityCore relatedEntity)
		{
			if(_workOrder!=relatedEntity)
			{
				DesetupSyncWorkOrder(true, true);
				_workOrder = (WorkOrderEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _workOrder, new PropertyChangedEventHandler( OnWorkOrderPropertyChanged ), "WorkOrder", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticWorkOrderRoutingRelations.WorkOrderEntityUsingWorkOrderIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnWorkOrderPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this WorkOrderRoutingEntity</param>
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
		public  static WorkOrderRoutingRelations Relations
		{
			get	{ return new WorkOrderRoutingRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Location' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathLocation
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(LocationEntityFactory))),	(IEntityRelation)GetRelationsForField("Location")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.WorkOrderRoutingEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.LocationEntity, 0, null, null, null, null, "Location", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'WorkOrder' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathWorkOrder
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(WorkOrderEntityFactory))),	(IEntityRelation)GetRelationsForField("WorkOrder")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.WorkOrderRoutingEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.WorkOrderEntity, 0, null, null, null, null, "WorkOrder", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ActualCost property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ActualCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)WorkOrderRoutingFieldIndex.ActualCost, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualCost, value); }
		}

		/// <summary> The ActualEndDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ActualEndDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderRoutingFieldIndex.ActualEndDate, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualEndDate, value); }
		}

		/// <summary> The ActualResourceHrs property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualResourceHrs"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 9, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> ActualResourceHrs
		{
			get { return (Nullable<System.Decimal>)GetValue((int)WorkOrderRoutingFieldIndex.ActualResourceHrs, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualResourceHrs, value); }
		}

		/// <summary> The ActualStartDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ActualStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ActualStartDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)WorkOrderRoutingFieldIndex.ActualStartDate, false); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ActualStartDate, value); }
		}

		/// <summary> The LocationId property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."LocationID"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 LocationId
		{
			get { return (System.Int16)GetValue((int)WorkOrderRoutingFieldIndex.LocationId, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.LocationId, value); }
		}

		/// <summary> The ModifiedDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The OperationSequence property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."OperationSequence"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int16 OperationSequence
		{
			get { return (System.Int16)GetValue((int)WorkOrderRoutingFieldIndex.OperationSequence, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.OperationSequence, value); }
		}

		/// <summary> The PlannedCost property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."PlannedCost"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal PlannedCost
		{
			get { return (System.Decimal)GetValue((int)WorkOrderRoutingFieldIndex.PlannedCost, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.PlannedCost, value); }
		}

		/// <summary> The ProductId property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ProductID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)WorkOrderRoutingFieldIndex.ProductId, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ProductId, value); }
		}

		/// <summary> The ScheduledEndDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ScheduledEndDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ScheduledEndDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ScheduledEndDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ScheduledEndDate, value); }
		}

		/// <summary> The ScheduledStartDate property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."ScheduledStartDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ScheduledStartDate
		{
			get { return (System.DateTime)GetValue((int)WorkOrderRoutingFieldIndex.ScheduledStartDate, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.ScheduledStartDate, value); }
		}

		/// <summary> The WorkOrderId property of the Entity WorkOrderRouting<br/><br/></summary>
		/// <remarks>Mapped on  table field: "WorkOrderRouting"."WorkOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 WorkOrderId
		{
			get { return (System.Int32)GetValue((int)WorkOrderRoutingFieldIndex.WorkOrderId, true); }
			set	{ SetValue((int)WorkOrderRoutingFieldIndex.WorkOrderId, value); }
		}

		/// <summary> Gets / sets related entity of type 'LocationEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual LocationEntity Location
		{
			get	{ return _location; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncLocation(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "WorkOrderRoutings", "Location", _location, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'WorkOrderEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual WorkOrderEntity WorkOrder
		{
			get	{ return _workOrder; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncWorkOrder(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "WorkOrderRoutings", "WorkOrder", _workOrder, true); 
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
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v42.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v42.EntityType.WorkOrderRoutingEntity; }
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
