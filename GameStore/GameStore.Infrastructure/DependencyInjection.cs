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
using Microsoft.AspNetCore.Identity;
using GameStore.Domain.Entities.Identity;
using GameStore.Infrastructure.Services.Identity;
using GameStore.Application.Contracts.Services.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using GameStore.Infrastructure.Persistence.Interceptors;
using StackExchange.Redis;

namespace GameStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<UpdateAuditableEntitiesInterceptor>();

            services.AddDbContext<GameStoreDbContext>((sp, options) =>
            {
                var interceptor = sp.GetService<UpdateAuditableEntitiesInterceptor>();
                options.UseSqlServer(configuration.GetConnectionString("GameStore"))
                       .AddInterceptors(interceptor);
            });

            services.AddSingleton<IConnectionMultiplexer>(c => 
            {
                var config = ConfigurationOptions.Parse(configuration
                      .GetConnectionString("Redis"), true);
                return ConnectionMultiplexer.Connect(config);
            });

            services.AddIdentity<User, Domain.Entities.Identity.Role>(options => 
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 9;
            })
            .AddEntityFrameworkStores<GameStoreDbContext>()
            .AddSignInManager<SignInManager<User>>()
            .AddDefaultTokenProviders();

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserService, UserService>();

            services.AddAuthentication(opt => {
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        RequireExpirationTime = true,
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = configuration["JwtSettings:Issuer"],
                        ValidAudience = configuration["JwtSettings:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                                           .GetBytes(configuration["JwtSettings:Key"]))
                    };
                });

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
            services.AddScoped<IRepositoryBase<UserPhoto>, UserPhotoRepository>();
            services.AddScoped<IReadRepositoryBase<Comment>, CommentRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IReadRepositoryBase<SubComment>, SubCommentRepository>();
            services.AddScoped<ISubCommentRepository, SubCommentRepository>();
            services.AddScoped<IBasketRepository, BasketRepository>();

            services.Configure<CloudinarySettings>(configuration.GetSection("CloudinarySettings"));
            services.AddScoped<IPhotoCloudService, PhotoCloudService>();
            
            return services;
        }
    }
}
