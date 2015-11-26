using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ProductSubcategory
    {
        public ProductSubcategory()
        {
            Product = new HashSet<Product>();
        }

        public int ProductSubcategoryID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ProductCategoryID { get; set; }
        public Guid rowguid { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
