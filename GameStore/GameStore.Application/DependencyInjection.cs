using FluentValidation;
using FluentValidation.AspNetCore;
using GameStore.Application.Common;
using GameStore.Application.Contracts.Services;
using GameStore.Application.Contracts.Services.Base;
using GameStore.Application.DTOs.Comment;
using GameStore.Application.DTOs.Comment.SubComment;
using GameStore.Application.Services;
using GameStore.Application.Services.Base;
using GameStore.Domain.Entities;
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
            services.AddScoped<IBaseCommentService<CommentDto, CommentInfoDto, Comment>, CommentService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ISubCommentService, SubCommentService>();
            services.AddScoped<IBaseCommentService<SubCommentDto, SubCommentInfoDto, SubComment>, SubCommentService>();
            services.AddScoped<IBasketService, BasketService>();

            services.AddFluentValidationAutoValidation();
            services.AddValidatorsFromAssemblyContaining<IAssemblyMarker>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
