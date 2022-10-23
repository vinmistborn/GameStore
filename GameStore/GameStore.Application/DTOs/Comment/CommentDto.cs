using GameStore.Application.DTOs.Comment.Base;

namespace GameStore.Application.DTOs.Comment
{
    public class CommentDto : BaseCommentDto
    {
        public int GameId { get; set; }        
    }
}