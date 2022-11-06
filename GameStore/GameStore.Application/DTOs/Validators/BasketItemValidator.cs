using FluentValidation;
using GameStore.Application.DTOs.Basket;

namespace GameStore.Application.DTOs.Validators
{
    public class BasketItemValidator : AbstractValidator<BasketItemDto>
    {
        public BasketItemValidator()
        {
            RuleFor(p => p.Id)
                .NotEmpty()
                    .WithMessage("Item id is required");
            RuleFor(p => p.GameName)
                .NotEmpty()
                    .WithMessage("Game name is required");
            RuleFor(p => p.Price)
                .NotEmpty()
                    .WithMessage("Picture url is required");
            RuleFor(p => p.Price)
                .NotEmpty()
                    .WithMessage("Price is required")
                .GreaterThan(0)
                    .WithMessage("Price should be a valid number");
            RuleFor(p => p.Quantity)
                .NotEmpty()
                    .WithMessage("Quantity is required")
                .GreaterThan(0)
                    .WithMessage("Quantity should be a valid number");
        }
    }
}
