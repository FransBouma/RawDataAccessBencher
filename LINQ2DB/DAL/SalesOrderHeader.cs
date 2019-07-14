using LinqToDB.Mapping;
using System;
using System.Collections.Generic;

namespace LINQ2DB.Bencher
{
    [Table(Schema = "Sales", Name = "SalesOrderHeader")]
    public class SalesOrderHeader
    {
        [PrimaryKey]
        public int SalesOrderID { get; set; }

        [Column]
        public string AccountNumber { get; set; }

        [Column]
        public string Comment { get; set; }

        [Column]
        public string CreditCardApprovalCode { get; set; }

        [Column]
        public DateTime DueDate { get; set; }

        [Column]
        public decimal Freight { get; set; }

        [Column]
        public DateTime ModifiedDate { get; set; }

        [Column]
        public bool OnlineOrderFlag { get; set; }

        [Column]
        public DateTime OrderDate { get; set; }

        [Column]
        public string PurchaseOrderNumber { get; set; }

        [Column]
        public byte RevisionNumber { get; set; }

        [Column]
        public Guid Rowguid { get; set; }

        [Column]
        public string SalesOrderNumber { get; set; }

        [Column]
        public DateTime? ShipDate { get; set; }

        [Column]
        public byte Status { get; set; }

        [Column]
        public decimal SubTotal { get; set; }

        [Column]
        public decimal TaxAmt { get; set; }

        [Column]
        public decimal TotalDue { get; set; }

        [Column]
        public int CustomerID { get; set; }

        [Column]
        public int? SalesPersonID { get; set; }

        [Column]
        public int? TerritoryID { get; set; }

        [Column]
        public int BillToAddressID { get; set; }

        [Column]
        public int ShipToAddressID { get; set; }

        [Column]
        public int ShipMethodID { get; set; }

        [Column]
        public int? CreditCardID { get; set; }

        [Column]
        public int? CurrencyRateID { get; set; }

        [Association(ThisKey = nameof(SalesOrderID), OtherKey = nameof(SalesOrderDetail.SalesOrderID))]
        public List<SalesOrderDetail> SalesOrderDetails { get; set; }

        [Association(ThisKey = nameof(CustomerID), OtherKey = nameof(Bencher.Customer.CustomerID))]
        public Customer Customer { get; set; }
    }
}
