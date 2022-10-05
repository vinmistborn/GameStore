using AutoMapper;
using GameStore.Application.DTOs.Genre;
using GameStore.Domain.Entities;

namespace GameStore.Application.Mappings
{
    public class GenreMappingProfile : Profile
    {
        public GenreMappingProfile()
        {
            CreateMap<Genre, GenreDTO>()
                    .ReverseMap();
            CreateMap<Genre, GenreWithSubGenresDTO>()
                    .ForMember(dest => dest.SubGenres,
                               src => src.MapFrom(x => x.SubGenres));
        }
    }
}
