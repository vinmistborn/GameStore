using Ardalis.GuardClauses;
using Ardalis.Specification;
using AutoMapper;
using GameStore.Application.Contracts.Services;
using GameStore.Application.Contracts.Services.Identity;
using GameStore.Application.DTOs.Identity;
using GameStore.Application.DTOs.Photo;
using GameStore.Application.Extensions.GuardExtensions;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.Services.Identity
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly ICurrentUserService _currentUserService;
        private readonly ITokenService _tokenService;
        private readonly IRepositoryBase<UserPhoto> _photoRepository;
        private readonly IPhotoCloudService _photoService;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager,
                           ICurrentUserService currentUserService,
                           ITokenService tokenService,
                           IRepositoryBase<UserPhoto> photoRepository,
                           IPhotoCloudService photoService,
                           IMapper mapper)
        {
            _userManager = userManager;
            _currentUserService = currentUserService;
            _tokenService = tokenService;
            _photoRepository = photoRepository;
            _photoService = photoService;
            _mapper = mapper;
        }

        public async Task<UserPhotoDto> AddPhotoAsync(int userId, IFormFile file)
        {
            var user = await _userManager.FindByIdAsync($"{userId}");
            Guard.Against.NotFound($"{userId}", user, "id");

            var result = await _photoService.AddPhotoAsync(file);
            Guard.Against.ImageErrorFound(result);

            var photo = new UserPhoto
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId,
                UserId = userId
            };

            var addedPhoto = await _photoRepository.AddAsync(photo);
            return _mapper.Map<UserPhotoDto>(addedPhoto);
        }

        public async Task<UserDto> GetCurrentUserAsync()
        {
            var userId = _currentUserService.UserId;
            var user = await _userManager.FindByIdAsync(userId);

            var currentUser = _mapper.Map<UserDto>(user);
            currentUser.Token = await _tokenService.GetTokenAsync(user);
            return currentUser;
        }
    }
}
