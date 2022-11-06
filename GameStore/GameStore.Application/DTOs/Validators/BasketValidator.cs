using FluentValidation;
using GameStore.Application.DTOs.Basket;

namespace GameStore.Application.DTOs.Validators
{
    public class BasketValidator : AbstractValidator<BasketDto>
    {
        public BasketValidator()
        {
            RuleFor(p => p.Id)
                .NotEmpty()
                    .WithMessage("Basket id is required");
        }
    }
}
