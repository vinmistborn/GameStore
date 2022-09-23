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
            CreateMap<GameGenres, GameGenresDTO>()
                    .ReverseMap();

            CreateMap<GameSubGenres, GameSubGenresDTO>()
                    .ReverseMap();

            CreateMap<GameGenres, GameGenresInfoDTO>()
                    .ForMember(dest => dest.Game,
                               src => src.MapFrom(p => p.Game.Name))
                    .ForMember(dest => dest.Genre,
                               src => src.MapFrom(p => p.Genre.Name));                      

            CreateMap<GameSubGenres, GameGenresInfoDTO>()
                    .ForMember(dest => dest.Game,
                               src => src.MapFrom(p => p.Game.Name))
                    .ForMember(dest => dest.Genre,
                               src => src.MapFrom(p => p.SubGenre.Name));
        }
    }
}
