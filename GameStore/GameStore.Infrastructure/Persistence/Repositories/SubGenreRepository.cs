using Ardalis.Specification.EntityFrameworkCore;
using GameStore.Application.Contracts.Repositories;
using GameStore.Domain.Entities;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class SubGenreRepository : RepositoryBase<SubGenre>, ISubGenreRepository
    {
        public SubGenreRepository(GameStoreDbContext context) : base(context)
        {
        }
    }
}
