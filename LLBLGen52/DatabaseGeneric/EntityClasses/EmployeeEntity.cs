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
	/// <summary>Entity class which represents the entity 'Employee'.<br/><br/></summary>
	[Serializable]
	public partial class EmployeeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<DocumentEntity> _documents;
		private EntityCollection<EmployeeDepartmentHistoryEntity> _employeeDepartmentHistories;
		private EntityCollection<EmployeePayHistoryEntity> _employeePayHistories;
		private EntityCollection<JobCandidateEntity> _jobCandidates;
		private EntityCollection<PurchaseOrderHeaderEntity> _purchaseOrderHeaders;
		private PersonEntity _person;
		private SalesPersonEntity _salesPerson;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Documents</summary>
			public static readonly string Documents = "Documents";
			/// <summary>Member name EmployeeDepartmentHistories</summary>
			public static readonly string EmployeeDepartmentHistories = "EmployeeDepartmentHistories";
			/// <summary>Member name EmployeePayHistories</summary>
			public static readonly string EmployeePayHistories = "EmployeePayHistories";
			/// <summary>Member name JobCandidates</summary>
			public static readonly string JobCandidates = "JobCandidates";
			/// <summary>Member name PurchaseOrderHeaders</summary>
			public static readonly string PurchaseOrderHeaders = "PurchaseOrderHeaders";
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
			/// <summary>Member name SalesPerson</summary>
			public static readonly string SalesPerson = "SalesPerson";
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static EmployeeEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public EmployeeEntity():base("EmployeeEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public EmployeeEntity(IEntityFields2 fields):base("EmployeeEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		public EmployeeEntity(IValidator validator):base("EmployeeEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public EmployeeEntity(System.Int32 employeeId):base("EmployeeEntity")
		{
			InitClassEmpty(null, null);
			this.EmployeeId = employeeId;
		}

		/// <summary> CTor</summary>
		/// <param name="employeeId">PK value for Employee which data should be fetched into this Employee object</param>
		/// <param name="validator">The custom validator object for this EmployeeEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public EmployeeEntity(System.Int32 employeeId, IValidator validator):base("EmployeeEntity")
		{
			InitClassEmpty(validator, null);
			this.EmployeeId = employeeId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected EmployeeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_documents = (EntityCollection<DocumentEntity>)info.GetValue("_documents", typeof(EntityCollection<DocumentEntity>));
				_employeeDepartmentHistories = (EntityCollection<EmployeeDepartmentHistoryEntity>)info.GetValue("_employeeDepartmentHistories", typeof(EntityCollection<EmployeeDepartmentHistoryEntity>));
				_employeePayHistories = (EntityCollection<EmployeePayHistoryEntity>)info.GetValue("_employeePayHistories", typeof(EntityCollection<EmployeePayHistoryEntity>));
				_jobCandidates = (EntityCollection<JobCandidateEntity>)info.GetValue("_jobCandidates", typeof(EntityCollection<JobCandidateEntity>));
				_purchaseOrderHeaders = (EntityCollection<PurchaseOrderHeaderEntity>)info.GetValue("_purchaseOrderHeaders", typeof(EntityCollection<PurchaseOrderHeaderEntity>));
				_person = (PersonEntity)info.GetValue("_person", typeof(PersonEntity));
				if(_person!=null)
				{
					_person.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_salesPerson = (SalesPersonEntity)info.GetValue("_salesPerson", typeof(SalesPersonEntity));
				if(_salesPerson!=null)
				{
					_salesPerson.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((EmployeeFieldIndex)fieldIndex)
			{
				case EmployeeFieldIndex.EmployeeId:
					DesetupSyncPerson(true, false);
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
				case "Documents":
					this.Documents.Add((DocumentEntity)entity);
					break;
				case "EmployeeDepartmentHistories":
					this.EmployeeDepartmentHistories.Add((EmployeeDepartmentHistoryEntity)entity);
					break;
				case "EmployeePayHistories":
					this.EmployeePayHistories.Add((EmployeePayHistoryEntity)entity);
					break;
				case "JobCandidates":
					this.JobCandidates.Add((JobCandidateEntity)entity);
					break;
				case "PurchaseOrderHeaders":
					this.PurchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)entity);
					break;
				case "Person":
					this.Person = (PersonEntity)entity;
					break;
				case "SalesPerson":
					this.SalesPerson = (SalesPersonEntity)entity;
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
				case "Documents":
					toReturn.Add(Relations.DocumentEntityUsingOwner);
					break;
				case "EmployeeDepartmentHistories":
					toReturn.Add(Relations.EmployeeDepartmentHistoryEntityUsingEmployeeId);
					break;
				case "EmployeePayHistories":
					toReturn.Add(Relations.EmployeePayHistoryEntityUsingEmployeeId);
					break;
				case "JobCandidates":
					toReturn.Add(Relations.JobCandidateEntityUsingEmployeeId);
					break;
				case "PurchaseOrderHeaders":
					toReturn.Add(Relations.PurchaseOrderHeaderEntityUsingEmployeeId);
					break;
				case "Person":
					toReturn.Add(Relations.PersonEntityUsingEmployeeId);
					break;
				case "SalesPerson":
					toReturn.Add(Relations.SalesPersonEntityUsingSalesPersonId);
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
				case "Documents":
					this.Documents.Add((DocumentEntity)relatedEntity);
					break;
				case "EmployeeDepartmentHistories":
					this.EmployeeDepartmentHistories.Add((EmployeeDepartmentHistoryEntity)relatedEntity);
					break;
				case "EmployeePayHistories":
					this.EmployeePayHistories.Add((EmployeePayHistoryEntity)relatedEntity);
					break;
				case "JobCandidates":
					this.JobCandidates.Add((JobCandidateEntity)relatedEntity);
					break;
				case "PurchaseOrderHeaders":
					this.PurchaseOrderHeaders.Add((PurchaseOrderHeaderEntity)relatedEntity);
					break;
				case "Person":
					SetupSyncPerson(relatedEntity);
					break;
				case "SalesPerson":
					SetupSyncSalesPerson(relatedEntity);
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
				case "Documents":
					this.PerformRelatedEntityRemoval(this.Documents, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeeDepartmentHistories":
					this.PerformRelatedEntityRemoval(this.EmployeeDepartmentHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "EmployeePayHistories":
					this.PerformRelatedEntityRemoval(this.EmployeePayHistories, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "JobCandidates":
					this.PerformRelatedEntityRemoval(this.JobCandidates, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "PurchaseOrderHeaders":
					this.PerformRelatedEntityRemoval(this.PurchaseOrderHeaders, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "Person":
					DesetupSyncPerson(false, true);
					break;
				case "SalesPerson":
					DesetupSyncSalesPerson(false, true);
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


			if(_salesPerson!=null)
			{
				toReturn.Add(_salesPerson);
			}

			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			if(_person!=null)
			{
				toReturn.Add(_person);
			}



			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.Documents);
			toReturn.Add(this.EmployeeDepartmentHistories);
			toReturn.Add(this.EmployeePayHistories);
			toReturn.Add(this.JobCandidates);
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
				info.AddValue("_documents", ((_documents!=null) && (_documents.Count>0) && !this.MarkedForDeletion)?_documents:null);
				info.AddValue("_employeeDepartmentHistories", ((_employeeDepartmentHistories!=null) && (_employeeDepartmentHistories.Count>0) && !this.MarkedForDeletion)?_employeeDepartmentHistories:null);
				info.AddValue("_employeePayHistories", ((_employeePayHistories!=null) && (_employeePayHistories.Count>0) && !this.MarkedForDeletion)?_employeePayHistories:null);
				info.AddValue("_jobCandidates", ((_jobCandidates!=null) && (_jobCandidates.Count>0) && !this.MarkedForDeletion)?_jobCandidates:null);
				info.AddValue("_purchaseOrderHeaders", ((_purchaseOrderHeaders!=null) && (_purchaseOrderHeaders.Count>0) && !this.MarkedForDeletion)?_purchaseOrderHeaders:null);
				info.AddValue("_person", (!this.MarkedForDeletion?_person:null));
				info.AddValue("_salesPerson", (!this.MarkedForDeletion?_salesPerson:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new EmployeeRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Document' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoDocuments()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(DocumentFields.Owner, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'EmployeeDepartmentHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeeDepartmentHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeeDepartmentHistoryFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'EmployeePayHistory' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoEmployeePayHistories()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(EmployeePayHistoryFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'JobCandidate' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoJobCandidates()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(JobCandidateFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PurchaseOrderHeader' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPurchaseOrderHeaders()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PurchaseOrderHeaderFields.EmployeeId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(PersonFields.BusinessEntityId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SalesPerson' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSalesPerson()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SalesPersonFields.SalesPersonId, null, ComparisonOperator.Equal, this.EmployeeId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(EmployeeEntityFactory));
		}

		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._documents);
			collectionsQueue.Enqueue(this._employeeDepartmentHistories);
			collectionsQueue.Enqueue(this._employeePayHistories);
			collectionsQueue.Enqueue(this._jobCandidates);
			collectionsQueue.Enqueue(this._purchaseOrderHeaders);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._documents = (EntityCollection<DocumentEntity>) collectionsQueue.Dequeue();
			this._employeeDepartmentHistories = (EntityCollection<EmployeeDepartmentHistoryEntity>) collectionsQueue.Dequeue();
			this._employeePayHistories = (EntityCollection<EmployeePayHistoryEntity>) collectionsQueue.Dequeue();
			this._jobCandidates = (EntityCollection<JobCandidateEntity>) collectionsQueue.Dequeue();
			this._purchaseOrderHeaders = (EntityCollection<PurchaseOrderHeaderEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._documents != null);
			toReturn |=(this._employeeDepartmentHistories != null);
			toReturn |=(this._employeePayHistories != null);
			toReturn |=(this._jobCandidates != null);
			toReturn |=(this._purchaseOrderHeaders != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<DocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeeDepartmentHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeDepartmentHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<EmployeePayHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeePayHistoryEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<JobCandidateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(JobCandidateEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<PurchaseOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory))) : null);
		}

		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("Documents", _documents);
			toReturn.Add("EmployeeDepartmentHistories", _employeeDepartmentHistories);
			toReturn.Add("EmployeePayHistories", _employeePayHistories);
			toReturn.Add("JobCandidates", _jobCandidates);
			toReturn.Add("PurchaseOrderHeaders", _purchaseOrderHeaders);
			toReturn.Add("Person", _person);
			toReturn.Add("SalesPerson", _salesPerson);
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
			_fieldsCustomProperties.Add("BirthDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("CurrentFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmployeeId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Gender", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HireDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("LoginId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MaritalStatus", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ModifiedDate", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NationalIdnumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrganizationLevel", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OrganizationNode", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Rowguid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SalariedFlag", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SickLeaveHours", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Title", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VacationHours", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _person</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncPerson(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticEmployeeRelations.PersonEntityUsingEmployeeIdStatic, true, signalRelatedEntity, "Employee", false, new int[] { (int)EmployeeFieldIndex.EmployeeId } );
			_person = null;
		}
		
		/// <summary> setups the sync logic for member _person</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncPerson(IEntityCore relatedEntity)
		{
			if(_person!=relatedEntity)
			{
				DesetupSyncPerson(true, true);
				_person = (PersonEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _person, new PropertyChangedEventHandler( OnPersonPropertyChanged ), "Person", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticEmployeeRelations.PersonEntityUsingEmployeeIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnPersonPropertyChanged( object sender, PropertyChangedEventArgs e )
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
			this.PerformDesetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticEmployeeRelations.SalesPersonEntityUsingSalesPersonIdStatic, false, signalRelatedEntity, "Employee", false, new int[] { (int)EmployeeFieldIndex.EmployeeId } );
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
				this.PerformSetupSyncRelatedEntity( _salesPerson, new PropertyChangedEventHandler( OnSalesPersonPropertyChanged ), "SalesPerson", AdventureWorks.Dal.Adapter.v52.RelationClasses.StaticEmployeeRelations.SalesPersonEntityUsingSalesPersonIdStatic, false, new string[] {  } );
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

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this EmployeeEntity</param>
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
		public  static EmployeeRelations Relations
		{
			get	{ return new EmployeeRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Document' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathDocuments
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<DocumentEntity>(EntityFactoryCache2.GetEntityFactory(typeof(DocumentEntityFactory))), (IEntityRelation)GetRelationsForField("Documents")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.DocumentEntity, 0, null, null, null, null, "Documents", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'EmployeeDepartmentHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeeDepartmentHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<EmployeeDepartmentHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeeDepartmentHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("EmployeeDepartmentHistories")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeDepartmentHistoryEntity, 0, null, null, null, null, "EmployeeDepartmentHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'EmployeePayHistory' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathEmployeePayHistories
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<EmployeePayHistoryEntity>(EntityFactoryCache2.GetEntityFactory(typeof(EmployeePayHistoryEntityFactory))), (IEntityRelation)GetRelationsForField("EmployeePayHistories")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeePayHistoryEntity, 0, null, null, null, null, "EmployeePayHistories", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'JobCandidate' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathJobCandidates
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<JobCandidateEntity>(EntityFactoryCache2.GetEntityFactory(typeof(JobCandidateEntityFactory))), (IEntityRelation)GetRelationsForField("JobCandidates")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.JobCandidateEntity, 0, null, null, null, null, "JobCandidates", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PurchaseOrderHeader' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPurchaseOrderHeaders
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<PurchaseOrderHeaderEntity>(EntityFactoryCache2.GetEntityFactory(typeof(PurchaseOrderHeaderEntityFactory))), (IEntityRelation)GetRelationsForField("PurchaseOrderHeaders")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.PurchaseOrderHeaderEntity, 0, null, null, null, null, "PurchaseOrderHeaders", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(PersonEntityFactory))), (IEntityRelation)GetRelationsForField("Person")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.PersonEntity, 0, null, null, null, null, "Person", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SalesPerson' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSalesPerson
		{
			get { return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SalesPersonEntityFactory))), (IEntityRelation)GetRelationsForField("SalesPerson")[0], (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity, (int)AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity, 0, null, null, null, null, "SalesPerson", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne);	}
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

		/// <summary> The BirthDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."BirthDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime BirthDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.BirthDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.BirthDate, value); }
		}

		/// <summary> The CurrentFlag property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."CurrentFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean CurrentFlag
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.CurrentFlag, true); }
			set	{ SetValue((int)EmployeeFieldIndex.CurrentFlag, value); }
		}

		/// <summary> The EmployeeId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."BusinessEntityID"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 EmployeeId
		{
			get { return (System.Int32)GetValue((int)EmployeeFieldIndex.EmployeeId, true); }
			set	{ SetValue((int)EmployeeFieldIndex.EmployeeId, value); }
		}

		/// <summary> The Gender property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."Gender"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Gender
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Gender, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Gender, value); }
		}

		/// <summary> The HireDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."HireDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): Date, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime HireDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.HireDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.HireDate, value); }
		}

		/// <summary> The LoginId property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."LoginID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 256<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String LoginId
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.LoginId, true); }
			set	{ SetValue((int)EmployeeFieldIndex.LoginId, value); }
		}

		/// <summary> The MaritalStatus property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."MaritalStatus"<br/>
		/// Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 1<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String MaritalStatus
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.MaritalStatus, true); }
			set	{ SetValue((int)EmployeeFieldIndex.MaritalStatus, value); }
		}

		/// <summary> The ModifiedDate property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."ModifiedDate"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)EmployeeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)EmployeeFieldIndex.ModifiedDate, value); }
		}

		/// <summary> The NationalIdnumber property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."NationalIDNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 15<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String NationalIdnumber
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.NationalIdnumber, true); }
			set	{ SetValue((int)EmployeeFieldIndex.NationalIdnumber, value); }
		}

		/// <summary> The OrganizationLevel property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."OrganizationLevel"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int16> OrganizationLevel
		{
			get { return (Nullable<System.Int16>)GetValue((int)EmployeeFieldIndex.OrganizationLevel, false); }

		}

		/// <summary> The OrganizationNode property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."OrganizationNode"<br/>
		/// Table field type characteristics (type, precision, scale, length): VarChar, 0, 0, 892<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String OrganizationNode
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.OrganizationNode, true); }
			set	{ SetValue((int)EmployeeFieldIndex.OrganizationNode, value); }
		}

		/// <summary> The Rowguid property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."rowguid"<br/>
		/// Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)EmployeeFieldIndex.Rowguid, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Rowguid, value); }
		}

		/// <summary> The SalariedFlag property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."SalariedFlag"<br/>
		/// Table field type characteristics (type, precision, scale, length): Bit, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Boolean SalariedFlag
		{
			get { return (System.Boolean)GetValue((int)EmployeeFieldIndex.SalariedFlag, true); }
			set	{ SetValue((int)EmployeeFieldIndex.SalariedFlag, value); }
		}

		/// <summary> The SickLeaveHours property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."SickLeaveHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 SickLeaveHours
		{
			get { return (System.Int16)GetValue((int)EmployeeFieldIndex.SickLeaveHours, true); }
			set	{ SetValue((int)EmployeeFieldIndex.SickLeaveHours, value); }
		}

		/// <summary> The Title property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."JobTitle"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)EmployeeFieldIndex.Title, true); }
			set	{ SetValue((int)EmployeeFieldIndex.Title, value); }
		}

		/// <summary> The VacationHours property of the Entity Employee<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Employee"."VacationHours"<br/>
		/// Table field type characteristics (type, precision, scale, length): SmallInt, 5, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int16 VacationHours
		{
			get { return (System.Int16)GetValue((int)EmployeeFieldIndex.VacationHours, true); }
			set	{ SetValue((int)EmployeeFieldIndex.VacationHours, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'DocumentEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(DocumentEntity))]
		public virtual EntityCollection<DocumentEntity> Documents
		{
			get { return GetOrCreateEntityCollection<DocumentEntity, DocumentEntityFactory>("Employee", true, false, ref _documents);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeeDepartmentHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeeDepartmentHistoryEntity))]
		public virtual EntityCollection<EmployeeDepartmentHistoryEntity> EmployeeDepartmentHistories
		{
			get { return GetOrCreateEntityCollection<EmployeeDepartmentHistoryEntity, EmployeeDepartmentHistoryEntityFactory>("Employee", true, false, ref _employeeDepartmentHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'EmployeePayHistoryEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(EmployeePayHistoryEntity))]
		public virtual EntityCollection<EmployeePayHistoryEntity> EmployeePayHistories
		{
			get { return GetOrCreateEntityCollection<EmployeePayHistoryEntity, EmployeePayHistoryEntityFactory>("Employee", true, false, ref _employeePayHistories);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'JobCandidateEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(JobCandidateEntity))]
		public virtual EntityCollection<JobCandidateEntity> JobCandidates
		{
			get { return GetOrCreateEntityCollection<JobCandidateEntity, JobCandidateEntityFactory>("Employee", true, false, ref _jobCandidates);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'PurchaseOrderHeaderEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PurchaseOrderHeaderEntity))]
		public virtual EntityCollection<PurchaseOrderHeaderEntity> PurchaseOrderHeaders
		{
			get { return GetOrCreateEntityCollection<PurchaseOrderHeaderEntity, PurchaseOrderHeaderEntityFactory>("Employee", true, false, ref _purchaseOrderHeaders);	}
		}

		/// <summary> Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get { return _person; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncPerson(value);
					CallSetRelatedEntityDuringDeserialization(value, "Employee");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_person !=null);
						DesetupSyncPerson(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("Person");
						}
					}
					else
					{
						if(_person!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "Employee");
							SetupSyncPerson(value);
						}
					}
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'SalesPersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned.<br/><br/>
		/// </summary>
		[Browsable(false)]
		public virtual SalesPersonEntity SalesPerson
		{
			get { return _salesPerson; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSalesPerson(value);
					CallSetRelatedEntityDuringDeserialization(value, "Employee");
				}
				else
				{
					if(value==null)
					{
						bool raisePropertyChanged = (_salesPerson !=null);
						DesetupSyncSalesPerson(true, true);
						if(raisePropertyChanged)
						{
							OnPropertyChanged("SalesPerson");
						}
					}
					else
					{
						if(_salesPerson!=value)
						{
							((IEntity2)value).SetRelatedEntity(this, "Employee");
							SetupSyncSalesPerson(value);
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
			get { return (int)AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity; }
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
