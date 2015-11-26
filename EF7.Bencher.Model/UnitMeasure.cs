using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            BillOfMaterials = new HashSet<BillOfMaterials>();
            Product = new HashSet<Product>();
            ProductNavigation = new HashSet<Product>();
            ProductVendor = new HashSet<ProductVendor>();
        }

        public string UnitMeasureCode { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Product> ProductNavigation { get; set; }
        public virtual ICollection<ProductVendor> ProductVendor { get; set; }
    }
}
