using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using GameStore.Application.Contracts.Services;
using GameStore.Infrastructure.Services.Photo.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.Services.Photo
{
    public class PhotoCloudService : IPhotoCloudService
    {
        public PhotoCloudService(IOptions<CloudinarySettings> config)
        {
            var account = new Account
            (
               config.Value.CloudName,
               config.Value.ApiKey,
               config.Value.ApiSecret
            );

            _cloudinary = new Cloudinary(account);
        }

        private readonly Cloudinary _cloudinary;
        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();

            if(file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadParameters = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream)                   
                };

                uploadResult = await _cloudinary.UploadAsync(uploadParameters);
            }

            return uploadResult;            
        }

        public async Task<DeletionResult> DeletePhotoAsync(string publicId)
        {
            var deleteParameters = new DeletionParams(publicId);
            var result = await _cloudinary.DestroyAsync(deleteParameters);

            return result;
        }
    }
}
