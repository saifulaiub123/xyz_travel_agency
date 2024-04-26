using TA.Domain.DBModel;
using TA.Domain.Model;

namespace TA.Domain.IRepository
{
    public interface ISuggessionRepository : IRepository<Suggession, int>
    {
        Task SubmitSuggession(SuggessionModel model);
    }
}
