using Ardalis.GuardClauses;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Extensions.GuardExtensions
{
    public static class IdNotMatchedGuard
    {
        public static void NotEqualIds<TEntity>(this IGuardClause guardClause, int id, TEntity entity) where TEntity : BaseEntity
        {
            if(id != entity.Id)
            {
                throw new ArgumentException($"id - {id} does not match with {nameof(entity)} id - {entity.Id}");
            }
        }
    }
}
