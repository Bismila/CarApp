using System;
using System.Collections.Generic;
using System.Text;

namespace Car.BLL.DTO
{
    public class OrdersDto
    {
        public int Id { get; set; }
        public string DateFrom { get; set; }
        public string DateEnd { get; set; }

        public int CarId { get; set; }
        public int UserId { get; set; }
        public int SupportsId { get; set; }
        public string Message { get; set; }

        public string UserEmail { get; set; }
        public string CarName { get; set; }
        public string SupportsName { get; set; }

    }
}
