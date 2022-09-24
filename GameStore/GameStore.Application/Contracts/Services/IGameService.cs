using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.DTOs.Filters;
using GameStore.Application.DTOs.Game;
using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services
{
    public interface IGameService : IGenericServiceWithSpecification<GameDTO, GameInfoDTO, Game>
    {
       Task<IEnumerable<GameInfoDTO>> GetGamesByFilterParameters(GameFilterDTO filterParameters);
    }
}
