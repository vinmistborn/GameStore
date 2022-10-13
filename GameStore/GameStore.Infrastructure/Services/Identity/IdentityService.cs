using AutoMapper;
using GameStore.Application.Contracts.Services.Identity;
using GameStore.Application.DTOs.Identity;
using GameStore.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Ardalis.GuardClauses;
using GameStore.Application.Extensions.GuardExtensions;

namespace GameStore.Infrastructure.Services.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;

        public IdentityService(UserManager<User> userManager,
                               SignInManager<User> signInManager,
                               ITokenService tokenService,
                               IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
            _mapper = mapper;
        }

        public async Task<UserDto> RegisterUserAsync(RegisterDto registerDto)
        {
            await CheckForReservedIdentityAsync(registerDto);

            var newUser = _mapper.Map<User>(registerDto);

            var result = await _userManager.CreateAsync(newUser, registerDto.Password);
            Guard.Against.RegistrationFailed(result);

            var registeredUser = _mapper.Map<UserDto>(newUser);
            registeredUser.Token = await _tokenService.GetTokenAsync(newUser);
            return registeredUser;
        }

        public async Task<UserDto> LoginUserAsync(LoginDto loginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.UserName, loginDto.Password, false, false);
            Guard.Against.LoginFailed(result);

            var signedInUser = await _userManager.FindByNameAsync(loginDto.UserName);
            var user = _mapper.Map<UserDto>(signedInUser);
            user.Token = await _tokenService.GetTokenAsync(signedInUser);
            return user;
        }

        public async Task SignOutUserAsync()
        {
            await _signInManager.SignOutAsync();
        }

        private async Task CheckForReservedIdentityAsync(RegisterDto registerDto) 
        {
            var userWithReservedEmail = await _userManager.FindByEmailAsync(registerDto.Email);
            Guard.Against.ReservedIdentity(userWithReservedEmail, "Email", registerDto.Email);

            var userWithReservedUserName = await _userManager.FindByNameAsync(registerDto.UserName);
            Guard.Against.ReservedIdentity(userWithReservedUserName, "User name", registerDto.UserName);
        }
    }
}
