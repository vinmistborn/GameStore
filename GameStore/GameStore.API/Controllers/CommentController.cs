using GameStore.Application.Contracts.Services;
using GameStore.Application.DTOs.Comment;
using GameStore.Application.Specifications.CommentSpecs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GameStore.API.Controllers
{
    [Authorize]
    public class CommentController : BaseController
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("{gameId}")]
        public async Task<ActionResult<IEnumerable<CommentDto>>> GetGameComments(int gameId) 
        {
            var comments = await _commentService.GetAllWithSpecificationAsync(new CommentGroupFilterSpec(gameId));
            return Ok(comments);
        }

        [HttpPost]
        public async Task<ActionResult<CommentDto>> PostComment(CommentDto commentDto) 
        {
            var comment = await _commentService.AddAsync(commentDto);
            return Ok(comment);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CommentDto>> PutComment(int id, CommentDto commentDto) 
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
