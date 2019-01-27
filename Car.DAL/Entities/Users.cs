using System;
using System.Collections.Generic;

namespace Car.DAL.Entities
{
    public partial class Users
    {
        public Users()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
