﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.8.</auto-generated>
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
	/// <summary>Entity class which represents the entity 'AddressType'.<br/><br/></summary>
	[Serializable]
	public partial class AddressTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private EntityCollection<BusinessEntityAddressEntity> _businessEntityAddresses;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static AddressTypeEntityStaticMetaData _staticMetaData = new AddressTypeEntityStaticMetaData();
		private static AddressTypeRelations _relationsFactory = new AddressTypeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name BusinessEntityAddresses</summary>
			public static readonly string BusinessEntityAddresses = "BusinessEntityAddresses";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class AddressTypeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public AddressTypeEntityStaticMetaData()
			{
				SetEntityCoreInfo("AddressTypeEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.AddressTypeEntity, typeof(AddressTypeEntity), typeof(AddressTypeEntityFactory), false);
				AddNavigatorMetaData<AddressTypeEntity, EntityCollection<BusinessEntityAddressEntity>>("BusinessEntityAddresses", a => a._businessEntityAddresses, (a, b) => a._businessEntityAddresses = b, a => a.BusinessEntityAddresses, () => new AddressTypeRelations().BusinessEntityAddressEntityUsingAddressTypeId, typeof(BusinessEntityAddressEntity), (int)AdventureWorks.Dal.Adapter.EntityType.BusinessEntityAddressEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static AddressTypeEntity()
		{
		}

		/// <summary> CTor</summary>
		public AddressTypeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AddressTypeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AddressTypeEntity</param>
		public AddressTypeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="addressTypeId">PK value for AddressType which data should be fetched into this AddressType object</param>
		public AddressTypeEntity(System.Int32 addressTypeId) : this(addressTypeId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="addressTypeId">PK value for AddressType which data should be fetched into this AddressType object</param>
		/// <param name="validator">The custom validator object for this AddressTypeEntity</param>
		public AddressTypeEntity(System.Int32 addressTypeId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.AddressTypeId = addressTypeId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AddressTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'BusinessEntityAddress' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoBusinessEntityAddresses() { return CreateRelationInfoForNavigator("BusinessEntityAddresses"); }
		
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
		/// <param name="validator">The validator object for this AddressTypeEntity</param>
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
		public static AddressTypeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'BusinessEntityAddress' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathBusinessEntityAddresses { get { return _staticMetaData.GetPrefetchPathElement("BusinessEntityAddresses", CommonEntityBase.CreateEntityCollection<BusinessEntityAddressEntity>()); } }

		/// <summary>The AddressTypeId property of the Entity AddressType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."AddressTypeID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 AddressTypeId
		{
			get { return (System.Int32)GetValue((int)AddressTypeFieldIndex.AddressTypeId, true); }
			set { SetValue((int)AddressTypeFieldIndex.AddressTypeId, value); }		}

		/// <summary>The ModifiedDate property of the Entity AddressType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)AddressTypeFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The Name property of the Entity AddressType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AddressTypeFieldIndex.Name, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.Name, value); }
		}

		/// <summary>The Rowguid property of the Entity AddressType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "AddressType"."rowguid".<br/>Table field type characteristics (type, precision, scale, length): UniqueIdentifier, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Guid Rowguid
		{
			get { return (System.Guid)GetValue((int)AddressTypeFieldIndex.Rowguid, true); }
			set	{ SetValue((int)AddressTypeFieldIndex.Rowguid, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'BusinessEntityAddressEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(BusinessEntityAddressEntity))]
		public virtual EntityCollection<BusinessEntityAddressEntity> BusinessEntityAddresses { get { return GetOrCreateEntityCollection<BusinessEntityAddressEntity, BusinessEntityAddressEntityFactory>("AddressType", true, false, ref _businessEntityAddresses); } }

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum AddressTypeFieldIndex
	{
		///<summary>AddressTypeId. </summary>
		AddressTypeId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: AddressType. </summary>
	public partial class AddressTypeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between AddressTypeEntity and BusinessEntityAddressEntity over the 1:n relation they have, using the relation between the fields: AddressType.AddressTypeId - BusinessEntityAddress.AddressTypeId</summary>
		public virtual IEntityRelation BusinessEntityAddressEntityUsingAddressTypeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "BusinessEntityAddresses", true, new[] { AddressTypeFields.AddressTypeId, BusinessEntityAddressFields.AddressTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAddressTypeRelations
	{
		internal static readonly IEntityRelation BusinessEntityAddressEntityUsingAddressTypeIdStatic = new AddressTypeRelations().BusinessEntityAddressEntityUsingAddressTypeId;

		/// <summary>CTor</summary>
		static StaticAddressTypeRelations() { }
	}
}
