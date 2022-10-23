using GameStore.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations.Extensions
{
    public static class GameGenresCommonPropertiesConfiguration
    {
        public static void ConfigureCommonGameGenresProperties<T>(this EntityTypeBuilder<T> builder) where T : BaseGameGenres
        {
            builder.Property(p => p.GameId)
                   .IsRequired();
        }
    }
}
