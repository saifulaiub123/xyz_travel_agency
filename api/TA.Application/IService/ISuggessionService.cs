

using TA.Domain.Model;

namespace TA.Application.IService
{
    public interface ISuggessionService
    {
        Task SubmitSuggession(SuggessionModel model);
    }
}
