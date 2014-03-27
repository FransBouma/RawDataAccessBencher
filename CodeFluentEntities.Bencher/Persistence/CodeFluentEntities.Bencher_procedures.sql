IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_Load]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_Load]
GO

IF EXISTS (SELECT * FROM [dbo].[sysobjects] WHERE id = object_id(N'[Sales].[SalesOrderHeader_LoadAll]') AND OBJECTPROPERTY(id, N'IsProcedure') = 1)
DROP PROCEDURE [Sales].[SalesOrderHeader_LoadAll]
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