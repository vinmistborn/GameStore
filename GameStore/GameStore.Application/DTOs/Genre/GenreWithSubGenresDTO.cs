using System.Collections.Generic;

namespace GameStore.Application.DTOs.Genre
{
    public class GenreWithSubGenresDTO : GenreDto
    {
        public IEnumerable<SubGenreDto> SubGenres { get; set; }
    }
}
