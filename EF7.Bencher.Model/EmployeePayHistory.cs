using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class EmployeePayHistory
    {
        public int BusinessEntityID { get; set; }
        public DateTime RateChangeDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public byte PayFrequency { get; set; }
        public decimal Rate { get; set; }

        public virtual Employee BusinessEntity { get; set; }
    }
}
