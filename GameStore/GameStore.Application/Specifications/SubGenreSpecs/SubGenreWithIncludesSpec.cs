using Ardalis.Specification;
using GameStore.Domain.Entities;
using System.Linq;

namespace GameStore.Application.Specifications.SubGenreSpecs
{
    public class SubGenreWithIncludesSpec : Specification<SubGenre>
    {
        public SubGenreWithIncludesSpec()
        {
            Query
                .Include(x => x.Genre);
        }

        public SubGenreWithIncludesSpec(int id) : this()
        {
            Query
                .Where(x => x.Id == id);
        }
    }    
}
