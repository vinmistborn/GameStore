using Ardalis.Specification;
using GameStore.Application.Contracts.Repositories;
using GameStore.Application.Contracts.Services;
using GameStore.Domain.Entities;
using GameStore.Infrastructure.Persistence;
using GameStore.Infrastructure.Persistence.Repositories;
using GameStore.Infrastructure.Services.Photo.Helpers;
using GameStore.Infrastructure.Services.Photo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<GameStoreDbContext>(options =>
                                    options.UseSqlServer(configuration.GetConnectionString("GameStore")));

            services.AddScoped<IRepositoryBase<Game>, GameRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IRepositoryBase<Genre>, GenreRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
            services.AddScoped<IRepositoryBase<GameGenres>, GameGenresRepository>();
            services.AddScoped<IGameGenresRepository, GameGenresRepository>();
            services.AddScoped<IRepositoryBase<SubGenre>, SubGenreRepository>();
            services.AddScoped<ISubGenreRepository, SubGenreRepository>();
            services.AddScoped<IRepositoryBase<GameSubGenres>, GameSubGenreRepository>();
            services.AddScoped<IGameSubGenresRepository, GameSubGenreRepository>();
            services.AddScoped<IRepositoryBase<Photo>, PhotoRepository>();

            services.Configure<CloudinarySettings>(configuration.GetSection("CloudinarySettings"));
            services.AddScoped<IPhotoService, PhotoService>();
            
            return services;
        }
    }
}
