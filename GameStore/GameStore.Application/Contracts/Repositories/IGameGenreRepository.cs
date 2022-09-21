using Ardalis.Specification;
using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Repositories
{
    public interface IGameGenresRepository : IRepositoryBase<GameGenres>
    {
        Task<IEnumerable<GameGenres>> GetGameGenresByGameIdAsync(int gameId);
        Task<IEnumerable<GameGenres>> GetGameGenresByGenreIdAsync(int genreId);
    }
}
