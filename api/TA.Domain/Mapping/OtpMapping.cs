using AutoMapper;
using TA.Domain.DBModel;
using TA.Domain.ViewModel;

namespace TA.Domain.Mapping
{
    public class OtpMapping : Profile
    {
        public OtpMapping()
        {
            CreateMap<OtpViewModel,Otp>()
                .ReverseMap();
        }
    }
}
