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
        }
    }
}
