using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities
{
    public class GameSubGenres : BaseGameGenres
    {
        public int SubGenreId { get; set; }
        public Game Game { get; set; }
        public SubGenre SubGenre { get; set; }
    }
}
