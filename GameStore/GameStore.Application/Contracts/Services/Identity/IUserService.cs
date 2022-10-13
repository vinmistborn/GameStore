using GameStore.Application.DTOs.Photo;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services.Identity
{
    public interface IUserService
    {
        Task<UserPhotoDto> AddPhotoAsync(int userId, IFormFile file);
    }
}
