using FluentValidation;
using GameStore.Application.DTOs.Genre;

namespace GameStore.Application.DTOs.Validators
{
    public class SubGenreValidator : AbstractValidator<SubGenreDto>
    {
        public SubGenreValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty();
            RuleFor(p => p.GenreId)
                .NotEmpty();
        }
    }
}
