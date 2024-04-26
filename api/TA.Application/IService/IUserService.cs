using TA.Domain.Model;
using TA.Domain.ViewModel;

namespace TA.Application.IService
{
    public interface IUserService
    {
        Task<UserViewModel> GetUserById(int id);
        Task UpdateUser(UserModel user);
    }
}
