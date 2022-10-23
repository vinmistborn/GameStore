using GameStore.Domain.Entities;
using GameStore.Infrastructure.Persistence.Configurations.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class GameGenresConfiguration : IEntityTypeConfiguration<GameGenres>
    {
        public void Configure(EntityTypeBuilder<GameGenres> builder)
        {
            builder.ConfigureCommonGameGenresProperties();
            builder.Property(p => p.GenreId)
                   .IsRequired();

            builder.HasData(SeedGameGenresEntity());
        }

        private GameGenres[] SeedGameGenresEntity()
        {
            return new GameGenres[]
            {
                new GameGenres
                {
                    Id = 1,
                    GameId = 1,
                    GenreId = 2
                },               
                new GameGenres
                {
                    Id = 2,
                    GameId = 1,
                    GenreId = 7
                },               
                new GameGenres
                {
                    Id = 3,
                    GameId = 3,
                    GenreId = 7
                },
                new GameGenres
                {
                    Id = 4,
                    GameId = 4,
                    GenreId = 1
                },
                new GameGenres
                {
                    Id = 5,
                    GameId = 5,
                    GenreId = 3
                },
                new GameGenres
                {
                    Id = 6,
                    GameId = 5,
                    GenreId = 4
                },
                new GameGenres
                {
                    Id = 7,
                    GameId = 6,
                    GenreId = 7
                },
                new GameGenres
                {
                    Id = 8,
                    GameId = 8,
                    GenreId = 3
                },
                new GameGenres
                {
                    Id = 9,
                    GameId = 9,
                    GenreId = 6
                },
                new GameGenres
                {
                    Id = 10,
                    GameId = 10,
                    GenreId = 1
                }
            };
        }
    }
}
