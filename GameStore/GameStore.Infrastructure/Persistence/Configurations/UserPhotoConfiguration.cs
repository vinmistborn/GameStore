using GameStore.Domain.Entities;
using GameStore.Infrastructure.Persistence.Configurations.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class UserPhotoConfiguration : IEntityTypeConfiguration<UserPhoto>
    {
        public void Configure(EntityTypeBuilder<UserPhoto> builder)
        {
            builder.ConfigureCommonPhotoProperties();
            builder.Property(p => p.UserId)
                   .IsRequired();
        }
    }
}
