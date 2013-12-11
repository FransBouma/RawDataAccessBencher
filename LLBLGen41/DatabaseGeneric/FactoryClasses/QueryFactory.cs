///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using AdventureWorks.Dal.Adapter.v41.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;

namespace AdventureWorks.Dal.Adapter.v41.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory
	{
		private int _aliasCounter = 0;

		/// <summary>Creates a new DynamicQuery instance with no alias set.</summary>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create()
		{
			return Create(string.Empty);
		}

		/// <summary>Creates a new DynamicQuery instance with the alias specified as the alias set.</summary>
		/// <param name="alias">The alias.</param>
		/// <returns>Ready to use DynamicQuery instance</returns>
		public DynamicQuery Create(string alias)
		{
			return new DynamicQuery(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}

		/// <summary>Creates a new DynamicQuery which wraps the specified TableValuedFunction call</summary>
		/// <param name="toWrap">The table valued function call to wrap.</param>
		/// <returns>toWrap wrapped in a DynamicQuery.</returns>
		public DynamicQuery Create(TableValuedFunctionCall toWrap)
		{
			return this.Create().From(new TvfCallWrapper(toWrap)).Select(toWrap.GetFieldsAsArray().Select(f => this.Field(toWrap.Alias, f.Alias)).ToArray());
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with no alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>()
			where TEntity : IEntityCore
		{
			return Create<TEntity>(string.Empty);
		}

		/// <summary>Creates a new EntityQuery for the entity of the type specified with the alias specified as the alias set.</summary>
		/// <typeparam name="TEntity">The type of the entity to produce the query for.</typeparam>
		/// <param name="alias">The alias.</param>
		/// <returns>ready to use EntityQuery instance</returns>
		public EntityQuery<TEntity> Create<TEntity>(string alias)
			where TEntity : IEntityCore
		{
			return new EntityQuery<TEntity>(new ElementCreator(), alias, this.GetNextAliasCounterValue());
		}
				
		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string fieldName)
		{
			return Field<object>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'object'. Used for referring to aliased fields in another projection.</summary>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field(string targetAlias, string fieldName)
		{
			return Field<object>(targetAlias, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value represented by the field.</typeparam>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string fieldName)
		{
			return Field<TValue>(string.Empty, fieldName);
		}

		/// <summary>Creates a new field object with the name specified and of resulttype 'TValue'. Used for referring to aliased fields in another projection.</summary>
		/// <typeparam name="TValue">The type of the value.</typeparam>
		/// <param name="targetAlias">The alias of the table/query to target.</param>
		/// <param name="fieldName">Name of the field.</param>
		/// <returns>Ready to use field object</returns>
		public EntityField2 Field<TValue>(string targetAlias, string fieldName)
		{
			return new EntityField2(fieldName, targetAlias, typeof(TValue));
		}
		
		/// <summary>Gets the next alias counter value to produce artifical aliases with</summary>
		private int GetNextAliasCounterValue()
		{
			_aliasCounter++;
			return _aliasCounter;
		}
		

		/// <summary>Creates and returns a new EntityQuery for the Address entity</summary>
		public EntityQuery<AddressEntity> Address
		{
			get { return Create<AddressEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the AddressType entity</summary>
		public EntityQuery<AddressTypeEntity> AddressType
		{
			get { return Create<AddressTypeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BillOfMaterial entity</summary>
		public EntityQuery<BillOfMaterialEntity> BillOfMaterial
		{
			get { return Create<BillOfMaterialEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BusinessEntity entity</summary>
		public EntityQuery<BusinessEntityEntity> BusinessEntity
		{
			get { return Create<BusinessEntityEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BusinessEntityAddress entity</summary>
		public EntityQuery<BusinessEntityAddressEntity> BusinessEntityAddress
		{
			get { return Create<BusinessEntityAddressEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the BusinessEntityContact entity</summary>
		public EntityQuery<BusinessEntityContactEntity> BusinessEntityContact
		{
			get { return Create<BusinessEntityContactEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ContactCreditCard entity</summary>
		public EntityQuery<ContactCreditCardEntity> ContactCreditCard
		{
			get { return Create<ContactCreditCardEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ContactType entity</summary>
		public EntityQuery<ContactTypeEntity> ContactType
		{
			get { return Create<ContactTypeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CountryRegion entity</summary>
		public EntityQuery<CountryRegionEntity> CountryRegion
		{
			get { return Create<CountryRegionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CountryRegionCurrency entity</summary>
		public EntityQuery<CountryRegionCurrencyEntity> CountryRegionCurrency
		{
			get { return Create<CountryRegionCurrencyEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CreditCard entity</summary>
		public EntityQuery<CreditCardEntity> CreditCard
		{
			get { return Create<CreditCardEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Culture entity</summary>
		public EntityQuery<CultureEntity> Culture
		{
			get { return Create<CultureEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Currency entity</summary>
		public EntityQuery<CurrencyEntity> Currency
		{
			get { return Create<CurrencyEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the CurrencyRate entity</summary>
		public EntityQuery<CurrencyRateEntity> CurrencyRate
		{
			get { return Create<CurrencyRateEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Customer entity</summary>
		public EntityQuery<CustomerEntity> Customer
		{
			get { return Create<CustomerEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Department entity</summary>
		public EntityQuery<DepartmentEntity> Department
		{
			get { return Create<DepartmentEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Document entity</summary>
		public EntityQuery<DocumentEntity> Document
		{
			get { return Create<DocumentEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the EmailAddress entity</summary>
		public EntityQuery<EmailAddressEntity> EmailAddress
		{
			get { return Create<EmailAddressEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Employee entity</summary>
		public EntityQuery<EmployeeEntity> Employee
		{
			get { return Create<EmployeeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the EmployeeDepartmentHistory entity</summary>
		public EntityQuery<EmployeeDepartmentHistoryEntity> EmployeeDepartmentHistory
		{
			get { return Create<EmployeeDepartmentHistoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the EmployeePayHistory entity</summary>
		public EntityQuery<EmployeePayHistoryEntity> EmployeePayHistory
		{
			get { return Create<EmployeePayHistoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Illustration entity</summary>
		public EntityQuery<IllustrationEntity> Illustration
		{
			get { return Create<IllustrationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the JobCandidate entity</summary>
		public EntityQuery<JobCandidateEntity> JobCandidate
		{
			get { return Create<JobCandidateEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Location entity</summary>
		public EntityQuery<LocationEntity> Location
		{
			get { return Create<LocationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Password entity</summary>
		public EntityQuery<PasswordEntity> Password
		{
			get { return Create<PasswordEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Person entity</summary>
		public EntityQuery<PersonEntity> Person
		{
			get { return Create<PersonEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PersonPhone entity</summary>
		public EntityQuery<PersonPhoneEntity> PersonPhone
		{
			get { return Create<PersonPhoneEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PhoneNumberType entity</summary>
		public EntityQuery<PhoneNumberTypeEntity> PhoneNumberType
		{
			get { return Create<PhoneNumberTypeEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Product entity</summary>
		public EntityQuery<ProductEntity> Product
		{
			get { return Create<ProductEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductCategory entity</summary>
		public EntityQuery<ProductCategoryEntity> ProductCategory
		{
			get { return Create<ProductCategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductCostHistory entity</summary>
		public EntityQuery<ProductCostHistoryEntity> ProductCostHistory
		{
			get { return Create<ProductCostHistoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductDescription entity</summary>
		public EntityQuery<ProductDescriptionEntity> ProductDescription
		{
			get { return Create<ProductDescriptionEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductDocument entity</summary>
		public EntityQuery<ProductDocumentEntity> ProductDocument
		{
			get { return Create<ProductDocumentEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductInventory entity</summary>
		public EntityQuery<ProductInventoryEntity> ProductInventory
		{
			get { return Create<ProductInventoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductListPriceHistory entity</summary>
		public EntityQuery<ProductListPriceHistoryEntity> ProductListPriceHistory
		{
			get { return Create<ProductListPriceHistoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductModel entity</summary>
		public EntityQuery<ProductModelEntity> ProductModel
		{
			get { return Create<ProductModelEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductModelIllustration entity</summary>
		public EntityQuery<ProductModelIllustrationEntity> ProductModelIllustration
		{
			get { return Create<ProductModelIllustrationEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductModelProductDescriptionCulture entity</summary>
		public EntityQuery<ProductModelProductDescriptionCultureEntity> ProductModelProductDescriptionCulture
		{
			get { return Create<ProductModelProductDescriptionCultureEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductPhoto entity</summary>
		public EntityQuery<ProductPhotoEntity> ProductPhoto
		{
			get { return Create<ProductPhotoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductProductPhoto entity</summary>
		public EntityQuery<ProductProductPhotoEntity> ProductProductPhoto
		{
			get { return Create<ProductProductPhotoEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductReview entity</summary>
		public EntityQuery<ProductReviewEntity> ProductReview
		{
			get { return Create<ProductReviewEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductSubcategory entity</summary>
		public EntityQuery<ProductSubcategoryEntity> ProductSubcategory
		{
			get { return Create<ProductSubcategoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ProductVendor entity</summary>
		public EntityQuery<ProductVendorEntity> ProductVendor
		{
			get { return Create<ProductVendorEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PurchaseOrderDetail entity</summary>
		public EntityQuery<PurchaseOrderDetailEntity> PurchaseOrderDetail
		{
			get { return Create<PurchaseOrderDetailEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the PurchaseOrderHeader entity</summary>
		public EntityQuery<PurchaseOrderHeaderEntity> PurchaseOrderHeader
		{
			get { return Create<PurchaseOrderHeaderEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesOrderDetail entity</summary>
		public EntityQuery<SalesOrderDetailEntity> SalesOrderDetail
		{
			get { return Create<SalesOrderDetailEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesOrderHeader entity</summary>
		public EntityQuery<SalesOrderHeaderEntity> SalesOrderHeader
		{
			get { return Create<SalesOrderHeaderEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesOrderHeaderSalesReason entity</summary>
		public EntityQuery<SalesOrderHeaderSalesReasonEntity> SalesOrderHeaderSalesReason
		{
			get { return Create<SalesOrderHeaderSalesReasonEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesPerson entity</summary>
		public EntityQuery<SalesPersonEntity> SalesPerson
		{
			get { return Create<SalesPersonEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesPersonQuotaHistory entity</summary>
		public EntityQuery<SalesPersonQuotaHistoryEntity> SalesPersonQuotaHistory
		{
			get { return Create<SalesPersonQuotaHistoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesReason entity</summary>
		public EntityQuery<SalesReasonEntity> SalesReason
		{
			get { return Create<SalesReasonEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesTaxRate entity</summary>
		public EntityQuery<SalesTaxRateEntity> SalesTaxRate
		{
			get { return Create<SalesTaxRateEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesTerritory entity</summary>
		public EntityQuery<SalesTerritoryEntity> SalesTerritory
		{
			get { return Create<SalesTerritoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SalesTerritoryHistory entity</summary>
		public EntityQuery<SalesTerritoryHistoryEntity> SalesTerritoryHistory
		{
			get { return Create<SalesTerritoryHistoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ScrapReason entity</summary>
		public EntityQuery<ScrapReasonEntity> ScrapReason
		{
			get { return Create<ScrapReasonEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Shift entity</summary>
		public EntityQuery<ShiftEntity> Shift
		{
			get { return Create<ShiftEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ShipMethod entity</summary>
		public EntityQuery<ShipMethodEntity> ShipMethod
		{
			get { return Create<ShipMethodEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the ShoppingCartItem entity</summary>
		public EntityQuery<ShoppingCartItemEntity> ShoppingCartItem
		{
			get { return Create<ShoppingCartItemEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SpecialOffer entity</summary>
		public EntityQuery<SpecialOfferEntity> SpecialOffer
		{
			get { return Create<SpecialOfferEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the SpecialOfferProduct entity</summary>
		public EntityQuery<SpecialOfferProductEntity> SpecialOfferProduct
		{
			get { return Create<SpecialOfferProductEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the StateProvince entity</summary>
		public EntityQuery<StateProvinceEntity> StateProvince
		{
			get { return Create<StateProvinceEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Store entity</summary>
		public EntityQuery<StoreEntity> Store
		{
			get { return Create<StoreEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the TransactionHistory entity</summary>
		public EntityQuery<TransactionHistoryEntity> TransactionHistory
		{
			get { return Create<TransactionHistoryEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the TransactionHistoryArchive entity</summary>
		public EntityQuery<TransactionHistoryArchiveEntity> TransactionHistoryArchive
		{
			get { return Create<TransactionHistoryArchiveEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the UnitMeasure entity</summary>
		public EntityQuery<UnitMeasureEntity> UnitMeasure
		{
			get { return Create<UnitMeasureEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the Vendor entity</summary>
		public EntityQuery<VendorEntity> Vendor
		{
			get { return Create<VendorEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the WorkOrder entity</summary>
		public EntityQuery<WorkOrderEntity> WorkOrder
		{
			get { return Create<WorkOrderEntity>(); }
		}

		/// <summary>Creates and returns a new EntityQuery for the WorkOrderRouting entity</summary>
		public EntityQuery<WorkOrderRoutingEntity> WorkOrderRouting
		{
			get { return Create<WorkOrderRoutingEntity>(); }
		}

 

	}
}