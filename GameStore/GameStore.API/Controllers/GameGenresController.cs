﻿using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.GameGenres;
using GameStore.Application.DTOs.GameGenres.GameSubGenres;
using GameStore.Application.Specifications.GameGenresSpecs;
using GameStore.Application.Specifications.GameGenresSpecs.GameSubGenresSpecs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    public class GameGenresController : BaseController
    {       
        public GameGenresController(IGameGenresService gameGenresService, IGameSubGenresService gameSubGenresService)
        {
            _gameGenresService = gameGenresService;
            _gameSubGenresService = gameSubGenresService;
        }

        private readonly IGameGenresService _gameGenresService;
        private readonly IGameSubGenresService _gameSubGenresService;

        [HttpGet("{gameId}")]
        public async Task<ActionResult<IEnumerable<GameGenresInfoDTO>>> GetGameGenres(int gameId)
        {
            var gameGenres = await _gameGenresService.GetAllWithSpecificationAsync(new GameGenresFilterByGameIdSpec(gameId));           
            return Ok(gameGenres);
        }

        [HttpGet("/gameSubGenres/{gameId}")]
        public async Task<ActionResult<IEnumerable<GameGenresInfoDTO>>> GetGameSubGenres(int gameId)
        {
            var gameSubGenres = await _gameSubGenresService.GetAllWithSpecificationAsync(new GameSubGenresFilterByGameIdSpec(gameId));
            return Ok(gameSubGenres);
        }

        [HttpPost("/assignGenres")]
        public async Task<IActionResult> PostGameGenres(GameGenresDTO gameGenresDTO)
        {
            var gameGenres = await _gameGenresService.AddAsync(gameGenresDTO);
            return Ok(await _gameGenresService.GetInfoWithSpecificationAsync(new GameGenresWithIncludesSpec(gameGenres.Id)));
        }

        [HttpPost("/assignSubGenres")]
        public async Task<IActionResult> PostGameSubGenres(GameSubGenresDTO gameSubGenresDTO)
        {
            var gameGenres = await _gameSubGenresService.AddAsync(gameSubGenresDTO);
            return Ok(await _gameSubGenresService.GetInfoWithSpecificationAsync(new GameSubGenresWithIncludesSpec(gameGenres.Id)));
        }
    }
}
