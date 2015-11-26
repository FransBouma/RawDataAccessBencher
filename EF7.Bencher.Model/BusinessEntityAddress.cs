using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class BusinessEntityAddress
    {
        public int BusinessEntityID { get; set; }
        public int AddressID { get; set; }
        public int AddressTypeID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid rowguid { get; set; }

        public virtual Address Address { get; set; }
        public virtual AddressType AddressType { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
