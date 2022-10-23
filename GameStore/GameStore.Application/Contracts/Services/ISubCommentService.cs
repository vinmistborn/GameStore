using GameStore.Application.DTOs.Comment.SubComment;
using GameStore.Domain.Entities;

namespace GameStore.Application.Contracts.Services
{
    public interface ISubCommentService : IBaseCommentService<SubCommentDto, SubCommentInfoDto, SubComment>
    {
    }
}
