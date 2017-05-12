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
	/// <summary>Entity class which represents the entity 'BusinessEntityAddress'.<br/><br/></summary>
	[Serializable]
	public partial class BusinessEntityAddressEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private AddressEntity _address;
		private AddressTypeEntity _addressType;
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
			/// <summary>Member name Address</summary>
			public static readonly string Address = "Address";
			/// <summary>Member name AddressType</summary>
			public static readonly string AddressType = "AddressType";
			/// <summary>Member name BusinessEntity</summary>
			public static readonly string BusinessEntity = "BusinessEntity";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static BusinessEntityAddressEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public BusinessEntityAddressEntity():base("BusinessEntityAddressEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public BusinessEntityAddressEntity(IEntityFields2 fields):base("BusinessEntityAddressEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this BusinessEntityAddressEntity</param>
		public BusinessEntityAddressEntity(IValidator validator):base("BusinessEntityAddressEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="addressId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="addressTypeId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="businessEntityId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public BusinessEntityAddressEntity(System.Int32 addressId, System.Int32 addressTypeId, System.Int32 businessEntityId):base("BusinessEntityAddressEntity")
		{
			InitClassEmpty(null, null);
			this.AddressId = addressId;
			this.AddressTypeId = addressTypeId;
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary> CTor</summary>
		/// <param name="addressId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="addressTypeId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="businessEntityId">PK value for BusinessEntityAddress which data should be fetched into this BusinessEntityAddress object</param>
		/// <param name="validator">The custom validator object for this BusinessEntityAddressEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public BusinessEntityAddressEntity(System.Int32 addressId, System.Int32 addressTypeId, System.Int32 businessEntityId, IValidator validator):base("BusinessEntityAddressEntity")
		{
			InitClassEmpty(validator, null);
			this.AddressId = addressId;
			this.AddressTypeId = addressTypeId;
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected BusinessEntityAddressEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_address = (AddressEntity)info.GetValue("_address", typeof(AddressEntity));
				if(_address!=null)
				{
					_address.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_addressType = (AddressTypeEntity)info.GetValue("_addressType", typeof(AddressTypeEntity));
				if(_addressType!=null)
				{
					_addressType.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
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
			switch((BusinessEntityAddressFieldIndex)fieldIndex)
			{
				case BusinessEntityAddressFieldIndex.AddressId:
					DesetupSyncAddress(true, false);
					break;
				case BusinessEntityAddressFieldIndex.AddressTypeId:
					DesetupSyncAddressType(true, false);
					break;
				case BusinessEntityAddressFieldIndex.BusinessEntityId:
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
				case "Address":
					this.Address = (AddressEntity)entity;
					break;
				case "AddressType":
					this.AddressType = (AddressTypeEntity)entity;
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
				case "Address":
					toReturn.Add(Relations.AddressEntityUsingAddressId);
					break;
				case "AddressType":
					toReturn.Add(Relations.AddressTypeEntityUsingAddressTypeId);
					break;
				case "BusinessEntity":
					toReturn.Add(Relations.BusinessEntityEntityUsingBusinessEntityId);
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
				case "Address":
					SetupSyncAddress(relatedEntity);
					break;
				case "AddressType":
					SetupSyncAddressType(relatedEntity);
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
				case "Address":
					DesetupSyncAddress(false, true);
					break;
				case "AddressType":
					DesetupSyncAddressType(false, true);
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
			if(_address!=null)
			{
				toReturn.Add(_address);
			}
			if(_addressType!=null)
			{
				toReturn.Add(_addressType);
			}
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
				info.AddValue("_address", (!this.MarkedForDeletion?_address:null));
				info.AddValue("_addressType", (!this.MarkedForDeletion?_addressType:null));
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
			return new BusinessEntityAddressRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddress()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.AddressId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'AddressType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddressType()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressTypeFields.AddressTypeId, null, ComparisonOperator.Equal, this.AddressTypeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'BusinessEntity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntity()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BusinessEntityFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityAddressEntityFactory));
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
			toReturn.Add("Address", _address);
			toReturn.Add("AddressType", _addressType);
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
			_fieldsCustomProperties.Add("AddressId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("AddressTypeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BusinessEntityId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _address</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddress(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticBusinessEntityAddressRelations.AddressEntityUsingAddressIdStatic, true, signalRelatedEntity, "BusinessEntityAddresses", resetFKFields, new int[] { (int)BusinessEntityAddressFieldIndex.AddressId } );
			_address = null;
		}

		/// <summary> setups the sync logic for member _address</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress(IEntityCore relatedEntity)
		{
			if(_address!=relatedEntity)
			{
				DesetupSyncAddress(true, true);
				_address = (AddressEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticBusinessEntityAddressRelations.AddressEntityUsingAddressIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAddressPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _addressType</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddressType(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _addressType, new PropertyChangedEventHandler( OnAddressTypePropertyChanged ), "AddressType", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticBusinessEntityAddressRelations.AddressTypeEntityUsingAddressTypeIdStatic, true, signalRelatedEntity, "BusinessEntityAddresses", resetFKFields, new int[] { (int)BusinessEntityAddressFieldIndex.AddressTypeId } );
			_addressType = null;
		}

		/// <summary> setups the sync logic for member _addressType</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddressType(IEntityCore relatedEntity)
		{
			if(_addressType!=relatedEntity)
			{
				DesetupSyncAddressType(true, true);
				_addressType = (AddressTypeEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _addressType, new PropertyChangedEventHandler( OnAddressTypePropertyChanged ), "AddressType", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticBusinessEntityAddressRelations.AddressTypeEntityUsingAddressTypeIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAddressTypePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _businessEntity</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBusinessEntity(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _businessEntity, new PropertyChangedEventHandler( OnBusinessEntityPropertyChanged ), "BusinessEntity", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticBusinessEntityAddressRelations.BusinessEntityEntityUsingBusinessEntityIdStatic, true, signalRelatedEntity, "BusinessEntityAddresses", resetFKFields, new int[] { (int)BusinessEntityAddressFieldIndex.BusinessEntityId } );
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
				this.PerformSetupSyncRelatedEntity( _businessEntity, new PropertyChangedEventHandler( OnBusinessEntityPropertyChanged ), "BusinessEntity", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticBusinessEntityAddressRelations.BusinessEntityEntityUsingBusinessEntityIdStatic, true, new string[] {  } );
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
		/// <param name="validator">The validator object for this BusinessEntityAddressEntity</param>
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
		public  static BusinessEntityAddressRelations Relations
		{
			get	{ return new BusinessEntityAddressRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddress
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))),	(IEntityRelation)GetRelationsForField("Address")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.BusinessEntityAddressEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.AddressEntity, 0, null, null, null, null, "Address", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'AddressType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddressType
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AddressTypeEntityFactory))),	(IEntityRelation)GetRelationsForField("AddressType")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.BusinessEntityAddressEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.AddressTypeEntity, 0, null, null, null, null, "AddressType", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntity
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityEntityFactory))),	(IEntityRelation)GetRelationsForField("BusinessEntity")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.BusinessEntityAddressEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.BusinessEntityEntity, 0, null, null, null, null, "BusinessEntity", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AddressId property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."AddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AddressId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityAddressFieldIndex.AddressId, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.AddressId, value); }
		}

		/// <summary> The AddressTypeId property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."AddressTypeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 AddressTypeId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityAddressFieldIndex.AddressTypeId, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.AddressTypeId, value); }
		}

		/// <summary> The BusinessEntityId property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."BusinessEntityID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityAddressFieldIndex.BusinessEntityId, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.BusinessEntityId, value); }
		}

		/// <summary> The ModifiedDate property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)BusinessEntityAddressFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The Rowguid property of the Entity BusinessEntityAddress<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityAddress"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)BusinessEntityAddressFieldIndex.Rowguid, true); }
			set	{ SetValue((int)BusinessEntityAddressFieldIndex.Rowguid, value); }
		}

		/// <summary> Gets / sets related entity of type 'AddressEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual AddressEntity Address
		{
			get	{ return _address; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAddress(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BusinessEntityAddresses", "Address", _address, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AddressTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual AddressTypeEntity AddressType
		{
			get	{ return _addressType; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAddressType(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BusinessEntityAddresses", "AddressType", _addressType, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'BusinessEntityEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual BusinessEntityEntity BusinessEntity
		{
			get	{ return _businessEntity; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncBusinessEntity(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "BusinessEntityAddresses", "BusinessEntity", _businessEntity, true); 
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
			get { return (int)AdventureWorks.Dal.Adapter.v52.EntityType.BusinessEntityAddressEntity; }
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
