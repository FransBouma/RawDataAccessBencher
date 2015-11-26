using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ErrorLog
    {
        public int ErrorLogID { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
        public int ErrorNumber { get; set; }
        public string ErrorProcedure { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }
        public DateTime ErrorTime { get; set; }
    }
}
