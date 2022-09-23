using FluentValidation;
using GameStore.Application.DTOs.GameGenres.GameSubGenres;

namespace GameStore.Application.DTOs.Validators
{
    public class GameSubGenresValidator : AbstractValidator<GameSubGenresDTO>
    {
        public GameSubGenresValidator()
        {
            RuleFor(p => p.GameId)
                .NotEmpty()
                    .WithMessage("Game Id is required")
                .GreaterThan(0)
                    .WithMessage("Game Id cannot be less than or equal to 0");
            RuleFor(p => p.SubGenreId)
                .NotEmpty()
                    .WithMessage("Sub-genre Id is required")
                .GreaterThan(0)
                    .WithMessage("Sub-genre Id cannot be less than or equal to 0");
        }
    }
}
