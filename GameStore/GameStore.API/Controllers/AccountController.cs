using GameStore.Application.Contracts.Services.Identity;
using GameStore.Application.DTOs.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IIdentityService _identityService;
        public AccountController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> RegisterUser(RegisterDto registerDto)
        {
            var user = await _identityService.RegisterUserAsync(registerDto);
            return Ok(user);
        }

        [HttpPost("login")]        
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var response = await _identityService.LoginUserAsync(loginDto);
            return Ok(response);
        }

        [HttpPost("logout")]
        public async Task<IActionResult> LogOut()
        {
            await _identityService.SignOutUserAsync();
            return Ok();
        }
    }
}
