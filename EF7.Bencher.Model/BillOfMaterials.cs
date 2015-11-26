using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class BillOfMaterials
    {
        public int BillOfMaterialsID { get; set; }
        public short BOMLevel { get; set; }
        public int ComponentID { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public decimal PerAssemblyQty { get; set; }
        public int? ProductAssemblyID { get; set; }
        public DateTime StartDate { get; set; }
        public string UnitMeasureCode { get; set; }

        public virtual Product Component { get; set; }
        public virtual Product ProductAssembly { get; set; }
        public virtual UnitMeasure UnitMeasureCodeNavigation { get; set; }
    }
}
