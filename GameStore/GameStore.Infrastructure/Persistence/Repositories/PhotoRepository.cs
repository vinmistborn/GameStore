using Ardalis.Specification.EntityFrameworkCore;
using GameStore.Domain.Entities;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class PhotoRepository: RepositoryBase<Photo>
    {
        public PhotoRepository(GameStoreDbContext context) : base(context)
        {
        }
    }
}
