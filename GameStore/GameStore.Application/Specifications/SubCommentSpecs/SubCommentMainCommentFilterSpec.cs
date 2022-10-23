using Ardalis.Specification;
using GameStore.Domain.Entities;
using System.Linq;

namespace GameStore.Application.Specifications.SubCommentSpecs
{
    public class SubCommentMainCommentFilterSpec : Specification<SubComment> 
    {
        public SubCommentMainCommentFilterSpec(int commentId)
        {
            Query
                .Where(p => p.CommentId == commentId);
        }
    }
}
