using AutoMapper;
using TA.Domain.DBModel;
using TA.Domain.Model;
using TA.Domain.ViewModel;


namespace TA.Domain.Mapping
{
    public class SuggessionMapping : Profile
    {
        public SuggessionMapping()
        {
            CreateMap<Suggession,SuggessionModel>().ReverseMap();
            CreateMap<Suggession,SuggessionViewModel>().ReverseMap();
        }
    }
}
