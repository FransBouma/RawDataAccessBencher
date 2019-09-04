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
// Code is generated on: woensdag 4 september 2019 12:09:46
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;

namespace LLBL2003.AdventureWorks2008
{

	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Address.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum AddressFieldIndex:int
	{
		AddressID,
		AddressLine1,
		AddressLine2,
		City,
		StateProvinceID,
		PostalCode,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AddressType.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum AddressTypeFieldIndex:int
	{
		AddressTypeID,
		Name,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AWBuildVersion.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum AWBuildVersionFieldIndex:int
	{
		SystemInformationID,
		DatabaseVersion,
		VersionDate,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: BillOfMaterials.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum BillOfMaterialsFieldIndex:int
	{
		BillOfMaterialsID,
		ProductAssemblyID,
		ComponentID,
		StartDate,
		EndDate,
		UnitMeasureCode,
		BOMLevel,
		PerAssemblyQty,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Contact.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ContactFieldIndex:int
	{
		ContactID,
		NameStyle,
		Title,
		FirstName,
		MiddleName,
		LastName,
		Suffix,
		EmailAddress,
		EmailPromotion,
		Phone,
		PasswordHash,
		PasswordSalt,
		AdditionalContactInfo,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ContactCreditCard.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ContactCreditCardFieldIndex:int
	{
		ContactID,
		CreditCardID,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ContactType.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ContactTypeFieldIndex:int
	{
		ContactTypeID,
		Name,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CountryRegion.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CountryRegionFieldIndex:int
	{
		CountryRegionCode,
		Name,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CountryRegionCurrency.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CountryRegionCurrencyFieldIndex:int
	{
		CountryRegionCode,
		CurrencyCode,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CreativeAddresses.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CreativeAddressesFieldIndex:int
	{
		ID,
		City,
		Latitude,
		Longitude,
		LatitudeF,
		LongitudeF,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CreditCard.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CreditCardFieldIndex:int
	{
		CreditCardID,
		CardType,
		CardNumber,
		ExpMonth,
		ExpYear,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Culture.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CultureFieldIndex:int
	{
		CultureID,
		Name,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Currency.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CurrencyFieldIndex:int
	{
		CurrencyCode,
		Name,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CurrencyRate.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CurrencyRateFieldIndex:int
	{
		CurrencyRateID,
		CurrencyRateDate,
		FromCurrencyCode,
		ToCurrencyCode,
		AverageRate,
		EndOfDayRate,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Customer.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CustomerFieldIndex:int
	{
		CustomerID,
		TerritoryID,
		AccountNumber,
		CustomerType,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CustomerAddress.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum CustomerAddressFieldIndex:int
	{
		CustomerID,
		AddressID,
		AddressTypeID,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: DatabaseLog.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum DatabaseLogFieldIndex:int
	{
		DatabaseLogID,
		PostTime,
		DatabaseUser,
		Event,
		Schema,
		Object,
		TSQL,
		XmlEvent,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Department.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum DepartmentFieldIndex:int
	{
		DepartmentID,
		Name,
		GroupName,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Document.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum DocumentFieldIndex:int
	{
		DocumentID,
		Title,
		FileName,
		FileExtension,
		Revision,
		ChangeNumber,
		Status,
		DocumentSummary,
		Document,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Employee.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum EmployeeFieldIndex:int
	{
		EmployeeID,
		NationalIDNumber,
		ContactID,
		LoginID,
		ManagerID,
		Title,
		BirthDate,
		MaritalStatus,
		Gender,
		HireDate,
		SalariedFlag,
		VacationHours,
		SickLeaveHours,
		CurrentFlag,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeeAddress.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum EmployeeAddressFieldIndex:int
	{
		EmployeeID,
		AddressID,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeeDepartmentHistory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum EmployeeDepartmentHistoryFieldIndex:int
	{
		EmployeeID,
		DepartmentID,
		ShiftID,
		StartDate,
		EndDate,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeePayHistory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum EmployeePayHistoryFieldIndex:int
	{
		EmployeeID,
		RateChangeDate,
		Rate,
		PayFrequency,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ErrorLog.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ErrorLogFieldIndex:int
	{
		ErrorLogID,
		ErrorTime,
		UserName,
		ErrorNumber,
		ErrorSeverity,
		ErrorState,
		ErrorProcedure,
		ErrorLine,
		ErrorMessage,
		TesTField,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Illustration.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum IllustrationFieldIndex:int
	{
		IllustrationID,
		Diagram,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Individual.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum IndividualFieldIndex:int
	{
		CustomerID,
		ContactID,
		Demographics,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: JobCandidate.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum JobCandidateFieldIndex:int
	{
		JobCandidateID,
		EmployeeID,
		Resume,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Location.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum LocationFieldIndex:int
	{
		LocationID,
		Name,
		CostRate,
		Availability,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NameTestTab.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum NameTestTabFieldIndex:int
	{
		ID,
		Avg_grade,
		Name,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NewSequentialIDTest.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum NewSequentialIDTestFieldIndex:int
	{
		ID,
		Description,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NonPresentTime.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum NonPresentTimeFieldIndex:int
	{
		ID,
		HeaderID,
		ReasonID,
		DateStart,
		DateEnd,
		Notes,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: NonPresentTimeHeader.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum NonPresentTimeHeaderFieldIndex:int
	{
		ID,
		UserID,
		ApprovedFromID,
		EnteredDate,
		ApprovedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductFieldIndex:int
	{
		ProductID,
		Name,
		ProductNumber,
		MakeFlag,
		FinishedGoodsFlag,
		Color,
		SafetyStockLevel,
		ReorderPoint,
		StandardCost,
		ListPrice,
		Size,
		SizeUnitMeasureCode,
		WeightUnitMeasureCode,
		Weight,
		DaysToManufacture,
		ProductLine,
		Class,
		Style,
		ProductSubcategoryID,
		ProductModelID,
		SellStartDate,
		SellEndDate,
		DiscontinuedDate,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductCategory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductCategoryFieldIndex:int
	{
		ProductCategoryID,
		Name,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductCostHistory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductCostHistoryFieldIndex:int
	{
		ProductID,
		StartDate,
		EndDate,
		StandardCost,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductDescription.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductDescriptionFieldIndex:int
	{
		ProductDescriptionID,
		Description,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductDocument.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductDocumentFieldIndex:int
	{
		ProductID,
		DocumentID,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductInventory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductInventoryFieldIndex:int
	{
		ProductID,
		LocationID,
		Shelf,
		Bin,
		Quantity,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductListPriceHistory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductListPriceHistoryFieldIndex:int
	{
		ProductID,
		StartDate,
		EndDate,
		ListPrice,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModel.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductModelFieldIndex:int
	{
		ProductModelID,
		Name,
		CatalogDescription,
		Instructions,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModelIllustration.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductModelIllustrationFieldIndex:int
	{
		ProductModelID,
		IllustrationID,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModelProductDescriptionCulture.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductModelProductDescriptionCultureFieldIndex:int
	{
		ProductModelID,
		ProductDescriptionID,
		CultureID,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductPhoto.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductPhotoFieldIndex:int
	{
		ProductPhotoID,
		ThumbNailPhoto,
		ThumbnailPhotoFileName,
		LargePhoto,
		LargePhotoFileName,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductProductPhoto.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductProductPhotoFieldIndex:int
	{
		ProductID,
		ProductPhotoID,
		Primary,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductReview.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductReviewFieldIndex:int
	{
		ProductReviewID,
		ProductID,
		ReviewerName,
		ReviewDate,
		EmailAddress,
		Rating,
		Comments,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductSubcategory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductSubcategoryFieldIndex:int
	{
		ProductSubcategoryID,
		ProductCategoryID,
		Name,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductVendor.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ProductVendorFieldIndex:int
	{
		ProductID,
		VendorID,
		AverageLeadTime,
		StandardPrice,
		LastReceiptCost,
		LastReceiptDate,
		MinOrderQty,
		MaxOrderQty,
		OnOrderQty,
		UnitMeasureCode,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PurchaseOrderDetail.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum PurchaseOrderDetailFieldIndex:int
	{
		PurchaseOrderID,
		PurchaseOrderDetailID,
		DueDate,
		OrderQty,
		ProductID,
		UnitPrice,
		LineTotal,
		ReceivedQty,
		RejectedQty,
		StockedQty,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PurchaseOrderHeader.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum PurchaseOrderHeaderFieldIndex:int
	{
		PurchaseOrderID,
		RevisionNumber,
		Status,
		EmployeeID,
		VendorID,
		ShipMethodID,
		OrderDate,
		ShipDate,
		SubTotal,
		TaxAmt,
		Freight,
		TotalDue,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Reason.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ReasonFieldIndex:int
	{
		ID,
		Reason,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderDetail.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesOrderDetailFieldIndex:int
	{
		SalesOrderID,
		SalesOrderDetailID,
		CarrierTrackingNumber,
		OrderQty,
		ProductID,
		SpecialOfferID,
		UnitPrice,
		UnitPriceDiscount,
		LineTotal,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderHeader.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesOrderHeaderFieldIndex:int
	{
		SalesOrderID,
		RevisionNumber,
		OrderDate,
		DueDate,
		ShipDate,
		Status,
		OnlineOrderFlag,
		SalesOrderNumber,
		PurchaseOrderNumber,
		AccountNumber,
		CustomerID,
		SalesPersonID,
		TerritoryID,
		BillToAddressID,
		ShipToAddressID,
		ShipMethodID,
		CreditCardID,
		CreditCardApprovalCode,
		CurrencyRateID,
		SubTotal,
		TaxAmt,
		Freight,
		TotalDue,
		Comment,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderHeaderSalesReason.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesOrderHeaderSalesReasonFieldIndex:int
	{
		SalesOrderID,
		SalesReasonID,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesPerson.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesPersonFieldIndex:int
	{
		SalesPersonID,
		TerritoryID,
		SalesQuota,
		Bonus,
		CommissionPct,
		SalesYTD,
		SalesLastYear,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesPersonQuotaHistory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesPersonQuotaHistoryFieldIndex:int
	{
		SalesPersonID,
		QuotaDate,
		SalesQuota,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesReason.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesReasonFieldIndex:int
	{
		SalesReasonID,
		Name,
		ReasonType,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTaxRate.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesTaxRateFieldIndex:int
	{
		SalesTaxRateID,
		StateProvinceID,
		TaxType,
		TaxRate,
		Name,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTerritory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesTerritoryFieldIndex:int
	{
		TerritoryID,
		Name,
		CountryRegionCode,
		Group,
		SalesYTD,
		SalesLastYear,
		CostYTD,
		CostLastYear,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTerritoryHistory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SalesTerritoryHistoryFieldIndex:int
	{
		SalesPersonID,
		TerritoryID,
		StartDate,
		EndDate,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ScrapReason.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ScrapReasonFieldIndex:int
	{
		ScrapReasonID,
		Name,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SequentialIDSubType.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SequentialIDSubTypeFieldIndex:int
	{
		ID,
		IntValue,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Shift.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ShiftFieldIndex:int
	{
		ShiftID,
		Name,
		StartTime,
		EndTime,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ShipMethod.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ShipMethodFieldIndex:int
	{
		ShipMethodID,
		Name,
		ShipBase,
		ShipRate,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ShoppingCartItem.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum ShoppingCartItemFieldIndex:int
	{
		ShoppingCartItemID,
		ShoppingCartID,
		Quantity,
		ProductID,
		DateCreated,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOffer.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SpecialOfferFieldIndex:int
	{
		SpecialOfferID,
		Description,
		DiscountPct,
		Type,
		Category,
		StartDate,
		EndDate,
		MinQty,
		MaxQty,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOfferProduct.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum SpecialOfferProductFieldIndex:int
	{
		SpecialOfferID,
		ProductID,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: StateProvince.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum StateProvinceFieldIndex:int
	{
		StateProvinceID,
		StateProvinceCode,
		CountryRegionCode,
		IsOnlyStateProvinceFlag,
		Name,
		TerritoryID,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Store.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum StoreFieldIndex:int
	{
		CustomerID,
		Name,
		SalesPersonID,
		Demographics,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: StoreContact.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum StoreContactFieldIndex:int
	{
		CustomerID,
		ContactID,
		ContactTypeID,
		Rowguid,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TransactionHistory.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum TransactionHistoryFieldIndex:int
	{
		TransactionID,
		ProductID,
		ReferenceOrderID,
		ReferenceOrderLineID,
		TransactionDate,
		TransactionType,
		Quantity,
		ActualCost,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TransactionHistoryArchive.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum TransactionHistoryArchiveFieldIndex:int
	{
		TransactionID,
		ProductID,
		ReferenceOrderID,
		ReferenceOrderLineID,
		TransactionDate,
		TransactionType,
		Quantity,
		ActualCost,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UdtTest.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum UdtTestFieldIndex:int
	{
		ID,
		UdtField,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UnitMeasure.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum UnitMeasureFieldIndex:int
	{
		UnitMeasureCode,
		Name,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UserDetail.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum UserDetailFieldIndex:int
	{
		ID,
		UserName,
		SignaturePicPath,
		FullName,
		EmployeeNr,
		Department,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Vendor.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum VendorFieldIndex:int
	{
		VendorID,
		AccountNumber,
		Name,
		CreditRating,
		PreferredVendorStatus,
		ActiveFlag,
		PurchasingWebServiceURL,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: VendorAddress.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum VendorAddressFieldIndex:int
	{
		VendorID,
		AddressID,
		AddressTypeID,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: VendorContact.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum VendorContactFieldIndex:int
	{
		VendorID,
		ContactID,
		ContactTypeID,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrder.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum WorkOrderFieldIndex:int
	{
		WorkOrderID,
		ProductID,
		OrderQty,
		StockedQty,
		ScrappedQty,
		StartDate,
		EndDate,
		DueDate,
		ScrapReasonID,
		ModifiedDate,
		AmountOfFields
	}


	/// <summary>
	/// Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrderRouting.
	/// Auto-generated, do not modify.
	/// </summary>
	public enum WorkOrderRoutingFieldIndex:int
	{
		WorkOrderID,
		ProductID,
		OperationSequence,
		LocationID,
		ScheduledStartDate,
		ScheduledEndDate,
		ActualStartDate,
		ActualEndDate,
		ActualResourceHrs,
		PlannedCost,
		ActualCost,
		ModifiedDate,
		AmountOfFields
	}




	/// <summary>
	/// Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.
	/// </summary>
	public enum EntityType:int
	{
		AddressEntity,
		AddressTypeEntity,
		AWBuildVersionEntity,
		BillOfMaterialsEntity,
		ContactEntity,
		ContactCreditCardEntity,
		ContactTypeEntity,
		CountryRegionEntity,
		CountryRegionCurrencyEntity,
		CreativeAddressesEntity,
		CreditCardEntity,
		CultureEntity,
		CurrencyEntity,
		CurrencyRateEntity,
		CustomerEntity,
		CustomerAddressEntity,
		DatabaseLogEntity,
		DepartmentEntity,
		DocumentEntity,
		EmployeeEntity,
		EmployeeAddressEntity,
		EmployeeDepartmentHistoryEntity,
		EmployeePayHistoryEntity,
		ErrorLogEntity,
		IllustrationEntity,
		IndividualEntity,
		JobCandidateEntity,
		LocationEntity,
		NameTestTabEntity,
		NewSequentialIDTestEntity,
		NonPresentTimeEntity,
		NonPresentTimeHeaderEntity,
		ProductEntity,
		ProductCategoryEntity,
		ProductCostHistoryEntity,
		ProductDescriptionEntity,
		ProductDocumentEntity,
		ProductInventoryEntity,
		ProductListPriceHistoryEntity,
		ProductModelEntity,
		ProductModelIllustrationEntity,
		ProductModelProductDescriptionCultureEntity,
		ProductPhotoEntity,
		ProductProductPhotoEntity,
		ProductReviewEntity,
		ProductSubcategoryEntity,
		ProductVendorEntity,
		PurchaseOrderDetailEntity,
		PurchaseOrderHeaderEntity,
		ReasonEntity,
		SalesOrderDetailEntity,
		SalesOrderHeaderEntity,
		SalesOrderHeaderSalesReasonEntity,
		SalesPersonEntity,
		SalesPersonQuotaHistoryEntity,
		SalesReasonEntity,
		SalesTaxRateEntity,
		SalesTerritoryEntity,
		SalesTerritoryHistoryEntity,
		ScrapReasonEntity,
		SequentialIDSubTypeEntity,
		ShiftEntity,
		ShipMethodEntity,
		ShoppingCartItemEntity,
		SpecialOfferEntity,
		SpecialOfferProductEntity,
		StateProvinceEntity,
		StoreEntity,
		StoreContactEntity,
		TransactionHistoryEntity,
		TransactionHistoryArchiveEntity,
		UdtTestEntity,
		UnitMeasureEntity,
		UserDetailEntity,
		VendorEntity,
		VendorAddressEntity,
		VendorContactEntity,
		WorkOrderEntity,
		WorkOrderRoutingEntity
	}



}


