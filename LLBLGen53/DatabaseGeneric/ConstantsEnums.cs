///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.3
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

namespace AdventureWorks.Dal.Adapter.v53
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Address.</summary>
	public enum AddressFieldIndex
	{
		///<summary>AddressId. </summary>
		AddressId,
		///<summary>AddressLine1. </summary>
		AddressLine1,
		///<summary>AddressLine2. </summary>
		AddressLine2,
		///<summary>City. </summary>
		City,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PostalCode. </summary>
		PostalCode,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SpatialLocation. </summary>
		SpatialLocation,
		///<summary>StateProvinceId. </summary>
		StateProvinceId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AddressType.</summary>
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
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: BillOfMaterial.</summary>
	public enum BillOfMaterialFieldIndex
	{
		///<summary>BillOfMaterialsId. </summary>
		BillOfMaterialsId,
		///<summary>Bomlevel. </summary>
		Bomlevel,
		///<summary>ComponentId. </summary>
		ComponentId,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PerAssemblyQty. </summary>
		PerAssemblyQty,
		///<summary>ProductAssemblyId. </summary>
		ProductAssemblyId,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>UnitMeasureCode. </summary>
		UnitMeasureCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: BusinessEntity.</summary>
	public enum BusinessEntityFieldIndex
	{
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: BusinessEntityAddress.</summary>
	public enum BusinessEntityAddressFieldIndex
	{
		///<summary>AddressId. </summary>
		AddressId,
		///<summary>AddressTypeId. </summary>
		AddressTypeId,
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: BusinessEntityContact.</summary>
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
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ContactCreditCard.</summary>
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
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ContactType.</summary>
	public enum ContactTypeFieldIndex
	{
		///<summary>ContactTypeId. </summary>
		ContactTypeId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CountryRegion.</summary>
	public enum CountryRegionFieldIndex
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CountryRegionCurrency.</summary>
	public enum CountryRegionCurrencyFieldIndex
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>CurrencyCode. </summary>
		CurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CreditCard.</summary>
	public enum CreditCardFieldIndex
	{
		///<summary>CardNumber. </summary>
		CardNumber,
		///<summary>CardType. </summary>
		CardType,
		///<summary>CreditCardId. </summary>
		CreditCardId,
		///<summary>ExpMonth. </summary>
		ExpMonth,
		///<summary>ExpYear. </summary>
		ExpYear,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Culture.</summary>
	public enum CultureFieldIndex
	{
		///<summary>CultureId. </summary>
		CultureId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Currency.</summary>
	public enum CurrencyFieldIndex
	{
		///<summary>CurrencyCode. </summary>
		CurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: CurrencyRate.</summary>
	public enum CurrencyRateFieldIndex
	{
		///<summary>AverageRate. </summary>
		AverageRate,
		///<summary>CurrencyRateDate. </summary>
		CurrencyRateDate,
		///<summary>CurrencyRateId. </summary>
		CurrencyRateId,
		///<summary>EndOfDayRate. </summary>
		EndOfDayRate,
		///<summary>FromCurrencyCode. </summary>
		FromCurrencyCode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ToCurrencyCode. </summary>
		ToCurrencyCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Customer.</summary>
	public enum CustomerFieldIndex
	{
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PersonId. </summary>
		PersonId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>StoreId. </summary>
		StoreId,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Department.</summary>
	public enum DepartmentFieldIndex
	{
		///<summary>DepartmentId. </summary>
		DepartmentId,
		///<summary>GroupName. </summary>
		GroupName,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Document.</summary>
	public enum DocumentFieldIndex
	{
		///<summary>ChangeNumber. </summary>
		ChangeNumber,
		///<summary>Document. </summary>
		Document,
		///<summary>DocumentLevel. </summary>
		DocumentLevel,
		///<summary>DocumentNode. </summary>
		DocumentNode,
		///<summary>DocumentSummary. </summary>
		DocumentSummary,
		///<summary>FileExtension. </summary>
		FileExtension,
		///<summary>FileName. </summary>
		FileName,
		///<summary>FolderFlag. </summary>
		FolderFlag,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Owner. </summary>
		Owner,
		///<summary>Revision. </summary>
		Revision,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>Status. </summary>
		Status,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmailAddress.</summary>
	public enum EmailAddressFieldIndex
	{
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>EmailAddressId. </summary>
		EmailAddressId,
		///<summary>EmailAddressValue. </summary>
		EmailAddressValue,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Employee.</summary>
	public enum EmployeeFieldIndex
	{
		///<summary>BirthDate. </summary>
		BirthDate,
		///<summary>CurrentFlag. </summary>
		CurrentFlag,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Gender. </summary>
		Gender,
		///<summary>HireDate. </summary>
		HireDate,
		///<summary>LoginId. </summary>
		LoginId,
		///<summary>MaritalStatus. </summary>
		MaritalStatus,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>NationalIdnumber. </summary>
		NationalIdnumber,
		///<summary>OrganizationLevel. </summary>
		OrganizationLevel,
		///<summary>OrganizationNode. </summary>
		OrganizationNode,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalariedFlag. </summary>
		SalariedFlag,
		///<summary>SickLeaveHours. </summary>
		SickLeaveHours,
		///<summary>Title. </summary>
		Title,
		///<summary>VacationHours. </summary>
		VacationHours,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeeDepartmentHistory.</summary>
	public enum EmployeeDepartmentHistoryFieldIndex
	{
		///<summary>DepartmentId. </summary>
		DepartmentId,
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ShiftId. </summary>
		ShiftId,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EmployeePayHistory.</summary>
	public enum EmployeePayHistoryFieldIndex
	{
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PayFrequency. </summary>
		PayFrequency,
		///<summary>Rate. </summary>
		Rate,
		///<summary>RateChangeDate. </summary>
		RateChangeDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Illustration.</summary>
	public enum IllustrationFieldIndex
	{
		///<summary>Diagram. </summary>
		Diagram,
		///<summary>IllustrationId. </summary>
		IllustrationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: JobCandidate.</summary>
	public enum JobCandidateFieldIndex
	{
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>JobCandidateId. </summary>
		JobCandidateId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Resume. </summary>
		Resume,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Location.</summary>
	public enum LocationFieldIndex
	{
		///<summary>Availability. </summary>
		Availability,
		///<summary>CostRate. </summary>
		CostRate,
		///<summary>LocationId. </summary>
		LocationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Password.</summary>
	public enum PasswordFieldIndex
	{
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PasswordHash. </summary>
		PasswordHash,
		///<summary>PasswordSalt. </summary>
		PasswordSalt,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Person.</summary>
	public enum PersonFieldIndex
	{
		///<summary>AdditionalContactInfo. </summary>
		AdditionalContactInfo,
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>Demographics. </summary>
		Demographics,
		///<summary>EmailPromotion. </summary>
		EmailPromotion,
		///<summary>FirstName. </summary>
		FirstName,
		///<summary>LastName. </summary>
		LastName,
		///<summary>MiddleName. </summary>
		MiddleName,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>NameStyle. </summary>
		NameStyle,
		///<summary>PersonType. </summary>
		PersonType,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>Suffix. </summary>
		Suffix,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PersonPhone.</summary>
	public enum PersonPhoneFieldIndex
	{
		///<summary>BusinessEntityId. </summary>
		BusinessEntityId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>PhoneNumber. </summary>
		PhoneNumber,
		///<summary>PhoneNumberTypeId. </summary>
		PhoneNumberTypeId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PhoneNumberType.</summary>
	public enum PhoneNumberTypeFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>PhoneNumberTypeId. </summary>
		PhoneNumberTypeId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Product.</summary>
	public enum ProductFieldIndex
	{
		///<summary>Class. </summary>
		Class,
		///<summary>Color. </summary>
		Color,
		///<summary>DaysToManufacture. </summary>
		DaysToManufacture,
		///<summary>DiscontinuedDate. </summary>
		DiscontinuedDate,
		///<summary>FinishedGoodsFlag. </summary>
		FinishedGoodsFlag,
		///<summary>ListPrice. </summary>
		ListPrice,
		///<summary>MakeFlag. </summary>
		MakeFlag,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ProductLine. </summary>
		ProductLine,
		///<summary>ProductModelId. </summary>
		ProductModelId,
		///<summary>ProductNumber. </summary>
		ProductNumber,
		///<summary>ProductSubcategoryId. </summary>
		ProductSubcategoryId,
		///<summary>ReorderPoint. </summary>
		ReorderPoint,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SafetyStockLevel. </summary>
		SafetyStockLevel,
		///<summary>SellEndDate. </summary>
		SellEndDate,
		///<summary>SellStartDate. </summary>
		SellStartDate,
		///<summary>Size. </summary>
		Size,
		///<summary>SizeUnitMeasureCode. </summary>
		SizeUnitMeasureCode,
		///<summary>StandardCost. </summary>
		StandardCost,
		///<summary>Style. </summary>
		Style,
		///<summary>Weight. </summary>
		Weight,
		///<summary>WeightUnitMeasureCode. </summary>
		WeightUnitMeasureCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductCategory.</summary>
	public enum ProductCategoryFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductCategoryId. </summary>
		ProductCategoryId,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductCostHistory.</summary>
	public enum ProductCostHistoryFieldIndex
	{
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>StandardCost. </summary>
		StandardCost,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductDescription.</summary>
	public enum ProductDescriptionFieldIndex
	{
		///<summary>Description. </summary>
		Description,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductDescriptionId. </summary>
		ProductDescriptionId,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductDocument.</summary>
	public enum ProductDocumentFieldIndex
	{
		///<summary>DocumentNode. </summary>
		DocumentNode,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductInventory.</summary>
	public enum ProductInventoryFieldIndex
	{
		///<summary>Bin. </summary>
		Bin,
		///<summary>LocationId. </summary>
		LocationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>Shelf. </summary>
		Shelf,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductListPriceHistory.</summary>
	public enum ProductListPriceHistoryFieldIndex
	{
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ListPrice. </summary>
		ListPrice,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>StartDate. </summary>
		StartDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModel.</summary>
	public enum ProductModelFieldIndex
	{
		///<summary>CatalogDescription. </summary>
		CatalogDescription,
		///<summary>Instructions. </summary>
		Instructions,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductModelId. </summary>
		ProductModelId,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModelIllustration.</summary>
	public enum ProductModelIllustrationFieldIndex
	{
		///<summary>IllustrationId. </summary>
		IllustrationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductModelId. </summary>
		ProductModelId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductModelProductDescriptionCulture.</summary>
	public enum ProductModelProductDescriptionCultureFieldIndex
	{
		///<summary>CultureId. </summary>
		CultureId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductDescriptionId. </summary>
		ProductDescriptionId,
		///<summary>ProductModelId. </summary>
		ProductModelId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductPhoto.</summary>
	public enum ProductPhotoFieldIndex
	{
		///<summary>LargePhoto. </summary>
		LargePhoto,
		///<summary>LargePhotoFileName. </summary>
		LargePhotoFileName,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductPhotoId. </summary>
		ProductPhotoId,
		///<summary>ThumbNailPhoto. </summary>
		ThumbNailPhoto,
		///<summary>ThumbnailPhotoFileName. </summary>
		ThumbnailPhotoFileName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductProductPhoto.</summary>
	public enum ProductProductPhotoFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Primary. </summary>
		Primary,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ProductPhotoId. </summary>
		ProductPhotoId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductReview.</summary>
	public enum ProductReviewFieldIndex
	{
		///<summary>Comments. </summary>
		Comments,
		///<summary>EmailAddress. </summary>
		EmailAddress,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ProductReviewId. </summary>
		ProductReviewId,
		///<summary>Rating. </summary>
		Rating,
		///<summary>ReviewDate. </summary>
		ReviewDate,
		///<summary>ReviewerName. </summary>
		ReviewerName,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductSubcategory.</summary>
	public enum ProductSubcategoryFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ProductCategoryId. </summary>
		ProductCategoryId,
		///<summary>ProductSubcategoryId. </summary>
		ProductSubcategoryId,
		///<summary>Rowguid. </summary>
		Rowguid,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ProductVendor.</summary>
	public enum ProductVendorFieldIndex
	{
		///<summary>AverageLeadTime. </summary>
		AverageLeadTime,
		///<summary>LastReceiptCost. </summary>
		LastReceiptCost,
		///<summary>LastReceiptDate. </summary>
		LastReceiptDate,
		///<summary>MaxOrderQty. </summary>
		MaxOrderQty,
		///<summary>MinOrderQty. </summary>
		MinOrderQty,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OnOrderQty. </summary>
		OnOrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>StandardPrice. </summary>
		StandardPrice,
		///<summary>UnitMeasureCode. </summary>
		UnitMeasureCode,
		///<summary>VendorId. </summary>
		VendorId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PurchaseOrderDetail.</summary>
	public enum PurchaseOrderDetailFieldIndex
	{
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>LineTotal. </summary>
		LineTotal,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>PurchaseOrderDetailId. </summary>
		PurchaseOrderDetailId,
		///<summary>PurchaseOrderId. </summary>
		PurchaseOrderId,
		///<summary>ReceivedQty. </summary>
		ReceivedQty,
		///<summary>RejectedQty. </summary>
		RejectedQty,
		///<summary>StockedQty. </summary>
		StockedQty,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: PurchaseOrderHeader.</summary>
	public enum PurchaseOrderHeaderFieldIndex
	{
		///<summary>EmployeeId. </summary>
		EmployeeId,
		///<summary>Freight. </summary>
		Freight,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>PurchaseOrderId. </summary>
		PurchaseOrderId,
		///<summary>RevisionNumber. </summary>
		RevisionNumber,
		///<summary>ShipDate. </summary>
		ShipDate,
		///<summary>ShipMethodId. </summary>
		ShipMethodId,
		///<summary>Status. </summary>
		Status,
		///<summary>SubTotal. </summary>
		SubTotal,
		///<summary>TaxAmt. </summary>
		TaxAmt,
		///<summary>TotalDue. </summary>
		TotalDue,
		///<summary>VendorId. </summary>
		VendorId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderDetail.</summary>
	public enum SalesOrderDetailFieldIndex
	{
		///<summary>CarrierTrackingNumber. </summary>
		CarrierTrackingNumber,
		///<summary>LineTotal. </summary>
		LineTotal,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesOrderDetailId. </summary>
		SalesOrderDetailId,
		///<summary>SalesOrderId. </summary>
		SalesOrderId,
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		///<summary>UnitPrice. </summary>
		UnitPrice,
		///<summary>UnitPriceDiscount. </summary>
		UnitPriceDiscount,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderHeader.</summary>
	public enum SalesOrderHeaderFieldIndex
	{
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>BillToAddressId. </summary>
		BillToAddressId,
		///<summary>Comment. </summary>
		Comment,
		///<summary>CreditCardApprovalCode. </summary>
		CreditCardApprovalCode,
		///<summary>CreditCardId. </summary>
		CreditCardId,
		///<summary>CurrencyRateId. </summary>
		CurrencyRateId,
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>Freight. </summary>
		Freight,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OnlineOrderFlag. </summary>
		OnlineOrderFlag,
		///<summary>OrderDate. </summary>
		OrderDate,
		///<summary>PurchaseOrderNumber. </summary>
		PurchaseOrderNumber,
		///<summary>RevisionNumber. </summary>
		RevisionNumber,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesOrderId. </summary>
		SalesOrderId,
		///<summary>SalesOrderNumber. </summary>
		SalesOrderNumber,
		///<summary>SalesPersonId. </summary>
		SalesPersonId,
		///<summary>ShipDate. </summary>
		ShipDate,
		///<summary>ShipMethodId. </summary>
		ShipMethodId,
		///<summary>ShipToAddressId. </summary>
		ShipToAddressId,
		///<summary>Status. </summary>
		Status,
		///<summary>SubTotal. </summary>
		SubTotal,
		///<summary>TaxAmt. </summary>
		TaxAmt,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		///<summary>TotalDue. </summary>
		TotalDue,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesOrderHeaderSalesReason.</summary>
	public enum SalesOrderHeaderSalesReasonFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>SalesOrderId. </summary>
		SalesOrderId,
		///<summary>SalesReasonId. </summary>
		SalesReasonId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesPerson.</summary>
	public enum SalesPersonFieldIndex
	{
		///<summary>Bonus. </summary>
		Bonus,
		///<summary>CommissionPct. </summary>
		CommissionPct,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesLastYear. </summary>
		SalesLastYear,
		///<summary>SalesPersonId. </summary>
		SalesPersonId,
		///<summary>SalesQuota. </summary>
		SalesQuota,
		///<summary>SalesYtd. </summary>
		SalesYtd,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesPersonQuotaHistory.</summary>
	public enum SalesPersonQuotaHistoryFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>QuotaDate. </summary>
		QuotaDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesPersonId. </summary>
		SalesPersonId,
		///<summary>SalesQuota. </summary>
		SalesQuota,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesReason.</summary>
	public enum SalesReasonFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ReasonType. </summary>
		ReasonType,
		///<summary>SalesReasonId. </summary>
		SalesReasonId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTaxRate.</summary>
	public enum SalesTaxRateFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesTaxRateId. </summary>
		SalesTaxRateId,
		///<summary>StateProvinceId. </summary>
		StateProvinceId,
		///<summary>TaxRate. </summary>
		TaxRate,
		///<summary>TaxType. </summary>
		TaxType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTerritory.</summary>
	public enum SalesTerritoryFieldIndex
	{
		///<summary>CostLastYear. </summary>
		CostLastYear,
		///<summary>CostYtd. </summary>
		CostYtd,
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>Group. </summary>
		Group,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesLastYear. </summary>
		SalesLastYear,
		///<summary>SalesYtd. </summary>
		SalesYtd,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SalesTerritoryHistory.</summary>
	public enum SalesTerritoryHistoryFieldIndex
	{
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesPersonId. </summary>
		SalesPersonId,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ScrapReason.</summary>
	public enum ScrapReasonFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ScrapReasonId. </summary>
		ScrapReasonId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Shift.</summary>
	public enum ShiftFieldIndex
	{
		///<summary>EndTime. </summary>
		EndTime,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>ShiftId. </summary>
		ShiftId,
		///<summary>StartTime. </summary>
		StartTime,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ShipMethod.</summary>
	public enum ShipMethodFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>ShipBase. </summary>
		ShipBase,
		///<summary>ShipMethodId. </summary>
		ShipMethodId,
		///<summary>ShipRate. </summary>
		ShipRate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ShoppingCartItem.</summary>
	public enum ShoppingCartItemFieldIndex
	{
		///<summary>DateCreated. </summary>
		DateCreated,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>ShoppingCartId. </summary>
		ShoppingCartId,
		///<summary>ShoppingCartItemId. </summary>
		ShoppingCartItemId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOffer.</summary>
	public enum SpecialOfferFieldIndex
	{
		///<summary>Category. </summary>
		Category,
		///<summary>Description. </summary>
		Description,
		///<summary>DiscountPct. </summary>
		DiscountPct,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>MaxQty. </summary>
		MaxQty,
		///<summary>MinQty. </summary>
		MinQty,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>Type. </summary>
		Type,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: SpecialOfferProduct.</summary>
	public enum SpecialOfferProductFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SpecialOfferId. </summary>
		SpecialOfferId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: StateProvince.</summary>
	public enum StateProvinceFieldIndex
	{
		///<summary>CountryRegionCode. </summary>
		CountryRegionCode,
		///<summary>IsOnlyStateProvinceFlag. </summary>
		IsOnlyStateProvinceFlag,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>StateProvinceCode. </summary>
		StateProvinceCode,
		///<summary>StateProvinceId. </summary>
		StateProvinceId,
		///<summary>TerritoryId. </summary>
		TerritoryId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Store.</summary>
	public enum StoreFieldIndex
	{
		///<summary>CustomerId. </summary>
		CustomerId,
		///<summary>Demographics. </summary>
		Demographics,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>Rowguid. </summary>
		Rowguid,
		///<summary>SalesPersonId. </summary>
		SalesPersonId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TransactionHistory.</summary>
	public enum TransactionHistoryFieldIndex
	{
		///<summary>ActualCost. </summary>
		ActualCost,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>ReferenceOrderId. </summary>
		ReferenceOrderId,
		///<summary>ReferenceOrderLineId. </summary>
		ReferenceOrderLineId,
		///<summary>TransactionDate. </summary>
		TransactionDate,
		///<summary>TransactionId. </summary>
		TransactionId,
		///<summary>TransactionType. </summary>
		TransactionType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TransactionHistoryArchive.</summary>
	public enum TransactionHistoryArchiveFieldIndex
	{
		///<summary>ActualCost. </summary>
		ActualCost,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>Quantity. </summary>
		Quantity,
		///<summary>ReferenceOrderId. </summary>
		ReferenceOrderId,
		///<summary>ReferenceOrderLineId. </summary>
		ReferenceOrderLineId,
		///<summary>TransactionDate. </summary>
		TransactionDate,
		///<summary>TransactionId. </summary>
		TransactionId,
		///<summary>TransactionType. </summary>
		TransactionType,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: UnitMeasure.</summary>
	public enum UnitMeasureFieldIndex
	{
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>UnitMeasureCode. </summary>
		UnitMeasureCode,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Vendor.</summary>
	public enum VendorFieldIndex
	{
		///<summary>AccountNumber. </summary>
		AccountNumber,
		///<summary>ActiveFlag. </summary>
		ActiveFlag,
		///<summary>CreditRating. </summary>
		CreditRating,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>Name. </summary>
		Name,
		///<summary>PreferredVendorStatus. </summary>
		PreferredVendorStatus,
		///<summary>PurchasingWebServiceUrl. </summary>
		PurchasingWebServiceUrl,
		///<summary>VendorId. </summary>
		VendorId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrder.</summary>
	public enum WorkOrderFieldIndex
	{
		///<summary>DueDate. </summary>
		DueDate,
		///<summary>EndDate. </summary>
		EndDate,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OrderQty. </summary>
		OrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ScrappedQty. </summary>
		ScrappedQty,
		///<summary>ScrapReasonId. </summary>
		ScrapReasonId,
		///<summary>StartDate. </summary>
		StartDate,
		///<summary>StockedQty. </summary>
		StockedQty,
		///<summary>WorkOrderId. </summary>
		WorkOrderId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: WorkOrderRouting.</summary>
	public enum WorkOrderRoutingFieldIndex
	{
		///<summary>ActualCost. </summary>
		ActualCost,
		///<summary>ActualEndDate. </summary>
		ActualEndDate,
		///<summary>ActualResourceHrs. </summary>
		ActualResourceHrs,
		///<summary>ActualStartDate. </summary>
		ActualStartDate,
		///<summary>LocationId. </summary>
		LocationId,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OperationSequence. </summary>
		OperationSequence,
		///<summary>PlannedCost. </summary>
		PlannedCost,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>ScheduledEndDate. </summary>
		ScheduledEndDate,
		///<summary>ScheduledStartDate. </summary>
		ScheduledStartDate,
		///<summary>WorkOrderId. </summary>
		WorkOrderId,
		/// <summary></summary>
		AmountOfFields
	}

	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : Soh.</summary>
	public enum SohFieldIndex
	{
		///<summary>SalesOrderId</summary>
		SalesOrderId,
		///<summary>RevisionNumber</summary>
		RevisionNumber,
		///<summary>OrderDate</summary>
		OrderDate,
		///<summary>DueDate</summary>
		DueDate,
		///<summary>ShipDate</summary>
		ShipDate,
		///<summary>Status</summary>
		Status,
		///<summary>OnlineOrderFlag</summary>
		OnlineOrderFlag,
		///<summary>SalesOrderNumber</summary>
		SalesOrderNumber,
		///<summary>PurchaseOrderNumber</summary>
		PurchaseOrderNumber,
		///<summary>AccountNumber</summary>
		AccountNumber,
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>SalesPersonId</summary>
		SalesPersonId,
		///<summary>TerritoryId</summary>
		TerritoryId,
		///<summary>BillToAddressId</summary>
		BillToAddressId,
		///<summary>ShipToAddressId</summary>
		ShipToAddressId,
		///<summary>ShipMethodId</summary>
		ShipMethodId,
		///<summary>CreditCardId</summary>
		CreditCardId,
		///<summary>CreditCardApprovalCode</summary>
		CreditCardApprovalCode,
		///<summary>CurrencyRateId</summary>
		CurrencyRateId,
		///<summary>SubTotal</summary>
		SubTotal,
		///<summary>TaxAmt</summary>
		TaxAmt,
		///<summary>Freight</summary>
		Freight,
		///<summary>TotalDue</summary>
		TotalDue,
		///<summary>Comment</summary>
		Comment,
		///<summary>Rowguid</summary>
		Rowguid,
		///<summary>ModifiedDate</summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : SohLinqPoco.</summary>
	public enum SohLinqPocoFieldIndex
	{
		///<summary>SalesOrderId</summary>
		SalesOrderId,
		///<summary>RevisionNumber</summary>
		RevisionNumber,
		///<summary>OrderDate</summary>
		OrderDate,
		///<summary>DueDate</summary>
		DueDate,
		///<summary>ShipDate</summary>
		ShipDate,
		///<summary>Status</summary>
		Status,
		///<summary>OnlineOrderFlag</summary>
		OnlineOrderFlag,
		///<summary>SalesOrderNumber</summary>
		SalesOrderNumber,
		///<summary>PurchaseOrderNumber</summary>
		PurchaseOrderNumber,
		///<summary>AccountNumber</summary>
		AccountNumber,
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>SalesPersonId</summary>
		SalesPersonId,
		///<summary>TerritoryId</summary>
		TerritoryId,
		///<summary>BillToAddressId</summary>
		BillToAddressId,
		///<summary>ShipToAddressId</summary>
		ShipToAddressId,
		///<summary>ShipMethodId</summary>
		ShipMethodId,
		///<summary>CreditCardId</summary>
		CreditCardId,
		///<summary>CreditCardApprovalCode</summary>
		CreditCardApprovalCode,
		///<summary>CurrencyRateId</summary>
		CurrencyRateId,
		///<summary>SubTotal</summary>
		SubTotal,
		///<summary>TaxAmt</summary>
		TaxAmt,
		///<summary>Freight</summary>
		Freight,
		///<summary>TotalDue</summary>
		TotalDue,
		///<summary>Comment</summary>
		Comment,
		///<summary>Rowguid</summary>
		Rowguid,
		///<summary>ModifiedDate</summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access Typed View EntityFields in the IEntityFields collection for the typed view : SohQuerySpecPoco.</summary>
	public enum SohQuerySpecPocoFieldIndex
	{
		///<summary>SalesOrderId</summary>
		SalesOrderId,
		///<summary>RevisionNumber</summary>
		RevisionNumber,
		///<summary>OrderDate</summary>
		OrderDate,
		///<summary>DueDate</summary>
		DueDate,
		///<summary>ShipDate</summary>
		ShipDate,
		///<summary>Status</summary>
		Status,
		///<summary>OnlineOrderFlag</summary>
		OnlineOrderFlag,
		///<summary>SalesOrderNumber</summary>
		SalesOrderNumber,
		///<summary>PurchaseOrderNumber</summary>
		PurchaseOrderNumber,
		///<summary>AccountNumber</summary>
		AccountNumber,
		///<summary>CustomerId</summary>
		CustomerId,
		///<summary>SalesPersonId</summary>
		SalesPersonId,
		///<summary>TerritoryId</summary>
		TerritoryId,
		///<summary>BillToAddressId</summary>
		BillToAddressId,
		///<summary>ShipToAddressId</summary>
		ShipToAddressId,
		///<summary>ShipMethodId</summary>
		ShipMethodId,
		///<summary>CreditCardId</summary>
		CreditCardId,
		///<summary>CreditCardApprovalCode</summary>
		CreditCardApprovalCode,
		///<summary>CurrencyRateId</summary>
		CurrencyRateId,
		///<summary>SubTotal</summary>
		SubTotal,
		///<summary>TaxAmt</summary>
		TaxAmt,
		///<summary>Freight</summary>
		Freight,
		///<summary>TotalDue</summary>
		TotalDue,
		///<summary>Comment</summary>
		Comment,
		///<summary>Rowguid</summary>
		Rowguid,
		///<summary>ModifiedDate</summary>
		ModifiedDate,
		/// <summary></summary>
		AmountOfFields
	}


	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>Address</summary>
		AddressEntity,
		///<summary>AddressType</summary>
		AddressTypeEntity,
		///<summary>BillOfMaterial</summary>
		BillOfMaterialEntity,
		///<summary>BusinessEntity</summary>
		BusinessEntityEntity,
		///<summary>BusinessEntityAddress</summary>
		BusinessEntityAddressEntity,
		///<summary>BusinessEntityContact</summary>
		BusinessEntityContactEntity,
		///<summary>ContactCreditCard</summary>
		ContactCreditCardEntity,
		///<summary>ContactType</summary>
		ContactTypeEntity,
		///<summary>CountryRegion</summary>
		CountryRegionEntity,
		///<summary>CountryRegionCurrency</summary>
		CountryRegionCurrencyEntity,
		///<summary>CreditCard</summary>
		CreditCardEntity,
		///<summary>Culture</summary>
		CultureEntity,
		///<summary>Currency</summary>
		CurrencyEntity,
		///<summary>CurrencyRate</summary>
		CurrencyRateEntity,
		///<summary>Customer</summary>
		CustomerEntity,
		///<summary>Department</summary>
		DepartmentEntity,
		///<summary>Document</summary>
		DocumentEntity,
		///<summary>EmailAddress</summary>
		EmailAddressEntity,
		///<summary>Employee</summary>
		EmployeeEntity,
		///<summary>EmployeeDepartmentHistory</summary>
		EmployeeDepartmentHistoryEntity,
		///<summary>EmployeePayHistory</summary>
		EmployeePayHistoryEntity,
		///<summary>Illustration</summary>
		IllustrationEntity,
		///<summary>JobCandidate</summary>
		JobCandidateEntity,
		///<summary>Location</summary>
		LocationEntity,
		///<summary>Password</summary>
		PasswordEntity,
		///<summary>Person</summary>
		PersonEntity,
		///<summary>PersonPhone</summary>
		PersonPhoneEntity,
		///<summary>PhoneNumberType</summary>
		PhoneNumberTypeEntity,
		///<summary>Product</summary>
		ProductEntity,
		///<summary>ProductCategory</summary>
		ProductCategoryEntity,
		///<summary>ProductCostHistory</summary>
		ProductCostHistoryEntity,
		///<summary>ProductDescription</summary>
		ProductDescriptionEntity,
		///<summary>ProductDocument</summary>
		ProductDocumentEntity,
		///<summary>ProductInventory</summary>
		ProductInventoryEntity,
		///<summary>ProductListPriceHistory</summary>
		ProductListPriceHistoryEntity,
		///<summary>ProductModel</summary>
		ProductModelEntity,
		///<summary>ProductModelIllustration</summary>
		ProductModelIllustrationEntity,
		///<summary>ProductModelProductDescriptionCulture</summary>
		ProductModelProductDescriptionCultureEntity,
		///<summary>ProductPhoto</summary>
		ProductPhotoEntity,
		///<summary>ProductProductPhoto</summary>
		ProductProductPhotoEntity,
		///<summary>ProductReview</summary>
		ProductReviewEntity,
		///<summary>ProductSubcategory</summary>
		ProductSubcategoryEntity,
		///<summary>ProductVendor</summary>
		ProductVendorEntity,
		///<summary>PurchaseOrderDetail</summary>
		PurchaseOrderDetailEntity,
		///<summary>PurchaseOrderHeader</summary>
		PurchaseOrderHeaderEntity,
		///<summary>SalesOrderDetail</summary>
		SalesOrderDetailEntity,
		///<summary>SalesOrderHeader</summary>
		SalesOrderHeaderEntity,
		///<summary>SalesOrderHeaderSalesReason</summary>
		SalesOrderHeaderSalesReasonEntity,
		///<summary>SalesPerson</summary>
		SalesPersonEntity,
		///<summary>SalesPersonQuotaHistory</summary>
		SalesPersonQuotaHistoryEntity,
		///<summary>SalesReason</summary>
		SalesReasonEntity,
		///<summary>SalesTaxRate</summary>
		SalesTaxRateEntity,
		///<summary>SalesTerritory</summary>
		SalesTerritoryEntity,
		///<summary>SalesTerritoryHistory</summary>
		SalesTerritoryHistoryEntity,
		///<summary>ScrapReason</summary>
		ScrapReasonEntity,
		///<summary>Shift</summary>
		ShiftEntity,
		///<summary>ShipMethod</summary>
		ShipMethodEntity,
		///<summary>ShoppingCartItem</summary>
		ShoppingCartItemEntity,
		///<summary>SpecialOffer</summary>
		SpecialOfferEntity,
		///<summary>SpecialOfferProduct</summary>
		SpecialOfferProductEntity,
		///<summary>StateProvince</summary>
		StateProvinceEntity,
		///<summary>Store</summary>
		StoreEntity,
		///<summary>TransactionHistory</summary>
		TransactionHistoryEntity,
		///<summary>TransactionHistoryArchive</summary>
		TransactionHistoryArchiveEntity,
		///<summary>UnitMeasure</summary>
		UnitMeasureEntity,
		///<summary>Vendor</summary>
		VendorEntity,
		///<summary>WorkOrder</summary>
		WorkOrderEntity,
		///<summary>WorkOrderRouting</summary>
		WorkOrderRoutingEntity
	}

	/// <summary>Enum definition for all the typed view types defined in this namespace. Used by the entityfields factory.</summary>
	public enum TypedViewType
	{
		///<summary>Soh</summary>
		SohTypedView,
		///<summary>SohLinqPoco</summary>
		SohLinqPocoTypedView,
		///<summary>SohQuerySpecPoco</summary>
		SohQuerySpecPocoTypedView
	}

	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}

