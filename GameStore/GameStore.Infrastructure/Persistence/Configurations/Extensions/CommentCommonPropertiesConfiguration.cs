using GameStore.Domain.Entities.Base;
using GameStore.Infrastructure.Persistence.Configurations.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations.Extensions
{
    public static class CommentCommonPropertiesConfiguration
    {
        public static void ConfigureCommonCommentProperties<T>(this EntityTypeBuilder<T> builder) where T : BaseComment
        {
            builder.Property(p => p.Description)
                   .HasMaxLength(Constraints.CommentMaxLength)
                   .IsRequired();
            builder.Property(p => p.IsDeleted)
                   .HasDefaultValue(false);
        }
    }
}
