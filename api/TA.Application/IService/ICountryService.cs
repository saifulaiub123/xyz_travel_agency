using TA.Domain.Model;
using TA.Domain.ViewModel;

namespace TA.Application.IService
{
    public interface ICountryService
    {
        Task Add(CountryModel country);
        Task<List<CountryViewModel>> GetAll();
        Task<CountryViewModel> GetById(int id);
        Task Update(CountryModel country);
        Task Delete(int id);
    }
}
