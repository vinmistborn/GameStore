using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Comment.SubComment;
using GameStore.Application.Specifications.SubCommentSpecs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    [Authorize]
    public class SubCommentController : BaseController 
    {
        private readonly ISubCommentService _commentService;

        public SubCommentController(ISubCommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("{gameId}")]
        public async Task<ActionResult<IEnumerable<SubCommentDto>>> GetGameComments(int gameId)
        {
            var comments = await _commentService.GetAllWithSpecificationAsync(new SubCommentMainCommentFilterSpec(gameId));
            return Ok(comments);
        }

        [HttpPost]
        public async Task<ActionResult<SubCommentDto>> PostComment(SubCommentDto commentDto)
        {
            var comment = await _commentService.AddAsync(commentDto);
            return Ok(comment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SubCommentDto>> PutComment(int id, SubCommentDto commentDto)
        {
            var comment = await _commentService.UpdateAsync(id, commentDto);
            return Ok(comment);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteComment(int id)
        {
            await _commentService.DeleteAsync(id);
            return NoContent();
        }
    }
}
