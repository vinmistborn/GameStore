using AutoMapper;
using GameStore.Application.Contracts.Repositories;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Genre;
using GameStore.Application.Services.Base;
using GameStore.Domain.Entities;

namespace GameStore.Application.Services
{
    public class GenreService : GenericService<GenreDto, GenreDto, Genre>, IGenreService
    {
        public GenreService(IGenreRepository repository,
                            IMapper mapper)
                          : base(repository, mapper)
        {
        }
    }
}
