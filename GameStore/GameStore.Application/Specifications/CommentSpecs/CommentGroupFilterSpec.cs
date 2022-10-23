using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Specifications.CommentSpecs
{
    public class CommentGroupFilterSpec : Specification<Comment> 
    {
        public CommentGroupFilterSpec()
        {
            Query
                .Include(p => p.SubComments);
        }

        public CommentGroupFilterSpec(int gameId) : this()
        {
            Query
                .Where(p => p.GameId == gameId);                
        }
    }
}
