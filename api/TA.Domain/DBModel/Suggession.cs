
using TA.Domain.IEntity;
using TA.Domain.Model;

namespace TA.Domain.DBModel
{
    public class Suggession : BaseModel<int>
    {
        public string TripDestination { get; set; }
        public string PlaceToVisit { get; set; }
        public string? AccomodationSuggession { get; set; }
        public string TravelType { get; set; }
        public string? Dining { get; set; }
        public double AverageMoneySpent { get; set; }
        public string? Comments { get; set; }
    }
}
