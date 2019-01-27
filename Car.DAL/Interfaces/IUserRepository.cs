using Car.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.DAL.Interfaces
{
    public interface IUserRepository: IBaseRepository<Users>
    {
        Task<Users> GetByEmail(string email);

    }
}
