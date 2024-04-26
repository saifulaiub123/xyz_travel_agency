using AutoMapper;
using TA.Domain.DBModel;
using TA.Domain.Model;
using TA.Domain.ViewModel;

namespace TA.Domain.Mapping
{
    public class ApplicationUserMapping : Profile
    {
        public ApplicationUserMapping()
        {
            CreateMap<RegisterModel,ApplicationUser>()
                .ForMember(u => u.UserName, opt => opt.MapFrom(x => x.Email))
                .ForMember(u=>u.PasswordHash, opt=> opt.MapFrom(x=> x.Password))
                .ReverseMap();

            CreateMap<UserViewModel, ApplicationUser>()
                //.ForMember(u => u.Id, opt => opt.MapFrom(x => x.Id))
                //.ForMember(u => u.Name, opt => opt.MapFrom(x => x.Name))
                //.ForMember(u => u.Email, opt => opt.MapFrom(x => x.Email))
                //.ForMember(u => u.PhoneNumber, opt => opt.MapFrom(x => x.PhoneNumber))
                //.ForMember(u => u.UserRoles, opt => opt.MapFrom(x => x.PhoneNumber))
                .ReverseMap();

            CreateMap<UserRole, UserRoleViewModel>().ReverseMap();
            CreateMap<Role, RoleViewModel>().ReverseMap();
        }
    }
}
