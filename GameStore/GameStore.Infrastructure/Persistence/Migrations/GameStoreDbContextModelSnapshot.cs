﻿// <auto-generated />
using System;
using GameStore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameStore.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(GameStoreDbContext))]
    partial class GameStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameStore.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The game takes place in a fictional fantasy world based on Slavic mythology. Players control Geralt of Rivia, a monster slayer for hire known as a Witcher, and search for his adopted daughter, who is on the run from the otherworldly Wild Hunt.",
                            Name = "The Witcher 3: Wild Hunt",
                            Price = 24.99m
                        },
                        new
                        {
                            Id = 2,
                            Description = "The events of S.T.A.L.K.E.R.: Call of Pripyat unfold shortly after the end of S.T.A.L.K.E.R.: Shadow of Chernobyl. Having discovered about the open path to the Zone center, the government decides to hold a large-scale military 'Fairway' operation aimed to take the CNPP under control.",
                            Name = "S.T.A.L.K.E.R",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = 3,
                            Description = "In a ravaged civilization, where infected and hardened survivors run rampant, Joel, a weary protagonist, is hired to smuggle 14-year-old Ellie out of a military quarantine zone. However, what starts as a small job soon transforms into a brutal cross-country journey.",
                            Name = "The Last of Us Part I",
                            Price = 69.99m
                        },
                        new
                        {
                            Id = 4,
                            Description = "The game's main campaign takes place from 270 BC to 14 AD, showcasing the rise and final centuries of the Republican period and the early decades of the Imperial period of Ancient Rome.",
                            Name = "Rome: Total War",
                            Price = 59.99m
                        },
                        new
                        {
                            Id = 5,
                            Description = "The series generally centers around illicit street racing and tasks players to complete various types of races while evading the local law enforcement in police pursuits.",
                            Name = "Need For Speed",
                            Price = 39.99m
                        },
                        new
                        {
                            Id = 6,
                            Description = "The Walking Dead is a graphic adventure, played from a third-person perspective with a variety of cinematic camera angles, in which the player, as protagonist Lee Everett, works with a rag-tag group of survivors to stay alive in the midst of a zombie apocalypse.",
                            Name = "The Walking Dead",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Modern Warfare takes place in modern time, with the campaign occurring over the course of several days in late 2019, and the Special Ops and multiplayer modes continuing the story into 2020.",
                            Name = "Call of Duty: Modern Warfare",
                            Price = 59.99m
                        },
                        new
                        {
                            Id = 8,
                            Description = "FIFA 22 is a football simulation video game published by Electronic Arts. It is the 29th installment in the FIFA series, and was released worldwide on 1 October 2021 for Microsoft Windows, Nintendo Switch, PlayStation 4, PlayStation 5, Xbox One and Xbox Series X/S",
                            Name = "FIFA 22",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 9,
                            Description = "Angry Birds is a 2009 casual puzzle video game developed by Finnish video game developer Rovio Entertainment. Inspired primarily by a sketch of stylized wingless birds, the game was first released for iOS and Maemo devices starting in December 2009.",
                            Name = "Angry Birds",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = 10,
                            Description = "The player takes the role of a homeowner amid a zombie apocalypse. As a horde of zombies approaches along several parallel lanes, the player must defend the home by putting down plants, which fire projectiles at the zombies or otherwise detrimentally affect them.",
                            Name = "Plants Vs Zombies",
                            Price = 19.99m
                        });
                });

            modelBuilder.Entity("GameStore.Domain.Entities.GameGenres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("GenreId");

                    b.ToTable("GameGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            GenreId = 2
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            GenreId = 7
                        },
                        new
                        {
                            Id = 3,
                            GameId = 3,
                            GenreId = 7
                        },
                        new
                        {
                            Id = 4,
                            GameId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            Id = 5,
                            GameId = 5,
                            GenreId = 3
                        },
                        new
                        {
                            Id = 6,
                            GameId = 5,
                            GenreId = 4
                        },
                        new
                        {
                            Id = 7,
                            GameId = 6,
                            GenreId = 7
                        },
                        new
                        {
                            Id = 8,
                            GameId = 8,
                            GenreId = 3
                        },
                        new
                        {
                            Id = 9,
                            GameId = 9,
                            GenreId = 6
                        },
                        new
                        {
                            Id = 10,
                            GameId = 10,
                            GenreId = 1
                        });
                });

            modelBuilder.Entity("GameStore.Domain.Entities.GameSubGenres", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("SubGenreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("SubGenreId");

                    b.ToTable("GameSubGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            SubGenreId = 3
                        },
                        new
                        {
                            Id = 2,
                            GameId = 2,
                            SubGenreId = 3
                        },
                        new
                        {
                            Id = 3,
                            GameId = 7,
                            SubGenreId = 4
                        },
                        new
                        {
                            Id = 4,
                            GameId = 3,
                            SubGenreId = 4
                        });
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 2,
                            Name = "RPG"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Races"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Puzzle and skills"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Adventure"
                        });
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId")
                        .IsUnique();

                    b.ToTable("Photos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            PublicId = "witcher3_fvwqhx",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/witcher3_fvwqhx.jpg"
                        },
                        new
                        {
                            Id = 2,
                            GameId = 2,
                            PublicId = "stalker_vkxa35",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/stalker_vkxa35.jpg"
                        },
                        new
                        {
                            Id = 3,
                            GameId = 3,
                            PublicId = "theLastOfUs_i5pzt2",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/theLastOfUs_i5pzt2.jpg"
                        },
                        new
                        {
                            Id = 4,
                            GameId = 4,
                            PublicId = "romeTotalWar_l2gsq4",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/romeTotalWar_l2gsq4.jpg"
                        },
                        new
                        {
                            Id = 5,
                            GameId = 5,
                            PublicId = "needForSpeed_lnuuti",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/needForSpeed_lnuuti.jpg"
                        },
                        new
                        {
                            Id = 6,
                            GameId = 6,
                            PublicId = "walkingDeadAlternative_ei6jzz",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553760/walkingDeadAlternative_ei6jzz.jpg"
                        },
                        new
                        {
                            Id = 7,
                            GameId = 7,
                            PublicId = "callOfDuty_amvzib",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/callOfDuty_amvzib.jpg"
                        },
                        new
                        {
                            Id = 8,
                            GameId = 8,
                            PublicId = "fifa22_hqcqmc",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/fifa22_hqcqmc.jpg"
                        },
                        new
                        {
                            Id = 9,
                            GameId = 9,
                            PublicId = "angryBirds_mqqjd3",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664531819/angryBirds_mqqjd3.jpg"
                        },
                        new
                        {
                            Id = 10,
                            GameId = 10,
                            PublicId = "plantsVsZombies_lcmdic",
                            Url = "https://res.cloudinary.com/dbxbuj4wd/image/upload/v1664553759/plantsVsZombies_lcmdic.jpg"
                        });
                });

            modelBuilder.Entity("GameStore.Domain.Entities.SubComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("SubComments");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.SubGenre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("SubGenres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            Name = "Rally"
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 1,
                            Name = "Arcade"
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 5,
                            Name = "FPS"
                        },
                        new
                        {
                            Id = 4,
                            GenreId = 5,
                            Name = "TPS"
                        });
                });

            modelBuilder.Entity("GameStore.Domain.Entities.UserPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PublicId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserPhotos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Comment", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Game", "Game")
                        .WithMany("Comments")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.GameGenres", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Game", "Game")
                        .WithMany("GameGenres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameStore.Domain.Entities.Genre", "Genre")
                        .WithMany("GameGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.GameSubGenres", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Game", "Game")
                        .WithMany("GameSubGenres")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameStore.Domain.Entities.SubGenre", "SubGenre")
                        .WithMany("GameSubGenres")
                        .HasForeignKey("SubGenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("SubGenre");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Photo", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Game", "Game")
                        .WithOne("Photo")
                        .HasForeignKey("GameStore.Domain.Entities.Photo", "GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.SubComment", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Comment", "Comment")
                        .WithMany("SubComments")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.SubGenre", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Genre", "Genre")
                        .WithMany("SubGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.UserPhoto", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Identity.User", "User")
                        .WithOne("Photo")
                        .HasForeignKey("GameStore.Domain.Entities.UserPhoto", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Identity.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameStore.Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("GameStore.Domain.Entities.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Comment", b =>
                {
                    b.Navigation("SubComments");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Game", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("GameGenres");

                    b.Navigation("GameSubGenres");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Genre", b =>
                {
                    b.Navigation("GameGenres");

                    b.Navigation("SubGenres");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.Identity.User", b =>
                {
                    b.Navigation("Photo");
                });

            modelBuilder.Entity("GameStore.Domain.Entities.SubGenre", b =>
                {
                    b.Navigation("GameSubGenres");
                });
#pragma warning restore 612, 618
        }
    }
}
