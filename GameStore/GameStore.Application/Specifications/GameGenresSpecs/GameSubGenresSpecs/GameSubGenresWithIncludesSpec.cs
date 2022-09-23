using Ardalis.Specification;
using GameStore.Domain.Entities;
using System.Linq;

namespace GameStore.Application.Specifications.GameGenresSpecs.GameSubGenresSpecs
{
    public class GameSubGenresWithIncludesSpec : Specification<GameSubGenres>
    {
        public GameSubGenresWithIncludesSpec()
        {
            Query
                .Include(x => x.Game)
                .Include(x => x.SubGenre);
        }

        public GameSubGenresWithIncludesSpec(int id) : this()
        {
            Query
                .Where(x => x.Id == id);
        }
    }
}
