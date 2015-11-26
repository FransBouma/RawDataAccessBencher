using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class sysdiagrams
    {
        public int diagram_id { get; set; }
        public byte[] definition { get; set; }
        public int principal_id { get; set; }
        public int? version { get; set; }
    }
}
