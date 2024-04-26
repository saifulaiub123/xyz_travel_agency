using TA.Domain.DBModel;
using TA.Domain.ViewModel;

namespace TA.Domain.IRepository
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetUserById(int id);
        Task DeleteUserRole(UserRole userRole);
        Task AddUserRole(UserRole userRole);
        Task UpdateUserRole(UserRole userRole);
        //Task UpdateUser(ApplicationUser user);
    }
}
