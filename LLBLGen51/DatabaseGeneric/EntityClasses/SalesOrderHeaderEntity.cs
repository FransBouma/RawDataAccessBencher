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
	/// <summary>Entity class which represents the entity 'SalesOrderHeader'.<br/><br/></summary>
	[Serializable]
	public partial class SalesOrderHeaderEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<SalesOrderDetailEntity> _salesOrderDetails;
		private EntityCollection<SalesOrderHeaderSalesReasonEntity> _salesOrderHeaderSalesReasons;
		private AddressEntity _address;
		private AddressEntity _address_;
		private CreditCardEntity _creditCard;
		private CurrencyRateEntity _currencyRate;
		private CustomerEntity _customer;
		private SalesPersonEntity _salesPerson;
		private SalesTerritoryEntity _salesTerritory;
		private ShipMethodEntity _shipMethod;

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
			/// <summary>Member name Address_</summary>
			public static readonly string Address_ = "Address_";
			/// <summary>Member name CreditCard</summary>
			public static readonly string CreditCard = "CreditCard";
			/// <summary>Member name CurrencyRate</summary>
			public static readonly string CurrencyRate = "CurrencyRate";
			/// <summary>Member name Customer</summary>
			public static readonly string Customer = "Customer";
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
			/// <summary>Member name SalesTerritory</summary>
			public static readonly string SalesTerritory = "SalesTerritory";
			/// <summary>Member name ShipMethod</summary>
			public static readonly string ShipMethod = "ShipMethod";
			/// <summary>Member name SalesOrderDetails</summary>
			public static readonly string SalesOrderDetails = "SalesOrderDetails";
			/// <summary>Member name SalesOrderHeaderSalesReasons</summary>
			public static readonly string SalesOrderHeaderSalesReasons = "SalesOrderHeaderSalesReasons";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static SalesOrderHeaderEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public SalesOrderHeaderEntity():base("SalesOrderHeaderEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public SalesOrderHeaderEntity(IEntityFields2 fields):base("SalesOrderHeaderEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		public SalesOrderHeaderEntity(IValidator validator):base("SalesOrderHeaderEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId):base("SalesOrderHeaderEntity")
		{
			InitClassEmpty(null, null);
			this.SalesOrderId = salesOrderId;
		}

		/// <summary> CTor</summary>
		/// <param name="salesOrderId">PK value for SalesOrderHeader which data should be fetched into this SalesOrderHeader object</param>
		/// <param name="validator">The custom validator object for this SalesOrderHeaderEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public SalesOrderHeaderEntity(System.Int32 salesOrderId, IValidator validator):base("SalesOrderHeaderEntity")
		{
			InitClassEmpty(validator, null);
			this.SalesOrderId = salesOrderId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected SalesOrderHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_salesOrderDetails = (EntityCollection<SalesOrderDetailEntity>)info.GetValue("_salesOrderDetails", typeof(EntityCollection<SalesOrderDetailEntity>));
				_salesOrderHeaderSalesReasons = (EntityCollection<SalesOrderHeaderSalesReasonEntity>)info.GetValue("_salesOrderHeaderSalesReasons", typeof(EntityCollection<SalesOrderHeaderSalesReasonEntity>));
				_address = (AddressEntity)info.GetValue("_address", typeof(AddressEntity));
				if(_address!=null)
				{
					_address.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_address_ = (AddressEntity)info.GetValue("_address_", typeof(AddressEntity));
				if(_address_!=null)
				{
					_address_.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_creditCard = (CreditCardEntity)info.GetValue("_creditCard", typeof(CreditCardEntity));
				if(_creditCard!=null)
				{
					_creditCard.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_currencyRate = (CurrencyRateEntity)info.GetValue("_currencyRate", typeof(CurrencyRateEntity));
				if(_currencyRate!=null)
				{
					_currencyRate.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_customer = (CustomerEntity)info.GetValue("_customer", typeof(CustomerEntity));
				if(_customer!=null)
				{
					_customer.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
				if(_salesPerson!=null)
				{
					_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_salesTerritory = (SalesTerritoryEntity)info.GetValue("_salesTerritory", typeof(SalesTerritoryEntity));
				if(_salesTerritory!=null)
				{
					_salesTerritory.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_shipMethod = (ShipMethodEntity)info.GetValue("_shipMethod", typeof(ShipMethodEntity));
				if(_shipMethod!=null)
				{
					_shipMethod.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((SalesOrderHeaderFieldIndex)fieldIndex)
			{
				case SalesOrderHeaderFieldIndex.BillToAddressId:
					DesetupSyncAddress(true, false);
					break;
				case SalesOrderHeaderFieldIndex.CreditCardId:
					DesetupSyncCreditCard(true, false);
					break;
				case SalesOrderHeaderFieldIndex.CurrencyRateId:
					DesetupSyncCurrencyRate(true, false);
					break;
				case SalesOrderHeaderFieldIndex.CustomerId:
					DesetupSyncCustomer(true, false);
					break;
				case SalesOrderHeaderFieldIndex.SalesPersonId:
					DesetupSyncSalesPerson(true, false);
					break;
				case SalesOrderHeaderFieldIndex.ShipMethodId:
					DesetupSyncShipMethod(true, false);
					break;
				case SalesOrderHeaderFieldIndex.ShipToAddressId:
					DesetupSyncAddress_(true, false);
					break;
				case SalesOrderHeaderFieldIndex.TerritoryId:
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
				case "Address":
					this.Address = (AddressEntity)entity;
					break;
				case "Address_":
					this.Address_ = (AddressEntity)entity;
					break;
				case "CreditCard":
					this.CreditCard = (CreditCardEntity)entity;
					break;
				case "CurrencyRate":
					this.CurrencyRate = (CurrencyRateEntity)entity;
					break;
				case "Customer":
					this.Customer = (CustomerEntity)entity;
					break;
				case "SalesPerson":
					this.SalesPerson = (SalesPersonEntity)entity;
					break;
				case "SalesTerritory":
					this.SalesTerritory = (SalesTerritoryEntity)entity;
					break;
				case "ShipMethod":
					this.ShipMethod = (ShipMethodEntity)entity;
					break;
				case "SalesOrderDetails":
					this.SalesOrderDetails.Add((SalesOrderDetailEntity)entity);
					break;
				case "SalesOrderHeaderSalesReasons":
					this.SalesOrderHeaderSalesReasons.Add((SalesOrderHeaderSalesReasonEntity)entity);
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
					toReturn.Add(Relations.AddressEntityUsingBillToAddressId);
					break;
				case "Address_":
					toReturn.Add(Relations.AddressEntityUsingShipToAddressId);
					break;
				case "CreditCard":
					toReturn.Add(Relations.CreditCardEntityUsingCreditCardId);
					break;
				case "CurrencyRate":
					toReturn.Add(Relations.CurrencyRateEntityUsingCurrencyRateId);
					break;
				case "Customer":
					toReturn.Add(Relations.CustomerEntityUsingCustomerId);
					break;
				case "SalesPerson":
					toReturn.Add(Relations.SalesPersonEntityUsingSalesPersonId);
					break;
				case "SalesTerritory":
					toReturn.Add(Relations.SalesTerritoryEntityUsingTerritoryId);
					break;
				case "ShipMethod":
					toReturn.Add(Relations.ShipMethodEntityUsingShipMethodId);
					break;
				case "SalesOrderDetails":
					toReturn.Add(Relations.SalesOrderDetailEntityUsingSalesOrderId);
					break;
				case "SalesOrderHeaderSalesReasons":
					toReturn.Add(Relations.SalesOrderHeaderSalesReasonEntityUsingSalesOrderId);
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
				case "Address":
					SetupSyncAddress(relatedEntity);
					break;
				case "Address_":
					SetupSyncAddress_(relatedEntity);
					break;
				case "CreditCard":
					SetupSyncCreditCard(relatedEntity);
					break;
				case "CurrencyRate":
					SetupSyncCurrencyRate(relatedEntity);
					break;
				case "Customer":
					SetupSyncCustomer(relatedEntity);
					break;
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
					break;
				case "SalesTerritory":
					SetupSyncSalesTerritory(relatedEntity);
					break;
				case "ShipMethod":
					SetupSyncShipMethod(relatedEntity);
					break;
				case "SalesOrderDetails":
					this.SalesOrderDetails.Add((SalesOrderDetailEntity)relatedEntity);
					break;
				case "SalesOrderHeaderSalesReasons":
					this.SalesOrderHeaderSalesReasons.Add((SalesOrderHeaderSalesReasonEntity)relatedEntity);
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
				case "Address_":
					DesetupSyncAddress_(false, true);
					break;
				case "CreditCard":
					DesetupSyncCreditCard(false, true);
					break;
				case "CurrencyRate":
					DesetupSyncCurrencyRate(false, true);
					break;
				case "Customer":
					DesetupSyncCustomer(false, true);
					break;
				case "SalesPerson":
					DesetupSyncSalesPerson(false, true);
					break;
				case "SalesTerritory":
					DesetupSyncSalesTerritory(false, true);
					break;
				case "ShipMethod":
					DesetupSyncShipMethod(false, true);
					break;
				case "SalesOrderDetails":
					this.PerformRelatedEntityRemoval(this.SalesOrderDetails, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "SalesOrderHeaderSalesReasons":
					this.PerformRelatedEntityRemoval(this.SalesOrderHeaderSalesReasons, relatedEntity, signalRelatedEntityManyToOne);
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
			if(_address_!=null)
			{
				toReturn.Add(_address_);
			}
			if(_creditCard!=null)
			{
				toReturn.Add(_creditCard);
			}
			if(_currencyRate!=null)
			{
				toReturn.Add(_currencyRate);
			}
			if(_customer!=null)
			{
				toReturn.Add(_customer);
			}
			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
			}
			if(_salesTerritory!=null)
			{
				toReturn.Add(_salesTerritory);
			}
			if(_shipMethod!=null)
			{
				toReturn.Add(_shipMethod);
			}
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.SalesOrderDetails);
			toReturn.Add(this.SalesOrderHeaderSalesReasons);
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
				info.AddValue("_salesOrderHeaderSalesReasons", ((_salesOrderHeaderSalesReasons!=null) && (_salesOrderHeaderSalesReasons.Count>0) && !this.MarkedForDeletion)?_salesOrderHeaderSalesReasons:null);
				info.AddValue("_address", (!this.MarkedForDeletion?_address:null));
				info.AddValue("_address_", (!this.MarkedForDeletion?_address_:null));
				info.AddValue("_creditCard", (!this.MarkedForDeletion?_creditCard:null));
				info.AddValue("_currencyRate", (!this.MarkedForDeletion?_currencyRate:null));
				info.AddValue("_customer", (!this.MarkedForDeletion?_customer:null));
				info.AddValue("_salesPerson", (!this.MarkedForDeletion?_salesPerson:null));
				info.AddValue("_salesTerritory", (!this.MarkedForDeletion?_salesTerritory:null));
				info.AddValue("_shipMethod", (!this.MarkedForDeletion?_shipMethod:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new SalesOrderHeaderRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderDetails()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderDetailFields.SalesOrderId, null, ComparisonOperator.Equal, this.SalesOrderId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'SalesOrderHeaderSalesReason' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesOrderHeaderSalesReasons()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesOrderHeaderSalesReasonFields.SalesOrderId, null, ComparisonOperator.Equal, this.SalesOrderId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddress()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.BillToAddressId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Address' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAddress_()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(AddressFields.AddressId, null, ComparisonOperator.Equal, this.ShipToAddressId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreditCard()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CreditCardFields.CreditCardId, null, ComparisonOperator.Equal, this.CreditCardId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CurrencyRate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCurrencyRate()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CurrencyRateFields.CurrencyRateId, null, ComparisonOperator.Equal, this.CurrencyRateId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomer()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CustomerFields.CustomerId, null, ComparisonOperator.Equal, this.CustomerId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPerson()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.SalesPersonId, null, ComparisonOperator.Equal, this.SalesPersonId));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ShipMethod' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoShipMethod()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ShipMethodFields.ShipMethodId, null, ComparisonOperator.Equal, this.ShipMethodId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._salesOrderDetails);
			collectionsQueue.Enqueue(this._salesOrderHeaderSalesReasons);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._salesOrderDetails = (EntityCollection<SalesOrderDetailEntity>) collectionsQueue.Dequeue();
			this._salesOrderHeaderSalesReasons = (EntityCollection<SalesOrderHeaderSalesReasonEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._salesOrderDetails != null);
			toReturn |=(this._salesOrderHeaderSalesReasons != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderDetailEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<SalesOrderHeaderSalesReasonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderSalesReasonEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Address", _address);
			toReturn.Add("Address_", _address_);
			toReturn.Add("CreditCard", _creditCard);
			toReturn.Add("CurrencyRate", _currencyRate);
			toReturn.Add("Customer", _customer);
			toReturn.Add("SalesPerson", _salesPerson);
			toReturn.Add("SalesTerritory", _salesTerritory);
			toReturn.Add("ShipMethod", _shipMethod);
			toReturn.Add("SalesOrderDetails", _salesOrderDetails);
			toReturn.Add("SalesOrderHeaderSalesReasons", _salesOrderHeaderSalesReasons);
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
			_fieldsCustomProperties.Add("BillToAddressId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Comment", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CreditCardApprovalCode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CreditCardId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CurrencyRateId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CustomerId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DueDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Freight", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OnlineOrderFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrderDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PurchaseOrderNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RevisionNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesOrderId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesOrderNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalesPersonId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipMethodId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ShipToAddressId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Status", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SubTotal", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TaxAmt", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TerritoryId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TotalDue", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _address</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddress(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.AddressEntityUsingBillToAddressIdStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.BillToAddressId } );
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
				this.PerformSetupSyncRelatedEntity( _address, new PropertyChangedEventHandler( OnAddressPropertyChanged ), "Address", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.AddressEntityUsingBillToAddressIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _address_</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncAddress_(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _address_, new PropertyChangedEventHandler( OnAddress_PropertyChanged ), "Address_", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.AddressEntityUsingShipToAddressIdStatic, true, signalRelatedEntity, "SalesOrderHeaders_", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.ShipToAddressId } );
			_address_ = null;
		}

		/// <summary> setups the sync logic for member _address_</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncAddress_(IEntityCore relatedEntity)
		{
			if(_address_!=relatedEntity)
			{
				DesetupSyncAddress_(true, true);
				_address_ = (AddressEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _address_, new PropertyChangedEventHandler( OnAddress_PropertyChanged ), "Address_", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.AddressEntityUsingShipToAddressIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnAddress_PropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _creditCard</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCreditCard(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _creditCard, new PropertyChangedEventHandler( OnCreditCardPropertyChanged ), "CreditCard", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.CreditCardEntityUsingCreditCardIdStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CreditCardId } );
			_creditCard = null;
		}

		/// <summary> setups the sync logic for member _creditCard</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCreditCard(IEntityCore relatedEntity)
		{
			if(_creditCard!=relatedEntity)
			{
				DesetupSyncCreditCard(true, true);
				_creditCard = (CreditCardEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _creditCard, new PropertyChangedEventHandler( OnCreditCardPropertyChanged ), "CreditCard", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.CreditCardEntityUsingCreditCardIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCreditCardPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _currencyRate</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCurrencyRate(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _currencyRate, new PropertyChangedEventHandler( OnCurrencyRatePropertyChanged ), "CurrencyRate", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.CurrencyRateEntityUsingCurrencyRateIdStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CurrencyRateId } );
			_currencyRate = null;
		}

		/// <summary> setups the sync logic for member _currencyRate</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCurrencyRate(IEntityCore relatedEntity)
		{
			if(_currencyRate!=relatedEntity)
			{
				DesetupSyncCurrencyRate(true, true);
				_currencyRate = (CurrencyRateEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _currencyRate, new PropertyChangedEventHandler( OnCurrencyRatePropertyChanged ), "CurrencyRate", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.CurrencyRateEntityUsingCurrencyRateIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCurrencyRatePropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _customer</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncCustomer(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.CustomerEntityUsingCustomerIdStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.CustomerId } );
			_customer = null;
		}

		/// <summary> setups the sync logic for member _customer</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCustomer(IEntityCore relatedEntity)
		{
			if(_customer!=relatedEntity)
			{
				DesetupSyncCustomer(true, true);
				_customer = (CustomerEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _customer, new PropertyChangedEventHandler( OnCustomerPropertyChanged ), "Customer", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.CustomerEntityUsingCustomerIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnCustomerPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _salesPerson</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSalesPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.SalesPersonEntityUsingSalesPersonIdStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.SalesPersonId } );
			_salesPerson = null;
		}

		/// <summary> setups the sync logic for member _salesPerson</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSalesPerson(IEntityCore relatedEntity)
		{
			if(_salesPerson!=relatedEntity)
			{
				DesetupSyncSalesPerson(true, true);
				_salesPerson = (SalesPersonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.SalesPersonEntityUsingSalesPersonIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSalesPersonPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.SalesTerritoryEntityUsingTerritoryIdStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.TerritoryId } );
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
				this.PerformSetupSyncRelatedEntity( _salesTerritory, new PropertyChangedEventHandler( OnSalesTerritoryPropertyChanged ), "SalesTerritory", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.SalesTerritoryEntityUsingTerritoryIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _shipMethod</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncShipMethod(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.ShipMethodEntityUsingShipMethodIdStatic, true, signalRelatedEntity, "SalesOrderHeaders", resetFKFields, new int[] { (int)SalesOrderHeaderFieldIndex.ShipMethodId } );
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
				this.PerformSetupSyncRelatedEntity( _shipMethod, new PropertyChangedEventHandler( OnShipMethodPropertyChanged ), "ShipMethod", AdventureWorks.Dal.Adapter.v51.RelationClasses.StaticSalesOrderHeaderRelations.ShipMethodEntityUsingShipMethodIdStatic, true, new string[] {  } );
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

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this SalesOrderHeaderEntity</param>
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
		public  static SalesOrderHeaderRelations Relations
		{
			get	{ return new SalesOrderHeaderRelations(); }
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
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderDetailEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderDetailEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderDetails")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderDetailEntity, 0, null, null, null, null, "SalesOrderDetails", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesOrderHeaderSalesReason' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesOrderHeaderSalesReasons
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<SalesOrderHeaderSalesReasonEntity>(EntityFactoryCache2.GetEntityFactory(typeof(SalesOrderHeaderSalesReasonEntityFactory))), (IEntityRelation)GetRelationsForField("SalesOrderHeaderSalesReasons")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderSalesReasonEntity, 0, null, null, null, null, "SalesOrderHeaderSalesReasons", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddress
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))),	(IEntityRelation)GetRelationsForField("Address")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.AddressEntity, 0, null, null, null, null, "Address", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Address' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAddress_
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(AddressEntityFactory))),	(IEntityRelation)GetRelationsForField("Address_")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.AddressEntity, 0, null, null, null, null, "Address_", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreditCard
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CreditCardEntityFactory))),	(IEntityRelation)GetRelationsForField("CreditCard")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.CreditCardEntity, 0, null, null, null, null, "CreditCard", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CurrencyRate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCurrencyRate
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CurrencyRateEntityFactory))),	(IEntityRelation)GetRelationsForField("CurrencyRate")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.CurrencyRateEntity, 0, null, null, null, null, "CurrencyRate", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomer
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))),	(IEntityRelation)GetRelationsForField("Customer")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.CustomerEntity, 0, null, null, null, null, "Customer", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPerson
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))),	(IEntityRelation)GetRelationsForField("SalesPerson")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesPersonEntity, 0, null, null, null, null, "SalesPerson", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesTerritory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesTerritory
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SalesTerritoryEntityFactory))),	(IEntityRelation)GetRelationsForField("SalesTerritory")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesTerritoryEntity, 0, null, null, null, null, "SalesTerritory", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ShipMethod' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathShipMethod
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(ShipMethodEntityFactory))),	(IEntityRelation)GetRelationsForField("ShipMethod")[0], (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity, (int)AdventureWorks.Dal.Adapter.v51.EntityType.ShipMethodEntity, 0, null, null, null, null, "ShipMethod", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The AccountNumber property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."AccountNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AccountNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.AccountNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.AccountNumber, value); }
		}

		/// <summary> The BillToAddressId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."BillToAddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 BillToAddressId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.BillToAddressId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.BillToAddressId, value); }
		}

		/// <summary> The Comment property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Comment"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 128<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Comment
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.Comment, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Comment, value); }
		}

		/// <summary> The CreditCardApprovalCode property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CreditCardApprovalCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String CreditCardApprovalCode
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, value); }
		}

		/// <summary> The CreditCardId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CreditCardID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CreditCardId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.CreditCardId, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CreditCardId, value); }
		}

		/// <summary> The CurrencyRateId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CurrencyRateID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> CurrencyRateId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.CurrencyRateId, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CurrencyRateId, value); }
		}

		/// <summary> The CustomerId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."CustomerID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 CustomerId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.CustomerId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.CustomerId, value); }
		}

		/// <summary> The DueDate property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."DueDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime DueDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.DueDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.DueDate, value); }
		}

		/// <summary> The Freight property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Freight"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal Freight
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.Freight, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Freight, value); }
		}

		/// <summary> The ModifiedDate property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The OnlineOrderFlag property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."OnlineOrderFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean OnlineOrderFlag
		{
			get { return (System.Boolean)GetValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, value); }
		}

		/// <summary> The OrderDate property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."OrderDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime OrderDate
		{
			get { return (System.DateTime)GetValue((int)SalesOrderHeaderFieldIndex.OrderDate, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.OrderDate, value); }
		}

		/// <summary> The PurchaseOrderNumber property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."PurchaseOrderNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String PurchaseOrderNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, value); }
		}

		/// <summary> The RevisionNumber property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."RevisionNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte RevisionNumber
		{
			get { return (System.Byte)GetValue((int)SalesOrderHeaderFieldIndex.RevisionNumber, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.RevisionNumber, value); }
		}

		/// <summary> The Rowguid property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)SalesOrderHeaderFieldIndex.Rowguid, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Rowguid, value); }
		}

		/// <summary> The SalesOrderId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesOrderID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 SalesOrderId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.SalesOrderId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SalesOrderId, value); }
		}

		/// <summary> The SalesOrderNumber property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesOrderNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 25<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String SalesOrderNumber
		{
			get { return (System.String)GetValue((int)SalesOrderHeaderFieldIndex.SalesOrderNumber, true); }

		}

		/// <summary> The SalesPersonId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SalesPersonID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> SalesPersonId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.SalesPersonId, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SalesPersonId, value); }
		}

		/// <summary> The ShipDate property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> ShipDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)SalesOrderHeaderFieldIndex.ShipDate, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipDate, value); }
		}

		/// <summary> The ShipMethodId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipMethodID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipMethodId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.ShipMethodId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipMethodId, value); }
		}

		/// <summary> The ShipToAddressId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."ShipToAddressID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 ShipToAddressId
		{
			get { return (System.Int32)GetValue((int)SalesOrderHeaderFieldIndex.ShipToAddressId, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.ShipToAddressId, value); }
		}

		/// <summary> The Status property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."Status"<br/>
		/// Table field type characteristics (type, precision, scale, length): TinyInt, 3, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Byte Status
		{
			get { return (System.Byte)GetValue((int)SalesOrderHeaderFieldIndex.Status, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.Status, value); }
		}

		/// <summary> The SubTotal property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."SubTotal"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal SubTotal
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.SubTotal, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.SubTotal, value); }
		}

		/// <summary> The TaxAmt property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TaxAmt"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TaxAmt
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.TaxAmt, true); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.TaxAmt, value); }
		}

		/// <summary> The TerritoryId property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TerritoryID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TerritoryId
		{
			get { return (Nullable<System.Int32>)GetValue((int)SalesOrderHeaderFieldIndex.TerritoryId, false); }
			set	{ SetValue((int)SalesOrderHeaderFieldIndex.TerritoryId, value); }
		}

		/// <summary> The TotalDue property of the Entity SalesOrderHeader<br/><br/></summary>
		/// <remarks>Mapped on  table field: "SalesOrderHeader"."TotalDue"<br/>
		/// Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal TotalDue
		{
			get { return (System.Decimal)GetValue((int)SalesOrderHeaderFieldIndex.TotalDue, true); }

		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderDetailEntity))]
		public virtual EntityCollection<SalesOrderDetailEntity> SalesOrderDetails
		{
			get { return GetOrCreateEntityCollection<SalesOrderDetailEntity, SalesOrderDetailEntityFactory>("SalesOrderHeader", true, false, ref _salesOrderDetails);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'SalesOrderHeaderSalesReasonEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(SalesOrderHeaderSalesReasonEntity))]
		public virtual EntityCollection<SalesOrderHeaderSalesReasonEntity> SalesOrderHeaderSalesReasons
		{
			get { return GetOrCreateEntityCollection<SalesOrderHeaderSalesReasonEntity, SalesOrderHeaderSalesReasonEntityFactory>("SalesOrderHeader", true, false, ref _salesOrderHeaderSalesReasons);	}
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
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "Address", _address, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'AddressEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual AddressEntity Address_
		{
			get	{ return _address_; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncAddress_(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders_", "Address_", _address_, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CreditCardEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CreditCardEntity CreditCard
		{
			get	{ return _creditCard; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCreditCard(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "CreditCard", _creditCard, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CurrencyRateEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CurrencyRateEntity CurrencyRate
		{
			get	{ return _currencyRate; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCurrencyRate(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "CurrencyRate", _currencyRate, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'CustomerEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CustomerEntity Customer
		{
			get	{ return _customer; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncCustomer(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "Customer", _customer, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SalesPersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get	{ return _salesPerson; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSalesPerson(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "SalesPerson", _salesPerson, true); 
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
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "SalesTerritory", _salesTerritory, true); 
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
					SetSingleRelatedEntityNavigator(value, "SalesOrderHeaders", "ShipMethod", _shipMethod, true); 
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
			get { return (int)AdventureWorks.Dal.Adapter.v51.EntityType.SalesOrderHeaderEntity; }
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
