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
	/// <summary>Entity class which represents the entity 'SalesPerson'.<br/><br/></summary>
	[Serializable]
	public partial class SalesPersonEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SalesOrderHeaderEntity> _salesOrderHeaders;
		private EntityCollection<SalesPersonQuotaHistoryEntity> _salesPersonQuotaHistories;
		private EntityCollection<SalesTerritoryHistoryEntity> _salesTerritoryHistories;
		private EntityCollection<StoreEntity> _stores;
		private SalesTerritoryEntity _salesTerritory;
		private EmployeeEntity _employee;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name SalesOrderHeaders</summary>
			public static readonly string SalesOrderHeaders = "SalesOrderHeaders";
			/// <summary>Member name SalesPersonQuotaHistories</summary>
			public static readonly string SalesPersonQuotaHistories = "SalesPersonQuotaHistories";
			/// <summary>Member name SalesTerritoryHistories</summary>
			public static readonly string SalesTerritoryHistories = "SalesTerritoryHistories";
			/// <summary>Member name Stores</summary>
			public static readonly string Stores = "Stores";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesPersonEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SalesPersonEntity():base("SalesPersonEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesPersonEntity(IEntityFields2 fields):base("SalesPersonEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		public SalesPersonEntity(IValidator validator):base("SalesPersonEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="salesPersonId">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesPersonEntity(System.Int32 salesPersonId):base("SalesPersonEntity")
		{
			InitClassEmpty(null, null);
			this.SalesPersonId = salesPersonId;
		}

		/// <summary> CTor</summary>
		/// <param name="salesPersonId">PK value for SalesPerson which data should be fetched into this SalesPerson object</param>
		/// <param name="validator">The custom validator object for this SalesPersonEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesPersonEntity(System.Int32 salesPersonId, IValidator validator):base("SalesPersonEntity")
		{
			InitClassEmpty(validator, null);
			this.SalesPersonId = salesPersonId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SalesPersonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>)info.GetValue("_salesOrderHeaders", typeof(EntityCollection<SalesOrderHeaderEntity>));
				_salesPersonQuotaHistories = (EntityCollection<SalesPersonQuotaHistoryEntity>)info.GetValue("_salesPersonQuotaHistories", typeof(EntityCollection<SalesPersonQuotaHistoryEntity>));
				_salesTerritoryHistories = (EntityCollection<SalesTerritoryHistoryEntity>)info.GetValue("_salesTerritoryHistories", typeof(EntityCollection<SalesTerritoryHistoryEntity>));
				_stores = (EntityCollection<StoreEntity>)info.GetValue("_stores", typeof(EntityCollection<StoreEntity>));
				_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
				if(_salesTerritory!=null)
				{
					_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
				if(_employee!=null)
				{
					_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SalesPersonFieldIndex)fieldIndex)
			{
				case SalesPersonFieldIndex.SalesPersonId:
					DesetupSyncEmployee(true, false);
					break;
				case SalesPersonFieldIndex.TerritoryId:
					DesetupSyncSalesTerritory(true, false);
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
				case "SalesTerritory":
					this.SalesTerritory = (SalesTerritoryEntity)entity;
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)entity);
					break;
				case "SalesPersonQuotaHistories":
					this.SalesPersonQuotaHistories.Add((SalesPersonQuotaHistoryEntity)entity);
					break;
				case "SalesTerritoryHistories":
					this.SalesTerritoryHistories.Add((SalesTerritoryHistoryEntity)entity);
					break;
				case "Stores":
					this.Stores.Add((StoreEntity)entity);
					break;
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
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
				case "SalesTerritory":
					toReturn.Add(Relations.SalesTerritoryEntityUsingTerritoryId);
					break;
				case "SalesOrderHeaders":
					toReturn.Add(Relations.SalesOrderHeaderEntityUsingSalesPersonId);
					break;
				case "SalesPersonQuotaHistories":
					toReturn.Add(Relations.SalesPersonQuotaHistoryEntityUsingSalesPersonId);
					break;
				case "SalesTerritoryHistories":
					toReturn.Add(Relations.SalesTerritoryHistoryEntityUsingSalesPersonId);
					break;
				case "Stores":
					toReturn.Add(Relations.StoreEntityUsingSalesPersonId);
					break;
				case "Employee":
					toReturn.Add(Relations.EmployeeEntityUsingSalesPersonId);
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
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "SalesOrderHeaders":
					this.SalesOrderHeaders.Add((SalesOrderHeaderEntity)relatedEntity);
					break;
				case "SalesPersonQuotaHistories":
					this.SalesPersonQuotaHistories.Add((SalesPersonQuotaHistoryEntity)relatedEntity);
					break;
				case "SalesTerritoryHistories":
					this.SalesTerritoryHistories.Add((SalesTerritoryHistoryEntity)relatedEntity);
					break;
				case "Stores":
					this.Stores.Add((StoreEntity)relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
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
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
					break;
				case "SalesOrderHeaders":
					this.PerformRelatedEntityRemoval(this.SalesOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesPersonQuotaHistories":
					this.PerformRelatedEntityRemoval(this.SalesPersonQuotaHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTerritoryHistories":
					this.PerformRelatedEntityRemoval(this.SalesTerritoryHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Stores":
					this.PerformRelatedEntityRemoval(this.Stores, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
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
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}

			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SalesOrderHeaders);
			toReturn.Add(this.SalesPersonQuotaHistories);
			toReturn.Add(this.SalesTerritoryHistories);
			toReturn.Add(this.Stores);
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
				info.AddValue("_salesOrderHeaders", ((_salesOrderHeaders!=null) && (_salesOrderHeaders.Count>0) && !this.MarkedForDeletion)?_salesOrderHeaders:null);
				info.AddValue("_salesPersonQuotaHistories", ((_salesPersonQuotaHistories!=null) && (_salesPersonQuotaHistories.Count>0) && !this.MarkedForDeletion)?_salesPersonQuotaHistories:null);
				info.AddValue("_salesTerritoryHistories", ((_salesTerritoryHistories!=null) && (_salesTerritoryHistories.Count>0) && !this.MarkedForDeletion)?_salesTerritoryHistories:null);
				info.AddValue("_stores", ((_stores!=null) && (_stores.Count>0) && !this.MarkedForDeletion)?_stores:null);
				info.AddValue("_salesTerritory", (!this.MarkedForDeletion?_salesTerritory:null));
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesPersonRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderFields.SalesPersonId, null, ComparisonOperator.Equal, this.SalesPersonId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesPersonQuotaHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPersonQuotaHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonQuotaHistoryFields.SalesPersonId, null, ComparisonOperator.Equal, this.SalesPersonId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTerritoryHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritoryHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryHistoryFields.SalesPersonId, null, ComparisonOperator.Equal, this.SalesPersonId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Store' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoStores()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(StoreFields.SalesPersonId, null, ComparisonOperator.Equal, this.SalesPersonId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesTerritory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTerritory()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTerritoryFields.TerritoryId, null, ComparisonOperator.Equal, this.TerritoryId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.SalesPersonId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory));
		}

		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._salesOrderHeaders);
			collectionsQueue.Enqueue(this._salesPersonQuotaHistories);
			collectionsQueue.Enqueue(this._salesTerritoryHistories);
			collectionsQueue.Enqueue(this._stores);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._salesOrderHeaders = (EntityCollection<SalesOrderHeaderEntity>) collectionsQueue.Dequeue();
			this._salesPersonQuotaHistories = (EntityCollection<SalesPersonQuotaHistoryEntity>) collectionsQueue.Dequeue();
			this._salesTerritoryHistories = (EntityCollection<SalesTerritoryHistoryEntity>) collectionsQueue.Dequeue();
			this._stores = (EntityCollection<StoreEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._salesOrderHeaders != null);
			toReturn |=(this._salesPersonQuotaHistories != null);
			toReturn |=(this._salesTerritoryHistories != null);
			toReturn |=(this._stores != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesPersonQuotaHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonQuotaHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTerritoryHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<StoreEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StoreEntityFactory))) : null);
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("SalesTerritory", _salesTerritory);
			toReturn.Add("SalesOrderHeaders", _salesOrderHeaders);
			toReturn.Add("SalesPersonQuotaHistories", _salesPersonQuotaHistories);
			toReturn.Add("SalesTerritoryHistories", _salesTerritoryHistories);
			toReturn.Add("Stores", _stores);
			toReturn.Add("Employee", _employee);
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
			_fieldsCustomProperties.Add("Bonus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CommissionPct", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesLastYear", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesPersonId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesQuota", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesYtd", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _salesTerritory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesTerritory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticSalesPersonRelations.SalesTerritoryEntityUsingTerritoryIdStatic, true, signalRelatedEntity, "SalesPeople", resetFKFields, new int[] { (int)SalesPersonFieldIndex.TerritoryId } );
			_salesTerritory = null;
		}

		/// <summary> setups the sync logic for member _salesTerritory</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesTerritory(IEntityCore relatedEntity)
		{
			if(_salesTerritory!=relatedEntity)
			{
				DesetupSyncSalesTerritory(true, true);
				_salesTerritory = (SalesTerritoryEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticSalesPersonRelations.SalesTerritoryEntityUsingTerritoryIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesTerritoryPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticSalesPersonRelations.EmployeeEntityUsingSalesPersonIdStatic, true, signalRelatedEntity, "SalesPerson", false, new int[] { (int)SalesPersonFieldIndex.SalesPersonId } );
			_employee = null;
		}
		
		/// <summary> setups the sync logic for member _employee</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncEmployee(IEntityCore relatedEntity)
		{
			if(_employee!=relatedEntity)
			{
				DesetupSyncEmployee(true, true);
				_employee = (EmployeeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticSalesPersonRelations.EmployeeEntityUsingSalesPersonIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnEmployeePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SalesPersonEntity</param>
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
		public  static SalesPersonRelations Relations
		{
			get	{ return new SalesPersonRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderHeaders")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesOrderHeaderEntity, 0, null, null, null, null, "SalesOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPersonQuotaHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPersonQuotaHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesPersonQuotaHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonQuotaHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("SalesPersonQuotaHistories")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonQuotaHistoryEntity, 0, null, null, null, null, "SalesPersonQuotaHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritoryHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritoryHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesTerritoryHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("SalesTerritoryHistories")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesTerritoryHistoryEntity, 0, null, null, null, null, "SalesTerritoryHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Store' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathStores
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<StoreEntity>(EntityFactoryCache2.GetEntityFactory(typeof(StoreEntityFactory))), (IEntityRelation)GetRelationsForField("Stores")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.StoreEntity, 0, null, null, null, null, "Stores", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))),	(IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesTerritoryEntity, 0, null, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), (IEntityRelation)GetRelationsForField("Employee")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The Bonus property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."Bonus"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Bonus
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.Bonus, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.Bonus, value); }
		}

		/// <summary> The CommissionPct property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."CommissionPct"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallMoney, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal CommissionPct
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.CommissionPct, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.CommissionPct, value); }
		}

		/// <summary> The ModifiedDate property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesPersonFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Rowguid property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesPersonFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.Rowguid, value); }
		}

		/// <summary> The SalesLastYear property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesLastYear"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesLastYear
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.SalesLastYear, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesLastYear, value); }
		}

		/// <summary> The SalesPersonId property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."BusinessEntityID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 SalesPersonId
		{
			get { return (System.Int32)GetValue((int)SalesPersonFieldIndex.SalesPersonId, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesPersonId, value); }
		}

		/// <summary> The SalesQuota property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesQuota"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> SalesQuota
		{
			get { return (Nullable<System.Decimal>)GetValue((int)SalesPersonFieldIndex.SalesQuota, false); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesQuota, value); }
		}

		/// <summary> The SalesYtd property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."SalesYTD"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SalesYtd
		{
			get { return (System.Decimal)GetValue((int)SalesPersonFieldIndex.SalesYtd, true); }
			set	{ SetValue((int)SalesPersonFieldIndex.SalesYtd, value); }
		}

		/// <summary> The TerritoryId property of the Entity SalesPerson<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesPerson"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TerritoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesPersonFieldIndex.TerritoryId, false); }
			set	{ SetValue((int)SalesPersonFieldIndex.TerritoryId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderEntity))]
		public virtual EntityCollection<SalesOrderHeaderEntity> SalesOrderHeaders
		{
			get { return GetOrCreateEntityCollection<SalesOrderHeaderEntity, SalesOrderHeaderEntityFactory>("SalesPerson", true, false, ref _salesOrderHeaders);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesPersonQuotaHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesPersonQuotaHistoryEntity))]
		public virtual EntityCollection<SalesPersonQuotaHistoryEntity> SalesPersonQuotaHistories
		{
			get { return GetOrCreateEntityCollection<SalesPersonQuotaHistoryEntity, SalesPersonQuotaHistoryEntityFactory>("SalesPerson", true, false, ref _salesPersonQuotaHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTerritoryHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTerritoryHistoryEntity))]
		public virtual EntityCollection<SalesTerritoryHistoryEntity> SalesTerritoryHistories
		{
			get { return GetOrCreateEntityCollection<SalesTerritoryHistoryEntity, SalesTerritoryHistoryEntityFactory>("SalesPerson", true, false, ref _salesTerritoryHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'StoreEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(StoreEntity))]
		public virtual EntityCollection<StoreEntity> Stores
		{
			get { return GetOrCreateEntityCollection<StoreEntity, StoreEntityFactory>("SalesPerson", true, false, ref _stores);	}
		}

		/// <summary> Gets / sets related entity of type 'SalesTerritoryEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SalesTerritoryEntity SalesTerritory
		{
			get	{ return _salesTerritory; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSalesTerritory(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesPeople", "SalesTerritory", _salesTerritory, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get { return _employee; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncEmployee(value);
					CallSetRelatedEntityDuringDeserialization(value, "SalesPerson");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_employee !=null);
						DesetupSyncEmployee(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("Employee");
						}
					}
					else
					{
						if(_employee!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "SalesPerson");
							SetupSyncEmployee(value);
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
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v52.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity; }
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
