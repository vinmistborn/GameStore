using Ardalis.Specification;
using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.DTOs.Comment.Base;
using GameStore.Domain.Entities;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services
{
    public interface IBaseCommentService<TDto, TInfoDto, TEntity> :
                     IGenericServiceWithSpecification<TDto, TInfoDto, TEntity>
                     where TDto : BaseCommentDto
                     where TInfoDto : BaseCommentInfoDto
                     where TEntity : BaseEntity
    {
        Task DeleteCommentsAsync();
    }
}
