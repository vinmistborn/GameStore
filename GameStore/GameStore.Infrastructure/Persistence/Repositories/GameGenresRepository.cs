using GameStore.Application.Contracts.Repositories;
using GameStore.Domain.Entities;
using Ardalis.Specification.EntityFrameworkCore;
using System.Threading.Tasks;
using GameStore.Application.Specifications.GameGenresSpecs;
using System.Collections.Generic;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class GameGenresRepository : RepositoryBase<GameGenres>, IGameGenresRepository
    {
        public GameGenresRepository(GameStoreDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<GameGenres>> GetGameGenresByGameIdAsync(int gameId)
        {
            var gameGenres = await ListAsync(new GameGenresFilterByGameIdSpec(gameId));
            return gameGenres;
        }

        public async Task<IEnumerable<GameGenres>> GetGameGenresByGenreIdAsync(int genreId)
        {
            var gameGenres = await ListAsync(new GameGenresFilterByGenreIdSpec(genreId));
            return gameGenres;
        }
    }
}
