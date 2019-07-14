using LinqToDB.Mapping;
using System;
using System.Collections.Generic;

namespace LINQ2DB.Bencher
{
    [Table(Schema = "Sales", Name = "CreditCard")]
    public class CreditCard
    {
        [PrimaryKey]
        public int CreditCardID { get; set; }

        [Column]
        public string CardNumber { get; set; }

        [Column]
        public string CardType { get; set; }

        [Column]
        public byte ExpMonth { get; set; }

        [Column]
        public short ExpYear { get; set; }

        [Column]
        public DateTime ModifiedDate { get; set; }

        [Association(ThisKey = nameof(CreditCardID), OtherKey = nameof(SalesOrderHeader.CreditCardID))]
        public List<SalesOrderHeader> SalesOrderHeaders { get; set; }

    }
}
