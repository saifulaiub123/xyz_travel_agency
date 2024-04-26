using AutoMapper;
using TA.Domain.DBModel;
using TA.Domain.Model;
using TA.Domain.ViewModel;

namespace TA.Domain.Mapping
{
    public class CountryMapping : Profile
    {
        public CountryMapping()
        {
            CreateMap<Country, CountryModel>()
                .ReverseMap();
            CreateMap<Country, CountryViewModel>()
                .ReverseMap();
        }
    }
}
