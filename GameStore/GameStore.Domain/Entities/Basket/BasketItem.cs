namespace GameStore.Domain.Entities.Basket
{
    public class BasketItem : BaseEntity
    {
        public string GameName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
    }
}
