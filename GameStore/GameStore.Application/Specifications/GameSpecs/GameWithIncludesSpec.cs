using Ardalis.Specification;
using GameStore.Application.DTOs.Filters;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.GameSpecs
{
    public class GameWithIncludesSpec : Specification<Game>
    {
        public GameWithIncludesSpec()
        {
            Query
                .Include(p => p.GameGenres)
                .Include(p => p.GameSubGenres);
        }
    }
}
