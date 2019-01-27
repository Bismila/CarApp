using System;
using System.Collections.Generic;

namespace Car.DAL.Entities
{
    public partial class Supports
    {
        public Supports()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
