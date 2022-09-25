using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.GameSpecs
{
    public class GameWithPhotoSpec : Specification<Game>
    {
        public GameWithPhotoSpec()
        {
            Query
                .Include(p => p.Photo);
        }

        public GameWithPhotoSpec(int id) : this()
        {
            Query
                .Where(p => p.Id == id);
        }
    }
}
