using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ProductProductPhoto
    {
        public int ProductID { get; set; }
        public int ProductPhotoID { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual ProductPhoto ProductPhoto { get; set; }
    }
}
