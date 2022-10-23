using GameStore.Domain.Entities.Base;
using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Comment : BaseComment
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
        public ICollection<SubComment> SubComments { get; set; }
    }
}
