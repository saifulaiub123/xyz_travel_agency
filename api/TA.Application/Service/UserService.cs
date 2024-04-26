using AutoMapper;
using Microsoft.AspNetCore.Identity;
using TA.Application.IService;
using TA.Domain.DBModel;
using TA.Domain.IRepository;
using TA.Domain.Model;
using TA.Domain.ViewModel;

namespace TA.Application.Service
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserViewModel> GetUserById(int id)
        {
            var user = await _userRepository.GetUserById(id);
            var result = _mapper.Map<UserViewModel>(user);

            return result;
        }

        public async Task UpdateUser(UserModel user)
        {
            var exist = await _userRepository.GetUserById(user.Id);
            if (exist != null)
            {
                exist.Name = user.Name;
                exist.PhoneNumber = user.PhoneNumber;
                foreach (var existUserRole in exist.UserRoles)
                {
                    if (!user.Roles.Any(x => x == existUserRole.RoleId))
                    {
                        await _userRepository.DeleteUserRole(existUserRole);
                    }
                }
                foreach (var updateRole in user.Roles)
                {
                    if (!exist.UserRoles.Any(x => x.RoleId == updateRole))
                    {
                        await _userRepository.AddUserRole(new UserRole() { UserId = user.Id, RoleId = updateRole });
                    }
                }
				await _userManager.UpdateAsync(exist);
            }
        }
    }
}
