using AutoMapper;
using GameStore.Application.DTOs.Identity;
using GameStore.Domain.Entities.Identity;

namespace GameStore.Application.Mappings
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, RegisterDto>()
                     .ReverseMap();

            CreateMap<User, UserDto>()
                    .ReverseMap();
        }
    }
}
