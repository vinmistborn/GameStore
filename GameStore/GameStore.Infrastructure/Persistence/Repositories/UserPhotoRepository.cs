using Ardalis.Specification.EntityFrameworkCore;
using GameStore.Domain.Entities;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class UserPhotoRepository : RepositoryBase<UserPhoto>
    {
        public UserPhotoRepository(GameStoreDbContext context) : base(context)
        {
        }
    }
}
