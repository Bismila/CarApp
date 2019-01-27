using Car.BLL.DTO;
using System.Threading.Tasks;

namespace Car.BLL.Interfaces
{
    public interface IUserService: IBaseService<UsersDto>
    {
        Task<bool> ExistUser(string userEmail);
    }
}
