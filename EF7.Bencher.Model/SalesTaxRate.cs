using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class SalesTaxRate
    {
        public int SalesTaxRateID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid rowguid { get; set; }
        public int StateProvinceID { get; set; }
        public decimal TaxRate { get; set; }
        public byte TaxType { get; set; }

        public virtual StateProvince StateProvince { get; set; }
    }
}
