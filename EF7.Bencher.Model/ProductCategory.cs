using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            ProductSubcategory = new HashSet<ProductSubcategory>();
        }

        public int ProductCategoryID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid rowguid { get; set; }

        public virtual ICollection<ProductSubcategory> ProductSubcategory { get; set; }
    }
}
