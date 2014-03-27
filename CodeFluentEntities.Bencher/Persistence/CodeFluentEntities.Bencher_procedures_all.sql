/* CodeFluent Generated Tuesday, 18 March 2014 16:33. TargetVersion:Default. Culture:en-US. UiCulture:en-US. Encoding:utf-8 (http://www.softfluent.com) */
set quoted_identifier OFF
GO
IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Address_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Address_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Address_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Address_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[AddressType_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[AddressType_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[AddressType_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[AddressType_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AWBuildVersion_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[AWBuildVersion_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AWBuildVersion_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[AWBuildVersion_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[BillOfMaterials_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[BillOfMaterials_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[BillOfMaterials_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[BillOfMaterials_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntity_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntity_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntity_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntity_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityAddress_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityAddress_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityAddress_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityAddress_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityContact_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityContact_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityContact_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityContact_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[ContactType_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[ContactType_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[ContactType_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[ContactType_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[CountryRegion_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[CountryRegion_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[CountryRegion_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[CountryRegion_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CountryRegionCurrency_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CountryRegionCurrency_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CountryRegionCurrency_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CountryRegionCurrency_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CreditCard_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CreditCard_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CreditCard_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CreditCard_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Culture_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Culture_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Culture_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Culture_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Currency_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Currency_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Currency_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Currency_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CurrencyRate_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CurrencyRate_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CurrencyRate_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CurrencyRate_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Customer_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Customer_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Customer_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Customer_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DatabaseLog_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[DatabaseLog_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DatabaseLog_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[DatabaseLog_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Department_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Department_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Department_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Department_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Document_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Document_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Document_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Document_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[EmailAddress_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[EmailAddress_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[EmailAddress_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[EmailAddress_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Employee_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Employee_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Employee_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Employee_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeeDepartmentHistory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeeDepartmentHistory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeeDepartmentHistory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeeDepartmentHistory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeePayHistory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeePayHistory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeePayHistory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeePayHistory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[ErrorLog_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[ErrorLog_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[ErrorLog_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[ErrorLog_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Illustration_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Illustration_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Illustration_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Illustration_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[JobCandidate_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[JobCandidate_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[JobCandidate_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[JobCandidate_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Location_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Location_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Location_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Location_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Password_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Password_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Password_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Password_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Person_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Person_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Person_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Person_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[PersonCreditCard_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[PersonCreditCard_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[PersonCreditCard_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[PersonCreditCard_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PersonPhone_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PersonPhone_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PersonPhone_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PersonPhone_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PhoneNumberType_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PhoneNumberType_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PhoneNumberType_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PhoneNumberType_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Product_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Product_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Product_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Product_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductCategory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductCategory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductCategory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductCategory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductCostHistory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductCostHistory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductCostHistory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductCostHistory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductDescription_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductDescription_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductDescription_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductDescription_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductDocument_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductDocument_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductDocument_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductDocument_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductInventory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductInventory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductInventory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductInventory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductListPriceHistory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductListPriceHistory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductListPriceHistory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductListPriceHistory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModel_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModel_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModel_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModel_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelIllustration_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelIllustration_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelIllustration_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelIllustration_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelProductDescriptionCulture_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelProductDescriptionCulture_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelProductDescriptionCulture_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelProductDescriptionCulture_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductPhoto_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductPhoto_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductPhoto_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductPhoto_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductProductPhoto_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductProductPhoto_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductProductPhoto_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductProductPhoto_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductReview_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductReview_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductReview_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductReview_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductSubcategory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductSubcategory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductSubcategory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductSubcategory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ProductVendor_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ProductVendor_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ProductVendor_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ProductVendor_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderDetail_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderDetail_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderDetail_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderDetail_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderHeader_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderHeader_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderHeader_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderHeader_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderDetail_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderDetail_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderDetail_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderDetail_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeaderSalesReason_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeaderSalesReason_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeaderSalesReason_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeaderSalesReason_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPerson_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPerson_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPerson_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPerson_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPersonQuotaHistory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPersonQuotaHistory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPersonQuotaHistory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPersonQuotaHistory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesReason_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesReason_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesReason_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesReason_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTaxRate_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTaxRate_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTaxRate_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTaxRate_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritoryHistory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritoryHistory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritoryHistory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritoryHistory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ScrapReason_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ScrapReason_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ScrapReason_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ScrapReason_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Shift_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Shift_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Shift_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Shift_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ShipMethod_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ShipMethod_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ShipMethod_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ShipMethod_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[ShoppingCartItem_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[ShoppingCartItem_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[ShoppingCartItem_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[ShoppingCartItem_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOffer_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOffer_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOffer_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOffer_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOfferProduct_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOfferProduct_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOfferProduct_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOfferProduct_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[StateProvince_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[StateProvince_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[StateProvince_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[StateProvince_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Store_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Store_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Store_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Store_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistory_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistory_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistory_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistory_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistoryArchive_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistoryArchive_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistoryArchive_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistoryArchive_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[UnitMeasure_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[UnitMeasure_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[UnitMeasure_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[UnitMeasure_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[Vendor_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[Vendor_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[Vendor_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[Vendor_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrder_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrder_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrder_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrder_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrderRouting_Delete]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrderRouting_Delete]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrderRouting_Save]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrderRouting_Save]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Address_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Address_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Address_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Address_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Address_LoadByStateProvince]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Address_LoadByStateProvince]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[AddressType_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[AddressType_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[AddressType_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[AddressType_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AWBuildVersion_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[AWBuildVersion_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[AWBuildVersion_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[AWBuildVersion_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[BillOfMaterials_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[BillOfMaterials_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[BillOfMaterials_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[BillOfMaterials_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[BillOfMaterials_LoadByUnitMeasure]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[BillOfMaterials_LoadByUnitMeasure]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntity_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntity_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntity_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntity_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityAddress_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityAddress_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityAddress_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityAddress_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityAddress_LoadByBusinessEntity]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityAddress_LoadByBusinessEntity]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityContact_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityContact_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityContact_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityContact_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityContact_LoadByBusinessEntity]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityContact_LoadByBusinessEntity]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[BusinessEntityContact_LoadByContactType]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[BusinessEntityContact_LoadByContactType]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[ContactType_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[ContactType_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[ContactType_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[ContactType_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[CountryRegion_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[CountryRegion_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[CountryRegion_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[CountryRegion_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CountryRegionCurrency_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CountryRegionCurrency_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CountryRegionCurrency_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CountryRegionCurrency_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CountryRegionCurrency_LoadByCountryRegion]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CountryRegionCurrency_LoadByCountryRegion]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CountryRegionCurrency_LoadByCurrency]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CountryRegionCurrency_LoadByCurrency]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CreditCard_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CreditCard_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CreditCard_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CreditCard_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Culture_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Culture_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Culture_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Culture_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Currency_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Currency_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Currency_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Currency_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CurrencyRate_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CurrencyRate_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CurrencyRate_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CurrencyRate_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CurrencyRate_LoadByFromCurrencyCode]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CurrencyRate_LoadByFromCurrencyCode]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[CurrencyRate_LoadByToCurrencyCode]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[CurrencyRate_LoadByToCurrencyCode]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Customer_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Customer_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Customer_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Customer_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Customer_LoadBySalesTerritory]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Customer_LoadBySalesTerritory]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DatabaseLog_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[DatabaseLog_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[DatabaseLog_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[DatabaseLog_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Department_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Department_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Department_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Department_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Document_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Document_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Document_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Document_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[EmailAddress_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[EmailAddress_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[EmailAddress_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[EmailAddress_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Employee_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Employee_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Employee_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Employee_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeeDepartmentHistory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeeDepartmentHistory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeeDepartmentHistory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeeDepartmentHistory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeeDepartmentHistory_LoadByDepartment]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeeDepartmentHistory_LoadByDepartment]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeeDepartmentHistory_LoadByShift]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeeDepartmentHistory_LoadByShift]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeePayHistory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeePayHistory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[EmployeePayHistory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[EmployeePayHistory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[ErrorLog_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[ErrorLog_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[dbo].[ErrorLog_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[ErrorLog_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Illustration_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Illustration_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Illustration_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Illustration_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[JobCandidate_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[JobCandidate_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[JobCandidate_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[JobCandidate_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Location_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Location_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Location_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Location_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Password_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Password_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Password_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Password_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Person_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Person_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Person_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Person_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[Person_LoadByBusinessEntity]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[Person_LoadByBusinessEntity]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[PersonCreditCard_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[PersonCreditCard_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[PersonCreditCard_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[PersonCreditCard_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[PersonCreditCard_LoadByCreditCard]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[PersonCreditCard_LoadByCreditCard]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PersonPhone_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PersonPhone_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PersonPhone_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PersonPhone_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PersonPhone_LoadByPhoneNumberType]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PersonPhone_LoadByPhoneNumberType]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PhoneNumberType_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PhoneNumberType_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[PhoneNumberType_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[PhoneNumberType_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Product_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Product_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Product_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Product_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Product_LoadByProductModel]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Product_LoadByProductModel]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Product_LoadByProductSubcategory]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Product_LoadByProductSubcategory]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Product_LoadBySizeUnitMeasureCode]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Product_LoadBySizeUnitMeasureCode]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[Product_LoadByWeightUnitMeasureCode]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[Product_LoadByWeightUnitMeasureCode]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductCategory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductCategory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductCategory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductCategory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductCostHistory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductCostHistory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductCostHistory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductCostHistory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductDescription_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductDescription_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductDescription_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductDescription_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductDocument_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductDocument_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductDocument_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductDocument_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductInventory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductInventory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductInventory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductInventory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductInventory_LoadByLocation]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductInventory_LoadByLocation]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductListPriceHistory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductListPriceHistory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductListPriceHistory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductListPriceHistory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModel_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModel_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModel_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModel_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelIllustration_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelIllustration_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelIllustration_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelIllustration_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelIllustration_LoadByIllustration]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelIllustration_LoadByIllustration]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelIllustration_LoadByProductModel]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelIllustration_LoadByProductModel]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelProductDescriptionCulture_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelProductDescriptionCulture_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelProductDescriptionCulture_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelProductDescriptionCulture_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelProductDescriptionCulture_LoadByCulture]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelProductDescriptionCulture_LoadByCulture]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelProductDescriptionCulture_LoadByProductDescription]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelProductDescriptionCulture_LoadByProductDescription]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductModelProductDescriptionCulture_LoadByProductModel]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductModelProductDescriptionCulture_LoadByProductModel]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductPhoto_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductPhoto_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductPhoto_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductPhoto_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductProductPhoto_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductProductPhoto_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductProductPhoto_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductProductPhoto_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductProductPhoto_LoadByProductPhoto]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductProductPhoto_LoadByProductPhoto]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductReview_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductReview_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductReview_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductReview_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductReview_LoadByProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductReview_LoadByProduct]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductSubcategory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductSubcategory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductSubcategory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductSubcategory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ProductSubcategory_LoadByProductCategory]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ProductSubcategory_LoadByProductCategory]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ProductVendor_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ProductVendor_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ProductVendor_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ProductVendor_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ProductVendor_LoadByUnitMeasure]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ProductVendor_LoadByUnitMeasure]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderDetail_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderDetail_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderDetail_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderDetail_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderDetail_LoadByProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderDetail_LoadByProduct]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderHeader_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderHeader_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderHeader_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderHeader_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[PurchaseOrderHeader_LoadByShipMethod]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[PurchaseOrderHeader_LoadByShipMethod]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderDetail_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderDetail_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderDetail_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderDetail_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderDetail_LoadByProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderDetail_LoadByProduct]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderDetail_LoadBySpecialOffer]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderDetail_LoadBySpecialOffer]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_LoadByCreditCard]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_LoadByCreditCard]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_LoadByCurrencyRate]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_LoadByCurrencyRate]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_LoadByCustomer]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_LoadByCustomer]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_LoadBySalesTerritory]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_LoadBySalesTerritory]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_LoadByShipMethod]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_LoadByShipMethod]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeaderSalesReason_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeaderSalesReason_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeaderSalesReason_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeaderSalesReason_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeaderSalesReason_LoadBySalesReason]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeaderSalesReason_LoadBySalesReason]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPerson_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPerson_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPerson_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPerson_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPerson_LoadBySalesTerritory]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPerson_LoadBySalesTerritory]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPersonQuotaHistory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPersonQuotaHistory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesPersonQuotaHistory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesPersonQuotaHistory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesReason_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesReason_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesReason_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesReason_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTaxRate_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTaxRate_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTaxRate_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTaxRate_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTaxRate_LoadByStateProvince]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTaxRate_LoadByStateProvince]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritory_LoadByCountryRegion]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritory_LoadByCountryRegion]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritoryHistory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritoryHistory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesTerritoryHistory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesTerritoryHistory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ScrapReason_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ScrapReason_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[ScrapReason_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[ScrapReason_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Shift_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Shift_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[HumanResources].[Shift_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [HumanResources].[Shift_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ShipMethod_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ShipMethod_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[ShipMethod_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[ShipMethod_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[ShoppingCartItem_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[ShoppingCartItem_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[ShoppingCartItem_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[ShoppingCartItem_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[ShoppingCartItem_LoadByProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[ShoppingCartItem_LoadByProduct]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOffer_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOffer_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOffer_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOffer_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOfferProduct_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOfferProduct_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOfferProduct_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOfferProduct_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SpecialOfferProduct_LoadBySpecialOffer]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SpecialOfferProduct_LoadBySpecialOffer]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[StateProvince_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[StateProvince_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[StateProvince_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[StateProvince_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[StateProvince_LoadByCountryRegion]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[StateProvince_LoadByCountryRegion]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Person].[StateProvince_LoadBySalesTerritory]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Person].[StateProvince_LoadBySalesTerritory]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Store_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Store_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Store_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Store_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[Store_LoadByBusinessEntity]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[Store_LoadByBusinessEntity]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistory_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistory_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistory_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistory_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistory_LoadByProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistory_LoadByProduct]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistoryArchive_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistoryArchive_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistoryArchive_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistoryArchive_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[TransactionHistoryArchive_LoadByProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[TransactionHistoryArchive_LoadByProduct]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[UnitMeasure_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[UnitMeasure_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[UnitMeasure_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[UnitMeasure_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[Vendor_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[Vendor_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[Vendor_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[Vendor_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Purchasing].[Vendor_LoadByBusinessEntity]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Purchasing].[Vendor_LoadByBusinessEntity]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrder_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrder_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrder_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrder_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrder_LoadByProduct]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrder_LoadByProduct]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrder_LoadByScrapReason]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrder_LoadByScrapReason]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrderRouting_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrderRouting_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrderRouting_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrderRouting_LoadAll]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Production].[WorkOrderRouting_LoadByLocation]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Production].[WorkOrderRouting_LoadByLocation]
GO

CREATE PROCEDURE [Person].[Address_Delete]
(
 @AddressID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[Address]
    WHERE ([Person].[Address].[AddressID] = @AddressID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[Address_Save]
(
 @AddressID [int] = NULL,
 @AddressLine1 [nvarchar] (60),
 @AddressLine2 [nvarchar] (60) = NULL,
 @City [nvarchar] (30),
 @PostalCode [nvarchar] (15),
 @SpatialLocation [geography] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @StateProvinceID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[Address] SET
 [Person].[Address].[AddressLine1] = @AddressLine1,
 [Person].[Address].[AddressLine2] = @AddressLine2,
 [Person].[Address].[City] = @City,
 [Person].[Address].[PostalCode] = @PostalCode,
 [Person].[Address].[SpatialLocation] = @SpatialLocation,
 [Person].[Address].[rowguid] = @rowguid,
 [Person].[Address].[ModifiedDate] = @ModifiedDate,
 [Person].[Address].[StateProvinceID] = @StateProvinceID
    WHERE ([Person].[Address].[AddressID] = @AddressID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[Address] (
        [Person].[Address].[AddressLine1],
        [Person].[Address].[AddressLine2],
        [Person].[Address].[City],
        [Person].[Address].[PostalCode],
        [Person].[Address].[SpatialLocation],
        [Person].[Address].[rowguid],
        [Person].[Address].[ModifiedDate],
        [Person].[Address].[StateProvinceID])
    VALUES (
        @AddressLine1,
        @AddressLine2,
        @City,
        @PostalCode,
        @SpatialLocation,
        @rowguid,
        @ModifiedDate,
        @StateProvinceID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @AddressID = SCOPE_IDENTITY() 
    SELECT DISTINCT @AddressID AS 'AddressID' 
        FROM [Person].[Address]
        WHERE ([Person].[Address].[AddressID] = @AddressID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[AddressType_Delete]
(
 @AddressTypeID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[AddressType]
    WHERE ([Person].[AddressType].[AddressTypeID] = @AddressTypeID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[AddressType_Save]
(
 @AddressTypeID [int] = NULL,
 @Name [nvarchar] (50),
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[AddressType] SET
 [Person].[AddressType].[Name] = @Name,
 [Person].[AddressType].[rowguid] = @rowguid,
 [Person].[AddressType].[ModifiedDate] = @ModifiedDate
    WHERE ([Person].[AddressType].[AddressTypeID] = @AddressTypeID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[AddressType] (
        [Person].[AddressType].[Name],
        [Person].[AddressType].[rowguid],
        [Person].[AddressType].[ModifiedDate])
    VALUES (
        @Name,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @AddressTypeID = SCOPE_IDENTITY() 
    SELECT DISTINCT @AddressTypeID AS 'AddressTypeID' 
        FROM [Person].[AddressType]
        WHERE ([Person].[AddressType].[AddressTypeID] = @AddressTypeID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [dbo].[AWBuildVersion_Delete]
(
 @SystemInformationID [tinyint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [AWBuildVersion]
    WHERE ([AWBuildVersion].[SystemInformationID] = @SystemInformationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [dbo].[AWBuildVersion_Save]
(
 @SystemInformationID [tinyint] = NULL,
 @DatabaseVersion [nvarchar] (25),
 @VersionDate [datetime],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [AWBuildVersion] SET
 [AWBuildVersion].[Database Version] = @DatabaseVersion,
 [AWBuildVersion].[VersionDate] = @VersionDate,
 [AWBuildVersion].[ModifiedDate] = @ModifiedDate
    WHERE ([AWBuildVersion].[SystemInformationID] = @SystemInformationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [AWBuildVersion] (
        [AWBuildVersion].[Database Version],
        [AWBuildVersion].[VersionDate],
        [AWBuildVersion].[ModifiedDate])
    VALUES (
        @DatabaseVersion,
        @VersionDate,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @SystemInformationID = SCOPE_IDENTITY() 
    SELECT DISTINCT @SystemInformationID AS 'SystemInformationID' 
        FROM [AWBuildVersion]
        WHERE ([AWBuildVersion].[SystemInformationID] = @SystemInformationID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[BillOfMaterials_Delete]
(
 @BillOfMaterialsID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[BillOfMaterials]
    WHERE ([Production].[BillOfMaterials].[BillOfMaterialsID] = @BillOfMaterialsID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[BillOfMaterials_Save]
(
 @BillOfMaterialsID [int] = NULL,
 @ProductAssemblyID [int] = NULL,
 @ComponentID [int],
 @StartDate [datetime],
 @EndDate [datetime] = NULL,
 @BOMLevel [smallint],
 @PerAssemblyQty [decimal] (28, 13),
 @ModifiedDate [datetime],
 @UnitMeasureCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[BillOfMaterials] SET
 [Production].[BillOfMaterials].[ProductAssemblyID] = @ProductAssemblyID,
 [Production].[BillOfMaterials].[ComponentID] = @ComponentID,
 [Production].[BillOfMaterials].[StartDate] = @StartDate,
 [Production].[BillOfMaterials].[EndDate] = @EndDate,
 [Production].[BillOfMaterials].[BOMLevel] = @BOMLevel,
 [Production].[BillOfMaterials].[PerAssemblyQty] = @PerAssemblyQty,
 [Production].[BillOfMaterials].[ModifiedDate] = @ModifiedDate,
 [Production].[BillOfMaterials].[UnitMeasureCode] = @UnitMeasureCode
    WHERE ([Production].[BillOfMaterials].[BillOfMaterialsID] = @BillOfMaterialsID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[BillOfMaterials] (
        [Production].[BillOfMaterials].[ProductAssemblyID],
        [Production].[BillOfMaterials].[ComponentID],
        [Production].[BillOfMaterials].[StartDate],
        [Production].[BillOfMaterials].[EndDate],
        [Production].[BillOfMaterials].[BOMLevel],
        [Production].[BillOfMaterials].[PerAssemblyQty],
        [Production].[BillOfMaterials].[ModifiedDate],
        [Production].[BillOfMaterials].[UnitMeasureCode])
    VALUES (
        @ProductAssemblyID,
        @ComponentID,
        @StartDate,
        @EndDate,
        @BOMLevel,
        @PerAssemblyQty,
        @ModifiedDate,
        @UnitMeasureCode)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @BillOfMaterialsID = SCOPE_IDENTITY() 
    SELECT DISTINCT @BillOfMaterialsID AS 'BillOfMaterialsID' 
        FROM [Production].[BillOfMaterials]
        WHERE ([Production].[BillOfMaterials].[BillOfMaterialsID] = @BillOfMaterialsID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntity_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[Store]
    WHERE ([Sales].[Store].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Person].[BusinessEntityAddress]
    WHERE ([Person].[BusinessEntityAddress].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Person].[BusinessEntityContact]
    WHERE ([Person].[BusinessEntityContact].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Purchasing].[Vendor]
    WHERE ([Purchasing].[Vendor].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Person].[Person]
    WHERE ([Person].[Person].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Person].[BusinessEntity]
    WHERE ([Person].[BusinessEntity].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntity_Save]
(
 @BusinessEntityID [int] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[BusinessEntity] SET
 [Person].[BusinessEntity].[rowguid] = @rowguid,
 [Person].[BusinessEntity].[ModifiedDate] = @ModifiedDate
    WHERE ([Person].[BusinessEntity].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[BusinessEntity] (
        [Person].[BusinessEntity].[rowguid],
        [Person].[BusinessEntity].[ModifiedDate])
    VALUES (
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @BusinessEntityID = SCOPE_IDENTITY() 
    SELECT DISTINCT @BusinessEntityID AS 'BusinessEntityID' 
        FROM [Person].[BusinessEntity]
        WHERE ([Person].[BusinessEntity].[BusinessEntityID] = @BusinessEntityID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityAddress_Delete]
(
 @AddressID [int],
 @AddressTypeID [int],
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[BusinessEntityAddress]
    WHERE ((([Person].[BusinessEntityAddress].[AddressID] = @AddressID) AND ([Person].[BusinessEntityAddress].[AddressTypeID] = @AddressTypeID)) AND ([Person].[BusinessEntityAddress].[BusinessEntityID] = @BusinessEntityID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityAddress_Save]
(
 @AddressID [int],
 @AddressTypeID [int],
 @BusinessEntityID [int],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[BusinessEntityAddress] SET
 [Person].[BusinessEntityAddress].[rowguid] = @rowguid,
 [Person].[BusinessEntityAddress].[ModifiedDate] = @ModifiedDate
    WHERE ((([Person].[BusinessEntityAddress].[AddressID] = @AddressID) AND ([Person].[BusinessEntityAddress].[AddressTypeID] = @AddressTypeID)) AND ([Person].[BusinessEntityAddress].[BusinessEntityID] = @BusinessEntityID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[BusinessEntityAddress] (
        [Person].[BusinessEntityAddress].[AddressID],
        [Person].[BusinessEntityAddress].[AddressTypeID],
        [Person].[BusinessEntityAddress].[rowguid],
        [Person].[BusinessEntityAddress].[ModifiedDate],
        [Person].[BusinessEntityAddress].[BusinessEntityID])
    VALUES (
        @AddressID,
        @AddressTypeID,
        @rowguid,
        @ModifiedDate,
        @BusinessEntityID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityContact_Delete]
(
 @PersonID [int],
 @BusinessEntityID [int],
 @ContactTypeID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[BusinessEntityContact]
    WHERE ((([Person].[BusinessEntityContact].[PersonID] = @PersonID) AND ([Person].[BusinessEntityContact].[BusinessEntityID] = @BusinessEntityID)) AND ([Person].[BusinessEntityContact].[ContactTypeID] = @ContactTypeID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityContact_Save]
(
 @PersonID [int],
 @BusinessEntityID [int],
 @ContactTypeID [int],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[BusinessEntityContact] SET
 [Person].[BusinessEntityContact].[rowguid] = @rowguid,
 [Person].[BusinessEntityContact].[ModifiedDate] = @ModifiedDate
    WHERE ((([Person].[BusinessEntityContact].[PersonID] = @PersonID) AND ([Person].[BusinessEntityContact].[BusinessEntityID] = @BusinessEntityID)) AND ([Person].[BusinessEntityContact].[ContactTypeID] = @ContactTypeID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[BusinessEntityContact] (
        [Person].[BusinessEntityContact].[PersonID],
        [Person].[BusinessEntityContact].[rowguid],
        [Person].[BusinessEntityContact].[ModifiedDate],
        [Person].[BusinessEntityContact].[BusinessEntityID],
        [Person].[BusinessEntityContact].[ContactTypeID])
    VALUES (
        @PersonID,
        @rowguid,
        @ModifiedDate,
        @BusinessEntityID,
        @ContactTypeID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[ContactType_Delete]
(
 @ContactTypeID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[BusinessEntityContact]
    WHERE ([Person].[BusinessEntityContact].[ContactTypeID] = @ContactTypeID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Person].[ContactType]
    WHERE ([Person].[ContactType].[ContactTypeID] = @ContactTypeID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[ContactType_Save]
(
 @ContactTypeID [int] = NULL,
 @Name [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[ContactType] SET
 [Person].[ContactType].[Name] = @Name,
 [Person].[ContactType].[ModifiedDate] = @ModifiedDate
    WHERE ([Person].[ContactType].[ContactTypeID] = @ContactTypeID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[ContactType] (
        [Person].[ContactType].[Name],
        [Person].[ContactType].[ModifiedDate])
    VALUES (
        @Name,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ContactTypeID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ContactTypeID AS 'ContactTypeID' 
        FROM [Person].[ContactType]
        WHERE ([Person].[ContactType].[ContactTypeID] = @ContactTypeID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[CountryRegion_Delete]
(
 @CountryRegionCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[StateProvince] SET
 [Person].[StateProvince].[CountryRegionCode] = NULL
    WHERE ([Person].[StateProvince].[CountryRegionCode] = @CountryRegionCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Sales].[CountryRegionCurrency]
    WHERE ([Sales].[CountryRegionCurrency].[CountryRegionCode] = @CountryRegionCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
UPDATE [Sales].[SalesTerritory] SET
 [Sales].[SalesTerritory].[CountryRegionCode] = NULL
    WHERE ([Sales].[SalesTerritory].[CountryRegionCode] = @CountryRegionCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Person].[CountryRegion]
    WHERE ([Person].[CountryRegion].[CountryRegionCode] = @CountryRegionCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[CountryRegion_Save]
(
 @CountryRegionCode [nvarchar] (3),
 @Name [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[CountryRegion] SET
 [Person].[CountryRegion].[Name] = @Name,
 [Person].[CountryRegion].[ModifiedDate] = @ModifiedDate
    WHERE ([Person].[CountryRegion].[CountryRegionCode] = @CountryRegionCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[CountryRegion] (
        [Person].[CountryRegion].[CountryRegionCode],
        [Person].[CountryRegion].[Name],
        [Person].[CountryRegion].[ModifiedDate])
    VALUES (
        @CountryRegionCode,
        @Name,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[CountryRegionCurrency_Delete]
(
 @CountryRegionCode [nvarchar] (3),
 @CurrencyCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[CountryRegionCurrency]
    WHERE (([Sales].[CountryRegionCurrency].[CountryRegionCode] = @CountryRegionCode) AND ([Sales].[CountryRegionCurrency].[CurrencyCode] = @CurrencyCode))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[CountryRegionCurrency_Save]
(
 @CountryRegionCode [nvarchar] (3),
 @CurrencyCode [nvarchar] (3),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[CountryRegionCurrency] SET
 [Sales].[CountryRegionCurrency].[ModifiedDate] = @ModifiedDate
    WHERE (([Sales].[CountryRegionCurrency].[CountryRegionCode] = @CountryRegionCode) AND ([Sales].[CountryRegionCurrency].[CurrencyCode] = @CurrencyCode))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[CountryRegionCurrency] (
        [Sales].[CountryRegionCurrency].[ModifiedDate],
        [Sales].[CountryRegionCurrency].[CountryRegionCode],
        [Sales].[CountryRegionCurrency].[CurrencyCode])
    VALUES (
        @ModifiedDate,
        @CountryRegionCode,
        @CurrencyCode)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[CreditCard_Delete]
(
 @CreditCardID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesOrderHeader] SET
 [Sales].[SalesOrderHeader].[CreditCardID] = NULL
    WHERE ([Sales].[SalesOrderHeader].[CreditCardID] = @CreditCardID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Sales].[PersonCreditCard]
    WHERE ([Sales].[PersonCreditCard].[CreditCardID] = @CreditCardID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Sales].[CreditCard]
    WHERE ([Sales].[CreditCard].[CreditCardID] = @CreditCardID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[CreditCard_Save]
(
 @CreditCardID [int] = NULL,
 @CardType [nvarchar] (50),
 @CardNumber [nvarchar] (25),
 @ExpMonth [tinyint],
 @ExpYear [smallint],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[CreditCard] SET
 [Sales].[CreditCard].[CardType] = @CardType,
 [Sales].[CreditCard].[CardNumber] = @CardNumber,
 [Sales].[CreditCard].[ExpMonth] = @ExpMonth,
 [Sales].[CreditCard].[ExpYear] = @ExpYear,
 [Sales].[CreditCard].[ModifiedDate] = @ModifiedDate
    WHERE ([Sales].[CreditCard].[CreditCardID] = @CreditCardID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[CreditCard] (
        [Sales].[CreditCard].[CardType],
        [Sales].[CreditCard].[CardNumber],
        [Sales].[CreditCard].[ExpMonth],
        [Sales].[CreditCard].[ExpYear],
        [Sales].[CreditCard].[ModifiedDate])
    VALUES (
        @CardType,
        @CardNumber,
        @ExpMonth,
        @ExpYear,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @CreditCardID = SCOPE_IDENTITY() 
    SELECT DISTINCT @CreditCardID AS 'CreditCardID' 
        FROM [Sales].[CreditCard]
        WHERE ([Sales].[CreditCard].[CreditCardID] = @CreditCardID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Culture_Delete]
(
 @CultureID [nvarchar] (6)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductModelProductDescriptionCulture]
    WHERE ([Production].[ProductModelProductDescriptionCulture].[CultureID] = @CultureID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Production].[Culture]
    WHERE ([Production].[Culture].[CultureID] = @CultureID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Culture_Save]
(
 @CultureID [nvarchar] (6),
 @Name [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[Culture] SET
 [Production].[Culture].[Name] = @Name,
 [Production].[Culture].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[Culture].[CultureID] = @CultureID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[Culture] (
        [Production].[Culture].[CultureID],
        [Production].[Culture].[Name],
        [Production].[Culture].[ModifiedDate])
    VALUES (
        @CultureID,
        @Name,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[Currency_Delete]
(
 @CurrencyCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[CountryRegionCurrency]
    WHERE ([Sales].[CountryRegionCurrency].[CurrencyCode] = @CurrencyCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
UPDATE [Sales].[CurrencyRate] SET
 [Sales].[CurrencyRate].[FromCurrencyCode] = NULL
    WHERE ([Sales].[CurrencyRate].[FromCurrencyCode] = @CurrencyCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Sales].[CurrencyRate] SET
 [Sales].[CurrencyRate].[ToCurrencyCode] = NULL
    WHERE ([Sales].[CurrencyRate].[ToCurrencyCode] = @CurrencyCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Sales].[Currency]
    WHERE ([Sales].[Currency].[CurrencyCode] = @CurrencyCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[Currency_Save]
(
 @CurrencyCode [nvarchar] (3),
 @Name [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[Currency] SET
 [Sales].[Currency].[Name] = @Name,
 [Sales].[Currency].[ModifiedDate] = @ModifiedDate
    WHERE ([Sales].[Currency].[CurrencyCode] = @CurrencyCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[Currency] (
        [Sales].[Currency].[CurrencyCode],
        [Sales].[Currency].[Name],
        [Sales].[Currency].[ModifiedDate])
    VALUES (
        @CurrencyCode,
        @Name,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[CurrencyRate_Delete]
(
 @CurrencyRateID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesOrderHeader] SET
 [Sales].[SalesOrderHeader].[CurrencyRateID] = NULL
    WHERE ([Sales].[SalesOrderHeader].[CurrencyRateID] = @CurrencyRateID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Sales].[CurrencyRate]
    WHERE ([Sales].[CurrencyRate].[CurrencyRateID] = @CurrencyRateID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[CurrencyRate_Save]
(
 @CurrencyRateID [int] = NULL,
 @CurrencyRateDate [datetime],
 @AverageRate [money],
 @EndOfDayRate [money],
 @ModifiedDate [datetime],
 @FromCurrencyCode [nvarchar] (3),
 @ToCurrencyCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[CurrencyRate] SET
 [Sales].[CurrencyRate].[CurrencyRateDate] = @CurrencyRateDate,
 [Sales].[CurrencyRate].[AverageRate] = @AverageRate,
 [Sales].[CurrencyRate].[EndOfDayRate] = @EndOfDayRate,
 [Sales].[CurrencyRate].[ModifiedDate] = @ModifiedDate,
 [Sales].[CurrencyRate].[FromCurrencyCode] = @FromCurrencyCode,
 [Sales].[CurrencyRate].[ToCurrencyCode] = @ToCurrencyCode
    WHERE ([Sales].[CurrencyRate].[CurrencyRateID] = @CurrencyRateID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[CurrencyRate] (
        [Sales].[CurrencyRate].[CurrencyRateDate],
        [Sales].[CurrencyRate].[AverageRate],
        [Sales].[CurrencyRate].[EndOfDayRate],
        [Sales].[CurrencyRate].[ModifiedDate],
        [Sales].[CurrencyRate].[FromCurrencyCode],
        [Sales].[CurrencyRate].[ToCurrencyCode])
    VALUES (
        @CurrencyRateDate,
        @AverageRate,
        @EndOfDayRate,
        @ModifiedDate,
        @FromCurrencyCode,
        @ToCurrencyCode)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @CurrencyRateID = SCOPE_IDENTITY() 
    SELECT DISTINCT @CurrencyRateID AS 'CurrencyRateID' 
        FROM [Sales].[CurrencyRate]
        WHERE ([Sales].[CurrencyRate].[CurrencyRateID] = @CurrencyRateID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[Customer_Delete]
(
 @CustomerID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesOrderHeader] SET
 [Sales].[SalesOrderHeader].[CustomerID] = NULL
    WHERE ([Sales].[SalesOrderHeader].[CustomerID] = @CustomerID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Sales].[Customer]
    WHERE ([Sales].[Customer].[CustomerID] = @CustomerID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[Customer_Save]
(
 @CustomerID [int] = NULL,
 @PersonID [int] = NULL,
 @StoreID [int] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @TerritoryID [int] = NULL
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[Customer] SET
 [Sales].[Customer].[PersonID] = @PersonID,
 [Sales].[Customer].[StoreID] = @StoreID,
 [Sales].[Customer].[rowguid] = @rowguid,
 [Sales].[Customer].[ModifiedDate] = @ModifiedDate,
 [Sales].[Customer].[TerritoryID] = @TerritoryID
    WHERE ([Sales].[Customer].[CustomerID] = @CustomerID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[Customer] (
        [Sales].[Customer].[PersonID],
        [Sales].[Customer].[StoreID],
        [Sales].[Customer].[rowguid],
        [Sales].[Customer].[ModifiedDate],
        [Sales].[Customer].[TerritoryID])
    VALUES (
        @PersonID,
        @StoreID,
        @rowguid,
        @ModifiedDate,
        @TerritoryID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @CustomerID = SCOPE_IDENTITY() 
    SELECT DISTINCT @CustomerID AS 'CustomerID' 
        FROM [Sales].[Customer]
        WHERE ([Sales].[Customer].[CustomerID] = @CustomerID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [dbo].[DatabaseLog_Delete]
(
 @DatabaseLogID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [DatabaseLog]
    WHERE ([DatabaseLog].[DatabaseLogID] = @DatabaseLogID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [dbo].[DatabaseLog_Save]
(
 @DatabaseLogID [int] = NULL,
 @PostTime [datetime],
 @DatabaseUser [nvarchar] (128),
 @Event [nvarchar] (128),
 @Schema [nvarchar] (128) = NULL,
 @Object [nvarchar] (128) = NULL,
 @TSQL [nvarchar] (max),
 @XmlEvent [xml]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [DatabaseLog] SET
 [DatabaseLog].[PostTime] = @PostTime,
 [DatabaseLog].[DatabaseUser] = @DatabaseUser,
 [DatabaseLog].[Event] = @Event,
 [DatabaseLog].[Schema] = @Schema,
 [DatabaseLog].[Object] = @Object,
 [DatabaseLog].[TSQL] = @TSQL,
 [DatabaseLog].[XmlEvent] = @XmlEvent
    WHERE ([DatabaseLog].[DatabaseLogID] = @DatabaseLogID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [DatabaseLog] (
        [DatabaseLog].[PostTime],
        [DatabaseLog].[DatabaseUser],
        [DatabaseLog].[Event],
        [DatabaseLog].[Schema],
        [DatabaseLog].[Object],
        [DatabaseLog].[TSQL],
        [DatabaseLog].[XmlEvent])
    VALUES (
        @PostTime,
        @DatabaseUser,
        @Event,
        @Schema,
        @Object,
        @TSQL,
        @XmlEvent)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @DatabaseLogID = SCOPE_IDENTITY() 
    SELECT DISTINCT @DatabaseLogID AS 'DatabaseLogID' 
        FROM [DatabaseLog]
        WHERE ([DatabaseLog].[DatabaseLogID] = @DatabaseLogID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[Department_Delete]
(
 @DepartmentID [smallint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [HumanResources].[EmployeeDepartmentHistory]
    WHERE ([HumanResources].[EmployeeDepartmentHistory].[DepartmentID] = @DepartmentID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [HumanResources].[Department]
    WHERE ([HumanResources].[Department].[DepartmentID] = @DepartmentID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[Department_Save]
(
 @DepartmentID [smallint] = NULL,
 @Name [nvarchar] (50),
 @GroupName [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [HumanResources].[Department] SET
 [HumanResources].[Department].[Name] = @Name,
 [HumanResources].[Department].[GroupName] = @GroupName,
 [HumanResources].[Department].[ModifiedDate] = @ModifiedDate
    WHERE ([HumanResources].[Department].[DepartmentID] = @DepartmentID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [HumanResources].[Department] (
        [HumanResources].[Department].[Name],
        [HumanResources].[Department].[GroupName],
        [HumanResources].[Department].[ModifiedDate])
    VALUES (
        @Name,
        @GroupName,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @DepartmentID = SCOPE_IDENTITY() 
    SELECT DISTINCT @DepartmentID AS 'DepartmentID' 
        FROM [HumanResources].[Department]
        WHERE ([HumanResources].[Department].[DepartmentID] = @DepartmentID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Document_Delete]
(
 @Title [nvarchar] (50)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[Document]
    WHERE ([Production].[Document].[Title] = @Title)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Document_Save]
(
 @Title [nvarchar] (50),
 @DocumentNode [hierarchyid],
 @Owner [int],
 @FolderFlag [bit],
 @FileName [nvarchar] (400),
 @FileExtension [nvarchar] (8),
 @Revision [nvarchar] (5),
 @ChangeNumber [int],
 @Status [tinyint],
 @DocumentSummary [nvarchar] (max) = NULL,
 @Document [varbinary] (max) = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[Document] SET
 [Production].[Document].[DocumentNode] = @DocumentNode,
 [Production].[Document].[Owner] = @Owner,
 [Production].[Document].[FolderFlag] = @FolderFlag,
 [Production].[Document].[FileName] = @FileName,
 [Production].[Document].[FileExtension] = @FileExtension,
 [Production].[Document].[Revision] = @Revision,
 [Production].[Document].[ChangeNumber] = @ChangeNumber,
 [Production].[Document].[Status] = @Status,
 [Production].[Document].[DocumentSummary] = @DocumentSummary,
 [Production].[Document].[Document] = @Document,
 [Production].[Document].[rowguid] = @rowguid,
 [Production].[Document].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[Document].[Title] = @Title)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[Document] (
        [Production].[Document].[DocumentNode],
        [Production].[Document].[Title],
        [Production].[Document].[Owner],
        [Production].[Document].[FolderFlag],
        [Production].[Document].[FileName],
        [Production].[Document].[FileExtension],
        [Production].[Document].[Revision],
        [Production].[Document].[ChangeNumber],
        [Production].[Document].[Status],
        [Production].[Document].[DocumentSummary],
        [Production].[Document].[Document],
        [Production].[Document].[rowguid],
        [Production].[Document].[ModifiedDate])
    VALUES (
        @DocumentNode,
        @Title,
        @Owner,
        @FolderFlag,
        @FileName,
        @FileExtension,
        @Revision,
        @ChangeNumber,
        @Status,
        @DocumentSummary,
        @Document,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[EmailAddress_Delete]
(
 @BusinessEntityID [int],
 @EmailAddressID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[EmailAddress]
    WHERE (([Person].[EmailAddress].[BusinessEntityID] = @BusinessEntityID) AND ([Person].[EmailAddress].[EmailAddressID] = @EmailAddressID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[EmailAddress_Save]
(
 @BusinessEntityID [int],
 @EmailAddressID [int] = NULL,
 @EmailAddress [nvarchar] (50) = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[EmailAddress] SET
 [Person].[EmailAddress].[EmailAddress] = @EmailAddress,
 [Person].[EmailAddress].[rowguid] = @rowguid,
 [Person].[EmailAddress].[ModifiedDate] = @ModifiedDate
    WHERE (([Person].[EmailAddress].[BusinessEntityID] = @BusinessEntityID) AND ([Person].[EmailAddress].[EmailAddressID] = @EmailAddressID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[EmailAddress] (
        [Person].[EmailAddress].[BusinessEntityID],
        [Person].[EmailAddress].[EmailAddress],
        [Person].[EmailAddress].[rowguid],
        [Person].[EmailAddress].[ModifiedDate])
    VALUES (
        @BusinessEntityID,
        @EmailAddress,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @EmailAddressID = SCOPE_IDENTITY() 
    SELECT DISTINCT @EmailAddressID AS 'EmailAddressID' 
        FROM [Person].[EmailAddress]
        WHERE (([Person].[EmailAddress].[BusinessEntityID] = @BusinessEntityID) AND ([Person].[EmailAddress].[EmailAddressID] = @EmailAddressID))
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[Employee_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [HumanResources].[Employee]
    WHERE ([HumanResources].[Employee].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[Employee_Save]
(
 @BusinessEntityID [int],
 @NationalIDNumber [nvarchar] (15),
 @LoginID [nvarchar] (256),
 @OrganizationNode [hierarchyid] = NULL,
 @JobTitle [nvarchar] (50),
 @BirthDate [datetime],
 @MaritalStatus [nvarchar] (1),
 @Gender [nvarchar] (1),
 @HireDate [datetime],
 @SalariedFlag [bit],
 @VacationHours [smallint],
 @SickLeaveHours [smallint],
 @CurrentFlag [bit],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [HumanResources].[Employee] SET
 [HumanResources].[Employee].[NationalIDNumber] = @NationalIDNumber,
 [HumanResources].[Employee].[LoginID] = @LoginID,
 [HumanResources].[Employee].[OrganizationNode] = @OrganizationNode,
 [HumanResources].[Employee].[JobTitle] = @JobTitle,
 [HumanResources].[Employee].[BirthDate] = @BirthDate,
 [HumanResources].[Employee].[MaritalStatus] = @MaritalStatus,
 [HumanResources].[Employee].[Gender] = @Gender,
 [HumanResources].[Employee].[HireDate] = @HireDate,
 [HumanResources].[Employee].[SalariedFlag] = @SalariedFlag,
 [HumanResources].[Employee].[VacationHours] = @VacationHours,
 [HumanResources].[Employee].[SickLeaveHours] = @SickLeaveHours,
 [HumanResources].[Employee].[CurrentFlag] = @CurrentFlag,
 [HumanResources].[Employee].[rowguid] = @rowguid,
 [HumanResources].[Employee].[ModifiedDate] = @ModifiedDate
    WHERE ([HumanResources].[Employee].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [HumanResources].[Employee] (
        [HumanResources].[Employee].[BusinessEntityID],
        [HumanResources].[Employee].[NationalIDNumber],
        [HumanResources].[Employee].[LoginID],
        [HumanResources].[Employee].[OrganizationNode],
        [HumanResources].[Employee].[JobTitle],
        [HumanResources].[Employee].[BirthDate],
        [HumanResources].[Employee].[MaritalStatus],
        [HumanResources].[Employee].[Gender],
        [HumanResources].[Employee].[HireDate],
        [HumanResources].[Employee].[SalariedFlag],
        [HumanResources].[Employee].[VacationHours],
        [HumanResources].[Employee].[SickLeaveHours],
        [HumanResources].[Employee].[CurrentFlag],
        [HumanResources].[Employee].[rowguid],
        [HumanResources].[Employee].[ModifiedDate])
    VALUES (
        @BusinessEntityID,
        @NationalIDNumber,
        @LoginID,
        @OrganizationNode,
        @JobTitle,
        @BirthDate,
        @MaritalStatus,
        @Gender,
        @HireDate,
        @SalariedFlag,
        @VacationHours,
        @SickLeaveHours,
        @CurrentFlag,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeeDepartmentHistory_Delete]
(
 @BusinessEntityID [int],
 @DepartmentID [smallint],
 @ShiftID [tinyint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [HumanResources].[EmployeeDepartmentHistory]
    WHERE ((([HumanResources].[EmployeeDepartmentHistory].[BusinessEntityID] = @BusinessEntityID) AND ([HumanResources].[EmployeeDepartmentHistory].[DepartmentID] = @DepartmentID)) AND ([HumanResources].[EmployeeDepartmentHistory].[ShiftID] = @ShiftID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeeDepartmentHistory_Save]
(
 @BusinessEntityID [int],
 @DepartmentID [smallint],
 @ShiftID [tinyint],
 @StartDate [datetime],
 @EndDate [datetime] = NULL,
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [HumanResources].[EmployeeDepartmentHistory] SET
 [HumanResources].[EmployeeDepartmentHistory].[StartDate] = @StartDate,
 [HumanResources].[EmployeeDepartmentHistory].[EndDate] = @EndDate,
 [HumanResources].[EmployeeDepartmentHistory].[ModifiedDate] = @ModifiedDate
    WHERE ((([HumanResources].[EmployeeDepartmentHistory].[BusinessEntityID] = @BusinessEntityID) AND ([HumanResources].[EmployeeDepartmentHistory].[DepartmentID] = @DepartmentID)) AND ([HumanResources].[EmployeeDepartmentHistory].[ShiftID] = @ShiftID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [HumanResources].[EmployeeDepartmentHistory] (
        [HumanResources].[EmployeeDepartmentHistory].[BusinessEntityID],
        [HumanResources].[EmployeeDepartmentHistory].[StartDate],
        [HumanResources].[EmployeeDepartmentHistory].[EndDate],
        [HumanResources].[EmployeeDepartmentHistory].[ModifiedDate],
        [HumanResources].[EmployeeDepartmentHistory].[DepartmentID],
        [HumanResources].[EmployeeDepartmentHistory].[ShiftID])
    VALUES (
        @BusinessEntityID,
        @StartDate,
        @EndDate,
        @ModifiedDate,
        @DepartmentID,
        @ShiftID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeePayHistory_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [HumanResources].[EmployeePayHistory]
    WHERE ([HumanResources].[EmployeePayHistory].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeePayHistory_Save]
(
 @BusinessEntityID [int],
 @RateChangeDate [datetime],
 @Rate [money],
 @PayFrequency [tinyint],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [HumanResources].[EmployeePayHistory] SET
 [HumanResources].[EmployeePayHistory].[RateChangeDate] = @RateChangeDate,
 [HumanResources].[EmployeePayHistory].[Rate] = @Rate,
 [HumanResources].[EmployeePayHistory].[PayFrequency] = @PayFrequency,
 [HumanResources].[EmployeePayHistory].[ModifiedDate] = @ModifiedDate
    WHERE ([HumanResources].[EmployeePayHistory].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [HumanResources].[EmployeePayHistory] (
        [HumanResources].[EmployeePayHistory].[BusinessEntityID],
        [HumanResources].[EmployeePayHistory].[RateChangeDate],
        [HumanResources].[EmployeePayHistory].[Rate],
        [HumanResources].[EmployeePayHistory].[PayFrequency],
        [HumanResources].[EmployeePayHistory].[ModifiedDate])
    VALUES (
        @BusinessEntityID,
        @RateChangeDate,
        @Rate,
        @PayFrequency,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [dbo].[ErrorLog_Delete]
(
 @ErrorLogID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [ErrorLog]
    WHERE ([ErrorLog].[ErrorLogID] = @ErrorLogID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [dbo].[ErrorLog_Save]
(
 @ErrorLogID [int] = NULL,
 @ErrorTime [datetime],
 @UserName [nvarchar] (128),
 @ErrorNumber [int],
 @ErrorSeverity [int] = NULL,
 @ErrorState [int] = NULL,
 @ErrorProcedure [nvarchar] (126) = NULL,
 @ErrorLine [int] = NULL,
 @ErrorMessage [nvarchar] (4000)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [ErrorLog] SET
 [ErrorLog].[ErrorTime] = @ErrorTime,
 [ErrorLog].[UserName] = @UserName,
 [ErrorLog].[ErrorNumber] = @ErrorNumber,
 [ErrorLog].[ErrorSeverity] = @ErrorSeverity,
 [ErrorLog].[ErrorState] = @ErrorState,
 [ErrorLog].[ErrorProcedure] = @ErrorProcedure,
 [ErrorLog].[ErrorLine] = @ErrorLine,
 [ErrorLog].[ErrorMessage] = @ErrorMessage
    WHERE ([ErrorLog].[ErrorLogID] = @ErrorLogID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [ErrorLog] (
        [ErrorLog].[ErrorTime],
        [ErrorLog].[UserName],
        [ErrorLog].[ErrorNumber],
        [ErrorLog].[ErrorSeverity],
        [ErrorLog].[ErrorState],
        [ErrorLog].[ErrorProcedure],
        [ErrorLog].[ErrorLine],
        [ErrorLog].[ErrorMessage])
    VALUES (
        @ErrorTime,
        @UserName,
        @ErrorNumber,
        @ErrorSeverity,
        @ErrorState,
        @ErrorProcedure,
        @ErrorLine,
        @ErrorMessage)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ErrorLogID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ErrorLogID AS 'ErrorLogID' 
        FROM [ErrorLog]
        WHERE ([ErrorLog].[ErrorLogID] = @ErrorLogID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Illustration_Delete]
(
 @IllustrationID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductModelIllustration]
    WHERE ([Production].[ProductModelIllustration].[IllustrationID] = @IllustrationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Production].[Illustration]
    WHERE ([Production].[Illustration].[IllustrationID] = @IllustrationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Illustration_Save]
(
 @IllustrationID [int] = NULL,
 @Diagram [xml] = NULL,
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[Illustration] SET
 [Production].[Illustration].[Diagram] = @Diagram,
 [Production].[Illustration].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[Illustration].[IllustrationID] = @IllustrationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[Illustration] (
        [Production].[Illustration].[Diagram],
        [Production].[Illustration].[ModifiedDate])
    VALUES (
        @Diagram,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @IllustrationID = SCOPE_IDENTITY() 
    SELECT DISTINCT @IllustrationID AS 'IllustrationID' 
        FROM [Production].[Illustration]
        WHERE ([Production].[Illustration].[IllustrationID] = @IllustrationID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[JobCandidate_Delete]
(
 @JobCandidateID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [HumanResources].[JobCandidate]
    WHERE ([HumanResources].[JobCandidate].[JobCandidateID] = @JobCandidateID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[JobCandidate_Save]
(
 @JobCandidateID [int] = NULL,
 @BusinessEntityID [int] = NULL,
 @Resume [xml] = NULL,
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [HumanResources].[JobCandidate] SET
 [HumanResources].[JobCandidate].[BusinessEntityID] = @BusinessEntityID,
 [HumanResources].[JobCandidate].[Resume] = @Resume,
 [HumanResources].[JobCandidate].[ModifiedDate] = @ModifiedDate
    WHERE ([HumanResources].[JobCandidate].[JobCandidateID] = @JobCandidateID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [HumanResources].[JobCandidate] (
        [HumanResources].[JobCandidate].[BusinessEntityID],
        [HumanResources].[JobCandidate].[Resume],
        [HumanResources].[JobCandidate].[ModifiedDate])
    VALUES (
        @BusinessEntityID,
        @Resume,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @JobCandidateID = SCOPE_IDENTITY() 
    SELECT DISTINCT @JobCandidateID AS 'JobCandidateID' 
        FROM [HumanResources].[JobCandidate]
        WHERE ([HumanResources].[JobCandidate].[JobCandidateID] = @JobCandidateID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Location_Delete]
(
 @LocationID [smallint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductInventory]
    WHERE ([Production].[ProductInventory].[LocationID] = @LocationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
UPDATE [Production].[WorkOrderRouting] SET
 [Production].[WorkOrderRouting].[LocationID] = NULL
    WHERE ([Production].[WorkOrderRouting].[LocationID] = @LocationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Production].[Location]
    WHERE ([Production].[Location].[LocationID] = @LocationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Location_Save]
(
 @LocationID [smallint] = NULL,
 @Name [nvarchar] (50),
 @CostRate [money],
 @Availability [decimal] (28, 13),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[Location] SET
 [Production].[Location].[Name] = @Name,
 [Production].[Location].[CostRate] = @CostRate,
 [Production].[Location].[Availability] = @Availability,
 [Production].[Location].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[Location].[LocationID] = @LocationID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[Location] (
        [Production].[Location].[Name],
        [Production].[Location].[CostRate],
        [Production].[Location].[Availability],
        [Production].[Location].[ModifiedDate])
    VALUES (
        @Name,
        @CostRate,
        @Availability,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @LocationID = SCOPE_IDENTITY() 
    SELECT DISTINCT @LocationID AS 'LocationID' 
        FROM [Production].[Location]
        WHERE ([Production].[Location].[LocationID] = @LocationID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[Password_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[Password]
    WHERE ([Person].[Password].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[Password_Save]
(
 @BusinessEntityID [int],
 @PasswordHash [varchar] (128),
 @PasswordSalt [varchar] (10),
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[Password] SET
 [Person].[Password].[PasswordHash] = @PasswordHash,
 [Person].[Password].[PasswordSalt] = @PasswordSalt,
 [Person].[Password].[rowguid] = @rowguid,
 [Person].[Password].[ModifiedDate] = @ModifiedDate
    WHERE ([Person].[Password].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[Password] (
        [Person].[Password].[BusinessEntityID],
        [Person].[Password].[PasswordHash],
        [Person].[Password].[PasswordSalt],
        [Person].[Password].[rowguid],
        [Person].[Password].[ModifiedDate])
    VALUES (
        @BusinessEntityID,
        @PasswordHash,
        @PasswordSalt,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[Person_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[Person]
    WHERE ([Person].[Person].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[Person_Save]
(
 @BusinessEntityID [int],
 @PersonType [nvarchar] (2),
 @NameStyle [bit],
 @Title [nvarchar] (8) = NULL,
 @FirstName [nvarchar] (50),
 @MiddleName [nvarchar] (50) = NULL,
 @LastName [nvarchar] (50),
 @Suffix [nvarchar] (10) = NULL,
 @EmailPromotion [int],
 @AdditionalContactInfo [xml] = NULL,
 @Demographics [xml] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[Person] SET
 [Person].[Person].[PersonType] = @PersonType,
 [Person].[Person].[NameStyle] = @NameStyle,
 [Person].[Person].[Title] = @Title,
 [Person].[Person].[FirstName] = @FirstName,
 [Person].[Person].[MiddleName] = @MiddleName,
 [Person].[Person].[LastName] = @LastName,
 [Person].[Person].[Suffix] = @Suffix,
 [Person].[Person].[EmailPromotion] = @EmailPromotion,
 [Person].[Person].[AdditionalContactInfo] = @AdditionalContactInfo,
 [Person].[Person].[Demographics] = @Demographics,
 [Person].[Person].[rowguid] = @rowguid,
 [Person].[Person].[ModifiedDate] = @ModifiedDate
    WHERE ([Person].[Person].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[Person] (
        [Person].[Person].[PersonType],
        [Person].[Person].[NameStyle],
        [Person].[Person].[Title],
        [Person].[Person].[FirstName],
        [Person].[Person].[MiddleName],
        [Person].[Person].[LastName],
        [Person].[Person].[Suffix],
        [Person].[Person].[EmailPromotion],
        [Person].[Person].[AdditionalContactInfo],
        [Person].[Person].[Demographics],
        [Person].[Person].[rowguid],
        [Person].[Person].[ModifiedDate],
        [Person].[Person].[BusinessEntityID])
    VALUES (
        @PersonType,
        @NameStyle,
        @Title,
        @FirstName,
        @MiddleName,
        @LastName,
        @Suffix,
        @EmailPromotion,
        @AdditionalContactInfo,
        @Demographics,
        @rowguid,
        @ModifiedDate,
        @BusinessEntityID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[PersonCreditCard_Delete]
(
 @BusinessEntityID [int],
 @CreditCardID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[PersonCreditCard]
    WHERE (([Sales].[PersonCreditCard].[BusinessEntityID] = @BusinessEntityID) AND ([Sales].[PersonCreditCard].[CreditCardID] = @CreditCardID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[PersonCreditCard_Save]
(
 @BusinessEntityID [int],
 @CreditCardID [int],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[PersonCreditCard] SET
 [Sales].[PersonCreditCard].[ModifiedDate] = @ModifiedDate
    WHERE (([Sales].[PersonCreditCard].[BusinessEntityID] = @BusinessEntityID) AND ([Sales].[PersonCreditCard].[CreditCardID] = @CreditCardID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[PersonCreditCard] (
        [Sales].[PersonCreditCard].[BusinessEntityID],
        [Sales].[PersonCreditCard].[ModifiedDate],
        [Sales].[PersonCreditCard].[CreditCardID])
    VALUES (
        @BusinessEntityID,
        @ModifiedDate,
        @CreditCardID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[PersonPhone_Delete]
(
 @BusinessEntityID [int],
 @PhoneNumber [nvarchar] (25),
 @PhoneNumberTypeID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[PersonPhone]
    WHERE ((([Person].[PersonPhone].[BusinessEntityID] = @BusinessEntityID) AND ([Person].[PersonPhone].[PhoneNumber] = @PhoneNumber)) AND ([Person].[PersonPhone].[PhoneNumberTypeID] = @PhoneNumberTypeID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[PersonPhone_Save]
(
 @BusinessEntityID [int],
 @PhoneNumber [nvarchar] (25),
 @PhoneNumberTypeID [int],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[PersonPhone] SET
 [Person].[PersonPhone].[ModifiedDate] = @ModifiedDate
    WHERE ((([Person].[PersonPhone].[BusinessEntityID] = @BusinessEntityID) AND ([Person].[PersonPhone].[PhoneNumber] = @PhoneNumber)) AND ([Person].[PersonPhone].[PhoneNumberTypeID] = @PhoneNumberTypeID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[PersonPhone] (
        [Person].[PersonPhone].[BusinessEntityID],
        [Person].[PersonPhone].[PhoneNumber],
        [Person].[PersonPhone].[ModifiedDate],
        [Person].[PersonPhone].[PhoneNumberTypeID])
    VALUES (
        @BusinessEntityID,
        @PhoneNumber,
        @ModifiedDate,
        @PhoneNumberTypeID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[PhoneNumberType_Delete]
(
 @PhoneNumberTypeID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Person].[PersonPhone]
    WHERE ([Person].[PersonPhone].[PhoneNumberTypeID] = @PhoneNumberTypeID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Person].[PhoneNumberType]
    WHERE ([Person].[PhoneNumberType].[PhoneNumberTypeID] = @PhoneNumberTypeID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[PhoneNumberType_Save]
(
 @PhoneNumberTypeID [int] = NULL,
 @Name [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[PhoneNumberType] SET
 [Person].[PhoneNumberType].[Name] = @Name,
 [Person].[PhoneNumberType].[ModifiedDate] = @ModifiedDate
    WHERE ([Person].[PhoneNumberType].[PhoneNumberTypeID] = @PhoneNumberTypeID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[PhoneNumberType] (
        [Person].[PhoneNumberType].[Name],
        [Person].[PhoneNumberType].[ModifiedDate])
    VALUES (
        @Name,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @PhoneNumberTypeID = SCOPE_IDENTITY() 
    SELECT DISTINCT @PhoneNumberTypeID AS 'PhoneNumberTypeID' 
        FROM [Person].[PhoneNumberType]
        WHERE ([Person].[PhoneNumberType].[PhoneNumberTypeID] = @PhoneNumberTypeID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Product_Delete]
(
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[TransactionHistory] SET
 [Production].[TransactionHistory].[ProductID] = NULL
    WHERE ([Production].[TransactionHistory].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Production].[ProductReview] SET
 [Production].[ProductReview].[ProductID] = NULL
    WHERE ([Production].[ProductReview].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Production].[TransactionHistoryArchive] SET
 [Production].[TransactionHistoryArchive].[ProductID] = NULL
    WHERE ([Production].[TransactionHistoryArchive].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Production].[WorkOrder] SET
 [Production].[WorkOrder].[ProductID] = NULL
    WHERE ([Production].[WorkOrder].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Purchasing].[PurchaseOrderDetail] SET
 [Purchasing].[PurchaseOrderDetail].[ProductID] = NULL
    WHERE ([Purchasing].[PurchaseOrderDetail].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Sales].[SalesOrderDetail] SET
 [Sales].[SalesOrderDetail].[ProductID] = NULL
    WHERE ([Sales].[SalesOrderDetail].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Sales].[ShoppingCartItem] SET
 [Sales].[ShoppingCartItem].[ProductID] = NULL
    WHERE ([Sales].[ShoppingCartItem].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Production].[Product]
    WHERE ([Production].[Product].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[Product_Save]
(
 @ProductID [int] = NULL,
 @Name [nvarchar] (50),
 @ProductNumber [nvarchar] (25),
 @MakeFlag [bit],
 @FinishedGoodsFlag [bit],
 @Color [nvarchar] (15) = NULL,
 @SafetyStockLevel [smallint],
 @ReorderPoint [smallint],
 @StandardCost [money],
 @ListPrice [money],
 @Size [nvarchar] (5) = NULL,
 @Weight [decimal] (28, 13) = NULL,
 @DaysToManufacture [int],
 @ProductLine [nvarchar] (2) = NULL,
 @Class [nvarchar] (2) = NULL,
 @Style [nvarchar] (2) = NULL,
 @SellStartDate [datetime],
 @SellEndDate [datetime] = NULL,
 @DiscontinuedDate [datetime] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @ProductModelID [int] = NULL,
 @SizeUnitMeasureCode [nvarchar] (3) = NULL,
 @WeightUnitMeasureCode [nvarchar] (3) = NULL,
 @ProductSubcategoryID [int] = NULL
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[Product] SET
 [Production].[Product].[Name] = @Name,
 [Production].[Product].[ProductNumber] = @ProductNumber,
 [Production].[Product].[MakeFlag] = @MakeFlag,
 [Production].[Product].[FinishedGoodsFlag] = @FinishedGoodsFlag,
 [Production].[Product].[Color] = @Color,
 [Production].[Product].[SafetyStockLevel] = @SafetyStockLevel,
 [Production].[Product].[ReorderPoint] = @ReorderPoint,
 [Production].[Product].[StandardCost] = @StandardCost,
 [Production].[Product].[ListPrice] = @ListPrice,
 [Production].[Product].[Size] = @Size,
 [Production].[Product].[Weight] = @Weight,
 [Production].[Product].[DaysToManufacture] = @DaysToManufacture,
 [Production].[Product].[ProductLine] = @ProductLine,
 [Production].[Product].[Class] = @Class,
 [Production].[Product].[Style] = @Style,
 [Production].[Product].[SellStartDate] = @SellStartDate,
 [Production].[Product].[SellEndDate] = @SellEndDate,
 [Production].[Product].[DiscontinuedDate] = @DiscontinuedDate,
 [Production].[Product].[rowguid] = @rowguid,
 [Production].[Product].[ModifiedDate] = @ModifiedDate,
 [Production].[Product].[ProductModelID] = @ProductModelID,
 [Production].[Product].[SizeUnitMeasureCode] = @SizeUnitMeasureCode,
 [Production].[Product].[WeightUnitMeasureCode] = @WeightUnitMeasureCode,
 [Production].[Product].[ProductSubcategoryID] = @ProductSubcategoryID
    WHERE ([Production].[Product].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[Product] (
        [Production].[Product].[Name],
        [Production].[Product].[ProductNumber],
        [Production].[Product].[MakeFlag],
        [Production].[Product].[FinishedGoodsFlag],
        [Production].[Product].[Color],
        [Production].[Product].[SafetyStockLevel],
        [Production].[Product].[ReorderPoint],
        [Production].[Product].[StandardCost],
        [Production].[Product].[ListPrice],
        [Production].[Product].[Size],
        [Production].[Product].[Weight],
        [Production].[Product].[DaysToManufacture],
        [Production].[Product].[ProductLine],
        [Production].[Product].[Class],
        [Production].[Product].[Style],
        [Production].[Product].[SellStartDate],
        [Production].[Product].[SellEndDate],
        [Production].[Product].[DiscontinuedDate],
        [Production].[Product].[rowguid],
        [Production].[Product].[ModifiedDate],
        [Production].[Product].[ProductModelID],
        [Production].[Product].[SizeUnitMeasureCode],
        [Production].[Product].[WeightUnitMeasureCode],
        [Production].[Product].[ProductSubcategoryID])
    VALUES (
        @Name,
        @ProductNumber,
        @MakeFlag,
        @FinishedGoodsFlag,
        @Color,
        @SafetyStockLevel,
        @ReorderPoint,
        @StandardCost,
        @ListPrice,
        @Size,
        @Weight,
        @DaysToManufacture,
        @ProductLine,
        @Class,
        @Style,
        @SellStartDate,
        @SellEndDate,
        @DiscontinuedDate,
        @rowguid,
        @ModifiedDate,
        @ProductModelID,
        @SizeUnitMeasureCode,
        @WeightUnitMeasureCode,
        @ProductSubcategoryID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ProductID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ProductID AS 'ProductID' 
        FROM [Production].[Product]
        WHERE ([Production].[Product].[ProductID] = @ProductID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductCategory_Delete]
(
 @ProductCategoryID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductSubcategory] SET
 [Production].[ProductSubcategory].[ProductCategoryID] = NULL
    WHERE ([Production].[ProductSubcategory].[ProductCategoryID] = @ProductCategoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Production].[ProductCategory]
    WHERE ([Production].[ProductCategory].[ProductCategoryID] = @ProductCategoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductCategory_Save]
(
 @ProductCategoryID [int] = NULL,
 @Name [nvarchar] (50),
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductCategory] SET
 [Production].[ProductCategory].[Name] = @Name,
 [Production].[ProductCategory].[rowguid] = @rowguid,
 [Production].[ProductCategory].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[ProductCategory].[ProductCategoryID] = @ProductCategoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductCategory] (
        [Production].[ProductCategory].[Name],
        [Production].[ProductCategory].[rowguid],
        [Production].[ProductCategory].[ModifiedDate])
    VALUES (
        @Name,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ProductCategoryID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ProductCategoryID AS 'ProductCategoryID' 
        FROM [Production].[ProductCategory]
        WHERE ([Production].[ProductCategory].[ProductCategoryID] = @ProductCategoryID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductCostHistory_Delete]
(
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductCostHistory]
    WHERE ([Production].[ProductCostHistory].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductCostHistory_Save]
(
 @ProductID [int],
 @StartDate [datetime],
 @EndDate [datetime] = NULL,
 @StandardCost [money],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductCostHistory] SET
 [Production].[ProductCostHistory].[StartDate] = @StartDate,
 [Production].[ProductCostHistory].[EndDate] = @EndDate,
 [Production].[ProductCostHistory].[StandardCost] = @StandardCost,
 [Production].[ProductCostHistory].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[ProductCostHistory].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductCostHistory] (
        [Production].[ProductCostHistory].[ProductID],
        [Production].[ProductCostHistory].[StartDate],
        [Production].[ProductCostHistory].[EndDate],
        [Production].[ProductCostHistory].[StandardCost],
        [Production].[ProductCostHistory].[ModifiedDate])
    VALUES (
        @ProductID,
        @StartDate,
        @EndDate,
        @StandardCost,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductDescription_Delete]
(
 @ProductDescriptionID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductModelProductDescriptionCulture]
    WHERE ([Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID] = @ProductDescriptionID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Production].[ProductDescription]
    WHERE ([Production].[ProductDescription].[ProductDescriptionID] = @ProductDescriptionID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductDescription_Save]
(
 @ProductDescriptionID [int] = NULL,
 @Description [nvarchar] (400),
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductDescription] SET
 [Production].[ProductDescription].[Description] = @Description,
 [Production].[ProductDescription].[rowguid] = @rowguid,
 [Production].[ProductDescription].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[ProductDescription].[ProductDescriptionID] = @ProductDescriptionID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductDescription] (
        [Production].[ProductDescription].[Description],
        [Production].[ProductDescription].[rowguid],
        [Production].[ProductDescription].[ModifiedDate])
    VALUES (
        @Description,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ProductDescriptionID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ProductDescriptionID AS 'ProductDescriptionID' 
        FROM [Production].[ProductDescription]
        WHERE ([Production].[ProductDescription].[ProductDescriptionID] = @ProductDescriptionID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductDocument_Delete]
(
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductDocument]
    WHERE ([Production].[ProductDocument].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductDocument_Save]
(
 @ProductID [int],
 @DocumentNode [hierarchyid],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductDocument] SET
 [Production].[ProductDocument].[DocumentNode] = @DocumentNode,
 [Production].[ProductDocument].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[ProductDocument].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductDocument] (
        [Production].[ProductDocument].[ProductID],
        [Production].[ProductDocument].[DocumentNode],
        [Production].[ProductDocument].[ModifiedDate])
    VALUES (
        @ProductID,
        @DocumentNode,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductInventory_Delete]
(
 @ProductID [int],
 @LocationID [smallint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductInventory]
    WHERE (([Production].[ProductInventory].[ProductID] = @ProductID) AND ([Production].[ProductInventory].[LocationID] = @LocationID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductInventory_Save]
(
 @ProductID [int],
 @LocationID [smallint],
 @Shelf [nvarchar] (10),
 @Bin [tinyint],
 @Quantity [smallint],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductInventory] SET
 [Production].[ProductInventory].[Shelf] = @Shelf,
 [Production].[ProductInventory].[Bin] = @Bin,
 [Production].[ProductInventory].[Quantity] = @Quantity,
 [Production].[ProductInventory].[rowguid] = @rowguid,
 [Production].[ProductInventory].[ModifiedDate] = @ModifiedDate
    WHERE (([Production].[ProductInventory].[ProductID] = @ProductID) AND ([Production].[ProductInventory].[LocationID] = @LocationID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductInventory] (
        [Production].[ProductInventory].[ProductID],
        [Production].[ProductInventory].[Shelf],
        [Production].[ProductInventory].[Bin],
        [Production].[ProductInventory].[Quantity],
        [Production].[ProductInventory].[rowguid],
        [Production].[ProductInventory].[ModifiedDate],
        [Production].[ProductInventory].[LocationID])
    VALUES (
        @ProductID,
        @Shelf,
        @Bin,
        @Quantity,
        @rowguid,
        @ModifiedDate,
        @LocationID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductListPriceHistory_Delete]
(
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductListPriceHistory]
    WHERE ([Production].[ProductListPriceHistory].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductListPriceHistory_Save]
(
 @ProductID [int],
 @StartDate [datetime],
 @EndDate [datetime] = NULL,
 @ListPrice [money],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductListPriceHistory] SET
 [Production].[ProductListPriceHistory].[StartDate] = @StartDate,
 [Production].[ProductListPriceHistory].[EndDate] = @EndDate,
 [Production].[ProductListPriceHistory].[ListPrice] = @ListPrice,
 [Production].[ProductListPriceHistory].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[ProductListPriceHistory].[ProductID] = @ProductID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductListPriceHistory] (
        [Production].[ProductListPriceHistory].[ProductID],
        [Production].[ProductListPriceHistory].[StartDate],
        [Production].[ProductListPriceHistory].[EndDate],
        [Production].[ProductListPriceHistory].[ListPrice],
        [Production].[ProductListPriceHistory].[ModifiedDate])
    VALUES (
        @ProductID,
        @StartDate,
        @EndDate,
        @ListPrice,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductModel_Delete]
(
 @ProductModelID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductModelIllustration]
    WHERE ([Production].[ProductModelIllustration].[ProductModelID] = @ProductModelID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Production].[ProductModelProductDescriptionCulture]
    WHERE ([Production].[ProductModelProductDescriptionCulture].[ProductModelID] = @ProductModelID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
UPDATE [Production].[Product] SET
 [Production].[Product].[ProductModelID] = NULL
    WHERE ([Production].[Product].[ProductModelID] = @ProductModelID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Production].[ProductModel]
    WHERE ([Production].[ProductModel].[ProductModelID] = @ProductModelID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductModel_Save]
(
 @ProductModelID [int] = NULL,
 @Name [nvarchar] (50),
 @CatalogDescription [xml] = NULL,
 @Instructions [xml] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductModel] SET
 [Production].[ProductModel].[Name] = @Name,
 [Production].[ProductModel].[CatalogDescription] = @CatalogDescription,
 [Production].[ProductModel].[Instructions] = @Instructions,
 [Production].[ProductModel].[rowguid] = @rowguid,
 [Production].[ProductModel].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[ProductModel].[ProductModelID] = @ProductModelID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductModel] (
        [Production].[ProductModel].[Name],
        [Production].[ProductModel].[CatalogDescription],
        [Production].[ProductModel].[Instructions],
        [Production].[ProductModel].[rowguid],
        [Production].[ProductModel].[ModifiedDate])
    VALUES (
        @Name,
        @CatalogDescription,
        @Instructions,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ProductModelID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ProductModelID AS 'ProductModelID' 
        FROM [Production].[ProductModel]
        WHERE ([Production].[ProductModel].[ProductModelID] = @ProductModelID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelIllustration_Delete]
(
 @IllustrationID [int],
 @ProductModelID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductModelIllustration]
    WHERE (([Production].[ProductModelIllustration].[IllustrationID] = @IllustrationID) AND ([Production].[ProductModelIllustration].[ProductModelID] = @ProductModelID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelIllustration_Save]
(
 @IllustrationID [int],
 @ProductModelID [int],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductModelIllustration] SET
 [Production].[ProductModelIllustration].[ModifiedDate] = @ModifiedDate
    WHERE (([Production].[ProductModelIllustration].[IllustrationID] = @IllustrationID) AND ([Production].[ProductModelIllustration].[ProductModelID] = @ProductModelID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductModelIllustration] (
        [Production].[ProductModelIllustration].[ModifiedDate],
        [Production].[ProductModelIllustration].[IllustrationID],
        [Production].[ProductModelIllustration].[ProductModelID])
    VALUES (
        @ModifiedDate,
        @IllustrationID,
        @ProductModelID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelProductDescriptionCulture_Delete]
(
 @CultureID [nvarchar] (6),
 @ProductDescriptionID [int],
 @ProductModelID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductModelProductDescriptionCulture]
    WHERE ((([Production].[ProductModelProductDescriptionCulture].[CultureID] = @CultureID) AND ([Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID] = @ProductDescriptionID)) AND ([Production].[ProductModelProductDescriptionCulture].[ProductModelID] = @ProductModelID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelProductDescriptionCulture_Save]
(
 @CultureID [nvarchar] (6),
 @ProductDescriptionID [int],
 @ProductModelID [int],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductModelProductDescriptionCulture] SET
 [Production].[ProductModelProductDescriptionCulture].[ModifiedDate] = @ModifiedDate
    WHERE ((([Production].[ProductModelProductDescriptionCulture].[CultureID] = @CultureID) AND ([Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID] = @ProductDescriptionID)) AND ([Production].[ProductModelProductDescriptionCulture].[ProductModelID] = @ProductModelID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductModelProductDescriptionCulture] (
        [Production].[ProductModelProductDescriptionCulture].[ModifiedDate],
        [Production].[ProductModelProductDescriptionCulture].[CultureID],
        [Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID],
        [Production].[ProductModelProductDescriptionCulture].[ProductModelID])
    VALUES (
        @ModifiedDate,
        @CultureID,
        @ProductDescriptionID,
        @ProductModelID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductPhoto_Delete]
(
 @ProductPhotoID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductProductPhoto]
    WHERE ([Production].[ProductProductPhoto].[ProductPhotoID] = @ProductPhotoID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Production].[ProductPhoto]
    WHERE ([Production].[ProductPhoto].[ProductPhotoID] = @ProductPhotoID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductPhoto_Save]
(
 @ProductPhotoID [int] = NULL,
 @ThumbNailPhoto [varbinary] (max) = NULL,
 @ThumbnailPhotoFileName [nvarchar] (50) = NULL,
 @LargePhoto [varbinary] (max) = NULL,
 @LargePhotoFileName [nvarchar] (50) = NULL,
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductPhoto] SET
 [Production].[ProductPhoto].[ThumbNailPhoto] = @ThumbNailPhoto,
 [Production].[ProductPhoto].[ThumbnailPhotoFileName] = @ThumbnailPhotoFileName,
 [Production].[ProductPhoto].[LargePhoto] = @LargePhoto,
 [Production].[ProductPhoto].[LargePhotoFileName] = @LargePhotoFileName,
 [Production].[ProductPhoto].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[ProductPhoto].[ProductPhotoID] = @ProductPhotoID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductPhoto] (
        [Production].[ProductPhoto].[ThumbNailPhoto],
        [Production].[ProductPhoto].[ThumbnailPhotoFileName],
        [Production].[ProductPhoto].[LargePhoto],
        [Production].[ProductPhoto].[LargePhotoFileName],
        [Production].[ProductPhoto].[ModifiedDate])
    VALUES (
        @ThumbNailPhoto,
        @ThumbnailPhotoFileName,
        @LargePhoto,
        @LargePhotoFileName,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ProductPhotoID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ProductPhotoID AS 'ProductPhotoID' 
        FROM [Production].[ProductPhoto]
        WHERE ([Production].[ProductPhoto].[ProductPhotoID] = @ProductPhotoID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductProductPhoto_Delete]
(
 @ProductID [int],
 @ProductPhotoID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductProductPhoto]
    WHERE (([Production].[ProductProductPhoto].[ProductID] = @ProductID) AND ([Production].[ProductProductPhoto].[ProductPhotoID] = @ProductPhotoID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductProductPhoto_Save]
(
 @ProductID [int],
 @ProductPhotoID [int],
 @Primary [bit],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductProductPhoto] SET
 [Production].[ProductProductPhoto].[Primary] = @Primary,
 [Production].[ProductProductPhoto].[ModifiedDate] = @ModifiedDate
    WHERE (([Production].[ProductProductPhoto].[ProductID] = @ProductID) AND ([Production].[ProductProductPhoto].[ProductPhotoID] = @ProductPhotoID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductProductPhoto] (
        [Production].[ProductProductPhoto].[ProductID],
        [Production].[ProductProductPhoto].[Primary],
        [Production].[ProductProductPhoto].[ModifiedDate],
        [Production].[ProductProductPhoto].[ProductPhotoID])
    VALUES (
        @ProductID,
        @Primary,
        @ModifiedDate,
        @ProductPhotoID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductReview_Delete]
(
 @ProductReviewID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[ProductReview]
    WHERE ([Production].[ProductReview].[ProductReviewID] = @ProductReviewID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductReview_Save]
(
 @ProductReviewID [int] = NULL,
 @ReviewerName [nvarchar] (50),
 @ReviewDate [datetime],
 @EmailAddress [nvarchar] (50),
 @Rating [int],
 @Comments [nvarchar] (3850) = NULL,
 @ModifiedDate [datetime],
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductReview] SET
 [Production].[ProductReview].[ReviewerName] = @ReviewerName,
 [Production].[ProductReview].[ReviewDate] = @ReviewDate,
 [Production].[ProductReview].[EmailAddress] = @EmailAddress,
 [Production].[ProductReview].[Rating] = @Rating,
 [Production].[ProductReview].[Comments] = @Comments,
 [Production].[ProductReview].[ModifiedDate] = @ModifiedDate,
 [Production].[ProductReview].[ProductID] = @ProductID
    WHERE ([Production].[ProductReview].[ProductReviewID] = @ProductReviewID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductReview] (
        [Production].[ProductReview].[ReviewerName],
        [Production].[ProductReview].[ReviewDate],
        [Production].[ProductReview].[EmailAddress],
        [Production].[ProductReview].[Rating],
        [Production].[ProductReview].[Comments],
        [Production].[ProductReview].[ModifiedDate],
        [Production].[ProductReview].[ProductID])
    VALUES (
        @ReviewerName,
        @ReviewDate,
        @EmailAddress,
        @Rating,
        @Comments,
        @ModifiedDate,
        @ProductID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ProductReviewID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ProductReviewID AS 'ProductReviewID' 
        FROM [Production].[ProductReview]
        WHERE ([Production].[ProductReview].[ProductReviewID] = @ProductReviewID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductSubcategory_Delete]
(
 @ProductSubcategoryID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[Product] SET
 [Production].[Product].[ProductSubcategoryID] = NULL
    WHERE ([Production].[Product].[ProductSubcategoryID] = @ProductSubcategoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Production].[ProductSubcategory]
    WHERE ([Production].[ProductSubcategory].[ProductSubcategoryID] = @ProductSubcategoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ProductSubcategory_Save]
(
 @ProductSubcategoryID [int] = NULL,
 @Name [nvarchar] (50),
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @ProductCategoryID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ProductSubcategory] SET
 [Production].[ProductSubcategory].[Name] = @Name,
 [Production].[ProductSubcategory].[rowguid] = @rowguid,
 [Production].[ProductSubcategory].[ModifiedDate] = @ModifiedDate,
 [Production].[ProductSubcategory].[ProductCategoryID] = @ProductCategoryID
    WHERE ([Production].[ProductSubcategory].[ProductSubcategoryID] = @ProductSubcategoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ProductSubcategory] (
        [Production].[ProductSubcategory].[Name],
        [Production].[ProductSubcategory].[rowguid],
        [Production].[ProductSubcategory].[ModifiedDate],
        [Production].[ProductSubcategory].[ProductCategoryID])
    VALUES (
        @Name,
        @rowguid,
        @ModifiedDate,
        @ProductCategoryID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ProductSubcategoryID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ProductSubcategoryID AS 'ProductSubcategoryID' 
        FROM [Production].[ProductSubcategory]
        WHERE ([Production].[ProductSubcategory].[ProductSubcategoryID] = @ProductSubcategoryID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[ProductVendor_Delete]
(
 @ProductID [int],
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Purchasing].[ProductVendor]
    WHERE (([Purchasing].[ProductVendor].[ProductID] = @ProductID) AND ([Purchasing].[ProductVendor].[BusinessEntityID] = @BusinessEntityID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[ProductVendor_Save]
(
 @ProductID [int],
 @BusinessEntityID [int],
 @AverageLeadTime [int],
 @StandardPrice [money],
 @LastReceiptCost [money] = NULL,
 @LastReceiptDate [datetime] = NULL,
 @MinOrderQty [int],
 @MaxOrderQty [int],
 @OnOrderQty [int] = NULL,
 @ModifiedDate [datetime],
 @UnitMeasureCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Purchasing].[ProductVendor] SET
 [Purchasing].[ProductVendor].[AverageLeadTime] = @AverageLeadTime,
 [Purchasing].[ProductVendor].[StandardPrice] = @StandardPrice,
 [Purchasing].[ProductVendor].[LastReceiptCost] = @LastReceiptCost,
 [Purchasing].[ProductVendor].[LastReceiptDate] = @LastReceiptDate,
 [Purchasing].[ProductVendor].[MinOrderQty] = @MinOrderQty,
 [Purchasing].[ProductVendor].[MaxOrderQty] = @MaxOrderQty,
 [Purchasing].[ProductVendor].[OnOrderQty] = @OnOrderQty,
 [Purchasing].[ProductVendor].[ModifiedDate] = @ModifiedDate,
 [Purchasing].[ProductVendor].[UnitMeasureCode] = @UnitMeasureCode
    WHERE (([Purchasing].[ProductVendor].[ProductID] = @ProductID) AND ([Purchasing].[ProductVendor].[BusinessEntityID] = @BusinessEntityID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Purchasing].[ProductVendor] (
        [Purchasing].[ProductVendor].[ProductID],
        [Purchasing].[ProductVendor].[BusinessEntityID],
        [Purchasing].[ProductVendor].[AverageLeadTime],
        [Purchasing].[ProductVendor].[StandardPrice],
        [Purchasing].[ProductVendor].[LastReceiptCost],
        [Purchasing].[ProductVendor].[LastReceiptDate],
        [Purchasing].[ProductVendor].[MinOrderQty],
        [Purchasing].[ProductVendor].[MaxOrderQty],
        [Purchasing].[ProductVendor].[OnOrderQty],
        [Purchasing].[ProductVendor].[ModifiedDate],
        [Purchasing].[ProductVendor].[UnitMeasureCode])
    VALUES (
        @ProductID,
        @BusinessEntityID,
        @AverageLeadTime,
        @StandardPrice,
        @LastReceiptCost,
        @LastReceiptDate,
        @MinOrderQty,
        @MaxOrderQty,
        @OnOrderQty,
        @ModifiedDate,
        @UnitMeasureCode)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderDetail_Delete]
(
 @PurchaseOrderID [int],
 @PurchaseOrderDetailID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Purchasing].[PurchaseOrderDetail]
    WHERE (([Purchasing].[PurchaseOrderDetail].[PurchaseOrderID] = @PurchaseOrderID) AND ([Purchasing].[PurchaseOrderDetail].[PurchaseOrderDetailID] = @PurchaseOrderDetailID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderDetail_Save]
(
 @PurchaseOrderID [int],
 @PurchaseOrderDetailID [int] = NULL,
 @DueDate [datetime],
 @OrderQty [smallint],
 @UnitPrice [money],
 @ReceivedQty [decimal] (28, 13),
 @RejectedQty [decimal] (28, 13),
 @ModifiedDate [datetime],
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Purchasing].[PurchaseOrderDetail] SET
 [Purchasing].[PurchaseOrderDetail].[DueDate] = @DueDate,
 [Purchasing].[PurchaseOrderDetail].[OrderQty] = @OrderQty,
 [Purchasing].[PurchaseOrderDetail].[UnitPrice] = @UnitPrice,
 [Purchasing].[PurchaseOrderDetail].[ReceivedQty] = @ReceivedQty,
 [Purchasing].[PurchaseOrderDetail].[RejectedQty] = @RejectedQty,
 [Purchasing].[PurchaseOrderDetail].[ModifiedDate] = @ModifiedDate,
 [Purchasing].[PurchaseOrderDetail].[ProductID] = @ProductID
    WHERE (([Purchasing].[PurchaseOrderDetail].[PurchaseOrderID] = @PurchaseOrderID) AND ([Purchasing].[PurchaseOrderDetail].[PurchaseOrderDetailID] = @PurchaseOrderDetailID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Purchasing].[PurchaseOrderDetail] (
        [Purchasing].[PurchaseOrderDetail].[PurchaseOrderID],
        [Purchasing].[PurchaseOrderDetail].[DueDate],
        [Purchasing].[PurchaseOrderDetail].[OrderQty],
        [Purchasing].[PurchaseOrderDetail].[UnitPrice],
        [Purchasing].[PurchaseOrderDetail].[ReceivedQty],
        [Purchasing].[PurchaseOrderDetail].[RejectedQty],
        [Purchasing].[PurchaseOrderDetail].[ModifiedDate],
        [Purchasing].[PurchaseOrderDetail].[ProductID])
    VALUES (
        @PurchaseOrderID,
        @DueDate,
        @OrderQty,
        @UnitPrice,
        @ReceivedQty,
        @RejectedQty,
        @ModifiedDate,
        @ProductID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @PurchaseOrderDetailID = SCOPE_IDENTITY() 
    SELECT DISTINCT @PurchaseOrderDetailID AS 'PurchaseOrderDetailID' 
        FROM [Purchasing].[PurchaseOrderDetail]
        WHERE (([Purchasing].[PurchaseOrderDetail].[PurchaseOrderID] = @PurchaseOrderID) AND ([Purchasing].[PurchaseOrderDetail].[PurchaseOrderDetailID] = @PurchaseOrderDetailID))
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderHeader_Delete]
(
 @PurchaseOrderID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Purchasing].[PurchaseOrderHeader]
    WHERE ([Purchasing].[PurchaseOrderHeader].[PurchaseOrderID] = @PurchaseOrderID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderHeader_Save]
(
 @PurchaseOrderID [int] = NULL,
 @RevisionNumber [tinyint],
 @Status [tinyint],
 @EmployeeID [int],
 @VendorID [int],
 @OrderDate [datetime],
 @ShipDate [datetime] = NULL,
 @SubTotal [money],
 @TaxAmt [money],
 @Freight [money],
 @ModifiedDate [datetime],
 @ShipMethodID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Purchasing].[PurchaseOrderHeader] SET
 [Purchasing].[PurchaseOrderHeader].[RevisionNumber] = @RevisionNumber,
 [Purchasing].[PurchaseOrderHeader].[Status] = @Status,
 [Purchasing].[PurchaseOrderHeader].[EmployeeID] = @EmployeeID,
 [Purchasing].[PurchaseOrderHeader].[VendorID] = @VendorID,
 [Purchasing].[PurchaseOrderHeader].[OrderDate] = @OrderDate,
 [Purchasing].[PurchaseOrderHeader].[ShipDate] = @ShipDate,
 [Purchasing].[PurchaseOrderHeader].[SubTotal] = @SubTotal,
 [Purchasing].[PurchaseOrderHeader].[TaxAmt] = @TaxAmt,
 [Purchasing].[PurchaseOrderHeader].[Freight] = @Freight,
 [Purchasing].[PurchaseOrderHeader].[ModifiedDate] = @ModifiedDate,
 [Purchasing].[PurchaseOrderHeader].[ShipMethodID] = @ShipMethodID
    WHERE ([Purchasing].[PurchaseOrderHeader].[PurchaseOrderID] = @PurchaseOrderID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Purchasing].[PurchaseOrderHeader] (
        [Purchasing].[PurchaseOrderHeader].[RevisionNumber],
        [Purchasing].[PurchaseOrderHeader].[Status],
        [Purchasing].[PurchaseOrderHeader].[EmployeeID],
        [Purchasing].[PurchaseOrderHeader].[VendorID],
        [Purchasing].[PurchaseOrderHeader].[OrderDate],
        [Purchasing].[PurchaseOrderHeader].[ShipDate],
        [Purchasing].[PurchaseOrderHeader].[SubTotal],
        [Purchasing].[PurchaseOrderHeader].[TaxAmt],
        [Purchasing].[PurchaseOrderHeader].[Freight],
        [Purchasing].[PurchaseOrderHeader].[ModifiedDate],
        [Purchasing].[PurchaseOrderHeader].[ShipMethodID])
    VALUES (
        @RevisionNumber,
        @Status,
        @EmployeeID,
        @VendorID,
        @OrderDate,
        @ShipDate,
        @SubTotal,
        @TaxAmt,
        @Freight,
        @ModifiedDate,
        @ShipMethodID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @PurchaseOrderID = SCOPE_IDENTITY() 
    SELECT DISTINCT @PurchaseOrderID AS 'PurchaseOrderID' 
        FROM [Purchasing].[PurchaseOrderHeader]
        WHERE ([Purchasing].[PurchaseOrderHeader].[PurchaseOrderID] = @PurchaseOrderID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderDetail_Delete]
(
 @SalesOrderID [int],
 @SalesOrderDetailID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SalesOrderDetail]
    WHERE (([Sales].[SalesOrderDetail].[SalesOrderID] = @SalesOrderID) AND ([Sales].[SalesOrderDetail].[SalesOrderDetailID] = @SalesOrderDetailID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderDetail_Save]
(
 @SalesOrderID [int],
 @SalesOrderDetailID [int] = NULL,
 @CarrierTrackingNumber [nvarchar] (25) = NULL,
 @OrderQty [smallint],
 @UnitPrice [money],
 @UnitPriceDiscount [money],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @ProductID [int],
 @SpecialOfferID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesOrderDetail] SET
 [Sales].[SalesOrderDetail].[CarrierTrackingNumber] = @CarrierTrackingNumber,
 [Sales].[SalesOrderDetail].[OrderQty] = @OrderQty,
 [Sales].[SalesOrderDetail].[UnitPrice] = @UnitPrice,
 [Sales].[SalesOrderDetail].[UnitPriceDiscount] = @UnitPriceDiscount,
 [Sales].[SalesOrderDetail].[rowguid] = @rowguid,
 [Sales].[SalesOrderDetail].[ModifiedDate] = @ModifiedDate,
 [Sales].[SalesOrderDetail].[ProductID] = @ProductID,
 [Sales].[SalesOrderDetail].[SpecialOfferID] = @SpecialOfferID
    WHERE (([Sales].[SalesOrderDetail].[SalesOrderID] = @SalesOrderID) AND ([Sales].[SalesOrderDetail].[SalesOrderDetailID] = @SalesOrderDetailID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesOrderDetail] (
        [Sales].[SalesOrderDetail].[SalesOrderID],
        [Sales].[SalesOrderDetail].[CarrierTrackingNumber],
        [Sales].[SalesOrderDetail].[OrderQty],
        [Sales].[SalesOrderDetail].[UnitPrice],
        [Sales].[SalesOrderDetail].[UnitPriceDiscount],
        [Sales].[SalesOrderDetail].[rowguid],
        [Sales].[SalesOrderDetail].[ModifiedDate],
        [Sales].[SalesOrderDetail].[ProductID],
        [Sales].[SalesOrderDetail].[SpecialOfferID])
    VALUES (
        @SalesOrderID,
        @CarrierTrackingNumber,
        @OrderQty,
        @UnitPrice,
        @UnitPriceDiscount,
        @rowguid,
        @ModifiedDate,
        @ProductID,
        @SpecialOfferID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @SalesOrderDetailID = SCOPE_IDENTITY() 
    SELECT DISTINCT @SalesOrderDetailID AS 'SalesOrderDetailID' 
        FROM [Sales].[SalesOrderDetail]
        WHERE (([Sales].[SalesOrderDetail].[SalesOrderID] = @SalesOrderID) AND ([Sales].[SalesOrderDetail].[SalesOrderDetailID] = @SalesOrderDetailID))
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_Delete]
(
 @SalesOrderID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SalesOrderHeader]
    WHERE ([Sales].[SalesOrderHeader].[SalesOrderID] = @SalesOrderID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_Save]
(
 @SalesOrderID [int] = NULL,
 @RevisionNumber [tinyint],
 @OrderDate [datetime],
 @DueDate [datetime],
 @ShipDate [datetime] = NULL,
 @Status [tinyint],
 @OnlineOrderFlag [bit],
 @PurchaseOrderNumber [nvarchar] (25) = NULL,
 @AccountNumber [nvarchar] (15) = NULL,
 @SalesPersonID [int] = NULL,
 @BillToAddressID [int],
 @ShipToAddressID [int],
 @CreditCardApprovalCode [varchar] (15) = NULL,
 @SubTotal [money],
 @TaxAmt [money],
 @Freight [money],
 @Comment [nvarchar] (128) = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @CreditCardID [int] = NULL,
 @ShipMethodID [int],
 @CustomerID [int],
 @TerritoryID [int] = NULL,
 @CurrencyRateID [int] = NULL
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesOrderHeader] SET
 [Sales].[SalesOrderHeader].[RevisionNumber] = @RevisionNumber,
 [Sales].[SalesOrderHeader].[OrderDate] = @OrderDate,
 [Sales].[SalesOrderHeader].[DueDate] = @DueDate,
 [Sales].[SalesOrderHeader].[ShipDate] = @ShipDate,
 [Sales].[SalesOrderHeader].[Status] = @Status,
 [Sales].[SalesOrderHeader].[OnlineOrderFlag] = @OnlineOrderFlag,
 [Sales].[SalesOrderHeader].[PurchaseOrderNumber] = @PurchaseOrderNumber,
 [Sales].[SalesOrderHeader].[AccountNumber] = @AccountNumber,
 [Sales].[SalesOrderHeader].[SalesPersonID] = @SalesPersonID,
 [Sales].[SalesOrderHeader].[BillToAddressID] = @BillToAddressID,
 [Sales].[SalesOrderHeader].[ShipToAddressID] = @ShipToAddressID,
 [Sales].[SalesOrderHeader].[CreditCardApprovalCode] = @CreditCardApprovalCode,
 [Sales].[SalesOrderHeader].[SubTotal] = @SubTotal,
 [Sales].[SalesOrderHeader].[TaxAmt] = @TaxAmt,
 [Sales].[SalesOrderHeader].[Freight] = @Freight,
 [Sales].[SalesOrderHeader].[Comment] = @Comment,
 [Sales].[SalesOrderHeader].[rowguid] = @rowguid,
 [Sales].[SalesOrderHeader].[ModifiedDate] = @ModifiedDate,
 [Sales].[SalesOrderHeader].[CreditCardID] = @CreditCardID,
 [Sales].[SalesOrderHeader].[ShipMethodID] = @ShipMethodID,
 [Sales].[SalesOrderHeader].[CustomerID] = @CustomerID,
 [Sales].[SalesOrderHeader].[TerritoryID] = @TerritoryID,
 [Sales].[SalesOrderHeader].[CurrencyRateID] = @CurrencyRateID
    WHERE ([Sales].[SalesOrderHeader].[SalesOrderID] = @SalesOrderID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesOrderHeader] (
        [Sales].[SalesOrderHeader].[RevisionNumber],
        [Sales].[SalesOrderHeader].[OrderDate],
        [Sales].[SalesOrderHeader].[DueDate],
        [Sales].[SalesOrderHeader].[ShipDate],
        [Sales].[SalesOrderHeader].[Status],
        [Sales].[SalesOrderHeader].[OnlineOrderFlag],
        [Sales].[SalesOrderHeader].[PurchaseOrderNumber],
        [Sales].[SalesOrderHeader].[AccountNumber],
        [Sales].[SalesOrderHeader].[SalesPersonID],
        [Sales].[SalesOrderHeader].[BillToAddressID],
        [Sales].[SalesOrderHeader].[ShipToAddressID],
        [Sales].[SalesOrderHeader].[CreditCardApprovalCode],
        [Sales].[SalesOrderHeader].[SubTotal],
        [Sales].[SalesOrderHeader].[TaxAmt],
        [Sales].[SalesOrderHeader].[Freight],
        [Sales].[SalesOrderHeader].[Comment],
        [Sales].[SalesOrderHeader].[rowguid],
        [Sales].[SalesOrderHeader].[ModifiedDate],
        [Sales].[SalesOrderHeader].[CreditCardID],
        [Sales].[SalesOrderHeader].[ShipMethodID],
        [Sales].[SalesOrderHeader].[CustomerID],
        [Sales].[SalesOrderHeader].[TerritoryID],
        [Sales].[SalesOrderHeader].[CurrencyRateID])
    VALUES (
        @RevisionNumber,
        @OrderDate,
        @DueDate,
        @ShipDate,
        @Status,
        @OnlineOrderFlag,
        @PurchaseOrderNumber,
        @AccountNumber,
        @SalesPersonID,
        @BillToAddressID,
        @ShipToAddressID,
        @CreditCardApprovalCode,
        @SubTotal,
        @TaxAmt,
        @Freight,
        @Comment,
        @rowguid,
        @ModifiedDate,
        @CreditCardID,
        @ShipMethodID,
        @CustomerID,
        @TerritoryID,
        @CurrencyRateID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @SalesOrderID = SCOPE_IDENTITY() 
    SELECT DISTINCT @SalesOrderID AS 'SalesOrderID' 
        FROM [Sales].[SalesOrderHeader]
        WHERE ([Sales].[SalesOrderHeader].[SalesOrderID] = @SalesOrderID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeaderSalesReason_Delete]
(
 @SalesOrderID [int],
 @SalesReasonID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SalesOrderHeaderSalesReason]
    WHERE (([Sales].[SalesOrderHeaderSalesReason].[SalesOrderID] = @SalesOrderID) AND ([Sales].[SalesOrderHeaderSalesReason].[SalesReasonID] = @SalesReasonID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeaderSalesReason_Save]
(
 @SalesOrderID [int],
 @SalesReasonID [int],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesOrderHeaderSalesReason] SET
 [Sales].[SalesOrderHeaderSalesReason].[ModifiedDate] = @ModifiedDate
    WHERE (([Sales].[SalesOrderHeaderSalesReason].[SalesOrderID] = @SalesOrderID) AND ([Sales].[SalesOrderHeaderSalesReason].[SalesReasonID] = @SalesReasonID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesOrderHeaderSalesReason] (
        [Sales].[SalesOrderHeaderSalesReason].[SalesOrderID],
        [Sales].[SalesOrderHeaderSalesReason].[ModifiedDate],
        [Sales].[SalesOrderHeaderSalesReason].[SalesReasonID])
    VALUES (
        @SalesOrderID,
        @ModifiedDate,
        @SalesReasonID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPerson_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SalesPerson]
    WHERE ([Sales].[SalesPerson].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPerson_Save]
(
 @BusinessEntityID [int],
 @SalesQuota [money] = NULL,
 @Bonus [money],
 @CommissionPct [money],
 @SalesYTD [money],
 @SalesLastYear [money],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @TerritoryID [int] = NULL
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesPerson] SET
 [Sales].[SalesPerson].[SalesQuota] = @SalesQuota,
 [Sales].[SalesPerson].[Bonus] = @Bonus,
 [Sales].[SalesPerson].[CommissionPct] = @CommissionPct,
 [Sales].[SalesPerson].[SalesYTD] = @SalesYTD,
 [Sales].[SalesPerson].[SalesLastYear] = @SalesLastYear,
 [Sales].[SalesPerson].[rowguid] = @rowguid,
 [Sales].[SalesPerson].[ModifiedDate] = @ModifiedDate,
 [Sales].[SalesPerson].[TerritoryID] = @TerritoryID
    WHERE ([Sales].[SalesPerson].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesPerson] (
        [Sales].[SalesPerson].[BusinessEntityID],
        [Sales].[SalesPerson].[SalesQuota],
        [Sales].[SalesPerson].[Bonus],
        [Sales].[SalesPerson].[CommissionPct],
        [Sales].[SalesPerson].[SalesYTD],
        [Sales].[SalesPerson].[SalesLastYear],
        [Sales].[SalesPerson].[rowguid],
        [Sales].[SalesPerson].[ModifiedDate],
        [Sales].[SalesPerson].[TerritoryID])
    VALUES (
        @BusinessEntityID,
        @SalesQuota,
        @Bonus,
        @CommissionPct,
        @SalesYTD,
        @SalesLastYear,
        @rowguid,
        @ModifiedDate,
        @TerritoryID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPersonQuotaHistory_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SalesPersonQuotaHistory]
    WHERE ([Sales].[SalesPersonQuotaHistory].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPersonQuotaHistory_Save]
(
 @BusinessEntityID [int],
 @QuotaDate [datetime],
 @SalesQuota [money],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesPersonQuotaHistory] SET
 [Sales].[SalesPersonQuotaHistory].[QuotaDate] = @QuotaDate,
 [Sales].[SalesPersonQuotaHistory].[SalesQuota] = @SalesQuota,
 [Sales].[SalesPersonQuotaHistory].[rowguid] = @rowguid,
 [Sales].[SalesPersonQuotaHistory].[ModifiedDate] = @ModifiedDate
    WHERE ([Sales].[SalesPersonQuotaHistory].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesPersonQuotaHistory] (
        [Sales].[SalesPersonQuotaHistory].[BusinessEntityID],
        [Sales].[SalesPersonQuotaHistory].[QuotaDate],
        [Sales].[SalesPersonQuotaHistory].[SalesQuota],
        [Sales].[SalesPersonQuotaHistory].[rowguid],
        [Sales].[SalesPersonQuotaHistory].[ModifiedDate])
    VALUES (
        @BusinessEntityID,
        @QuotaDate,
        @SalesQuota,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesReason_Delete]
(
 @SalesReasonID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SalesOrderHeaderSalesReason]
    WHERE ([Sales].[SalesOrderHeaderSalesReason].[SalesReasonID] = @SalesReasonID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [Sales].[SalesReason]
    WHERE ([Sales].[SalesReason].[SalesReasonID] = @SalesReasonID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesReason_Save]
(
 @SalesReasonID [int] = NULL,
 @Name [nvarchar] (50),
 @ReasonType [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesReason] SET
 [Sales].[SalesReason].[Name] = @Name,
 [Sales].[SalesReason].[ReasonType] = @ReasonType,
 [Sales].[SalesReason].[ModifiedDate] = @ModifiedDate
    WHERE ([Sales].[SalesReason].[SalesReasonID] = @SalesReasonID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesReason] (
        [Sales].[SalesReason].[Name],
        [Sales].[SalesReason].[ReasonType],
        [Sales].[SalesReason].[ModifiedDate])
    VALUES (
        @Name,
        @ReasonType,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @SalesReasonID = SCOPE_IDENTITY() 
    SELECT DISTINCT @SalesReasonID AS 'SalesReasonID' 
        FROM [Sales].[SalesReason]
        WHERE ([Sales].[SalesReason].[SalesReasonID] = @SalesReasonID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTaxRate_Delete]
(
 @SalesTaxRateID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SalesTaxRate]
    WHERE ([Sales].[SalesTaxRate].[SalesTaxRateID] = @SalesTaxRateID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTaxRate_Save]
(
 @SalesTaxRateID [int] = NULL,
 @TaxType [tinyint],
 @TaxRate [money],
 @Name [nvarchar] (50),
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @StateProvinceID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesTaxRate] SET
 [Sales].[SalesTaxRate].[TaxType] = @TaxType,
 [Sales].[SalesTaxRate].[TaxRate] = @TaxRate,
 [Sales].[SalesTaxRate].[Name] = @Name,
 [Sales].[SalesTaxRate].[rowguid] = @rowguid,
 [Sales].[SalesTaxRate].[ModifiedDate] = @ModifiedDate,
 [Sales].[SalesTaxRate].[StateProvinceID] = @StateProvinceID
    WHERE ([Sales].[SalesTaxRate].[SalesTaxRateID] = @SalesTaxRateID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesTaxRate] (
        [Sales].[SalesTaxRate].[TaxType],
        [Sales].[SalesTaxRate].[TaxRate],
        [Sales].[SalesTaxRate].[Name],
        [Sales].[SalesTaxRate].[rowguid],
        [Sales].[SalesTaxRate].[ModifiedDate],
        [Sales].[SalesTaxRate].[StateProvinceID])
    VALUES (
        @TaxType,
        @TaxRate,
        @Name,
        @rowguid,
        @ModifiedDate,
        @StateProvinceID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @SalesTaxRateID = SCOPE_IDENTITY() 
    SELECT DISTINCT @SalesTaxRateID AS 'SalesTaxRateID' 
        FROM [Sales].[SalesTaxRate]
        WHERE ([Sales].[SalesTaxRate].[SalesTaxRateID] = @SalesTaxRateID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritory_Delete]
(
 @TerritoryID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[StateProvince] SET
 [Person].[StateProvince].[TerritoryID] = NULL
    WHERE ([Person].[StateProvince].[TerritoryID] = @TerritoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Sales].[Customer] SET
 [Sales].[Customer].[TerritoryID] = NULL
    WHERE ([Sales].[Customer].[TerritoryID] = @TerritoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Sales].[SalesOrderHeader] SET
 [Sales].[SalesOrderHeader].[TerritoryID] = NULL
    WHERE ([Sales].[SalesOrderHeader].[TerritoryID] = @TerritoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Sales].[SalesPerson] SET
 [Sales].[SalesPerson].[TerritoryID] = NULL
    WHERE ([Sales].[SalesPerson].[TerritoryID] = @TerritoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Sales].[SalesTerritory]
    WHERE ([Sales].[SalesTerritory].[TerritoryID] = @TerritoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritory_Save]
(
 @TerritoryID [int] = NULL,
 @Name [nvarchar] (50),
 @Group [nvarchar] (50),
 @SalesYTD [money],
 @SalesLastYear [money],
 @CostYTD [money],
 @CostLastYear [money],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @CountryRegionCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesTerritory] SET
 [Sales].[SalesTerritory].[Name] = @Name,
 [Sales].[SalesTerritory].[Group] = @Group,
 [Sales].[SalesTerritory].[SalesYTD] = @SalesYTD,
 [Sales].[SalesTerritory].[SalesLastYear] = @SalesLastYear,
 [Sales].[SalesTerritory].[CostYTD] = @CostYTD,
 [Sales].[SalesTerritory].[CostLastYear] = @CostLastYear,
 [Sales].[SalesTerritory].[rowguid] = @rowguid,
 [Sales].[SalesTerritory].[ModifiedDate] = @ModifiedDate,
 [Sales].[SalesTerritory].[CountryRegionCode] = @CountryRegionCode
    WHERE ([Sales].[SalesTerritory].[TerritoryID] = @TerritoryID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesTerritory] (
        [Sales].[SalesTerritory].[Name],
        [Sales].[SalesTerritory].[Group],
        [Sales].[SalesTerritory].[SalesYTD],
        [Sales].[SalesTerritory].[SalesLastYear],
        [Sales].[SalesTerritory].[CostYTD],
        [Sales].[SalesTerritory].[CostLastYear],
        [Sales].[SalesTerritory].[rowguid],
        [Sales].[SalesTerritory].[ModifiedDate],
        [Sales].[SalesTerritory].[CountryRegionCode])
    VALUES (
        @Name,
        @Group,
        @SalesYTD,
        @SalesLastYear,
        @CostYTD,
        @CostLastYear,
        @rowguid,
        @ModifiedDate,
        @CountryRegionCode)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @TerritoryID = SCOPE_IDENTITY() 
    SELECT DISTINCT @TerritoryID AS 'TerritoryID' 
        FROM [Sales].[SalesTerritory]
        WHERE ([Sales].[SalesTerritory].[TerritoryID] = @TerritoryID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritoryHistory_Delete]
(
 @BusinessEntityID [int],
 @TerritoryID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SalesTerritoryHistory]
    WHERE (([Sales].[SalesTerritoryHistory].[BusinessEntityID] = @BusinessEntityID) AND ([Sales].[SalesTerritoryHistory].[TerritoryID] = @TerritoryID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritoryHistory_Save]
(
 @BusinessEntityID [int],
 @TerritoryID [int],
 @StartDate [datetime],
 @EndDate [datetime] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SalesTerritoryHistory] SET
 [Sales].[SalesTerritoryHistory].[StartDate] = @StartDate,
 [Sales].[SalesTerritoryHistory].[EndDate] = @EndDate,
 [Sales].[SalesTerritoryHistory].[rowguid] = @rowguid,
 [Sales].[SalesTerritoryHistory].[ModifiedDate] = @ModifiedDate
    WHERE (([Sales].[SalesTerritoryHistory].[BusinessEntityID] = @BusinessEntityID) AND ([Sales].[SalesTerritoryHistory].[TerritoryID] = @TerritoryID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SalesTerritoryHistory] (
        [Sales].[SalesTerritoryHistory].[BusinessEntityID],
        [Sales].[SalesTerritoryHistory].[TerritoryID],
        [Sales].[SalesTerritoryHistory].[StartDate],
        [Sales].[SalesTerritoryHistory].[EndDate],
        [Sales].[SalesTerritoryHistory].[rowguid],
        [Sales].[SalesTerritoryHistory].[ModifiedDate])
    VALUES (
        @BusinessEntityID,
        @TerritoryID,
        @StartDate,
        @EndDate,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ScrapReason_Delete]
(
 @ScrapReasonID [smallint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[WorkOrder] SET
 [Production].[WorkOrder].[ScrapReasonID] = NULL
    WHERE ([Production].[WorkOrder].[ScrapReasonID] = @ScrapReasonID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Production].[ScrapReason]
    WHERE ([Production].[ScrapReason].[ScrapReasonID] = @ScrapReasonID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[ScrapReason_Save]
(
 @ScrapReasonID [smallint] = NULL,
 @Name [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[ScrapReason] SET
 [Production].[ScrapReason].[Name] = @Name,
 [Production].[ScrapReason].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[ScrapReason].[ScrapReasonID] = @ScrapReasonID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[ScrapReason] (
        [Production].[ScrapReason].[Name],
        [Production].[ScrapReason].[ModifiedDate])
    VALUES (
        @Name,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ScrapReasonID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ScrapReasonID AS 'ScrapReasonID' 
        FROM [Production].[ScrapReason]
        WHERE ([Production].[ScrapReason].[ScrapReasonID] = @ScrapReasonID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[Shift_Delete]
(
 @ShiftID [tinyint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [HumanResources].[EmployeeDepartmentHistory]
    WHERE ([HumanResources].[EmployeeDepartmentHistory].[ShiftID] = @ShiftID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
DELETE FROM [HumanResources].[Shift]
    WHERE ([HumanResources].[Shift].[ShiftID] = @ShiftID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [HumanResources].[Shift_Save]
(
 @ShiftID [tinyint] = NULL,
 @Name [nvarchar] (50),
 @StartTime [datetime],
 @EndTime [datetime],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [HumanResources].[Shift] SET
 [HumanResources].[Shift].[Name] = @Name,
 [HumanResources].[Shift].[StartTime] = @StartTime,
 [HumanResources].[Shift].[EndTime] = @EndTime,
 [HumanResources].[Shift].[ModifiedDate] = @ModifiedDate
    WHERE ([HumanResources].[Shift].[ShiftID] = @ShiftID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [HumanResources].[Shift] (
        [HumanResources].[Shift].[Name],
        [HumanResources].[Shift].[StartTime],
        [HumanResources].[Shift].[EndTime],
        [HumanResources].[Shift].[ModifiedDate])
    VALUES (
        @Name,
        @StartTime,
        @EndTime,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ShiftID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ShiftID AS 'ShiftID' 
        FROM [HumanResources].[Shift]
        WHERE ([HumanResources].[Shift].[ShiftID] = @ShiftID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[ShipMethod_Delete]
(
 @ShipMethodID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Purchasing].[PurchaseOrderHeader] SET
 [Purchasing].[PurchaseOrderHeader].[ShipMethodID] = NULL
    WHERE ([Purchasing].[PurchaseOrderHeader].[ShipMethodID] = @ShipMethodID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Sales].[SalesOrderHeader] SET
 [Sales].[SalesOrderHeader].[ShipMethodID] = NULL
    WHERE ([Sales].[SalesOrderHeader].[ShipMethodID] = @ShipMethodID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Purchasing].[ShipMethod]
    WHERE ([Purchasing].[ShipMethod].[ShipMethodID] = @ShipMethodID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[ShipMethod_Save]
(
 @ShipMethodID [int] = NULL,
 @Name [nvarchar] (50),
 @ShipBase [money],
 @ShipRate [money],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Purchasing].[ShipMethod] SET
 [Purchasing].[ShipMethod].[Name] = @Name,
 [Purchasing].[ShipMethod].[ShipBase] = @ShipBase,
 [Purchasing].[ShipMethod].[ShipRate] = @ShipRate,
 [Purchasing].[ShipMethod].[rowguid] = @rowguid,
 [Purchasing].[ShipMethod].[ModifiedDate] = @ModifiedDate
    WHERE ([Purchasing].[ShipMethod].[ShipMethodID] = @ShipMethodID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Purchasing].[ShipMethod] (
        [Purchasing].[ShipMethod].[Name],
        [Purchasing].[ShipMethod].[ShipBase],
        [Purchasing].[ShipMethod].[ShipRate],
        [Purchasing].[ShipMethod].[rowguid],
        [Purchasing].[ShipMethod].[ModifiedDate])
    VALUES (
        @Name,
        @ShipBase,
        @ShipRate,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ShipMethodID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ShipMethodID AS 'ShipMethodID' 
        FROM [Purchasing].[ShipMethod]
        WHERE ([Purchasing].[ShipMethod].[ShipMethodID] = @ShipMethodID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[ShoppingCartItem_Delete]
(
 @ShoppingCartItemID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[ShoppingCartItem]
    WHERE ([Sales].[ShoppingCartItem].[ShoppingCartItemID] = @ShoppingCartItemID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[ShoppingCartItem_Save]
(
 @ShoppingCartItemID [int] = NULL,
 @ShoppingCartID [nvarchar] (50),
 @Quantity [int],
 @DateCreated [datetime],
 @ModifiedDate [datetime],
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[ShoppingCartItem] SET
 [Sales].[ShoppingCartItem].[ShoppingCartID] = @ShoppingCartID,
 [Sales].[ShoppingCartItem].[Quantity] = @Quantity,
 [Sales].[ShoppingCartItem].[DateCreated] = @DateCreated,
 [Sales].[ShoppingCartItem].[ModifiedDate] = @ModifiedDate,
 [Sales].[ShoppingCartItem].[ProductID] = @ProductID
    WHERE ([Sales].[ShoppingCartItem].[ShoppingCartItemID] = @ShoppingCartItemID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[ShoppingCartItem] (
        [Sales].[ShoppingCartItem].[ShoppingCartID],
        [Sales].[ShoppingCartItem].[Quantity],
        [Sales].[ShoppingCartItem].[DateCreated],
        [Sales].[ShoppingCartItem].[ModifiedDate],
        [Sales].[ShoppingCartItem].[ProductID])
    VALUES (
        @ShoppingCartID,
        @Quantity,
        @DateCreated,
        @ModifiedDate,
        @ProductID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @ShoppingCartItemID = SCOPE_IDENTITY() 
    SELECT DISTINCT @ShoppingCartItemID AS 'ShoppingCartItemID' 
        FROM [Sales].[ShoppingCartItem]
        WHERE ([Sales].[ShoppingCartItem].[ShoppingCartItemID] = @ShoppingCartItemID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOffer_Delete]
(
 @SpecialOfferID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SpecialOfferProduct]
    WHERE ([Sales].[SpecialOfferProduct].[SpecialOfferID] = @SpecialOfferID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
UPDATE [Sales].[SalesOrderDetail] SET
 [Sales].[SalesOrderDetail].[SpecialOfferID] = NULL
    WHERE ([Sales].[SalesOrderDetail].[SpecialOfferID] = @SpecialOfferID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Sales].[SpecialOffer]
    WHERE ([Sales].[SpecialOffer].[SpecialOfferID] = @SpecialOfferID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOffer_Save]
(
 @SpecialOfferID [int] = NULL,
 @Description [nvarchar] (255),
 @DiscountPct [money],
 @Type [nvarchar] (50),
 @Category [nvarchar] (50),
 @StartDate [datetime],
 @EndDate [datetime],
 @MinQty [int],
 @MaxQty [int] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SpecialOffer] SET
 [Sales].[SpecialOffer].[Description] = @Description,
 [Sales].[SpecialOffer].[DiscountPct] = @DiscountPct,
 [Sales].[SpecialOffer].[Type] = @Type,
 [Sales].[SpecialOffer].[Category] = @Category,
 [Sales].[SpecialOffer].[StartDate] = @StartDate,
 [Sales].[SpecialOffer].[EndDate] = @EndDate,
 [Sales].[SpecialOffer].[MinQty] = @MinQty,
 [Sales].[SpecialOffer].[MaxQty] = @MaxQty,
 [Sales].[SpecialOffer].[rowguid] = @rowguid,
 [Sales].[SpecialOffer].[ModifiedDate] = @ModifiedDate
    WHERE ([Sales].[SpecialOffer].[SpecialOfferID] = @SpecialOfferID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SpecialOffer] (
        [Sales].[SpecialOffer].[Description],
        [Sales].[SpecialOffer].[DiscountPct],
        [Sales].[SpecialOffer].[Type],
        [Sales].[SpecialOffer].[Category],
        [Sales].[SpecialOffer].[StartDate],
        [Sales].[SpecialOffer].[EndDate],
        [Sales].[SpecialOffer].[MinQty],
        [Sales].[SpecialOffer].[MaxQty],
        [Sales].[SpecialOffer].[rowguid],
        [Sales].[SpecialOffer].[ModifiedDate])
    VALUES (
        @Description,
        @DiscountPct,
        @Type,
        @Category,
        @StartDate,
        @EndDate,
        @MinQty,
        @MaxQty,
        @rowguid,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @SpecialOfferID = SCOPE_IDENTITY() 
    SELECT DISTINCT @SpecialOfferID AS 'SpecialOfferID' 
        FROM [Sales].[SpecialOffer]
        WHERE ([Sales].[SpecialOffer].[SpecialOfferID] = @SpecialOfferID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOfferProduct_Delete]
(
 @ProductID [int],
 @SpecialOfferID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[SpecialOfferProduct]
    WHERE (([Sales].[SpecialOfferProduct].[ProductID] = @ProductID) AND ([Sales].[SpecialOfferProduct].[SpecialOfferID] = @SpecialOfferID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOfferProduct_Save]
(
 @ProductID [int],
 @SpecialOfferID [int],
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[SpecialOfferProduct] SET
 [Sales].[SpecialOfferProduct].[rowguid] = @rowguid,
 [Sales].[SpecialOfferProduct].[ModifiedDate] = @ModifiedDate
    WHERE (([Sales].[SpecialOfferProduct].[ProductID] = @ProductID) AND ([Sales].[SpecialOfferProduct].[SpecialOfferID] = @SpecialOfferID))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[SpecialOfferProduct] (
        [Sales].[SpecialOfferProduct].[ProductID],
        [Sales].[SpecialOfferProduct].[rowguid],
        [Sales].[SpecialOfferProduct].[ModifiedDate],
        [Sales].[SpecialOfferProduct].[SpecialOfferID])
    VALUES (
        @ProductID,
        @rowguid,
        @ModifiedDate,
        @SpecialOfferID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[StateProvince_Delete]
(
 @StateProvinceID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[Address] SET
 [Person].[Address].[StateProvinceID] = NULL
    WHERE ([Person].[Address].[StateProvinceID] = @StateProvinceID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Sales].[SalesTaxRate] SET
 [Sales].[SalesTaxRate].[StateProvinceID] = NULL
    WHERE ([Sales].[SalesTaxRate].[StateProvinceID] = @StateProvinceID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Person].[StateProvince]
    WHERE ([Person].[StateProvince].[StateProvinceID] = @StateProvinceID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[StateProvince_Save]
(
 @StateProvinceID [int] = NULL,
 @StateProvinceCode [nvarchar] (3),
 @IsOnlyStateProvinceFlag [bit],
 @Name [nvarchar] (50),
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime],
 @CountryRegionCode [nvarchar] (3),
 @TerritoryID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Person].[StateProvince] SET
 [Person].[StateProvince].[StateProvinceCode] = @StateProvinceCode,
 [Person].[StateProvince].[IsOnlyStateProvinceFlag] = @IsOnlyStateProvinceFlag,
 [Person].[StateProvince].[Name] = @Name,
 [Person].[StateProvince].[rowguid] = @rowguid,
 [Person].[StateProvince].[ModifiedDate] = @ModifiedDate,
 [Person].[StateProvince].[CountryRegionCode] = @CountryRegionCode,
 [Person].[StateProvince].[TerritoryID] = @TerritoryID
    WHERE ([Person].[StateProvince].[StateProvinceID] = @StateProvinceID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Person].[StateProvince] (
        [Person].[StateProvince].[StateProvinceCode],
        [Person].[StateProvince].[IsOnlyStateProvinceFlag],
        [Person].[StateProvince].[Name],
        [Person].[StateProvince].[rowguid],
        [Person].[StateProvince].[ModifiedDate],
        [Person].[StateProvince].[CountryRegionCode],
        [Person].[StateProvince].[TerritoryID])
    VALUES (
        @StateProvinceCode,
        @IsOnlyStateProvinceFlag,
        @Name,
        @rowguid,
        @ModifiedDate,
        @CountryRegionCode,
        @TerritoryID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @StateProvinceID = SCOPE_IDENTITY() 
    SELECT DISTINCT @StateProvinceID AS 'StateProvinceID' 
        FROM [Person].[StateProvince]
        WHERE ([Person].[StateProvince].[StateProvinceID] = @StateProvinceID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[Store_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Sales].[Store]
    WHERE ([Sales].[Store].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Sales].[Store_Save]
(
 @BusinessEntityID [int],
 @Name [nvarchar] (50),
 @SalesPersonID [int] = NULL,
 @Demographics [xml] = NULL,
 @rowguid [uniqueidentifier],
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Sales].[Store] SET
 [Sales].[Store].[Name] = @Name,
 [Sales].[Store].[SalesPersonID] = @SalesPersonID,
 [Sales].[Store].[Demographics] = @Demographics,
 [Sales].[Store].[rowguid] = @rowguid,
 [Sales].[Store].[ModifiedDate] = @ModifiedDate
    WHERE ([Sales].[Store].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Sales].[Store] (
        [Sales].[Store].[Name],
        [Sales].[Store].[SalesPersonID],
        [Sales].[Store].[Demographics],
        [Sales].[Store].[rowguid],
        [Sales].[Store].[ModifiedDate],
        [Sales].[Store].[BusinessEntityID])
    VALUES (
        @Name,
        @SalesPersonID,
        @Demographics,
        @rowguid,
        @ModifiedDate,
        @BusinessEntityID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistory_Delete]
(
 @TransactionID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[TransactionHistory]
    WHERE ([Production].[TransactionHistory].[TransactionID] = @TransactionID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistory_Save]
(
 @TransactionID [int] = NULL,
 @ReferenceOrderID [int],
 @ReferenceOrderLineID [int],
 @TransactionDate [datetime],
 @TransactionType [nvarchar] (1),
 @Quantity [int],
 @ActualCost [money],
 @ModifiedDate [datetime],
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[TransactionHistory] SET
 [Production].[TransactionHistory].[ReferenceOrderID] = @ReferenceOrderID,
 [Production].[TransactionHistory].[ReferenceOrderLineID] = @ReferenceOrderLineID,
 [Production].[TransactionHistory].[TransactionDate] = @TransactionDate,
 [Production].[TransactionHistory].[TransactionType] = @TransactionType,
 [Production].[TransactionHistory].[Quantity] = @Quantity,
 [Production].[TransactionHistory].[ActualCost] = @ActualCost,
 [Production].[TransactionHistory].[ModifiedDate] = @ModifiedDate,
 [Production].[TransactionHistory].[ProductID] = @ProductID
    WHERE ([Production].[TransactionHistory].[TransactionID] = @TransactionID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[TransactionHistory] (
        [Production].[TransactionHistory].[ReferenceOrderID],
        [Production].[TransactionHistory].[ReferenceOrderLineID],
        [Production].[TransactionHistory].[TransactionDate],
        [Production].[TransactionHistory].[TransactionType],
        [Production].[TransactionHistory].[Quantity],
        [Production].[TransactionHistory].[ActualCost],
        [Production].[TransactionHistory].[ModifiedDate],
        [Production].[TransactionHistory].[ProductID])
    VALUES (
        @ReferenceOrderID,
        @ReferenceOrderLineID,
        @TransactionDate,
        @TransactionType,
        @Quantity,
        @ActualCost,
        @ModifiedDate,
        @ProductID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @TransactionID = SCOPE_IDENTITY() 
    SELECT DISTINCT @TransactionID AS 'TransactionID' 
        FROM [Production].[TransactionHistory]
        WHERE ([Production].[TransactionHistory].[TransactionID] = @TransactionID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistoryArchive_Delete]
(
 @TransactionID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[TransactionHistoryArchive]
    WHERE ([Production].[TransactionHistoryArchive].[TransactionID] = @TransactionID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistoryArchive_Save]
(
 @TransactionID [int],
 @ReferenceOrderID [int],
 @ReferenceOrderLineID [int],
 @TransactionDate [datetime],
 @TransactionType [nvarchar] (1),
 @Quantity [int],
 @ActualCost [money],
 @ModifiedDate [datetime],
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[TransactionHistoryArchive] SET
 [Production].[TransactionHistoryArchive].[ReferenceOrderID] = @ReferenceOrderID,
 [Production].[TransactionHistoryArchive].[ReferenceOrderLineID] = @ReferenceOrderLineID,
 [Production].[TransactionHistoryArchive].[TransactionDate] = @TransactionDate,
 [Production].[TransactionHistoryArchive].[TransactionType] = @TransactionType,
 [Production].[TransactionHistoryArchive].[Quantity] = @Quantity,
 [Production].[TransactionHistoryArchive].[ActualCost] = @ActualCost,
 [Production].[TransactionHistoryArchive].[ModifiedDate] = @ModifiedDate,
 [Production].[TransactionHistoryArchive].[ProductID] = @ProductID
    WHERE ([Production].[TransactionHistoryArchive].[TransactionID] = @TransactionID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[TransactionHistoryArchive] (
        [Production].[TransactionHistoryArchive].[TransactionID],
        [Production].[TransactionHistoryArchive].[ReferenceOrderID],
        [Production].[TransactionHistoryArchive].[ReferenceOrderLineID],
        [Production].[TransactionHistoryArchive].[TransactionDate],
        [Production].[TransactionHistoryArchive].[TransactionType],
        [Production].[TransactionHistoryArchive].[Quantity],
        [Production].[TransactionHistoryArchive].[ActualCost],
        [Production].[TransactionHistoryArchive].[ModifiedDate],
        [Production].[TransactionHistoryArchive].[ProductID])
    VALUES (
        @TransactionID,
        @ReferenceOrderID,
        @ReferenceOrderLineID,
        @TransactionDate,
        @TransactionType,
        @Quantity,
        @ActualCost,
        @ModifiedDate,
        @ProductID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[UnitMeasure_Delete]
(
 @UnitMeasureCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[BillOfMaterials] SET
 [Production].[BillOfMaterials].[UnitMeasureCode] = NULL
    WHERE ([Production].[BillOfMaterials].[UnitMeasureCode] = @UnitMeasureCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Purchasing].[ProductVendor] SET
 [Purchasing].[ProductVendor].[UnitMeasureCode] = NULL
    WHERE ([Purchasing].[ProductVendor].[UnitMeasureCode] = @UnitMeasureCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Production].[Product] SET
 [Production].[Product].[SizeUnitMeasureCode] = NULL
    WHERE ([Production].[Product].[SizeUnitMeasureCode] = @UnitMeasureCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
UPDATE [Production].[Product] SET
 [Production].[Product].[WeightUnitMeasureCode] = NULL
    WHERE ([Production].[Product].[WeightUnitMeasureCode] = @UnitMeasureCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
DELETE FROM [Production].[UnitMeasure]
    WHERE ([Production].[UnitMeasure].[UnitMeasureCode] = @UnitMeasureCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[UnitMeasure_Save]
(
 @UnitMeasureCode [nvarchar] (3),
 @Name [nvarchar] (50),
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[UnitMeasure] SET
 [Production].[UnitMeasure].[Name] = @Name,
 [Production].[UnitMeasure].[ModifiedDate] = @ModifiedDate
    WHERE ([Production].[UnitMeasure].[UnitMeasureCode] = @UnitMeasureCode)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[UnitMeasure] (
        [Production].[UnitMeasure].[UnitMeasureCode],
        [Production].[UnitMeasure].[Name],
        [Production].[UnitMeasure].[ModifiedDate])
    VALUES (
        @UnitMeasureCode,
        @Name,
        @ModifiedDate)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[Vendor_Delete]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Purchasing].[Vendor]
    WHERE ([Purchasing].[Vendor].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Purchasing].[Vendor_Save]
(
 @BusinessEntityID [int],
 @AccountNumber [nvarchar] (15),
 @Name [nvarchar] (50),
 @CreditRating [tinyint],
 @PreferredVendorStatus [bit],
 @ActiveFlag [bit],
 @PurchasingWebServiceURL [nvarchar] (1024) = NULL,
 @ModifiedDate [datetime]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Purchasing].[Vendor] SET
 [Purchasing].[Vendor].[AccountNumber] = @AccountNumber,
 [Purchasing].[Vendor].[Name] = @Name,
 [Purchasing].[Vendor].[CreditRating] = @CreditRating,
 [Purchasing].[Vendor].[PreferredVendorStatus] = @PreferredVendorStatus,
 [Purchasing].[Vendor].[ActiveFlag] = @ActiveFlag,
 [Purchasing].[Vendor].[PurchasingWebServiceURL] = @PurchasingWebServiceURL,
 [Purchasing].[Vendor].[ModifiedDate] = @ModifiedDate
    WHERE ([Purchasing].[Vendor].[BusinessEntityID] = @BusinessEntityID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Purchasing].[Vendor] (
        [Purchasing].[Vendor].[AccountNumber],
        [Purchasing].[Vendor].[Name],
        [Purchasing].[Vendor].[CreditRating],
        [Purchasing].[Vendor].[PreferredVendorStatus],
        [Purchasing].[Vendor].[ActiveFlag],
        [Purchasing].[Vendor].[PurchasingWebServiceURL],
        [Purchasing].[Vendor].[ModifiedDate],
        [Purchasing].[Vendor].[BusinessEntityID])
    VALUES (
        @AccountNumber,
        @Name,
        @CreditRating,
        @PreferredVendorStatus,
        @ActiveFlag,
        @PurchasingWebServiceURL,
        @ModifiedDate,
        @BusinessEntityID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrder_Delete]
(
 @WorkOrderID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[WorkOrder]
    WHERE ([Production].[WorkOrder].[WorkOrderID] = @WorkOrderID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrder_Save]
(
 @WorkOrderID [int] = NULL,
 @OrderQty [int],
 @ScrappedQty [smallint],
 @StartDate [datetime],
 @EndDate [datetime] = NULL,
 @DueDate [datetime],
 @ModifiedDate [datetime],
 @ScrapReasonID [smallint] = NULL,
 @ProductID [int]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[WorkOrder] SET
 [Production].[WorkOrder].[OrderQty] = @OrderQty,
 [Production].[WorkOrder].[ScrappedQty] = @ScrappedQty,
 [Production].[WorkOrder].[StartDate] = @StartDate,
 [Production].[WorkOrder].[EndDate] = @EndDate,
 [Production].[WorkOrder].[DueDate] = @DueDate,
 [Production].[WorkOrder].[ModifiedDate] = @ModifiedDate,
 [Production].[WorkOrder].[ScrapReasonID] = @ScrapReasonID,
 [Production].[WorkOrder].[ProductID] = @ProductID
    WHERE ([Production].[WorkOrder].[WorkOrderID] = @WorkOrderID)
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[WorkOrder] (
        [Production].[WorkOrder].[OrderQty],
        [Production].[WorkOrder].[ScrappedQty],
        [Production].[WorkOrder].[StartDate],
        [Production].[WorkOrder].[EndDate],
        [Production].[WorkOrder].[DueDate],
        [Production].[WorkOrder].[ModifiedDate],
        [Production].[WorkOrder].[ScrapReasonID],
        [Production].[WorkOrder].[ProductID])
    VALUES (
        @OrderQty,
        @ScrappedQty,
        @StartDate,
        @EndDate,
        @DueDate,
        @ModifiedDate,
        @ScrapReasonID,
        @ProductID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
    SELECT DISTINCT @WorkOrderID = SCOPE_IDENTITY() 
    SELECT DISTINCT @WorkOrderID AS 'WorkOrderID' 
        FROM [Production].[WorkOrder]
        WHERE ([Production].[WorkOrder].[WorkOrderID] = @WorkOrderID)
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrderRouting_Delete]
(
 @WorkOrderID [int],
 @ProductID [int],
 @OperationSequence [smallint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
DELETE FROM [Production].[WorkOrderRouting]
    WHERE ((([Production].[WorkOrderRouting].[WorkOrderID] = @WorkOrderID) AND ([Production].[WorkOrderRouting].[ProductID] = @ProductID)) AND ([Production].[WorkOrderRouting].[OperationSequence] = @OperationSequence))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrderRouting_Save]
(
 @WorkOrderID [int],
 @ProductID [int],
 @OperationSequence [smallint],
 @ScheduledStartDate [datetime],
 @ScheduledEndDate [datetime],
 @ActualStartDate [datetime] = NULL,
 @ActualEndDate [datetime] = NULL,
 @ActualResourceHrs [decimal] (28, 13) = NULL,
 @PlannedCost [money],
 @ActualCost [money] = NULL,
 @ModifiedDate [datetime],
 @LocationID [smallint]
)
AS
SET NOCOUNT ON
DECLARE @error int, @rowcount int
DECLARE @tran bit; SELECT @tran = 0
IF @@TRANCOUNT = 0
BEGIN
 SELECT @tran = 1
 BEGIN TRANSACTION
END
UPDATE [Production].[WorkOrderRouting] SET
 [Production].[WorkOrderRouting].[ScheduledStartDate] = @ScheduledStartDate,
 [Production].[WorkOrderRouting].[ScheduledEndDate] = @ScheduledEndDate,
 [Production].[WorkOrderRouting].[ActualStartDate] = @ActualStartDate,
 [Production].[WorkOrderRouting].[ActualEndDate] = @ActualEndDate,
 [Production].[WorkOrderRouting].[ActualResourceHrs] = @ActualResourceHrs,
 [Production].[WorkOrderRouting].[PlannedCost] = @PlannedCost,
 [Production].[WorkOrderRouting].[ActualCost] = @ActualCost,
 [Production].[WorkOrderRouting].[ModifiedDate] = @ModifiedDate,
 [Production].[WorkOrderRouting].[LocationID] = @LocationID
    WHERE ((([Production].[WorkOrderRouting].[WorkOrderID] = @WorkOrderID) AND ([Production].[WorkOrderRouting].[ProductID] = @ProductID)) AND ([Production].[WorkOrderRouting].[OperationSequence] = @OperationSequence))
SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
IF(@error != 0)
BEGIN
    IF @tran = 1 ROLLBACK TRANSACTION
    RETURN
END
IF(@rowcount = 0)
BEGIN
    INSERT INTO [Production].[WorkOrderRouting] (
        [Production].[WorkOrderRouting].[WorkOrderID],
        [Production].[WorkOrderRouting].[ProductID],
        [Production].[WorkOrderRouting].[OperationSequence],
        [Production].[WorkOrderRouting].[ScheduledStartDate],
        [Production].[WorkOrderRouting].[ScheduledEndDate],
        [Production].[WorkOrderRouting].[ActualStartDate],
        [Production].[WorkOrderRouting].[ActualEndDate],
        [Production].[WorkOrderRouting].[ActualResourceHrs],
        [Production].[WorkOrderRouting].[PlannedCost],
        [Production].[WorkOrderRouting].[ActualCost],
        [Production].[WorkOrderRouting].[ModifiedDate],
        [Production].[WorkOrderRouting].[LocationID])
    VALUES (
        @WorkOrderID,
        @ProductID,
        @OperationSequence,
        @ScheduledStartDate,
        @ScheduledEndDate,
        @ActualStartDate,
        @ActualEndDate,
        @ActualResourceHrs,
        @PlannedCost,
        @ActualCost,
        @ModifiedDate,
        @LocationID)
    SELECT @error = @@ERROR, @rowcount = @@ROWCOUNT
    IF(@error != 0)
    BEGIN
        IF @tran = 1 ROLLBACK TRANSACTION
        RETURN
    END
END
IF @tran = 1 COMMIT TRANSACTION

RETURN
GO

CREATE PROCEDURE [Person].[Address_Load]
(
 @AddressID [int]
)
AS
SET NOCOUNT ON
SELECT [Person].[Address].[AddressID], [Person].[Address].[AddressLine1], [Person].[Address].[AddressLine2], [Person].[Address].[City], [Person].[Address].[PostalCode], [Person].[Address].[SpatialLocation], [Person].[Address].[rowguid], [Person].[Address].[ModifiedDate], [Person].[Address].[StateProvinceID] 
    FROM [Person].[Address]
    WHERE ([Person].[Address].[AddressID] = @AddressID)

RETURN
GO

CREATE PROCEDURE [Person].[Address_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Person].[Address].[AddressID], [Person].[Address].[AddressLine1], [Person].[Address].[AddressLine2], [Person].[Address].[City], [Person].[Address].[PostalCode], [Person].[Address].[SpatialLocation], [Person].[Address].[rowguid], [Person].[Address].[ModifiedDate], [Person].[Address].[StateProvinceID] 
    FROM [Person].[Address]

RETURN
GO

CREATE PROCEDURE [Person].[Address_LoadByStateProvince]
(
 @StateProvinceStateProvinceID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Person].[Address].[AddressID], [Person].[Address].[AddressLine1], [Person].[Address].[AddressLine2], [Person].[Address].[City], [Person].[Address].[PostalCode], [Person].[Address].[SpatialLocation], [Person].[Address].[rowguid], [Person].[Address].[ModifiedDate], [Person].[Address].[StateProvinceID] 
    FROM [Person].[Address]
    WHERE ([Person].[Address].[StateProvinceID] = @StateProvinceStateProvinceID)

RETURN
GO

CREATE PROCEDURE [Person].[AddressType_Load]
(
 @AddressTypeID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[AddressType].[AddressTypeID], [Person].[AddressType].[Name], [Person].[AddressType].[rowguid], [Person].[AddressType].[ModifiedDate] 
    FROM [Person].[AddressType]
    WHERE ([Person].[AddressType].[AddressTypeID] = @AddressTypeID)

RETURN
GO

CREATE PROCEDURE [Person].[AddressType_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[AddressType].[AddressTypeID], [Person].[AddressType].[Name], [Person].[AddressType].[rowguid], [Person].[AddressType].[ModifiedDate] 
    FROM [Person].[AddressType]

RETURN
GO

CREATE PROCEDURE [dbo].[AWBuildVersion_Load]
(
 @SystemInformationID [tinyint]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [AWBuildVersion].[SystemInformationID], [AWBuildVersion].[Database Version], [AWBuildVersion].[VersionDate], [AWBuildVersion].[ModifiedDate] 
    FROM [AWBuildVersion]
    WHERE ([AWBuildVersion].[SystemInformationID] = @SystemInformationID)

RETURN
GO

CREATE PROCEDURE [dbo].[AWBuildVersion_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [AWBuildVersion].[SystemInformationID], [AWBuildVersion].[Database Version], [AWBuildVersion].[VersionDate], [AWBuildVersion].[ModifiedDate] 
    FROM [AWBuildVersion]

RETURN
GO

CREATE PROCEDURE [Production].[BillOfMaterials_Load]
(
 @BillOfMaterialsID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[BillOfMaterials].[BillOfMaterialsID], [Production].[BillOfMaterials].[ProductAssemblyID], [Production].[BillOfMaterials].[ComponentID], [Production].[BillOfMaterials].[StartDate], [Production].[BillOfMaterials].[EndDate], [Production].[BillOfMaterials].[BOMLevel], [Production].[BillOfMaterials].[PerAssemblyQty], [Production].[BillOfMaterials].[ModifiedDate], [Production].[BillOfMaterials].[UnitMeasureCode] 
    FROM [Production].[BillOfMaterials]
    WHERE ([Production].[BillOfMaterials].[BillOfMaterialsID] = @BillOfMaterialsID)

RETURN
GO

CREATE PROCEDURE [Production].[BillOfMaterials_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[BillOfMaterials].[BillOfMaterialsID], [Production].[BillOfMaterials].[ProductAssemblyID], [Production].[BillOfMaterials].[ComponentID], [Production].[BillOfMaterials].[StartDate], [Production].[BillOfMaterials].[EndDate], [Production].[BillOfMaterials].[BOMLevel], [Production].[BillOfMaterials].[PerAssemblyQty], [Production].[BillOfMaterials].[ModifiedDate], [Production].[BillOfMaterials].[UnitMeasureCode] 
    FROM [Production].[BillOfMaterials]

RETURN
GO

CREATE PROCEDURE [Production].[BillOfMaterials_LoadByUnitMeasure]
(
 @UnitMeasureUnitMeasureCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[BillOfMaterials].[BillOfMaterialsID], [Production].[BillOfMaterials].[ProductAssemblyID], [Production].[BillOfMaterials].[ComponentID], [Production].[BillOfMaterials].[StartDate], [Production].[BillOfMaterials].[EndDate], [Production].[BillOfMaterials].[BOMLevel], [Production].[BillOfMaterials].[PerAssemblyQty], [Production].[BillOfMaterials].[ModifiedDate], [Production].[BillOfMaterials].[UnitMeasureCode] 
    FROM [Production].[BillOfMaterials]
    WHERE ([Production].[BillOfMaterials].[UnitMeasureCode] = @UnitMeasureUnitMeasureCode)

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntity_Load]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntity].[BusinessEntityID], [Person].[BusinessEntity].[rowguid], [Person].[BusinessEntity].[ModifiedDate] 
    FROM [Person].[BusinessEntity]
    WHERE ([Person].[BusinessEntity].[BusinessEntityID] = @BusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntity_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntity].[BusinessEntityID], [Person].[BusinessEntity].[rowguid], [Person].[BusinessEntity].[ModifiedDate] 
    FROM [Person].[BusinessEntity]

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityAddress_Load]
(
 @AddressID [int],
 @AddressTypeID [int],
 @BusinessEntityBusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntityAddress].[AddressID], [Person].[BusinessEntityAddress].[AddressTypeID], [Person].[BusinessEntityAddress].[rowguid], [Person].[BusinessEntityAddress].[ModifiedDate], [Person].[BusinessEntityAddress].[BusinessEntityID] 
    FROM [Person].[BusinessEntityAddress]
    WHERE (([Person].[BusinessEntityAddress].[AddressID] = @AddressID) AND (([Person].[BusinessEntityAddress].[AddressTypeID] = @AddressTypeID) AND ([Person].[BusinessEntityAddress].[BusinessEntityID] = @BusinessEntityBusinessEntityID)))

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityAddress_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntityAddress].[AddressID], [Person].[BusinessEntityAddress].[AddressTypeID], [Person].[BusinessEntityAddress].[rowguid], [Person].[BusinessEntityAddress].[ModifiedDate], [Person].[BusinessEntityAddress].[BusinessEntityID] 
    FROM [Person].[BusinessEntityAddress]

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityAddress_LoadByBusinessEntity]
(
 @BusinessEntityBusinessEntityID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntityAddress].[AddressID], [Person].[BusinessEntityAddress].[AddressTypeID], [Person].[BusinessEntityAddress].[rowguid], [Person].[BusinessEntityAddress].[ModifiedDate], [Person].[BusinessEntityAddress].[BusinessEntityID] 
    FROM [Person].[BusinessEntityAddress]
    WHERE ([Person].[BusinessEntityAddress].[BusinessEntityID] = @BusinessEntityBusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityContact_Load]
(
 @PersonID [int],
 @BusinessEntityBusinessEntityID [int],
 @ContactTypeContactTypeID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntityContact].[PersonID], [Person].[BusinessEntityContact].[rowguid], [Person].[BusinessEntityContact].[ModifiedDate], [Person].[BusinessEntityContact].[BusinessEntityID], [Person].[BusinessEntityContact].[ContactTypeID] 
    FROM [Person].[BusinessEntityContact]
    WHERE (([Person].[BusinessEntityContact].[PersonID] = @PersonID) AND (([Person].[BusinessEntityContact].[BusinessEntityID] = @BusinessEntityBusinessEntityID) AND ([Person].[BusinessEntityContact].[ContactTypeID] = @ContactTypeContactTypeID)))

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityContact_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntityContact].[PersonID], [Person].[BusinessEntityContact].[rowguid], [Person].[BusinessEntityContact].[ModifiedDate], [Person].[BusinessEntityContact].[BusinessEntityID], [Person].[BusinessEntityContact].[ContactTypeID] 
    FROM [Person].[BusinessEntityContact]

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityContact_LoadByBusinessEntity]
(
 @BusinessEntityBusinessEntityID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntityContact].[PersonID], [Person].[BusinessEntityContact].[rowguid], [Person].[BusinessEntityContact].[ModifiedDate], [Person].[BusinessEntityContact].[BusinessEntityID], [Person].[BusinessEntityContact].[ContactTypeID] 
    FROM [Person].[BusinessEntityContact]
    WHERE ([Person].[BusinessEntityContact].[BusinessEntityID] = @BusinessEntityBusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Person].[BusinessEntityContact_LoadByContactType]
(
 @ContactTypeContactTypeID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[BusinessEntityContact].[PersonID], [Person].[BusinessEntityContact].[rowguid], [Person].[BusinessEntityContact].[ModifiedDate], [Person].[BusinessEntityContact].[BusinessEntityID], [Person].[BusinessEntityContact].[ContactTypeID] 
    FROM [Person].[BusinessEntityContact]
    WHERE ([Person].[BusinessEntityContact].[ContactTypeID] = @ContactTypeContactTypeID)

RETURN
GO

CREATE PROCEDURE [Person].[ContactType_Load]
(
 @ContactTypeID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[ContactType].[ContactTypeID], [Person].[ContactType].[Name], [Person].[ContactType].[ModifiedDate] 
    FROM [Person].[ContactType]
    WHERE ([Person].[ContactType].[ContactTypeID] = @ContactTypeID)

RETURN
GO

CREATE PROCEDURE [Person].[ContactType_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[ContactType].[ContactTypeID], [Person].[ContactType].[Name], [Person].[ContactType].[ModifiedDate] 
    FROM [Person].[ContactType]

RETURN
GO

CREATE PROCEDURE [Person].[CountryRegion_Load]
(
 @CountryRegionCode [nvarchar] (256)
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[CountryRegion].[CountryRegionCode], [Person].[CountryRegion].[Name], [Person].[CountryRegion].[ModifiedDate] 
    FROM [Person].[CountryRegion]
    WHERE ([Person].[CountryRegion].[CountryRegionCode] = @CountryRegionCode)

RETURN
GO

CREATE PROCEDURE [Person].[CountryRegion_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[CountryRegion].[CountryRegionCode], [Person].[CountryRegion].[Name], [Person].[CountryRegion].[ModifiedDate] 
    FROM [Person].[CountryRegion]

RETURN
GO

CREATE PROCEDURE [Sales].[CountryRegionCurrency_Load]
(
 @CountryRegionCountryRegionCode [nvarchar] (3),
 @CurrencyCurrencyCode [nvarchar] (3)
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CountryRegionCurrency].[ModifiedDate], [Sales].[CountryRegionCurrency].[CountryRegionCode], [Sales].[CountryRegionCurrency].[CurrencyCode] 
    FROM [Sales].[CountryRegionCurrency]
    WHERE (([Sales].[CountryRegionCurrency].[CountryRegionCode] = @CountryRegionCountryRegionCode) AND ([Sales].[CountryRegionCurrency].[CurrencyCode] = @CurrencyCurrencyCode))

RETURN
GO

CREATE PROCEDURE [Sales].[CountryRegionCurrency_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CountryRegionCurrency].[ModifiedDate], [Sales].[CountryRegionCurrency].[CountryRegionCode], [Sales].[CountryRegionCurrency].[CurrencyCode] 
    FROM [Sales].[CountryRegionCurrency]

RETURN
GO

CREATE PROCEDURE [Sales].[CountryRegionCurrency_LoadByCountryRegion]
(
 @CountryRegionCountryRegionCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CountryRegionCurrency].[ModifiedDate], [Sales].[CountryRegionCurrency].[CountryRegionCode], [Sales].[CountryRegionCurrency].[CurrencyCode] 
    FROM [Sales].[CountryRegionCurrency]
    WHERE ([Sales].[CountryRegionCurrency].[CountryRegionCode] = @CountryRegionCountryRegionCode)

RETURN
GO

CREATE PROCEDURE [Sales].[CountryRegionCurrency_LoadByCurrency]
(
 @CurrencyCurrencyCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CountryRegionCurrency].[ModifiedDate], [Sales].[CountryRegionCurrency].[CountryRegionCode], [Sales].[CountryRegionCurrency].[CurrencyCode] 
    FROM [Sales].[CountryRegionCurrency]
    WHERE ([Sales].[CountryRegionCurrency].[CurrencyCode] = @CurrencyCurrencyCode)

RETURN
GO

CREATE PROCEDURE [Sales].[CreditCard_Load]
(
 @CreditCardID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CreditCard].[CreditCardID], [Sales].[CreditCard].[CardType], [Sales].[CreditCard].[CardNumber], [Sales].[CreditCard].[ExpMonth], [Sales].[CreditCard].[ExpYear], [Sales].[CreditCard].[ModifiedDate] 
    FROM [Sales].[CreditCard]
    WHERE ([Sales].[CreditCard].[CreditCardID] = @CreditCardID)

RETURN
GO

CREATE PROCEDURE [Sales].[CreditCard_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CreditCard].[CreditCardID], [Sales].[CreditCard].[CardType], [Sales].[CreditCard].[CardNumber], [Sales].[CreditCard].[ExpMonth], [Sales].[CreditCard].[ExpYear], [Sales].[CreditCard].[ModifiedDate] 
    FROM [Sales].[CreditCard]

RETURN
GO

CREATE PROCEDURE [Production].[Culture_Load]
(
 @CultureID [nvarchar] (256)
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Culture].[CultureID], [Production].[Culture].[Name], [Production].[Culture].[ModifiedDate] 
    FROM [Production].[Culture]
    WHERE ([Production].[Culture].[CultureID] = @CultureID)

RETURN
GO

CREATE PROCEDURE [Production].[Culture_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Culture].[CultureID], [Production].[Culture].[Name], [Production].[Culture].[ModifiedDate] 
    FROM [Production].[Culture]

RETURN
GO

CREATE PROCEDURE [Sales].[Currency_Load]
(
 @CurrencyCode [nvarchar] (256)
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[Currency].[CurrencyCode], [Sales].[Currency].[Name], [Sales].[Currency].[ModifiedDate] 
    FROM [Sales].[Currency]
    WHERE ([Sales].[Currency].[CurrencyCode] = @CurrencyCode)

RETURN
GO

CREATE PROCEDURE [Sales].[Currency_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[Currency].[CurrencyCode], [Sales].[Currency].[Name], [Sales].[Currency].[ModifiedDate] 
    FROM [Sales].[Currency]

RETURN
GO

CREATE PROCEDURE [Sales].[CurrencyRate_Load]
(
 @CurrencyRateID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CurrencyRate].[CurrencyRateID], [Sales].[CurrencyRate].[CurrencyRateDate], [Sales].[CurrencyRate].[AverageRate], [Sales].[CurrencyRate].[EndOfDayRate], [Sales].[CurrencyRate].[ModifiedDate], [Sales].[CurrencyRate].[FromCurrencyCode], [Sales].[CurrencyRate].[ToCurrencyCode] 
    FROM [Sales].[CurrencyRate]
    WHERE ([Sales].[CurrencyRate].[CurrencyRateID] = @CurrencyRateID)

RETURN
GO

CREATE PROCEDURE [Sales].[CurrencyRate_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CurrencyRate].[CurrencyRateID], [Sales].[CurrencyRate].[CurrencyRateDate], [Sales].[CurrencyRate].[AverageRate], [Sales].[CurrencyRate].[EndOfDayRate], [Sales].[CurrencyRate].[ModifiedDate], [Sales].[CurrencyRate].[FromCurrencyCode], [Sales].[CurrencyRate].[ToCurrencyCode] 
    FROM [Sales].[CurrencyRate]

RETURN
GO

CREATE PROCEDURE [Sales].[CurrencyRate_LoadByFromCurrencyCode]
(
 @FromCurrencyCodeCurrencyCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CurrencyRate].[CurrencyRateID], [Sales].[CurrencyRate].[CurrencyRateDate], [Sales].[CurrencyRate].[AverageRate], [Sales].[CurrencyRate].[EndOfDayRate], [Sales].[CurrencyRate].[ModifiedDate], [Sales].[CurrencyRate].[FromCurrencyCode], [Sales].[CurrencyRate].[ToCurrencyCode] 
    FROM [Sales].[CurrencyRate]
    WHERE ([Sales].[CurrencyRate].[FromCurrencyCode] = @FromCurrencyCodeCurrencyCode)

RETURN
GO

CREATE PROCEDURE [Sales].[CurrencyRate_LoadByToCurrencyCode]
(
 @ToCurrencyCodeCurrencyCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[CurrencyRate].[CurrencyRateID], [Sales].[CurrencyRate].[CurrencyRateDate], [Sales].[CurrencyRate].[AverageRate], [Sales].[CurrencyRate].[EndOfDayRate], [Sales].[CurrencyRate].[ModifiedDate], [Sales].[CurrencyRate].[FromCurrencyCode], [Sales].[CurrencyRate].[ToCurrencyCode] 
    FROM [Sales].[CurrencyRate]
    WHERE ([Sales].[CurrencyRate].[ToCurrencyCode] = @ToCurrencyCodeCurrencyCode)

RETURN
GO

CREATE PROCEDURE [Sales].[Customer_Load]
(
 @CustomerID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[Customer].[CustomerID], [Sales].[Customer].[PersonID], [Sales].[Customer].[StoreID], [Sales].[Customer].[AccountNumber], [Sales].[Customer].[rowguid], [Sales].[Customer].[ModifiedDate], [Sales].[Customer].[TerritoryID] 
    FROM [Sales].[Customer]
    WHERE ([Sales].[Customer].[CustomerID] = @CustomerID)

RETURN
GO

CREATE PROCEDURE [Sales].[Customer_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[Customer].[CustomerID], [Sales].[Customer].[PersonID], [Sales].[Customer].[StoreID], [Sales].[Customer].[AccountNumber], [Sales].[Customer].[rowguid], [Sales].[Customer].[ModifiedDate], [Sales].[Customer].[TerritoryID] 
    FROM [Sales].[Customer]

RETURN
GO

CREATE PROCEDURE [Sales].[Customer_LoadBySalesTerritory]
(
 @SalesTerritoryTerritoryID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[Customer].[CustomerID], [Sales].[Customer].[PersonID], [Sales].[Customer].[StoreID], [Sales].[Customer].[AccountNumber], [Sales].[Customer].[rowguid], [Sales].[Customer].[ModifiedDate], [Sales].[Customer].[TerritoryID] 
    FROM [Sales].[Customer]
    WHERE ([Sales].[Customer].[TerritoryID] = @SalesTerritoryTerritoryID)

RETURN
GO

CREATE PROCEDURE [dbo].[DatabaseLog_Load]
(
 @DatabaseLogID [int]
)
AS
SET NOCOUNT ON
SELECT [DatabaseLog].[DatabaseLogID], [DatabaseLog].[PostTime], [DatabaseLog].[DatabaseUser], [DatabaseLog].[Event], [DatabaseLog].[Schema], [DatabaseLog].[Object], [DatabaseLog].[TSQL], [DatabaseLog].[XmlEvent] 
    FROM [DatabaseLog]
    WHERE ([DatabaseLog].[DatabaseLogID] = @DatabaseLogID)

RETURN
GO

CREATE PROCEDURE [dbo].[DatabaseLog_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [DatabaseLog].[DatabaseLogID], [DatabaseLog].[PostTime], [DatabaseLog].[DatabaseUser], [DatabaseLog].[Event], [DatabaseLog].[Schema], [DatabaseLog].[Object], [DatabaseLog].[TSQL], [DatabaseLog].[XmlEvent] 
    FROM [DatabaseLog]

RETURN
GO

CREATE PROCEDURE [HumanResources].[Department_Load]
(
 @DepartmentID [smallint]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[Department].[DepartmentID], [HumanResources].[Department].[Name], [HumanResources].[Department].[GroupName], [HumanResources].[Department].[ModifiedDate] 
    FROM [HumanResources].[Department]
    WHERE ([HumanResources].[Department].[DepartmentID] = @DepartmentID)

RETURN
GO

CREATE PROCEDURE [HumanResources].[Department_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[Department].[DepartmentID], [HumanResources].[Department].[Name], [HumanResources].[Department].[GroupName], [HumanResources].[Department].[ModifiedDate] 
    FROM [HumanResources].[Department]

RETURN
GO

CREATE PROCEDURE [Production].[Document_Load]
(
 @Title [nvarchar] (256)
)
AS
SET NOCOUNT ON
SELECT [Production].[Document].[DocumentNode], [Production].[Document].[DocumentLevel], [Production].[Document].[Title], [Production].[Document].[Owner], [Production].[Document].[FolderFlag], [Production].[Document].[FileName], [Production].[Document].[FileExtension], [Production].[Document].[Revision], [Production].[Document].[ChangeNumber], [Production].[Document].[Status], [Production].[Document].[DocumentSummary], [Production].[Document].[Document], [Production].[Document].[rowguid], [Production].[Document].[ModifiedDate] 
    FROM [Production].[Document]
    WHERE ([Production].[Document].[Title] = @Title)

RETURN
GO

CREATE PROCEDURE [Production].[Document_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Production].[Document].[DocumentNode], [Production].[Document].[DocumentLevel], [Production].[Document].[Title], [Production].[Document].[Owner], [Production].[Document].[FolderFlag], [Production].[Document].[FileName], [Production].[Document].[FileExtension], [Production].[Document].[Revision], [Production].[Document].[ChangeNumber], [Production].[Document].[Status], [Production].[Document].[DocumentSummary], [Production].[Document].[Document], [Production].[Document].[rowguid], [Production].[Document].[ModifiedDate] 
    FROM [Production].[Document]

RETURN
GO

CREATE PROCEDURE [Person].[EmailAddress_Load]
(
 @BusinessEntityID [int],
 @EmailAddressID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[EmailAddress].[BusinessEntityID], [Person].[EmailAddress].[EmailAddressID], [Person].[EmailAddress].[EmailAddress], [Person].[EmailAddress].[rowguid], [Person].[EmailAddress].[ModifiedDate] 
    FROM [Person].[EmailAddress]
    WHERE (([Person].[EmailAddress].[BusinessEntityID] = @BusinessEntityID) AND ([Person].[EmailAddress].[EmailAddressID] = @EmailAddressID))

RETURN
GO

CREATE PROCEDURE [Person].[EmailAddress_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[EmailAddress].[BusinessEntityID], [Person].[EmailAddress].[EmailAddressID], [Person].[EmailAddress].[EmailAddress], [Person].[EmailAddress].[rowguid], [Person].[EmailAddress].[ModifiedDate] 
    FROM [Person].[EmailAddress]

RETURN
GO

CREATE PROCEDURE [HumanResources].[Employee_Load]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[Employee].[BusinessEntityID], [HumanResources].[Employee].[NationalIDNumber], [HumanResources].[Employee].[LoginID], [HumanResources].[Employee].[OrganizationNode], [HumanResources].[Employee].[OrganizationLevel], [HumanResources].[Employee].[JobTitle], [HumanResources].[Employee].[BirthDate], [HumanResources].[Employee].[MaritalStatus], [HumanResources].[Employee].[Gender], [HumanResources].[Employee].[HireDate], [HumanResources].[Employee].[SalariedFlag], [HumanResources].[Employee].[VacationHours], [HumanResources].[Employee].[SickLeaveHours], [HumanResources].[Employee].[CurrentFlag], [HumanResources].[Employee].[rowguid], [HumanResources].[Employee].[ModifiedDate] 
    FROM [HumanResources].[Employee]
    WHERE ([HumanResources].[Employee].[BusinessEntityID] = @BusinessEntityID)

RETURN
GO

CREATE PROCEDURE [HumanResources].[Employee_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[Employee].[BusinessEntityID], [HumanResources].[Employee].[NationalIDNumber], [HumanResources].[Employee].[LoginID], [HumanResources].[Employee].[OrganizationNode], [HumanResources].[Employee].[OrganizationLevel], [HumanResources].[Employee].[JobTitle], [HumanResources].[Employee].[BirthDate], [HumanResources].[Employee].[MaritalStatus], [HumanResources].[Employee].[Gender], [HumanResources].[Employee].[HireDate], [HumanResources].[Employee].[SalariedFlag], [HumanResources].[Employee].[VacationHours], [HumanResources].[Employee].[SickLeaveHours], [HumanResources].[Employee].[CurrentFlag], [HumanResources].[Employee].[rowguid], [HumanResources].[Employee].[ModifiedDate] 
    FROM [HumanResources].[Employee]

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeeDepartmentHistory_Load]
(
 @BusinessEntityID [int],
 @DepartmentDepartmentID [smallint],
 @ShiftShiftID [tinyint]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[EmployeeDepartmentHistory].[BusinessEntityID], [HumanResources].[EmployeeDepartmentHistory].[StartDate], [HumanResources].[EmployeeDepartmentHistory].[EndDate], [HumanResources].[EmployeeDepartmentHistory].[ModifiedDate], [HumanResources].[EmployeeDepartmentHistory].[DepartmentID], [HumanResources].[EmployeeDepartmentHistory].[ShiftID] 
    FROM [HumanResources].[EmployeeDepartmentHistory]
    WHERE (([HumanResources].[EmployeeDepartmentHistory].[BusinessEntityID] = @BusinessEntityID) AND (([HumanResources].[EmployeeDepartmentHistory].[DepartmentID] = @DepartmentDepartmentID) AND ([HumanResources].[EmployeeDepartmentHistory].[ShiftID] = @ShiftShiftID)))

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeeDepartmentHistory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[EmployeeDepartmentHistory].[BusinessEntityID], [HumanResources].[EmployeeDepartmentHistory].[StartDate], [HumanResources].[EmployeeDepartmentHistory].[EndDate], [HumanResources].[EmployeeDepartmentHistory].[ModifiedDate], [HumanResources].[EmployeeDepartmentHistory].[DepartmentID], [HumanResources].[EmployeeDepartmentHistory].[ShiftID] 
    FROM [HumanResources].[EmployeeDepartmentHistory]

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeeDepartmentHistory_LoadByDepartment]
(
 @DepartmentDepartmentID [smallint],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[EmployeeDepartmentHistory].[BusinessEntityID], [HumanResources].[EmployeeDepartmentHistory].[StartDate], [HumanResources].[EmployeeDepartmentHistory].[EndDate], [HumanResources].[EmployeeDepartmentHistory].[ModifiedDate], [HumanResources].[EmployeeDepartmentHistory].[DepartmentID], [HumanResources].[EmployeeDepartmentHistory].[ShiftID] 
    FROM [HumanResources].[EmployeeDepartmentHistory]
    WHERE ([HumanResources].[EmployeeDepartmentHistory].[DepartmentID] = @DepartmentDepartmentID)

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeeDepartmentHistory_LoadByShift]
(
 @ShiftShiftID [tinyint],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[EmployeeDepartmentHistory].[BusinessEntityID], [HumanResources].[EmployeeDepartmentHistory].[StartDate], [HumanResources].[EmployeeDepartmentHistory].[EndDate], [HumanResources].[EmployeeDepartmentHistory].[ModifiedDate], [HumanResources].[EmployeeDepartmentHistory].[DepartmentID], [HumanResources].[EmployeeDepartmentHistory].[ShiftID] 
    FROM [HumanResources].[EmployeeDepartmentHistory]
    WHERE ([HumanResources].[EmployeeDepartmentHistory].[ShiftID] = @ShiftShiftID)

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeePayHistory_Load]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[EmployeePayHistory].[BusinessEntityID], [HumanResources].[EmployeePayHistory].[RateChangeDate], [HumanResources].[EmployeePayHistory].[Rate], [HumanResources].[EmployeePayHistory].[PayFrequency], [HumanResources].[EmployeePayHistory].[ModifiedDate] 
    FROM [HumanResources].[EmployeePayHistory]
    WHERE ([HumanResources].[EmployeePayHistory].[BusinessEntityID] = @BusinessEntityID)

RETURN
GO

CREATE PROCEDURE [HumanResources].[EmployeePayHistory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[EmployeePayHistory].[BusinessEntityID], [HumanResources].[EmployeePayHistory].[RateChangeDate], [HumanResources].[EmployeePayHistory].[Rate], [HumanResources].[EmployeePayHistory].[PayFrequency], [HumanResources].[EmployeePayHistory].[ModifiedDate] 
    FROM [HumanResources].[EmployeePayHistory]

RETURN
GO

CREATE PROCEDURE [dbo].[ErrorLog_Load]
(
 @ErrorLogID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [ErrorLog].[ErrorLogID], [ErrorLog].[ErrorTime], [ErrorLog].[UserName], [ErrorLog].[ErrorNumber], [ErrorLog].[ErrorSeverity], [ErrorLog].[ErrorState], [ErrorLog].[ErrorProcedure], [ErrorLog].[ErrorLine], [ErrorLog].[ErrorMessage] 
    FROM [ErrorLog]
    WHERE ([ErrorLog].[ErrorLogID] = @ErrorLogID)

RETURN
GO

CREATE PROCEDURE [dbo].[ErrorLog_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [ErrorLog].[ErrorLogID], [ErrorLog].[ErrorTime], [ErrorLog].[UserName], [ErrorLog].[ErrorNumber], [ErrorLog].[ErrorSeverity], [ErrorLog].[ErrorState], [ErrorLog].[ErrorProcedure], [ErrorLog].[ErrorLine], [ErrorLog].[ErrorMessage] 
    FROM [ErrorLog]

RETURN
GO

CREATE PROCEDURE [Production].[Illustration_Load]
(
 @IllustrationID [int]
)
AS
SET NOCOUNT ON
SELECT [Production].[Illustration].[IllustrationID], [Production].[Illustration].[Diagram], [Production].[Illustration].[ModifiedDate] 
    FROM [Production].[Illustration]
    WHERE ([Production].[Illustration].[IllustrationID] = @IllustrationID)

RETURN
GO

CREATE PROCEDURE [Production].[Illustration_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Production].[Illustration].[IllustrationID], [Production].[Illustration].[Diagram], [Production].[Illustration].[ModifiedDate] 
    FROM [Production].[Illustration]

RETURN
GO

CREATE PROCEDURE [HumanResources].[JobCandidate_Load]
(
 @JobCandidateID [int]
)
AS
SET NOCOUNT ON
SELECT [HumanResources].[JobCandidate].[JobCandidateID], [HumanResources].[JobCandidate].[BusinessEntityID], [HumanResources].[JobCandidate].[Resume], [HumanResources].[JobCandidate].[ModifiedDate] 
    FROM [HumanResources].[JobCandidate]
    WHERE ([HumanResources].[JobCandidate].[JobCandidateID] = @JobCandidateID)

RETURN
GO

CREATE PROCEDURE [HumanResources].[JobCandidate_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [HumanResources].[JobCandidate].[JobCandidateID], [HumanResources].[JobCandidate].[BusinessEntityID], [HumanResources].[JobCandidate].[Resume], [HumanResources].[JobCandidate].[ModifiedDate] 
    FROM [HumanResources].[JobCandidate]

RETURN
GO

CREATE PROCEDURE [Production].[Location_Load]
(
 @LocationID [smallint]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Location].[LocationID], [Production].[Location].[Name], [Production].[Location].[CostRate], [Production].[Location].[Availability], [Production].[Location].[ModifiedDate] 
    FROM [Production].[Location]
    WHERE ([Production].[Location].[LocationID] = @LocationID)

RETURN
GO

CREATE PROCEDURE [Production].[Location_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Location].[LocationID], [Production].[Location].[Name], [Production].[Location].[CostRate], [Production].[Location].[Availability], [Production].[Location].[ModifiedDate] 
    FROM [Production].[Location]

RETURN
GO

CREATE PROCEDURE [Person].[Password_Load]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[Password].[BusinessEntityID], [Person].[Password].[PasswordHash], [Person].[Password].[PasswordSalt], [Person].[Password].[rowguid], [Person].[Password].[ModifiedDate] 
    FROM [Person].[Password]
    WHERE ([Person].[Password].[BusinessEntityID] = @BusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Person].[Password_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[Password].[BusinessEntityID], [Person].[Password].[PasswordHash], [Person].[Password].[PasswordSalt], [Person].[Password].[rowguid], [Person].[Password].[ModifiedDate] 
    FROM [Person].[Password]

RETURN
GO

CREATE PROCEDURE [Person].[Person_Load]
(
 @BusinessEntityBusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT [Person].[Person].[PersonType], [Person].[Person].[NameStyle], [Person].[Person].[Title], [Person].[Person].[FirstName], [Person].[Person].[MiddleName], [Person].[Person].[LastName], [Person].[Person].[Suffix], [Person].[Person].[EmailPromotion], [Person].[Person].[AdditionalContactInfo], [Person].[Person].[Demographics], [Person].[Person].[rowguid], [Person].[Person].[ModifiedDate], [Person].[Person].[BusinessEntityID] 
    FROM [Person].[Person]
    WHERE ([Person].[Person].[BusinessEntityID] = @BusinessEntityBusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Person].[Person_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Person].[Person].[PersonType], [Person].[Person].[NameStyle], [Person].[Person].[Title], [Person].[Person].[FirstName], [Person].[Person].[MiddleName], [Person].[Person].[LastName], [Person].[Person].[Suffix], [Person].[Person].[EmailPromotion], [Person].[Person].[AdditionalContactInfo], [Person].[Person].[Demographics], [Person].[Person].[rowguid], [Person].[Person].[ModifiedDate], [Person].[Person].[BusinessEntityID] 
    FROM [Person].[Person]

RETURN
GO

CREATE PROCEDURE [Person].[Person_LoadByBusinessEntity]
(
 @BusinessEntityBusinessEntityID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Person].[Person].[PersonType], [Person].[Person].[NameStyle], [Person].[Person].[Title], [Person].[Person].[FirstName], [Person].[Person].[MiddleName], [Person].[Person].[LastName], [Person].[Person].[Suffix], [Person].[Person].[EmailPromotion], [Person].[Person].[AdditionalContactInfo], [Person].[Person].[Demographics], [Person].[Person].[rowguid], [Person].[Person].[ModifiedDate], [Person].[Person].[BusinessEntityID] 
    FROM [Person].[Person]
    WHERE ([Person].[Person].[BusinessEntityID] = @BusinessEntityBusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Sales].[PersonCreditCard_Load]
(
 @BusinessEntityID [int],
 @CreditCardCreditCardID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[PersonCreditCard].[BusinessEntityID], [Sales].[PersonCreditCard].[ModifiedDate], [Sales].[PersonCreditCard].[CreditCardID] 
    FROM [Sales].[PersonCreditCard]
    WHERE (([Sales].[PersonCreditCard].[BusinessEntityID] = @BusinessEntityID) AND ([Sales].[PersonCreditCard].[CreditCardID] = @CreditCardCreditCardID))

RETURN
GO

CREATE PROCEDURE [Sales].[PersonCreditCard_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[PersonCreditCard].[BusinessEntityID], [Sales].[PersonCreditCard].[ModifiedDate], [Sales].[PersonCreditCard].[CreditCardID] 
    FROM [Sales].[PersonCreditCard]

RETURN
GO

CREATE PROCEDURE [Sales].[PersonCreditCard_LoadByCreditCard]
(
 @CreditCardCreditCardID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[PersonCreditCard].[BusinessEntityID], [Sales].[PersonCreditCard].[ModifiedDate], [Sales].[PersonCreditCard].[CreditCardID] 
    FROM [Sales].[PersonCreditCard]
    WHERE ([Sales].[PersonCreditCard].[CreditCardID] = @CreditCardCreditCardID)

RETURN
GO

CREATE PROCEDURE [Person].[PersonPhone_Load]
(
 @BusinessEntityID [int],
 @PhoneNumber [nvarchar] (256),
 @PhoneNumberTypePhoneNumberTypeID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[PersonPhone].[BusinessEntityID], [Person].[PersonPhone].[PhoneNumber], [Person].[PersonPhone].[ModifiedDate], [Person].[PersonPhone].[PhoneNumberTypeID] 
    FROM [Person].[PersonPhone]
    WHERE (([Person].[PersonPhone].[BusinessEntityID] = @BusinessEntityID) AND (([Person].[PersonPhone].[PhoneNumber] = @PhoneNumber) AND ([Person].[PersonPhone].[PhoneNumberTypeID] = @PhoneNumberTypePhoneNumberTypeID)))

RETURN
GO

CREATE PROCEDURE [Person].[PersonPhone_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[PersonPhone].[BusinessEntityID], [Person].[PersonPhone].[PhoneNumber], [Person].[PersonPhone].[ModifiedDate], [Person].[PersonPhone].[PhoneNumberTypeID] 
    FROM [Person].[PersonPhone]

RETURN
GO

CREATE PROCEDURE [Person].[PersonPhone_LoadByPhoneNumberType]
(
 @PhoneNumberTypePhoneNumberTypeID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[PersonPhone].[BusinessEntityID], [Person].[PersonPhone].[PhoneNumber], [Person].[PersonPhone].[ModifiedDate], [Person].[PersonPhone].[PhoneNumberTypeID] 
    FROM [Person].[PersonPhone]
    WHERE ([Person].[PersonPhone].[PhoneNumberTypeID] = @PhoneNumberTypePhoneNumberTypeID)

RETURN
GO

CREATE PROCEDURE [Person].[PhoneNumberType_Load]
(
 @PhoneNumberTypeID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[PhoneNumberType].[PhoneNumberTypeID], [Person].[PhoneNumberType].[Name], [Person].[PhoneNumberType].[ModifiedDate] 
    FROM [Person].[PhoneNumberType]
    WHERE ([Person].[PhoneNumberType].[PhoneNumberTypeID] = @PhoneNumberTypeID)

RETURN
GO

CREATE PROCEDURE [Person].[PhoneNumberType_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[PhoneNumberType].[PhoneNumberTypeID], [Person].[PhoneNumberType].[Name], [Person].[PhoneNumberType].[ModifiedDate] 
    FROM [Person].[PhoneNumberType]

RETURN
GO

CREATE PROCEDURE [Production].[Product_Load]
(
 @ProductID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Product].[ProductID], [Production].[Product].[Name], [Production].[Product].[ProductNumber], [Production].[Product].[MakeFlag], [Production].[Product].[FinishedGoodsFlag], [Production].[Product].[Color], [Production].[Product].[SafetyStockLevel], [Production].[Product].[ReorderPoint], [Production].[Product].[StandardCost], [Production].[Product].[ListPrice], [Production].[Product].[Size], [Production].[Product].[Weight], [Production].[Product].[DaysToManufacture], [Production].[Product].[ProductLine], [Production].[Product].[Class], [Production].[Product].[Style], [Production].[Product].[SellStartDate], [Production].[Product].[SellEndDate], [Production].[Product].[DiscontinuedDate], [Production].[Product].[rowguid], [Production].[Product].[ModifiedDate], [Production].[Product].[ProductModelID], [Production].[Product].[SizeUnitMeasureCode], [Production].[Product].[WeightUnitMeasureCode], [Production].[Product].[ProductSubcategoryID] 
    FROM [Production].[Product]
    WHERE ([Production].[Product].[ProductID] = @ProductID)

RETURN
GO

CREATE PROCEDURE [Production].[Product_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Product].[ProductID], [Production].[Product].[Name], [Production].[Product].[ProductNumber], [Production].[Product].[MakeFlag], [Production].[Product].[FinishedGoodsFlag], [Production].[Product].[Color], [Production].[Product].[SafetyStockLevel], [Production].[Product].[ReorderPoint], [Production].[Product].[StandardCost], [Production].[Product].[ListPrice], [Production].[Product].[Size], [Production].[Product].[Weight], [Production].[Product].[DaysToManufacture], [Production].[Product].[ProductLine], [Production].[Product].[Class], [Production].[Product].[Style], [Production].[Product].[SellStartDate], [Production].[Product].[SellEndDate], [Production].[Product].[DiscontinuedDate], [Production].[Product].[rowguid], [Production].[Product].[ModifiedDate], [Production].[Product].[ProductModelID], [Production].[Product].[SizeUnitMeasureCode], [Production].[Product].[WeightUnitMeasureCode], [Production].[Product].[ProductSubcategoryID] 
    FROM [Production].[Product]

RETURN
GO

CREATE PROCEDURE [Production].[Product_LoadByProductModel]
(
 @ProductModelProductModelID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Product].[ProductID], [Production].[Product].[Name], [Production].[Product].[ProductNumber], [Production].[Product].[MakeFlag], [Production].[Product].[FinishedGoodsFlag], [Production].[Product].[Color], [Production].[Product].[SafetyStockLevel], [Production].[Product].[ReorderPoint], [Production].[Product].[StandardCost], [Production].[Product].[ListPrice], [Production].[Product].[Size], [Production].[Product].[Weight], [Production].[Product].[DaysToManufacture], [Production].[Product].[ProductLine], [Production].[Product].[Class], [Production].[Product].[Style], [Production].[Product].[SellStartDate], [Production].[Product].[SellEndDate], [Production].[Product].[DiscontinuedDate], [Production].[Product].[rowguid], [Production].[Product].[ModifiedDate], [Production].[Product].[ProductModelID], [Production].[Product].[SizeUnitMeasureCode], [Production].[Product].[WeightUnitMeasureCode], [Production].[Product].[ProductSubcategoryID] 
    FROM [Production].[Product]
    WHERE ([Production].[Product].[ProductModelID] = @ProductModelProductModelID)

RETURN
GO

CREATE PROCEDURE [Production].[Product_LoadByProductSubcategory]
(
 @ProductSubcategoryProductSubcategoryID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Product].[ProductID], [Production].[Product].[Name], [Production].[Product].[ProductNumber], [Production].[Product].[MakeFlag], [Production].[Product].[FinishedGoodsFlag], [Production].[Product].[Color], [Production].[Product].[SafetyStockLevel], [Production].[Product].[ReorderPoint], [Production].[Product].[StandardCost], [Production].[Product].[ListPrice], [Production].[Product].[Size], [Production].[Product].[Weight], [Production].[Product].[DaysToManufacture], [Production].[Product].[ProductLine], [Production].[Product].[Class], [Production].[Product].[Style], [Production].[Product].[SellStartDate], [Production].[Product].[SellEndDate], [Production].[Product].[DiscontinuedDate], [Production].[Product].[rowguid], [Production].[Product].[ModifiedDate], [Production].[Product].[ProductModelID], [Production].[Product].[SizeUnitMeasureCode], [Production].[Product].[WeightUnitMeasureCode], [Production].[Product].[ProductSubcategoryID] 
    FROM [Production].[Product]
    WHERE ([Production].[Product].[ProductSubcategoryID] = @ProductSubcategoryProductSubcategoryID)

RETURN
GO

CREATE PROCEDURE [Production].[Product_LoadBySizeUnitMeasureCode]
(
 @SizeUnitMeasureCodeUnitMeasureCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Product].[ProductID], [Production].[Product].[Name], [Production].[Product].[ProductNumber], [Production].[Product].[MakeFlag], [Production].[Product].[FinishedGoodsFlag], [Production].[Product].[Color], [Production].[Product].[SafetyStockLevel], [Production].[Product].[ReorderPoint], [Production].[Product].[StandardCost], [Production].[Product].[ListPrice], [Production].[Product].[Size], [Production].[Product].[Weight], [Production].[Product].[DaysToManufacture], [Production].[Product].[ProductLine], [Production].[Product].[Class], [Production].[Product].[Style], [Production].[Product].[SellStartDate], [Production].[Product].[SellEndDate], [Production].[Product].[DiscontinuedDate], [Production].[Product].[rowguid], [Production].[Product].[ModifiedDate], [Production].[Product].[ProductModelID], [Production].[Product].[SizeUnitMeasureCode], [Production].[Product].[WeightUnitMeasureCode], [Production].[Product].[ProductSubcategoryID] 
    FROM [Production].[Product]
    WHERE ([Production].[Product].[SizeUnitMeasureCode] = @SizeUnitMeasureCodeUnitMeasureCode)

RETURN
GO

CREATE PROCEDURE [Production].[Product_LoadByWeightUnitMeasureCode]
(
 @WeightUnitMeasureCodeUnitMeasureCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[Product].[ProductID], [Production].[Product].[Name], [Production].[Product].[ProductNumber], [Production].[Product].[MakeFlag], [Production].[Product].[FinishedGoodsFlag], [Production].[Product].[Color], [Production].[Product].[SafetyStockLevel], [Production].[Product].[ReorderPoint], [Production].[Product].[StandardCost], [Production].[Product].[ListPrice], [Production].[Product].[Size], [Production].[Product].[Weight], [Production].[Product].[DaysToManufacture], [Production].[Product].[ProductLine], [Production].[Product].[Class], [Production].[Product].[Style], [Production].[Product].[SellStartDate], [Production].[Product].[SellEndDate], [Production].[Product].[DiscontinuedDate], [Production].[Product].[rowguid], [Production].[Product].[ModifiedDate], [Production].[Product].[ProductModelID], [Production].[Product].[SizeUnitMeasureCode], [Production].[Product].[WeightUnitMeasureCode], [Production].[Product].[ProductSubcategoryID] 
    FROM [Production].[Product]
    WHERE ([Production].[Product].[WeightUnitMeasureCode] = @WeightUnitMeasureCodeUnitMeasureCode)

RETURN
GO

CREATE PROCEDURE [Production].[ProductCategory_Load]
(
 @ProductCategoryID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductCategory].[ProductCategoryID], [Production].[ProductCategory].[Name], [Production].[ProductCategory].[rowguid], [Production].[ProductCategory].[ModifiedDate] 
    FROM [Production].[ProductCategory]
    WHERE ([Production].[ProductCategory].[ProductCategoryID] = @ProductCategoryID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductCategory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductCategory].[ProductCategoryID], [Production].[ProductCategory].[Name], [Production].[ProductCategory].[rowguid], [Production].[ProductCategory].[ModifiedDate] 
    FROM [Production].[ProductCategory]

RETURN
GO

CREATE PROCEDURE [Production].[ProductCostHistory_Load]
(
 @ProductID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductCostHistory].[ProductID], [Production].[ProductCostHistory].[StartDate], [Production].[ProductCostHistory].[EndDate], [Production].[ProductCostHistory].[StandardCost], [Production].[ProductCostHistory].[ModifiedDate] 
    FROM [Production].[ProductCostHistory]
    WHERE ([Production].[ProductCostHistory].[ProductID] = @ProductID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductCostHistory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductCostHistory].[ProductID], [Production].[ProductCostHistory].[StartDate], [Production].[ProductCostHistory].[EndDate], [Production].[ProductCostHistory].[StandardCost], [Production].[ProductCostHistory].[ModifiedDate] 
    FROM [Production].[ProductCostHistory]

RETURN
GO

CREATE PROCEDURE [Production].[ProductDescription_Load]
(
 @ProductDescriptionID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductDescription].[ProductDescriptionID], [Production].[ProductDescription].[Description], [Production].[ProductDescription].[rowguid], [Production].[ProductDescription].[ModifiedDate] 
    FROM [Production].[ProductDescription]
    WHERE ([Production].[ProductDescription].[ProductDescriptionID] = @ProductDescriptionID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductDescription_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductDescription].[ProductDescriptionID], [Production].[ProductDescription].[Description], [Production].[ProductDescription].[rowguid], [Production].[ProductDescription].[ModifiedDate] 
    FROM [Production].[ProductDescription]

RETURN
GO

CREATE PROCEDURE [Production].[ProductDocument_Load]
(
 @ProductID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductDocument].[ProductID], [Production].[ProductDocument].[DocumentNode], [Production].[ProductDocument].[ModifiedDate] 
    FROM [Production].[ProductDocument]
    WHERE ([Production].[ProductDocument].[ProductID] = @ProductID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductDocument_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductDocument].[ProductID], [Production].[ProductDocument].[DocumentNode], [Production].[ProductDocument].[ModifiedDate] 
    FROM [Production].[ProductDocument]

RETURN
GO

CREATE PROCEDURE [Production].[ProductInventory_Load]
(
 @ProductID [int],
 @LocationLocationID [smallint]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductInventory].[ProductID], [Production].[ProductInventory].[Shelf], [Production].[ProductInventory].[Bin], [Production].[ProductInventory].[Quantity], [Production].[ProductInventory].[rowguid], [Production].[ProductInventory].[ModifiedDate], [Production].[ProductInventory].[LocationID] 
    FROM [Production].[ProductInventory]
    WHERE (([Production].[ProductInventory].[ProductID] = @ProductID) AND ([Production].[ProductInventory].[LocationID] = @LocationLocationID))

RETURN
GO

CREATE PROCEDURE [Production].[ProductInventory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductInventory].[ProductID], [Production].[ProductInventory].[Shelf], [Production].[ProductInventory].[Bin], [Production].[ProductInventory].[Quantity], [Production].[ProductInventory].[rowguid], [Production].[ProductInventory].[ModifiedDate], [Production].[ProductInventory].[LocationID] 
    FROM [Production].[ProductInventory]

RETURN
GO

CREATE PROCEDURE [Production].[ProductInventory_LoadByLocation]
(
 @LocationLocationID [smallint],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductInventory].[ProductID], [Production].[ProductInventory].[Shelf], [Production].[ProductInventory].[Bin], [Production].[ProductInventory].[Quantity], [Production].[ProductInventory].[rowguid], [Production].[ProductInventory].[ModifiedDate], [Production].[ProductInventory].[LocationID] 
    FROM [Production].[ProductInventory]
    WHERE ([Production].[ProductInventory].[LocationID] = @LocationLocationID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductListPriceHistory_Load]
(
 @ProductID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductListPriceHistory].[ProductID], [Production].[ProductListPriceHistory].[StartDate], [Production].[ProductListPriceHistory].[EndDate], [Production].[ProductListPriceHistory].[ListPrice], [Production].[ProductListPriceHistory].[ModifiedDate] 
    FROM [Production].[ProductListPriceHistory]
    WHERE ([Production].[ProductListPriceHistory].[ProductID] = @ProductID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductListPriceHistory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductListPriceHistory].[ProductID], [Production].[ProductListPriceHistory].[StartDate], [Production].[ProductListPriceHistory].[EndDate], [Production].[ProductListPriceHistory].[ListPrice], [Production].[ProductListPriceHistory].[ModifiedDate] 
    FROM [Production].[ProductListPriceHistory]

RETURN
GO

CREATE PROCEDURE [Production].[ProductModel_Load]
(
 @ProductModelID [int]
)
AS
SET NOCOUNT ON
SELECT [Production].[ProductModel].[ProductModelID], [Production].[ProductModel].[Name], [Production].[ProductModel].[CatalogDescription], [Production].[ProductModel].[Instructions], [Production].[ProductModel].[rowguid], [Production].[ProductModel].[ModifiedDate] 
    FROM [Production].[ProductModel]
    WHERE ([Production].[ProductModel].[ProductModelID] = @ProductModelID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductModel_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Production].[ProductModel].[ProductModelID], [Production].[ProductModel].[Name], [Production].[ProductModel].[CatalogDescription], [Production].[ProductModel].[Instructions], [Production].[ProductModel].[rowguid], [Production].[ProductModel].[ModifiedDate] 
    FROM [Production].[ProductModel]

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelIllustration_Load]
(
 @IllustrationIllustrationID [int],
 @ProductModelProductModelID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelIllustration].[ModifiedDate], [Production].[ProductModelIllustration].[IllustrationID], [Production].[ProductModelIllustration].[ProductModelID] 
    FROM [Production].[ProductModelIllustration]
    WHERE (([Production].[ProductModelIllustration].[IllustrationID] = @IllustrationIllustrationID) AND ([Production].[ProductModelIllustration].[ProductModelID] = @ProductModelProductModelID))

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelIllustration_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelIllustration].[ModifiedDate], [Production].[ProductModelIllustration].[IllustrationID], [Production].[ProductModelIllustration].[ProductModelID] 
    FROM [Production].[ProductModelIllustration]

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelIllustration_LoadByIllustration]
(
 @IllustrationIllustrationID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelIllustration].[ModifiedDate], [Production].[ProductModelIllustration].[IllustrationID], [Production].[ProductModelIllustration].[ProductModelID] 
    FROM [Production].[ProductModelIllustration]
    WHERE ([Production].[ProductModelIllustration].[IllustrationID] = @IllustrationIllustrationID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelIllustration_LoadByProductModel]
(
 @ProductModelProductModelID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelIllustration].[ModifiedDate], [Production].[ProductModelIllustration].[IllustrationID], [Production].[ProductModelIllustration].[ProductModelID] 
    FROM [Production].[ProductModelIllustration]
    WHERE ([Production].[ProductModelIllustration].[ProductModelID] = @ProductModelProductModelID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelProductDescriptionCulture_Load]
(
 @CultureCultureID [nvarchar] (6),
 @ProductDescriptionProductDescriptionID [int],
 @ProductModelProductModelID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelProductDescriptionCulture].[ModifiedDate], [Production].[ProductModelProductDescriptionCulture].[CultureID], [Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID], [Production].[ProductModelProductDescriptionCulture].[ProductModelID] 
    FROM [Production].[ProductModelProductDescriptionCulture]
    WHERE (([Production].[ProductModelProductDescriptionCulture].[CultureID] = @CultureCultureID) AND (([Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID] = @ProductDescriptionProductDescriptionID) AND ([Production].[ProductModelProductDescriptionCulture].[ProductModelID] = @ProductModelProductModelID)))

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelProductDescriptionCulture_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelProductDescriptionCulture].[ModifiedDate], [Production].[ProductModelProductDescriptionCulture].[CultureID], [Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID], [Production].[ProductModelProductDescriptionCulture].[ProductModelID] 
    FROM [Production].[ProductModelProductDescriptionCulture]

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelProductDescriptionCulture_LoadByCulture]
(
 @CultureCultureID [nvarchar] (6),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelProductDescriptionCulture].[ModifiedDate], [Production].[ProductModelProductDescriptionCulture].[CultureID], [Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID], [Production].[ProductModelProductDescriptionCulture].[ProductModelID] 
    FROM [Production].[ProductModelProductDescriptionCulture]
    WHERE ([Production].[ProductModelProductDescriptionCulture].[CultureID] = @CultureCultureID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelProductDescriptionCulture_LoadByProductDescription]
(
 @ProductDescriptionProductDescriptionID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelProductDescriptionCulture].[ModifiedDate], [Production].[ProductModelProductDescriptionCulture].[CultureID], [Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID], [Production].[ProductModelProductDescriptionCulture].[ProductModelID] 
    FROM [Production].[ProductModelProductDescriptionCulture]
    WHERE ([Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID] = @ProductDescriptionProductDescriptionID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductModelProductDescriptionCulture_LoadByProductModel]
(
 @ProductModelProductModelID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductModelProductDescriptionCulture].[ModifiedDate], [Production].[ProductModelProductDescriptionCulture].[CultureID], [Production].[ProductModelProductDescriptionCulture].[ProductDescriptionID], [Production].[ProductModelProductDescriptionCulture].[ProductModelID] 
    FROM [Production].[ProductModelProductDescriptionCulture]
    WHERE ([Production].[ProductModelProductDescriptionCulture].[ProductModelID] = @ProductModelProductModelID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductPhoto_Load]
(
 @ProductPhotoID [int]
)
AS
SET NOCOUNT ON
SELECT [Production].[ProductPhoto].[ProductPhotoID], [Production].[ProductPhoto].[ThumbNailPhoto], [Production].[ProductPhoto].[ThumbnailPhotoFileName], [Production].[ProductPhoto].[LargePhoto], [Production].[ProductPhoto].[LargePhotoFileName], [Production].[ProductPhoto].[ModifiedDate] 
    FROM [Production].[ProductPhoto]
    WHERE ([Production].[ProductPhoto].[ProductPhotoID] = @ProductPhotoID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductPhoto_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Production].[ProductPhoto].[ProductPhotoID], [Production].[ProductPhoto].[ThumbNailPhoto], [Production].[ProductPhoto].[ThumbnailPhotoFileName], [Production].[ProductPhoto].[LargePhoto], [Production].[ProductPhoto].[LargePhotoFileName], [Production].[ProductPhoto].[ModifiedDate] 
    FROM [Production].[ProductPhoto]

RETURN
GO

CREATE PROCEDURE [Production].[ProductProductPhoto_Load]
(
 @ProductID [int],
 @ProductPhotoProductPhotoID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductProductPhoto].[ProductID], [Production].[ProductProductPhoto].[Primary], [Production].[ProductProductPhoto].[ModifiedDate], [Production].[ProductProductPhoto].[ProductPhotoID] 
    FROM [Production].[ProductProductPhoto]
    WHERE (([Production].[ProductProductPhoto].[ProductID] = @ProductID) AND ([Production].[ProductProductPhoto].[ProductPhotoID] = @ProductPhotoProductPhotoID))

RETURN
GO

CREATE PROCEDURE [Production].[ProductProductPhoto_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductProductPhoto].[ProductID], [Production].[ProductProductPhoto].[Primary], [Production].[ProductProductPhoto].[ModifiedDate], [Production].[ProductProductPhoto].[ProductPhotoID] 
    FROM [Production].[ProductProductPhoto]

RETURN
GO

CREATE PROCEDURE [Production].[ProductProductPhoto_LoadByProductPhoto]
(
 @ProductPhotoProductPhotoID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductProductPhoto].[ProductID], [Production].[ProductProductPhoto].[Primary], [Production].[ProductProductPhoto].[ModifiedDate], [Production].[ProductProductPhoto].[ProductPhotoID] 
    FROM [Production].[ProductProductPhoto]
    WHERE ([Production].[ProductProductPhoto].[ProductPhotoID] = @ProductPhotoProductPhotoID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductReview_Load]
(
 @ProductReviewID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductReview].[ProductReviewID], [Production].[ProductReview].[ReviewerName], [Production].[ProductReview].[ReviewDate], [Production].[ProductReview].[EmailAddress], [Production].[ProductReview].[Rating], [Production].[ProductReview].[Comments], [Production].[ProductReview].[ModifiedDate], [Production].[ProductReview].[ProductID] 
    FROM [Production].[ProductReview]
    WHERE ([Production].[ProductReview].[ProductReviewID] = @ProductReviewID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductReview_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductReview].[ProductReviewID], [Production].[ProductReview].[ReviewerName], [Production].[ProductReview].[ReviewDate], [Production].[ProductReview].[EmailAddress], [Production].[ProductReview].[Rating], [Production].[ProductReview].[Comments], [Production].[ProductReview].[ModifiedDate], [Production].[ProductReview].[ProductID] 
    FROM [Production].[ProductReview]

RETURN
GO

CREATE PROCEDURE [Production].[ProductReview_LoadByProduct]
(
 @ProductProductID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductReview].[ProductReviewID], [Production].[ProductReview].[ReviewerName], [Production].[ProductReview].[ReviewDate], [Production].[ProductReview].[EmailAddress], [Production].[ProductReview].[Rating], [Production].[ProductReview].[Comments], [Production].[ProductReview].[ModifiedDate], [Production].[ProductReview].[ProductID] 
    FROM [Production].[ProductReview]
    WHERE ([Production].[ProductReview].[ProductID] = @ProductProductID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductSubcategory_Load]
(
 @ProductSubcategoryID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductSubcategory].[ProductSubcategoryID], [Production].[ProductSubcategory].[Name], [Production].[ProductSubcategory].[rowguid], [Production].[ProductSubcategory].[ModifiedDate], [Production].[ProductSubcategory].[ProductCategoryID] 
    FROM [Production].[ProductSubcategory]
    WHERE ([Production].[ProductSubcategory].[ProductSubcategoryID] = @ProductSubcategoryID)

RETURN
GO

CREATE PROCEDURE [Production].[ProductSubcategory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductSubcategory].[ProductSubcategoryID], [Production].[ProductSubcategory].[Name], [Production].[ProductSubcategory].[rowguid], [Production].[ProductSubcategory].[ModifiedDate], [Production].[ProductSubcategory].[ProductCategoryID] 
    FROM [Production].[ProductSubcategory]

RETURN
GO

CREATE PROCEDURE [Production].[ProductSubcategory_LoadByProductCategory]
(
 @ProductCategoryProductCategoryID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ProductSubcategory].[ProductSubcategoryID], [Production].[ProductSubcategory].[Name], [Production].[ProductSubcategory].[rowguid], [Production].[ProductSubcategory].[ModifiedDate], [Production].[ProductSubcategory].[ProductCategoryID] 
    FROM [Production].[ProductSubcategory]
    WHERE ([Production].[ProductSubcategory].[ProductCategoryID] = @ProductCategoryProductCategoryID)

RETURN
GO

CREATE PROCEDURE [Purchasing].[ProductVendor_Load]
(
 @ProductID [int],
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[ProductVendor].[ProductID], [Purchasing].[ProductVendor].[BusinessEntityID], [Purchasing].[ProductVendor].[AverageLeadTime], [Purchasing].[ProductVendor].[StandardPrice], [Purchasing].[ProductVendor].[LastReceiptCost], [Purchasing].[ProductVendor].[LastReceiptDate], [Purchasing].[ProductVendor].[MinOrderQty], [Purchasing].[ProductVendor].[MaxOrderQty], [Purchasing].[ProductVendor].[OnOrderQty], [Purchasing].[ProductVendor].[ModifiedDate], [Purchasing].[ProductVendor].[UnitMeasureCode] 
    FROM [Purchasing].[ProductVendor]
    WHERE (([Purchasing].[ProductVendor].[ProductID] = @ProductID) AND ([Purchasing].[ProductVendor].[BusinessEntityID] = @BusinessEntityID))

RETURN
GO

CREATE PROCEDURE [Purchasing].[ProductVendor_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[ProductVendor].[ProductID], [Purchasing].[ProductVendor].[BusinessEntityID], [Purchasing].[ProductVendor].[AverageLeadTime], [Purchasing].[ProductVendor].[StandardPrice], [Purchasing].[ProductVendor].[LastReceiptCost], [Purchasing].[ProductVendor].[LastReceiptDate], [Purchasing].[ProductVendor].[MinOrderQty], [Purchasing].[ProductVendor].[MaxOrderQty], [Purchasing].[ProductVendor].[OnOrderQty], [Purchasing].[ProductVendor].[ModifiedDate], [Purchasing].[ProductVendor].[UnitMeasureCode] 
    FROM [Purchasing].[ProductVendor]

RETURN
GO

CREATE PROCEDURE [Purchasing].[ProductVendor_LoadByUnitMeasure]
(
 @UnitMeasureUnitMeasureCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[ProductVendor].[ProductID], [Purchasing].[ProductVendor].[BusinessEntityID], [Purchasing].[ProductVendor].[AverageLeadTime], [Purchasing].[ProductVendor].[StandardPrice], [Purchasing].[ProductVendor].[LastReceiptCost], [Purchasing].[ProductVendor].[LastReceiptDate], [Purchasing].[ProductVendor].[MinOrderQty], [Purchasing].[ProductVendor].[MaxOrderQty], [Purchasing].[ProductVendor].[OnOrderQty], [Purchasing].[ProductVendor].[ModifiedDate], [Purchasing].[ProductVendor].[UnitMeasureCode] 
    FROM [Purchasing].[ProductVendor]
    WHERE ([Purchasing].[ProductVendor].[UnitMeasureCode] = @UnitMeasureUnitMeasureCode)

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderDetail_Load]
(
 @PurchaseOrderID [int],
 @PurchaseOrderDetailID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[PurchaseOrderDetail].[PurchaseOrderID], [Purchasing].[PurchaseOrderDetail].[PurchaseOrderDetailID], [Purchasing].[PurchaseOrderDetail].[DueDate], [Purchasing].[PurchaseOrderDetail].[OrderQty], [Purchasing].[PurchaseOrderDetail].[UnitPrice], [Purchasing].[PurchaseOrderDetail].[LineTotal], [Purchasing].[PurchaseOrderDetail].[ReceivedQty], [Purchasing].[PurchaseOrderDetail].[RejectedQty], [Purchasing].[PurchaseOrderDetail].[StockedQty], [Purchasing].[PurchaseOrderDetail].[ModifiedDate], [Purchasing].[PurchaseOrderDetail].[ProductID] 
    FROM [Purchasing].[PurchaseOrderDetail]
    WHERE (([Purchasing].[PurchaseOrderDetail].[PurchaseOrderID] = @PurchaseOrderID) AND ([Purchasing].[PurchaseOrderDetail].[PurchaseOrderDetailID] = @PurchaseOrderDetailID))

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderDetail_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[PurchaseOrderDetail].[PurchaseOrderID], [Purchasing].[PurchaseOrderDetail].[PurchaseOrderDetailID], [Purchasing].[PurchaseOrderDetail].[DueDate], [Purchasing].[PurchaseOrderDetail].[OrderQty], [Purchasing].[PurchaseOrderDetail].[UnitPrice], [Purchasing].[PurchaseOrderDetail].[LineTotal], [Purchasing].[PurchaseOrderDetail].[ReceivedQty], [Purchasing].[PurchaseOrderDetail].[RejectedQty], [Purchasing].[PurchaseOrderDetail].[StockedQty], [Purchasing].[PurchaseOrderDetail].[ModifiedDate], [Purchasing].[PurchaseOrderDetail].[ProductID] 
    FROM [Purchasing].[PurchaseOrderDetail]

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderDetail_LoadByProduct]
(
 @ProductProductID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[PurchaseOrderDetail].[PurchaseOrderID], [Purchasing].[PurchaseOrderDetail].[PurchaseOrderDetailID], [Purchasing].[PurchaseOrderDetail].[DueDate], [Purchasing].[PurchaseOrderDetail].[OrderQty], [Purchasing].[PurchaseOrderDetail].[UnitPrice], [Purchasing].[PurchaseOrderDetail].[LineTotal], [Purchasing].[PurchaseOrderDetail].[ReceivedQty], [Purchasing].[PurchaseOrderDetail].[RejectedQty], [Purchasing].[PurchaseOrderDetail].[StockedQty], [Purchasing].[PurchaseOrderDetail].[ModifiedDate], [Purchasing].[PurchaseOrderDetail].[ProductID] 
    FROM [Purchasing].[PurchaseOrderDetail]
    WHERE ([Purchasing].[PurchaseOrderDetail].[ProductID] = @ProductProductID)

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderHeader_Load]
(
 @PurchaseOrderID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[PurchaseOrderHeader].[PurchaseOrderID], [Purchasing].[PurchaseOrderHeader].[RevisionNumber], [Purchasing].[PurchaseOrderHeader].[Status], [Purchasing].[PurchaseOrderHeader].[EmployeeID], [Purchasing].[PurchaseOrderHeader].[VendorID], [Purchasing].[PurchaseOrderHeader].[OrderDate], [Purchasing].[PurchaseOrderHeader].[ShipDate], [Purchasing].[PurchaseOrderHeader].[SubTotal], [Purchasing].[PurchaseOrderHeader].[TaxAmt], [Purchasing].[PurchaseOrderHeader].[Freight], [Purchasing].[PurchaseOrderHeader].[TotalDue], [Purchasing].[PurchaseOrderHeader].[ModifiedDate], [Purchasing].[PurchaseOrderHeader].[ShipMethodID] 
    FROM [Purchasing].[PurchaseOrderHeader]
    WHERE ([Purchasing].[PurchaseOrderHeader].[PurchaseOrderID] = @PurchaseOrderID)

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderHeader_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[PurchaseOrderHeader].[PurchaseOrderID], [Purchasing].[PurchaseOrderHeader].[RevisionNumber], [Purchasing].[PurchaseOrderHeader].[Status], [Purchasing].[PurchaseOrderHeader].[EmployeeID], [Purchasing].[PurchaseOrderHeader].[VendorID], [Purchasing].[PurchaseOrderHeader].[OrderDate], [Purchasing].[PurchaseOrderHeader].[ShipDate], [Purchasing].[PurchaseOrderHeader].[SubTotal], [Purchasing].[PurchaseOrderHeader].[TaxAmt], [Purchasing].[PurchaseOrderHeader].[Freight], [Purchasing].[PurchaseOrderHeader].[TotalDue], [Purchasing].[PurchaseOrderHeader].[ModifiedDate], [Purchasing].[PurchaseOrderHeader].[ShipMethodID] 
    FROM [Purchasing].[PurchaseOrderHeader]

RETURN
GO

CREATE PROCEDURE [Purchasing].[PurchaseOrderHeader_LoadByShipMethod]
(
 @ShipMethodShipMethodID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[PurchaseOrderHeader].[PurchaseOrderID], [Purchasing].[PurchaseOrderHeader].[RevisionNumber], [Purchasing].[PurchaseOrderHeader].[Status], [Purchasing].[PurchaseOrderHeader].[EmployeeID], [Purchasing].[PurchaseOrderHeader].[VendorID], [Purchasing].[PurchaseOrderHeader].[OrderDate], [Purchasing].[PurchaseOrderHeader].[ShipDate], [Purchasing].[PurchaseOrderHeader].[SubTotal], [Purchasing].[PurchaseOrderHeader].[TaxAmt], [Purchasing].[PurchaseOrderHeader].[Freight], [Purchasing].[PurchaseOrderHeader].[TotalDue], [Purchasing].[PurchaseOrderHeader].[ModifiedDate], [Purchasing].[PurchaseOrderHeader].[ShipMethodID] 
    FROM [Purchasing].[PurchaseOrderHeader]
    WHERE ([Purchasing].[PurchaseOrderHeader].[ShipMethodID] = @ShipMethodShipMethodID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderDetail_Load]
(
 @SalesOrderID [int],
 @SalesOrderDetailID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderDetail].[SalesOrderID], [Sales].[SalesOrderDetail].[SalesOrderDetailID], [Sales].[SalesOrderDetail].[CarrierTrackingNumber], [Sales].[SalesOrderDetail].[OrderQty], [Sales].[SalesOrderDetail].[UnitPrice], [Sales].[SalesOrderDetail].[UnitPriceDiscount], [Sales].[SalesOrderDetail].[LineTotal], [Sales].[SalesOrderDetail].[rowguid], [Sales].[SalesOrderDetail].[ModifiedDate], [Sales].[SalesOrderDetail].[ProductID], [Sales].[SalesOrderDetail].[SpecialOfferID] 
    FROM [Sales].[SalesOrderDetail]
    WHERE (([Sales].[SalesOrderDetail].[SalesOrderID] = @SalesOrderID) AND ([Sales].[SalesOrderDetail].[SalesOrderDetailID] = @SalesOrderDetailID))

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderDetail_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderDetail].[SalesOrderID], [Sales].[SalesOrderDetail].[SalesOrderDetailID], [Sales].[SalesOrderDetail].[CarrierTrackingNumber], [Sales].[SalesOrderDetail].[OrderQty], [Sales].[SalesOrderDetail].[UnitPrice], [Sales].[SalesOrderDetail].[UnitPriceDiscount], [Sales].[SalesOrderDetail].[LineTotal], [Sales].[SalesOrderDetail].[rowguid], [Sales].[SalesOrderDetail].[ModifiedDate], [Sales].[SalesOrderDetail].[ProductID], [Sales].[SalesOrderDetail].[SpecialOfferID] 
    FROM [Sales].[SalesOrderDetail]

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderDetail_LoadByProduct]
(
 @ProductProductID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderDetail].[SalesOrderID], [Sales].[SalesOrderDetail].[SalesOrderDetailID], [Sales].[SalesOrderDetail].[CarrierTrackingNumber], [Sales].[SalesOrderDetail].[OrderQty], [Sales].[SalesOrderDetail].[UnitPrice], [Sales].[SalesOrderDetail].[UnitPriceDiscount], [Sales].[SalesOrderDetail].[LineTotal], [Sales].[SalesOrderDetail].[rowguid], [Sales].[SalesOrderDetail].[ModifiedDate], [Sales].[SalesOrderDetail].[ProductID], [Sales].[SalesOrderDetail].[SpecialOfferID] 
    FROM [Sales].[SalesOrderDetail]
    WHERE ([Sales].[SalesOrderDetail].[ProductID] = @ProductProductID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderDetail_LoadBySpecialOffer]
(
 @SpecialOfferSpecialOfferID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderDetail].[SalesOrderID], [Sales].[SalesOrderDetail].[SalesOrderDetailID], [Sales].[SalesOrderDetail].[CarrierTrackingNumber], [Sales].[SalesOrderDetail].[OrderQty], [Sales].[SalesOrderDetail].[UnitPrice], [Sales].[SalesOrderDetail].[UnitPriceDiscount], [Sales].[SalesOrderDetail].[LineTotal], [Sales].[SalesOrderDetail].[rowguid], [Sales].[SalesOrderDetail].[ModifiedDate], [Sales].[SalesOrderDetail].[ProductID], [Sales].[SalesOrderDetail].[SpecialOfferID] 
    FROM [Sales].[SalesOrderDetail]
    WHERE ([Sales].[SalesOrderDetail].[SpecialOfferID] = @SpecialOfferSpecialOfferID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_Load]
(
 @SalesOrderID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeader].[SalesOrderID], [Sales].[SalesOrderHeader].[RevisionNumber], [Sales].[SalesOrderHeader].[OrderDate], [Sales].[SalesOrderHeader].[DueDate], [Sales].[SalesOrderHeader].[ShipDate], [Sales].[SalesOrderHeader].[Status], [Sales].[SalesOrderHeader].[OnlineOrderFlag], [Sales].[SalesOrderHeader].[SalesOrderNumber], [Sales].[SalesOrderHeader].[PurchaseOrderNumber], [Sales].[SalesOrderHeader].[AccountNumber], [Sales].[SalesOrderHeader].[SalesPersonID], [Sales].[SalesOrderHeader].[BillToAddressID], [Sales].[SalesOrderHeader].[ShipToAddressID], [Sales].[SalesOrderHeader].[CreditCardApprovalCode], [Sales].[SalesOrderHeader].[SubTotal], [Sales].[SalesOrderHeader].[TaxAmt], [Sales].[SalesOrderHeader].[Freight], [Sales].[SalesOrderHeader].[TotalDue], [Sales].[SalesOrderHeader].[Comment], [Sales].[SalesOrderHeader].[rowguid], [Sales].[SalesOrderHeader].[ModifiedDate], [Sales].[SalesOrderHeader].[CreditCardID], [Sales].[SalesOrderHeader].[ShipMethodID], [Sales].[SalesOrderHeader].[CustomerID], [Sales].[SalesOrderHeader].[TerritoryID], [Sales].[SalesOrderHeader].[CurrencyRateID] 
    FROM [Sales].[SalesOrderHeader]
    WHERE ([Sales].[SalesOrderHeader].[SalesOrderID] = @SalesOrderID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeader].[SalesOrderID], [Sales].[SalesOrderHeader].[RevisionNumber], [Sales].[SalesOrderHeader].[OrderDate], [Sales].[SalesOrderHeader].[DueDate], [Sales].[SalesOrderHeader].[ShipDate], [Sales].[SalesOrderHeader].[Status], [Sales].[SalesOrderHeader].[OnlineOrderFlag], [Sales].[SalesOrderHeader].[SalesOrderNumber], [Sales].[SalesOrderHeader].[PurchaseOrderNumber], [Sales].[SalesOrderHeader].[AccountNumber], [Sales].[SalesOrderHeader].[SalesPersonID], [Sales].[SalesOrderHeader].[BillToAddressID], [Sales].[SalesOrderHeader].[ShipToAddressID], [Sales].[SalesOrderHeader].[CreditCardApprovalCode], [Sales].[SalesOrderHeader].[SubTotal], [Sales].[SalesOrderHeader].[TaxAmt], [Sales].[SalesOrderHeader].[Freight], [Sales].[SalesOrderHeader].[TotalDue], [Sales].[SalesOrderHeader].[Comment], [Sales].[SalesOrderHeader].[rowguid], [Sales].[SalesOrderHeader].[ModifiedDate], [Sales].[SalesOrderHeader].[CreditCardID], [Sales].[SalesOrderHeader].[ShipMethodID], [Sales].[SalesOrderHeader].[CustomerID], [Sales].[SalesOrderHeader].[TerritoryID], [Sales].[SalesOrderHeader].[CurrencyRateID] 
    FROM [Sales].[SalesOrderHeader]

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_LoadByCreditCard]
(
 @CreditCardCreditCardID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeader].[SalesOrderID], [Sales].[SalesOrderHeader].[RevisionNumber], [Sales].[SalesOrderHeader].[OrderDate], [Sales].[SalesOrderHeader].[DueDate], [Sales].[SalesOrderHeader].[ShipDate], [Sales].[SalesOrderHeader].[Status], [Sales].[SalesOrderHeader].[OnlineOrderFlag], [Sales].[SalesOrderHeader].[SalesOrderNumber], [Sales].[SalesOrderHeader].[PurchaseOrderNumber], [Sales].[SalesOrderHeader].[AccountNumber], [Sales].[SalesOrderHeader].[SalesPersonID], [Sales].[SalesOrderHeader].[BillToAddressID], [Sales].[SalesOrderHeader].[ShipToAddressID], [Sales].[SalesOrderHeader].[CreditCardApprovalCode], [Sales].[SalesOrderHeader].[SubTotal], [Sales].[SalesOrderHeader].[TaxAmt], [Sales].[SalesOrderHeader].[Freight], [Sales].[SalesOrderHeader].[TotalDue], [Sales].[SalesOrderHeader].[Comment], [Sales].[SalesOrderHeader].[rowguid], [Sales].[SalesOrderHeader].[ModifiedDate], [Sales].[SalesOrderHeader].[CreditCardID], [Sales].[SalesOrderHeader].[ShipMethodID], [Sales].[SalesOrderHeader].[CustomerID], [Sales].[SalesOrderHeader].[TerritoryID], [Sales].[SalesOrderHeader].[CurrencyRateID] 
    FROM [Sales].[SalesOrderHeader]
    WHERE ([Sales].[SalesOrderHeader].[CreditCardID] = @CreditCardCreditCardID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_LoadByCurrencyRate]
(
 @CurrencyRateCurrencyRateID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeader].[SalesOrderID], [Sales].[SalesOrderHeader].[RevisionNumber], [Sales].[SalesOrderHeader].[OrderDate], [Sales].[SalesOrderHeader].[DueDate], [Sales].[SalesOrderHeader].[ShipDate], [Sales].[SalesOrderHeader].[Status], [Sales].[SalesOrderHeader].[OnlineOrderFlag], [Sales].[SalesOrderHeader].[SalesOrderNumber], [Sales].[SalesOrderHeader].[PurchaseOrderNumber], [Sales].[SalesOrderHeader].[AccountNumber], [Sales].[SalesOrderHeader].[SalesPersonID], [Sales].[SalesOrderHeader].[BillToAddressID], [Sales].[SalesOrderHeader].[ShipToAddressID], [Sales].[SalesOrderHeader].[CreditCardApprovalCode], [Sales].[SalesOrderHeader].[SubTotal], [Sales].[SalesOrderHeader].[TaxAmt], [Sales].[SalesOrderHeader].[Freight], [Sales].[SalesOrderHeader].[TotalDue], [Sales].[SalesOrderHeader].[Comment], [Sales].[SalesOrderHeader].[rowguid], [Sales].[SalesOrderHeader].[ModifiedDate], [Sales].[SalesOrderHeader].[CreditCardID], [Sales].[SalesOrderHeader].[ShipMethodID], [Sales].[SalesOrderHeader].[CustomerID], [Sales].[SalesOrderHeader].[TerritoryID], [Sales].[SalesOrderHeader].[CurrencyRateID] 
    FROM [Sales].[SalesOrderHeader]
    WHERE ([Sales].[SalesOrderHeader].[CurrencyRateID] = @CurrencyRateCurrencyRateID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_LoadByCustomer]
(
 @CustomerCustomerID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeader].[SalesOrderID], [Sales].[SalesOrderHeader].[RevisionNumber], [Sales].[SalesOrderHeader].[OrderDate], [Sales].[SalesOrderHeader].[DueDate], [Sales].[SalesOrderHeader].[ShipDate], [Sales].[SalesOrderHeader].[Status], [Sales].[SalesOrderHeader].[OnlineOrderFlag], [Sales].[SalesOrderHeader].[SalesOrderNumber], [Sales].[SalesOrderHeader].[PurchaseOrderNumber], [Sales].[SalesOrderHeader].[AccountNumber], [Sales].[SalesOrderHeader].[SalesPersonID], [Sales].[SalesOrderHeader].[BillToAddressID], [Sales].[SalesOrderHeader].[ShipToAddressID], [Sales].[SalesOrderHeader].[CreditCardApprovalCode], [Sales].[SalesOrderHeader].[SubTotal], [Sales].[SalesOrderHeader].[TaxAmt], [Sales].[SalesOrderHeader].[Freight], [Sales].[SalesOrderHeader].[TotalDue], [Sales].[SalesOrderHeader].[Comment], [Sales].[SalesOrderHeader].[rowguid], [Sales].[SalesOrderHeader].[ModifiedDate], [Sales].[SalesOrderHeader].[CreditCardID], [Sales].[SalesOrderHeader].[ShipMethodID], [Sales].[SalesOrderHeader].[CustomerID], [Sales].[SalesOrderHeader].[TerritoryID], [Sales].[SalesOrderHeader].[CurrencyRateID] 
    FROM [Sales].[SalesOrderHeader]
    WHERE ([Sales].[SalesOrderHeader].[CustomerID] = @CustomerCustomerID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_LoadBySalesTerritory]
(
 @SalesTerritoryTerritoryID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeader].[SalesOrderID], [Sales].[SalesOrderHeader].[RevisionNumber], [Sales].[SalesOrderHeader].[OrderDate], [Sales].[SalesOrderHeader].[DueDate], [Sales].[SalesOrderHeader].[ShipDate], [Sales].[SalesOrderHeader].[Status], [Sales].[SalesOrderHeader].[OnlineOrderFlag], [Sales].[SalesOrderHeader].[SalesOrderNumber], [Sales].[SalesOrderHeader].[PurchaseOrderNumber], [Sales].[SalesOrderHeader].[AccountNumber], [Sales].[SalesOrderHeader].[SalesPersonID], [Sales].[SalesOrderHeader].[BillToAddressID], [Sales].[SalesOrderHeader].[ShipToAddressID], [Sales].[SalesOrderHeader].[CreditCardApprovalCode], [Sales].[SalesOrderHeader].[SubTotal], [Sales].[SalesOrderHeader].[TaxAmt], [Sales].[SalesOrderHeader].[Freight], [Sales].[SalesOrderHeader].[TotalDue], [Sales].[SalesOrderHeader].[Comment], [Sales].[SalesOrderHeader].[rowguid], [Sales].[SalesOrderHeader].[ModifiedDate], [Sales].[SalesOrderHeader].[CreditCardID], [Sales].[SalesOrderHeader].[ShipMethodID], [Sales].[SalesOrderHeader].[CustomerID], [Sales].[SalesOrderHeader].[TerritoryID], [Sales].[SalesOrderHeader].[CurrencyRateID] 
    FROM [Sales].[SalesOrderHeader]
    WHERE ([Sales].[SalesOrderHeader].[TerritoryID] = @SalesTerritoryTerritoryID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeader_LoadByShipMethod]
(
 @ShipMethodShipMethodID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeader].[SalesOrderID], [Sales].[SalesOrderHeader].[RevisionNumber], [Sales].[SalesOrderHeader].[OrderDate], [Sales].[SalesOrderHeader].[DueDate], [Sales].[SalesOrderHeader].[ShipDate], [Sales].[SalesOrderHeader].[Status], [Sales].[SalesOrderHeader].[OnlineOrderFlag], [Sales].[SalesOrderHeader].[SalesOrderNumber], [Sales].[SalesOrderHeader].[PurchaseOrderNumber], [Sales].[SalesOrderHeader].[AccountNumber], [Sales].[SalesOrderHeader].[SalesPersonID], [Sales].[SalesOrderHeader].[BillToAddressID], [Sales].[SalesOrderHeader].[ShipToAddressID], [Sales].[SalesOrderHeader].[CreditCardApprovalCode], [Sales].[SalesOrderHeader].[SubTotal], [Sales].[SalesOrderHeader].[TaxAmt], [Sales].[SalesOrderHeader].[Freight], [Sales].[SalesOrderHeader].[TotalDue], [Sales].[SalesOrderHeader].[Comment], [Sales].[SalesOrderHeader].[rowguid], [Sales].[SalesOrderHeader].[ModifiedDate], [Sales].[SalesOrderHeader].[CreditCardID], [Sales].[SalesOrderHeader].[ShipMethodID], [Sales].[SalesOrderHeader].[CustomerID], [Sales].[SalesOrderHeader].[TerritoryID], [Sales].[SalesOrderHeader].[CurrencyRateID] 
    FROM [Sales].[SalesOrderHeader]
    WHERE ([Sales].[SalesOrderHeader].[ShipMethodID] = @ShipMethodShipMethodID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeaderSalesReason_Load]
(
 @SalesOrderID [int],
 @SalesReasonSalesReasonID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeaderSalesReason].[SalesOrderID], [Sales].[SalesOrderHeaderSalesReason].[ModifiedDate], [Sales].[SalesOrderHeaderSalesReason].[SalesReasonID] 
    FROM [Sales].[SalesOrderHeaderSalesReason]
    WHERE (([Sales].[SalesOrderHeaderSalesReason].[SalesOrderID] = @SalesOrderID) AND ([Sales].[SalesOrderHeaderSalesReason].[SalesReasonID] = @SalesReasonSalesReasonID))

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeaderSalesReason_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeaderSalesReason].[SalesOrderID], [Sales].[SalesOrderHeaderSalesReason].[ModifiedDate], [Sales].[SalesOrderHeaderSalesReason].[SalesReasonID] 
    FROM [Sales].[SalesOrderHeaderSalesReason]

RETURN
GO

CREATE PROCEDURE [Sales].[SalesOrderHeaderSalesReason_LoadBySalesReason]
(
 @SalesReasonSalesReasonID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesOrderHeaderSalesReason].[SalesOrderID], [Sales].[SalesOrderHeaderSalesReason].[ModifiedDate], [Sales].[SalesOrderHeaderSalesReason].[SalesReasonID] 
    FROM [Sales].[SalesOrderHeaderSalesReason]
    WHERE ([Sales].[SalesOrderHeaderSalesReason].[SalesReasonID] = @SalesReasonSalesReasonID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPerson_Load]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesPerson].[BusinessEntityID], [Sales].[SalesPerson].[SalesQuota], [Sales].[SalesPerson].[Bonus], [Sales].[SalesPerson].[CommissionPct], [Sales].[SalesPerson].[SalesYTD], [Sales].[SalesPerson].[SalesLastYear], [Sales].[SalesPerson].[rowguid], [Sales].[SalesPerson].[ModifiedDate], [Sales].[SalesPerson].[TerritoryID] 
    FROM [Sales].[SalesPerson]
    WHERE ([Sales].[SalesPerson].[BusinessEntityID] = @BusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPerson_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesPerson].[BusinessEntityID], [Sales].[SalesPerson].[SalesQuota], [Sales].[SalesPerson].[Bonus], [Sales].[SalesPerson].[CommissionPct], [Sales].[SalesPerson].[SalesYTD], [Sales].[SalesPerson].[SalesLastYear], [Sales].[SalesPerson].[rowguid], [Sales].[SalesPerson].[ModifiedDate], [Sales].[SalesPerson].[TerritoryID] 
    FROM [Sales].[SalesPerson]

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPerson_LoadBySalesTerritory]
(
 @SalesTerritoryTerritoryID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesPerson].[BusinessEntityID], [Sales].[SalesPerson].[SalesQuota], [Sales].[SalesPerson].[Bonus], [Sales].[SalesPerson].[CommissionPct], [Sales].[SalesPerson].[SalesYTD], [Sales].[SalesPerson].[SalesLastYear], [Sales].[SalesPerson].[rowguid], [Sales].[SalesPerson].[ModifiedDate], [Sales].[SalesPerson].[TerritoryID] 
    FROM [Sales].[SalesPerson]
    WHERE ([Sales].[SalesPerson].[TerritoryID] = @SalesTerritoryTerritoryID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPersonQuotaHistory_Load]
(
 @BusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesPersonQuotaHistory].[BusinessEntityID], [Sales].[SalesPersonQuotaHistory].[QuotaDate], [Sales].[SalesPersonQuotaHistory].[SalesQuota], [Sales].[SalesPersonQuotaHistory].[rowguid], [Sales].[SalesPersonQuotaHistory].[ModifiedDate] 
    FROM [Sales].[SalesPersonQuotaHistory]
    WHERE ([Sales].[SalesPersonQuotaHistory].[BusinessEntityID] = @BusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesPersonQuotaHistory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesPersonQuotaHistory].[BusinessEntityID], [Sales].[SalesPersonQuotaHistory].[QuotaDate], [Sales].[SalesPersonQuotaHistory].[SalesQuota], [Sales].[SalesPersonQuotaHistory].[rowguid], [Sales].[SalesPersonQuotaHistory].[ModifiedDate] 
    FROM [Sales].[SalesPersonQuotaHistory]

RETURN
GO

CREATE PROCEDURE [Sales].[SalesReason_Load]
(
 @SalesReasonID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesReason].[SalesReasonID], [Sales].[SalesReason].[Name], [Sales].[SalesReason].[ReasonType], [Sales].[SalesReason].[ModifiedDate] 
    FROM [Sales].[SalesReason]
    WHERE ([Sales].[SalesReason].[SalesReasonID] = @SalesReasonID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesReason_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesReason].[SalesReasonID], [Sales].[SalesReason].[Name], [Sales].[SalesReason].[ReasonType], [Sales].[SalesReason].[ModifiedDate] 
    FROM [Sales].[SalesReason]

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTaxRate_Load]
(
 @SalesTaxRateID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesTaxRate].[SalesTaxRateID], [Sales].[SalesTaxRate].[TaxType], [Sales].[SalesTaxRate].[TaxRate], [Sales].[SalesTaxRate].[Name], [Sales].[SalesTaxRate].[rowguid], [Sales].[SalesTaxRate].[ModifiedDate], [Sales].[SalesTaxRate].[StateProvinceID] 
    FROM [Sales].[SalesTaxRate]
    WHERE ([Sales].[SalesTaxRate].[SalesTaxRateID] = @SalesTaxRateID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTaxRate_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesTaxRate].[SalesTaxRateID], [Sales].[SalesTaxRate].[TaxType], [Sales].[SalesTaxRate].[TaxRate], [Sales].[SalesTaxRate].[Name], [Sales].[SalesTaxRate].[rowguid], [Sales].[SalesTaxRate].[ModifiedDate], [Sales].[SalesTaxRate].[StateProvinceID] 
    FROM [Sales].[SalesTaxRate]

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTaxRate_LoadByStateProvince]
(
 @StateProvinceStateProvinceID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesTaxRate].[SalesTaxRateID], [Sales].[SalesTaxRate].[TaxType], [Sales].[SalesTaxRate].[TaxRate], [Sales].[SalesTaxRate].[Name], [Sales].[SalesTaxRate].[rowguid], [Sales].[SalesTaxRate].[ModifiedDate], [Sales].[SalesTaxRate].[StateProvinceID] 
    FROM [Sales].[SalesTaxRate]
    WHERE ([Sales].[SalesTaxRate].[StateProvinceID] = @StateProvinceStateProvinceID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritory_Load]
(
 @TerritoryID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesTerritory].[TerritoryID], [Sales].[SalesTerritory].[Name], [Sales].[SalesTerritory].[Group], [Sales].[SalesTerritory].[SalesYTD], [Sales].[SalesTerritory].[SalesLastYear], [Sales].[SalesTerritory].[CostYTD], [Sales].[SalesTerritory].[CostLastYear], [Sales].[SalesTerritory].[rowguid], [Sales].[SalesTerritory].[ModifiedDate], [Sales].[SalesTerritory].[CountryRegionCode] 
    FROM [Sales].[SalesTerritory]
    WHERE ([Sales].[SalesTerritory].[TerritoryID] = @TerritoryID)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesTerritory].[TerritoryID], [Sales].[SalesTerritory].[Name], [Sales].[SalesTerritory].[Group], [Sales].[SalesTerritory].[SalesYTD], [Sales].[SalesTerritory].[SalesLastYear], [Sales].[SalesTerritory].[CostYTD], [Sales].[SalesTerritory].[CostLastYear], [Sales].[SalesTerritory].[rowguid], [Sales].[SalesTerritory].[ModifiedDate], [Sales].[SalesTerritory].[CountryRegionCode] 
    FROM [Sales].[SalesTerritory]

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritory_LoadByCountryRegion]
(
 @CountryRegionCountryRegionCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesTerritory].[TerritoryID], [Sales].[SalesTerritory].[Name], [Sales].[SalesTerritory].[Group], [Sales].[SalesTerritory].[SalesYTD], [Sales].[SalesTerritory].[SalesLastYear], [Sales].[SalesTerritory].[CostYTD], [Sales].[SalesTerritory].[CostLastYear], [Sales].[SalesTerritory].[rowguid], [Sales].[SalesTerritory].[ModifiedDate], [Sales].[SalesTerritory].[CountryRegionCode] 
    FROM [Sales].[SalesTerritory]
    WHERE ([Sales].[SalesTerritory].[CountryRegionCode] = @CountryRegionCountryRegionCode)

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritoryHistory_Load]
(
 @BusinessEntityID [int],
 @TerritoryID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesTerritoryHistory].[BusinessEntityID], [Sales].[SalesTerritoryHistory].[TerritoryID], [Sales].[SalesTerritoryHistory].[StartDate], [Sales].[SalesTerritoryHistory].[EndDate], [Sales].[SalesTerritoryHistory].[rowguid], [Sales].[SalesTerritoryHistory].[ModifiedDate] 
    FROM [Sales].[SalesTerritoryHistory]
    WHERE (([Sales].[SalesTerritoryHistory].[BusinessEntityID] = @BusinessEntityID) AND ([Sales].[SalesTerritoryHistory].[TerritoryID] = @TerritoryID))

RETURN
GO

CREATE PROCEDURE [Sales].[SalesTerritoryHistory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SalesTerritoryHistory].[BusinessEntityID], [Sales].[SalesTerritoryHistory].[TerritoryID], [Sales].[SalesTerritoryHistory].[StartDate], [Sales].[SalesTerritoryHistory].[EndDate], [Sales].[SalesTerritoryHistory].[rowguid], [Sales].[SalesTerritoryHistory].[ModifiedDate] 
    FROM [Sales].[SalesTerritoryHistory]

RETURN
GO

CREATE PROCEDURE [Production].[ScrapReason_Load]
(
 @ScrapReasonID [smallint]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ScrapReason].[ScrapReasonID], [Production].[ScrapReason].[Name], [Production].[ScrapReason].[ModifiedDate] 
    FROM [Production].[ScrapReason]
    WHERE ([Production].[ScrapReason].[ScrapReasonID] = @ScrapReasonID)

RETURN
GO

CREATE PROCEDURE [Production].[ScrapReason_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[ScrapReason].[ScrapReasonID], [Production].[ScrapReason].[Name], [Production].[ScrapReason].[ModifiedDate] 
    FROM [Production].[ScrapReason]

RETURN
GO

CREATE PROCEDURE [HumanResources].[Shift_Load]
(
 @ShiftID [tinyint]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[Shift].[ShiftID], [HumanResources].[Shift].[Name], [HumanResources].[Shift].[StartTime], [HumanResources].[Shift].[EndTime], [HumanResources].[Shift].[ModifiedDate] 
    FROM [HumanResources].[Shift]
    WHERE ([HumanResources].[Shift].[ShiftID] = @ShiftID)

RETURN
GO

CREATE PROCEDURE [HumanResources].[Shift_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [HumanResources].[Shift].[ShiftID], [HumanResources].[Shift].[Name], [HumanResources].[Shift].[StartTime], [HumanResources].[Shift].[EndTime], [HumanResources].[Shift].[ModifiedDate] 
    FROM [HumanResources].[Shift]

RETURN
GO

CREATE PROCEDURE [Purchasing].[ShipMethod_Load]
(
 @ShipMethodID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[ShipMethod].[ShipMethodID], [Purchasing].[ShipMethod].[Name], [Purchasing].[ShipMethod].[ShipBase], [Purchasing].[ShipMethod].[ShipRate], [Purchasing].[ShipMethod].[rowguid], [Purchasing].[ShipMethod].[ModifiedDate] 
    FROM [Purchasing].[ShipMethod]
    WHERE ([Purchasing].[ShipMethod].[ShipMethodID] = @ShipMethodID)

RETURN
GO

CREATE PROCEDURE [Purchasing].[ShipMethod_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[ShipMethod].[ShipMethodID], [Purchasing].[ShipMethod].[Name], [Purchasing].[ShipMethod].[ShipBase], [Purchasing].[ShipMethod].[ShipRate], [Purchasing].[ShipMethod].[rowguid], [Purchasing].[ShipMethod].[ModifiedDate] 
    FROM [Purchasing].[ShipMethod]

RETURN
GO

CREATE PROCEDURE [Sales].[ShoppingCartItem_Load]
(
 @ShoppingCartItemID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[ShoppingCartItem].[ShoppingCartItemID], [Sales].[ShoppingCartItem].[ShoppingCartID], [Sales].[ShoppingCartItem].[Quantity], [Sales].[ShoppingCartItem].[DateCreated], [Sales].[ShoppingCartItem].[ModifiedDate], [Sales].[ShoppingCartItem].[ProductID] 
    FROM [Sales].[ShoppingCartItem]
    WHERE ([Sales].[ShoppingCartItem].[ShoppingCartItemID] = @ShoppingCartItemID)

RETURN
GO

CREATE PROCEDURE [Sales].[ShoppingCartItem_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[ShoppingCartItem].[ShoppingCartItemID], [Sales].[ShoppingCartItem].[ShoppingCartID], [Sales].[ShoppingCartItem].[Quantity], [Sales].[ShoppingCartItem].[DateCreated], [Sales].[ShoppingCartItem].[ModifiedDate], [Sales].[ShoppingCartItem].[ProductID] 
    FROM [Sales].[ShoppingCartItem]

RETURN
GO

CREATE PROCEDURE [Sales].[ShoppingCartItem_LoadByProduct]
(
 @ProductProductID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[ShoppingCartItem].[ShoppingCartItemID], [Sales].[ShoppingCartItem].[ShoppingCartID], [Sales].[ShoppingCartItem].[Quantity], [Sales].[ShoppingCartItem].[DateCreated], [Sales].[ShoppingCartItem].[ModifiedDate], [Sales].[ShoppingCartItem].[ProductID] 
    FROM [Sales].[ShoppingCartItem]
    WHERE ([Sales].[ShoppingCartItem].[ProductID] = @ProductProductID)

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOffer_Load]
(
 @SpecialOfferID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SpecialOffer].[SpecialOfferID], [Sales].[SpecialOffer].[Description], [Sales].[SpecialOffer].[DiscountPct], [Sales].[SpecialOffer].[Type], [Sales].[SpecialOffer].[Category], [Sales].[SpecialOffer].[StartDate], [Sales].[SpecialOffer].[EndDate], [Sales].[SpecialOffer].[MinQty], [Sales].[SpecialOffer].[MaxQty], [Sales].[SpecialOffer].[rowguid], [Sales].[SpecialOffer].[ModifiedDate] 
    FROM [Sales].[SpecialOffer]
    WHERE ([Sales].[SpecialOffer].[SpecialOfferID] = @SpecialOfferID)

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOffer_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SpecialOffer].[SpecialOfferID], [Sales].[SpecialOffer].[Description], [Sales].[SpecialOffer].[DiscountPct], [Sales].[SpecialOffer].[Type], [Sales].[SpecialOffer].[Category], [Sales].[SpecialOffer].[StartDate], [Sales].[SpecialOffer].[EndDate], [Sales].[SpecialOffer].[MinQty], [Sales].[SpecialOffer].[MaxQty], [Sales].[SpecialOffer].[rowguid], [Sales].[SpecialOffer].[ModifiedDate] 
    FROM [Sales].[SpecialOffer]

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOfferProduct_Load]
(
 @ProductID [int],
 @SpecialOfferSpecialOfferID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SpecialOfferProduct].[ProductID], [Sales].[SpecialOfferProduct].[rowguid], [Sales].[SpecialOfferProduct].[ModifiedDate], [Sales].[SpecialOfferProduct].[SpecialOfferID] 
    FROM [Sales].[SpecialOfferProduct]
    WHERE (([Sales].[SpecialOfferProduct].[ProductID] = @ProductID) AND ([Sales].[SpecialOfferProduct].[SpecialOfferID] = @SpecialOfferSpecialOfferID))

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOfferProduct_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SpecialOfferProduct].[ProductID], [Sales].[SpecialOfferProduct].[rowguid], [Sales].[SpecialOfferProduct].[ModifiedDate], [Sales].[SpecialOfferProduct].[SpecialOfferID] 
    FROM [Sales].[SpecialOfferProduct]

RETURN
GO

CREATE PROCEDURE [Sales].[SpecialOfferProduct_LoadBySpecialOffer]
(
 @SpecialOfferSpecialOfferID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Sales].[SpecialOfferProduct].[ProductID], [Sales].[SpecialOfferProduct].[rowguid], [Sales].[SpecialOfferProduct].[ModifiedDate], [Sales].[SpecialOfferProduct].[SpecialOfferID] 
    FROM [Sales].[SpecialOfferProduct]
    WHERE ([Sales].[SpecialOfferProduct].[SpecialOfferID] = @SpecialOfferSpecialOfferID)

RETURN
GO

CREATE PROCEDURE [Person].[StateProvince_Load]
(
 @StateProvinceID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[StateProvince].[StateProvinceID], [Person].[StateProvince].[StateProvinceCode], [Person].[StateProvince].[IsOnlyStateProvinceFlag], [Person].[StateProvince].[Name], [Person].[StateProvince].[rowguid], [Person].[StateProvince].[ModifiedDate], [Person].[StateProvince].[CountryRegionCode], [Person].[StateProvince].[TerritoryID] 
    FROM [Person].[StateProvince]
    WHERE ([Person].[StateProvince].[StateProvinceID] = @StateProvinceID)

RETURN
GO

CREATE PROCEDURE [Person].[StateProvince_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[StateProvince].[StateProvinceID], [Person].[StateProvince].[StateProvinceCode], [Person].[StateProvince].[IsOnlyStateProvinceFlag], [Person].[StateProvince].[Name], [Person].[StateProvince].[rowguid], [Person].[StateProvince].[ModifiedDate], [Person].[StateProvince].[CountryRegionCode], [Person].[StateProvince].[TerritoryID] 
    FROM [Person].[StateProvince]

RETURN
GO

CREATE PROCEDURE [Person].[StateProvince_LoadByCountryRegion]
(
 @CountryRegionCountryRegionCode [nvarchar] (3),
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[StateProvince].[StateProvinceID], [Person].[StateProvince].[StateProvinceCode], [Person].[StateProvince].[IsOnlyStateProvinceFlag], [Person].[StateProvince].[Name], [Person].[StateProvince].[rowguid], [Person].[StateProvince].[ModifiedDate], [Person].[StateProvince].[CountryRegionCode], [Person].[StateProvince].[TerritoryID] 
    FROM [Person].[StateProvince]
    WHERE ([Person].[StateProvince].[CountryRegionCode] = @CountryRegionCountryRegionCode)

RETURN
GO

CREATE PROCEDURE [Person].[StateProvince_LoadBySalesTerritory]
(
 @SalesTerritoryTerritoryID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Person].[StateProvince].[StateProvinceID], [Person].[StateProvince].[StateProvinceCode], [Person].[StateProvince].[IsOnlyStateProvinceFlag], [Person].[StateProvince].[Name], [Person].[StateProvince].[rowguid], [Person].[StateProvince].[ModifiedDate], [Person].[StateProvince].[CountryRegionCode], [Person].[StateProvince].[TerritoryID] 
    FROM [Person].[StateProvince]
    WHERE ([Person].[StateProvince].[TerritoryID] = @SalesTerritoryTerritoryID)

RETURN
GO

CREATE PROCEDURE [Sales].[Store_Load]
(
 @BusinessEntityBusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT [Sales].[Store].[Name], [Sales].[Store].[SalesPersonID], [Sales].[Store].[Demographics], [Sales].[Store].[rowguid], [Sales].[Store].[ModifiedDate], [Sales].[Store].[BusinessEntityID] 
    FROM [Sales].[Store]
    WHERE ([Sales].[Store].[BusinessEntityID] = @BusinessEntityBusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Sales].[Store_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Sales].[Store].[Name], [Sales].[Store].[SalesPersonID], [Sales].[Store].[Demographics], [Sales].[Store].[rowguid], [Sales].[Store].[ModifiedDate], [Sales].[Store].[BusinessEntityID] 
    FROM [Sales].[Store]

RETURN
GO

CREATE PROCEDURE [Sales].[Store_LoadByBusinessEntity]
(
 @BusinessEntityBusinessEntityID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT [Sales].[Store].[Name], [Sales].[Store].[SalesPersonID], [Sales].[Store].[Demographics], [Sales].[Store].[rowguid], [Sales].[Store].[ModifiedDate], [Sales].[Store].[BusinessEntityID] 
    FROM [Sales].[Store]
    WHERE ([Sales].[Store].[BusinessEntityID] = @BusinessEntityBusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistory_Load]
(
 @TransactionID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[TransactionHistory].[TransactionID], [Production].[TransactionHistory].[ReferenceOrderID], [Production].[TransactionHistory].[ReferenceOrderLineID], [Production].[TransactionHistory].[TransactionDate], [Production].[TransactionHistory].[TransactionType], [Production].[TransactionHistory].[Quantity], [Production].[TransactionHistory].[ActualCost], [Production].[TransactionHistory].[ModifiedDate], [Production].[TransactionHistory].[ProductID] 
    FROM [Production].[TransactionHistory]
    WHERE ([Production].[TransactionHistory].[TransactionID] = @TransactionID)

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistory_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[TransactionHistory].[TransactionID], [Production].[TransactionHistory].[ReferenceOrderID], [Production].[TransactionHistory].[ReferenceOrderLineID], [Production].[TransactionHistory].[TransactionDate], [Production].[TransactionHistory].[TransactionType], [Production].[TransactionHistory].[Quantity], [Production].[TransactionHistory].[ActualCost], [Production].[TransactionHistory].[ModifiedDate], [Production].[TransactionHistory].[ProductID] 
    FROM [Production].[TransactionHistory]

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistory_LoadByProduct]
(
 @ProductProductID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[TransactionHistory].[TransactionID], [Production].[TransactionHistory].[ReferenceOrderID], [Production].[TransactionHistory].[ReferenceOrderLineID], [Production].[TransactionHistory].[TransactionDate], [Production].[TransactionHistory].[TransactionType], [Production].[TransactionHistory].[Quantity], [Production].[TransactionHistory].[ActualCost], [Production].[TransactionHistory].[ModifiedDate], [Production].[TransactionHistory].[ProductID] 
    FROM [Production].[TransactionHistory]
    WHERE ([Production].[TransactionHistory].[ProductID] = @ProductProductID)

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistoryArchive_Load]
(
 @TransactionID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[TransactionHistoryArchive].[TransactionID], [Production].[TransactionHistoryArchive].[ReferenceOrderID], [Production].[TransactionHistoryArchive].[ReferenceOrderLineID], [Production].[TransactionHistoryArchive].[TransactionDate], [Production].[TransactionHistoryArchive].[TransactionType], [Production].[TransactionHistoryArchive].[Quantity], [Production].[TransactionHistoryArchive].[ActualCost], [Production].[TransactionHistoryArchive].[ModifiedDate], [Production].[TransactionHistoryArchive].[ProductID] 
    FROM [Production].[TransactionHistoryArchive]
    WHERE ([Production].[TransactionHistoryArchive].[TransactionID] = @TransactionID)

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistoryArchive_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[TransactionHistoryArchive].[TransactionID], [Production].[TransactionHistoryArchive].[ReferenceOrderID], [Production].[TransactionHistoryArchive].[ReferenceOrderLineID], [Production].[TransactionHistoryArchive].[TransactionDate], [Production].[TransactionHistoryArchive].[TransactionType], [Production].[TransactionHistoryArchive].[Quantity], [Production].[TransactionHistoryArchive].[ActualCost], [Production].[TransactionHistoryArchive].[ModifiedDate], [Production].[TransactionHistoryArchive].[ProductID] 
    FROM [Production].[TransactionHistoryArchive]

RETURN
GO

CREATE PROCEDURE [Production].[TransactionHistoryArchive_LoadByProduct]
(
 @ProductProductID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[TransactionHistoryArchive].[TransactionID], [Production].[TransactionHistoryArchive].[ReferenceOrderID], [Production].[TransactionHistoryArchive].[ReferenceOrderLineID], [Production].[TransactionHistoryArchive].[TransactionDate], [Production].[TransactionHistoryArchive].[TransactionType], [Production].[TransactionHistoryArchive].[Quantity], [Production].[TransactionHistoryArchive].[ActualCost], [Production].[TransactionHistoryArchive].[ModifiedDate], [Production].[TransactionHistoryArchive].[ProductID] 
    FROM [Production].[TransactionHistoryArchive]
    WHERE ([Production].[TransactionHistoryArchive].[ProductID] = @ProductProductID)

RETURN
GO

CREATE PROCEDURE [Production].[UnitMeasure_Load]
(
 @UnitMeasureCode [nvarchar] (256)
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[UnitMeasure].[UnitMeasureCode], [Production].[UnitMeasure].[Name], [Production].[UnitMeasure].[ModifiedDate] 
    FROM [Production].[UnitMeasure]
    WHERE ([Production].[UnitMeasure].[UnitMeasureCode] = @UnitMeasureCode)

RETURN
GO

CREATE PROCEDURE [Production].[UnitMeasure_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[UnitMeasure].[UnitMeasureCode], [Production].[UnitMeasure].[Name], [Production].[UnitMeasure].[ModifiedDate] 
    FROM [Production].[UnitMeasure]

RETURN
GO

CREATE PROCEDURE [Purchasing].[Vendor_Load]
(
 @BusinessEntityBusinessEntityID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[Vendor].[AccountNumber], [Purchasing].[Vendor].[Name], [Purchasing].[Vendor].[CreditRating], [Purchasing].[Vendor].[PreferredVendorStatus], [Purchasing].[Vendor].[ActiveFlag], [Purchasing].[Vendor].[PurchasingWebServiceURL], [Purchasing].[Vendor].[ModifiedDate], [Purchasing].[Vendor].[BusinessEntityID] 
    FROM [Purchasing].[Vendor]
    WHERE ([Purchasing].[Vendor].[BusinessEntityID] = @BusinessEntityBusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Purchasing].[Vendor_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[Vendor].[AccountNumber], [Purchasing].[Vendor].[Name], [Purchasing].[Vendor].[CreditRating], [Purchasing].[Vendor].[PreferredVendorStatus], [Purchasing].[Vendor].[ActiveFlag], [Purchasing].[Vendor].[PurchasingWebServiceURL], [Purchasing].[Vendor].[ModifiedDate], [Purchasing].[Vendor].[BusinessEntityID] 
    FROM [Purchasing].[Vendor]

RETURN
GO

CREATE PROCEDURE [Purchasing].[Vendor_LoadByBusinessEntity]
(
 @BusinessEntityBusinessEntityID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Purchasing].[Vendor].[AccountNumber], [Purchasing].[Vendor].[Name], [Purchasing].[Vendor].[CreditRating], [Purchasing].[Vendor].[PreferredVendorStatus], [Purchasing].[Vendor].[ActiveFlag], [Purchasing].[Vendor].[PurchasingWebServiceURL], [Purchasing].[Vendor].[ModifiedDate], [Purchasing].[Vendor].[BusinessEntityID] 
    FROM [Purchasing].[Vendor]
    WHERE ([Purchasing].[Vendor].[BusinessEntityID] = @BusinessEntityBusinessEntityID)

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrder_Load]
(
 @WorkOrderID [int]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[WorkOrder].[WorkOrderID], [Production].[WorkOrder].[OrderQty], [Production].[WorkOrder].[StockedQty], [Production].[WorkOrder].[ScrappedQty], [Production].[WorkOrder].[StartDate], [Production].[WorkOrder].[EndDate], [Production].[WorkOrder].[DueDate], [Production].[WorkOrder].[ModifiedDate], [Production].[WorkOrder].[ScrapReasonID], [Production].[WorkOrder].[ProductID] 
    FROM [Production].[WorkOrder]
    WHERE ([Production].[WorkOrder].[WorkOrderID] = @WorkOrderID)

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrder_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[WorkOrder].[WorkOrderID], [Production].[WorkOrder].[OrderQty], [Production].[WorkOrder].[StockedQty], [Production].[WorkOrder].[ScrappedQty], [Production].[WorkOrder].[StartDate], [Production].[WorkOrder].[EndDate], [Production].[WorkOrder].[DueDate], [Production].[WorkOrder].[ModifiedDate], [Production].[WorkOrder].[ScrapReasonID], [Production].[WorkOrder].[ProductID] 
    FROM [Production].[WorkOrder]

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrder_LoadByProduct]
(
 @ProductProductID [int],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[WorkOrder].[WorkOrderID], [Production].[WorkOrder].[OrderQty], [Production].[WorkOrder].[StockedQty], [Production].[WorkOrder].[ScrappedQty], [Production].[WorkOrder].[StartDate], [Production].[WorkOrder].[EndDate], [Production].[WorkOrder].[DueDate], [Production].[WorkOrder].[ModifiedDate], [Production].[WorkOrder].[ScrapReasonID], [Production].[WorkOrder].[ProductID] 
    FROM [Production].[WorkOrder]
    WHERE ([Production].[WorkOrder].[ProductID] = @ProductProductID)

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrder_LoadByScrapReason]
(
 @ScrapReasonScrapReasonID [smallint],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[WorkOrder].[WorkOrderID], [Production].[WorkOrder].[OrderQty], [Production].[WorkOrder].[StockedQty], [Production].[WorkOrder].[ScrappedQty], [Production].[WorkOrder].[StartDate], [Production].[WorkOrder].[EndDate], [Production].[WorkOrder].[DueDate], [Production].[WorkOrder].[ModifiedDate], [Production].[WorkOrder].[ScrapReasonID], [Production].[WorkOrder].[ProductID] 
    FROM [Production].[WorkOrder]
    WHERE ([Production].[WorkOrder].[ScrapReasonID] = @ScrapReasonScrapReasonID)

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrderRouting_Load]
(
 @WorkOrderID [int],
 @ProductID [int],
 @OperationSequence [smallint]
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[WorkOrderRouting].[WorkOrderID], [Production].[WorkOrderRouting].[ProductID], [Production].[WorkOrderRouting].[OperationSequence], [Production].[WorkOrderRouting].[ScheduledStartDate], [Production].[WorkOrderRouting].[ScheduledEndDate], [Production].[WorkOrderRouting].[ActualStartDate], [Production].[WorkOrderRouting].[ActualEndDate], [Production].[WorkOrderRouting].[ActualResourceHrs], [Production].[WorkOrderRouting].[PlannedCost], [Production].[WorkOrderRouting].[ActualCost], [Production].[WorkOrderRouting].[ModifiedDate], [Production].[WorkOrderRouting].[LocationID] 
    FROM [Production].[WorkOrderRouting]
    WHERE (([Production].[WorkOrderRouting].[WorkOrderID] = @WorkOrderID) AND (([Production].[WorkOrderRouting].[ProductID] = @ProductID) AND ([Production].[WorkOrderRouting].[OperationSequence] = @OperationSequence)))

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrderRouting_LoadAll]
(
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[WorkOrderRouting].[WorkOrderID], [Production].[WorkOrderRouting].[ProductID], [Production].[WorkOrderRouting].[OperationSequence], [Production].[WorkOrderRouting].[ScheduledStartDate], [Production].[WorkOrderRouting].[ScheduledEndDate], [Production].[WorkOrderRouting].[ActualStartDate], [Production].[WorkOrderRouting].[ActualEndDate], [Production].[WorkOrderRouting].[ActualResourceHrs], [Production].[WorkOrderRouting].[PlannedCost], [Production].[WorkOrderRouting].[ActualCost], [Production].[WorkOrderRouting].[ModifiedDate], [Production].[WorkOrderRouting].[LocationID] 
    FROM [Production].[WorkOrderRouting]

RETURN
GO

CREATE PROCEDURE [Production].[WorkOrderRouting_LoadByLocation]
(
 @LocationLocationID [smallint],
 @_orderBy0 [nvarchar] (64) = NULL,
 @_orderByDirection0 [bit] = 0
)
AS
SET NOCOUNT ON
SELECT DISTINCT [Production].[WorkOrderRouting].[WorkOrderID], [Production].[WorkOrderRouting].[ProductID], [Production].[WorkOrderRouting].[OperationSequence], [Production].[WorkOrderRouting].[ScheduledStartDate], [Production].[WorkOrderRouting].[ScheduledEndDate], [Production].[WorkOrderRouting].[ActualStartDate], [Production].[WorkOrderRouting].[ActualEndDate], [Production].[WorkOrderRouting].[ActualResourceHrs], [Production].[WorkOrderRouting].[PlannedCost], [Production].[WorkOrderRouting].[ActualCost], [Production].[WorkOrderRouting].[ModifiedDate], [Production].[WorkOrderRouting].[LocationID] 
    FROM [Production].[WorkOrderRouting]
    WHERE ([Production].[WorkOrderRouting].[LocationID] = @LocationLocationID)

RETURN
GO

