using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.DTOs.GameGenres;
using GameStore.Application.DTOs.GameGenres.GameSubGenres;
using GameStore.Domain.Entities;

namespace GameStore.Application.Contracts.Services
{
    public interface IGameSubGenresService : IGenericServiceWithSpecification<GameSubGenresDTO, GameGenresInfoDTO, GameSubGenres>
    {
    }
}
