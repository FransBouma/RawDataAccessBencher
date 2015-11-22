using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class DatabaseLog
    {
        public int DatabaseLogID { get; set; }
        public DateTime PostTime { get; set; }
        public string TSQL { get; set; }
    }
}
