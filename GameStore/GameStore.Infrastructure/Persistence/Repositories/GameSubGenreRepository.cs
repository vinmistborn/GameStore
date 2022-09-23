using Ardalis.Specification.EntityFrameworkCore;
using GameStore.Application.Contracts.Repositories;
using GameStore.Domain.Entities;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class GameSubGenreRepository : RepositoryBase<GameSubGenres>, IGameSubGenresRepository
    {
        public GameSubGenreRepository(GameStoreDbContext context) : base(context)
        {
        }
    }
}
