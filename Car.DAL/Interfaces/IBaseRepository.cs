using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task Create(T item);
        Task Update(T item);
        Task<List<T>> GetAll();
    }
}
