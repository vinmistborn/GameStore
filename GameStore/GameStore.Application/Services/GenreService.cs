using Ardalis.Specification;
using AutoMapper;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Genre;
using GameStore.Application.Services.Base;
using GameStore.Domain.Entities;

namespace GameStore.Application.Services
{
    public class GenreService : GenericService<GenreDTO, GenreDTO, Genre>, IGenreService
    {
        public GenreService(IRepositoryBase<Genre> repository,
                            IMapper mapper)
                          : base(repository, mapper)
        {
        }
    }
}
