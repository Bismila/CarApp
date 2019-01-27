using Car.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.BLL.Interfaces
{
    public interface ICarsService : IBaseService<CarsDto>
    {
        Task<List<string>> GetAll();

    }
}
