using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services.Base
{
    public interface IGenericService<TDto, TInfoDto, TEntity> where TDto : class
                                                              where TInfoDto : class
                                                              where TEntity : BaseEntity
    {
        Task<IEnumerable<TInfoDto>> GetAllAsync();
        Task<TInfoDto> GetInfoAsync(int id);
        Task<TDto> GetByIdAsync(int id);
        Task<TInfoDto> AddAsync(TDto entityDTO);
        Task<TInfoDto> UpdateAsync(int id, TDto entityDTO);
        Task DeleteAsync(int id);
    }
}
