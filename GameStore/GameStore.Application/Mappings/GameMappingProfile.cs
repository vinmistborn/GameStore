using AutoMapper;
using GameStore.Application.DTOs.Game;
using GameStore.Domain.Entities;

namespace GameStore.Application.Mappings
{
    public class GameMappingProfile : Profile
    {
        public GameMappingProfile()
        {
            CreateMap<Game, GameDto>()
                    .ReverseMap();

            CreateMap<Game, GameInfoDto>()
                    .ForMember(dest => dest.Price,
                               src => src.MapFrom(p => p.Price.ToString("C")))
                    .ForMember(dest => dest.PhotoUrl,
                               src => src.MapFrom(p => p.Photo != null ? p.Photo.Url : ""));

            CreateMap<Game, GameWithCommentsDto>();
        }
    }
}
