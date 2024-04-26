
using TA.Domain.Model;

namespace TA.Domain.DBModel
{
    public class Country : BaseModel<int>
    {
        public string Name { get; set; }
    }
}
