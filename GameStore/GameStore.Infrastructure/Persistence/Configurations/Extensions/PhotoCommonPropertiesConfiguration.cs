using GameStore.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations.Extensions
{
    public static class PhotoCommonPropertiesConfiguration
    {
        public static void ConfigureCommonPhotoProperties<T>(this EntityTypeBuilder<T> builder) where T : BasePhoto
        {
            builder.Property(p => p.PublicId)
                   .IsRequired();
            builder.Property(p => p.Url)
                   .IsRequired();
        }
    }
}
