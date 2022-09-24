using Ardalis.Specification;
using AutoMapper;
using GameStore.Application.Contracts.Repositories;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Filters;
using GameStore.Application.DTOs.Game;
using GameStore.Application.Services.Base;
using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System;
using GameStore.Application.Specifications.GameSpecs;

namespace GameStore.Application.Services
{
    public class GameService : GenericServiceWithSpecification<GameDTO, GameInfoDTO, Game>, IGameService
    {
        public GameService(IGameRepository repository,
                           IMapper mapper)
                         : base(repository, mapper)
        {            
        }

        public async Task<IEnumerable<GameInfoDTO>> GetGamesByFilterParameters(GameFilterDTO filterParameters)
        {
            var games = await _repository.ListAsync(new GameWithIncludesSpec());
            
            games = games.Where(x => !filterParameters.GenreId.HasValue
                                || x.GameGenres.Any(p => p.GenreId == filterParameters.GenreId.Value))
                         .Where(x => !filterParameters.SubGenreId.HasValue
                                || x.GameSubGenres.Any(p => p.SubGenreId == filterParameters.SubGenreId.Value))
                         .Where(x => filterParameters.Name == null || StartsWithFilterName(x.Name, filterParameters.Name)).ToList();
                        
            return _mapper.Map<IEnumerable<GameInfoDTO>>(games);
        }

        private bool StartsWithFilterName(string name, string filterParameter)
        {
            return name.StartsWith(filterParameter, StringComparison.OrdinalIgnoreCase);
        }
    }
}
