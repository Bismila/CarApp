using Car.BLL.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Car.BLL.Interfaces
{
    public interface ISupportService : IBaseService<SupportsDto>
    {
        Task<List<string>> GetAll();
    }
}
