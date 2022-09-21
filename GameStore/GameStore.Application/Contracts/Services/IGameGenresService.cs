using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.DTOs.GameGenres;
using GameStore.Domain.Entities;

namespace GameStore.Application.Contracts.Services
{
    public interface IGameGenresService : IGenericServiceWithSpecification<GameGenresDTO, GameGenresInfoDTO, GameGenres>
    {
    }
}
