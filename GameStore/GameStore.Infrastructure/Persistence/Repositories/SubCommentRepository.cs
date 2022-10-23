using Ardalis.Specification.EntityFrameworkCore;
using GameStore.Application.Contracts.Repositories;
using GameStore.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.Persistence.Repositories
{
    public class SubCommentRepository : RepositoryBase<SubComment>, ISubCommentRepository
    {
        public SubCommentRepository(GameStoreDbContext context) : base(context)
        {
        }

        public override async Task DeleteAsync(SubComment entity, CancellationToken cancellationToken = default)
        {
            entity.IsDeleted = true;
            await SaveChangesAsync(cancellationToken);
        }
    }
}
