using System.Collections.Generic;

namespace GameStore.Application.DTOs.Genre
{
    public class GenreWithSubGenresDTO : GenreDTO
    {
        public IEnumerable<SubGenreDTO> SubGenres { get; set; }
    }
}
