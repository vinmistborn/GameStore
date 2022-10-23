using GameStore.Domain.Entities;
using GameStore.Infrastructure.Persistence.Configurations.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class SubCommentConfiguration : IEntityTypeConfiguration<SubComment>
    {
        public void Configure(EntityTypeBuilder<SubComment> builder)
        {
            builder.ConfigureCommonCommentProperties();
            builder.Property(p => p.CommentId)
                   .IsRequired();
        }
    }
}
