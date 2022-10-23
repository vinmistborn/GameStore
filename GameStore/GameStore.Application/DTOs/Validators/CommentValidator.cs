using FluentValidation;
using GameStore.Application.DTOs.Comment;
using GameStore.Application.DTOs.Comment.Base;
using GameStore.Application.DTOs.Comment.SubComment;

namespace GameStore.Application.DTOs.Validators
{
    public class CommentValidator : AbstractValidator<CommentDto>
    {
        public CommentValidator(BaseCommentValidator baseValidator)
        {
            RuleFor(p => p)
                .SetValidator(baseValidator);
            RuleFor(p => p.GameId)
                .NotEmpty()
                    .WithMessage("Game id is required");
        }
    }

    public class SubCommentValidator : AbstractValidator<SubCommentDto>
    {
        public SubCommentValidator(BaseCommentValidator baseValidator)
        {
            RuleFor(p => p)
                .SetValidator(baseValidator);
            RuleFor(p => p.CommentId)
                .NotEmpty()
                    .WithMessage("Comment id is required");
        }
    }

    public class BaseCommentValidator : AbstractValidator<BaseCommentDto>
    {
        public BaseCommentValidator()
        {
            RuleFor(p => p.Description)
                .NotEmpty()
                   .WithMessage("Description is required");
        }
    }
}
