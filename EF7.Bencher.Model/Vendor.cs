using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class Vendor
    {
        public Vendor()
        {
            ProductVendor = new HashSet<ProductVendor>();
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
        }

        public int BusinessEntityID { get; set; }
        public byte CreditRating { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string PurchasingWebServiceURL { get; set; }

        public virtual ICollection<ProductVendor> ProductVendor { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
