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
        }
    }
}
