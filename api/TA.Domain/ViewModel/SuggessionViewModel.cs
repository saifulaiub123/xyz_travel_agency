using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA.Domain.ViewModel
{
    public class SuggessionViewModel
    {
        public int? Id { get; set; }
        public string TripDestination { get; set; }
        public string PlaceToVisit { get; set; }
        public string? AccomodationSuggession { get; set; }
        public string TravelType { get; set; }
        public string? Dining { get; set; }
        public double AverageMoneySpent { get; set; }
        public string? Comments { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
