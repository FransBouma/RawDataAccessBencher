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
	
	/// <summary>Entity class which represents the entity 'Person'.<br/><br/></summary>
	[Serializable]
	public partial class PersonEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private EntityCollection<BusinessEntityContactEntity> _businessEntityContacts;
		private EntityCollection<ContactCreditCardEntity> _contactCreditCards;
		private EntityCollection<CustomerEntity> _customers;
		private EntityCollection<EmailAddressEntity> _emailAddresses;
		private EntityCollection<PersonPhoneEntity> _personPhones;
		private BusinessEntityEntity _businessEntity;
		private EmployeeEntity _employee;
		private PasswordEntity _password;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BusinessEntityContacts</summary>
			public static readonly string BusinessEntityContacts = "BusinessEntityContacts";
			/// <summary>Member name ContactCreditCards</summary>
			public static readonly string ContactCreditCards = "ContactCreditCards";
			/// <summary>Member name Customers</summary>
			public static readonly string Customers = "Customers";
			/// <summary>Member name EmailAddresses</summary>
			public static readonly string EmailAddresses = "EmailAddresses";
			/// <summary>Member name PersonPhones</summary>
			public static readonly string PersonPhones = "PersonPhones";
			/// <summary>Member name BusinessEntity</summary>
			public static readonly string BusinessEntity = "BusinessEntity";
			/// <summary>Member name Employee</summary>
			public static readonly string Employee = "Employee";
			/// <summary>Member name Password</summary>
			public static readonly string Password = "Password";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static PersonEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public PersonEntity():base("PersonEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PersonEntity(IEntityFields2 fields):base("PersonEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PersonEntity</param>
		public PersonEntity(IValidator validator):base("PersonEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for Person which data should be fetched into this Person object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PersonEntity(System.Int32 businessEntityId):base("PersonEntity")
		{
			InitClassEmpty(null, null);
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for Person which data should be fetched into this Person object</param>
		/// <param name="validator">The custom validator object for this PersonEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public PersonEntity(System.Int32 businessEntityId, IValidator validator):base("PersonEntity")
		{
			InitClassEmpty(validator, null);
			this.BusinessEntityId = businessEntityId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected PersonEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_businessEntityContacts = (EntityCollection<BusinessEntityContactEntity>)info.GetValue("_businessEntityContacts", typeof(EntityCollection<BusinessEntityContactEntity>));
				_contactCreditCards = (EntityCollection<ContactCreditCardEntity>)info.GetValue("_contactCreditCards", typeof(EntityCollection<ContactCreditCardEntity>));
				_customers = (EntityCollection<CustomerEntity>)info.GetValue("_customers", typeof(EntityCollection<CustomerEntity>));
				_emailAddresses = (EntityCollection<EmailAddressEntity>)info.GetValue("_emailAddresses", typeof(EntityCollection<EmailAddressEntity>));
				_personPhones = (EntityCollection<PersonPhoneEntity>)info.GetValue("_personPhones", typeof(EntityCollection<PersonPhoneEntity>));
				_businessEntity = (BusinessEntityEntity)info.GetValue("_businessEntity", typeof(BusinessEntityEntity));
				if(_businessEntity!=null)
				{
					_businessEntity.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_employee = (EmployeeEntity)info.GetValue("_employee", typeof(EmployeeEntity));
				if(_employee!=null)
				{
					_employee.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_password = (PasswordEntity)info.GetValue("_password", typeof(PasswordEntity));
				if(_password!=null)
				{
					_password.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((PersonFieldIndex)fieldIndex)
			{
				case PersonFieldIndex.BusinessEntityId:
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
				case "BusinessEntityContacts":
					this.BusinessEntityContacts.Add((BusinessEntityContactEntity)entity);
					break;
				case "ContactCreditCards":
					this.ContactCreditCards.Add((ContactCreditCardEntity)entity);
					break;
				case "Customers":
					this.Customers.Add((CustomerEntity)entity);
					break;
				case "EmailAddresses":
					this.EmailAddresses.Add((EmailAddressEntity)entity);
					break;
				case "PersonPhones":
					this.PersonPhones.Add((PersonPhoneEntity)entity);
					break;
				case "BusinessEntity":
					this.BusinessEntity = (BusinessEntityEntity)entity;
					break;
				case "Employee":
					this.Employee = (EmployeeEntity)entity;
					break;
				case "Password":
					this.Password = (PasswordEntity)entity;
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
				case "BusinessEntityContacts":
					toReturn.Add(Relations.BusinessEntityContactEntityUsingPersonId);
					break;
				case "ContactCreditCards":
					toReturn.Add(Relations.ContactCreditCardEntityUsingContactId);
					break;
				case "Customers":
					toReturn.Add(Relations.CustomerEntityUsingPersonId);
					break;
				case "EmailAddresses":
					toReturn.Add(Relations.EmailAddressEntityUsingBusinessEntityId);
					break;
				case "PersonPhones":
					toReturn.Add(Relations.PersonPhoneEntityUsingBusinessEntityId);
					break;
				case "BusinessEntity":
					toReturn.Add(Relations.BusinessEntityEntityUsingBusinessEntityId);
					break;
				case "Employee":
					toReturn.Add(Relations.EmployeeEntityUsingEmployeeId);
					break;
				case "Password":
					toReturn.Add(Relations.PasswordEntityUsingBusinessEntityId);
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
				case "BusinessEntityContacts":
					this.BusinessEntityContacts.Add((BusinessEntityContactEntity)relatedEntity);
					break;
				case "ContactCreditCards":
					this.ContactCreditCards.Add((ContactCreditCardEntity)relatedEntity);
					break;
				case "Customers":
					this.Customers.Add((CustomerEntity)relatedEntity);
					break;
				case "EmailAddresses":
					this.EmailAddresses.Add((EmailAddressEntity)relatedEntity);
					break;
				case "PersonPhones":
					this.PersonPhones.Add((PersonPhoneEntity)relatedEntity);
					break;
				case "BusinessEntity":
					SetupSyncBusinessEntity(relatedEntity);
					break;
				case "Employee":
					SetupSyncEmployee(relatedEntity);
					break;
				case "Password":
					SetupSyncPassword(relatedEntity);
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
				case "BusinessEntityContacts":
					this.PerformRelatedEntityRemoval(this.BusinessEntityContacts, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "ContactCreditCards":
					this.PerformRelatedEntityRemoval(this.ContactCreditCards, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Customers":
					this.PerformRelatedEntityRemoval(this.Customers, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmailAddresses":
					this.PerformRelatedEntityRemoval(this.EmailAddresses, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PersonPhones":
					this.PerformRelatedEntityRemoval(this.PersonPhones, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "BusinessEntity":
					DesetupSyncBusinessEntity(false, true);
					break;
				case "Employee":
					DesetupSyncEmployee(false, true);
					break;
				case "Password":
					DesetupSyncPassword(false, true);
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


			if(_employee!=null)
			{
				toReturn.Add(_employee);
			}

			if(_password!=null)
			{
				toReturn.Add(_password);
			}

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
			toReturn.Add(this.BusinessEntityContacts);
			toReturn.Add(this.ContactCreditCards);
			toReturn.Add(this.Customers);
			toReturn.Add(this.EmailAddresses);
			toReturn.Add(this.PersonPhones);
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
				info.AddValue("_businessEntityContacts", ((_businessEntityContacts!=null) && (_businessEntityContacts.Count>0) && !this.MarkedForDeletion)?_businessEntityContacts:null);
				info.AddValue("_contactCreditCards", ((_contactCreditCards!=null) && (_contactCreditCards.Count>0) && !this.MarkedForDeletion)?_contactCreditCards:null);
				info.AddValue("_customers", ((_customers!=null) && (_customers.Count>0) && !this.MarkedForDeletion)?_customers:null);
				info.AddValue("_emailAddresses", ((_emailAddresses!=null) && (_emailAddresses.Count>0) && !this.MarkedForDeletion)?_emailAddresses:null);
				info.AddValue("_personPhones", ((_personPhones!=null) && (_personPhones.Count>0) && !this.MarkedForDeletion)?_personPhones:null);
				info.AddValue("_businessEntity", (!this.MarkedForDeletion?_businessEntity:null));
				info.AddValue("_employee", (!this.MarkedForDeletion?_employee:null));
				info.AddValue("_password", (!this.MarkedForDeletion?_password:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new PersonRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityContact' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityContacts()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(BusinessEntityContactFields.PersonId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'ContactCreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoContactCreditCards()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(ContactCreditCardFields.ContactId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Customer' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCustomers()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(CustomerFields.PersonId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'EmailAddress' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmailAddresses()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmailAddressFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PersonPhone' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPersonPhones()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PersonPhoneFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
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

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Employee' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployee()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeFields.EmployeeId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Password' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPassword()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PasswordFields.BusinessEntityId, null, ComparisonOperator.Equal, this.BusinessEntityId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._businessEntityContacts);
			collectionsQueue.Enqueue(this._contactCreditCards);
			collectionsQueue.Enqueue(this._customers);
			collectionsQueue.Enqueue(this._emailAddresses);
			collectionsQueue.Enqueue(this._personPhones);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._businessEntityContacts = (EntityCollection<BusinessEntityContactEntity>) collectionsQueue.Dequeue();
			this._contactCreditCards = (EntityCollection<ContactCreditCardEntity>) collectionsQueue.Dequeue();
			this._customers = (EntityCollection<CustomerEntity>) collectionsQueue.Dequeue();
			this._emailAddresses = (EntityCollection<EmailAddressEntity>) collectionsQueue.Dequeue();
			this._personPhones = (EntityCollection<PersonPhoneEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._businessEntityContacts != null);
			toReturn |=(this._contactCreditCards != null);
			toReturn |=(this._customers != null);
			toReturn |=(this._emailAddresses != null);
			toReturn |=(this._personPhones != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<BusinessEntityContactEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityContactEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<ContactCreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ContactCreditCardEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmailAddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmailAddressEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PersonPhoneEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PersonPhoneEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("BusinessEntityContacts", _businessEntityContacts);
			toReturn.Add("ContactCreditCards", _contactCreditCards);
			toReturn.Add("Customers", _customers);
			toReturn.Add("EmailAddresses", _emailAddresses);
			toReturn.Add("PersonPhones", _personPhones);
			toReturn.Add("BusinessEntity", _businessEntity);
			toReturn.Add("Employee", _employee);
			toReturn.Add("Password", _password);
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
			_fieldsCustomProperties.Add("AdditionalContactInfo", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("BusinessEntityId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Demographics", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmailPromotion", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FirstName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LastName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MiddleName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NameStyle", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PersonType", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Suffix", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _businessEntity</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncBusinessEntity(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _businessEntity, new PropertyChangedEventHandler( OnBusinessEntityPropertyChanged ), "BusinessEntity", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticPersonRelations.BusinessEntityEntityUsingBusinessEntityIdStatic, true, signalRelatedEntity, "Person", false, new int[] { (int)PersonFieldIndex.BusinessEntityId } );
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
				this.PerformSetupSyncRelatedEntity( _businessEntity, new PropertyChangedEventHandler( OnBusinessEntityPropertyChanged ), "BusinessEntity", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticPersonRelations.BusinessEntityEntityUsingBusinessEntityIdStatic, true, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _employee</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncEmployee(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticPersonRelations.EmployeeEntityUsingEmployeeIdStatic, false, signalRelatedEntity, "Person", false, new int[] { (int)PersonFieldIndex.BusinessEntityId } );
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
				this.PerformSetupSyncRelatedEntity( _employee, new PropertyChangedEventHandler( OnEmployeePropertyChanged ), "Employee", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticPersonRelations.EmployeeEntityUsingEmployeeIdStatic, false, new string[] {  } );
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

		/// <summary> Removes the sync logic for member _password</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPassword(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _password, new PropertyChangedEventHandler( OnPasswordPropertyChanged ), "Password", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticPersonRelations.PasswordEntityUsingBusinessEntityIdStatic, false, signalRelatedEntity, "Person", false, new int[] { (int)PersonFieldIndex.BusinessEntityId } );
			_password = null;
		}
		
		/// <summary> setups the sync logic for member _password</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPassword(IEntityCore relatedEntity)
		{
			if(_password!=relatedEntity)
			{
				DesetupSyncPassword(true, true);
				_password = (PasswordEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _password, new PropertyChangedEventHandler( OnPasswordPropertyChanged ), "Password", AdventureWorks.Dal.Adapter.v41.RelationClasses.StaticPersonRelations.PasswordEntityUsingBusinessEntityIdStatic, false, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPasswordPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this PersonEntity</param>
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
		public  static PersonRelations Relations
		{
			get	{ return new PersonRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityContact' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityContacts
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<BusinessEntityContactEntity>(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityContactEntityFactory))), (IEntityRelation)GetRelationsForField("BusinessEntityContacts")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityContactEntity, 0, null, null, null, null, "BusinessEntityContacts", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ContactCreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathContactCreditCards
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<ContactCreditCardEntity>(EntityFactoryCache2.GetEntityFactory(typeof(ContactCreditCardEntityFactory))), (IEntityRelation)GetRelationsForField("ContactCreditCards")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.ContactCreditCardEntity, 0, null, null, null, null, "ContactCreditCards", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Customer' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCustomers
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<CustomerEntity>(EntityFactoryCache2.GetEntityFactory(typeof(CustomerEntityFactory))), (IEntityRelation)GetRelationsForField("Customers")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.CustomerEntity, 0, null, null, null, null, "Customers", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'EmailAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmailAddresses
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<EmailAddressEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmailAddressEntityFactory))), (IEntityRelation)GetRelationsForField("EmailAddresses")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.EmailAddressEntity, 0, null, null, null, null, "EmailAddresses", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PersonPhone' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPersonPhones
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PersonPhoneEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PersonPhoneEntityFactory))), (IEntityRelation)GetRelationsForField("PersonPhones")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonPhoneEntity, 0, null, null, null, null, "PersonPhones", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntity
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(BusinessEntityEntityFactory))), (IEntityRelation)GetRelationsForField("BusinessEntity")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityEntity, 0, null, null, null, null, "BusinessEntity", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Employee' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployee
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory))), (IEntityRelation)GetRelationsForField("Employee")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.EmployeeEntity, 0, null, null, null, null, "Employee", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Password' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPassword
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PasswordEntityFactory))), (IEntityRelation)GetRelationsForField("Password")[0], (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, (int)AdventureWorks.Dal.Adapter.v41.EntityType.PasswordEntity, 0, null, null, null, null, "Password", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The AdditionalContactInfo property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."AdditionalContactInfo"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String AdditionalContactInfo
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.AdditionalContactInfo, true); }
			set	{ SetValue((int)PersonFieldIndex.AdditionalContactInfo, value); }
		}

		/// <summary> The BusinessEntityId property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."BusinessEntityID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)PersonFieldIndex.BusinessEntityId, true); }
			set	{ SetValue((int)PersonFieldIndex.BusinessEntityId, value); }
		}

		/// <summary> The Demographics property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Demographics"<br/>
		/// Table field type characteristics (type, precision, scale, length): Xml, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Demographics
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.Demographics, true); }
			set	{ SetValue((int)PersonFieldIndex.Demographics, value); }
		}

		/// <summary> The EmailPromotion property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."EmailPromotion"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 EmailPromotion
		{
			get { return (System.Int32)GetValue((int)PersonFieldIndex.EmailPromotion, true); }
			set	{ SetValue((int)PersonFieldIndex.EmailPromotion, value); }
		}

		/// <summary> The FirstName property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."FirstName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String FirstName
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.FirstName, true); }
			set	{ SetValue((int)PersonFieldIndex.FirstName, value); }
		}

		/// <summary> The LastName property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."LastName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LastName
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.LastName, true); }
			set	{ SetValue((int)PersonFieldIndex.LastName, value); }
		}

		/// <summary> The MiddleName property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."MiddleName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleName
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.MiddleName, true); }
			set	{ SetValue((int)PersonFieldIndex.MiddleName, value); }
		}

		/// <summary> The ModifiedDate property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)PersonFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)PersonFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The NameStyle property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."NameStyle"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean NameStyle
		{
			get { return (System.Boolean)GetValue((int)PersonFieldIndex.NameStyle, true); }
			set	{ SetValue((int)PersonFieldIndex.NameStyle, value); }
		}

		/// <summary> The PersonType property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."PersonType"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 2<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String PersonType
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.PersonType, true); }
			set	{ SetValue((int)PersonFieldIndex.PersonType, value); }
		}

		/// <summary> The Rowguid property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)PersonFieldIndex.Rowguid, true); }
			set	{ SetValue((int)PersonFieldIndex.Rowguid, value); }
		}

		/// <summary> The Suffix property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Suffix"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 10<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Suffix
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.Suffix, true); }
			set	{ SetValue((int)PersonFieldIndex.Suffix, value); }
		}

		/// <summary> The Title property of the Entity Person<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Person"."Title"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 8<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)PersonFieldIndex.Title, true); }
			set	{ SetValue((int)PersonFieldIndex.Title, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'BusinessEntityContactEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityContactEntity))]
		public virtual EntityCollection<BusinessEntityContactEntity> BusinessEntityContacts
		{
			get { return GetOrCreateEntityCollection<BusinessEntityContactEntity, BusinessEntityContactEntityFactory>("Person", true, false, ref _businessEntityContacts);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'ContactCreditCardEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(ContactCreditCardEntity))]
		public virtual EntityCollection<ContactCreditCardEntity> ContactCreditCards
		{
			get { return GetOrCreateEntityCollection<ContactCreditCardEntity, ContactCreditCardEntityFactory>("Person", true, false, ref _contactCreditCards);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'CustomerEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(CustomerEntity))]
		public virtual EntityCollection<CustomerEntity> Customers
		{
			get { return GetOrCreateEntityCollection<CustomerEntity, CustomerEntityFactory>("Person", true, false, ref _customers);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmailAddressEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmailAddressEntity))]
		public virtual EntityCollection<EmailAddressEntity> EmailAddresses
		{
			get { return GetOrCreateEntityCollection<EmailAddressEntity, EmailAddressEntityFactory>("Person", true, false, ref _emailAddresses);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PersonPhoneEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PersonPhoneEntity))]
		public virtual EntityCollection<PersonPhoneEntity> PersonPhones
		{
			get { return GetOrCreateEntityCollection<PersonPhoneEntity, PersonPhoneEntityFactory>("Person", true, false, ref _personPhones);	}
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
					CallSetRelatedEntityDuringDeserialization(value, "Person");
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
							((IEntity2)value).SetRelatedEntity(this, "Person");
							SetupSyncBusinessEntity(value);
						}
					}
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
					CallSetRelatedEntityDuringDeserialization(value, "Person");
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
							((IEntity2)value).SetRelatedEntity(this, "Person");
							SetupSyncEmployee(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'PasswordEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual PasswordEntity Password
		{
			get { return _password; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPassword(value);
					CallSetRelatedEntityDuringDeserialization(value, "Person");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_password !=null);
						DesetupSyncPassword(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("Password");
						}
					}
					else
					{
						if(_password!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "Person");
							SetupSyncPassword(value);
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
			get { return (int)AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity; }
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
