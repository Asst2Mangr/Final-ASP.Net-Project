﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project4.Models;

#nullable disable

namespace Project4.Migrations
{
    [DbContext(typeof(DeckContext))]
    partial class DeckContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project4.Models.Deck", b =>
                {
                    b.Property<int>("DeckID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeckID"));

                    b.Property<int>("DeckCount")
                        .HasColumnType("int");

                    b.Property<string>("DeckName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeckID");

                    b.ToTable("Decks");

                    b.HasData(
                        new
                        {
                            DeckID = 1,
                            DeckCount = 78,
                            DeckName = "Rider-Waite Tarot"
                        },
                        new
                        {
                            DeckID = 2,
                            DeckCount = 52,
                            DeckName = "Standard"
                        },
                        new
                        {
                            DeckID = 3,
                            DeckCount = 100,
                            DeckName = "another one"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
