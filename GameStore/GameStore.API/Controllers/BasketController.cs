using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Basket;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    [Authorize]
    public class BasketController : BaseController
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public async Task<ActionResult<BasketDto>> GetBasket(string basketId)
        {
            return Ok(await _basketService.GetBasketByIdAsync(basketId));
        }

        [HttpPost]
        public async Task<ActionResult<BasketDto>> CreateOrUpdateBasket(BasketDto basketDto)
        {
            return Ok(await _basketService.CreateOrUpdateBasketAsync(basketDto));
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteBasket(string basketId)
        {
            await _basketService.DeleteBasketAsync(basketId);
            return NoContent();
        }
    }
}
