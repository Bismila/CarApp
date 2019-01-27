using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Car.BLL.Interfaces
{
    public interface IBaseService<T>
    {
        Task Create(T item);
        Task<bool> Update(T item);
    }
}
