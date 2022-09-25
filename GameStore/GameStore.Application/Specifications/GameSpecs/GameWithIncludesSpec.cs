using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.GameSpecs
{
    public class GameWithIncludesSpec : Specification<Game>
    {
        public GameWithIncludesSpec()
        {
            Query
                .Include(p => p.Photo)
                .Include(p => p.GameGenres)
                .Include(p => p.GameSubGenres);
        }

        public GameWithIncludesSpec(int id) : this()
        {
            Query
                .Where(p => p.Id == id);
        }
    }
}
