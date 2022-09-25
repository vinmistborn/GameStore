using System.Collections.Generic;

namespace GameStore.Domain.Entities
{
    public class Game : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<GameGenres> GameGenres { get; set; }
        public ICollection<GameSubGenres> GameSubGenres { get; set; }
        public Photo Photo { get; set; }
    }
}
