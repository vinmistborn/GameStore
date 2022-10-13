using Ardalis.GuardClauses;
using GameStore.Domain.Entities.Identity;
using GameStore.Domain.Exceptions;

namespace GameStore.Application.Extensions.GuardExtensions
{
    public static class ReservedIdentityGuard
    {
        public static void ReservedIdentity(this IGuardClause guard, User user, string info, string type) 
        {
            if(user is not null) 
            {
                throw new ReservedException(info, type);
            }
        }
    }
}
