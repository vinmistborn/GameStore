using GameStore.Application.DTOs.Identity;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services.Identity
{
    public interface IIdentityService
    {
        Task<UserDto> RegisterUserAsync(RegisterDto registerDto);
        Task<UserDto> LoginUserAsync(LoginDto loginDto);
        Task SignOutUserAsync();
    }
}
