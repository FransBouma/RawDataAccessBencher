using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ProductModel
    {
        public ProductModel()
        {
            Product = new HashSet<Product>();
            ProductModelIllustration = new HashSet<ProductModelIllustration>();
            ProductModelProductDescriptionCulture = new HashSet<ProductModelProductDescriptionCulture>();
        }

        public int ProductModelID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid rowguid { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; }
        public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
    }
}
