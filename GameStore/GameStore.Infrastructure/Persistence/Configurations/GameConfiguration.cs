using GameStore.Domain.Entities;
using GameStore.Infrastructure.Persistence.Configurations.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.Property(p => p.Name)
                   .HasMaxLength(Constraints.MaxLength)
                   .IsRequired();
            builder.Property(p => p.Description)
                   .IsRequired();
            builder.Property(p => p.Price)
                   .HasColumnType(Constraints.DecimalType);
        }
    }
}
