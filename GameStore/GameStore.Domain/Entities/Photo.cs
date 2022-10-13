using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities
{
    public class Photo : BasePhoto
    {
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
