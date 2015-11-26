using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class AWBuildVersion
    {
        public byte SystemInformationID { get; set; }
        public string Database_Version { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime VersionDate { get; set; }
    }
}
