namespace GameStore.Domain.Entities
{
    public class GameGenres : BaseEntity
    {
        public int GameId { get; set; }
        public int GenreId { get; set; }
        public Game Game { get; set; }
        public Genre Genre { get; set; }
    }
}
