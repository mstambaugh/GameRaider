﻿// <auto-generated />
using GameRaider.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameRaider.Migrations
{
    [DbContext(typeof(GameRaiderContext))]
    [Migration("20191029180929_ReviewClass")]
    partial class ReviewClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GameRaider.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Raiding");

                    b.Property<string>("ReleaseDate");

                    b.Property<string>("Studio");

                    b.Property<string>("Title");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = 1,
                            Raiding = 5,
                            ReleaseDate = "2011",
                            Studio = "Bethesda",
                            Title = "Skyrim"
                        },
                        new
                        {
                            GameId = 2,
                            Raiding = 5,
                            ReleaseDate = "2018",
                            Studio = "Rockstar",
                            Title = "Red Dead Redemtion 2"
                        },
                        new
                        {
                            GameId = 3,
                            Raiding = 2,
                            ReleaseDate = "2019",
                            Studio = "id Software",
                            Title = "Wolfenstein Youngblood"
                        },
                        new
                        {
                            GameId = 4,
                            Raiding = 4,
                            ReleaseDate = "2015",
                            Studio = "FromSoftware",
                            Title = "Bloodborne"
                        },
                        new
                        {
                            GameId = 5,
                            Raiding = 3,
                            ReleaseDate = "2013",
                            Studio = "Ghost Games",
                            Title = "Need for Speed Rivals"
                        },
                        new
                        {
                            GameId = 6,
                            Raiding = 1,
                            ReleaseDate = "2002",
                            Studio = "Nintendo",
                            Title = "Mario Sunshine"
                        });
                });

            modelBuilder.Entity("GameRaider.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GameId");

                    b.Property<string>("PublishDate");

                    b.Property<int>("Raiding");

                    b.Property<string>("ReviewAuthor");

                    b.Property<string>("ReviewText");

                    b.HasKey("ReviewId");

                    b.HasIndex("GameId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            GameId = 2,
                            PublishDate = "October 26, 2019",
                            Raiding = 5,
                            ReviewAuthor = "BeffJezos666",
                            ReviewText = "The worlding building in this game is on a whole new level, bro. It is so big, so detailed, and I get to be a cowboy and ride my horse, Whitneigh Horsten, all over town"
                        },
                        new
                        {
                            ReviewId = 2,
                            GameId = 1,
                            PublishDate = "February 26, 2015",
                            Raiding = 2,
                            ReviewAuthor = "RunDMC123",
                            ReviewText = "It is the incapable younger brother of Morrowind, but nonetheless I played it"
                        },
                        new
                        {
                            ReviewId = 3,
                            GameId = 3,
                            PublishDate = "May 1, 2002",
                            Raiding = 2,
                            ReviewAuthor = "TaylorLautner420",
                            ReviewText = "This game sucked bro"
                        });
                });

            modelBuilder.Entity("GameRaider.Models.Review", b =>
                {
                    b.HasOne("GameRaider.Models.Game", "Game")
                        .WithMany("Reviews")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
