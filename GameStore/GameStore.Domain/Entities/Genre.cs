using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<GameGenres> GameGenres { get; set; }
        public ICollection<SubGenre> SubGenres { get; set; }
    }
}
