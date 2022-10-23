using AutoMapper;
using GameStore.Application.Contracts.Repositories;
using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Comment.SubComment;
using GameStore.Application.Services.Base;
using GameStore.Application.Specifications.SubCommentSpecs;
using GameStore.Domain.Entities;
using System.Threading.Tasks;

namespace GameStore.Application.Services
{
    public class SubCommentService : GenericServiceWithSpecification<SubCommentDto, SubCommentInfoDto, SubComment>,
                                     ISubCommentService
    {
        public SubCommentService(ISubCommentRepository repo,
                                 IMapper mapper) : base(repo, mapper)
        {
        }

        public async Task DeleteCommentsAsync()
        {
            var comments = await _repository.ListAsync(new SubCommentIsDeletedStatusSpec());
            await _repository.DeleteRangeAsync(comments);
        }
    }
}
