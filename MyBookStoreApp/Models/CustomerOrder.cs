using System;
using System.Collections.Generic;

namespace MyBookStore.Models
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            CustomerOrderDetails = new HashSet<CustomerOrderDetails>();
        }

        public string OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal CartTotal { get; set; }

        public virtual ICollection<CustomerOrderDetails> CustomerOrderDetails { get; set; }
    }
}
