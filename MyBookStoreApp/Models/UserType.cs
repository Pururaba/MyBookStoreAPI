using System;
using System.Collections.Generic;

namespace MyBookStore.Models
{
    public partial class UserType
    {
        public UserType()
        {
            UserMaster = new HashSet<UserMaster>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public virtual ICollection<UserMaster> UserMaster { get; set; }
    }
}
