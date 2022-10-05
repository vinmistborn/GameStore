using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.DTOs.Filters;
using GameStore.Application.DTOs.Game;
using GameStore.Application.DTOs.Photo;
using GameStore.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services
{
    public interface IGameService : IGenericServiceWithSpecification<GameDTO, GameInfoDTO, Game>
    {
        Task<IEnumerable<GameInfoDTO>> GetGamesByFilterParameters(GameFilterDTO filterParameters);
        Task<PhotoDTO> AddPhotoAsync(int gameId, IFormFile file);
        Task<PhotoDTO> UpdatePhotoAsync(int gameId, IFormFile file);
    }
}
