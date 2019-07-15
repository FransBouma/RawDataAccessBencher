using LinqToDB.Mapping;
using System;

namespace LINQ2DB.Bencher
{
    [Table(Schema = "Sales", Name = "Customer")]
    public class Customer
    {
        [PrimaryKey, Identity]
        public int CustomerID { get; set; }

        [Column]
        public int? PersonID { get; set; }

        [Column]
        public int? StoreID { get; set; }

        [Column]
        public int? TerritoryID { get; set; }

        [Column]
        public string AccountNumber { get; set; }

        [Column]
        public Guid rowguid { get; set; }

        [Column]
        public DateTime ModifiedDate { get; set; }
    }
}
