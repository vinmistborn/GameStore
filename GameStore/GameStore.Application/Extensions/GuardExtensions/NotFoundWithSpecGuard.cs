using Ardalis.GuardClauses;
using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Extensions.GuardExtensions
{
    public static class NotFoundWithSpecGuard
    {
        public static void NotFoundWithSpec<TEntity>(this IGuardClause guardClause,
                                                     TEntity entity,
                                                     ISpecification<TEntity> spec) where TEntity : BaseEntity
        {
            if(entity is null)
            {
                throw new NotFoundException(spec.GetType().Name, nameof(entity));
            }
        }
    }
}
