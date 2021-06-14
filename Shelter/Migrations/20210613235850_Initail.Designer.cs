﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shelter.Models;

namespace Shelter.Migrations
{
    [DbContext(typeof(ShelterContext))]
    [Migration("20210613235850_Initail")]
    partial class Initail
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Shelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<bool>("Availible")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 15,
                            Availible = true,
                            Name = "John",
                            Sex = "Male",
                            Type = "cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 15,
                            Availible = false,
                            Name = "Robb",
                            Sex = "Male",
                            Type = "cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 11,
                            Availible = true,
                            Name = "Sansa",
                            Sex = "Female",
                            Type = "cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 7,
                            Availible = true,
                            Name = "Bran",
                            Sex = "Male",
                            Type = "cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 9,
                            Availible = true,
                            Name = "Arya",
                            Sex = "Female",
                            Type = "cat"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 3,
                            Availible = false,
                            Name = "Rickon",
                            Sex = "Male",
                            Type = "cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 1,
                            Availible = true,
                            Name = "Ghost",
                            Sex = "Male",
                            Type = "dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 1,
                            Availible = false,
                            Name = "Grey Wind",
                            Sex = "Male",
                            Type = "dog"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 1,
                            Availible = false,
                            Name = "Lady",
                            Sex = "Female",
                            Type = "dog"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 1,
                            Availible = true,
                            Name = "Nymeria",
                            Sex = "Female",
                            Type = "dog"
                        },
                        new
                        {
                            AnimalId = 11,
                            Age = 1,
                            Availible = false,
                            Name = "Summer",
                            Sex = "Male",
                            Type = "dog"
                        },
                        new
                        {
                            AnimalId = 12,
                            Age = 1,
                            Availible = false,
                            Name = "Shaggy Dog",
                            Sex = "Male",
                            Type = "dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
