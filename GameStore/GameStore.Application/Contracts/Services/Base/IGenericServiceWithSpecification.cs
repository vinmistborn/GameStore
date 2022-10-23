using Ardalis.Specification;
using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services.Base
{
    public interface IGenericServiceWithSpecification<TDto, TInfoDto, TEntity>
                   : IGenericService<TDto, TInfoDto, TEntity>  where TDto : class
                                                               where TInfoDto : class
                                                               where TEntity : BaseEntity
    {
        Task<IEnumerable<TInfoDto>> GetAllWithSpecificationAsync(Specification<TEntity> specification);
        Task<TInfoDto> GetInfoWithSpecificationAsync(Specification<TEntity> specification);
    }
}
