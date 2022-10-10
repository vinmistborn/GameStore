using AutoMapper;
using GameStore.Application.DTOs.GameGenres;
using GameStore.Application.DTOs.GameGenres.GameSubGenres;
using GameStore.Domain.Entities;

namespace GameStore.Application.Mappings
{
    public class GameGenresMappingProfile : Profile
    {
        public GameGenresMappingProfile()
        {
            CreateMap<GameGenres, GameGenresDto>()
                    .ReverseMap();

            CreateMap<GameSubGenres, GameSubGenresDto>()
                    .ReverseMap();

            CreateMap<GameGenres, GameGenresInfoDto>()
                    .ForMember(dest => dest.Game,
                               src => src.MapFrom(p => p.Game.Name))
                    .ForMember(dest => dest.Name,
                               src => src.MapFrom(p => p.Genre.Name));

            CreateMap<GameSubGenres, GameGenresInfoDto>()
                    .ForMember(dest => dest.Game,
                               src => src.MapFrom(p => p.Game.Name))
                    .ForMember(dest => dest.Name,
                               src => src.MapFrom(p => p.SubGenre.Name));
        }
    }
}
