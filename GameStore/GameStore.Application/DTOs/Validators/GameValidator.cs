using FluentValidation;
using GameStore.Application.DTOs.Game;

namespace GameStore.Application.DTOs.Validators
{
    public class GameValidator : AbstractValidator<GameDto>
    {
        public GameValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                    .WithMessage("Valid game name is required");
            RuleFor(p => p.Description)
                .NotEmpty()
                    .WithMessage("Valid game description is required");
            RuleFor(p => p.Price) 
                .NotEmpty()
                    .WithMessage("Game price is required")
                .GreaterThan(0)
                    .WithMessage("Game price cannot be less than or equal to 0");
        }
    }
}
