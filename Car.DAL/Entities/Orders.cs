using System;
using System.Collections.Generic;

namespace Car.DAL.Entities
{
    public partial class Orders
    {
        public int Id { get; set; }
        public string DateFrom { get; set; }
        public string DateEnd { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public int SupportsId { get; set; }
        public string Message { get; set; }

        public virtual Cars Car { get; set; }
        public virtual Supports Supports { get; set; }
        public virtual Users User { get; set; }
    }
}
