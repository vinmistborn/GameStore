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
using GameStore.Application.Specifications.GameGenresSpecs;

namespace GameStore.Application.Services
{
    public class GameService : GenericService<GameDTO, GameInfoDTO, Game>, IGameService
    {
        public GameService(IRepositoryBase<Game> repository,
                           IMapper mapper,
                           IGameGenresRepository gameGenresRepo)
                         : base(repository, mapper)
        {
            _gameGenresRepo = gameGenresRepo;
        }

        private readonly IGameGenresRepository _gameGenresRepo;

        public async Task<IEnumerable<GameInfoDTO>> GetGamesByFilterParameters(GameFilterDTO filterParameters)
        {
            var games = await _repository.ListAsync();
            var gameGenres = await _gameGenresRepo.ListAsync(new GameGenresWithIncludesSpec());

            if (filterParameters.GenreId.HasValue)
            {
                gameGenres = gameGenres.Where(x => x.GenreId == filterParameters.GenreId.Value).ToList();
            }
            if(filterParameters.Name is not null)
            {
                games = games.Where(x => StartsWithFilterName(x.Name, filterParameters.Name)).ToList();
            }

            var filterResult = games.Union(gameGenres.Select(x => x.Game));

            return _mapper.Map<IEnumerable<GameInfoDTO>>(filterResult);
        }
        private bool StartsWithFilterName(string name, string filterParameter)
        {
            return name.StartsWith(filterParameter, StringComparison.OrdinalIgnoreCase);
        }
    }
}
