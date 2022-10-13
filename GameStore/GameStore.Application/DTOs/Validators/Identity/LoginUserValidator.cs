using FluentValidation;
using GameStore.Application.DTOs.Identity;

namespace GameStore.Application.DTOs.Validators.Identity
{
    public class LoginUserValidator : AbstractValidator<LoginDto>
    {
        public LoginUserValidator()
        {
            RuleFor(p => p.UserName)
                .NotEmpty()
                    .WithMessage("User name is required");
            RuleFor(p => p.Password)
                .NotEmpty()
                    .WithMessage("Password is required");
        }
    }
}
