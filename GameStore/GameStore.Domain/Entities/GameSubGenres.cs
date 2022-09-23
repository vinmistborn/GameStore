namespace GameStore.Domain.Entities
{
    public class GameSubGenres : BaseEntity
    {
        public int GameId { get; set; }
        public int SubGenreId { get; set; }
        public Game Game { get; set; }
        public SubGenre SubGenre { get; set; }
    }
}
