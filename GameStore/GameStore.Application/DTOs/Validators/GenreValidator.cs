using FluentValidation;
using GameStore.Application.DTOs.Genre;

namespace GameStore.Application.DTOs.Validators
{
    public class GenreValidator : AbstractValidator<GenreDTO>
    {
        public GenreValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                    .WithMessage("Valid genre name is required");
        }
    }
}
