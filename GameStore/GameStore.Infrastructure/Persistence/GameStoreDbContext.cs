using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GameStore.Infrastructure.Persistence
{
    public class GameStoreDbContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
