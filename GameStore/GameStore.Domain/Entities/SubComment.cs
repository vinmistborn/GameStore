using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities
{
    public class SubComment : BaseComment 
    {
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
