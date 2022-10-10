using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Genre : BaseGenre
    {
        public ICollection<GameGenres> GameGenres { get; set; }
        public ICollection<SubGenre> SubGenres { get; set; }
    }
}
