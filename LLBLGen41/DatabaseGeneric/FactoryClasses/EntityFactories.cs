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
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v41.EntityClasses;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using AdventureWorks.Dal.Adapter.v41.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v41.FactoryClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>general base class for the generated factories</summary>
	[Serializable]
	public partial class EntityFactoryBase2<TEntity> : EntityFactoryCore2
		where TEntity : EntityBase2, IEntity2
	{
		private readonly AdventureWorks.Dal.Adapter.v41.EntityType _typeOfEntity;
		private readonly bool _isInHierarchy;
		
		/// <summary>CTor</summary>
		/// <param name="entityName">Name of the entity.</param>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <param name="isInHierarchy">If true, the entity of this factory is in an inheritance hierarchy, false otherwise</param>
		public EntityFactoryBase2(string entityName, AdventureWorks.Dal.Adapter.v41.EntityType typeOfEntity, bool isInHierarchy) : base(entityName)
		{
			_typeOfEntity = typeOfEntity;
			_isInHierarchy = isInHierarchy;
		}
		
		/// <summary>Creates, using the generated EntityFieldsFactory, the IEntityFields2 object for the entity to create.</summary>
		/// <returns>Empty IEntityFields2 object.</returns>
		public override IEntityFields2 CreateFields()
		{
			return EntityFieldsFactory.CreateEntityFieldsObject(_typeOfEntity);
		}
		
		/// <summary>Creates a new entity instance using the GeneralEntityFactory in the generated code, using the passed in entitytype value</summary>
		/// <param name="entityTypeValue">The entity type value of the entity to create an instance for.</param>
		/// <returns>new IEntity instance</returns>
		public override IEntity2 CreateEntityFromEntityTypeValue(int entityTypeValue)
		{
			return GeneralEntityFactory.Create((AdventureWorks.Dal.Adapter.v41.EntityType)entityTypeValue);
		}

		/// <summary>Creates the relations collection to the entity to join all targets so this entity can be fetched. </summary>
		/// <param name="objectAlias">The object alias to use for the elements in the relations.</param>
		/// <returns>null if the entity isn't in a hierarchy of type TargetPerEntity, otherwise the relations collection needed to join all targets together to fetch all subtypes of this entity and this entity itself</returns>
		public override IRelationCollection CreateHierarchyRelations(string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetHierarchyRelations(this.ForEntityName, objectAlias);
		}

		/// <summary>This method retrieves, using the InheritanceInfoprovider, the factory for the entity represented by the values passed in.</summary>
		/// <param name="fieldValues">Field values read from the db, to determine which factory to return, based on the field values passed in.</param>
		/// <param name="entityFieldStartIndexesPerEntity">indexes into values where per entity type their own fields start.</param>
		/// <returns>the factory for the entity which is represented by the values passed in.</returns>
		public override IEntityFactory2 GetEntityFactory(object[] fieldValues, Dictionary<string, int> entityFieldStartIndexesPerEntity) 
		{
			IEntityFactory2 toReturn = (IEntityFactory2)InheritanceInfoProviderSingleton.GetInstance().GetEntityFactory(this.ForEntityName, fieldValues, entityFieldStartIndexesPerEntity);
			if(toReturn == null)
			{
				toReturn = this;
			}
			return toReturn;
		}
		
		/// <summary>Gets a predicateexpression which filters on the entity with type belonging to this factory.</summary>
		/// <param name="negate">Flag to produce a NOT filter, (true), or a normal filter (false). </param>
		/// <param name="objectAlias">The object alias to use for the predicate(s).</param>
		/// <returns>ready to use predicateexpression, or an empty predicate expression if the belonging entity isn't a hierarchical type.</returns>
		public override IPredicateExpression GetEntityTypeFilter(bool negate, string objectAlias) 
		{
			return InheritanceInfoProviderSingleton.GetInstance().GetEntityTypeFilter(this.ForEntityName, objectAlias, negate);
		}
						
		/// <summary>Creates a new generic EntityCollection(Of T) for the entity which this factory belongs to.</summary>
		/// <returns>ready to use generic EntityCollection(Of T) with this factory set as the factory</returns>
		public override IEntityCollection2 CreateEntityCollection()
		{
			return new EntityCollection<TEntity>(this);
		}
		
		/// <summary>Creates the hierarchy fields for the entity to which this factory belongs.</summary>
		/// <returns>IEntityFields2 object with the fields of all the entities in teh hierarchy of this entity or the fields of this entity if the entity isn't in a hierarchy.</returns>
		public override IEntityFields2 CreateHierarchyFields() 
		{
			return _isInHierarchy ? new EntityFields2(InheritanceInfoProviderSingleton.GetInstance().GetHierarchyFields(this.ForEntityName), InheritanceInfoProviderSingleton.GetInstance(), null) : base.CreateHierarchyFields();
		}
	}

	/// <summary>Factory to create new, empty AddressEntity objects.</summary>
	[Serializable]
	public partial class AddressEntityFactory : EntityFactoryBase2<AddressEntity> {
		/// <summary>CTor</summary>
		public AddressEntityFactory() : base("AddressEntity", AdventureWorks.Dal.Adapter.v41.EntityType.AddressEntity, false) { }
		
		/// <summary>Creates a new AddressEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AddressEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty AddressTypeEntity objects.</summary>
	[Serializable]
	public partial class AddressTypeEntityFactory : EntityFactoryBase2<AddressTypeEntity> {
		/// <summary>CTor</summary>
		public AddressTypeEntityFactory() : base("AddressTypeEntity", AdventureWorks.Dal.Adapter.v41.EntityType.AddressTypeEntity, false) { }
		
		/// <summary>Creates a new AddressTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new AddressTypeEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewAddressTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BillOfMaterialEntity objects.</summary>
	[Serializable]
	public partial class BillOfMaterialEntityFactory : EntityFactoryBase2<BillOfMaterialEntity> {
		/// <summary>CTor</summary>
		public BillOfMaterialEntityFactory() : base("BillOfMaterialEntity", AdventureWorks.Dal.Adapter.v41.EntityType.BillOfMaterialEntity, false) { }
		
		/// <summary>Creates a new BillOfMaterialEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BillOfMaterialEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBillOfMaterialUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BusinessEntityEntity objects.</summary>
	[Serializable]
	public partial class BusinessEntityEntityFactory : EntityFactoryBase2<BusinessEntityEntity> {
		/// <summary>CTor</summary>
		public BusinessEntityEntityFactory() : base("BusinessEntityEntity", AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityEntity, false) { }
		
		/// <summary>Creates a new BusinessEntityEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BusinessEntityEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBusinessEntityUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BusinessEntityAddressEntity objects.</summary>
	[Serializable]
	public partial class BusinessEntityAddressEntityFactory : EntityFactoryBase2<BusinessEntityAddressEntity> {
		/// <summary>CTor</summary>
		public BusinessEntityAddressEntityFactory() : base("BusinessEntityAddressEntity", AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityAddressEntity, false) { }
		
		/// <summary>Creates a new BusinessEntityAddressEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BusinessEntityAddressEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBusinessEntityAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty BusinessEntityContactEntity objects.</summary>
	[Serializable]
	public partial class BusinessEntityContactEntityFactory : EntityFactoryBase2<BusinessEntityContactEntity> {
		/// <summary>CTor</summary>
		public BusinessEntityContactEntityFactory() : base("BusinessEntityContactEntity", AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityContactEntity, false) { }
		
		/// <summary>Creates a new BusinessEntityContactEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new BusinessEntityContactEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewBusinessEntityContactUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ContactCreditCardEntity objects.</summary>
	[Serializable]
	public partial class ContactCreditCardEntityFactory : EntityFactoryBase2<ContactCreditCardEntity> {
		/// <summary>CTor</summary>
		public ContactCreditCardEntityFactory() : base("ContactCreditCardEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ContactCreditCardEntity, false) { }
		
		/// <summary>Creates a new ContactCreditCardEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ContactCreditCardEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewContactCreditCardUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ContactTypeEntity objects.</summary>
	[Serializable]
	public partial class ContactTypeEntityFactory : EntityFactoryBase2<ContactTypeEntity> {
		/// <summary>CTor</summary>
		public ContactTypeEntityFactory() : base("ContactTypeEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ContactTypeEntity, false) { }
		
		/// <summary>Creates a new ContactTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ContactTypeEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewContactTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CountryRegionEntity objects.</summary>
	[Serializable]
	public partial class CountryRegionEntityFactory : EntityFactoryBase2<CountryRegionEntity> {
		/// <summary>CTor</summary>
		public CountryRegionEntityFactory() : base("CountryRegionEntity", AdventureWorks.Dal.Adapter.v41.EntityType.CountryRegionEntity, false) { }
		
		/// <summary>Creates a new CountryRegionEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CountryRegionEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCountryRegionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CountryRegionCurrencyEntity objects.</summary>
	[Serializable]
	public partial class CountryRegionCurrencyEntityFactory : EntityFactoryBase2<CountryRegionCurrencyEntity> {
		/// <summary>CTor</summary>
		public CountryRegionCurrencyEntityFactory() : base("CountryRegionCurrencyEntity", AdventureWorks.Dal.Adapter.v41.EntityType.CountryRegionCurrencyEntity, false) { }
		
		/// <summary>Creates a new CountryRegionCurrencyEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CountryRegionCurrencyEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCountryRegionCurrencyUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CreditCardEntity objects.</summary>
	[Serializable]
	public partial class CreditCardEntityFactory : EntityFactoryBase2<CreditCardEntity> {
		/// <summary>CTor</summary>
		public CreditCardEntityFactory() : base("CreditCardEntity", AdventureWorks.Dal.Adapter.v41.EntityType.CreditCardEntity, false) { }
		
		/// <summary>Creates a new CreditCardEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CreditCardEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCreditCardUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CultureEntity objects.</summary>
	[Serializable]
	public partial class CultureEntityFactory : EntityFactoryBase2<CultureEntity> {
		/// <summary>CTor</summary>
		public CultureEntityFactory() : base("CultureEntity", AdventureWorks.Dal.Adapter.v41.EntityType.CultureEntity, false) { }
		
		/// <summary>Creates a new CultureEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CultureEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCultureUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CurrencyEntity objects.</summary>
	[Serializable]
	public partial class CurrencyEntityFactory : EntityFactoryBase2<CurrencyEntity> {
		/// <summary>CTor</summary>
		public CurrencyEntityFactory() : base("CurrencyEntity", AdventureWorks.Dal.Adapter.v41.EntityType.CurrencyEntity, false) { }
		
		/// <summary>Creates a new CurrencyEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CurrencyEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCurrencyUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CurrencyRateEntity objects.</summary>
	[Serializable]
	public partial class CurrencyRateEntityFactory : EntityFactoryBase2<CurrencyRateEntity> {
		/// <summary>CTor</summary>
		public CurrencyRateEntityFactory() : base("CurrencyRateEntity", AdventureWorks.Dal.Adapter.v41.EntityType.CurrencyRateEntity, false) { }
		
		/// <summary>Creates a new CurrencyRateEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CurrencyRateEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCurrencyRateUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty CustomerEntity objects.</summary>
	[Serializable]
	public partial class CustomerEntityFactory : EntityFactoryBase2<CustomerEntity> {
		/// <summary>CTor</summary>
		public CustomerEntityFactory() : base("CustomerEntity", AdventureWorks.Dal.Adapter.v41.EntityType.CustomerEntity, false) { }
		
		/// <summary>Creates a new CustomerEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new CustomerEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewCustomerUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty DepartmentEntity objects.</summary>
	[Serializable]
	public partial class DepartmentEntityFactory : EntityFactoryBase2<DepartmentEntity> {
		/// <summary>CTor</summary>
		public DepartmentEntityFactory() : base("DepartmentEntity", AdventureWorks.Dal.Adapter.v41.EntityType.DepartmentEntity, false) { }
		
		/// <summary>Creates a new DepartmentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DepartmentEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDepartmentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty DocumentEntity objects.</summary>
	[Serializable]
	public partial class DocumentEntityFactory : EntityFactoryBase2<DocumentEntity> {
		/// <summary>CTor</summary>
		public DocumentEntityFactory() : base("DocumentEntity", AdventureWorks.Dal.Adapter.v41.EntityType.DocumentEntity, false) { }
		
		/// <summary>Creates a new DocumentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new DocumentEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewDocumentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty EmailAddressEntity objects.</summary>
	[Serializable]
	public partial class EmailAddressEntityFactory : EntityFactoryBase2<EmailAddressEntity> {
		/// <summary>CTor</summary>
		public EmailAddressEntityFactory() : base("EmailAddressEntity", AdventureWorks.Dal.Adapter.v41.EntityType.EmailAddressEntity, false) { }
		
		/// <summary>Creates a new EmailAddressEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new EmailAddressEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmailAddressUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty EmployeeEntity objects.</summary>
	[Serializable]
	public partial class EmployeeEntityFactory : EntityFactoryBase2<EmployeeEntity> {
		/// <summary>CTor</summary>
		public EmployeeEntityFactory() : base("EmployeeEntity", AdventureWorks.Dal.Adapter.v41.EntityType.EmployeeEntity, false) { }
		
		/// <summary>Creates a new EmployeeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new EmployeeEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty EmployeeDepartmentHistoryEntity objects.</summary>
	[Serializable]
	public partial class EmployeeDepartmentHistoryEntityFactory : EntityFactoryBase2<EmployeeDepartmentHistoryEntity> {
		/// <summary>CTor</summary>
		public EmployeeDepartmentHistoryEntityFactory() : base("EmployeeDepartmentHistoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.EmployeeDepartmentHistoryEntity, false) { }
		
		/// <summary>Creates a new EmployeeDepartmentHistoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new EmployeeDepartmentHistoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeeDepartmentHistoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty EmployeePayHistoryEntity objects.</summary>
	[Serializable]
	public partial class EmployeePayHistoryEntityFactory : EntityFactoryBase2<EmployeePayHistoryEntity> {
		/// <summary>CTor</summary>
		public EmployeePayHistoryEntityFactory() : base("EmployeePayHistoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.EmployeePayHistoryEntity, false) { }
		
		/// <summary>Creates a new EmployeePayHistoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new EmployeePayHistoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewEmployeePayHistoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty IllustrationEntity objects.</summary>
	[Serializable]
	public partial class IllustrationEntityFactory : EntityFactoryBase2<IllustrationEntity> {
		/// <summary>CTor</summary>
		public IllustrationEntityFactory() : base("IllustrationEntity", AdventureWorks.Dal.Adapter.v41.EntityType.IllustrationEntity, false) { }
		
		/// <summary>Creates a new IllustrationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new IllustrationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewIllustrationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty JobCandidateEntity objects.</summary>
	[Serializable]
	public partial class JobCandidateEntityFactory : EntityFactoryBase2<JobCandidateEntity> {
		/// <summary>CTor</summary>
		public JobCandidateEntityFactory() : base("JobCandidateEntity", AdventureWorks.Dal.Adapter.v41.EntityType.JobCandidateEntity, false) { }
		
		/// <summary>Creates a new JobCandidateEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new JobCandidateEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewJobCandidateUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty LocationEntity objects.</summary>
	[Serializable]
	public partial class LocationEntityFactory : EntityFactoryBase2<LocationEntity> {
		/// <summary>CTor</summary>
		public LocationEntityFactory() : base("LocationEntity", AdventureWorks.Dal.Adapter.v41.EntityType.LocationEntity, false) { }
		
		/// <summary>Creates a new LocationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new LocationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewLocationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PasswordEntity objects.</summary>
	[Serializable]
	public partial class PasswordEntityFactory : EntityFactoryBase2<PasswordEntity> {
		/// <summary>CTor</summary>
		public PasswordEntityFactory() : base("PasswordEntity", AdventureWorks.Dal.Adapter.v41.EntityType.PasswordEntity, false) { }
		
		/// <summary>Creates a new PasswordEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PasswordEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPasswordUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PersonEntity objects.</summary>
	[Serializable]
	public partial class PersonEntityFactory : EntityFactoryBase2<PersonEntity> {
		/// <summary>CTor</summary>
		public PersonEntityFactory() : base("PersonEntity", AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity, false) { }
		
		/// <summary>Creates a new PersonEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PersonEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPersonUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PersonPhoneEntity objects.</summary>
	[Serializable]
	public partial class PersonPhoneEntityFactory : EntityFactoryBase2<PersonPhoneEntity> {
		/// <summary>CTor</summary>
		public PersonPhoneEntityFactory() : base("PersonPhoneEntity", AdventureWorks.Dal.Adapter.v41.EntityType.PersonPhoneEntity, false) { }
		
		/// <summary>Creates a new PersonPhoneEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PersonPhoneEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPersonPhoneUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PhoneNumberTypeEntity objects.</summary>
	[Serializable]
	public partial class PhoneNumberTypeEntityFactory : EntityFactoryBase2<PhoneNumberTypeEntity> {
		/// <summary>CTor</summary>
		public PhoneNumberTypeEntityFactory() : base("PhoneNumberTypeEntity", AdventureWorks.Dal.Adapter.v41.EntityType.PhoneNumberTypeEntity, false) { }
		
		/// <summary>Creates a new PhoneNumberTypeEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PhoneNumberTypeEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPhoneNumberTypeUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductEntity objects.</summary>
	[Serializable]
	public partial class ProductEntityFactory : EntityFactoryBase2<ProductEntity> {
		/// <summary>CTor</summary>
		public ProductEntityFactory() : base("ProductEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductEntity, false) { }
		
		/// <summary>Creates a new ProductEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductCategoryEntity objects.</summary>
	[Serializable]
	public partial class ProductCategoryEntityFactory : EntityFactoryBase2<ProductCategoryEntity> {
		/// <summary>CTor</summary>
		public ProductCategoryEntityFactory() : base("ProductCategoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductCategoryEntity, false) { }
		
		/// <summary>Creates a new ProductCategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductCategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductCategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductCostHistoryEntity objects.</summary>
	[Serializable]
	public partial class ProductCostHistoryEntityFactory : EntityFactoryBase2<ProductCostHistoryEntity> {
		/// <summary>CTor</summary>
		public ProductCostHistoryEntityFactory() : base("ProductCostHistoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductCostHistoryEntity, false) { }
		
		/// <summary>Creates a new ProductCostHistoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductCostHistoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductCostHistoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductDescriptionEntity objects.</summary>
	[Serializable]
	public partial class ProductDescriptionEntityFactory : EntityFactoryBase2<ProductDescriptionEntity> {
		/// <summary>CTor</summary>
		public ProductDescriptionEntityFactory() : base("ProductDescriptionEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductDescriptionEntity, false) { }
		
		/// <summary>Creates a new ProductDescriptionEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductDescriptionEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductDescriptionUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductDocumentEntity objects.</summary>
	[Serializable]
	public partial class ProductDocumentEntityFactory : EntityFactoryBase2<ProductDocumentEntity> {
		/// <summary>CTor</summary>
		public ProductDocumentEntityFactory() : base("ProductDocumentEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductDocumentEntity, false) { }
		
		/// <summary>Creates a new ProductDocumentEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductDocumentEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductDocumentUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductInventoryEntity objects.</summary>
	[Serializable]
	public partial class ProductInventoryEntityFactory : EntityFactoryBase2<ProductInventoryEntity> {
		/// <summary>CTor</summary>
		public ProductInventoryEntityFactory() : base("ProductInventoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductInventoryEntity, false) { }
		
		/// <summary>Creates a new ProductInventoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductInventoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductInventoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductListPriceHistoryEntity objects.</summary>
	[Serializable]
	public partial class ProductListPriceHistoryEntityFactory : EntityFactoryBase2<ProductListPriceHistoryEntity> {
		/// <summary>CTor</summary>
		public ProductListPriceHistoryEntityFactory() : base("ProductListPriceHistoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductListPriceHistoryEntity, false) { }
		
		/// <summary>Creates a new ProductListPriceHistoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductListPriceHistoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductListPriceHistoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductModelEntity objects.</summary>
	[Serializable]
	public partial class ProductModelEntityFactory : EntityFactoryBase2<ProductModelEntity> {
		/// <summary>CTor</summary>
		public ProductModelEntityFactory() : base("ProductModelEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelEntity, false) { }
		
		/// <summary>Creates a new ProductModelEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductModelEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductModelUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductModelIllustrationEntity objects.</summary>
	[Serializable]
	public partial class ProductModelIllustrationEntityFactory : EntityFactoryBase2<ProductModelIllustrationEntity> {
		/// <summary>CTor</summary>
		public ProductModelIllustrationEntityFactory() : base("ProductModelIllustrationEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelIllustrationEntity, false) { }
		
		/// <summary>Creates a new ProductModelIllustrationEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductModelIllustrationEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductModelIllustrationUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductModelProductDescriptionCultureEntity objects.</summary>
	[Serializable]
	public partial class ProductModelProductDescriptionCultureEntityFactory : EntityFactoryBase2<ProductModelProductDescriptionCultureEntity> {
		/// <summary>CTor</summary>
		public ProductModelProductDescriptionCultureEntityFactory() : base("ProductModelProductDescriptionCultureEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelProductDescriptionCultureEntity, false) { }
		
		/// <summary>Creates a new ProductModelProductDescriptionCultureEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductModelProductDescriptionCultureEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductModelProductDescriptionCultureUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductPhotoEntity objects.</summary>
	[Serializable]
	public partial class ProductPhotoEntityFactory : EntityFactoryBase2<ProductPhotoEntity> {
		/// <summary>CTor</summary>
		public ProductPhotoEntityFactory() : base("ProductPhotoEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductPhotoEntity, false) { }
		
		/// <summary>Creates a new ProductPhotoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductPhotoEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductPhotoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductProductPhotoEntity objects.</summary>
	[Serializable]
	public partial class ProductProductPhotoEntityFactory : EntityFactoryBase2<ProductProductPhotoEntity> {
		/// <summary>CTor</summary>
		public ProductProductPhotoEntityFactory() : base("ProductProductPhotoEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductProductPhotoEntity, false) { }
		
		/// <summary>Creates a new ProductProductPhotoEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductProductPhotoEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductProductPhotoUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductReviewEntity objects.</summary>
	[Serializable]
	public partial class ProductReviewEntityFactory : EntityFactoryBase2<ProductReviewEntity> {
		/// <summary>CTor</summary>
		public ProductReviewEntityFactory() : base("ProductReviewEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductReviewEntity, false) { }
		
		/// <summary>Creates a new ProductReviewEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductReviewEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductReviewUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductSubcategoryEntity objects.</summary>
	[Serializable]
	public partial class ProductSubcategoryEntityFactory : EntityFactoryBase2<ProductSubcategoryEntity> {
		/// <summary>CTor</summary>
		public ProductSubcategoryEntityFactory() : base("ProductSubcategoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductSubcategoryEntity, false) { }
		
		/// <summary>Creates a new ProductSubcategoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductSubcategoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductSubcategoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ProductVendorEntity objects.</summary>
	[Serializable]
	public partial class ProductVendorEntityFactory : EntityFactoryBase2<ProductVendorEntity> {
		/// <summary>CTor</summary>
		public ProductVendorEntityFactory() : base("ProductVendorEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ProductVendorEntity, false) { }
		
		/// <summary>Creates a new ProductVendorEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ProductVendorEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewProductVendorUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PurchaseOrderDetailEntity objects.</summary>
	[Serializable]
	public partial class PurchaseOrderDetailEntityFactory : EntityFactoryBase2<PurchaseOrderDetailEntity> {
		/// <summary>CTor</summary>
		public PurchaseOrderDetailEntityFactory() : base("PurchaseOrderDetailEntity", AdventureWorks.Dal.Adapter.v41.EntityType.PurchaseOrderDetailEntity, false) { }
		
		/// <summary>Creates a new PurchaseOrderDetailEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PurchaseOrderDetailEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPurchaseOrderDetailUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty PurchaseOrderHeaderEntity objects.</summary>
	[Serializable]
	public partial class PurchaseOrderHeaderEntityFactory : EntityFactoryBase2<PurchaseOrderHeaderEntity> {
		/// <summary>CTor</summary>
		public PurchaseOrderHeaderEntityFactory() : base("PurchaseOrderHeaderEntity", AdventureWorks.Dal.Adapter.v41.EntityType.PurchaseOrderHeaderEntity, false) { }
		
		/// <summary>Creates a new PurchaseOrderHeaderEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new PurchaseOrderHeaderEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewPurchaseOrderHeaderUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesOrderDetailEntity objects.</summary>
	[Serializable]
	public partial class SalesOrderDetailEntityFactory : EntityFactoryBase2<SalesOrderDetailEntity> {
		/// <summary>CTor</summary>
		public SalesOrderDetailEntityFactory() : base("SalesOrderDetailEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderDetailEntity, false) { }
		
		/// <summary>Creates a new SalesOrderDetailEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesOrderDetailEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderDetailUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesOrderHeaderEntity objects.</summary>
	[Serializable]
	public partial class SalesOrderHeaderEntityFactory : EntityFactoryBase2<SalesOrderHeaderEntity> {
		/// <summary>CTor</summary>
		public SalesOrderHeaderEntityFactory() : base("SalesOrderHeaderEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderHeaderEntity, false) { }
		
		/// <summary>Creates a new SalesOrderHeaderEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesOrderHeaderEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderHeaderUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesOrderHeaderSalesReasonEntity objects.</summary>
	[Serializable]
	public partial class SalesOrderHeaderSalesReasonEntityFactory : EntityFactoryBase2<SalesOrderHeaderSalesReasonEntity> {
		/// <summary>CTor</summary>
		public SalesOrderHeaderSalesReasonEntityFactory() : base("SalesOrderHeaderSalesReasonEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderHeaderSalesReasonEntity, false) { }
		
		/// <summary>Creates a new SalesOrderHeaderSalesReasonEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesOrderHeaderSalesReasonEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesOrderHeaderSalesReasonUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesPersonEntity objects.</summary>
	[Serializable]
	public partial class SalesPersonEntityFactory : EntityFactoryBase2<SalesPersonEntity> {
		/// <summary>CTor</summary>
		public SalesPersonEntityFactory() : base("SalesPersonEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesPersonEntity, false) { }
		
		/// <summary>Creates a new SalesPersonEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesPersonEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesPersonUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesPersonQuotaHistoryEntity objects.</summary>
	[Serializable]
	public partial class SalesPersonQuotaHistoryEntityFactory : EntityFactoryBase2<SalesPersonQuotaHistoryEntity> {
		/// <summary>CTor</summary>
		public SalesPersonQuotaHistoryEntityFactory() : base("SalesPersonQuotaHistoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesPersonQuotaHistoryEntity, false) { }
		
		/// <summary>Creates a new SalesPersonQuotaHistoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesPersonQuotaHistoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesPersonQuotaHistoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesReasonEntity objects.</summary>
	[Serializable]
	public partial class SalesReasonEntityFactory : EntityFactoryBase2<SalesReasonEntity> {
		/// <summary>CTor</summary>
		public SalesReasonEntityFactory() : base("SalesReasonEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesReasonEntity, false) { }
		
		/// <summary>Creates a new SalesReasonEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesReasonEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesReasonUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesTaxRateEntity objects.</summary>
	[Serializable]
	public partial class SalesTaxRateEntityFactory : EntityFactoryBase2<SalesTaxRateEntity> {
		/// <summary>CTor</summary>
		public SalesTaxRateEntityFactory() : base("SalesTaxRateEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesTaxRateEntity, false) { }
		
		/// <summary>Creates a new SalesTaxRateEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesTaxRateEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesTaxRateUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesTerritoryEntity objects.</summary>
	[Serializable]
	public partial class SalesTerritoryEntityFactory : EntityFactoryBase2<SalesTerritoryEntity> {
		/// <summary>CTor</summary>
		public SalesTerritoryEntityFactory() : base("SalesTerritoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesTerritoryEntity, false) { }
		
		/// <summary>Creates a new SalesTerritoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesTerritoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesTerritoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SalesTerritoryHistoryEntity objects.</summary>
	[Serializable]
	public partial class SalesTerritoryHistoryEntityFactory : EntityFactoryBase2<SalesTerritoryHistoryEntity> {
		/// <summary>CTor</summary>
		public SalesTerritoryHistoryEntityFactory() : base("SalesTerritoryHistoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SalesTerritoryHistoryEntity, false) { }
		
		/// <summary>Creates a new SalesTerritoryHistoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SalesTerritoryHistoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSalesTerritoryHistoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ScrapReasonEntity objects.</summary>
	[Serializable]
	public partial class ScrapReasonEntityFactory : EntityFactoryBase2<ScrapReasonEntity> {
		/// <summary>CTor</summary>
		public ScrapReasonEntityFactory() : base("ScrapReasonEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ScrapReasonEntity, false) { }
		
		/// <summary>Creates a new ScrapReasonEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ScrapReasonEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewScrapReasonUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ShiftEntity objects.</summary>
	[Serializable]
	public partial class ShiftEntityFactory : EntityFactoryBase2<ShiftEntity> {
		/// <summary>CTor</summary>
		public ShiftEntityFactory() : base("ShiftEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ShiftEntity, false) { }
		
		/// <summary>Creates a new ShiftEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ShiftEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShiftUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ShipMethodEntity objects.</summary>
	[Serializable]
	public partial class ShipMethodEntityFactory : EntityFactoryBase2<ShipMethodEntity> {
		/// <summary>CTor</summary>
		public ShipMethodEntityFactory() : base("ShipMethodEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ShipMethodEntity, false) { }
		
		/// <summary>Creates a new ShipMethodEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ShipMethodEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShipMethodUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty ShoppingCartItemEntity objects.</summary>
	[Serializable]
	public partial class ShoppingCartItemEntityFactory : EntityFactoryBase2<ShoppingCartItemEntity> {
		/// <summary>CTor</summary>
		public ShoppingCartItemEntityFactory() : base("ShoppingCartItemEntity", AdventureWorks.Dal.Adapter.v41.EntityType.ShoppingCartItemEntity, false) { }
		
		/// <summary>Creates a new ShoppingCartItemEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new ShoppingCartItemEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewShoppingCartItemUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SpecialOfferEntity objects.</summary>
	[Serializable]
	public partial class SpecialOfferEntityFactory : EntityFactoryBase2<SpecialOfferEntity> {
		/// <summary>CTor</summary>
		public SpecialOfferEntityFactory() : base("SpecialOfferEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SpecialOfferEntity, false) { }
		
		/// <summary>Creates a new SpecialOfferEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SpecialOfferEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty SpecialOfferProductEntity objects.</summary>
	[Serializable]
	public partial class SpecialOfferProductEntityFactory : EntityFactoryBase2<SpecialOfferProductEntity> {
		/// <summary>CTor</summary>
		public SpecialOfferProductEntityFactory() : base("SpecialOfferProductEntity", AdventureWorks.Dal.Adapter.v41.EntityType.SpecialOfferProductEntity, false) { }
		
		/// <summary>Creates a new SpecialOfferProductEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new SpecialOfferProductEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewSpecialOfferProductUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty StateProvinceEntity objects.</summary>
	[Serializable]
	public partial class StateProvinceEntityFactory : EntityFactoryBase2<StateProvinceEntity> {
		/// <summary>CTor</summary>
		public StateProvinceEntityFactory() : base("StateProvinceEntity", AdventureWorks.Dal.Adapter.v41.EntityType.StateProvinceEntity, false) { }
		
		/// <summary>Creates a new StateProvinceEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new StateProvinceEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStateProvinceUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty StoreEntity objects.</summary>
	[Serializable]
	public partial class StoreEntityFactory : EntityFactoryBase2<StoreEntity> {
		/// <summary>CTor</summary>
		public StoreEntityFactory() : base("StoreEntity", AdventureWorks.Dal.Adapter.v41.EntityType.StoreEntity, false) { }
		
		/// <summary>Creates a new StoreEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new StoreEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewStoreUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty TransactionHistoryEntity objects.</summary>
	[Serializable]
	public partial class TransactionHistoryEntityFactory : EntityFactoryBase2<TransactionHistoryEntity> {
		/// <summary>CTor</summary>
		public TransactionHistoryEntityFactory() : base("TransactionHistoryEntity", AdventureWorks.Dal.Adapter.v41.EntityType.TransactionHistoryEntity, false) { }
		
		/// <summary>Creates a new TransactionHistoryEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TransactionHistoryEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTransactionHistoryUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty TransactionHistoryArchiveEntity objects.</summary>
	[Serializable]
	public partial class TransactionHistoryArchiveEntityFactory : EntityFactoryBase2<TransactionHistoryArchiveEntity> {
		/// <summary>CTor</summary>
		public TransactionHistoryArchiveEntityFactory() : base("TransactionHistoryArchiveEntity", AdventureWorks.Dal.Adapter.v41.EntityType.TransactionHistoryArchiveEntity, false) { }
		
		/// <summary>Creates a new TransactionHistoryArchiveEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new TransactionHistoryArchiveEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewTransactionHistoryArchiveUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty UnitMeasureEntity objects.</summary>
	[Serializable]
	public partial class UnitMeasureEntityFactory : EntityFactoryBase2<UnitMeasureEntity> {
		/// <summary>CTor</summary>
		public UnitMeasureEntityFactory() : base("UnitMeasureEntity", AdventureWorks.Dal.Adapter.v41.EntityType.UnitMeasureEntity, false) { }
		
		/// <summary>Creates a new UnitMeasureEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new UnitMeasureEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewUnitMeasureUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty VendorEntity objects.</summary>
	[Serializable]
	public partial class VendorEntityFactory : EntityFactoryBase2<VendorEntity> {
		/// <summary>CTor</summary>
		public VendorEntityFactory() : base("VendorEntity", AdventureWorks.Dal.Adapter.v41.EntityType.VendorEntity, false) { }
		
		/// <summary>Creates a new VendorEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new VendorEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewVendorUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty WorkOrderEntity objects.</summary>
	[Serializable]
	public partial class WorkOrderEntityFactory : EntityFactoryBase2<WorkOrderEntity> {
		/// <summary>CTor</summary>
		public WorkOrderEntityFactory() : base("WorkOrderEntity", AdventureWorks.Dal.Adapter.v41.EntityType.WorkOrderEntity, false) { }
		
		/// <summary>Creates a new WorkOrderEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new WorkOrderEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty WorkOrderRoutingEntity objects.</summary>
	[Serializable]
	public partial class WorkOrderRoutingEntityFactory : EntityFactoryBase2<WorkOrderRoutingEntity> {
		/// <summary>CTor</summary>
		public WorkOrderRoutingEntityFactory() : base("WorkOrderRoutingEntity", AdventureWorks.Dal.Adapter.v41.EntityType.WorkOrderRoutingEntity, false) { }
		
		/// <summary>Creates a new WorkOrderRoutingEntity instance but uses a special constructor which will set the Fields object of the new IEntity2 instance to the passed in fields object.</summary>
		/// <param name="fields">Populated IEntityFields2 object for the new IEntity2 to create</param>
		/// <returns>Fully created and populated (due to the IEntityFields2 object) IEntity2 object</returns>
		public override IEntity2 Create(IEntityFields2 fields) {
			IEntity2 toReturn = new WorkOrderRoutingEntity(fields);
			// __LLBLGENPRO_USER_CODE_REGION_START CreateNewWorkOrderRoutingUsingFields
			// __LLBLGENPRO_USER_CODE_REGION_END
			return toReturn;
		}
		#region Included Code

		#endregion
	}

	/// <summary>Factory to create new, empty Entity objects based on the entity type specified. Uses  entity specific factory objects</summary>
	[Serializable]
	public partial class GeneralEntityFactory
	{
		/// <summary>Creates a new, empty Entity object of the type specified</summary>
		/// <param name="entityTypeToCreate">The entity type to create.</param>
		/// <returns>A new, empty Entity object.</returns>
		public static IEntity2 Create(AdventureWorks.Dal.Adapter.v41.EntityType entityTypeToCreate)
		{
			IEntityFactory2 factoryToUse = null;
			switch(entityTypeToCreate)
			{
				case AdventureWorks.Dal.Adapter.v41.EntityType.AddressEntity:
					factoryToUse = new AddressEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.AddressTypeEntity:
					factoryToUse = new AddressTypeEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.BillOfMaterialEntity:
					factoryToUse = new BillOfMaterialEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityEntity:
					factoryToUse = new BusinessEntityEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityAddressEntity:
					factoryToUse = new BusinessEntityAddressEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.BusinessEntityContactEntity:
					factoryToUse = new BusinessEntityContactEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ContactCreditCardEntity:
					factoryToUse = new ContactCreditCardEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ContactTypeEntity:
					factoryToUse = new ContactTypeEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CountryRegionEntity:
					factoryToUse = new CountryRegionEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CountryRegionCurrencyEntity:
					factoryToUse = new CountryRegionCurrencyEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CreditCardEntity:
					factoryToUse = new CreditCardEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CultureEntity:
					factoryToUse = new CultureEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CurrencyEntity:
					factoryToUse = new CurrencyEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CurrencyRateEntity:
					factoryToUse = new CurrencyRateEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CustomerEntity:
					factoryToUse = new CustomerEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.DepartmentEntity:
					factoryToUse = new DepartmentEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.DocumentEntity:
					factoryToUse = new DocumentEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.EmailAddressEntity:
					factoryToUse = new EmailAddressEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.EmployeeEntity:
					factoryToUse = new EmployeeEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.EmployeeDepartmentHistoryEntity:
					factoryToUse = new EmployeeDepartmentHistoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.EmployeePayHistoryEntity:
					factoryToUse = new EmployeePayHistoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.IllustrationEntity:
					factoryToUse = new IllustrationEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.JobCandidateEntity:
					factoryToUse = new JobCandidateEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.LocationEntity:
					factoryToUse = new LocationEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.PasswordEntity:
					factoryToUse = new PasswordEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.PersonEntity:
					factoryToUse = new PersonEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.PersonPhoneEntity:
					factoryToUse = new PersonPhoneEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.PhoneNumberTypeEntity:
					factoryToUse = new PhoneNumberTypeEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductEntity:
					factoryToUse = new ProductEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductCategoryEntity:
					factoryToUse = new ProductCategoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductCostHistoryEntity:
					factoryToUse = new ProductCostHistoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductDescriptionEntity:
					factoryToUse = new ProductDescriptionEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductDocumentEntity:
					factoryToUse = new ProductDocumentEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductInventoryEntity:
					factoryToUse = new ProductInventoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductListPriceHistoryEntity:
					factoryToUse = new ProductListPriceHistoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelEntity:
					factoryToUse = new ProductModelEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelIllustrationEntity:
					factoryToUse = new ProductModelIllustrationEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelProductDescriptionCultureEntity:
					factoryToUse = new ProductModelProductDescriptionCultureEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductPhotoEntity:
					factoryToUse = new ProductPhotoEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductProductPhotoEntity:
					factoryToUse = new ProductProductPhotoEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductReviewEntity:
					factoryToUse = new ProductReviewEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductSubcategoryEntity:
					factoryToUse = new ProductSubcategoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductVendorEntity:
					factoryToUse = new ProductVendorEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.PurchaseOrderDetailEntity:
					factoryToUse = new PurchaseOrderDetailEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.PurchaseOrderHeaderEntity:
					factoryToUse = new PurchaseOrderHeaderEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderDetailEntity:
					factoryToUse = new SalesOrderDetailEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderHeaderEntity:
					factoryToUse = new SalesOrderHeaderEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderHeaderSalesReasonEntity:
					factoryToUse = new SalesOrderHeaderSalesReasonEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesPersonEntity:
					factoryToUse = new SalesPersonEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesPersonQuotaHistoryEntity:
					factoryToUse = new SalesPersonQuotaHistoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesReasonEntity:
					factoryToUse = new SalesReasonEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesTaxRateEntity:
					factoryToUse = new SalesTaxRateEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesTerritoryEntity:
					factoryToUse = new SalesTerritoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesTerritoryHistoryEntity:
					factoryToUse = new SalesTerritoryHistoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ScrapReasonEntity:
					factoryToUse = new ScrapReasonEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ShiftEntity:
					factoryToUse = new ShiftEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ShipMethodEntity:
					factoryToUse = new ShipMethodEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ShoppingCartItemEntity:
					factoryToUse = new ShoppingCartItemEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SpecialOfferEntity:
					factoryToUse = new SpecialOfferEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SpecialOfferProductEntity:
					factoryToUse = new SpecialOfferProductEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.StateProvinceEntity:
					factoryToUse = new StateProvinceEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.StoreEntity:
					factoryToUse = new StoreEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.TransactionHistoryEntity:
					factoryToUse = new TransactionHistoryEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.TransactionHistoryArchiveEntity:
					factoryToUse = new TransactionHistoryArchiveEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.UnitMeasureEntity:
					factoryToUse = new UnitMeasureEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.VendorEntity:
					factoryToUse = new VendorEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.WorkOrderEntity:
					factoryToUse = new WorkOrderEntityFactory();
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.WorkOrderRoutingEntity:
					factoryToUse = new WorkOrderRoutingEntityFactory();
					break;
			}
			IEntity2 toReturn = null;
			if(factoryToUse != null)
			{
				toReturn = factoryToUse.Create();
			}
			return toReturn;
		}		
	}
		
	/// <summary>Class which is used to obtain the entity factory based on the .NET type of the entity. </summary>
	[Serializable]
	public static class EntityFactoryFactory
	{
		private static Dictionary<Type, IEntityFactory2> _factoryPerType = new Dictionary<Type, IEntityFactory2>();

		/// <summary>Initializes the <see cref="EntityFactoryFactory"/> class.</summary>
		static EntityFactoryFactory()
		{
			Array entityTypeValues = Enum.GetValues(typeof(AdventureWorks.Dal.Adapter.v41.EntityType));
			foreach(int entityTypeValue in entityTypeValues)
			{
				IEntity2 dummy = GeneralEntityFactory.Create((AdventureWorks.Dal.Adapter.v41.EntityType)entityTypeValue);
				_factoryPerType.Add(dummy.GetType(), dummy.GetEntityFactory());
			}
		}

		/// <summary>Gets the factory of the entity with the .NET type specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			IEntityFactory2 toReturn = null;
			_factoryPerType.TryGetValue(typeOfEntity, out toReturn);
			return toReturn;
		}

		/// <summary>Gets the factory of the entity with the AdventureWorks.Dal.Adapter.v41.EntityType specified</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>factory to use or null if not found</returns>
		public static IEntityFactory2 GetFactory(AdventureWorks.Dal.Adapter.v41.EntityType typeOfEntity)
		{
			return GetFactory(GeneralEntityFactory.Create(typeOfEntity).GetType());
		}
	}
		
	/// <summary>Element creator for creating project elements from somewhere else, like inside Linq providers.</summary>
	public class ElementCreator : ElementCreatorBase, IElementCreator2
	{
		/// <summary>Gets the factory of the Entity type with the AdventureWorks.Dal.Adapter.v41.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(int entityTypeValue)
		{
			return (IEntityFactory2)this.GetFactoryImpl(entityTypeValue);
		}
		
		/// <summary>Gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		public IEntityFactory2 GetFactory(Type typeOfEntity)
		{
			return (IEntityFactory2)this.GetFactoryImpl(typeOfEntity);
		}

		/// <summary>Creates a new resultset fields object with the number of field slots reserved as specified</summary>
		/// <param name="numberOfFields">The number of fields.</param>
		/// <returns>ready to use resultsetfields object</returns>
		public IEntityFields2 CreateResultsetFields(int numberOfFields)
		{
			return new ResultsetFields(numberOfFields);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand)
		{
			return new DynamicRelation(leftOperand);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperand">The right operand.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, DerivedTableDefinition rightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, rightOperand, onClause);
		}
		
		/// <summary>Obtains the inheritance info provider instance from the singleton </summary>
		/// <returns>The singleton instance of the inheritance info provider</returns>
		public override IInheritanceInfoProvider ObtainInheritanceInfoProviderInstance()
		{
			return InheritanceInfoProviderSingleton.GetInstance();
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperand">The left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(DerivedTableDefinition leftOperand, JoinHint joinType, string rightOperandEntityName, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation(leftOperand, joinType, (AdventureWorks.Dal.Adapter.v41.EntityType)Enum.Parse(typeof(AdventureWorks.Dal.Adapter.v41.EntityType), rightOperandEntityName, false), aliasRightOperand, onClause);
		}

		/// <summary>Creates a new dynamic relation instance</summary>
		/// <param name="leftOperandEntityName">Name of the entity which is used as the left operand.</param>
		/// <param name="joinType">Type of the join. If None is specified, Inner is assumed.</param>
		/// <param name="rightOperandEntityName">Name of the entity, which is used as the right operand.</param>
		/// <param name="aliasLeftOperand">The alias of the left operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="aliasRightOperand">The alias of the right operand. If you don't want to / need to alias the right operand (only alias if you have to), specify string.Empty.</param>
		/// <param name="onClause">The on clause for the join.</param>
		/// <returns>ready to use dynamic relation</returns>
		public override IDynamicRelation CreateDynamicRelation(string leftOperandEntityName, JoinHint joinType, string rightOperandEntityName, string aliasLeftOperand, string aliasRightOperand, IPredicate onClause)
		{
			return new DynamicRelation((AdventureWorks.Dal.Adapter.v41.EntityType)Enum.Parse(typeof(AdventureWorks.Dal.Adapter.v41.EntityType), leftOperandEntityName, false), joinType, (AdventureWorks.Dal.Adapter.v41.EntityType)Enum.Parse(typeof(AdventureWorks.Dal.Adapter.v41.EntityType), rightOperandEntityName, false), aliasLeftOperand, aliasRightOperand, onClause);
		}
		
		/// <summary>Implementation of the routine which gets the factory of the Entity type with the AdventureWorks.Dal.Adapter.v41.EntityType value passed in</summary>
		/// <param name="entityTypeValue">The entity type value.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(int entityTypeValue)
		{
			return EntityFactoryFactory.GetFactory((AdventureWorks.Dal.Adapter.v41.EntityType)entityTypeValue);
		}

		/// <summary>Implementation of the routine which gets the factory of the Entity type with the .NET type passed in</summary>
		/// <param name="typeOfEntity">The type of entity.</param>
		/// <returns>the entity factory of the entity type or null if not found</returns>
		protected override IEntityFactoryCore GetFactoryImpl(Type typeOfEntity)
		{
			return EntityFactoryFactory.GetFactory(typeOfEntity);
		}

	}
}
