using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class Address
    {
        public Address()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
            SalesOrderHeaderNavigation = new HashSet<SalesOrderHeader>();
        }

        public int AddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string PostalCode { get; set; }
        public Guid rowguid { get; set; }
        public int StateProvinceID { get; set; }

        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaderNavigation { get; set; }
        public virtual StateProvince StateProvince { get; set; }
    }
}
