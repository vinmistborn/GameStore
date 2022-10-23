using GameStore.Application.DTOs.Comment;
using System.Collections.Generic;

namespace GameStore.Application.DTOs.Game
{
    public class GameWithCommentsDto : GameInfoDto
    {
        public IEnumerable<CommentDto> Comments { get; set; }
    }
}
