using AutoMapper;
using GameStore.Application.DTOs.GameGenres;
using GameStore.Domain.Entities;

namespace GameStore.Application.Mappings
{
    public class GameGenresMappingProfile : Profile
    {
        public GameGenresMappingProfile()
        {
            CreateMap<GameGenres, GameGenresDTO>()
                    .ReverseMap();

            CreateMap<GameGenres, GameGenresInfoDTO>()
                    .ForMember(dest => dest.Game,
                               src => src.MapFrom(p => p.Game.Name))
                    .ForMember(dest => dest.Genre,
                               src => src.MapFrom(p => p.Genre.Name));
        }
    }
}
