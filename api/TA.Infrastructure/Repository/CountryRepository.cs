using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.Domain.DBModel;
using TA.Domain.IRepository;
using TA.Infrastructure.DBContext;

namespace TA.Infrastructure.Repository
{
    public class CountryRepository : Repository<Country, int>, ICountryRepository
    {
        private readonly ApplicationDbContext _context;
        public CountryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}