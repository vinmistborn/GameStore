using Ardalis.Specification;
using GameStore.Domain.Entities;
using System.Linq;

namespace GameStore.Application.Specifications.GameGenresSpecs
{
    public class GameGenresFilterByGameIdSpec : Specification<GameGenres>
    {
        public GameGenresFilterByGameIdSpec()
        {
            Query
                .Include(p => p.Game)
                .Include(p => p.Genre);
        }

        public GameGenresFilterByGameIdSpec(int gameId) : this()
        {
            Query
                .Where(p => p.GameId == gameId);                
        }
    }
}
