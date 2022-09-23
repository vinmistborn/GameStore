using AutoMapper;
using GameStore.Application.Contracts.Repositories;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.GameGenres;
using GameStore.Application.DTOs.GameGenres.GameSubGenres;
using GameStore.Application.Services.Base;
using GameStore.Domain.Entities;

namespace GameStore.Application.Services
{
    public class GameSubGenresService : GenericServiceWithSpecification<GameSubGenresDTO, GameGenresInfoDTO, GameSubGenres>, IGameSubGenresService
    {
        public GameSubGenresService(IGameSubGenresRepository repository,
                                    IMapper mapper)
                                    : base(repository, mapper)
        {
        }
    }
}
