using LinqToDB.Mapping;
using System;

namespace LINQ2DB.Bencher
{
    [Table(Schema = "Sales", Name = "SalesOrderDetail")]
    public class SalesOrderDetail
    {
        [PrimaryKey]
        public int SalesOrderID { get; set; }

        [PrimaryKey]
        public int SalesOrderDetailID { get; set; }

        [Column]
        public string CarrierTrackingNumber { get; set; }

        [Column]
        public short OrderQty { get; set; }

        [Column]
        public int ProductID { get; set; }

        [Column]
        public int SpecialOfferID { get; set; }

        [Column]
        public decimal UnitPrice { get; set; }

        [Column]
        public decimal UnitPriceDiscount { get; set; }

        [Column]
        public decimal LineTotal { get; set; }

        [Column]
        public Guid rowguid { get; set; }

        [Column]
        public DateTime ModifiedDate { get; set; }
    }
}
