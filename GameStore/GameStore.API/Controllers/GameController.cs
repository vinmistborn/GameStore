using System.Runtime.InteropServices.ComTypes;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Filters;
using GameStore.Application.DTOs.Game;
using GameStore.Application.DTOs.Photo;
using GameStore.Application.Specifications.GameSpecs;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("info/{id}")]
        public async Task<ActionResult<GameInfoDTO>> GetInfo(int id)
        {
            var game = await _gameService.GetInfoWithSpecificationAsync(new GameWithIncludesSpec(id));
            return Ok(game);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameDTO>> GetById(int id)
        {
            var game = await _gameService.GetByIdAsync(id);
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

        [HttpPost("add-photo/{gameId}")]
        public async Task<ActionResult<PhotoDTO>> AddPhoto(int gameId, IFormFile file)
        {
            var photo = await _gameService.AddPhotoAsync(gameId, file);
            return CreatedAtAction("GetById", new { id = photo.GameId }, photo);
        }

        [HttpPut("update-photo/{gameId}")]
        public async Task<ActionResult<PhotoDTO>> UpdatePhoto(int gameId, IFormFile file)
        {
            var photo = await _gameService.UpdatePhotoAsync(gameId, file);
            return Ok(photo);
        }
    }
}
