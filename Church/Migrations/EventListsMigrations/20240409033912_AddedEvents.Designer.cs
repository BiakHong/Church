﻿// <auto-generated />
using System;
using Church.Models.Events;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Church.Migrations.EventListsMigrations
{
    [DbContext(typeof(EventLists))]
    [Migration("20240409033912_AddedEvents")]
    partial class AddedEvents
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Church.Models.Events.Events", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EventHappened")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is the description for the first upcoming event.",
                            EndTime = new DateTime(2024, 4, 19, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7694),
                            EventHappened = false,
                            ImageUrl = "/images/event1.jpg",
                            StartTime = new DateTime(2024, 4, 18, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7581),
                            Title = "Upcoming Event 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is the description for the second upcoming event.",
                            EndTime = new DateTime(2024, 4, 29, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7702),
                            EventHappened = false,
                            ImageUrl = "/images/event2.jpg",
                            StartTime = new DateTime(2024, 4, 28, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7700),
                            Title = "Upcoming Event 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is the description for the third upcoming event.",
                            EndTime = new DateTime(2024, 6, 9, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7719),
                            EventHappened = false,
                            ImageUrl = "/images/event3.jpg",
                            StartTime = new DateTime(2024, 6, 8, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7705),
                            Title = "Upcoming Event 3"
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is the description for the first past event.",
                            EndTime = new DateTime(2024, 3, 30, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7724),
                            EventHappened = true,
                            ImageUrl = "/images/event4.jpg",
                            StartTime = new DateTime(2024, 3, 29, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7722),
                            Title = "Past Event 1"
                        },
                        new
                        {
                            Id = 5,
                            Description = "This is the description for the second past event.",
                            EndTime = new DateTime(2024, 3, 20, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7728),
                            EventHappened = true,
                            ImageUrl = "/images/event5.jpg",
                            StartTime = new DateTime(2024, 3, 19, 23, 39, 11, 353, DateTimeKind.Local).AddTicks(7726),
                            Title = "Past Event 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
