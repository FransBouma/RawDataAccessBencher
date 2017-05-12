///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using AdventureWorks.Dal.Adapter.v52;
using AdventureWorks.Dal.Adapter.v52.EntityClasses;
using AdventureWorks.Dal.Adapter.v52.FactoryClasses;
using AdventureWorks.Dal.Adapter.v52.HelperClasses;
using AdventureWorks.Dal.Adapter.v52.RelationClasses;

namespace AdventureWorks.Dal.Adapter.v52.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		#region Class Member Declarations
		private IDataAccessAdapter _adapterToUse;
		private FunctionMappingStore _customFunctionMappings;
		private Context _contextToUse;
		#endregion
		
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null)
		{
		}
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null)
		{
		}

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			_adapterToUse = adapterToUse;
			_customFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			IDataSource toReturn = null;
			switch((AdventureWorks.Dal.Adapter.v52.EntityType)typeOfEntity)
			{
				case AdventureWorks.Dal.Adapter.v52.EntityType.AddressEntity:
					toReturn = this.Address;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.AddressTypeEntity:
					toReturn = this.AddressType;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.BillOfMaterialEntity:
					toReturn = this.BillOfMaterial;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.BusinessEntityEntity:
					toReturn = this.BusinessEntity;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.BusinessEntityAddressEntity:
					toReturn = this.BusinessEntityAddress;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.BusinessEntityContactEntity:
					toReturn = this.BusinessEntityContact;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ContactCreditCardEntity:
					toReturn = this.ContactCreditCard;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ContactTypeEntity:
					toReturn = this.ContactType;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.CountryRegionEntity:
					toReturn = this.CountryRegion;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.CountryRegionCurrencyEntity:
					toReturn = this.CountryRegionCurrency;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.CreditCardEntity:
					toReturn = this.CreditCard;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.CultureEntity:
					toReturn = this.Culture;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.CurrencyEntity:
					toReturn = this.Currency;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.CurrencyRateEntity:
					toReturn = this.CurrencyRate;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.CustomerEntity:
					toReturn = this.Customer;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.DepartmentEntity:
					toReturn = this.Department;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.DocumentEntity:
					toReturn = this.Document;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.EmailAddressEntity:
					toReturn = this.EmailAddress;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.EmployeeDepartmentHistoryEntity:
					toReturn = this.EmployeeDepartmentHistory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.EmployeePayHistoryEntity:
					toReturn = this.EmployeePayHistory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.IllustrationEntity:
					toReturn = this.Illustration;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.JobCandidateEntity:
					toReturn = this.JobCandidate;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.LocationEntity:
					toReturn = this.Location;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.PasswordEntity:
					toReturn = this.Password;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.PersonEntity:
					toReturn = this.Person;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.PersonPhoneEntity:
					toReturn = this.PersonPhone;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.PhoneNumberTypeEntity:
					toReturn = this.PhoneNumberType;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductCategoryEntity:
					toReturn = this.ProductCategory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductCostHistoryEntity:
					toReturn = this.ProductCostHistory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductDescriptionEntity:
					toReturn = this.ProductDescription;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductDocumentEntity:
					toReturn = this.ProductDocument;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductInventoryEntity:
					toReturn = this.ProductInventory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductListPriceHistoryEntity:
					toReturn = this.ProductListPriceHistory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductModelEntity:
					toReturn = this.ProductModel;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductModelIllustrationEntity:
					toReturn = this.ProductModelIllustration;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductModelProductDescriptionCultureEntity:
					toReturn = this.ProductModelProductDescriptionCulture;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductPhotoEntity:
					toReturn = this.ProductPhoto;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductProductPhotoEntity:
					toReturn = this.ProductProductPhoto;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductReviewEntity:
					toReturn = this.ProductReview;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductSubcategoryEntity:
					toReturn = this.ProductSubcategory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ProductVendorEntity:
					toReturn = this.ProductVendor;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.PurchaseOrderDetailEntity:
					toReturn = this.PurchaseOrderDetail;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.PurchaseOrderHeaderEntity:
					toReturn = this.PurchaseOrderHeader;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesOrderDetailEntity:
					toReturn = this.SalesOrderDetail;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesOrderHeaderEntity:
					toReturn = this.SalesOrderHeader;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesOrderHeaderSalesReasonEntity:
					toReturn = this.SalesOrderHeaderSalesReason;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonEntity:
					toReturn = this.SalesPerson;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesPersonQuotaHistoryEntity:
					toReturn = this.SalesPersonQuotaHistory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesReasonEntity:
					toReturn = this.SalesReason;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesTaxRateEntity:
					toReturn = this.SalesTaxRate;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesTerritoryEntity:
					toReturn = this.SalesTerritory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SalesTerritoryHistoryEntity:
					toReturn = this.SalesTerritoryHistory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ScrapReasonEntity:
					toReturn = this.ScrapReason;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ShiftEntity:
					toReturn = this.Shift;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ShipMethodEntity:
					toReturn = this.ShipMethod;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.ShoppingCartItemEntity:
					toReturn = this.ShoppingCartItem;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SpecialOfferEntity:
					toReturn = this.SpecialOffer;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.SpecialOfferProductEntity:
					toReturn = this.SpecialOfferProduct;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.StateProvinceEntity:
					toReturn = this.StateProvince;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.StoreEntity:
					toReturn = this.Store;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.TransactionHistoryEntity:
					toReturn = this.TransactionHistory;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.TransactionHistoryArchiveEntity:
					toReturn = this.TransactionHistoryArchive;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.UnitMeasureEntity:
					toReturn = this.UnitMeasure;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.VendorEntity:
					toReturn = this.Vendor;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.WorkOrderEntity:
					toReturn = this.WorkOrder;
					break;
				case AdventureWorks.Dal.Adapter.v52.EntityType.WorkOrderRoutingEntity:
					toReturn = this.WorkOrderRouting;
					break;
				default:
					toReturn = null;
					break;
			}
			return toReturn;
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource2<TEntity> GetQueryableForEntity<TEntity>()
				where TEntity : class
		{
			return new DataSource2<TEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AddressEntity instances in the database.</summary>
		public DataSource2<AddressEntity> Address
		{
			get { return new DataSource2<AddressEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting AddressTypeEntity instances in the database.</summary>
		public DataSource2<AddressTypeEntity> AddressType
		{
			get { return new DataSource2<AddressTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BillOfMaterialEntity instances in the database.</summary>
		public DataSource2<BillOfMaterialEntity> BillOfMaterial
		{
			get { return new DataSource2<BillOfMaterialEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BusinessEntityEntity instances in the database.</summary>
		public DataSource2<BusinessEntityEntity> BusinessEntity
		{
			get { return new DataSource2<BusinessEntityEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BusinessEntityAddressEntity instances in the database.</summary>
		public DataSource2<BusinessEntityAddressEntity> BusinessEntityAddress
		{
			get { return new DataSource2<BusinessEntityAddressEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting BusinessEntityContactEntity instances in the database.</summary>
		public DataSource2<BusinessEntityContactEntity> BusinessEntityContact
		{
			get { return new DataSource2<BusinessEntityContactEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ContactCreditCardEntity instances in the database.</summary>
		public DataSource2<ContactCreditCardEntity> ContactCreditCard
		{
			get { return new DataSource2<ContactCreditCardEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ContactTypeEntity instances in the database.</summary>
		public DataSource2<ContactTypeEntity> ContactType
		{
			get { return new DataSource2<ContactTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CountryRegionEntity instances in the database.</summary>
		public DataSource2<CountryRegionEntity> CountryRegion
		{
			get { return new DataSource2<CountryRegionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CountryRegionCurrencyEntity instances in the database.</summary>
		public DataSource2<CountryRegionCurrencyEntity> CountryRegionCurrency
		{
			get { return new DataSource2<CountryRegionCurrencyEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CreditCardEntity instances in the database.</summary>
		public DataSource2<CreditCardEntity> CreditCard
		{
			get { return new DataSource2<CreditCardEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CultureEntity instances in the database.</summary>
		public DataSource2<CultureEntity> Culture
		{
			get { return new DataSource2<CultureEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CurrencyEntity instances in the database.</summary>
		public DataSource2<CurrencyEntity> Currency
		{
			get { return new DataSource2<CurrencyEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CurrencyRateEntity instances in the database.</summary>
		public DataSource2<CurrencyRateEntity> CurrencyRate
		{
			get { return new DataSource2<CurrencyRateEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerEntity instances in the database.</summary>
		public DataSource2<CustomerEntity> Customer
		{
			get { return new DataSource2<CustomerEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DepartmentEntity instances in the database.</summary>
		public DataSource2<DepartmentEntity> Department
		{
			get { return new DataSource2<DepartmentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting DocumentEntity instances in the database.</summary>
		public DataSource2<DocumentEntity> Document
		{
			get { return new DataSource2<DocumentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmailAddressEntity instances in the database.</summary>
		public DataSource2<EmailAddressEntity> EmailAddress
		{
			get { return new DataSource2<EmailAddressEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource2<EmployeeEntity> Employee
		{
			get { return new DataSource2<EmployeeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeDepartmentHistoryEntity instances in the database.</summary>
		public DataSource2<EmployeeDepartmentHistoryEntity> EmployeeDepartmentHistory
		{
			get { return new DataSource2<EmployeeDepartmentHistoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeePayHistoryEntity instances in the database.</summary>
		public DataSource2<EmployeePayHistoryEntity> EmployeePayHistory
		{
			get { return new DataSource2<EmployeePayHistoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting IllustrationEntity instances in the database.</summary>
		public DataSource2<IllustrationEntity> Illustration
		{
			get { return new DataSource2<IllustrationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting JobCandidateEntity instances in the database.</summary>
		public DataSource2<JobCandidateEntity> JobCandidate
		{
			get { return new DataSource2<JobCandidateEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting LocationEntity instances in the database.</summary>
		public DataSource2<LocationEntity> Location
		{
			get { return new DataSource2<LocationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PasswordEntity instances in the database.</summary>
		public DataSource2<PasswordEntity> Password
		{
			get { return new DataSource2<PasswordEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PersonEntity instances in the database.</summary>
		public DataSource2<PersonEntity> Person
		{
			get { return new DataSource2<PersonEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PersonPhoneEntity instances in the database.</summary>
		public DataSource2<PersonPhoneEntity> PersonPhone
		{
			get { return new DataSource2<PersonPhoneEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PhoneNumberTypeEntity instances in the database.</summary>
		public DataSource2<PhoneNumberTypeEntity> PhoneNumberType
		{
			get { return new DataSource2<PhoneNumberTypeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductEntity instances in the database.</summary>
		public DataSource2<ProductEntity> Product
		{
			get { return new DataSource2<ProductEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductCategoryEntity instances in the database.</summary>
		public DataSource2<ProductCategoryEntity> ProductCategory
		{
			get { return new DataSource2<ProductCategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductCostHistoryEntity instances in the database.</summary>
		public DataSource2<ProductCostHistoryEntity> ProductCostHistory
		{
			get { return new DataSource2<ProductCostHistoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductDescriptionEntity instances in the database.</summary>
		public DataSource2<ProductDescriptionEntity> ProductDescription
		{
			get { return new DataSource2<ProductDescriptionEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductDocumentEntity instances in the database.</summary>
		public DataSource2<ProductDocumentEntity> ProductDocument
		{
			get { return new DataSource2<ProductDocumentEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductInventoryEntity instances in the database.</summary>
		public DataSource2<ProductInventoryEntity> ProductInventory
		{
			get { return new DataSource2<ProductInventoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductListPriceHistoryEntity instances in the database.</summary>
		public DataSource2<ProductListPriceHistoryEntity> ProductListPriceHistory
		{
			get { return new DataSource2<ProductListPriceHistoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelEntity instances in the database.</summary>
		public DataSource2<ProductModelEntity> ProductModel
		{
			get { return new DataSource2<ProductModelEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelIllustrationEntity instances in the database.</summary>
		public DataSource2<ProductModelIllustrationEntity> ProductModelIllustration
		{
			get { return new DataSource2<ProductModelIllustrationEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductModelProductDescriptionCultureEntity instances in the database.</summary>
		public DataSource2<ProductModelProductDescriptionCultureEntity> ProductModelProductDescriptionCulture
		{
			get { return new DataSource2<ProductModelProductDescriptionCultureEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductPhotoEntity instances in the database.</summary>
		public DataSource2<ProductPhotoEntity> ProductPhoto
		{
			get { return new DataSource2<ProductPhotoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductProductPhotoEntity instances in the database.</summary>
		public DataSource2<ProductProductPhotoEntity> ProductProductPhoto
		{
			get { return new DataSource2<ProductProductPhotoEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductReviewEntity instances in the database.</summary>
		public DataSource2<ProductReviewEntity> ProductReview
		{
			get { return new DataSource2<ProductReviewEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductSubcategoryEntity instances in the database.</summary>
		public DataSource2<ProductSubcategoryEntity> ProductSubcategory
		{
			get { return new DataSource2<ProductSubcategoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProductVendorEntity instances in the database.</summary>
		public DataSource2<ProductVendorEntity> ProductVendor
		{
			get { return new DataSource2<ProductVendorEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PurchaseOrderDetailEntity instances in the database.</summary>
		public DataSource2<PurchaseOrderDetailEntity> PurchaseOrderDetail
		{
			get { return new DataSource2<PurchaseOrderDetailEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting PurchaseOrderHeaderEntity instances in the database.</summary>
		public DataSource2<PurchaseOrderHeaderEntity> PurchaseOrderHeader
		{
			get { return new DataSource2<PurchaseOrderHeaderEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderDetailEntity instances in the database.</summary>
		public DataSource2<SalesOrderDetailEntity> SalesOrderDetail
		{
			get { return new DataSource2<SalesOrderDetailEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderHeaderEntity instances in the database.</summary>
		public DataSource2<SalesOrderHeaderEntity> SalesOrderHeader
		{
			get { return new DataSource2<SalesOrderHeaderEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesOrderHeaderSalesReasonEntity instances in the database.</summary>
		public DataSource2<SalesOrderHeaderSalesReasonEntity> SalesOrderHeaderSalesReason
		{
			get { return new DataSource2<SalesOrderHeaderSalesReasonEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesPersonEntity instances in the database.</summary>
		public DataSource2<SalesPersonEntity> SalesPerson
		{
			get { return new DataSource2<SalesPersonEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesPersonQuotaHistoryEntity instances in the database.</summary>
		public DataSource2<SalesPersonQuotaHistoryEntity> SalesPersonQuotaHistory
		{
			get { return new DataSource2<SalesPersonQuotaHistoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesReasonEntity instances in the database.</summary>
		public DataSource2<SalesReasonEntity> SalesReason
		{
			get { return new DataSource2<SalesReasonEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTaxRateEntity instances in the database.</summary>
		public DataSource2<SalesTaxRateEntity> SalesTaxRate
		{
			get { return new DataSource2<SalesTaxRateEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTerritoryEntity instances in the database.</summary>
		public DataSource2<SalesTerritoryEntity> SalesTerritory
		{
			get { return new DataSource2<SalesTerritoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SalesTerritoryHistoryEntity instances in the database.</summary>
		public DataSource2<SalesTerritoryHistoryEntity> SalesTerritoryHistory
		{
			get { return new DataSource2<SalesTerritoryHistoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ScrapReasonEntity instances in the database.</summary>
		public DataSource2<ScrapReasonEntity> ScrapReason
		{
			get { return new DataSource2<ScrapReasonEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShiftEntity instances in the database.</summary>
		public DataSource2<ShiftEntity> Shift
		{
			get { return new DataSource2<ShiftEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShipMethodEntity instances in the database.</summary>
		public DataSource2<ShipMethodEntity> ShipMethod
		{
			get { return new DataSource2<ShipMethodEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting ShoppingCartItemEntity instances in the database.</summary>
		public DataSource2<ShoppingCartItemEntity> ShoppingCartItem
		{
			get { return new DataSource2<ShoppingCartItemEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SpecialOfferEntity instances in the database.</summary>
		public DataSource2<SpecialOfferEntity> SpecialOffer
		{
			get { return new DataSource2<SpecialOfferEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting SpecialOfferProductEntity instances in the database.</summary>
		public DataSource2<SpecialOfferProductEntity> SpecialOfferProduct
		{
			get { return new DataSource2<SpecialOfferProductEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting StateProvinceEntity instances in the database.</summary>
		public DataSource2<StateProvinceEntity> StateProvince
		{
			get { return new DataSource2<StateProvinceEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting StoreEntity instances in the database.</summary>
		public DataSource2<StoreEntity> Store
		{
			get { return new DataSource2<StoreEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TransactionHistoryEntity instances in the database.</summary>
		public DataSource2<TransactionHistoryEntity> TransactionHistory
		{
			get { return new DataSource2<TransactionHistoryEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting TransactionHistoryArchiveEntity instances in the database.</summary>
		public DataSource2<TransactionHistoryArchiveEntity> TransactionHistoryArchive
		{
			get { return new DataSource2<TransactionHistoryArchiveEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting UnitMeasureEntity instances in the database.</summary>
		public DataSource2<UnitMeasureEntity> UnitMeasure
		{
			get { return new DataSource2<UnitMeasureEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting VendorEntity instances in the database.</summary>
		public DataSource2<VendorEntity> Vendor
		{
			get { return new DataSource2<VendorEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderEntity instances in the database.</summary>
		public DataSource2<WorkOrderEntity> WorkOrder
		{
			get { return new DataSource2<WorkOrderEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting WorkOrderRoutingEntity instances in the database.</summary>
		public DataSource2<WorkOrderRoutingEntity> WorkOrderRouting
		{
			get { return new DataSource2<WorkOrderRoutingEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		

		/// <summary>returns the datasource to use in a Linq query when targeting SohLinqPoco instances in the database.</summary>
		public DataSource2<AdventureWorks.Dal.Adapter.v52.TypedViewClasses.SohLinqPocoRow> SohLinqPoco
		{
			get { return new DataSource2<AdventureWorks.Dal.Adapter.v52.TypedViewClasses.SohLinqPocoRow>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse) { TypedViewEnumTypeValue=(int)TypedViewType.SohLinqPocoTypedView }; }
		}

		#region Class Property Declarations
		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse
		{
			get { return _adapterToUse;}
			set { _adapterToUse = value;}
		}

		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings
		{
			get { return _customFunctionMappings; }
			set { _customFunctionMappings = value; }
		}
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse
		{
			get { return _contextToUse;}
			set { _contextToUse = value;}
		}
		#endregion
	}
}