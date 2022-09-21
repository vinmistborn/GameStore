using Ardalis.Specification;
using GameStore.Domain.Entities;
using System.Linq;

namespace GameStore.Application.Specifications.GameGenresSpecs
{
    public class GameGenresWithIncludesSpec : Specification<GameGenres>
    {
        public GameGenresWithIncludesSpec()
        {
            Query
                .Include(p => p.Game)
                .Include(p => p.Genre);
        }

        public GameGenresWithIncludesSpec(int id) : this()
        {
            Query
                .Where(p => p.Id == id);
        }
    }
}
