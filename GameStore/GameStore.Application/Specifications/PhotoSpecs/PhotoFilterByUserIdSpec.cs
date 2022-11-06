using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.PhotoSpecs
{
    public class PhotoFilterByUserIdSpec : Specification<UserPhoto>
    {
        public PhotoFilterByUserIdSpec(int userId)
        {
            Query
                .Where(p => p.UserId == userId);
        }
    }
}
