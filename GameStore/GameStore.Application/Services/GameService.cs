using Ardalis.Specification;
using AutoMapper;
using GameStore.Application.Contracts.Repositories;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Filters;
using GameStore.Application.DTOs.Game;
using GameStore.Application.Services.Base;
using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using GameStore.Application.Specifications.GameSpecs;
using Microsoft.AspNetCore.Http;
using Ardalis.GuardClauses;
using GameStore.Application.Extensions.GuardExtensions;
using GameStore.Application.DTOs.Photo;
using GameStore.Application.Specifications.PhotoSpecs;
using CloudinaryDotNet.Actions;

namespace GameStore.Application.Services
{
    public class GameService : GenericServiceWithSpecification<GameDto, GameInfoDto, Game>, IGameService
    {
        public GameService(IGameRepository repository,
                           IMapper mapper,
                           IPhotoService photoService,
                           IRepositoryBase<Photo> photoRepository)
                         : base(repository, mapper)
        {
            _photoService = photoService;
            _photoRepository = photoRepository;
        }

        private readonly IPhotoService _photoService;
        private readonly IRepositoryBase<Photo> _photoRepository;

        public async Task<IEnumerable<GameInfoDto>> GetGamesByFilterParameters(GameFilterDto filterParameters)
        {
            var games = await _repository.ListAsync(new GameWithFiltersSpec(filterParameters));
            return _mapper.Map<IEnumerable<GameInfoDto>>(games);
        }
        
        public async Task<GamePhotoDto> AddPhotoAsync(int gameId, IFormFile file)
        {
            var game = await _repository.GetByIdAsync(gameId);
            Guard.Against.NotFound($"{gameId}", game, "id");

            var result = await AddPhotoAsync(file);

            var photo = new Photo
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId,
                GameId = gameId
            };

            var addedPhoto = await _photoRepository.AddAsync(photo);
            return _mapper.Map<GamePhotoDto>(addedPhoto);
        }
        
        public async Task<GamePhotoDto> UpdatePhotoAsync(int gameId, IFormFile file)
        {
            var photo = await _photoRepository.FirstOrDefaultAsync(new PhotoWithGameSpec(gameId));
            Guard.Against.NotFound($"{gameId}", photo, "gameId");

            await DeletePhotoAsync(photo.PublicId);

            var newPhoto = await AddPhotoAsync(file);

            photo.Url = newPhoto.SecureUrl.AbsoluteUri;
            photo.PublicId = newPhoto.PublicId;

            await _photoRepository.SaveChangesAsync();
            return _mapper.Map<GamePhotoDto>(photo);
        }

        public async override Task DeleteAsync(int id)
        {
            var game = await _repository.FirstOrDefaultAsync(new GameWithPhotoSpec(id));
            Guard.Against.NotFound($"{id}", game, "id");

            var photoPublicId = game.Photo.PublicId;
            await _repository.DeleteAsync(game);

            await DeletePhotoAsync(photoPublicId);
        }

        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            var result = await _photoService.AddPhotoAsync(file);
            Guard.Against.ImageErrorFound(result);

            return result;
        }

        public async Task DeletePhotoAsync(string publicId)
        {
            var result = await _photoService.DeletePhotoAsync(publicId);
            Guard.Against.ImageErrorFound(result);
        }
    }
}
