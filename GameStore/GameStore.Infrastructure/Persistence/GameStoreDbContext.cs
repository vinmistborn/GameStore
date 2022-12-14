using GameStore.Domain.Entities;
using GameStore.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GameStore.Infrastructure.Persistence
{
    public class GameStoreDbContext : IdentityDbContext<User, Role, int>
    {
        public GameStoreDbContext(DbContextOptions<GameStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GameGenres> GameGenres { get; set; }
        public DbSet<SubGenre> SubGenres { get; set; }
        public DbSet<GameSubGenres> GameSubGenres { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<UserPhoto> UserPhotos { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<SubComment> SubComments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
