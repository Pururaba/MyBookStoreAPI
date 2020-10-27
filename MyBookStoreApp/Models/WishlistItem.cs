using System;
using System.Collections.Generic;

namespace MyBookStore.Models
{
    public partial class WishlistItem
    {
        public int WishlistItemId { get; set; }
        public string WishlistId { get; set; }
        public int ProductId { get; set; }

        public virtual Wishlist Wishlist { get; set; }
    }
}
