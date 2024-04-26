using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.Domain.DBModel;
using TA.Domain.IRepository;
using TA.Domain.Model;
using TA.Infrastructure.DBContext;

namespace TA.Infrastructure.Repository
{
    public class SuggessionRepository : Repository<Suggession, int>, ISuggessionRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public SuggessionRepository(
            ApplicationDbContext context, 
            IMapper mapper
        ) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task SubmitSuggession(SuggessionModel model)
        {
            var suggession = _mapper.Map<Suggession>(model);
            await _context.AddAsync(suggession);
            await _context.SaveChangesAsync();
        }
    }
}
