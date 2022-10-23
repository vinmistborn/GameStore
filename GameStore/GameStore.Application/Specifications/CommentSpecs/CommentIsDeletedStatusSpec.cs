using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.CommentSpecs
{
    public class CommentIsDeletedStatusSpec : Specification<Comment>
    {
        public CommentIsDeletedStatusSpec()
        {
            Query
                .Where(p => p.IsDeleted);
        }
    }
}
