using GameStore.Domain.Entities;
using GameStore.Infrastructure.Persistence.Configurations.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStore.Infrastructure.Persistence.Configurations
{
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.ConfigureCommonPhotoProperties();
            builder.Property(p => p.GameId)
                   .IsRequired();

            builder.HasData(SeedPhotoEntity());
        }

        private Photo[] SeedPhotoEntity()
        {
            return new Photo[]
            {
                new Photo
                {
                    Id = 1,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/witcher3_fvwqhx.jpg",
                    PublicId = "witcher3_fvwqhx",
                    GameId = 1
                },
                new Photo
                {
                    Id = 2,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/stalker_vkxa35.jpg",
                    PublicId = "stalker_vkxa35",
                    GameId = 2
                },
                new Photo
                {
                    Id = 3,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/theLastOfUs_i5pzt2.jpg",
                    PublicId = "theLastOfUs_i5pzt2",
                    GameId = 3
                },
                new Photo
                {
                    Id = 4,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/romeTotalWar_l2gsq4.jpg",
                    PublicId = "romeTotalWar_l2gsq4",
                    GameId = 4
                },
                new Photo
                {
                    Id = 5,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/needForSpeed_lnuuti.jpg",
                    PublicId = "needForSpeed_lnuuti",
                    GameId = 5
                },
                new Photo
                {
                    Id = 6,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/walkingDeadAlternative_ei6jzz.jpg",
                    PublicId = "walkingDeadAlternative_ei6jzz",
                    GameId = 6
                },
                new Photo
                {
                    Id = 7,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/callOfDuty_amvzib.jpg",
                    PublicId = "callOfDuty_amvzib",
                    GameId = 7
                },
                new Photo
                {
                    Id = 8,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/fifa22_hqcqmc.jpg",
                    PublicId = "fifa22_hqcqmc",
                    GameId = 8
                },
                new Photo
                {
                    Id = 9,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/angryBirds_mqqjd3.jpg",
                    PublicId = "angryBirds_mqqjd3",
                    GameId = 9
                },
                new Photo
                {
                    Id = 10,
                    Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553759/plantsVsZombies_lcmdic.jpg",
                    PublicId = "plantsVsZombies_lcmdic",
                    GameId = 10
                }
            };
        }
    }
}
