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
	/// <summary>Entity class which represents the entity 'ContactCreditCard'.<br/><br/></summary>
	[Serializable]
	public partial class ContactCreditCardEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private CreditCardEntity _creditCard;
		private PersonEntity _person;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ContactCreditCardEntityStaticMetaData _staticMetaData = new ContactCreditCardEntityStaticMetaData();
		private static ContactCreditCardRelations _relationsFactory = new ContactCreditCardRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name CreditCard</summary>
			public static readonly string CreditCard = "CreditCard";
			/// <summary>Member name Person</summary>
			public static readonly string Person = "Person";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ContactCreditCardEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ContactCreditCardEntityStaticMetaData()
			{
				SetEntityCoreInfo("ContactCreditCardEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.ContactCreditCardEntity, typeof(ContactCreditCardEntity), typeof(ContactCreditCardEntityFactory), false);
				AddNavigatorMetaData<ContactCreditCardEntity, CreditCardEntity>("CreditCard", "ContactCreditCards", (a, b) => a._creditCard = b, a => a._creditCard, (a, b) => a.CreditCard = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticContactCreditCardRelations.CreditCardEntityUsingCreditCardIdStatic, ()=>new ContactCreditCardRelations().CreditCardEntityUsingCreditCardId, null, new int[] { (int)ContactCreditCardFieldIndex.CreditCardId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.CreditCardEntity);
				AddNavigatorMetaData<ContactCreditCardEntity, PersonEntity>("Person", "ContactCreditCards", (a, b) => a._person = b, a => a._person, (a, b) => a.Person = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticContactCreditCardRelations.PersonEntityUsingContactIdStatic, ()=>new ContactCreditCardRelations().PersonEntityUsingContactId, null, new int[] { (int)ContactCreditCardFieldIndex.ContactId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.PersonEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ContactCreditCardEntity()
		{
		}

		/// <summary> CTor</summary>
		public ContactCreditCardEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ContactCreditCardEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ContactCreditCardEntity</param>
		public ContactCreditCardEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="contactId">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="creditCardId">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		public ContactCreditCardEntity(System.Int32 contactId, System.Int32 creditCardId) : this(contactId, creditCardId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="contactId">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="creditCardId">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="validator">The custom validator object for this ContactCreditCardEntity</param>
		public ContactCreditCardEntity(System.Int32 contactId, System.Int32 creditCardId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ContactId = contactId;
			this.CreditCardId = creditCardId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ContactCreditCardEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'CreditCard' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoCreditCard() { return CreateRelationInfoForNavigator("CreditCard"); }

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
		/// <param name="validator">The validator object for this ContactCreditCardEntity</param>
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
		public static ContactCreditCardRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'CreditCard' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathCreditCard { get { return _staticMetaData.GetPrefetchPathElement("CreditCard", CommonEntityBase.CreateEntityCollection<CreditCardEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Person' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPerson { get { return _staticMetaData.GetPrefetchPathElement("Person", CommonEntityBase.CreateEntityCollection<PersonEntity>()); } }

		/// <summary>The ContactId property of the Entity ContactCreditCard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PersonCreditCard"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ContactId
		{
			get { return (System.Int32)GetValue((int)ContactCreditCardFieldIndex.ContactId, true); }
			set	{ SetValue((int)ContactCreditCardFieldIndex.ContactId, value); }
		}

		/// <summary>The CreditCardId property of the Entity ContactCreditCard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PersonCreditCard"."CreditCardID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 CreditCardId
		{
			get { return (System.Int32)GetValue((int)ContactCreditCardFieldIndex.CreditCardId, true); }
			set	{ SetValue((int)ContactCreditCardFieldIndex.CreditCardId, value); }
		}

		/// <summary>The ModifiedDate property of the Entity ContactCreditCard<br/><br/></summary>
		/// <remarks>Mapped on  table field: "PersonCreditCard"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ContactCreditCardFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ContactCreditCardFieldIndex.ModifiedDate, value); }
		}

		/// <summary>Gets / sets related entity of type 'CreditCardEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual CreditCardEntity CreditCard
		{
			get { return _creditCard; }
			set { SetSingleRelatedEntityNavigator(value, "CreditCard"); }
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
	public enum ContactCreditCardFieldIndex
	{
		///<summary>ContactId. </summary>
		ContactId,
		///<summary>CreditCardId. </summary>
		CreditCardId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ContactCreditCard. </summary>
	public partial class ContactCreditCardRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between ContactCreditCardEntity and CreditCardEntity over the m:1 relation they have, using the relation between the fields: ContactCreditCard.CreditCardId - CreditCard.CreditCardId</summary>
		public virtual IEntityRelation CreditCardEntityUsingCreditCardId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "CreditCard", false, new[] { CreditCardFields.CreditCardId, ContactCreditCardFields.CreditCardId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ContactCreditCardEntity and PersonEntity over the m:1 relation they have, using the relation between the fields: ContactCreditCard.ContactId - Person.BusinessEntityId</summary>
		public virtual IEntityRelation PersonEntityUsingContactId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Person", false, new[] { PersonFields.BusinessEntityId, ContactCreditCardFields.ContactId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticContactCreditCardRelations
	{
		internal static readonly IEntityRelation CreditCardEntityUsingCreditCardIdStatic = new ContactCreditCardRelations().CreditCardEntityUsingCreditCardId;
		internal static readonly IEntityRelation PersonEntityUsingContactIdStatic = new ContactCreditCardRelations().PersonEntityUsingContactId;

		/// <summary>CTor</summary>
		static StaticContactCreditCardRelations() { }
	}
}
