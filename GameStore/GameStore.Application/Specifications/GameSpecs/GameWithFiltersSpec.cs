using Ardalis.Specification;
using GameStore.Application.DTOs.Filters;
using GameStore.Domain.Entities;
using System.Linq;

namespace GameStore.Application.Specifications.GameSpecs
{
    public class GameWithFiltersSpec : Specification<Game> 
    {
        public GameWithFiltersSpec()
        {
            Query
                .Include(p => p.Photo)
                .Include(p => p.GameGenres)
                .Include(p => p.GameSubGenres);
        }

        public GameWithFiltersSpec(GameFilterDto filterParameters) : this()
        {
            Query.Where(x => !filterParameters.GenreId.HasValue || x.GameGenres.Any(p => p.GenreId == filterParameters.GenreId.Value))
                 .Where(x => !filterParameters.SubGenreId.HasValue || x.GameSubGenres.Any(p => p.SubGenreId == filterParameters.SubGenreId.Value))
                 .Where(x => filterParameters.Name == null || x.Name.StartsWith(filterParameters.Name));
        }
    }
}
