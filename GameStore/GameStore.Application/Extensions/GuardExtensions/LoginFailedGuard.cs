using Ardalis.GuardClauses;
using GameStore.Domain.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace GameStore.Application.Extensions.GuardExtensions
{
    public static class LoginFailedGuard
    {
        public static void LoginFailed(this IGuardClause guard, SignInResult result) 
        {
            if (!result.Succeeded)
            {
                throw new LoginFailedException();
            }
        }
    }
}
