using GameStore.Domain.Entities.Base;
using GameStore.Domain.Entities.Identity;

namespace GameStore.Domain.Entities
{
    public class UserPhoto : BasePhoto
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
