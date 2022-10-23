using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations.Extensions
{
    public static class GenreCommonPropertiesConfiguration
    {
        public static void ConfigureCommonGenreProperties<T>(this EntityTypeBuilder<T> builder) where T : BaseGenre
        {
            builder.Property(p => p.Name)
                   .IsRequired();
        }
    }
}
