using GameStore.Application.Contracts.Repositories;
using GameStore.Domain.Entities;
using Ardalis.Specification.EntityFrameworkCore;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class GameGenresRepository : RepositoryBase<GameGenres>, IGameGenresRepository
    {
        public GameGenresRepository(GameStoreDbContext context) : base(context)
        {
        }
    }
}
