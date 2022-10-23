using GameStore.Application.DTOs.Comment.Base;

namespace GameStore.Application.DTOs.Comment.SubComment
{
    public class SubCommentInfoDto : BaseCommentInfoDto 
    {
        public int CommentId { get; set; }
    }
}