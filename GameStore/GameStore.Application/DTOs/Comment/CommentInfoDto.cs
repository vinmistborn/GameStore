using GameStore.Application.DTOs.Comment.Base;
using GameStore.Application.DTOs.Comment.SubComment;
using System.Collections.Generic;

namespace GameStore.Application.DTOs.Comment
{
    public class CommentInfoDto : BaseCommentInfoDto
    {
        public int GameId { get; set; }
        public IEnumerable<SubCommentInfoDto> SubComments { get; set; }
    }
}