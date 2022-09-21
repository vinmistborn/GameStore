using Ardalis.Specification;
using GameStore.Domain.Entities;
using System.Linq;

namespace GameStore.Application.Specifications.GameGenresSpecs
{
    public class GameGenresFilterByGenreIdSpec : Specification<GameGenres>
    {
        public GameGenresFilterByGenreIdSpec()
        {
            Query
                .Include(p => p.Genre)
                .Include(p => p.Game);
        }

        public GameGenresFilterByGenreIdSpec(int genreId) : this()
        {
            Query
                .Where(p => p.GenreId == genreId);
        }
    }
}
