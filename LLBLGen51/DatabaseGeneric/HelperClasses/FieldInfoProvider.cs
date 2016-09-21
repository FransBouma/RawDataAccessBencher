///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v51.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (68 + 3));
			InitAddressEntityInfos();
			InitAddressTypeEntityInfos();
			InitBillOfMaterialEntityInfos();
			InitBusinessEntityEntityInfos();
			InitBusinessEntityAddressEntityInfos();
			InitBusinessEntityContactEntityInfos();
			InitContactCreditCardEntityInfos();
			InitContactTypeEntityInfos();
			InitCountryRegionEntityInfos();
			InitCountryRegionCurrencyEntityInfos();
			InitCreditCardEntityInfos();
			InitCultureEntityInfos();
			InitCurrencyEntityInfos();
			InitCurrencyRateEntityInfos();
			InitCustomerEntityInfos();
			InitDepartmentEntityInfos();
			InitDocumentEntityInfos();
			InitEmailAddressEntityInfos();
			InitEmployeeEntityInfos();
			InitEmployeeDepartmentHistoryEntityInfos();
			InitEmployeePayHistoryEntityInfos();
			InitIllustrationEntityInfos();
			InitJobCandidateEntityInfos();
			InitLocationEntityInfos();
			InitPasswordEntityInfos();
			InitPersonEntityInfos();
			InitPersonPhoneEntityInfos();
			InitPhoneNumberTypeEntityInfos();
			InitProductEntityInfos();
			InitProductCategoryEntityInfos();
			InitProductCostHistoryEntityInfos();
			InitProductDescriptionEntityInfos();
			InitProductDocumentEntityInfos();
			InitProductInventoryEntityInfos();
			InitProductListPriceHistoryEntityInfos();
			InitProductModelEntityInfos();
			InitProductModelIllustrationEntityInfos();
			InitProductModelProductDescriptionCultureEntityInfos();
			InitProductPhotoEntityInfos();
			InitProductProductPhotoEntityInfos();
			InitProductReviewEntityInfos();
			InitProductSubcategoryEntityInfos();
			InitProductVendorEntityInfos();
			InitPurchaseOrderDetailEntityInfos();
			InitPurchaseOrderHeaderEntityInfos();
			InitSalesOrderDetailEntityInfos();
			InitSalesOrderHeaderEntityInfos();
			InitSalesOrderHeaderSalesReasonEntityInfos();
			InitSalesPersonEntityInfos();
			InitSalesPersonQuotaHistoryEntityInfos();
			InitSalesReasonEntityInfos();
			InitSalesTaxRateEntityInfos();
			InitSalesTerritoryEntityInfos();
			InitSalesTerritoryHistoryEntityInfos();
			InitScrapReasonEntityInfos();
			InitShiftEntityInfos();
			InitShipMethodEntityInfos();
			InitShoppingCartItemEntityInfos();
			InitSpecialOfferEntityInfos();
			InitSpecialOfferProductEntityInfos();
			InitStateProvinceEntityInfos();
			InitStoreEntityInfos();
			InitTransactionHistoryEntityInfos();
			InitTransactionHistoryArchiveEntityInfos();
			InitUnitMeasureEntityInfos();
			InitVendorEntityInfos();
			InitWorkOrderEntityInfos();
			InitWorkOrderRoutingEntityInfos();
			InitSohTypedViewInfos();
			InitSohLinqPocoTypedViewInfos();
			InitSohQuerySpecPocoTypedViewInfos();
			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AddressEntity's FieldInfo objects</summary>
		private void InitAddressEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AddressFieldIndex), "AddressEntity");
			this.AddElementFieldInfo("AddressEntity", "AddressId", typeof(System.Int32), true, false, true, false,  (int)AddressFieldIndex.AddressId, 0, 0, 10);
			this.AddElementFieldInfo("AddressEntity", "AddressLine1", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.AddressLine1, 60, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "AddressLine2", typeof(System.String), false, false, false, true,  (int)AddressFieldIndex.AddressLine2, 60, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "City", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.City, 30, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AddressFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "PostalCode", typeof(System.String), false, false, false, false,  (int)AddressFieldIndex.PostalCode, 15, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)AddressFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "SpatialLocation", typeof(Microsoft.SqlServer.Types.SqlGeography), false, false, false, true,  (int)AddressFieldIndex.SpatialLocation, 0, 0, 0);
			this.AddElementFieldInfo("AddressEntity", "StateProvinceId", typeof(System.Int32), false, true, false, false,  (int)AddressFieldIndex.StateProvinceId, 0, 0, 10);
		}
		/// <summary>Inits AddressTypeEntity's FieldInfo objects</summary>
		private void InitAddressTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AddressTypeFieldIndex), "AddressTypeEntity");
			this.AddElementFieldInfo("AddressTypeEntity", "AddressTypeId", typeof(System.Int32), true, false, true, false,  (int)AddressTypeFieldIndex.AddressTypeId, 0, 0, 10);
			this.AddElementFieldInfo("AddressTypeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)AddressTypeFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("AddressTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)AddressTypeFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("AddressTypeEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)AddressTypeFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits BillOfMaterialEntity's FieldInfo objects</summary>
		private void InitBillOfMaterialEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BillOfMaterialFieldIndex), "BillOfMaterialEntity");
			this.AddElementFieldInfo("BillOfMaterialEntity", "BillOfMaterialsId", typeof(System.Int32), true, false, true, false,  (int)BillOfMaterialFieldIndex.BillOfMaterialsId, 0, 0, 10);
			this.AddElementFieldInfo("BillOfMaterialEntity", "Bomlevel", typeof(System.Int16), false, false, false, false,  (int)BillOfMaterialFieldIndex.Bomlevel, 0, 0, 5);
			this.AddElementFieldInfo("BillOfMaterialEntity", "ComponentId", typeof(System.Int32), false, true, false, false,  (int)BillOfMaterialFieldIndex.ComponentId, 0, 0, 10);
			this.AddElementFieldInfo("BillOfMaterialEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)BillOfMaterialFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("BillOfMaterialEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)BillOfMaterialFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("BillOfMaterialEntity", "PerAssemblyQty", typeof(System.Decimal), false, false, false, false,  (int)BillOfMaterialFieldIndex.PerAssemblyQty, 0, 2, 8);
			this.AddElementFieldInfo("BillOfMaterialEntity", "ProductAssemblyId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)BillOfMaterialFieldIndex.ProductAssemblyId, 0, 0, 10);
			this.AddElementFieldInfo("BillOfMaterialEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)BillOfMaterialFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("BillOfMaterialEntity", "UnitMeasureCode", typeof(System.String), false, true, false, false,  (int)BillOfMaterialFieldIndex.UnitMeasureCode, 3, 0, 0);
		}
		/// <summary>Inits BusinessEntityEntity's FieldInfo objects</summary>
		private void InitBusinessEntityEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BusinessEntityFieldIndex), "BusinessEntityEntity");
			this.AddElementFieldInfo("BusinessEntityEntity", "BusinessEntityId", typeof(System.Int32), true, false, true, false,  (int)BusinessEntityFieldIndex.BusinessEntityId, 0, 0, 10);
			this.AddElementFieldInfo("BusinessEntityEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)BusinessEntityFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("BusinessEntityEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)BusinessEntityFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits BusinessEntityAddressEntity's FieldInfo objects</summary>
		private void InitBusinessEntityAddressEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BusinessEntityAddressFieldIndex), "BusinessEntityAddressEntity");
			this.AddElementFieldInfo("BusinessEntityAddressEntity", "AddressId", typeof(System.Int32), true, true, false, false,  (int)BusinessEntityAddressFieldIndex.AddressId, 0, 0, 10);
			this.AddElementFieldInfo("BusinessEntityAddressEntity", "AddressTypeId", typeof(System.Int32), true, true, false, false,  (int)BusinessEntityAddressFieldIndex.AddressTypeId, 0, 0, 10);
			this.AddElementFieldInfo("BusinessEntityAddressEntity", "BusinessEntityId", typeof(System.Int32), true, true, false, false,  (int)BusinessEntityAddressFieldIndex.BusinessEntityId, 0, 0, 10);
			this.AddElementFieldInfo("BusinessEntityAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)BusinessEntityAddressFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("BusinessEntityAddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)BusinessEntityAddressFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits BusinessEntityContactEntity's FieldInfo objects</summary>
		private void InitBusinessEntityContactEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(BusinessEntityContactFieldIndex), "BusinessEntityContactEntity");
			this.AddElementFieldInfo("BusinessEntityContactEntity", "BusinessEntityId", typeof(System.Int32), true, true, false, false,  (int)BusinessEntityContactFieldIndex.BusinessEntityId, 0, 0, 10);
			this.AddElementFieldInfo("BusinessEntityContactEntity", "ContactTypeId", typeof(System.Int32), true, true, false, false,  (int)BusinessEntityContactFieldIndex.ContactTypeId, 0, 0, 10);
			this.AddElementFieldInfo("BusinessEntityContactEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)BusinessEntityContactFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("BusinessEntityContactEntity", "PersonId", typeof(System.Int32), true, true, false, false,  (int)BusinessEntityContactFieldIndex.PersonId, 0, 0, 10);
			this.AddElementFieldInfo("BusinessEntityContactEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)BusinessEntityContactFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ContactCreditCardEntity's FieldInfo objects</summary>
		private void InitContactCreditCardEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ContactCreditCardFieldIndex), "ContactCreditCardEntity");
			this.AddElementFieldInfo("ContactCreditCardEntity", "ContactId", typeof(System.Int32), true, true, false, false,  (int)ContactCreditCardFieldIndex.ContactId, 0, 0, 10);
			this.AddElementFieldInfo("ContactCreditCardEntity", "CreditCardId", typeof(System.Int32), true, true, false, false,  (int)ContactCreditCardFieldIndex.CreditCardId, 0, 0, 10);
			this.AddElementFieldInfo("ContactCreditCardEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactCreditCardFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits ContactTypeEntity's FieldInfo objects</summary>
		private void InitContactTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ContactTypeFieldIndex), "ContactTypeEntity");
			this.AddElementFieldInfo("ContactTypeEntity", "ContactTypeId", typeof(System.Int32), true, false, true, false,  (int)ContactTypeFieldIndex.ContactTypeId, 0, 0, 10);
			this.AddElementFieldInfo("ContactTypeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ContactTypeFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ContactTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)ContactTypeFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits CountryRegionEntity's FieldInfo objects</summary>
		private void InitCountryRegionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CountryRegionFieldIndex), "CountryRegionEntity");
			this.AddElementFieldInfo("CountryRegionEntity", "CountryRegionCode", typeof(System.String), true, false, false, false,  (int)CountryRegionFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("CountryRegionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CountryRegionFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CountryRegionEntity", "Name", typeof(System.String), false, false, false, false,  (int)CountryRegionFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits CountryRegionCurrencyEntity's FieldInfo objects</summary>
		private void InitCountryRegionCurrencyEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CountryRegionCurrencyFieldIndex), "CountryRegionCurrencyEntity");
			this.AddElementFieldInfo("CountryRegionCurrencyEntity", "CountryRegionCode", typeof(System.String), true, true, false, false,  (int)CountryRegionCurrencyFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("CountryRegionCurrencyEntity", "CurrencyCode", typeof(System.String), true, true, false, false,  (int)CountryRegionCurrencyFieldIndex.CurrencyCode, 3, 0, 0);
			this.AddElementFieldInfo("CountryRegionCurrencyEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CountryRegionCurrencyFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CreditCardEntity's FieldInfo objects</summary>
		private void InitCreditCardEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CreditCardFieldIndex), "CreditCardEntity");
			this.AddElementFieldInfo("CreditCardEntity", "CardNumber", typeof(System.String), false, false, false, false,  (int)CreditCardFieldIndex.CardNumber, 25, 0, 0);
			this.AddElementFieldInfo("CreditCardEntity", "CardType", typeof(System.String), false, false, false, false,  (int)CreditCardFieldIndex.CardType, 50, 0, 0);
			this.AddElementFieldInfo("CreditCardEntity", "CreditCardId", typeof(System.Int32), true, false, true, false,  (int)CreditCardFieldIndex.CreditCardId, 0, 0, 10);
			this.AddElementFieldInfo("CreditCardEntity", "ExpMonth", typeof(System.Byte), false, false, false, false,  (int)CreditCardFieldIndex.ExpMonth, 0, 0, 3);
			this.AddElementFieldInfo("CreditCardEntity", "ExpYear", typeof(System.Int16), false, false, false, false,  (int)CreditCardFieldIndex.ExpYear, 0, 0, 5);
			this.AddElementFieldInfo("CreditCardEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CreditCardFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits CultureEntity's FieldInfo objects</summary>
		private void InitCultureEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CultureFieldIndex), "CultureEntity");
			this.AddElementFieldInfo("CultureEntity", "CultureId", typeof(System.String), true, false, false, false,  (int)CultureFieldIndex.CultureId, 6, 0, 0);
			this.AddElementFieldInfo("CultureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CultureFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CultureEntity", "Name", typeof(System.String), false, false, false, false,  (int)CultureFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits CurrencyEntity's FieldInfo objects</summary>
		private void InitCurrencyEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CurrencyFieldIndex), "CurrencyEntity");
			this.AddElementFieldInfo("CurrencyEntity", "CurrencyCode", typeof(System.String), true, false, false, false,  (int)CurrencyFieldIndex.CurrencyCode, 3, 0, 0);
			this.AddElementFieldInfo("CurrencyEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CurrencyEntity", "Name", typeof(System.String), false, false, false, false,  (int)CurrencyFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits CurrencyRateEntity's FieldInfo objects</summary>
		private void InitCurrencyRateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CurrencyRateFieldIndex), "CurrencyRateEntity");
			this.AddElementFieldInfo("CurrencyRateEntity", "AverageRate", typeof(System.Decimal), false, false, false, false,  (int)CurrencyRateFieldIndex.AverageRate, 0, 4, 19);
			this.AddElementFieldInfo("CurrencyRateEntity", "CurrencyRateDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyRateFieldIndex.CurrencyRateDate, 0, 0, 0);
			this.AddElementFieldInfo("CurrencyRateEntity", "CurrencyRateId", typeof(System.Int32), true, false, true, false,  (int)CurrencyRateFieldIndex.CurrencyRateId, 0, 0, 10);
			this.AddElementFieldInfo("CurrencyRateEntity", "EndOfDayRate", typeof(System.Decimal), false, false, false, false,  (int)CurrencyRateFieldIndex.EndOfDayRate, 0, 4, 19);
			this.AddElementFieldInfo("CurrencyRateEntity", "FromCurrencyCode", typeof(System.String), false, true, false, false,  (int)CurrencyRateFieldIndex.FromCurrencyCode, 3, 0, 0);
			this.AddElementFieldInfo("CurrencyRateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CurrencyRateFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CurrencyRateEntity", "ToCurrencyCode", typeof(System.String), false, true, false, false,  (int)CurrencyRateFieldIndex.ToCurrencyCode, 3, 0, 0);
		}
		/// <summary>Inits CustomerEntity's FieldInfo objects</summary>
		private void InitCustomerEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(CustomerFieldIndex), "CustomerEntity");
			this.AddElementFieldInfo("CustomerEntity", "AccountNumber", typeof(System.String), false, false, true, false,  (int)CustomerFieldIndex.AccountNumber, 10, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "CustomerId", typeof(System.Int32), true, false, true, false,  (int)CustomerFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("CustomerEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)CustomerFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "PersonId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CustomerFieldIndex.PersonId, 0, 0, 10);
			this.AddElementFieldInfo("CustomerEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)CustomerFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("CustomerEntity", "StoreId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CustomerFieldIndex.StoreId, 0, 0, 10);
			this.AddElementFieldInfo("CustomerEntity", "TerritoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)CustomerFieldIndex.TerritoryId, 0, 0, 10);
		}
		/// <summary>Inits DepartmentEntity's FieldInfo objects</summary>
		private void InitDepartmentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DepartmentFieldIndex), "DepartmentEntity");
			this.AddElementFieldInfo("DepartmentEntity", "DepartmentId", typeof(System.Int16), true, false, true, false,  (int)DepartmentFieldIndex.DepartmentId, 0, 0, 5);
			this.AddElementFieldInfo("DepartmentEntity", "GroupName", typeof(System.String), false, false, false, false,  (int)DepartmentFieldIndex.GroupName, 50, 0, 0);
			this.AddElementFieldInfo("DepartmentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)DepartmentFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("DepartmentEntity", "Name", typeof(System.String), false, false, false, false,  (int)DepartmentFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits DocumentEntity's FieldInfo objects</summary>
		private void InitDocumentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(DocumentFieldIndex), "DocumentEntity");
			this.AddElementFieldInfo("DocumentEntity", "ChangeNumber", typeof(System.Int32), false, false, false, false,  (int)DocumentFieldIndex.ChangeNumber, 0, 0, 10);
			this.AddElementFieldInfo("DocumentEntity", "Document", typeof(System.Byte[]), false, false, false, true,  (int)DocumentFieldIndex.Document, 2147483647, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "DocumentLevel", typeof(Nullable<System.Int16>), false, false, true, true,  (int)DocumentFieldIndex.DocumentLevel, 0, 0, 5);
			this.AddElementFieldInfo("DocumentEntity", "DocumentNode", typeof(System.String), true, false, false, false,  (int)DocumentFieldIndex.DocumentNode, 892, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "DocumentSummary", typeof(System.String), false, false, false, true,  (int)DocumentFieldIndex.DocumentSummary, 2147483647, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "FileExtension", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.FileExtension, 8, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "FileName", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.FileName, 400, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "FolderFlag", typeof(System.Boolean), false, false, false, false,  (int)DocumentFieldIndex.FolderFlag, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)DocumentFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "Owner", typeof(System.Int32), false, true, false, false,  (int)DocumentFieldIndex.Owner, 0, 0, 10);
			this.AddElementFieldInfo("DocumentEntity", "Revision", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.Revision, 5, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)DocumentFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("DocumentEntity", "Status", typeof(System.Byte), false, false, false, false,  (int)DocumentFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("DocumentEntity", "Title", typeof(System.String), false, false, false, false,  (int)DocumentFieldIndex.Title, 50, 0, 0);
		}
		/// <summary>Inits EmailAddressEntity's FieldInfo objects</summary>
		private void InitEmailAddressEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmailAddressFieldIndex), "EmailAddressEntity");
			this.AddElementFieldInfo("EmailAddressEntity", "BusinessEntityId", typeof(System.Int32), true, true, false, false,  (int)EmailAddressFieldIndex.BusinessEntityId, 0, 0, 10);
			this.AddElementFieldInfo("EmailAddressEntity", "EmailAddressId", typeof(System.Int32), true, false, true, false,  (int)EmailAddressFieldIndex.EmailAddressId, 0, 0, 10);
			this.AddElementFieldInfo("EmailAddressEntity", "EmailAddressValue", typeof(System.String), false, false, false, true,  (int)EmailAddressFieldIndex.EmailAddressValue, 50, 0, 0);
			this.AddElementFieldInfo("EmailAddressEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmailAddressFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmailAddressEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)EmailAddressFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits EmployeeEntity's FieldInfo objects</summary>
		private void InitEmployeeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeFieldIndex), "EmployeeEntity");
			this.AddElementFieldInfo("EmployeeEntity", "BirthDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.BirthDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "CurrentFlag", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.CurrentFlag, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "EmployeeId", typeof(System.Int32), true, true, true, false,  (int)EmployeeFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeEntity", "Gender", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.Gender, 1, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "HireDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.HireDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "LoginId", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.LoginId, 256, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "MaritalStatus", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.MaritalStatus, 1, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "NationalIdnumber", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.NationalIdnumber, 15, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "OrganizationLevel", typeof(Nullable<System.Int16>), false, false, true, true,  (int)EmployeeFieldIndex.OrganizationLevel, 0, 0, 5);
			this.AddElementFieldInfo("EmployeeEntity", "OrganizationNode", typeof(System.String), false, false, false, true,  (int)EmployeeFieldIndex.OrganizationNode, 892, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)EmployeeFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "SalariedFlag", typeof(System.Boolean), false, false, false, false,  (int)EmployeeFieldIndex.SalariedFlag, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "SickLeaveHours", typeof(System.Int16), false, false, false, false,  (int)EmployeeFieldIndex.SickLeaveHours, 0, 0, 5);
			this.AddElementFieldInfo("EmployeeEntity", "Title", typeof(System.String), false, false, false, false,  (int)EmployeeFieldIndex.Title, 50, 0, 0);
			this.AddElementFieldInfo("EmployeeEntity", "VacationHours", typeof(System.Int16), false, false, false, false,  (int)EmployeeFieldIndex.VacationHours, 0, 0, 5);
		}
		/// <summary>Inits EmployeeDepartmentHistoryEntity's FieldInfo objects</summary>
		private void InitEmployeeDepartmentHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeeDepartmentHistoryFieldIndex), "EmployeeDepartmentHistoryEntity");
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "DepartmentId", typeof(System.Int16), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.DepartmentId, 0, 0, 5);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "EmployeeId", typeof(System.Int32), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)EmployeeDepartmentHistoryFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "ShiftId", typeof(System.Byte), true, true, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.ShiftId, 0, 0, 3);
			this.AddElementFieldInfo("EmployeeDepartmentHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)EmployeeDepartmentHistoryFieldIndex.StartDate, 0, 0, 0);
		}
		/// <summary>Inits EmployeePayHistoryEntity's FieldInfo objects</summary>
		private void InitEmployeePayHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EmployeePayHistoryFieldIndex), "EmployeePayHistoryEntity");
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "EmployeeId", typeof(System.Int32), true, true, false, false,  (int)EmployeePayHistoryFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "PayFrequency", typeof(System.Byte), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.PayFrequency, 0, 0, 3);
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "Rate", typeof(System.Decimal), false, false, false, false,  (int)EmployeePayHistoryFieldIndex.Rate, 0, 4, 19);
			this.AddElementFieldInfo("EmployeePayHistoryEntity", "RateChangeDate", typeof(System.DateTime), true, false, false, false,  (int)EmployeePayHistoryFieldIndex.RateChangeDate, 0, 0, 0);
		}
		/// <summary>Inits IllustrationEntity's FieldInfo objects</summary>
		private void InitIllustrationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(IllustrationFieldIndex), "IllustrationEntity");
			this.AddElementFieldInfo("IllustrationEntity", "Diagram", typeof(System.String), false, false, false, true,  (int)IllustrationFieldIndex.Diagram, 2147483647, 0, 0);
			this.AddElementFieldInfo("IllustrationEntity", "IllustrationId", typeof(System.Int32), true, false, true, false,  (int)IllustrationFieldIndex.IllustrationId, 0, 0, 10);
			this.AddElementFieldInfo("IllustrationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)IllustrationFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits JobCandidateEntity's FieldInfo objects</summary>
		private void InitJobCandidateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(JobCandidateFieldIndex), "JobCandidateEntity");
			this.AddElementFieldInfo("JobCandidateEntity", "EmployeeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)JobCandidateFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("JobCandidateEntity", "JobCandidateId", typeof(System.Int32), true, false, true, false,  (int)JobCandidateFieldIndex.JobCandidateId, 0, 0, 10);
			this.AddElementFieldInfo("JobCandidateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)JobCandidateFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("JobCandidateEntity", "Resume", typeof(System.String), false, false, false, true,  (int)JobCandidateFieldIndex.Resume, 2147483647, 0, 0);
		}
		/// <summary>Inits LocationEntity's FieldInfo objects</summary>
		private void InitLocationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(LocationFieldIndex), "LocationEntity");
			this.AddElementFieldInfo("LocationEntity", "Availability", typeof(System.Decimal), false, false, false, false,  (int)LocationFieldIndex.Availability, 0, 2, 8);
			this.AddElementFieldInfo("LocationEntity", "CostRate", typeof(System.Decimal), false, false, false, false,  (int)LocationFieldIndex.CostRate, 0, 4, 10);
			this.AddElementFieldInfo("LocationEntity", "LocationId", typeof(System.Int16), true, false, true, false,  (int)LocationFieldIndex.LocationId, 0, 0, 5);
			this.AddElementFieldInfo("LocationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)LocationFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("LocationEntity", "Name", typeof(System.String), false, false, false, false,  (int)LocationFieldIndex.Name, 50, 0, 0);
		}
		/// <summary>Inits PasswordEntity's FieldInfo objects</summary>
		private void InitPasswordEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PasswordFieldIndex), "PasswordEntity");
			this.AddElementFieldInfo("PasswordEntity", "BusinessEntityId", typeof(System.Int32), true, true, false, false,  (int)PasswordFieldIndex.BusinessEntityId, 0, 0, 10);
			this.AddElementFieldInfo("PasswordEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PasswordFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("PasswordEntity", "PasswordHash", typeof(System.String), false, false, false, false,  (int)PasswordFieldIndex.PasswordHash, 128, 0, 0);
			this.AddElementFieldInfo("PasswordEntity", "PasswordSalt", typeof(System.String), false, false, false, false,  (int)PasswordFieldIndex.PasswordSalt, 10, 0, 0);
			this.AddElementFieldInfo("PasswordEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)PasswordFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits PersonEntity's FieldInfo objects</summary>
		private void InitPersonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PersonFieldIndex), "PersonEntity");
			this.AddElementFieldInfo("PersonEntity", "AdditionalContactInfo", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.AdditionalContactInfo, 2147483647, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "BusinessEntityId", typeof(System.Int32), true, true, false, false,  (int)PersonFieldIndex.BusinessEntityId, 0, 0, 10);
			this.AddElementFieldInfo("PersonEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.Demographics, 2147483647, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "EmailPromotion", typeof(System.Int32), false, false, false, false,  (int)PersonFieldIndex.EmailPromotion, 0, 0, 10);
			this.AddElementFieldInfo("PersonEntity", "FirstName", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.FirstName, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "LastName", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.LastName, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "MiddleName", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.MiddleName, 50, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PersonFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "NameStyle", typeof(System.Boolean), false, false, false, false,  (int)PersonFieldIndex.NameStyle, 0, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "PersonType", typeof(System.String), false, false, false, false,  (int)PersonFieldIndex.PersonType, 2, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)PersonFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Suffix", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.Suffix, 10, 0, 0);
			this.AddElementFieldInfo("PersonEntity", "Title", typeof(System.String), false, false, false, true,  (int)PersonFieldIndex.Title, 8, 0, 0);
		}
		/// <summary>Inits PersonPhoneEntity's FieldInfo objects</summary>
		private void InitPersonPhoneEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PersonPhoneFieldIndex), "PersonPhoneEntity");
			this.AddElementFieldInfo("PersonPhoneEntity", "BusinessEntityId", typeof(System.Int32), true, true, false, false,  (int)PersonPhoneFieldIndex.BusinessEntityId, 0, 0, 10);
			this.AddElementFieldInfo("PersonPhoneEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PersonPhoneFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("PersonPhoneEntity", "PhoneNumber", typeof(System.String), true, false, false, false,  (int)PersonPhoneFieldIndex.PhoneNumber, 25, 0, 0);
			this.AddElementFieldInfo("PersonPhoneEntity", "PhoneNumberTypeId", typeof(System.Int32), true, true, false, false,  (int)PersonPhoneFieldIndex.PhoneNumberTypeId, 0, 0, 10);
		}
		/// <summary>Inits PhoneNumberTypeEntity's FieldInfo objects</summary>
		private void InitPhoneNumberTypeEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PhoneNumberTypeFieldIndex), "PhoneNumberTypeEntity");
			this.AddElementFieldInfo("PhoneNumberTypeEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PhoneNumberTypeFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("PhoneNumberTypeEntity", "Name", typeof(System.String), false, false, false, false,  (int)PhoneNumberTypeFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("PhoneNumberTypeEntity", "PhoneNumberTypeId", typeof(System.Int32), true, false, true, false,  (int)PhoneNumberTypeFieldIndex.PhoneNumberTypeId, 0, 0, 10);
		}
		/// <summary>Inits ProductEntity's FieldInfo objects</summary>
		private void InitProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductFieldIndex), "ProductEntity");
			this.AddElementFieldInfo("ProductEntity", "Class", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Class, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Color", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Color, 15, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "DaysToManufacture", typeof(System.Int32), false, false, false, false,  (int)ProductFieldIndex.DaysToManufacture, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "DiscontinuedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.DiscontinuedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "FinishedGoodsFlag", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.FinishedGoodsFlag, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ListPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductFieldIndex.ListPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "MakeFlag", typeof(System.Boolean), false, false, false, false,  (int)ProductFieldIndex.MakeFlag, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductId", typeof(System.Int32), true, false, true, false,  (int)ProductFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductLine", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.ProductLine, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductModelId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.ProductModelId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ProductNumber", typeof(System.String), false, false, false, false,  (int)ProductFieldIndex.ProductNumber, 25, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "ProductSubcategoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProductFieldIndex.ProductSubcategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductEntity", "ReorderPoint", typeof(System.Int16), false, false, false, false,  (int)ProductFieldIndex.ReorderPoint, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SafetyStockLevel", typeof(System.Int16), false, false, false, false,  (int)ProductFieldIndex.SafetyStockLevel, 0, 0, 5);
			this.AddElementFieldInfo("ProductEntity", "SellEndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductFieldIndex.SellEndDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SellStartDate", typeof(System.DateTime), false, false, false, false,  (int)ProductFieldIndex.SellStartDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Size", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Size, 5, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "SizeUnitMeasureCode", typeof(System.String), false, true, false, true,  (int)ProductFieldIndex.SizeUnitMeasureCode, 3, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "StandardCost", typeof(System.Decimal), false, false, false, false,  (int)ProductFieldIndex.StandardCost, 0, 4, 19);
			this.AddElementFieldInfo("ProductEntity", "Style", typeof(System.String), false, false, false, true,  (int)ProductFieldIndex.Style, 2, 0, 0);
			this.AddElementFieldInfo("ProductEntity", "Weight", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductFieldIndex.Weight, 0, 2, 8);
			this.AddElementFieldInfo("ProductEntity", "WeightUnitMeasureCode", typeof(System.String), false, true, false, true,  (int)ProductFieldIndex.WeightUnitMeasureCode, 3, 0, 0);
		}
		/// <summary>Inits ProductCategoryEntity's FieldInfo objects</summary>
		private void InitProductCategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductCategoryFieldIndex), "ProductCategoryEntity");
			this.AddElementFieldInfo("ProductCategoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductCategoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductCategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductCategoryFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductCategoryEntity", "ProductCategoryId", typeof(System.Int32), true, false, true, false,  (int)ProductCategoryFieldIndex.ProductCategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductCategoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductCategoryFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ProductCostHistoryEntity's FieldInfo objects</summary>
		private void InitProductCostHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductCostHistoryFieldIndex), "ProductCostHistoryEntity");
			this.AddElementFieldInfo("ProductCostHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductCostHistoryFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductCostHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductCostHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductCostHistoryEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)ProductCostHistoryFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductCostHistoryEntity", "StandardCost", typeof(System.Decimal), false, false, false, false,  (int)ProductCostHistoryFieldIndex.StandardCost, 0, 4, 19);
			this.AddElementFieldInfo("ProductCostHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)ProductCostHistoryFieldIndex.StartDate, 0, 0, 0);
		}
		/// <summary>Inits ProductDescriptionEntity's FieldInfo objects</summary>
		private void InitProductDescriptionEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductDescriptionFieldIndex), "ProductDescriptionEntity");
			this.AddElementFieldInfo("ProductDescriptionEntity", "Description", typeof(System.String), false, false, false, false,  (int)ProductDescriptionFieldIndex.Description, 400, 0, 0);
			this.AddElementFieldInfo("ProductDescriptionEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductDescriptionFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductDescriptionEntity", "ProductDescriptionId", typeof(System.Int32), true, false, true, false,  (int)ProductDescriptionFieldIndex.ProductDescriptionId, 0, 0, 10);
			this.AddElementFieldInfo("ProductDescriptionEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductDescriptionFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ProductDocumentEntity's FieldInfo objects</summary>
		private void InitProductDocumentEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductDocumentFieldIndex), "ProductDocumentEntity");
			this.AddElementFieldInfo("ProductDocumentEntity", "DocumentNode", typeof(System.String), true, true, false, false,  (int)ProductDocumentFieldIndex.DocumentNode, 892, 0, 0);
			this.AddElementFieldInfo("ProductDocumentEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductDocumentFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductDocumentEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)ProductDocumentFieldIndex.ProductId, 0, 0, 10);
		}
		/// <summary>Inits ProductInventoryEntity's FieldInfo objects</summary>
		private void InitProductInventoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductInventoryFieldIndex), "ProductInventoryEntity");
			this.AddElementFieldInfo("ProductInventoryEntity", "Bin", typeof(System.Byte), false, false, false, false,  (int)ProductInventoryFieldIndex.Bin, 0, 0, 3);
			this.AddElementFieldInfo("ProductInventoryEntity", "LocationId", typeof(System.Int16), true, true, false, false,  (int)ProductInventoryFieldIndex.LocationId, 0, 0, 5);
			this.AddElementFieldInfo("ProductInventoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductInventoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductInventoryEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)ProductInventoryFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductInventoryEntity", "Quantity", typeof(System.Int16), false, false, false, false,  (int)ProductInventoryFieldIndex.Quantity, 0, 0, 5);
			this.AddElementFieldInfo("ProductInventoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductInventoryFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("ProductInventoryEntity", "Shelf", typeof(System.String), false, false, false, false,  (int)ProductInventoryFieldIndex.Shelf, 10, 0, 0);
		}
		/// <summary>Inits ProductListPriceHistoryEntity's FieldInfo objects</summary>
		private void InitProductListPriceHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductListPriceHistoryFieldIndex), "ProductListPriceHistoryEntity");
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductListPriceHistoryFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "ListPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductListPriceHistoryFieldIndex.ListPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductListPriceHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)ProductListPriceHistoryFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductListPriceHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)ProductListPriceHistoryFieldIndex.StartDate, 0, 0, 0);
		}
		/// <summary>Inits ProductModelEntity's FieldInfo objects</summary>
		private void InitProductModelEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductModelFieldIndex), "ProductModelEntity");
			this.AddElementFieldInfo("ProductModelEntity", "CatalogDescription", typeof(System.String), false, false, false, true,  (int)ProductModelFieldIndex.CatalogDescription, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductModelEntity", "Instructions", typeof(System.String), false, false, false, true,  (int)ProductModelFieldIndex.Instructions, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductModelEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductModelEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductModelFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductModelEntity", "ProductModelId", typeof(System.Int32), true, false, true, false,  (int)ProductModelFieldIndex.ProductModelId, 0, 0, 10);
			this.AddElementFieldInfo("ProductModelEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductModelFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ProductModelIllustrationEntity's FieldInfo objects</summary>
		private void InitProductModelIllustrationEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductModelIllustrationFieldIndex), "ProductModelIllustrationEntity");
			this.AddElementFieldInfo("ProductModelIllustrationEntity", "IllustrationId", typeof(System.Int32), true, true, false, false,  (int)ProductModelIllustrationFieldIndex.IllustrationId, 0, 0, 10);
			this.AddElementFieldInfo("ProductModelIllustrationEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelIllustrationFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductModelIllustrationEntity", "ProductModelId", typeof(System.Int32), true, true, false, false,  (int)ProductModelIllustrationFieldIndex.ProductModelId, 0, 0, 10);
		}
		/// <summary>Inits ProductModelProductDescriptionCultureEntity's FieldInfo objects</summary>
		private void InitProductModelProductDescriptionCultureEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductModelProductDescriptionCultureFieldIndex), "ProductModelProductDescriptionCultureEntity");
			this.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "CultureId", typeof(System.String), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.CultureId, 6, 0, 0);
			this.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ProductDescriptionId", typeof(System.Int32), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionId, 0, 0, 10);
			this.AddElementFieldInfo("ProductModelProductDescriptionCultureEntity", "ProductModelId", typeof(System.Int32), true, true, false, false,  (int)ProductModelProductDescriptionCultureFieldIndex.ProductModelId, 0, 0, 10);
		}
		/// <summary>Inits ProductPhotoEntity's FieldInfo objects</summary>
		private void InitProductPhotoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductPhotoFieldIndex), "ProductPhotoEntity");
			this.AddElementFieldInfo("ProductPhotoEntity", "LargePhoto", typeof(System.Byte[]), false, false, false, true,  (int)ProductPhotoFieldIndex.LargePhoto, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductPhotoEntity", "LargePhotoFileName", typeof(System.String), false, false, false, true,  (int)ProductPhotoFieldIndex.LargePhotoFileName, 50, 0, 0);
			this.AddElementFieldInfo("ProductPhotoEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductPhotoFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductPhotoEntity", "ProductPhotoId", typeof(System.Int32), true, false, true, false,  (int)ProductPhotoFieldIndex.ProductPhotoId, 0, 0, 10);
			this.AddElementFieldInfo("ProductPhotoEntity", "ThumbNailPhoto", typeof(System.Byte[]), false, false, false, true,  (int)ProductPhotoFieldIndex.ThumbNailPhoto, 2147483647, 0, 0);
			this.AddElementFieldInfo("ProductPhotoEntity", "ThumbnailPhotoFileName", typeof(System.String), false, false, false, true,  (int)ProductPhotoFieldIndex.ThumbnailPhotoFileName, 50, 0, 0);
		}
		/// <summary>Inits ProductProductPhotoEntity's FieldInfo objects</summary>
		private void InitProductProductPhotoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductProductPhotoFieldIndex), "ProductProductPhotoEntity");
			this.AddElementFieldInfo("ProductProductPhotoEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductProductPhotoFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductProductPhotoEntity", "Primary", typeof(System.Boolean), false, false, false, false,  (int)ProductProductPhotoFieldIndex.Primary, 0, 0, 0);
			this.AddElementFieldInfo("ProductProductPhotoEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)ProductProductPhotoFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductProductPhotoEntity", "ProductPhotoId", typeof(System.Int32), true, true, false, false,  (int)ProductProductPhotoFieldIndex.ProductPhotoId, 0, 0, 10);
		}
		/// <summary>Inits ProductReviewEntity's FieldInfo objects</summary>
		private void InitProductReviewEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductReviewFieldIndex), "ProductReviewEntity");
			this.AddElementFieldInfo("ProductReviewEntity", "Comments", typeof(System.String), false, false, false, true,  (int)ProductReviewFieldIndex.Comments, 3850, 0, 0);
			this.AddElementFieldInfo("ProductReviewEntity", "EmailAddress", typeof(System.String), false, false, false, false,  (int)ProductReviewFieldIndex.EmailAddress, 50, 0, 0);
			this.AddElementFieldInfo("ProductReviewEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductReviewFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductReviewEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)ProductReviewFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductReviewEntity", "ProductReviewId", typeof(System.Int32), true, false, true, false,  (int)ProductReviewFieldIndex.ProductReviewId, 0, 0, 10);
			this.AddElementFieldInfo("ProductReviewEntity", "Rating", typeof(System.Int32), false, false, false, false,  (int)ProductReviewFieldIndex.Rating, 0, 0, 10);
			this.AddElementFieldInfo("ProductReviewEntity", "ReviewDate", typeof(System.DateTime), false, false, false, false,  (int)ProductReviewFieldIndex.ReviewDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductReviewEntity", "ReviewerName", typeof(System.String), false, false, false, false,  (int)ProductReviewFieldIndex.ReviewerName, 50, 0, 0);
		}
		/// <summary>Inits ProductSubcategoryEntity's FieldInfo objects</summary>
		private void InitProductSubcategoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductSubcategoryFieldIndex), "ProductSubcategoryEntity");
			this.AddElementFieldInfo("ProductSubcategoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductSubcategoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductSubcategoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)ProductSubcategoryFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ProductSubcategoryEntity", "ProductCategoryId", typeof(System.Int32), false, true, false, false,  (int)ProductSubcategoryFieldIndex.ProductCategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductSubcategoryEntity", "ProductSubcategoryId", typeof(System.Int32), true, false, true, false,  (int)ProductSubcategoryFieldIndex.ProductSubcategoryId, 0, 0, 10);
			this.AddElementFieldInfo("ProductSubcategoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ProductSubcategoryFieldIndex.Rowguid, 0, 0, 0);
		}
		/// <summary>Inits ProductVendorEntity's FieldInfo objects</summary>
		private void InitProductVendorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProductVendorFieldIndex), "ProductVendorEntity");
			this.AddElementFieldInfo("ProductVendorEntity", "AverageLeadTime", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.AverageLeadTime, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "LastReceiptCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)ProductVendorFieldIndex.LastReceiptCost, 0, 4, 19);
			this.AddElementFieldInfo("ProductVendorEntity", "LastReceiptDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProductVendorFieldIndex.LastReceiptDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductVendorEntity", "MaxOrderQty", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.MaxOrderQty, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "MinOrderQty", typeof(System.Int32), false, false, false, false,  (int)ProductVendorFieldIndex.MinOrderQty, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ProductVendorFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProductVendorEntity", "OnOrderQty", typeof(Nullable<System.Int32>), false, false, false, true,  (int)ProductVendorFieldIndex.OnOrderQty, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)ProductVendorFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ProductVendorEntity", "StandardPrice", typeof(System.Decimal), false, false, false, false,  (int)ProductVendorFieldIndex.StandardPrice, 0, 4, 19);
			this.AddElementFieldInfo("ProductVendorEntity", "UnitMeasureCode", typeof(System.String), false, true, false, false,  (int)ProductVendorFieldIndex.UnitMeasureCode, 3, 0, 0);
			this.AddElementFieldInfo("ProductVendorEntity", "VendorId", typeof(System.Int32), true, true, false, false,  (int)ProductVendorFieldIndex.VendorId, 0, 0, 10);
		}
		/// <summary>Inits PurchaseOrderDetailEntity's FieldInfo objects</summary>
		private void InitPurchaseOrderDetailEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PurchaseOrderDetailFieldIndex), "PurchaseOrderDetailEntity");
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "LineTotal", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderDetailFieldIndex.LineTotal, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "OrderQty", typeof(System.Int16), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.OrderQty, 0, 0, 5);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderDetailFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "PurchaseOrderDetailId", typeof(System.Int32), true, false, true, false,  (int)PurchaseOrderDetailFieldIndex.PurchaseOrderDetailId, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "PurchaseOrderId", typeof(System.Int32), true, true, false, false,  (int)PurchaseOrderDetailFieldIndex.PurchaseOrderId, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "ReceivedQty", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.ReceivedQty, 0, 2, 8);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "RejectedQty", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.RejectedQty, 0, 2, 8);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "StockedQty", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderDetailFieldIndex.StockedQty, 0, 2, 9);
			this.AddElementFieldInfo("PurchaseOrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderDetailFieldIndex.UnitPrice, 0, 4, 19);
		}
		/// <summary>Inits PurchaseOrderHeaderEntity's FieldInfo objects</summary>
		private void InitPurchaseOrderHeaderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PurchaseOrderHeaderFieldIndex), "PurchaseOrderHeaderEntity");
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "EmployeeId", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.EmployeeId, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "Freight", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "OrderDate", typeof(System.DateTime), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "PurchaseOrderId", typeof(System.Int32), true, false, true, false,  (int)PurchaseOrderHeaderFieldIndex.PurchaseOrderId, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "RevisionNumber", typeof(System.Byte), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.RevisionNumber, 0, 0, 3);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ShipDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PurchaseOrderHeaderFieldIndex.ShipDate, 0, 0, 0);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "ShipMethodId", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.ShipMethodId, 0, 0, 10);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "Status", typeof(System.Byte), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "SubTotal", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.SubTotal, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "TaxAmt", typeof(System.Decimal), false, false, false, false,  (int)PurchaseOrderHeaderFieldIndex.TaxAmt, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "TotalDue", typeof(System.Decimal), false, false, true, false,  (int)PurchaseOrderHeaderFieldIndex.TotalDue, 0, 4, 19);
			this.AddElementFieldInfo("PurchaseOrderHeaderEntity", "VendorId", typeof(System.Int32), false, true, false, false,  (int)PurchaseOrderHeaderFieldIndex.VendorId, 0, 0, 10);
		}
		/// <summary>Inits SalesOrderDetailEntity's FieldInfo objects</summary>
		private void InitSalesOrderDetailEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesOrderDetailFieldIndex), "SalesOrderDetailEntity");
			this.AddElementFieldInfo("SalesOrderDetailEntity", "CarrierTrackingNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderDetailFieldIndex.CarrierTrackingNumber, 25, 0, 0);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "LineTotal", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderDetailFieldIndex.LineTotal, 0, 6, 38);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderDetailFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "OrderQty", typeof(System.Int16), false, false, false, false,  (int)SalesOrderDetailFieldIndex.OrderQty, 0, 0, 5);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderDetailFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesOrderDetailFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "SalesOrderDetailId", typeof(System.Int32), true, false, true, false,  (int)SalesOrderDetailFieldIndex.SalesOrderDetailId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "SalesOrderId", typeof(System.Int32), true, true, false, false,  (int)SalesOrderDetailFieldIndex.SalesOrderId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "SpecialOfferId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderDetailFieldIndex.SpecialOfferId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "UnitPrice", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderDetailFieldIndex.UnitPrice, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderDetailEntity", "UnitPriceDiscount", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderDetailFieldIndex.UnitPriceDiscount, 0, 4, 19);
		}
		/// <summary>Inits SalesOrderHeaderEntity's FieldInfo objects</summary>
		private void InitSalesOrderHeaderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesOrderHeaderFieldIndex), "SalesOrderHeaderEntity");
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "AccountNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.AccountNumber, 15, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "BillToAddressId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.BillToAddressId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Comment", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.Comment, 128, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "CreditCardApprovalCode", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.CreditCardApprovalCode, 15, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "CreditCardId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.CreditCardId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "CurrencyRateId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.CurrencyRateId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "CustomerId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Freight", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "OnlineOrderFlag", typeof(System.Boolean), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.OnlineOrderFlag, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "OrderDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "PurchaseOrderNumber", typeof(System.String), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.PurchaseOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "RevisionNumber", typeof(System.Byte), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.RevisionNumber, 0, 0, 3);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesOrderId", typeof(System.Int32), true, false, true, false,  (int)SalesOrderHeaderFieldIndex.SalesOrderId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesOrderNumber", typeof(System.String), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.SalesOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SalesPersonId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.SalesPersonId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesOrderHeaderFieldIndex.ShipDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipMethodId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipMethodId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "ShipToAddressId", typeof(System.Int32), false, true, false, false,  (int)SalesOrderHeaderFieldIndex.ShipToAddressId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "Status", typeof(System.Byte), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "SubTotal", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.SubTotal, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TaxAmt", typeof(System.Decimal), false, false, false, false,  (int)SalesOrderHeaderFieldIndex.TaxAmt, 0, 4, 19);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TerritoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesOrderHeaderFieldIndex.TerritoryId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderEntity", "TotalDue", typeof(System.Decimal), false, false, true, false,  (int)SalesOrderHeaderFieldIndex.TotalDue, 0, 4, 19);
		}
		/// <summary>Inits SalesOrderHeaderSalesReasonEntity's FieldInfo objects</summary>
		private void InitSalesOrderHeaderSalesReasonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesOrderHeaderSalesReasonFieldIndex), "SalesOrderHeaderSalesReasonEntity");
			this.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "SalesOrderId", typeof(System.Int32), true, true, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.SalesOrderId, 0, 0, 10);
			this.AddElementFieldInfo("SalesOrderHeaderSalesReasonEntity", "SalesReasonId", typeof(System.Int32), true, true, false, false,  (int)SalesOrderHeaderSalesReasonFieldIndex.SalesReasonId, 0, 0, 10);
		}
		/// <summary>Inits SalesPersonEntity's FieldInfo objects</summary>
		private void InitSalesPersonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesPersonFieldIndex), "SalesPersonEntity");
			this.AddElementFieldInfo("SalesPersonEntity", "Bonus", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.Bonus, 0, 4, 19);
			this.AddElementFieldInfo("SalesPersonEntity", "CommissionPct", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.CommissionPct, 0, 4, 10);
			this.AddElementFieldInfo("SalesPersonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesPersonFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesPersonEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesPersonFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesPersonEntity", "SalesLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.SalesLastYear, 0, 4, 19);
			this.AddElementFieldInfo("SalesPersonEntity", "SalesPersonId", typeof(System.Int32), true, true, false, false,  (int)SalesPersonFieldIndex.SalesPersonId, 0, 0, 10);
			this.AddElementFieldInfo("SalesPersonEntity", "SalesQuota", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)SalesPersonFieldIndex.SalesQuota, 0, 4, 19);
			this.AddElementFieldInfo("SalesPersonEntity", "SalesYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonFieldIndex.SalesYtd, 0, 4, 19);
			this.AddElementFieldInfo("SalesPersonEntity", "TerritoryId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)SalesPersonFieldIndex.TerritoryId, 0, 0, 10);
		}
		/// <summary>Inits SalesPersonQuotaHistoryEntity's FieldInfo objects</summary>
		private void InitSalesPersonQuotaHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesPersonQuotaHistoryFieldIndex), "SalesPersonQuotaHistoryEntity");
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "QuotaDate", typeof(System.DateTime), true, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.QuotaDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "SalesPersonId", typeof(System.Int32), true, true, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.SalesPersonId, 0, 0, 10);
			this.AddElementFieldInfo("SalesPersonQuotaHistoryEntity", "SalesQuota", typeof(System.Decimal), false, false, false, false,  (int)SalesPersonQuotaHistoryFieldIndex.SalesQuota, 0, 4, 19);
		}
		/// <summary>Inits SalesReasonEntity's FieldInfo objects</summary>
		private void InitSalesReasonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesReasonFieldIndex), "SalesReasonEntity");
			this.AddElementFieldInfo("SalesReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesReasonFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesReasonEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesReasonFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("SalesReasonEntity", "ReasonType", typeof(System.String), false, false, false, false,  (int)SalesReasonFieldIndex.ReasonType, 50, 0, 0);
			this.AddElementFieldInfo("SalesReasonEntity", "SalesReasonId", typeof(System.Int32), true, false, true, false,  (int)SalesReasonFieldIndex.SalesReasonId, 0, 0, 10);
		}
		/// <summary>Inits SalesTaxRateEntity's FieldInfo objects</summary>
		private void InitSalesTaxRateEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesTaxRateFieldIndex), "SalesTaxRateEntity");
			this.AddElementFieldInfo("SalesTaxRateEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTaxRateFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTaxRateEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesTaxRateFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("SalesTaxRateEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTaxRateFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesTaxRateEntity", "SalesTaxRateId", typeof(System.Int32), true, false, true, false,  (int)SalesTaxRateFieldIndex.SalesTaxRateId, 0, 0, 10);
			this.AddElementFieldInfo("SalesTaxRateEntity", "StateProvinceId", typeof(System.Int32), false, true, false, false,  (int)SalesTaxRateFieldIndex.StateProvinceId, 0, 0, 10);
			this.AddElementFieldInfo("SalesTaxRateEntity", "TaxRate", typeof(System.Decimal), false, false, false, false,  (int)SalesTaxRateFieldIndex.TaxRate, 0, 4, 10);
			this.AddElementFieldInfo("SalesTaxRateEntity", "TaxType", typeof(System.Byte), false, false, false, false,  (int)SalesTaxRateFieldIndex.TaxType, 0, 0, 3);
		}
		/// <summary>Inits SalesTerritoryEntity's FieldInfo objects</summary>
		private void InitSalesTerritoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesTerritoryFieldIndex), "SalesTerritoryEntity");
			this.AddElementFieldInfo("SalesTerritoryEntity", "CostLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.CostLastYear, 0, 4, 19);
			this.AddElementFieldInfo("SalesTerritoryEntity", "CostYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.CostYtd, 0, 4, 19);
			this.AddElementFieldInfo("SalesTerritoryEntity", "CountryRegionCode", typeof(System.String), false, true, false, false,  (int)SalesTerritoryFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "Group", typeof(System.String), false, false, false, false,  (int)SalesTerritoryFieldIndex.Group, 50, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTerritoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "Name", typeof(System.String), false, false, false, false,  (int)SalesTerritoryFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTerritoryFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryEntity", "SalesLastYear", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.SalesLastYear, 0, 4, 19);
			this.AddElementFieldInfo("SalesTerritoryEntity", "SalesYtd", typeof(System.Decimal), false, false, false, false,  (int)SalesTerritoryFieldIndex.SalesYtd, 0, 4, 19);
			this.AddElementFieldInfo("SalesTerritoryEntity", "TerritoryId", typeof(System.Int32), true, false, true, false,  (int)SalesTerritoryFieldIndex.TerritoryId, 0, 0, 10);
		}
		/// <summary>Inits SalesTerritoryHistoryEntity's FieldInfo objects</summary>
		private void InitSalesTerritoryHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SalesTerritoryHistoryFieldIndex), "SalesTerritoryHistoryEntity");
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)SalesTerritoryHistoryFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "SalesPersonId", typeof(System.Int32), true, true, false, false,  (int)SalesTerritoryHistoryFieldIndex.SalesPersonId, 0, 0, 10);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "StartDate", typeof(System.DateTime), true, false, false, false,  (int)SalesTerritoryHistoryFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("SalesTerritoryHistoryEntity", "TerritoryId", typeof(System.Int32), true, true, false, false,  (int)SalesTerritoryHistoryFieldIndex.TerritoryId, 0, 0, 10);
		}
		/// <summary>Inits ScrapReasonEntity's FieldInfo objects</summary>
		private void InitScrapReasonEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ScrapReasonFieldIndex), "ScrapReasonEntity");
			this.AddElementFieldInfo("ScrapReasonEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ScrapReasonFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ScrapReasonEntity", "Name", typeof(System.String), false, false, false, false,  (int)ScrapReasonFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ScrapReasonEntity", "ScrapReasonId", typeof(System.Int16), true, false, true, false,  (int)ScrapReasonFieldIndex.ScrapReasonId, 0, 0, 5);
		}
		/// <summary>Inits ShiftEntity's FieldInfo objects</summary>
		private void InitShiftEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ShiftFieldIndex), "ShiftEntity");
			this.AddElementFieldInfo("ShiftEntity", "EndTime", typeof(System.TimeSpan), false, false, false, false,  (int)ShiftFieldIndex.EndTime, 0, 0, 0);
			this.AddElementFieldInfo("ShiftEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShiftFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ShiftEntity", "Name", typeof(System.String), false, false, false, false,  (int)ShiftFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ShiftEntity", "ShiftId", typeof(System.Byte), true, false, true, false,  (int)ShiftFieldIndex.ShiftId, 0, 0, 3);
			this.AddElementFieldInfo("ShiftEntity", "StartTime", typeof(System.TimeSpan), false, false, false, false,  (int)ShiftFieldIndex.StartTime, 0, 0, 0);
		}
		/// <summary>Inits ShipMethodEntity's FieldInfo objects</summary>
		private void InitShipMethodEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ShipMethodFieldIndex), "ShipMethodEntity");
			this.AddElementFieldInfo("ShipMethodEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShipMethodFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ShipMethodEntity", "Name", typeof(System.String), false, false, false, false,  (int)ShipMethodFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("ShipMethodEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)ShipMethodFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("ShipMethodEntity", "ShipBase", typeof(System.Decimal), false, false, false, false,  (int)ShipMethodFieldIndex.ShipBase, 0, 4, 19);
			this.AddElementFieldInfo("ShipMethodEntity", "ShipMethodId", typeof(System.Int32), true, false, true, false,  (int)ShipMethodFieldIndex.ShipMethodId, 0, 0, 10);
			this.AddElementFieldInfo("ShipMethodEntity", "ShipRate", typeof(System.Decimal), false, false, false, false,  (int)ShipMethodFieldIndex.ShipRate, 0, 4, 19);
		}
		/// <summary>Inits ShoppingCartItemEntity's FieldInfo objects</summary>
		private void InitShoppingCartItemEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ShoppingCartItemFieldIndex), "ShoppingCartItemEntity");
			this.AddElementFieldInfo("ShoppingCartItemEntity", "DateCreated", typeof(System.DateTime), false, false, false, false,  (int)ShoppingCartItemFieldIndex.DateCreated, 0, 0, 0);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)ShoppingCartItemFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)ShoppingCartItemFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)ShoppingCartItemFieldIndex.Quantity, 0, 0, 10);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "ShoppingCartId", typeof(System.String), false, false, false, false,  (int)ShoppingCartItemFieldIndex.ShoppingCartId, 50, 0, 0);
			this.AddElementFieldInfo("ShoppingCartItemEntity", "ShoppingCartItemId", typeof(System.Int32), true, false, true, false,  (int)ShoppingCartItemFieldIndex.ShoppingCartItemId, 0, 0, 10);
		}
		/// <summary>Inits SpecialOfferEntity's FieldInfo objects</summary>
		private void InitSpecialOfferEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SpecialOfferFieldIndex), "SpecialOfferEntity");
			this.AddElementFieldInfo("SpecialOfferEntity", "Category", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Category, 50, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "Description", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Description, 255, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "DiscountPct", typeof(System.Decimal), false, false, false, false,  (int)SpecialOfferFieldIndex.DiscountPct, 0, 4, 10);
			this.AddElementFieldInfo("SpecialOfferEntity", "EndDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "MaxQty", typeof(Nullable<System.Int32>), false, false, false, true,  (int)SpecialOfferFieldIndex.MaxQty, 0, 0, 10);
			this.AddElementFieldInfo("SpecialOfferEntity", "MinQty", typeof(System.Int32), false, false, false, false,  (int)SpecialOfferFieldIndex.MinQty, 0, 0, 10);
			this.AddElementFieldInfo("SpecialOfferEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SpecialOfferFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "SpecialOfferId", typeof(System.Int32), true, false, true, false,  (int)SpecialOfferFieldIndex.SpecialOfferId, 0, 0, 10);
			this.AddElementFieldInfo("SpecialOfferEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferEntity", "Type", typeof(System.String), false, false, false, false,  (int)SpecialOfferFieldIndex.Type, 50, 0, 0);
		}
		/// <summary>Inits SpecialOfferProductEntity's FieldInfo objects</summary>
		private void InitSpecialOfferProductEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SpecialOfferProductFieldIndex), "SpecialOfferProductEntity");
			this.AddElementFieldInfo("SpecialOfferProductEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)SpecialOfferProductFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferProductEntity", "ProductId", typeof(System.Int32), true, true, false, false,  (int)SpecialOfferProductFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("SpecialOfferProductEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)SpecialOfferProductFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SpecialOfferProductEntity", "SpecialOfferId", typeof(System.Int32), true, true, false, false,  (int)SpecialOfferProductFieldIndex.SpecialOfferId, 0, 0, 10);
		}
		/// <summary>Inits StateProvinceEntity's FieldInfo objects</summary>
		private void InitStateProvinceEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StateProvinceFieldIndex), "StateProvinceEntity");
			this.AddElementFieldInfo("StateProvinceEntity", "CountryRegionCode", typeof(System.String), false, true, false, false,  (int)StateProvinceFieldIndex.CountryRegionCode, 3, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "IsOnlyStateProvinceFlag", typeof(System.Boolean), false, false, false, false,  (int)StateProvinceFieldIndex.IsOnlyStateProvinceFlag, 0, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)StateProvinceFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "Name", typeof(System.String), false, false, false, false,  (int)StateProvinceFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)StateProvinceFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "StateProvinceCode", typeof(System.String), false, false, false, false,  (int)StateProvinceFieldIndex.StateProvinceCode, 3, 0, 0);
			this.AddElementFieldInfo("StateProvinceEntity", "StateProvinceId", typeof(System.Int32), true, false, true, false,  (int)StateProvinceFieldIndex.StateProvinceId, 0, 0, 10);
			this.AddElementFieldInfo("StateProvinceEntity", "TerritoryId", typeof(System.Int32), false, true, false, false,  (int)StateProvinceFieldIndex.TerritoryId, 0, 0, 10);
		}
		/// <summary>Inits StoreEntity's FieldInfo objects</summary>
		private void InitStoreEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(StoreFieldIndex), "StoreEntity");
			this.AddElementFieldInfo("StoreEntity", "CustomerId", typeof(System.Int32), true, true, false, false,  (int)StoreFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("StoreEntity", "Demographics", typeof(System.String), false, false, false, true,  (int)StoreFieldIndex.Demographics, 2147483647, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)StoreFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "Name", typeof(System.String), false, false, false, false,  (int)StoreFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "Rowguid", typeof(System.Guid), false, false, false, false,  (int)StoreFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("StoreEntity", "SalesPersonId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)StoreFieldIndex.SalesPersonId, 0, 0, 10);
		}
		/// <summary>Inits TransactionHistoryEntity's FieldInfo objects</summary>
		private void InitTransactionHistoryEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TransactionHistoryFieldIndex), "TransactionHistoryEntity");
			this.AddElementFieldInfo("TransactionHistoryEntity", "ActualCost", typeof(System.Decimal), false, false, false, false,  (int)TransactionHistoryFieldIndex.ActualCost, 0, 4, 19);
			this.AddElementFieldInfo("TransactionHistoryEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("TransactionHistoryEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)TransactionHistoryFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.Quantity, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "ReferenceOrderId", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.ReferenceOrderId, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "ReferenceOrderLineId", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryFieldIndex.ReferenceOrderLineId, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "TransactionDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryFieldIndex.TransactionDate, 0, 0, 0);
			this.AddElementFieldInfo("TransactionHistoryEntity", "TransactionId", typeof(System.Int32), true, false, true, false,  (int)TransactionHistoryFieldIndex.TransactionId, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryEntity", "TransactionType", typeof(System.String), false, false, false, false,  (int)TransactionHistoryFieldIndex.TransactionType, 1, 0, 0);
		}
		/// <summary>Inits TransactionHistoryArchiveEntity's FieldInfo objects</summary>
		private void InitTransactionHistoryArchiveEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TransactionHistoryArchiveFieldIndex), "TransactionHistoryArchiveEntity");
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ActualCost", typeof(System.Decimal), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ActualCost, 0, 4, 19);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ProductId", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "Quantity", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.Quantity, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ReferenceOrderId", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ReferenceOrderId, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "ReferenceOrderLineId", typeof(System.Int32), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.ReferenceOrderLineId, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionDate", typeof(System.DateTime), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionDate, 0, 0, 0);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionId", typeof(System.Int32), true, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionId, 0, 0, 10);
			this.AddElementFieldInfo("TransactionHistoryArchiveEntity", "TransactionType", typeof(System.String), false, false, false, false,  (int)TransactionHistoryArchiveFieldIndex.TransactionType, 1, 0, 0);
		}
		/// <summary>Inits UnitMeasureEntity's FieldInfo objects</summary>
		private void InitUnitMeasureEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UnitMeasureFieldIndex), "UnitMeasureEntity");
			this.AddElementFieldInfo("UnitMeasureEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)UnitMeasureFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("UnitMeasureEntity", "Name", typeof(System.String), false, false, false, false,  (int)UnitMeasureFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("UnitMeasureEntity", "UnitMeasureCode", typeof(System.String), true, false, false, false,  (int)UnitMeasureFieldIndex.UnitMeasureCode, 3, 0, 0);
		}
		/// <summary>Inits VendorEntity's FieldInfo objects</summary>
		private void InitVendorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(VendorFieldIndex), "VendorEntity");
			this.AddElementFieldInfo("VendorEntity", "AccountNumber", typeof(System.String), false, false, false, false,  (int)VendorFieldIndex.AccountNumber, 15, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "ActiveFlag", typeof(System.Boolean), false, false, false, false,  (int)VendorFieldIndex.ActiveFlag, 0, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "CreditRating", typeof(System.Byte), false, false, false, false,  (int)VendorFieldIndex.CreditRating, 0, 0, 3);
			this.AddElementFieldInfo("VendorEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)VendorFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "Name", typeof(System.String), false, false, false, false,  (int)VendorFieldIndex.Name, 50, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "PreferredVendorStatus", typeof(System.Boolean), false, false, false, false,  (int)VendorFieldIndex.PreferredVendorStatus, 0, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "PurchasingWebServiceUrl", typeof(System.String), false, false, false, true,  (int)VendorFieldIndex.PurchasingWebServiceUrl, 1024, 0, 0);
			this.AddElementFieldInfo("VendorEntity", "VendorId", typeof(System.Int32), true, true, true, false,  (int)VendorFieldIndex.VendorId, 0, 0, 10);
		}
		/// <summary>Inits WorkOrderEntity's FieldInfo objects</summary>
		private void InitWorkOrderEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(WorkOrderFieldIndex), "WorkOrderEntity");
			this.AddElementFieldInfo("WorkOrderEntity", "DueDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderEntity", "EndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderFieldIndex.EndDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderEntity", "OrderQty", typeof(System.Int32), false, false, false, false,  (int)WorkOrderFieldIndex.OrderQty, 0, 0, 10);
			this.AddElementFieldInfo("WorkOrderEntity", "ProductId", typeof(System.Int32), false, true, false, false,  (int)WorkOrderFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("WorkOrderEntity", "ScrappedQty", typeof(System.Int16), false, false, false, false,  (int)WorkOrderFieldIndex.ScrappedQty, 0, 0, 5);
			this.AddElementFieldInfo("WorkOrderEntity", "ScrapReasonId", typeof(Nullable<System.Int16>), false, true, false, true,  (int)WorkOrderFieldIndex.ScrapReasonId, 0, 0, 5);
			this.AddElementFieldInfo("WorkOrderEntity", "StartDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderFieldIndex.StartDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderEntity", "StockedQty", typeof(System.Int32), false, false, true, false,  (int)WorkOrderFieldIndex.StockedQty, 0, 0, 10);
			this.AddElementFieldInfo("WorkOrderEntity", "WorkOrderId", typeof(System.Int32), true, false, true, false,  (int)WorkOrderFieldIndex.WorkOrderId, 0, 0, 10);
		}
		/// <summary>Inits WorkOrderRoutingEntity's FieldInfo objects</summary>
		private void InitWorkOrderRoutingEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(WorkOrderRoutingFieldIndex), "WorkOrderRoutingEntity");
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualCost", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualCost, 0, 4, 19);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualEndDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualEndDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualResourceHrs", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualResourceHrs, 0, 4, 9);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ActualStartDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)WorkOrderRoutingFieldIndex.ActualStartDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "LocationId", typeof(System.Int16), false, true, false, false,  (int)WorkOrderRoutingFieldIndex.LocationId, 0, 0, 5);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ModifiedDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ModifiedDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "OperationSequence", typeof(System.Int16), true, false, false, false,  (int)WorkOrderRoutingFieldIndex.OperationSequence, 0, 0, 5);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "PlannedCost", typeof(System.Decimal), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.PlannedCost, 0, 4, 19);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ProductId", typeof(System.Int32), true, false, false, false,  (int)WorkOrderRoutingFieldIndex.ProductId, 0, 0, 10);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ScheduledEndDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ScheduledEndDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "ScheduledStartDate", typeof(System.DateTime), false, false, false, false,  (int)WorkOrderRoutingFieldIndex.ScheduledStartDate, 0, 0, 0);
			this.AddElementFieldInfo("WorkOrderRoutingEntity", "WorkOrderId", typeof(System.Int32), true, true, false, false,  (int)WorkOrderRoutingFieldIndex.WorkOrderId, 0, 0, 10);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitSohTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SohFieldIndex), "SohTypedView");
			this.AddElementFieldInfo("SohTypedView", "SalesOrderId", typeof(System.Int32), false, false, true, false, (int)SohFieldIndex.SalesOrderId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "RevisionNumber", typeof(System.Byte), false, false, true, false, (int)SohFieldIndex.RevisionNumber, 0, 0, 3);
			this.AddElementFieldInfo("SohTypedView", "OrderDate", typeof(System.DateTime), false, false, true, false, (int)SohFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "DueDate", typeof(System.DateTime), false, false, true, false, (int)SohFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "ShipDate", typeof(Nullable<System.DateTime>), false, false, true, false, (int)SohFieldIndex.ShipDate, 0, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "Status", typeof(System.Byte), false, false, true, false, (int)SohFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("SohTypedView", "OnlineOrderFlag", typeof(System.Boolean), false, false, true, false, (int)SohFieldIndex.OnlineOrderFlag, 0, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "SalesOrderNumber", typeof(System.String), false, false, true, false, (int)SohFieldIndex.SalesOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "PurchaseOrderNumber", typeof(System.String), false, false, true, false, (int)SohFieldIndex.PurchaseOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "AccountNumber", typeof(System.String), false, false, true, false, (int)SohFieldIndex.AccountNumber, 15, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "CustomerId", typeof(System.Int32), false, false, true, false, (int)SohFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "SalesPersonId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohFieldIndex.SalesPersonId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "TerritoryId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohFieldIndex.TerritoryId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "BillToAddressId", typeof(System.Int32), false, false, true, false, (int)SohFieldIndex.BillToAddressId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "ShipToAddressId", typeof(System.Int32), false, false, true, false, (int)SohFieldIndex.ShipToAddressId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "ShipMethodId", typeof(System.Int32), false, false, true, false, (int)SohFieldIndex.ShipMethodId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "CreditCardId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohFieldIndex.CreditCardId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "CreditCardApprovalCode", typeof(System.String), false, false, true, false, (int)SohFieldIndex.CreditCardApprovalCode, 15, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "CurrencyRateId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohFieldIndex.CurrencyRateId, 0, 0, 10);
			this.AddElementFieldInfo("SohTypedView", "SubTotal", typeof(System.Decimal), false, false, true, false, (int)SohFieldIndex.SubTotal, 0, 4, 19);
			this.AddElementFieldInfo("SohTypedView", "TaxAmt", typeof(System.Decimal), false, false, true, false, (int)SohFieldIndex.TaxAmt, 0, 4, 19);
			this.AddElementFieldInfo("SohTypedView", "Freight", typeof(System.Decimal), false, false, true, false, (int)SohFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("SohTypedView", "TotalDue", typeof(System.Decimal), false, false, true, false, (int)SohFieldIndex.TotalDue, 0, 4, 19);
			this.AddElementFieldInfo("SohTypedView", "Comment", typeof(System.String), false, false, true, false, (int)SohFieldIndex.Comment, 128, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "Rowguid", typeof(System.Guid), false, false, true, false, (int)SohFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SohTypedView", "ModifiedDate", typeof(System.DateTime), false, false, true, false, (int)SohFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitSohLinqPocoTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SohLinqPocoFieldIndex), "SohLinqPocoTypedView");
			this.AddElementFieldInfo("SohLinqPocoTypedView", "SalesOrderId", typeof(System.Int32), false, false, true, false, (int)SohLinqPocoFieldIndex.SalesOrderId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "RevisionNumber", typeof(System.Byte), false, false, true, false, (int)SohLinqPocoFieldIndex.RevisionNumber, 0, 0, 3);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "OrderDate", typeof(System.DateTime), false, false, true, false, (int)SohLinqPocoFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "DueDate", typeof(System.DateTime), false, false, true, false, (int)SohLinqPocoFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "ShipDate", typeof(Nullable<System.DateTime>), false, false, true, false, (int)SohLinqPocoFieldIndex.ShipDate, 0, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "Status", typeof(System.Byte), false, false, true, false, (int)SohLinqPocoFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "OnlineOrderFlag", typeof(System.Boolean), false, false, true, false, (int)SohLinqPocoFieldIndex.OnlineOrderFlag, 0, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "SalesOrderNumber", typeof(System.String), false, false, true, false, (int)SohLinqPocoFieldIndex.SalesOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "PurchaseOrderNumber", typeof(System.String), false, false, true, false, (int)SohLinqPocoFieldIndex.PurchaseOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "AccountNumber", typeof(System.String), false, false, true, false, (int)SohLinqPocoFieldIndex.AccountNumber, 15, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "CustomerId", typeof(System.Int32), false, false, true, false, (int)SohLinqPocoFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "SalesPersonId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohLinqPocoFieldIndex.SalesPersonId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "TerritoryId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohLinqPocoFieldIndex.TerritoryId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "BillToAddressId", typeof(System.Int32), false, false, true, false, (int)SohLinqPocoFieldIndex.BillToAddressId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "ShipToAddressId", typeof(System.Int32), false, false, true, false, (int)SohLinqPocoFieldIndex.ShipToAddressId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "ShipMethodId", typeof(System.Int32), false, false, true, false, (int)SohLinqPocoFieldIndex.ShipMethodId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "CreditCardId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohLinqPocoFieldIndex.CreditCardId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "CreditCardApprovalCode", typeof(System.String), false, false, true, false, (int)SohLinqPocoFieldIndex.CreditCardApprovalCode, 15, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "CurrencyRateId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohLinqPocoFieldIndex.CurrencyRateId, 0, 0, 10);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "SubTotal", typeof(System.Decimal), false, false, true, false, (int)SohLinqPocoFieldIndex.SubTotal, 0, 4, 19);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "TaxAmt", typeof(System.Decimal), false, false, true, false, (int)SohLinqPocoFieldIndex.TaxAmt, 0, 4, 19);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "Freight", typeof(System.Decimal), false, false, true, false, (int)SohLinqPocoFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "TotalDue", typeof(System.Decimal), false, false, true, false, (int)SohLinqPocoFieldIndex.TotalDue, 0, 4, 19);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "Comment", typeof(System.String), false, false, true, false, (int)SohLinqPocoFieldIndex.Comment, 128, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "Rowguid", typeof(System.Guid), false, false, true, false, (int)SohLinqPocoFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SohLinqPocoTypedView", "ModifiedDate", typeof(System.DateTime), false, false, true, false, (int)SohLinqPocoFieldIndex.ModifiedDate, 0, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitSohQuerySpecPocoTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(SohQuerySpecPocoFieldIndex), "SohQuerySpecPocoTypedView");
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "SalesOrderId", typeof(System.Int32), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.SalesOrderId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "RevisionNumber", typeof(System.Byte), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.RevisionNumber, 0, 0, 3);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "OrderDate", typeof(System.DateTime), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.OrderDate, 0, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "DueDate", typeof(System.DateTime), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.DueDate, 0, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "ShipDate", typeof(Nullable<System.DateTime>), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.ShipDate, 0, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "Status", typeof(System.Byte), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.Status, 0, 0, 3);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "OnlineOrderFlag", typeof(System.Boolean), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.OnlineOrderFlag, 0, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "SalesOrderNumber", typeof(System.String), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.SalesOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "PurchaseOrderNumber", typeof(System.String), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.PurchaseOrderNumber, 25, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "AccountNumber", typeof(System.String), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.AccountNumber, 15, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "CustomerId", typeof(System.Int32), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.CustomerId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "SalesPersonId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.SalesPersonId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "TerritoryId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.TerritoryId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "BillToAddressId", typeof(System.Int32), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.BillToAddressId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "ShipToAddressId", typeof(System.Int32), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.ShipToAddressId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "ShipMethodId", typeof(System.Int32), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.ShipMethodId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "CreditCardId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.CreditCardId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "CreditCardApprovalCode", typeof(System.String), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.CreditCardApprovalCode, 15, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "CurrencyRateId", typeof(Nullable<System.Int32>), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.CurrencyRateId, 0, 0, 10);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "SubTotal", typeof(System.Decimal), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.SubTotal, 0, 4, 19);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "TaxAmt", typeof(System.Decimal), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.TaxAmt, 0, 4, 19);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "Freight", typeof(System.Decimal), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.Freight, 0, 4, 19);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "TotalDue", typeof(System.Decimal), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.TotalDue, 0, 4, 19);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "Comment", typeof(System.String), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.Comment, 128, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "Rowguid", typeof(System.Guid), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.Rowguid, 0, 0, 0);
			this.AddElementFieldInfo("SohQuerySpecPocoTypedView", "ModifiedDate", typeof(System.DateTime), false, false, true, false, (int)SohQuerySpecPocoFieldIndex.ModifiedDate, 0, 0, 0);
		}		
	}
}




