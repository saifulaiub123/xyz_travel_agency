using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.Application.IService;
using TA.Domain.IRepository;
using TA.Domain.Model;
using TA.Domain.ViewModel;

namespace TA.Application.Service
{
    public class SuggessionService : ISuggessionService
    {
        private readonly ISuggessionRepository _suggessionRepository;

        public SuggessionService(ISuggessionRepository suggessionRepository)
        {
            _suggessionRepository = suggessionRepository;
        }

        public async Task SubmitSuggession(SuggessionModel model)
        {
            await _suggessionRepository.SubmitSuggession(model);
        }
    }
}
