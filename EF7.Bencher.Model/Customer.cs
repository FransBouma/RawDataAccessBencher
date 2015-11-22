using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class Customer
    {
        public Customer()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }

        public int CustomerID { get; set; }
        public string AccountNumber { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? PersonID { get; set; }
        public Guid rowguid { get; set; }
        public int? StoreID { get; set; }
        public int? TerritoryID { get; set; }

        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual Person Person { get; set; }
        public virtual Store Store { get; set; }
        public virtual SalesTerritory Territory { get; set; }
    }
}
