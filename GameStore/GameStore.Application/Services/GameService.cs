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
using System.Linq;
using System;
using GameStore.Application.Specifications.GameSpecs;
using Microsoft.AspNetCore.Http;
using Ardalis.GuardClauses;
using GameStore.Application.Extensions.GuardExtensions;
using GameStore.Application.DTOs.Photo;
using GameStore.Application.Specifications.PhotoSpecs;
using CloudinaryDotNet.Actions;

namespace GameStore.Application.Services
{
    public class GameService : GenericServiceWithSpecification<GameDTO, GameInfoDTO, Game>, IGameService
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

        public async Task<IEnumerable<GameInfoDTO>> GetGamesByFilterParameters(GameFilterDTO filterParameters)
        {
            var games = await _repository.ListAsync(new GameWithIncludesSpec());

            games = games.Where(x => !filterParameters.GenreId.HasValue
                                || x.GameGenres.Any(p => p.GenreId == filterParameters.GenreId.Value))
                         .Where(x => !filterParameters.SubGenreId.HasValue
                                || x.GameSubGenres.Any(p => p.SubGenreId == filterParameters.SubGenreId.Value))
                         .Where(x => filterParameters.Name == null || StartsWithFilterName(x.Name, filterParameters.Name)).ToList();

            return _mapper.Map<IEnumerable<GameInfoDTO>>(games);
        }

        private bool StartsWithFilterName(string name, string filterParameter)
        {
            return name.StartsWith(filterParameter, StringComparison.OrdinalIgnoreCase);
        }

        public async Task<PhotoDTO> AddPhotoAsync(int gameId, IFormFile file)
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
            return _mapper.Map<PhotoDTO>(addedPhoto);
        }

        public async Task<PhotoDTO> UpdatePhotoAsync(int gameId, IFormFile file)
        {
            var photo = await _photoRepository.FirstOrDefaultAsync(new PhotoWithGameSpec(gameId));
            Guard.Against.NotFound($"{gameId}", photo, "gameId");

            await DeletePhotoAsync(photo.PublicId);

            var newPhoto = await AddPhotoAsync(file);

            photo.Url = newPhoto.SecureUrl.AbsoluteUri;
            photo.PublicId = newPhoto.PublicId;

            await _photoRepository.SaveChangesAsync();
            return _mapper.Map<PhotoDTO>(photo);
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
