using AutoMapper;
using GameStore.Application.DTOs.Basket;
using GameStore.Domain.Entities.Basket;

namespace GameStore.Application.Mappings
{
    public class BasketMappingProfile : Profile
    {
        public BasketMappingProfile()
        {
            CreateMap<Basket, BasketDto>()
                .ReverseMap();

            CreateMap<BasketItem, BasketItemDto>()
                .ReverseMap();
        }
    }
}
