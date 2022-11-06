using GameStore.Application.DTOs.Basket;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services
{
    public interface IBasketService
    {
        Task<BasketDto> GetBasketByIdAsync(string basketId);
        Task<BasketDto> CreateOrUpdateBasketAsync(BasketDto basket);
        Task DeleteBasketAsync(string basketId);
    }
}
