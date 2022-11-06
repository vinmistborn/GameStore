using AutoMapper;
using GameStore.Application.Contracts.Repositories;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Basket;
using GameStore.Domain.Entities.Basket;
using System;
using System.Threading.Tasks;

namespace GameStore.Application.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketRepository _repository;
        private readonly IMapper _mapper;

        public BasketService(IBasketRepository repository,
                             IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BasketDto> CreateOrUpdateBasketAsync(BasketDto basketDto)
        {
            var basket = _mapper.Map<Basket>(basketDto);
            var updatedBasket = await _repository.CreateOrUpdateBasketAsync(basket);
            return _mapper.Map<BasketDto>(updatedBasket);
        }

        public async Task<BasketDto> GetBasketByIdAsync(string basketId)
        {
            var basket = await _repository.GetBasketAsync(basketId);
            return basket is not null ? _mapper.Map<BasketDto>(basket)
                                      : _mapper.Map<BasketDto>(new Basket(basketId));
        }

        public async Task DeleteBasketAsync(string basketId)
        {
            await _repository.DeleteBasketAsync(basketId);
        }
    }
}
