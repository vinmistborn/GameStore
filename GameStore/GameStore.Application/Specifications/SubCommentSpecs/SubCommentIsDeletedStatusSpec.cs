using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.SubCommentSpecs
{
    public class SubCommentIsDeletedStatusSpec : Specification<SubComment>
    {
        public SubCommentIsDeletedStatusSpec()
        {
            Query
                .Where(p => p.IsDeleted);
        }
    }
}
