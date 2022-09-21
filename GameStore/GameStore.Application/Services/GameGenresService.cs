using Ardalis.Specification;
using AutoMapper;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.GameGenres;
using GameStore.Application.Services.Base;
using GameStore.Domain.Entities;

namespace GameStore.Application.Services
{
    public class GameGenresService : GenericServiceWithSpecification<GameGenresDTO, GameGenresInfoDTO, GameGenres>, IGameGenresService
    {
        public GameGenresService(IRepositoryBase<GameGenres> repository, 
                                 IMapper mapper)
                               : base(repository, mapper)
        {
        }
    }
}
