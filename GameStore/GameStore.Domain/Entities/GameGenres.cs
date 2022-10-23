using GameStore.Domain.Entities.Base;

namespace GameStore.Domain.Entities
{
    public class GameGenres : BaseGameGenres
    {
        public int GenreId { get; set; }
        public Game Game { get; set; }
        public Genre Genre { get; set; }
    }
}
