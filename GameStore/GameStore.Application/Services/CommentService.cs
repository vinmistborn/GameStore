using AutoMapper;
using GameStore.Application.Contracts.Repositories;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Comment;
using GameStore.Application.Services.Base;
using GameStore.Application.Specifications.CommentSpecs;
using GameStore.Domain.Entities;
using System.Threading.Tasks;

namespace GameStore.Application.Services
{
    public class CommentService :
                 GenericServiceWithSpecification<CommentDto, CommentInfoDto, Comment>,
                 ICommentService
    {
        public CommentService(ICommentRepository repo,
                              IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task DeleteCommentsAsync()
        {
            var comments = await _repository.ListAsync(new CommentIsDeletedStatusSpec());
            await _repository.DeleteRangeAsync(comments);
        }
    }
}
