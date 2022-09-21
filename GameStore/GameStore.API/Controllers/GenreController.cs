using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Genre;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace GameStore.API.Controllers
{
    public class GenreController : BaseController
    {
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;        
        }

        private readonly IGenreService _genreService;  

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GenreDTO>>> Get()
        {
            var genres = await _genreService.GetAllAsync();
            return Ok(genres);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GenreDTO>> GetById(int id)
        {
            var genre = await _genreService.GetInfoAsync(id);
            return Ok(genre);
        }

        [HttpPost]
        public async Task<IActionResult> Post(GenreDTO genreDTO)
        {
            var genre = await _genreService.AddAsync(genreDTO);
            return Ok(genre);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, GenreDTO genreDTO)
        {
            var genre = await _genreService.UpdateAsync(id, genreDTO);
            return Ok(genre);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _genreService.DeleteAsync(id);
            return NoContent();
        }
    }
}
