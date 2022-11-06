using GameStore.Domain.Entities.Basket;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Repositories
{
    public interface IBasketRepository
    {
        Task<Basket> GetBasketAsync(string basketId);
        Task<Basket> CreateOrUpdateBasketAsync(Basket basket);
        Task<bool> DeleteBasketAsync(string basketId);
    }
}
