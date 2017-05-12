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
	/// <summary>Entity class which represents the entity 'CountryRegionCurrency'.<br/><br/></summary>
	[Serializable]
	public partial class CountryRegionCurrencyEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private CountryRegionEntity _countryRegion;
		private CurrencyEntity _currency;

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
			/// <summary>Member name Currency</summary>
			public static readonly string Currency = "Currency";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static CountryRegionCurrencyEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public CountryRegionCurrencyEntity():base("CountryRegionCurrencyEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public CountryRegionCurrencyEntity(IEntityFields2 fields):base("CountryRegionCurrencyEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this CountryRegionCurrencyEntity</param>
		public CountryRegionCurrencyEntity(IValidator validator):base("CountryRegionCurrencyEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CountryRegionCurrencyEntity(System.String countryRegionCode, System.String currencyCode):base("CountryRegionCurrencyEntity")
		{
			InitClassEmpty(null, null);
			this.CountryRegionCode = countryRegionCode;
			this.CurrencyCode = currencyCode;
		}

		/// <summary> CTor</summary>
		/// <param name="countryRegionCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="currencyCode">PK value for CountryRegionCurrency which data should be fetched into this CountryRegionCurrency object</param>
		/// <param name="validator">The custom validator object for this CountryRegionCurrencyEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public CountryRegionCurrencyEntity(System.String countryRegionCode, System.String currencyCode, IValidator validator):base("CountryRegionCurrencyEntity")
		{
			InitClassEmpty(validator, null);
			this.CountryRegionCode = countryRegionCode;
			this.CurrencyCode = currencyCode;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected CountryRegionCurrencyEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_countryRegion = (CountryRegionEntity)info.GetValue("_countryRegion", typeof(CountryRegionEntity));
				if(_countryRegion!=null)
				{
					_countryRegion.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_currency = (CurrencyEntity)info.GetValue("_currency", typeof(CurrencyEntity));
				if(_currency!=null)
				{
					_currency.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((CountryRegionCurrencyFieldIndex)fieldIndex)
			{
				case CountryRegionCurrencyFieldIndex.CountryRegionCode:
					DesetupSyncCountryRegion(true, false);
					break;
				case CountryRegionCurrencyFieldIndex.CurrencyCode:
					DesetupSyncCurrency(true, false);
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
				case "Currency":
					this.Currency = (CurrencyEntity)entity;
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
				case "Currency":
					toReturn.Add(Relations.CurrencyEntityUsingCurrencyCode);
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
				case "CountryRegion":
					SetupSyncCountryRegion(relatedEntity);
					break;
				case "Currency":
					SetupSyncCurrency(relatedEntity);
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
				case "Currency":
					DesetupSyncCurrency(false, true);
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
			if(_currency!=null)
			{
				toReturn.Add(_currency);
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
				info.AddValue("_countryRegion", (!this.MarkedForDeletion?_countryRegion:null));
				info.AddValue("_currency", (!this.MarkedForDeletion?_currency:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new CountryRegionCurrencyRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CountryRegion' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCountryRegion()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CountryRegionFields.CountryRegionCode, null, ComparisonOperator.Equal, this.CountryRegionCode));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Currency' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrency()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyFields.CurrencyCode, null, ComparisonOperator.Equal, this.CurrencyCode));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionCurrencyEntityFactory));
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
			toReturn.Add("CountryRegion", _countryRegion);
			toReturn.Add("Currency", _currency);
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
			_fieldsCustomProperties.Add("CurrencyCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _countryRegion</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCountryRegion(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticCountryRegionCurrencyRelations.CountryRegionEntityUsingCountryRegionCodeStatic, true, signalRelatedEntity, "CountryRegionCurrencies", resetFKFields, new int[] { (int)CountryRegionCurrencyFieldIndex.CountryRegionCode } );
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
				this.PerformSetupSyncRelatedEntity( _countryRegion, new PropertyChangedEventHandler( OnCountryRegionPropertyChanged ), "CountryRegion", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticCountryRegionCurrencyRelations.CountryRegionEntityUsingCountryRegionCodeStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _currency</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCurrency(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticCountryRegionCurrencyRelations.CurrencyEntityUsingCurrencyCodeStatic, true, signalRelatedEntity, "CountryRegionCurrencies", resetFKFields, new int[] { (int)CountryRegionCurrencyFieldIndex.CurrencyCode } );
			_currency = null;
		}

		/// <summary> setups the sync logic for member _currency</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrency(IEntityCore relatedEntity)
		{
			if(_currency!=relatedEntity)
			{
				DesetupSyncCurrency(true, true);
				_currency = (CurrencyEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _currency, new PropertyChangedEventHandler( OnCurrencyPropertyChanged ), "Currency", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticCountryRegionCurrencyRelations.CurrencyEntityUsingCurrencyCodeStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCurrencyPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this CountryRegionCurrencyEntity</param>
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
		public  static CountryRegionCurrencyRelations Relations
		{
			get	{ return new CountryRegionCurrencyRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CountryRegion' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCountryRegion
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CountryRegionEntityFactory))),	(IEntityRelation)GetRelationsForField("CountryRegion")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.CountryRegionCurrencyEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.CountryRegionEntity, 0, null, null, null, null, "CountryRegion", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Currency' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrency
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyEntityFactory))),	(IEntityRelation)GetRelationsForField("Currency")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.CountryRegionCurrencyEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.CurrencyEntity, 0, null, null, null, null, "Currency", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The CountryRegionCode property of the Entity CountryRegionCurrency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."CountryRegionCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CountryRegionCode
		{
			get { return (System.String)GetValue((int)CountryRegionCurrencyFieldIndex.CountryRegionCode, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.CountryRegionCode, value); }
		}

		/// <summary> The CurrencyCode property of the Entity CountryRegionCurrency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."CurrencyCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.String CurrencyCode
		{
			get { return (System.String)GetValue((int)CountryRegionCurrencyFieldIndex.CurrencyCode, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.CurrencyCode, value); }
		}

		/// <summary> The ModifiedDate property of the Entity CountryRegionCurrency<br/><br/></summary>
		/// <remarks>Mapped on  table field: "CountryRegionCurrency"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)CountryRegionCurrencyFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)CountryRegionCurrencyFieldIndex.ModifiedDate, value); }
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
					SetSingleRelatedEntityNavigator(value, "CountryRegionCurrencies", "CountryRegion", _countryRegion, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CurrencyEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CurrencyEntity Currency
		{
			get	{ return _currency; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCurrency(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "CountryRegionCurrencies", "Currency", _currency, true); 
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
			get { return (int)AdventureWorks.Dal.Adapter.v52.EntityType.CountryRegionCurrencyEntity; }
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
