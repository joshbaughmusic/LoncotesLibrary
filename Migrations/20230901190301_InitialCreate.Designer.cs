﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    [DbContext(typeof(LoncotesLibraryDbContext))]
    [Migration("20230901190301_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LoncotesLibrary.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CheckoutDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("MaterialId")
                        .HasColumnType("integer");

                    b.Property<int>("PatronId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MaterialId");

                    b.HasIndex("PatronId");

                    b.ToTable("Checkouts");
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Metal"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Thriller"
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GenreId")
                        .HasColumnType("integer");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MaterialTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("OutOfCirculationSince")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("MaterialTypeId");

                    b.ToTable("Materials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GenreId = 1,
                            MaterialName = "1984",
                            MaterialTypeId = 1,
                            OutOfCirculationSince = new DateTime(1989, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            GenreId = 2,
                            MaterialName = "The Lord of the Rings",
                            MaterialTypeId = 1,
                            OutOfCirculationSince = new DateTime(2005, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            GenreId = 3,
                            MaterialName = "The Matrix",
                            MaterialTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            GenreId = 4,
                            MaterialName = "The Shining",
                            MaterialTypeId = 1,
                            OutOfCirculationSince = new DateTime(1992, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            GenreId = 5,
                            MaterialName = "Pulp Fiction",
                            MaterialTypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            GenreId = 1,
                            MaterialName = "The Catcher in the Rye",
                            MaterialTypeId = 1,
                            OutOfCirculationSince = new DateTime(2002, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            GenreId = 2,
                            MaterialName = "Blade Runner",
                            MaterialTypeId = 2
                        },
                        new
                        {
                            Id = 8,
                            GenreId = 3,
                            MaterialName = "1984",
                            MaterialTypeId = 3,
                            OutOfCirculationSince = new DateTime(1995, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            GenreId = 4,
                            MaterialName = "Brave New World",
                            MaterialTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            GenreId = 5,
                            MaterialName = "Star Wars: A New Hope",
                            MaterialTypeId = 2,
                            OutOfCirculationSince = new DateTime(2007, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            GenreId = 1,
                            MaterialName = "Master of Puppets",
                            MaterialTypeId = 3
                        },
                        new
                        {
                            Id = 12,
                            GenreId = 2,
                            MaterialName = "The Hobbit",
                            MaterialTypeId = 1
                        },
                        new
                        {
                            Id = 13,
                            GenreId = 3,
                            MaterialName = "The Terminator",
                            MaterialTypeId = 2,
                            OutOfCirculationSince = new DateTime(1998, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14,
                            GenreId = 4,
                            MaterialName = "Ride the Lightning",
                            MaterialTypeId = 3
                        },
                        new
                        {
                            Id = 15,
                            GenreId = 5,
                            MaterialName = "Jurassic Park",
                            MaterialTypeId = 1,
                            OutOfCirculationSince = new DateTime(2004, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.MaterialType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CheckoutDays")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MaterialTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CheckoutDays = 14,
                            Name = "Book"
                        },
                        new
                        {
                            Id = 2,
                            CheckoutDays = 3,
                            Name = "Movie"
                        },
                        new
                        {
                            Id = 3,
                            CheckoutDays = 7,
                            Name = "CD"
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Patron", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Patrons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            Email = "johndoe@example.com",
                            FirstName = "John",
                            IsActive = true,
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm St",
                            Email = "alicesmith@example.com",
                            FirstName = "Alice",
                            IsActive = true,
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Oak St",
                            Email = "bobjohnson@example.com",
                            FirstName = "Bob",
                            IsActive = false,
                            LastName = "Johnson"
                        },
                        new
                        {
                            Id = 4,
                            Address = "101 Pine St",
                            Email = "emilywilson@example.com",
                            FirstName = "Emily",
                            IsActive = true,
                            LastName = "Wilson"
                        },
                        new
                        {
                            Id = 5,
                            Address = "222 Cedar St",
                            Email = "michaeldavis@example.com",
                            FirstName = "Michael",
                            IsActive = false,
                            LastName = "Davis"
                        });
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Checkout", b =>
                {
                    b.HasOne("LoncotesLibrary.Models.Material", "material")
                        .WithMany("Checkouts")
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoncotesLibrary.Models.Patron", "patron")
                        .WithMany("Checkouts")
                        .HasForeignKey("PatronId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("material");

                    b.Navigation("patron");
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Material", b =>
                {
                    b.HasOne("LoncotesLibrary.Models.Genre", "genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LoncotesLibrary.Models.MaterialType", "materialType")
                        .WithMany()
                        .HasForeignKey("MaterialTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("genre");

                    b.Navigation("materialType");
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Material", b =>
                {
                    b.Navigation("Checkouts");
                });

            modelBuilder.Entity("LoncotesLibrary.Models.Patron", b =>
                {
                    b.Navigation("Checkouts");
                });
#pragma warning restore 612, 618
        }
    }
}
