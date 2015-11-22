using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ProductInventory
    {
        public int ProductID { get; set; }
        public short LocationID { get; set; }
        public byte Bin { get; set; }
        public DateTime ModifiedDate { get; set; }
        public short Quantity { get; set; }
        public Guid rowguid { get; set; }
        public string Shelf { get; set; }

        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
    }
}
