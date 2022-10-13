namespace GameStore.Domain.Entities.Base
{
    public class BasePhoto : BaseEntity
    {
        public string Url { get; set; }
        public string PublicId { get; set; }
    }
}
