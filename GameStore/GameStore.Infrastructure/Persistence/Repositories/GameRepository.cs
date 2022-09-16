using GameStore.Application.Contracts.Repositories;
using GameStore.Domain.Entities;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class GameRepository : RepositoryBase<Game>, IGameRepository
    {
        public GameRepository(GameStoreDbContext context) : base(context)
        {                
        }
    }
}
