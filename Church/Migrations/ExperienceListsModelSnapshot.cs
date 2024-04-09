﻿// <auto-generated />
using System;
using Church.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Church.Migrations
{
    [DbContext(typeof(ExperienceLists))]
    partial class ExperienceListsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Church.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExperienceTexts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 4, 3, 17, 21, 44, 521, DateTimeKind.Local).AddTicks(8337),
                            ExperienceTexts = "The people are very welcoming and nice.",
                            Name = "Tedd"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 4, 3, 17, 21, 44, 521, DateTimeKind.Local).AddTicks(8389),
                            ExperienceTexts = "I feel the present of God in this church.",
                            Name = "Mike"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 4, 3, 17, 21, 44, 521, DateTimeKind.Local).AddTicks(8394),
                            ExperienceTexts = "Worship team are so so good.",
                            Name = "John"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
