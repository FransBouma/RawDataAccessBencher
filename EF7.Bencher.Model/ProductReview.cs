using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ProductReview
    {
        public int ProductReviewID { get; set; }
        public string Comments { get; set; }
        public string EmailAddress { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ProductID { get; set; }
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }

        public virtual Product Product { get; set; }
    }
}
