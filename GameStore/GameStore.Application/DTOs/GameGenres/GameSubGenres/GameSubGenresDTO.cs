using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.DTOs.GameGenres.GameSubGenres
{
    public class GameSubGenresDTO
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int SubGenreId { get; set; }
    }
}
