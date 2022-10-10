using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class SubGenre : BaseGenre
    {
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public ICollection <GameSubGenres> GameSubGenres { get; set; }
    }
}
