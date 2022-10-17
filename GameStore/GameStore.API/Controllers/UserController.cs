using GameStore.Application.Contracts.Services.Identity;
using GameStore.Application.DTOs.Identity;
using GameStore.Application.DTOs.Photo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var user = await _userService.GetCurrentUserAsync();
            return Ok(user);
        }

        [HttpPost("add-photo/{userId}")]
        public async Task<ActionResult<UserPhotoDto>> AddPhoto(int userId, IFormFile file)
        {
            var photo = await _userService.AddPhotoAsync(userId, file);
            return Ok(photo);
        }
    }
}
