namespace GameStore.Application.DTOs.Basket
{
    public class BasketItemDto
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string PictureUrl { get; set; }
    }
}
