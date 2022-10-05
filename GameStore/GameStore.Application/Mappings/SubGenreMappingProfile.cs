using AutoMapper;
using GameStore.Application.DTOs.Genre;
using GameStore.Domain.Entities;

namespace GameStore.Application.Mappings
{
    public class SubGenreMappingProfile : Profile
    {
        public SubGenreMappingProfile()
        {
            CreateMap<SubGenre, SubGenreDTO>()
                .ReverseMap();

            CreateMap<SubGenre, SubGenreInfoDTO>();
        }
    }
}
