using System;
using System.Collections.Generic;

namespace MyBookStore.Models
{
    public partial class UserMaster
    {
        public UserMaster()
        {
            Cart = new HashSet<Cart>();
            Wishlist = new HashSet<Wishlist>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public int UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }
    }
}
