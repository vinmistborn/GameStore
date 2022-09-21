using FluentValidation;
using GameStore.Application.DTOs.GameGenres;

namespace GameStore.Application.DTOs.Validators
{
    public class GameGenresValidator : AbstractValidator<GameGenresDTO>
    {
        public GameGenresValidator()
        {
            RuleFor(p => p.GameId)
                .NotEmpty()
                    .WithMessage("Game Id is required")
                .GreaterThan(0)
                    .WithMessage("Game Id cannot be less than or equal to 0");
            RuleFor(p => p.GenreId)
                .NotEmpty()
                    .WithMessage("Genre Id is required")
                .GreaterThan(0)
                    .WithMessage("Genre Id cannot be less than or equal to 0");
        }
    }
}
