using AutoMapper;
using GameStore.Application.DTOs.Photo;
using GameStore.Domain.Entities;

namespace GameStore.Application.Mappings
{
    public class PhotoMappingProfile : Profile
    {
        public PhotoMappingProfile()
        {
            CreateMap<Photo, PhotoDTO>();
        }
    }
}
