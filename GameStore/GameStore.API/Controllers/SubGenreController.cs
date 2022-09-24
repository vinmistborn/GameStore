using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Genre;
using GameStore.Application.Specifications.SubGenreSpecs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    public class SubGenreController : BaseController
    {
        public SubGenreController(ISubGenreService genreService)
        {
            _genreService = genreService;
        }

        private readonly ISubGenreService _genreService;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubGenreInfoDTO>>> Get()
        {
            var genres = await _genreService.GetAllAsync();
            return Ok(genres);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubGenreDTO>> GetById(int id)
        {
            var genre = await _genreService.GetInfoWithSpecificationAsync(new SubGenreWithIncludesSpec(id));
            return Ok(genre);
        }

        [HttpPost]
        public async Task<IActionResult> Post(SubGenreDTO genreDTO)
        {
            var genre = await _genreService.AddAsync(genreDTO);
            return Ok(await _genreService.GetInfoWithSpecificationAsync(new SubGenreWithIncludesSpec(genre.Id)));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, SubGenreDTO genreDTO)
        {
            var genre = await _genreService.UpdateAsync(id, genreDTO);
            return Ok(_genreService.GetInfoWithSpecificationAsync(new SubGenreWithIncludesSpec(genre.Id)));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _genreService.DeleteAsync(id);
            return NoContent();
        }
    }
}
