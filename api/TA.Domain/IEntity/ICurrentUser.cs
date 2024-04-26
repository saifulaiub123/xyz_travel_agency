using TA.Domain.DBModel;

namespace TA.Domain.IEntity
{
    public interface ICurrentUser
    {
        public ApplicationUser User { get; }
    }
}
