using GameStore.Application.Contracts.Repositories;
using GameStore.Domain.Entities;
using Ardalis.Specification.EntityFrameworkCore;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        public GenreRepository(GameStoreDbContext context) : base(context)
        {
        }
    }
}
