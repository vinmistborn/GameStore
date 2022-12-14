using Ardalis.GuardClauses;
using Ardalis.Specification;
using AutoMapper;
using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.Extensions.GuardExtensions;
using GameStore.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.Application.Services.Base
{
    public class GenericServiceWithSpecification<TDto, TInfoDto, TEntity> : GenericService<TDto, TInfoDto, TEntity>,
                                                                          IGenericServiceWithSpecification<TDto, TInfoDto, TEntity>
                                                                          where TDto : class
                                                                          where TInfoDto : class
                                                                          where TEntity : BaseEntity

    {
        public GenericServiceWithSpecification(IRepositoryBase<TEntity> repository, IMapper mapper)
                                              : base(repository, mapper)
        {

        }
        public async Task<IEnumerable<TInfoDto>> GetAllWithSpecificationAsync(Specification<TEntity> specification)
        {
            var entities = await _repository.ListAsync(specification);
            return _mapper.Map<IEnumerable<TInfoDto>>(entities);
        }
                
        public async Task<TInfoDto> GetInfoWithSpecificationAsync(Specification<TEntity> specification)
        {
            var entity = await _repository.FirstOrDefaultAsync(specification);
            Guard.Against.NotFoundWithSpec(entity, specification);

            return _mapper.Map<TInfoDto>(entity);
        }
    }
}
