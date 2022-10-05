using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class SubGenreConfiguration : IEntityTypeConfiguration<SubGenre>
    {
        public void Configure(EntityTypeBuilder<SubGenre> builder)
        {
            builder.Property(p => p.Name)
                   .IsRequired();
            builder.Property(p => p.GenreId)
                   .IsRequired();

            builder.HasData(SeedSubGenreEntity());
        }

        private SubGenre[] SeedSubGenreEntity()
        {
            return new SubGenre[]
            {
                new SubGenre
                {
                    Id = 1,
                    Name = "Rally",
                    GenreId = 1
                },
                new SubGenre
                {
                    Id = 2,
                    Name = "Arcade",
                    GenreId = 1
                },                
                new SubGenre
                {
                    Id = 3,
                    Name = "FPS",
                    GenreId = 5
                },
                new SubGenre
                {
                    Id = 4,
                    Name = "TPS",
                    GenreId = 5
                }
            };
        }
    }
}
