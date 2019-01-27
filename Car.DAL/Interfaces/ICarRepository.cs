using Car.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.DAL.Interfaces
{
    public interface ICarRepository : IBaseRepository<Cars>
    {
       Task<Cars> GetCarByName(string carName);
    }
}
