namespace GameStore.Domain.Entities
{
    public class Photo : BaseEntity
    {
        public string Url { get; set; }
        public string PublicId { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
    }
}
