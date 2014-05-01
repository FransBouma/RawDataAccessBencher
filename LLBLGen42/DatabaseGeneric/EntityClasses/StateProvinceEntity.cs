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
	/// <summary>Entity class which represents the entity 'StateProvince'.<br/><br/></summary>
	[Serializable]
	public partial class StateProvinceEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<AddressEntity> _addresses;
		private EntityCollection<SalesTaxRateEntity> _salesTaxRates;
		private CountryRegionEntity _countryRegion;
		private SalesTerritoryEntity _salesTerritory;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CountryRegion</summary>
			public static readonly string CountryRegion = "CountryRegion";
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name Addresses</summary>
			public static readonly string Addresses = "Addresses";
			/// <summary>Member name SalesTaxRates</summary>
			public static readonly string SalesTaxRates = "SalesTaxRates";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static StateProvinceEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public StateProvinceEntity():base("StateProvinceEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public StateProvinceEntity(IEntityFields2 fields):base("StateProvinceEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this StateProvinceEntity</param>
		public StateProvinceEntity(IValidator validator):base("StateProvinceEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public StateProvinceEntity(System.Int32 stateProvinceId):base("StateProvinceEntity")
		{
			InitClassEmpty(null, null);
			this.StateProvinceId = stateProvinceId;
		}

		/// <summary> CTor</summary>
		/// <param name="stateProvinceId">PK value for StateProvince which data should be fetched into this StateProvince object</param>
		/// <param name="validator">The custom validator object for this StateProvinceEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public StateProvinceEntity(System.Int32 stateProvinceId, IValidator validator):base("StateProvinceEntity")
		{
			InitClassEmpty(validator, null);
			this.StateProvinceId = stateProvinceId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected StateProvinceEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_addresses = (EntityCollection<AddressEntity>)info.GetValue("_addresses", typeof(EntityCollection<AddressEntity>));
				_salesTaxRates = (EntityCollection<SalesTaxRateEntity>)info.GetValue("_salesTaxRates", typeof(EntityCollection<SalesTaxRateEntity>));
				_countryRegion = (CountryRegionEntity)info.GetValue("_countryRegion", typeof(CountryRegionEntity));
				if(_countryRegion!=null)
				{
					_countryRegion.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
				if(_salesTerritory!=null)
				{
					_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((StateProvinceFieldIndex)fieldIndex)
			{
				case StateProvinceFieldIndex.CountryRegionCode:
					DesetupSyncCountryRegion(true, false);
					break;
				case StateProvinceFieldIndex.TerritoryId:
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
				case "CountryRegion":
					this.CountryRegion = (CountryRegionEntity)entity;
					break;
				case "SalesTerritory":
					this.SalesTerritory = (SalesTerritoryEntity)entity;
					break;
				case "Addresses":
					this.Addresses.Add((AddressEntity)entity);
					break;
				case "SalesTaxRates":
					this.SalesTaxRates.Add((SalesTaxRateEntity)entity);
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
				case "CountryRegion":
					toReturn.Add(Relations.CountryRegionEntityUsingCountryRegionCode);
					break;
				case "SalesTerritory":
					toReturn.Add(Relations.SalesTerritoryEntityUsingTerritoryId);
					break;
				case "Addresses":
					toReturn.Add(Relations.AddressEntityUsingStateProvinceId);
					break;
				case "SalesTaxRates":
					toReturn.Add(Relations.SalesTaxRateEntityUsingStateProvinceId);
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
				case "CountryRegion":
					SetupSyncCountryRegion(relatedEntity);
					break;
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "Addresses":
					this.Addresses.Add((AddressEntity)relatedEntity);
					break;
				case "SalesTaxRates":
					this.SalesTaxRates.Add((SalesTaxRateEntity)relatedEntity);
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
				case "CountryRegion":
					DesetupSyncCountryRegion(false, true);
					break;
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
					break;
				case "Addresses":
					this.PerformRelatedEntityRemoval(this.Addresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesTaxRates":
					this.PerformRelatedEntityRemoval(this.SalesTaxRates, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_countryRegion!=null)
			{
				toReturn.Add(_countryRegion);
			}
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Addresses);
			toReturn.Add(this.SalesTaxRates);
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
				info.AddValue("_addresses", ((_addresses!=null) && (_addresses.Count>0) && !this.MarkedForDeletion)?_addresses:null);
				info.AddValue("_salesTaxRates", ((_salesTaxRates!=null) && (_salesTaxRates.Count>0) && !this.MarkedForDeletion)?_salesTaxRates:null);
				info.AddValue("_countryRegion", (!this.MarkedForDeletion?_countryRegion:null));
				info.AddValue("_salesTerritory", (!this.MarkedForDeletion?_salesTerritory:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new StateProvinceRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddresses()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.StateProvinceId, null, ComparisonOperator.Equal, this.StateProvinceId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesTaxRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesTaxRates()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesTaxRateFields.StateProvinceId, null, ComparisonOperator.Equal, this.StateProvinceId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CountryRegion' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegion()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CountryRegionFields.CountryRegionCode, null, ComparisonOperator.Equal, this.CountryRegionCode));
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
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(StateProvinceEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._addresses);
			collectionsQueue.Enqueue(this._salesTaxRates);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._addresses = (EntityCollection<AddressEntity>) collectionsQueue.Dequeue();
			this._salesTaxRates = (EntityCollection<SalesTaxRateEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._addresses != null);
			toReturn |=(this._salesTaxRates != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesTaxRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTaxRateEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("CountryRegion", _countryRegion);
			toReturn.Add("SalesTerritory", _salesTerritory);
			toReturn.Add("Addresses", _addresses);
			toReturn.Add("SalesTaxRates", _salesTaxRates);
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
			_fieldsCustomProperties.Add("CountryRegionCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("IsOnlyStateProvinceFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StateProvinceCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StateProvinceId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _countryRegion</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCountryRegion(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticStateProvinceRelations.CountryRegionEntityUsingCountryRegionCodeStatic, true, signalRelatedEntity, "StateProvinces", resetFKFields, new int[] { (int)StateProvinceFieldIndex.CountryRegionCode } );
			_countryRegion = null;
		}

		/// <summary> setups the sync logic for member _countryRegion</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCountryRegion(IEntityCore relatedEntity)
		{
			if(_countryRegion!=relatedEntity)
			{
				DesetupSyncCountryRegion(true, true);
				_countryRegion = (CountryRegionEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticStateProvinceRelations.CountryRegionEntityUsingCountryRegionCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCountryRegionPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _salesTerritory</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesTerritory(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticStateProvinceRelations.SalesTerritoryEntityUsingTerritoryIdStatic, true, signalRelatedEntity, "StateProvinces", resetFKFields, new int[] { (int)StateProvinceFieldIndex.TerritoryId } );
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
				this.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AdventureWorks.Dal.Adapter.v42.RelationClasses.StaticStateProvinceRelations.SalesTerritoryEntityUsingTerritoryIdStatic, true, new string[] {  } );
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

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this StateProvinceEntity</param>
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
		public  static StateProvinceRelations Relations
		{
			get	{ return new StateProvinceRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddresses
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<AddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))), (IEntityRelation)GetRelationsForField("Addresses")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.StateProvinceEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.AddressEntity, 0, null, null, null, null, "Addresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTaxRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTaxRates
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesTaxRateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesTaxRateEntityFactory))), (IEntityRelation)GetRelationsForField("SalesTaxRates")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.StateProvinceEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.SalesTaxRateEntity, 0, null, null, null, null, "SalesTaxRates", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegion' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegion
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionEntityFactory))),	(IEntityRelation)GetRelationsForField("CountryRegion")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.StateProvinceEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.CountryRegionEntity, 0, null, null, null, null, "CountryRegion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))),	(IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AdventureWorks.Dal.Adapter.v42.EntityType.StateProvinceEntity, (int)AdventureWorks.Dal.Adapter.v42.EntityType.SalesTerritoryEntity, 0, null, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CountryRegionCode property of the Entity StateProvince<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)StateProvinceFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.CountryRegionCode, value); }
		}

		/// <summary> The IsOnlyStateProvinceFlag property of the Entity StateProvince<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."IsOnlyStateProvinceFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean IsOnlyStateProvinceFlag
		{
			get { return (System.Boolean)GetValue((int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, value); }
		}

		/// <summary> The ModifiedDate property of the Entity StateProvince<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)StateProvinceFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Name property of the Entity StateProvince<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)StateProvinceFieldIndex.Name, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.Name, value); }
		}

		/// <summary> The Rowguid property of the Entity StateProvince<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)StateProvinceFieldIndex.Rowguid, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.Rowguid, value); }
		}

		/// <summary> The StateProvinceCode property of the Entity StateProvince<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."StateProvinceCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String StateProvinceCode
		{
			get { return (System.String)GetValue((int)StateProvinceFieldIndex.StateProvinceCode, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.StateProvinceCode, value); }
		}

		/// <summary> The StateProvinceId property of the Entity StateProvince<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."StateProvinceID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 StateProvinceId
		{
			get { return (System.Int32)GetValue((int)StateProvinceFieldIndex.StateProvinceId, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.StateProvinceId, value); }
		}

		/// <summary> The TerritoryId property of the Entity StateProvince<br/><br/></summary>
		/// <remarks>Mapped on  table field: "StateProvince"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 TerritoryId
		{
			get { return (System.Int32)GetValue((int)StateProvinceFieldIndex.TerritoryId, true); }
			set	{ SetValue((int)StateProvinceFieldIndex.TerritoryId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'AddressEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(AddressEntity))]
		public virtual EntityCollection<AddressEntity> Addresses
		{
			get { return GetOrCreateEntityCollection<AddressEntity, AddressEntityFactory>("StateProvince", true, false, ref _addresses);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesTaxRateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesTaxRateEntity))]
		public virtual EntityCollection<SalesTaxRateEntity> SalesTaxRates
		{
			get { return GetOrCreateEntityCollection<SalesTaxRateEntity, SalesTaxRateEntityFactory>("StateProvince", true, false, ref _salesTaxRates);	}
		}

		/// <summary> Gets / sets related entity of type 'CountryRegionEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CountryRegionEntity CountryRegion
		{
			get	{ return _countryRegion; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCountryRegion(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "StateProvinces", "CountryRegion", _countryRegion, true); 
				}
			}
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
					SetSingleRelatedEntityNavigator(value, "StateProvinces", "SalesTerritory", _salesTerritory, true); 
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
			get { return (int)AdventureWorks.Dal.Adapter.v42.EntityType.StateProvinceEntity; }
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
