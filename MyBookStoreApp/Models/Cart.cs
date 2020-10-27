using System;
using System.Collections.Generic;

namespace MyBookStore.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartItem = new HashSet<CartItem>();
        }

        public string CartId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual UserMaster User { get; set; }
        public virtual ICollection<CartItem> CartItem { get; set; }
    }
}
