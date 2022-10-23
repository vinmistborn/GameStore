using GameStore.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System;
using GameStore.Application.Contracts.Services.Identity;

namespace GameStore.Infrastructure.Persistence.Interceptors
{
    public class UpdateAuditableEntitiesInterceptor : SaveChangesInterceptor
    {
        private readonly ICurrentUserService _currentUserService;
        public UpdateAuditableEntitiesInterceptor(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            var dbContext = eventData.Context;
            if(dbContext is null) 
            {
                return base.SavingChangesAsync(eventData, result, cancellationToken);
            }

            var entities = dbContext.ChangeTracker.Entries<IAuditableEntity>();

            foreach (var entity in entities)
            {
                if(entity.State == EntityState.Added) 
                {
                    entity.Property(p => p.CreatedAt).CurrentValue = DateTime.Now;
                    entity.Property(p => p.LastModifiedAt).CurrentValue = DateTime.Now;
                    entity.Property(p => p.CreatedBy).CurrentValue = _currentUserService.UserId;
                }

                if (entity.State == EntityState.Modified)
                {
                    entity.Property(p => p.LastModifiedAt).CurrentValue = DateTime.Now;
                }
            }

            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }
    }
}
