using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public string ShoppingCartID { get; set; }

        public virtual Product Product { get; set; }
    }
}
