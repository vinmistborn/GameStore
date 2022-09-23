using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Filters;
using GameStore.Application.DTOs.Game;
using GameStore.Application.DTOs.GameGenres;
using GameStore.Application.Specifications.GameGenresSpecs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    public class GameController : BaseController
    {
        public GameController(IGameService gameService)
        {
            _gameService = gameService;            
        }

        private readonly IGameService _gameService;       

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameInfoDTO>>> Get([FromQuery] GameFilterDTO filterParameters)
        {
            var games = await _gameService.GetGamesByFilterParameters(filterParameters);
            return Ok(games);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameInfoDTO>> GetById(int id)
        {
            var game = await _gameService.GetInfoAsync(id);
            return Ok(game);
        }

        [HttpPost]
        public async Task<IActionResult> Post(GameDTO gameDTO)
        {
            var game = await _gameService.AddAsync(gameDTO);
            return CreatedAtAction("GetById", new { id = game.Id }, game);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, GameDTO gameDTO)
        {
            var game = await _gameService.UpdateAsync(id, gameDTO);
            return Ok(game);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _gameService.DeleteAsync(id);
            return NoContent();
        }
    }
}
