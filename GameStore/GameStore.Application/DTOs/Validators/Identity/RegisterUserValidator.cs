using FluentValidation;
using GameStore.Application.DTOs.Identity;

namespace GameStore.Application.DTOs.Validators.Identity
{
    public class RegisterUserValidator : AbstractValidator<RegisterDto>
    {
        public RegisterUserValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty()
                    .WithMessage("First name is required");
            RuleFor(p => p.LastName)
                .NotEmpty()
                    .WithMessage("Last name is required");
            RuleFor(p => p.UserName)
                .NotEmpty()
                    .WithMessage("User name is required");
            RuleFor(p => p.Email)
                .NotEmpty()
                    .WithMessage("Email is required")
                .EmailAddress();
            RuleFor(p => p.Password)
                .NotEmpty()
                    .WithMessage("Password is required");
        }
    }
}
