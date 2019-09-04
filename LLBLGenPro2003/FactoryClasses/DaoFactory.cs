///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//
// Do not try to run this code on another version of the database than the database
// which was used to generate this code. This means that when you used f.e. SqlServer 2000
// to generate this code, it is likely that you will not be able to use that code on
// SqlServer 7 due to SQL syntax mismatches. Most code is generic code which will work
// with any database, but some code relies on a specific database type/vendor/version used. 
// This code is located in the DaoClasses which target a specific specified database. Also all
// classes target a specific specified Dynamic Query Engine (DQE) in the using/imports
// directives. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2003.1
// Code is generated on: woensdag 4 september 2019 12:09:45
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;

using LLBL2003.AdventureWorks2008.DaoClasses;
using LLBL2003.AdventureWorks2008.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.FactoryClasses
{
	/// <summary>
	/// Generic factory for DAO objects. 
	/// </summary>
	public class DAOFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private DAOFactory()
		{
		}

	
		/// <summary>
		/// Creates a new AddressDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Address Entities</returns>
		public static AddressDAO CreateAddressDAO()
		{
			AddressDAO valueToReturn = new AddressDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new AddressTypeDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for AddressType Entities</returns>
		public static AddressTypeDAO CreateAddressTypeDAO()
		{
			AddressTypeDAO valueToReturn = new AddressTypeDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new AWBuildVersionDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for AWBuildVersion Entities</returns>
		public static AWBuildVersionDAO CreateAWBuildVersionDAO()
		{
			AWBuildVersionDAO valueToReturn = new AWBuildVersionDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new BillOfMaterialsDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for BillOfMaterials Entities</returns>
		public static BillOfMaterialsDAO CreateBillOfMaterialsDAO()
		{
			BillOfMaterialsDAO valueToReturn = new BillOfMaterialsDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ContactDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Contact Entities</returns>
		public static ContactDAO CreateContactDAO()
		{
			ContactDAO valueToReturn = new ContactDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ContactCreditCardDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ContactCreditCard Entities</returns>
		public static ContactCreditCardDAO CreateContactCreditCardDAO()
		{
			ContactCreditCardDAO valueToReturn = new ContactCreditCardDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ContactTypeDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ContactType Entities</returns>
		public static ContactTypeDAO CreateContactTypeDAO()
		{
			ContactTypeDAO valueToReturn = new ContactTypeDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CountryRegionDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for CountryRegion Entities</returns>
		public static CountryRegionDAO CreateCountryRegionDAO()
		{
			CountryRegionDAO valueToReturn = new CountryRegionDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CountryRegionCurrencyDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for CountryRegionCurrency Entities</returns>
		public static CountryRegionCurrencyDAO CreateCountryRegionCurrencyDAO()
		{
			CountryRegionCurrencyDAO valueToReturn = new CountryRegionCurrencyDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CreativeAddressesDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for CreativeAddresses Entities</returns>
		public static CreativeAddressesDAO CreateCreativeAddressesDAO()
		{
			CreativeAddressesDAO valueToReturn = new CreativeAddressesDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CreditCardDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for CreditCard Entities</returns>
		public static CreditCardDAO CreateCreditCardDAO()
		{
			CreditCardDAO valueToReturn = new CreditCardDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CultureDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Culture Entities</returns>
		public static CultureDAO CreateCultureDAO()
		{
			CultureDAO valueToReturn = new CultureDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CurrencyDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Currency Entities</returns>
		public static CurrencyDAO CreateCurrencyDAO()
		{
			CurrencyDAO valueToReturn = new CurrencyDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CurrencyRateDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for CurrencyRate Entities</returns>
		public static CurrencyRateDAO CreateCurrencyRateDAO()
		{
			CurrencyRateDAO valueToReturn = new CurrencyRateDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CustomerDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Customer Entities</returns>
		public static CustomerDAO CreateCustomerDAO()
		{
			CustomerDAO valueToReturn = new CustomerDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new CustomerAddressDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for CustomerAddress Entities</returns>
		public static CustomerAddressDAO CreateCustomerAddressDAO()
		{
			CustomerAddressDAO valueToReturn = new CustomerAddressDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new DatabaseLogDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for DatabaseLog Entities</returns>
		public static DatabaseLogDAO CreateDatabaseLogDAO()
		{
			DatabaseLogDAO valueToReturn = new DatabaseLogDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new DepartmentDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Department Entities</returns>
		public static DepartmentDAO CreateDepartmentDAO()
		{
			DepartmentDAO valueToReturn = new DepartmentDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new DocumentDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Document Entities</returns>
		public static DocumentDAO CreateDocumentDAO()
		{
			DocumentDAO valueToReturn = new DocumentDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new EmployeeDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Employee Entities</returns>
		public static EmployeeDAO CreateEmployeeDAO()
		{
			EmployeeDAO valueToReturn = new EmployeeDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new EmployeeAddressDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for EmployeeAddress Entities</returns>
		public static EmployeeAddressDAO CreateEmployeeAddressDAO()
		{
			EmployeeAddressDAO valueToReturn = new EmployeeAddressDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new EmployeeDepartmentHistoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for EmployeeDepartmentHistory Entities</returns>
		public static EmployeeDepartmentHistoryDAO CreateEmployeeDepartmentHistoryDAO()
		{
			EmployeeDepartmentHistoryDAO valueToReturn = new EmployeeDepartmentHistoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new EmployeePayHistoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for EmployeePayHistory Entities</returns>
		public static EmployeePayHistoryDAO CreateEmployeePayHistoryDAO()
		{
			EmployeePayHistoryDAO valueToReturn = new EmployeePayHistoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ErrorLogDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ErrorLog Entities</returns>
		public static ErrorLogDAO CreateErrorLogDAO()
		{
			ErrorLogDAO valueToReturn = new ErrorLogDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new IllustrationDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Illustration Entities</returns>
		public static IllustrationDAO CreateIllustrationDAO()
		{
			IllustrationDAO valueToReturn = new IllustrationDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new IndividualDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Individual Entities</returns>
		public static IndividualDAO CreateIndividualDAO()
		{
			IndividualDAO valueToReturn = new IndividualDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new JobCandidateDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for JobCandidate Entities</returns>
		public static JobCandidateDAO CreateJobCandidateDAO()
		{
			JobCandidateDAO valueToReturn = new JobCandidateDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new LocationDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Location Entities</returns>
		public static LocationDAO CreateLocationDAO()
		{
			LocationDAO valueToReturn = new LocationDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new NameTestTabDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for NameTestTab Entities</returns>
		public static NameTestTabDAO CreateNameTestTabDAO()
		{
			NameTestTabDAO valueToReturn = new NameTestTabDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new NewSequentialIDTestDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for NewSequentialIDTest Entities</returns>
		public static NewSequentialIDTestDAO CreateNewSequentialIDTestDAO()
		{
			NewSequentialIDTestDAO valueToReturn = new NewSequentialIDTestDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new NonPresentTimeDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for NonPresentTime Entities</returns>
		public static NonPresentTimeDAO CreateNonPresentTimeDAO()
		{
			NonPresentTimeDAO valueToReturn = new NonPresentTimeDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new NonPresentTimeHeaderDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for NonPresentTimeHeader Entities</returns>
		public static NonPresentTimeHeaderDAO CreateNonPresentTimeHeaderDAO()
		{
			NonPresentTimeHeaderDAO valueToReturn = new NonPresentTimeHeaderDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Product Entities</returns>
		public static ProductDAO CreateProductDAO()
		{
			ProductDAO valueToReturn = new ProductDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductCategoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductCategory Entities</returns>
		public static ProductCategoryDAO CreateProductCategoryDAO()
		{
			ProductCategoryDAO valueToReturn = new ProductCategoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductCostHistoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductCostHistory Entities</returns>
		public static ProductCostHistoryDAO CreateProductCostHistoryDAO()
		{
			ProductCostHistoryDAO valueToReturn = new ProductCostHistoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductDescriptionDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductDescription Entities</returns>
		public static ProductDescriptionDAO CreateProductDescriptionDAO()
		{
			ProductDescriptionDAO valueToReturn = new ProductDescriptionDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductDocumentDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductDocument Entities</returns>
		public static ProductDocumentDAO CreateProductDocumentDAO()
		{
			ProductDocumentDAO valueToReturn = new ProductDocumentDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductInventoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductInventory Entities</returns>
		public static ProductInventoryDAO CreateProductInventoryDAO()
		{
			ProductInventoryDAO valueToReturn = new ProductInventoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductListPriceHistoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductListPriceHistory Entities</returns>
		public static ProductListPriceHistoryDAO CreateProductListPriceHistoryDAO()
		{
			ProductListPriceHistoryDAO valueToReturn = new ProductListPriceHistoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductModelDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductModel Entities</returns>
		public static ProductModelDAO CreateProductModelDAO()
		{
			ProductModelDAO valueToReturn = new ProductModelDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductModelIllustrationDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductModelIllustration Entities</returns>
		public static ProductModelIllustrationDAO CreateProductModelIllustrationDAO()
		{
			ProductModelIllustrationDAO valueToReturn = new ProductModelIllustrationDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductModelProductDescriptionCultureDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductModelProductDescriptionCulture Entities</returns>
		public static ProductModelProductDescriptionCultureDAO CreateProductModelProductDescriptionCultureDAO()
		{
			ProductModelProductDescriptionCultureDAO valueToReturn = new ProductModelProductDescriptionCultureDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductPhotoDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductPhoto Entities</returns>
		public static ProductPhotoDAO CreateProductPhotoDAO()
		{
			ProductPhotoDAO valueToReturn = new ProductPhotoDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductProductPhotoDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductProductPhoto Entities</returns>
		public static ProductProductPhotoDAO CreateProductProductPhotoDAO()
		{
			ProductProductPhotoDAO valueToReturn = new ProductProductPhotoDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductReviewDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductReview Entities</returns>
		public static ProductReviewDAO CreateProductReviewDAO()
		{
			ProductReviewDAO valueToReturn = new ProductReviewDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductSubcategoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductSubcategory Entities</returns>
		public static ProductSubcategoryDAO CreateProductSubcategoryDAO()
		{
			ProductSubcategoryDAO valueToReturn = new ProductSubcategoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ProductVendorDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ProductVendor Entities</returns>
		public static ProductVendorDAO CreateProductVendorDAO()
		{
			ProductVendorDAO valueToReturn = new ProductVendorDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new PurchaseOrderDetailDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for PurchaseOrderDetail Entities</returns>
		public static PurchaseOrderDetailDAO CreatePurchaseOrderDetailDAO()
		{
			PurchaseOrderDetailDAO valueToReturn = new PurchaseOrderDetailDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new PurchaseOrderHeaderDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for PurchaseOrderHeader Entities</returns>
		public static PurchaseOrderHeaderDAO CreatePurchaseOrderHeaderDAO()
		{
			PurchaseOrderHeaderDAO valueToReturn = new PurchaseOrderHeaderDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ReasonDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Reason Entities</returns>
		public static ReasonDAO CreateReasonDAO()
		{
			ReasonDAO valueToReturn = new ReasonDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesOrderDetailDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesOrderDetail Entities</returns>
		public static SalesOrderDetailDAO CreateSalesOrderDetailDAO()
		{
			SalesOrderDetailDAO valueToReturn = new SalesOrderDetailDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesOrderHeaderDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesOrderHeader Entities</returns>
		public static SalesOrderHeaderDAO CreateSalesOrderHeaderDAO()
		{
			SalesOrderHeaderDAO valueToReturn = new SalesOrderHeaderDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesOrderHeaderSalesReasonDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesOrderHeaderSalesReason Entities</returns>
		public static SalesOrderHeaderSalesReasonDAO CreateSalesOrderHeaderSalesReasonDAO()
		{
			SalesOrderHeaderSalesReasonDAO valueToReturn = new SalesOrderHeaderSalesReasonDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesPersonDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesPerson Entities</returns>
		public static SalesPersonDAO CreateSalesPersonDAO()
		{
			SalesPersonDAO valueToReturn = new SalesPersonDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesPersonQuotaHistoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesPersonQuotaHistory Entities</returns>
		public static SalesPersonQuotaHistoryDAO CreateSalesPersonQuotaHistoryDAO()
		{
			SalesPersonQuotaHistoryDAO valueToReturn = new SalesPersonQuotaHistoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesReasonDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesReason Entities</returns>
		public static SalesReasonDAO CreateSalesReasonDAO()
		{
			SalesReasonDAO valueToReturn = new SalesReasonDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesTaxRateDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesTaxRate Entities</returns>
		public static SalesTaxRateDAO CreateSalesTaxRateDAO()
		{
			SalesTaxRateDAO valueToReturn = new SalesTaxRateDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesTerritoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesTerritory Entities</returns>
		public static SalesTerritoryDAO CreateSalesTerritoryDAO()
		{
			SalesTerritoryDAO valueToReturn = new SalesTerritoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SalesTerritoryHistoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SalesTerritoryHistory Entities</returns>
		public static SalesTerritoryHistoryDAO CreateSalesTerritoryHistoryDAO()
		{
			SalesTerritoryHistoryDAO valueToReturn = new SalesTerritoryHistoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ScrapReasonDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ScrapReason Entities</returns>
		public static ScrapReasonDAO CreateScrapReasonDAO()
		{
			ScrapReasonDAO valueToReturn = new ScrapReasonDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SequentialIDSubTypeDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SequentialIDSubType Entities</returns>
		public static SequentialIDSubTypeDAO CreateSequentialIDSubTypeDAO()
		{
			SequentialIDSubTypeDAO valueToReturn = new SequentialIDSubTypeDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ShiftDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Shift Entities</returns>
		public static ShiftDAO CreateShiftDAO()
		{
			ShiftDAO valueToReturn = new ShiftDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ShipMethodDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ShipMethod Entities</returns>
		public static ShipMethodDAO CreateShipMethodDAO()
		{
			ShipMethodDAO valueToReturn = new ShipMethodDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new ShoppingCartItemDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for ShoppingCartItem Entities</returns>
		public static ShoppingCartItemDAO CreateShoppingCartItemDAO()
		{
			ShoppingCartItemDAO valueToReturn = new ShoppingCartItemDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SpecialOfferDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SpecialOffer Entities</returns>
		public static SpecialOfferDAO CreateSpecialOfferDAO()
		{
			SpecialOfferDAO valueToReturn = new SpecialOfferDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new SpecialOfferProductDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for SpecialOfferProduct Entities</returns>
		public static SpecialOfferProductDAO CreateSpecialOfferProductDAO()
		{
			SpecialOfferProductDAO valueToReturn = new SpecialOfferProductDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new StateProvinceDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for StateProvince Entities</returns>
		public static StateProvinceDAO CreateStateProvinceDAO()
		{
			StateProvinceDAO valueToReturn = new StateProvinceDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new StoreDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Store Entities</returns>
		public static StoreDAO CreateStoreDAO()
		{
			StoreDAO valueToReturn = new StoreDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new StoreContactDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for StoreContact Entities</returns>
		public static StoreContactDAO CreateStoreContactDAO()
		{
			StoreContactDAO valueToReturn = new StoreContactDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new TransactionHistoryDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for TransactionHistory Entities</returns>
		public static TransactionHistoryDAO CreateTransactionHistoryDAO()
		{
			TransactionHistoryDAO valueToReturn = new TransactionHistoryDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new TransactionHistoryArchiveDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for TransactionHistoryArchive Entities</returns>
		public static TransactionHistoryArchiveDAO CreateTransactionHistoryArchiveDAO()
		{
			TransactionHistoryArchiveDAO valueToReturn = new TransactionHistoryArchiveDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new UdtTestDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for UdtTest Entities</returns>
		public static UdtTestDAO CreateUdtTestDAO()
		{
			UdtTestDAO valueToReturn = new UdtTestDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new UnitMeasureDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for UnitMeasure Entities</returns>
		public static UnitMeasureDAO CreateUnitMeasureDAO()
		{
			UnitMeasureDAO valueToReturn = new UnitMeasureDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new UserDetailDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for UserDetail Entities</returns>
		public static UserDetailDAO CreateUserDetailDAO()
		{
			UserDetailDAO valueToReturn = new UserDetailDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new VendorDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for Vendor Entities</returns>
		public static VendorDAO CreateVendorDAO()
		{
			VendorDAO valueToReturn = new VendorDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new VendorAddressDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for VendorAddress Entities</returns>
		public static VendorAddressDAO CreateVendorAddressDAO()
		{
			VendorAddressDAO valueToReturn = new VendorAddressDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new VendorContactDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for VendorContact Entities</returns>
		public static VendorContactDAO CreateVendorContactDAO()
		{
			VendorContactDAO valueToReturn = new VendorContactDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new WorkOrderDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for WorkOrder Entities</returns>
		public static WorkOrderDAO CreateWorkOrderDAO()
		{
			WorkOrderDAO valueToReturn = new WorkOrderDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	
		/// <summary>
		/// Creates a new WorkOrderRoutingDAO object
		/// </summary>
		/// <returns>the new DAO object ready to use for WorkOrderRouting Entities</returns>
		public static WorkOrderRoutingDAO CreateWorkOrderRoutingDAO()
		{
			WorkOrderRoutingDAO valueToReturn = new WorkOrderRoutingDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	

		/// <summary>
		/// Creates a new TypedListDAO object
		/// </summary>
		/// <returns>The new DAO object ready to use for Typed Lists</returns>
		public static TypedListDAO CreateTypedListDAO()
		{
			TypedListDAO valueToReturn = new TypedListDAO();
			valueToReturn.TypeDefaultValueSupplier = new TypeDefaultValue();
			return valueToReturn;
		}
	}
}
