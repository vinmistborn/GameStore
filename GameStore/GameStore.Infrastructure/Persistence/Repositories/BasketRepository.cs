using GameStore.Application.Contracts.Repositories;
using GameStore.Domain.Entities.Basket;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDatabase _database;
        private readonly ILogger<BasketRepository> _logger;

        public BasketRepository(IConnectionMultiplexer redis,
                                ILogger<BasketRepository> logger)
        {
            _database = redis.GetDatabase();
            _logger = logger;
        }

        public async Task<bool> DeleteBasketAsync(string basketId)
        {
            return await _database.KeyDeleteAsync(basketId);
        }

        public async Task<Basket> GetBasketAsync(string basketId)
        {            
            _logger.LogInformation($"basket id : {basketId}");
            var data = await _database.StringGetAsync(basketId);
            return data.IsNullOrEmpty ? null : JsonSerializer.Deserialize<Basket>(data);
        }

        public async Task<Basket> CreateOrUpdateBasketAsync(Basket basket)
        {
            var created = await _database.StringSetAsync(basket.Id,
                JsonSerializer.Serialize(basket), TimeSpan.FromDays(30));

            return !created ? null : await GetBasketAsync(basket.Id);
        }
    }
}
