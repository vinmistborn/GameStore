using Ardalis.GuardClauses;
using GameStore.Domain.Entities;
using System;

namespace GameStore.Application.Extensions.GuardExtensions
{
    public static class NotEqualIdsGuard
    {
        public static void NotEqualIds<TEntity>(this IGuardClause guardClause,
                                                int id,
                                                TEntity entity) where TEntity : BaseEntity
        {
            if(id != entity.Id)
            {
                throw new ArgumentException($"id - {id} does not match with {nameof(entity)} id - {entity.Id}");
            }
        }
    }
}
