///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

using AdventureWorks.Dal.Adapter.v41;
using AdventureWorks.Dal.Adapter.v41.EntityClasses;
using AdventureWorks.Dal.Adapter.v41.FactoryClasses;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using AdventureWorks.Dal.Adapter.v41.RelationClasses;

namespace AdventureWorks.Dal.Adapter.v41.Linq
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
			switch((AdventureWorks.Dal.Adapter.v41.EntityType)typeOfEntity)
			{
				case AdventureWorks.Dal.Adapter.v41.EntityType.AddressEntity:
					toReturn = this.Address;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.AddressTypeEntity:
					toReturn = this.AddressType;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.BillOfMaterialEntity:
					toReturn = this.BillOfMaterial;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ContactEntity:
					toReturn = this.Contact;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ContactCreditCardEntity:
					toReturn = this.ContactCreditCard;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ContactTypeEntity:
					toReturn = this.ContactType;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CountryRegionEntity:
					toReturn = this.CountryRegion;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CountryRegionCurrencyEntity:
					toReturn = this.CountryRegionCurrency;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CreditCardEntity:
					toReturn = this.CreditCard;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CultureEntity:
					toReturn = this.Culture;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CurrencyEntity:
					toReturn = this.Currency;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CurrencyRateEntity:
					toReturn = this.CurrencyRate;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CustomerEntity:
					toReturn = this.Customer;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.CustomerAddressEntity:
					toReturn = this.CustomerAddress;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.DepartmentEntity:
					toReturn = this.Department;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.DocumentEntity:
					toReturn = this.Document;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.EmployeeEntity:
					toReturn = this.Employee;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.EmployeeAddressEntity:
					toReturn = this.EmployeeAddress;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.EmployeeDepartmentHistoryEntity:
					toReturn = this.EmployeeDepartmentHistory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.EmployeePayHistoryEntity:
					toReturn = this.EmployeePayHistory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.IllustrationEntity:
					toReturn = this.Illustration;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.IndividualEntity:
					toReturn = this.Individual;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.JobCandidateEntity:
					toReturn = this.JobCandidate;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.LocationEntity:
					toReturn = this.Location;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductEntity:
					toReturn = this.Product;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductCategoryEntity:
					toReturn = this.ProductCategory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductCostHistoryEntity:
					toReturn = this.ProductCostHistory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductDescriptionEntity:
					toReturn = this.ProductDescription;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductDocumentEntity:
					toReturn = this.ProductDocument;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductInventoryEntity:
					toReturn = this.ProductInventory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductListPriceHistoryEntity:
					toReturn = this.ProductListPriceHistory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelEntity:
					toReturn = this.ProductModel;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelIllustrationEntity:
					toReturn = this.ProductModelIllustration;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductModelProductDescriptionCultureEntity:
					toReturn = this.ProductModelProductDescriptionCulture;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductPhotoEntity:
					toReturn = this.ProductPhoto;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductProductPhotoEntity:
					toReturn = this.ProductProductPhoto;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductReviewEntity:
					toReturn = this.ProductReview;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductSubcategoryEntity:
					toReturn = this.ProductSubcategory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ProductVendorEntity:
					toReturn = this.ProductVendor;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.PurchaseOrderDetailEntity:
					toReturn = this.PurchaseOrderDetail;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.PurchaseOrderHeaderEntity:
					toReturn = this.PurchaseOrderHeader;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderDetailEntity:
					toReturn = this.SalesOrderDetail;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderHeaderEntity:
					toReturn = this.SalesOrderHeader;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesOrderHeaderSalesReasonEntity:
					toReturn = this.SalesOrderHeaderSalesReason;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesPersonEntity:
					toReturn = this.SalesPerson;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesPersonQuotaHistoryEntity:
					toReturn = this.SalesPersonQuotaHistory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesReasonEntity:
					toReturn = this.SalesReason;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesTaxRateEntity:
					toReturn = this.SalesTaxRate;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesTerritoryEntity:
					toReturn = this.SalesTerritory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SalesTerritoryHistoryEntity:
					toReturn = this.SalesTerritoryHistory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ScrapReasonEntity:
					toReturn = this.ScrapReason;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ShiftEntity:
					toReturn = this.Shift;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ShipMethodEntity:
					toReturn = this.ShipMethod;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.ShoppingCartItemEntity:
					toReturn = this.ShoppingCartItem;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SpecialOfferEntity:
					toReturn = this.SpecialOffer;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.SpecialOfferProductEntity:
					toReturn = this.SpecialOfferProduct;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.StateProvinceEntity:
					toReturn = this.StateProvince;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.StoreEntity:
					toReturn = this.Store;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.StoreContactEntity:
					toReturn = this.StoreContact;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.TransactionHistoryEntity:
					toReturn = this.TransactionHistory;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.TransactionHistoryArchiveEntity:
					toReturn = this.TransactionHistoryArchive;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.UnitMeasureEntity:
					toReturn = this.UnitMeasure;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.VendorEntity:
					toReturn = this.Vendor;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.VendorAddressEntity:
					toReturn = this.VendorAddress;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.VendorContactEntity:
					toReturn = this.VendorContact;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.WorkOrderEntity:
					toReturn = this.WorkOrder;
					break;
				case AdventureWorks.Dal.Adapter.v41.EntityType.WorkOrderRoutingEntity:
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
		
		/// <summary>returns the datasource to use in a Linq query when targeting ContactEntity instances in the database.</summary>
		public DataSource2<ContactEntity> Contact
		{
			get { return new DataSource2<ContactEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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
		
		/// <summary>returns the datasource to use in a Linq query when targeting CustomerAddressEntity instances in the database.</summary>
		public DataSource2<CustomerAddressEntity> CustomerAddress
		{
			get { return new DataSource2<CustomerAddressEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeEntity instances in the database.</summary>
		public DataSource2<EmployeeEntity> Employee
		{
			get { return new DataSource2<EmployeeEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting EmployeeAddressEntity instances in the database.</summary>
		public DataSource2<EmployeeAddressEntity> EmployeeAddress
		{
			get { return new DataSource2<EmployeeAddressEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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
		
		/// <summary>returns the datasource to use in a Linq query when targeting IndividualEntity instances in the database.</summary>
		public DataSource2<IndividualEntity> Individual
		{
			get { return new DataSource2<IndividualEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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
		
		/// <summary>returns the datasource to use in a Linq query when targeting StoreContactEntity instances in the database.</summary>
		public DataSource2<StoreContactEntity> StoreContact
		{
			get { return new DataSource2<StoreContactEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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
		
		/// <summary>returns the datasource to use in a Linq query when targeting VendorAddressEntity instances in the database.</summary>
		public DataSource2<VendorAddressEntity> VendorAddress
		{
			get { return new DataSource2<VendorAddressEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
		}
		
		/// <summary>returns the datasource to use in a Linq query when targeting VendorContactEntity instances in the database.</summary>
		public DataSource2<VendorContactEntity> VendorContact
		{
			get { return new DataSource2<VendorContactEntity>(_adapterToUse, new ElementCreator(), _customFunctionMappings, _contextToUse); }
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