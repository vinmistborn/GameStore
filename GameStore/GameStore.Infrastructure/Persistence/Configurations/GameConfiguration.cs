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

            builder.HasData(SeedGameEntity());
        }

        private Game[] SeedGameEntity()
        {
            return new Game[]
            {
                new Game
                {
                    Id = 1,
                    Name = "The Witcher 3: Wild Hunt",
                    Description = "The game takes place in a fictional fantasy world based on Slavic mythology. Players control Geralt of Rivia, a monster slayer for hire known as a Witcher, and search for his adopted daughter, who is on the run from the otherworldly Wild Hunt.",
                    Price = 24.99M
                },
                new Game
                {
                    Id = 2,
                    Name = "S.T.A.L.K.E.R",
                    Description = "The events of S.T.A.L.K.E.R.: Call of Pripyat unfold shortly after the end of S.T.A.L.K.E.R.: Shadow of Chernobyl. Having discovered about the open path to the Zone center, the government decides to hold a large-scale military 'Fairway' operation aimed to take the CNPP under control.",
                    Price = 19.99M
                },
                new Game
                {
                    Id = 3,
                    Name = "The Last of Us Part I",
                    Description = "In a ravaged civilization, where infected and hardened survivors run rampant, Joel, a weary protagonist, is hired to smuggle 14-year-old Ellie out of a military quarantine zone. However, what starts as a small job soon transforms into a brutal cross-country journey.",
                    Price = 69.99M
                },
                new Game
                {
                    Id = 4,
                    Name = "Rome: Total War",
                    Description = "The game's main campaign takes place from 270 BC to 14 AD, showcasing the rise and final centuries of the Republican period and the early decades of the Imperial period of Ancient Rome.",
                    Price = 59.99M
                },
                new Game
                {
                    Id = 5,
                    Name = "Need For Speed",
                    Description = "The series generally centers around illicit street racing and tasks players to complete various types of races while evading the local law enforcement in police pursuits.",
                    Price = 39.99M
                },
                new Game
                {
                    Id = 6,
                    Name = "The Walking Dead",
                    Description = "The Walking Dead is a graphic adventure, played from a third-person perspective with a variety of cinematic camera angles, in which the player, as protagonist Lee Everett, works with a rag-tag group of survivors to stay alive in the midst of a zombie apocalypse.",
                    Price = 49.99M
                },
                new Game
                {
                    Id = 7,
                    Name = "Call of Duty: Modern Warfare",
                    Description = "Modern Warfare takes place in modern time, with the campaign occurring over the course of several days in late 2019, and the Special Ops and multiplayer modes continuing the story into 2020.",
                    Price = 59.99M
                },
                new Game
                {
                    Id = 8,
                    Name = "FIFA 22",
                    Description = "FIFA 22 is a football simulation video game published by Electronic Arts. It is the 29th installment in the FIFA series, and was released worldwide on 1 October 2021 for Microsoft Windows, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox One and Xbox Series X/S",
                    Price = 49.99M
                },
                new Game
                {
                    Id = 9,
                    Name = "Angry Birds",
                    Description = "Angry Birds is a 2009 casual puzzle video game developed by Finnish video game developer Rovio Entertainment. Inspired primarily by a sketch of stylized wingless birds, the game was first released for iOS and Maemo devices starting in December 2009.",
                    Price = 19.99M
                },
                new Game
                {
                    Id = 10,
                    Name = "Plants Vs Zombies",
                    Description = "The player takes the role of a homeowner amid a zombie apocalypse. As a horde of zombies approaches along several parallel lanes, the player must defend the home by putting down plants, which fire projectiles at the zombies or otherwise detrimentally affect them.",
                    Price = 19.99M
                }
            };
        }
    }
}
