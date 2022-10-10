namespace GameStore.Application.DTOs.Filters
{
    public class GameFilterDto
    {
        public int? GenreId { get; set; }
        public int? SubGenreId { get; set; }
        public string Name { get; set; }
    }
}
