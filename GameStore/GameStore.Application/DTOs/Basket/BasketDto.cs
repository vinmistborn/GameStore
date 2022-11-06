using System.Collections.Generic;

namespace GameStore.Application.DTOs.Basket
{
    public class BasketDto
    {
        public string Id { get; set; }
        public List<BasketItemDto> Items { get; set; }
    }
}
