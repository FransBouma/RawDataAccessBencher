///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
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
using AdventureWorks.Dal.Adapter.v50;
using AdventureWorks.Dal.Adapter.v50.HelperClasses;
using AdventureWorks.Dal.Adapter.v50.FactoryClasses;
using AdventureWorks.Dal.Adapter.v50.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v50.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'PurchaseOrderHeader'.<br/><br/></summary>
	[Serializable]
	public partial class PurchaseOrderHeaderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<PurchaseOrderDetailEntity> _purchaseOrderDetails;
		private EmployeeEntity _employee;
		private ShipMethodEntity _shipMethod;
		private VendorEntity _vendor;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name ShipMethod</summary>
			public static readonly string ShipMethod = "ShipMethod";
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";
			/// <summary>Member name PurchaseOrderDetails</summary>
			public static readonly string PurchaseOrderDetails = "PurchaseOrderDetails";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PurchaseOrderHeaderEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public PurchaseOrderHeaderEntity():base("PurchaseOrderHeaderEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PurchaseOrderHeaderEntity(IEntityFields2 fields):base("PurchaseOrderHeaderEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PurchaseOrderHeaderEntity</param>
		public PurchaseOrderHeaderEntity(IValidator validator):base("PurchaseOrderHeaderEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="purchaseOrderId">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderId):base("PurchaseOrderHeaderEntity")
		{
			InitClassEmpty(null, null);
			this.PurchaseOrderId = purchaseOrderId;
		}

		/// <summary> CTor</summary>
		/// <param name="purchaseOrderId">PK value for PurchaseOrderHeader which data should be fetched into this PurchaseOrderHeader object</param>
		/// <param name="validator">The custom validator object for this PurchaseOrderHeaderEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PurchaseOrderHeaderEntity(System.Int32 purchaseOrderId, IValidator validator):base("PurchaseOrderHeaderEntity")
		{
			InitClassEmpty(validator, null);
			this.PurchaseOrderId = purchaseOrderId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PurchaseOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_purchaseOrderDetails = (EntityCollection<PurchaseOrderDetailEntity>)info.GetValue("_purchaseOrderDetails", typeof(EntityCollection<PurchaseOrderDetailEntity>));
				_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
				if(_employee!=null)
				{
					_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_shipMethod = (ShipMethodEntity)info.GetValue("_shipMethod", typeof(ShipMethodEntity));
				if(_shipMethod!=null)
				{
					_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_vendor = (VendorEntity)info.GetValue("_vendor", typeof(VendorEntity));
				if(_vendor!=null)
				{
					_vendor.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((PurchaseOrderHeaderFieldIndex)fieldIndex)
			{
				case PurchaseOrderHeaderFieldIndex.EmployeeId:
					DesetupSyncEmployee(true, false);
					break;
				case PurchaseOrderHeaderFieldIndex.ShipMethodId:
					DesetupSyncShipMethod(true, false);
					break;
				case PurchaseOrderHeaderFieldIndex.VendorId:
					DesetupSyncVendor(true, false);
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
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
					break;
				case "ShipMethod":
					this.ShipMethod = (ShipMethodEntity)entity;
					break;
				case "Vendor":
					this.Vendor = (VendorEntity)entity;
					break;
				case "PurchaseOrderDetails":
					this.PurchaseOrderDetails.Add((PurchaseOrderDetailEntity)entity);
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
				case "Employee":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeId);
					break;
				case "ShipMethod":
					toReturn.Add(Relations.ShipMethodEntityUsingShipMethodId);
					break;
				case "Vendor":
					toReturn.Add(Relations.VendorEntityUsingVendorId);
					break;
				case "PurchaseOrderDetails":
					toReturn.Add(Relations.PurchaseOrderDetailEntityUsingPurchaseOrderId);
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
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "Vendor":
					SetupSyncVendor(relatedEntity);
					break;
				case "PurchaseOrderDetails":
					this.PurchaseOrderDetails.Add((PurchaseOrderDetailEntity)relatedEntity);
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
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false, true);
					break;
				case "Vendor":
					DesetupSyncVendor(false, true);
					break;
				case "PurchaseOrderDetails":
					this.PerformRelatedEntityRemoval(this.PurchaseOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}
			if(_shipMethod!=null)
			{
				toReturn.Add(_shipMethod);
			}
			if(_vendor!=null)
			{
				toReturn.Add(_vendor);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.PurchaseOrderDetails);
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
				info.AddValue("_purchaseOrderDetails", ((_purchaseOrderDetails!=null) && (_purchaseOrderDetails.Count>0) && !this.MarkedForDeletion)?_purchaseOrderDetails:null);
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
				info.AddValue("_shipMethod", (!this.MarkedForDeletion?_shipMethod:null));
				info.AddValue("_vendor", (!this.MarkedForDeletion?_vendor:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PurchaseOrderHeaderRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderDetails()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PurchaseOrderDetailFields.PurchaseOrderId, null, ComparisonOperator.Equal, this.PurchaseOrderId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ShipMethod' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipMethod()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendor()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(VendorFields.VendorId, null, ComparisonOperator.Equal, this.VendorId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._purchaseOrderDetails);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._purchaseOrderDetails = (EntityCollection<PurchaseOrderDetailEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._purchaseOrderDetails != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PurchaseOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderDetailEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Employee", _employee);
			toReturn.Add("ShipMethod", _shipMethod);
			toReturn.Add("Vendor", _vendor);
			toReturn.Add("PurchaseOrderDetails", _purchaseOrderDetails);
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
			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PurchaseOrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RevisionNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipMethodId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SubTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TaxAmt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TotalDue", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VendorId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AdventureWorks.Dal.Adapter.v50.RelationClasses.StaticPurchaseOrderHeaderRelations.EmployeeEntityUsingEmployeeIdStatic, true, signalRelatedEntity, "PurchaseOrderHeaders", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.EmployeeId } );
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
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AdventureWorks.Dal.Adapter.v50.RelationClasses.StaticPurchaseOrderHeaderRelations.EmployeeEntityUsingEmployeeIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _shipMethod</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShipMethod(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", AdventureWorks.Dal.Adapter.v50.RelationClasses.StaticPurchaseOrderHeaderRelations.ShipMethodEntityUsingShipMethodIdStatic, true, signalRelatedEntity, "PurchaseOrderHeaders", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.ShipMethodId } );
			_shipMethod = null;
		}

		/// <summary> setups the sync logic for member _shipMethod</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncShipMethod(IEntityCore relatedEntity)
		{
			if(_shipMethod!=relatedEntity)
			{
				DesetupSyncShipMethod(true, true);
				_shipMethod = (ShipMethodEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", AdventureWorks.Dal.Adapter.v50.RelationClasses.StaticPurchaseOrderHeaderRelations.ShipMethodEntityUsingShipMethodIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnShipMethodPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _vendor</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncVendor(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AdventureWorks.Dal.Adapter.v50.RelationClasses.StaticPurchaseOrderHeaderRelations.VendorEntityUsingVendorIdStatic, true, signalRelatedEntity, "PurchaseOrderHeaders", resetFKFields, new int[] { (int)PurchaseOrderHeaderFieldIndex.VendorId } );
			_vendor = null;
		}

		/// <summary> setups the sync logic for member _vendor</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncVendor(IEntityCore relatedEntity)
		{
			if(_vendor!=relatedEntity)
			{
				DesetupSyncVendor(true, true);
				_vendor = (VendorEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _vendor, new PropertyChangedEventHandler( OnVendorPropertyChanged ), "Vendor", AdventureWorks.Dal.Adapter.v50.RelationClasses.StaticPurchaseOrderHeaderRelations.VendorEntityUsingVendorIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnVendorPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PurchaseOrderHeaderEntity</param>
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
		public  static PurchaseOrderHeaderRelations Relations
		{
			get	{ return new PurchaseOrderHeaderRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderDetails
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PurchaseOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderDetailEntityFactory))), (IEntityRelation)GetRelationsForField("PurchaseOrderDetails")[0], (int)AdventureWorks.Dal.Adapter.v50.EntityType.PurchaseOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v50.EntityType.PurchaseOrderDetailEntity, 0, null, null, null, null, "PurchaseOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))),	(IEntityRelation)GetRelationsForField("Employee")[0], (int)AdventureWorks.Dal.Adapter.v50.EntityType.PurchaseOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v50.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShipMethod' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipMethod
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))),	(IEntityRelation)GetRelationsForField("ShipMethod")[0], (int)AdventureWorks.Dal.Adapter.v50.EntityType.PurchaseOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v50.EntityType.ShipMethodEntity, 0, null, null, null, null, "ShipMethod", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendor
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(VendorEntityFactory))),	(IEntityRelation)GetRelationsForField("Vendor")[0], (int)AdventureWorks.Dal.Adapter.v50.EntityType.PurchaseOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v50.EntityType.VendorEntity, 0, null, null, null, null, "Vendor", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The EmployeeId property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."EmployeeID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.EmployeeId, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.EmployeeId, value); }
		}

		/// <summary> The Freight property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."Freight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Freight
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.Freight, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.Freight, value); }
		}

		/// <summary> The ModifiedDate property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderHeaderFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The OrderDate property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."OrderDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime OrderDate
		{
			get { return (System.DateTime)GetValue((int)PurchaseOrderHeaderFieldIndex.OrderDate, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.OrderDate, value); }
		}

		/// <summary> The PurchaseOrderId property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."PurchaseOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 PurchaseOrderId
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.PurchaseOrderId, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.PurchaseOrderId, value); }
		}

		/// <summary> The RevisionNumber property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."RevisionNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte RevisionNumber
		{
			get { return (System.Byte)GetValue((int)PurchaseOrderHeaderFieldIndex.RevisionNumber, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.RevisionNumber, value); }
		}

		/// <summary> The ShipDate property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ShipDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShipDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PurchaseOrderHeaderFieldIndex.ShipDate, false); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ShipDate, value); }
		}

		/// <summary> The ShipMethodId property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."ShipMethodID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipMethodId
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.ShipMethodId, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.ShipMethodId, value); }
		}

		/// <summary> The Status property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte Status
		{
			get { return (System.Byte)GetValue((int)PurchaseOrderHeaderFieldIndex.Status, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.Status, value); }
		}

		/// <summary> The SubTotal property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."SubTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SubTotal
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.SubTotal, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.SubTotal, value); }
		}

		/// <summary> The TaxAmt property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."TaxAmt"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxAmt
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.TaxAmt, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.TaxAmt, value); }
		}

		/// <summary> The TotalDue property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."TotalDue"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalDue
		{
			get { return (System.Decimal)GetValue((int)PurchaseOrderHeaderFieldIndex.TotalDue, true); }

		}

		/// <summary> The VendorId property of the Entity PurchaseOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PurchaseOrderHeader"."VendorID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 VendorId
		{
			get { return (System.Int32)GetValue((int)PurchaseOrderHeaderFieldIndex.VendorId, true); }
			set	{ SetValue((int)PurchaseOrderHeaderFieldIndex.VendorId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PurchaseOrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderDetailEntity))]
		public virtual EntityCollection<PurchaseOrderDetailEntity> PurchaseOrderDetails
		{
			get { return GetOrCreateEntityCollection<PurchaseOrderDetailEntity, PurchaseOrderDetailEntityFactory>("PurchaseOrderHeader", true, false, ref _purchaseOrderDetails);	}
		}

		/// <summary> Gets / sets related entity of type 'EmployeeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual EmployeeEntity Employee
		{
			get	{ return _employee; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncEmployee(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderHeaders", "Employee", _employee, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'ShipMethodEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ShipMethodEntity ShipMethod
		{
			get	{ return _shipMethod; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncShipMethod(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderHeaders", "ShipMethod", _shipMethod, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'VendorEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get	{ return _vendor; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncVendor(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "PurchaseOrderHeaders", "Vendor", _vendor, true); 
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
		
		/// <summary>Returns the AdventureWorks.Dal.Adapter.v50.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)AdventureWorks.Dal.Adapter.v50.EntityType.PurchaseOrderHeaderEntity; }
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
