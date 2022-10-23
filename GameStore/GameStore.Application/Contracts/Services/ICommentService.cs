using GameStore.Application.DTOs.Comment;
using GameStore.Domain.Entities;

namespace GameStore.Application.Contracts.Services
{
    public interface ICommentService : IBaseCommentService<CommentDto, CommentInfoDto, Comment>
    {
    }
}
