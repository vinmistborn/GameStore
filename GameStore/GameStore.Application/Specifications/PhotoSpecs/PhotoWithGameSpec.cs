using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.PhotoSpecs
{
    public class PhotoWithGameSpec : Specification<Photo>
    {
        public PhotoWithGameSpec()
        {
            Query
                .Include(p => p.Game);
        }

        public PhotoWithGameSpec(int gameId) : this()
        {
            Query
                .Where(p => p.GameId == gameId);
        }
    }
}