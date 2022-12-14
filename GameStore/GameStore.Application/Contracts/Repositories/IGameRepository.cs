using Ardalis.Specification;
using GameStore.Domain.Entities;

namespace GameStore.Application.Contracts.Repositories
{
    public interface IGameRepository : IRepositoryBase<Game>
    {
    }
}
