using Microsoft.EntityFrameworkCore.Migrations;

namespace GameStore.Infrastructure.Persistence.Migrations
{
    public partial class SeedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "The game takes place in a fictional fantasy world based on Slavic mythology. Players control Geralt of Rivia, a monster slayer for hire known as a Witcher, and search for his adopted daughter, who is on the run from the otherworldly Wild Hunt.", "The Witcher 3: Wild Hunt", 24.99m },
                    { 10, "The player takes the role of a homeowner amid a zombie apocalypse. As a horde of zombies approaches along several parallel lanes, the player must defend the home by putting down plants, which fire projectiles at the zombies or otherwise detrimentally affect them.", "Plants Vs Zombies", 19.99m },
                    { 8, "FIFA 22 is a football simulation video game published by Electronic Arts. It is the 29th installment in the FIFA series, and was released worldwide on 1 October 2021 for Microsoft Windows, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox One and Xbox Series X/S", "FIFA 22", 49.99m },
                    { 7, "Modern Warfare takes place in modern time, with the campaign occurring over the course of several days in late 2019, and the Special Ops and multiplayer modes continuing the story into 2020.", "Call of Duty: Modern Warfare", 59.99m },
                    { 6, "The Walking Dead is a graphic adventure, played from a third-person perspective with a variety of cinematic camera angles, in which the player, as protagonist Lee Everett, works with a rag-tag group of survivors to stay alive in the midst of a zombie apocalypse.", "The Walking Dead", 49.99m },
                    { 9, "Angry Birds is a 2009 casual puzzle video game developed by Finnish video game developer Rovio Entertainment. Inspired primarily by a sketch of stylized wingless birds, the game was first released for iOS and Maemo devices starting in December 2009.", "Angry Birds", 19.99m },
                    { 4, "The game's main campaign takes place from 270 BC to 14 AD, showcasing the rise and final centuries of the Republican period and the early decades of the Imperial period of Ancient Rome.", "Rome: Total War", 59.99m },
                    { 3, "In a ravaged civilization, where infected and hardened survivors run rampant, Joel, a weary protagonist, is hired to smuggle 14-year-old Ellie out of a military quarantine zone. However, what starts as a small job soon transforms into a brutal cross-country journey.", "The Last of Us Part I", 69.99m },
                    { 2, "The events of S.T.A.L.K.E.R.: Call of Pripyat unfold shortly after the end of S.T.A.L.K.E.R.: Shadow of Chernobyl. Having discovered about the open path to the Zone center, the government decides to hold a large-scale military 'Fairway' operation aimed to take the CNPP under control.", "S.T.A.L.K.E.R", 19.99m },
                    { 5, "The series generally centers around illicit street racing and tasks players to complete various types of races while evading the local law enforcement in police pursuits.", "Need For Speed", 39.99m }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Puzzle and skills" },
                    { 1, "Strategy" },
                    { 2, "RPG" },
                    { 3, "Sports" },
                    { 4, "Races" },
                    { 5, "Action" },
                    { 7, "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "GameGenres",
                columns: new[] { "Id", "GameId", "GenreId" },
                values: new object[,]
                {
                    { 10, 10, 1 },
                    { 2, 1, 7 },
                    { 9, 9, 6 },
                    { 6, 5, 4 },
                    { 8, 8, 3 },
                    { 5, 5, 3 },
                    { 1, 1, 2 },
                    { 3, 3, 7 },
                    { 4, 4, 1 },
                    { 7, 6, 7 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "GameId", "PublicId", "Url" },
                values: new object[,]
                {
                    { 9, 9, "angryBirds_mqqjd3", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/angryBirds_mqqjd3.jpg" },
                    { 8, 8, "fifa22_hqcqmc", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/fifa22_hqcqmc.jpg" },
                    { 7, 7, "callOfDuty_amvzib", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/callOfDuty_amvzib.jpg" },
                    { 6, 6, "walkingDeadAlternative_ei6jzz", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/walkingDeadAlternative_ei6jzz.jpg" },
                    { 5, 5, "needForSpeed_lnuuti", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/needForSpeed_lnuuti.jpg" },
                    { 4, 4, "romeTotalWar_l2gsq4", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/romeTotalWar_l2gsq4.jpg" },
                    { 3, 3, "theLastOfUs_i5pzt2", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/theLastOfUs_i5pzt2.jpg" },
                    { 2, 2, "stalker_vkxa35", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/stalker_vkxa35.jpg" },
                    { 10, 10, "plantsVsZombies_lcmdic", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553759/plantsVsZombies_lcmdic.jpg" },
                    { 1, 1, "witcher3_fvwqhx", "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/witcher3_fvwqhx.jpg" }
                });

            migrationBuilder.InsertData(
                table: "SubGenres",
                columns: new[] { "Id", "GenreId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Rally" },
                    { 2, 1, "Arcade" },
                    { 3, 5, "FPS" },
                    { 4, 5, "TPS" }
                });

            migrationBuilder.InsertData(
                table: "GameSubGenres",
                columns: new[] { "Id", "GameId", "SubGenreId" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 2, 3 },
                    { 3, 7, 4 },
                    { 4, 3, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GameGenres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GameSubGenres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameSubGenres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameSubGenres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameSubGenres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubGenres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
