﻿// <auto-generated />
using Beer.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Beer.Repository.Migrations
{
    [DbContext(typeof(BeerDBContext))]
    partial class BeerDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Beer.Models.BeerModel", b =>
                {
                    b.Property<int>("BeerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AverageRatings");

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("BeerId");

                    b.ToTable("Beers");

                    b.HasData(
                        new
                        {
                            BeerId = 1,
                            AverageRatings = 0m,
                            Name = "Three Floyds Zombie Dust",
                            Type = "Pale Ale"
                        },
                        new
                        {
                            BeerId = 2,
                            AverageRatings = 0m,
                            Name = "Sierra Nevada Pale Ale",
                            Type = "Pale Ale"
                        },
                        new
                        {
                            BeerId = 3,
                            AverageRatings = 0m,
                            Name = "DRY IRISH STOUT ",
                            Type = "Stout"
                        },
                        new
                        {
                            BeerId = 4,
                            AverageRatings = 0m,
                            Name = "MILK STOUT",
                            Type = "Stout"
                        });
                });

            modelBuilder.Entity("Beer.Models.RatingsModel", b =>
                {
                    b.Property<int>("RatingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BeerId");

                    b.Property<int>("Ratings");

                    b.HasKey("RatingId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            RatingId = 1,
                            BeerId = 1,
                            Ratings = 5
                        },
                        new
                        {
                            RatingId = 2,
                            BeerId = 1,
                            Ratings = 5
                        },
                        new
                        {
                            RatingId = 3,
                            BeerId = 1,
                            Ratings = 5
                        },
                        new
                        {
                            RatingId = 4,
                            BeerId = 1,
                            Ratings = 5
                        },
                        new
                        {
                            RatingId = 5,
                            BeerId = 1,
                            Ratings = 3
                        },
                        new
                        {
                            RatingId = 6,
                            BeerId = 2,
                            Ratings = 5
                        },
                        new
                        {
                            RatingId = 7,
                            BeerId = 2,
                            Ratings = 5
                        },
                        new
                        {
                            RatingId = 8,
                            BeerId = 3,
                            Ratings = 5
                        },
                        new
                        {
                            RatingId = 9,
                            BeerId = 4,
                            Ratings = 4
                        },
                        new
                        {
                            RatingId = 10,
                            BeerId = 4,
                            Ratings = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
