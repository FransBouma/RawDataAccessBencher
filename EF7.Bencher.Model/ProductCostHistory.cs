using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ProductCostHistory
    {
        public int ProductID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public decimal StandardCost { get; set; }

        public virtual Product Product { get; set; }
    }
}
