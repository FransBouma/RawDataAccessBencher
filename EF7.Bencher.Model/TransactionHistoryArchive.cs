using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class TransactionHistoryArchive
    {
        public int TransactionID { get; set; }
        public decimal ActualCost { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int ReferenceOrderID { get; set; }
        public int ReferenceOrderLineID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
    }
}
