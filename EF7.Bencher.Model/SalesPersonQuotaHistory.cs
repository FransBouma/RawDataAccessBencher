using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class SalesPersonQuotaHistory
    {
        public int BusinessEntityID { get; set; }
        public DateTime QuotaDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid rowguid { get; set; }
        public decimal SalesQuota { get; set; }

        public virtual SalesPerson BusinessEntity { get; set; }
    }
}
