using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.CommentSpecs
{
    public class CommentWithSubCommentsSpec : Specification<Comment>
    {
        public CommentWithSubCommentsSpec()
        {
            Query
                .Include(p => p.SubComments);
        }

        public CommentWithSubCommentsSpec(int id)
        {
            Query
                .Where(p => p.Id == id);
        }
    }
}
