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
    public interface IGameService : IGenericServiceWithSpecification<GameDto, GameInfoDto, Game>
    {
        Task<IEnumerable<GameInfoDto>> GetGamesByFilterParameters(GameFilterDto filterParameters);
        Task<GamePhotoDto> AddPhotoAsync(int gameId, IFormFile file);
        Task<GamePhotoDto> UpdatePhotoAsync(int gameId, IFormFile file);
    }
}
