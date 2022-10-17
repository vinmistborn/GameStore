using FluentValidation;
using FluentValidation.AspNetCore;
using GameStore.Application.Common;
using GameStore.Application.Contracts.Services;
using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.Services;
using GameStore.Application.Services.Base;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace GameStore.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<,,>), typeof(GenericService<,,>));
            services.AddScoped(typeof(IGenericServiceWithSpecification<,,>), typeof(GenericServiceWithSpecification<,,>));
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IGenreService, GenreService>();
            services.AddScoped<IGameGenresService, GameGenresService>();
            services.AddScoped<ISubGenreService, SubGenreService>();
            services.AddScoped<IGameSubGenresService, GameSubGenresService>();

            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<IAssemblyMarker>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
