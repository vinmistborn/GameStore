using Ardalis.GuardClauses;
using CloudinaryDotNet.Actions;
using GameStore.Domain.Exceptions;

namespace GameStore.Application.Extensions.GuardExtensions
{
    public static class ImageErrorFoundGuard
    {
        public static void ImageErrorFound(this IGuardClause guard, BaseResult result)
        {
            if (result.Error is not null)
            {
                throw new ImageException(result.Error.Message);
            }
        }
    }
}
