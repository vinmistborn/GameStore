using GameStore.Domain.Entities;
using GameStore.Infrastructure.Persistence.Configurations.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ConfigureCommonGenreProperties();
            builder.HasData(SeedGenreEntity());
        }

        private Genre[] SeedGenreEntity()
        {
            return new Genre[]
            {
                new Genre
                {
                    Id = 1,
                    Name = "Strategy"
                },
                new Genre
                {
                    Id = 2,
                    Name = "RPG"
                },
                new Genre
                {
                    Id = 3,
                    Name = "Sports"
                },
                new Genre
                {
                    Id = 4,
                    Name = "Races"
                },
                new Genre
                {
                    Id = 5,
                    Name = "Action"
                },
                new Genre
                {
                    Id = 6,
                    Name = "Puzzle and skills"
                },
                new Genre
                {
                    Id = 7,
                    Name = "Adventure"
                },
            };
        }
    }
}
