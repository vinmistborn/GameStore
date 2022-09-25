using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.Property(p => p.PublicId)
                   .IsRequired();
            builder.Property(p => p.Url)
                   .IsRequired();
            builder.Property(p => p.GameId)
                   .IsRequired();
        }
    }
}
