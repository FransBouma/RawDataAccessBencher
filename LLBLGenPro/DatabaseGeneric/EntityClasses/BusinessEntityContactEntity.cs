﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.10.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'BusinessEntityContact'.<br/><br/></summary>
	[Serializable]
	public partial class BusinessEntityContactEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private BusinessEntityEntity _businessEntity;
		private ContactTypeEntity _contactType;
		private PersonEntity _person;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static BusinessEntityContactEntityStaticMetaData _staticMetaData = new BusinessEntityContactEntityStaticMetaData();
		private static BusinessEntityContactRelations _relationsFactory = new BusinessEntityContactRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BusinessEntity</summary>
			public static readonly string BusinessEntity = "BusinessEntity";
			/// <summary>Member name ContactType</summary>
			public static readonly string ContactType = "ContactType";
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class BusinessEntityContactEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public BusinessEntityContactEntityStaticMetaData()
			{
				SetEntityCoreInfo("BusinessEntityContactEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityContactEntity, typeof(BusinessEntityContactEntity), typeof(BusinessEntityContactEntityFactory), false);
				AddNavigatorMetaData<BusinessEntityContactEntity, BusinessEntityEntity>("BusinessEntity", "BusinessEntityContacts", (a, b) => a._businessEntity = b, a => a._businessEntity, (a, b) => a.BusinessEntity = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticBusinessEntityContactRelations.BusinessEntityEntityUsingBusinessEntityIdStatic, ()=>new BusinessEntityContactRelations().BusinessEntityEntityUsingBusinessEntityId, null, new int[] { (int)BusinessEntityContactFieldIndex.BusinessEntityId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityEntity);
				AddNavigatorMetaData<BusinessEntityContactEntity, ContactTypeEntity>("ContactType", "BusinessEntityContacts", (a, b) => a._contactType = b, a => a._contactType, (a, b) => a.ContactType = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticBusinessEntityContactRelations.ContactTypeEntityUsingContactTypeIdStatic, ()=>new BusinessEntityContactRelations().ContactTypeEntityUsingContactTypeId, null, new int[] { (int)BusinessEntityContactFieldIndex.ContactTypeId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.ContactTypeEntity);
				AddNavigatorMetaData<BusinessEntityContactEntity, PersonEntity>("Person", "BusinessEntityContacts", (a, b) => a._person = b, a => a._person, (a, b) => a.Person = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticBusinessEntityContactRelations.PersonEntityUsingPersonIdStatic, ()=>new BusinessEntityContactRelations().PersonEntityUsingPersonId, null, new int[] { (int)BusinessEntityContactFieldIndex.PersonId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.PersonEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static BusinessEntityContactEntity()
		{
		}

		/// <summary> CTor</summary>
		public BusinessEntityContactEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public BusinessEntityContactEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this BusinessEntityContactEntity</param>
		public BusinessEntityContactEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for BusinessEntityContact which data should be fetched into this BusinessEntityContact object</param>
		/// <param name="contactTypeId">PK value for BusinessEntityContact which data should be fetched into this BusinessEntityContact object</param>
		/// <param name="personId">PK value for BusinessEntityContact which data should be fetched into this BusinessEntityContact object</param>
		public BusinessEntityContactEntity(System.Int32 businessEntityId, System.Int32 contactTypeId, System.Int32 personId) : this(businessEntityId, contactTypeId, personId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="businessEntityId">PK value for BusinessEntityContact which data should be fetched into this BusinessEntityContact object</param>
		/// <param name="contactTypeId">PK value for BusinessEntityContact which data should be fetched into this BusinessEntityContact object</param>
		/// <param name="personId">PK value for BusinessEntityContact which data should be fetched into this BusinessEntityContact object</param>
		/// <param name="validator">The custom validator object for this BusinessEntityContactEntity</param>
		public BusinessEntityContactEntity(System.Int32 businessEntityId, System.Int32 contactTypeId, System.Int32 personId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.BusinessEntityId = businessEntityId;
			this.ContactTypeId = contactTypeId;
			this.PersonId = personId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected BusinessEntityContactEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'BusinessEntity' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntity() { return CreateRelationInfoForNavigator("BusinessEntity"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'ContactType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoContactType() { return CreateRelationInfoForNavigator("ContactType"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Person' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPerson() { return CreateRelationInfoForNavigator("Person"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this BusinessEntityContactEntity</param>
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

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static BusinessEntityContactRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntity' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntity { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntity", CommonEntityBase.CreateEntityCollection<BusinessEntityEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'ContactType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathContactType { get { return _staticMetaData.GetPrefetchPathElement("ContactType", CommonEntityBase.CreateEntityCollection<ContactTypeEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson { get { return _staticMetaData.GetPrefetchPathElement("Person", CommonEntityBase.CreateEntityCollection<PersonEntity>()); } }

		/// <summary>The BusinessEntityId property of the Entity BusinessEntityContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityContact"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 BusinessEntityId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityContactFieldIndex.BusinessEntityId, true); }
			set	{ SetValue((int)BusinessEntityContactFieldIndex.BusinessEntityId, value); }
		}

		/// <summary>The ContactTypeId property of the Entity BusinessEntityContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityContact"."ContactTypeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ContactTypeId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityContactFieldIndex.ContactTypeId, true); }
			set	{ SetValue((int)BusinessEntityContactFieldIndex.ContactTypeId, value); }
		}

		/// <summary>The ModifiedDate property of the Entity BusinessEntityContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityContact"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)BusinessEntityContactFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)BusinessEntityContactFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The PersonId property of the Entity BusinessEntityContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityContact"."PersonID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 PersonId
		{
			get { return (System.Int32)GetValue((int)BusinessEntityContactFieldIndex.PersonId, true); }
			set	{ SetValue((int)BusinessEntityContactFieldIndex.PersonId, value); }
		}

		/// <summary>The Rowguid property of the Entity BusinessEntityContact<br/><br/></summary>
		/// <remarks>Mapped on  table field: "BusinessEntityContact"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)BusinessEntityContactFieldIndex.Rowguid, true); }
			set	{ SetValue((int)BusinessEntityContactFieldIndex.Rowguid, value); }
		}

		/// <summary>Gets / sets related entity of type 'BusinessEntityEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual BusinessEntityEntity BusinessEntity
		{
			get { return _businessEntity; }
			set { SetSingleRelatedEntityNavigator(value, "BusinessEntity"); }
		}

		/// <summary>Gets / sets related entity of type 'ContactTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ContactTypeEntity ContactType
		{
			get { return _contactType; }
			set { SetSingleRelatedEntityNavigator(value, "ContactType"); }
		}

		/// <summary>Gets / sets related entity of type 'PersonEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PersonEntity Person
		{
			get { return _person; }
			set { SetSingleRelatedEntityNavigator(value, "Person"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum BusinessEntityContactFieldIndex
	{
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ContactTypeId. </summary>
		ContactTypeId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PersonId. </summary>
		PersonId,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: BusinessEntityContact. </summary>
	public partial class BusinessEntityContactRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityContactEntity and BusinessEntityEntity over the m:1 relation they have, using the relation between the fields: BusinessEntityContact.BusinessEntityId - BusinessEntity.BusinessEntityId</summary>
		public virtual IEntityRelation BusinessEntityEntityUsingBusinessEntityId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "BusinessEntity", false, new[] { BusinessEntityFields.BusinessEntityId, BusinessEntityContactFields.BusinessEntityId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityContactEntity and ContactTypeEntity over the m:1 relation they have, using the relation between the fields: BusinessEntityContact.ContactTypeId - ContactType.ContactTypeId</summary>
		public virtual IEntityRelation ContactTypeEntityUsingContactTypeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "ContactType", false, new[] { ContactTypeFields.ContactTypeId, BusinessEntityContactFields.ContactTypeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between BusinessEntityContactEntity and PersonEntity over the m:1 relation they have, using the relation between the fields: BusinessEntityContact.PersonId - Person.BusinessEntityId</summary>
		public virtual IEntityRelation PersonEntityUsingPersonId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Person", false, new[] { PersonFields.BusinessEntityId, BusinessEntityContactFields.PersonId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticBusinessEntityContactRelations
	{
		internal static readonly IEntityRelation BusinessEntityEntityUsingBusinessEntityIdStatic = new BusinessEntityContactRelations().BusinessEntityEntityUsingBusinessEntityId;
		internal static readonly IEntityRelation ContactTypeEntityUsingContactTypeIdStatic = new BusinessEntityContactRelations().ContactTypeEntityUsingContactTypeId;
		internal static readonly IEntityRelation PersonEntityUsingPersonIdStatic = new BusinessEntityContactRelations().PersonEntityUsingPersonId;

		/// <summary>CTor</summary>
		static StaticBusinessEntityContactRelations() { }
	}
}
