using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class UserPhotoConfiguration : IEntityTypeConfiguration<UserPhoto>
    {
        public void Configure(EntityTypeBuilder<UserPhoto> builder)
        {
            builder.Property(p => p.PublicId)
                   .IsRequired();
            builder.Property(p => p.Url)
                   .IsRequired();
            builder.Property(p => p.UserId)
                   .IsRequired();
        }
    }
}
