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
    public class GenericService<TDto, TInfoDto, TEntity> : IGenericService<TDto, TInfoDto, TEntity>
                                                                          where TDto : class
                                                                          where TInfoDto : class
                                                                          where TEntity : BaseEntity
    {
        public GenericService(IRepositoryBase<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        protected readonly IRepositoryBase<TEntity> _repository;
        protected readonly IMapper _mapper;

        public virtual async Task<TInfoDto> AddAsync(TDto entityDTO)
        {
            Guard.Against.Null(entityDTO, nameof(entityDTO));

            var entity = _mapper.Map<TEntity>(entityDTO);
            await _repository.AddAsync(entity);

            return await GetAsync(entity.Id);
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await CheckEntityNotNullAsync(id);

            await _repository.DeleteAsync(entity);
        }

        public virtual async Task<IEnumerable<TInfoDto>> GetAllAsync()
        {
            var entities = await _repository.ListAsync();
            return _mapper.Map<IEnumerable<TInfoDto>>(entities);
        }

        public virtual async Task<TInfoDto> GetInfoAsync(int id)
        {
            var entity = await CheckEntityNotNullAsync(id);

            return _mapper.Map<TInfoDto>(entity);
        }

        public virtual async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await CheckEntityNotNullAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public virtual async Task<TInfoDto> UpdateAsync(int id, TDto entityDTO)
        {
            var entity = _mapper.Map<TEntity>(entityDTO);

            Guard.Against.NotEqualIds(id, entity);

            await _repository.UpdateAsync(entity);

            return await GetAsync(entity.Id);
        }

        private async Task<TEntity> CheckEntityNotNullAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            Guard.Against.NotFound(id, entity, nameof(id));

            return entity;
        }

        private async Task<TInfoDto> GetAsync(int id)
        {
            return _mapper.Map<TInfoDto>(await _repository.GetByIdAsync(id));
        }
    }
}
