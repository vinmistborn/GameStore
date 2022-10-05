using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class GameSubGenresConfiguration : IEntityTypeConfiguration<GameSubGenres>
    {
        public void Configure(EntityTypeBuilder<GameSubGenres> builder)
        {
            builder.Property(p => p.GameId)
                   .IsRequired();
            builder.Property(p => p.SubGenreId)
                   .IsRequired();

            builder.HasData(SeedGameSubGenresEntity());
        }

        private GameSubGenres[] SeedGameSubGenresEntity()
        {
            return new GameSubGenres[]
            {
                new GameSubGenres
                {
                    Id = 1,
                    GameId = 1,
                    SubGenreId = 3
                },
                new GameSubGenres
                {
                    Id = 2,
                    GameId = 2,
                    SubGenreId = 3
                },
                new GameSubGenres
                {
                    Id = 3,
                    GameId = 7,
                    SubGenreId = 4
                },
                new GameSubGenres
                {
                    Id = 4,
                    GameId = 3,
                    SubGenreId = 4
                }
            };
        }
    }
}
