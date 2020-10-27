using System;
using System.Collections.Generic;

namespace MyBookStore.Models
{
    public partial class Wishlist
    {
        public Wishlist()
        {
            WishlistItem = new HashSet<WishlistItem>();
        }

        public string WishlistId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual UserMaster User { get; set; }
        public virtual ICollection<WishlistItem> WishlistItem { get; set; }
    }
}
