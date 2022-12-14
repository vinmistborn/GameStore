using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Filters;
using GameStore.Application.DTOs.Game;
using GameStore.Application.DTOs.Photo;
using GameStore.Application.Specifications.GameSpecs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace GameStore.API.Controllers
{
    [Authorize]
    public class GameController : BaseController
    {
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        private readonly IGameService _gameService;

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameInfoDto>>> Get([FromQuery] GameFilterDto filterParameters)
        {
            var games = await _gameService.GetGamesByFilterParameters(filterParameters);
            return Ok(games);
        }

        [AllowAnonymous]
        [HttpGet("info/{id}")]
        public async Task<ActionResult<GameInfoDto>> GetInfo(int id)
        {
            var game = await _gameService.GetInfoWithSpecificationAsync(new GameWithIncludesSpec(id));
            return Ok(game);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GameDto>> GetById(int id)
        {
            var game = await _gameService.GetByIdAsync(id);
            return Ok(game);
        }

        [HttpPost]
        public async Task<IActionResult> Post(GameDto gameDto)
        {
            var game = await _gameService.AddAsync(gameDto);
            return CreatedAtAction("GetById", new { id = game.Id }, game);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, GameDto gameDto)
        {
            var game = await _gameService.UpdateAsync(id, gameDto);
            return Ok(game);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _gameService.DeleteAsync(id);
            return NoContent();
        }

        [HttpPost("add-photo/{gameId}")]
        public async Task<ActionResult<GamePhotoDto>> AddPhoto(int gameId, IFormFile file)
        {
            var photo = await _gameService.AddPhotoAsync(gameId, file);
            return CreatedAtAction("GetById", new { id = photo.GameId }, photo);
        }

        [HttpPut("update-photo/{gameId}")]
        public async Task<ActionResult<GamePhotoDto>> UpdatePhoto(int gameId, IFormFile file)
        {
            var photo = await _gameService.UpdatePhotoAsync(gameId, file);
            return Ok(photo);
        }
    }
}
