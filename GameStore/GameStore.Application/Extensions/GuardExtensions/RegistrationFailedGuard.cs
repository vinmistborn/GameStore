using Ardalis.GuardClauses;
using GameStore.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;
using System.Linq;

namespace GameStore.Application.Extensions.GuardExtensions
{
    public static class RegistrationFailedGuard
    {
        public static void RegistrationFailed(this IGuardClause guard, IdentityResult result) 
        {
            if (!result.Succeeded)
            {
                var errorDescriptions = string.Join("\n", result.Errors.Select(x => x.Description));
                throw new UserRegistrationFailedException(errorDescriptions);
            }
        }
    }
}
