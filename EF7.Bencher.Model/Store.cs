using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class Store
    {
        public Store()
        {
            Customer = new HashSet<Customer>();
        }

        public int BusinessEntityID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid rowguid { get; set; }
        public int? SalesPersonID { get; set; }

        public virtual ICollection<Customer> Customer { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
