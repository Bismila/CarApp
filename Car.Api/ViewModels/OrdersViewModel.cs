using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Api.ViewModels
{
    public class OrdersViewModel
    {
        public int Id { get; set; }
        public string DateFrom { get; set; }
        public string DateEnd { get; set; }
        public UsersViewModel User { get; set; }
        public CarsViewModel Car { get; set; }
        public SupportsViewModel Supports { get; set; }
       
        public string Message { get; set; }
    }
}
