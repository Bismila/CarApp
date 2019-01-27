using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.Api.ViewModels
{
    public class UsersViewModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
