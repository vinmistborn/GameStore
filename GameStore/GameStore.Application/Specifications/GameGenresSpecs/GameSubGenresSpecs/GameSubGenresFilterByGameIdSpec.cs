using Ardalis.Specification;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Specifications.GameGenresSpecs.GameSubGenresSpecs
{
    public class GameSubGenresFilterByGameIdSpec : Specification<GameSubGenres>
    {
        public GameSubGenresFilterByGameIdSpec()
        {
            Query
                .Include(p => p.Game)
                .Include(p => p.SubGenre);
        }

        public GameSubGenresFilterByGameIdSpec(int gameId) : this()
        {
            Query
                .Where(p => p.GameId == gameId);
        }
    }
}
