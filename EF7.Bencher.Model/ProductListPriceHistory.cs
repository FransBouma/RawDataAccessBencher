using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ProductListPriceHistory
    {
        public int ProductID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
