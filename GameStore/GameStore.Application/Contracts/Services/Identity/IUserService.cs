using GameStore.Application.DTOs.Identity;
using GameStore.Application.DTOs.Photo;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services.Identity
{
    public interface IUserService
    {
        Task<UserDto> GetCurrentUserAsync();
        Task<UserPhotoDto> GetUserPhotoUrl(int userId);
        Task<UserPhotoDto> AddPhotoAsync(int userId, IFormFile file);
    }
}
