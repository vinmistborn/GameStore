using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.DTOs.Genre;
using GameStore.Domain.Entities;

namespace GameStore.Application.Contracts.Services
{
    public interface IGenreService : IGenericService<GenreDTO, GenreDTO, Genre>
    {
    }
}
