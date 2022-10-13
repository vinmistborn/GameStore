using Ardalis.GuardClauses;
using Ardalis.Specification;
using AutoMapper;
using GameStore.Application.Contracts.Services;
using GameStore.Application.Contracts.Services.Identity;
using GameStore.Application.DTOs.Photo;
using GameStore.Application.Extensions.GuardExtensions;
using GameStore.Domain.Entities;
using GameStore.Domain.Entities.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.Services.Identity
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepositoryBase<UserPhoto> _photoRepository;
        private readonly IPhotoService _photoService;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager,
                           IRepositoryBase<UserPhoto> photoRepository,
                           IPhotoService photoService,
                           IMapper mapper)
        {
            _userManager = userManager;
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
    }
}
