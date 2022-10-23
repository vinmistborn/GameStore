using GameStore.Application.Contracts.Services.Identity;
using GameStore.Application.DTOs.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    public class AccountController : BaseController
    {
        private readonly IAccountService _identityService;
        private readonly IUserService _userService;
        public AccountController(IAccountService identityService,
                                IUserService userService)
        {
            _identityService = identityService;
            _userService = userService;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userService.GetCurrentUserAsync();
            return Ok(user);
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
