﻿using AutoMapper;
using GameStore.Application.DTOs.Game;
using GameStore.Domain.Entities;

namespace GameStore.Application.Mappings
{
    public class GameMappingProfile : Profile
    {
        public GameMappingProfile()
        {
            CreateMap<Game, GameDTO>()
                    .ReverseMap();

            CreateMap<Game, GameInfoDTO>()
                    .ForMember(dest => dest.Price,
                               src => src.MapFrom(p => p.Price.ToString("C")))
                    .ForMember(dest => dest.PhotoUrl,
                               src => src.MapFrom(p => p.Photo != null ? p.Photo.Url : ""));                    
        }
    }
}
