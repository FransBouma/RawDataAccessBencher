using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class Password
    {
        public int BusinessEntityID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public Guid rowguid { get; set; }

        public virtual Person BusinessEntity { get; set; }
    }
}
