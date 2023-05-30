﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_demo_1.DAL.Data;

#nullable disable

namespace project_demo_1.Migrations
{
    [DbContext(typeof(ContextFile))]
    [Migration("20230530080326_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("project_demo_1.DAL.Models.Epics", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("CompletedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProjectCode")
                        .HasColumnType("int");

                    b.Property<int>("SprintId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("EpicsS");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            CompletedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            Name = "stig0",
                            ProjectCode = 20,
                            SprintId = 30,
                            Status = "InProgress"
                        },
                        new
                        {
                            Id = 11,
                            CompletedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            Name = "stig1",
                            ProjectCode = 21,
                            SprintId = 31,
                            Status = "InProgress"
                        },
                        new
                        {
                            Id = 12,
                            CompletedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            Name = "stig2",
                            ProjectCode = 22,
                            SprintId = 32,
                            Status = "InProgress"
                        });
                });

            modelBuilder.Entity("project_demo_1.DAL.Models.UserStories", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("AcceptanceCriteria")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("AssignedToDeveloperId")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DoneOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpicsId")
                        .HasColumnType("int");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("StoryPoints")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserStoriesDetails")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("EpicsId");

                    b.ToTable("UserStoriesS");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            AcceptanceCriteria = "rand",
                            AssignedToDeveloperId = "dev0",
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            DoneOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            EpicsId = 10,
                            Priority = "1",
                            Status = "New",
                            StoryPoints = 3,
                            Title = "us100",
                            UserStoriesDetails = "us00details"
                        },
                        new
                        {
                            Id = 101,
                            AcceptanceCriteria = "rand",
                            AssignedToDeveloperId = "dev3",
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            DoneOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            EpicsId = 10,
                            Priority = "1",
                            Status = "Planning",
                            StoryPoints = 3,
                            Title = "us101",
                            UserStoriesDetails = "us00details"
                        },
                        new
                        {
                            Id = 110,
                            AcceptanceCriteria = "rand",
                            AssignedToDeveloperId = "dev2",
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            DoneOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            EpicsId = 11,
                            Priority = "3",
                            Status = "New",
                            StoryPoints = 3,
                            Title = "us111",
                            UserStoriesDetails = "us00details"
                        },
                        new
                        {
                            Id = 111,
                            AcceptanceCriteria = "rand",
                            AssignedToDeveloperId = "dev2",
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            DoneOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            EpicsId = 11,
                            Priority = "3",
                            Status = "Planning",
                            StoryPoints = 3,
                            Title = "us111",
                            UserStoriesDetails = "us00details"
                        },
                        new
                        {
                            Id = 112,
                            AcceptanceCriteria = "rand",
                            AssignedToDeveloperId = "dev4",
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            DoneOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            EpicsId = 11,
                            Priority = "2",
                            Status = "Coding",
                            StoryPoints = 3,
                            Title = "us110",
                            UserStoriesDetails = "us00details"
                        },
                        new
                        {
                            Id = 113,
                            AcceptanceCriteria = "rand",
                            AssignedToDeveloperId = "dev2",
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            DoneOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            EpicsId = 11,
                            Priority = "3",
                            Status = "Testing",
                            StoryPoints = 3,
                            Title = "us111",
                            UserStoriesDetails = "us00details"
                        },
                        new
                        {
                            Id = 114,
                            AcceptanceCriteria = "rand",
                            AssignedToDeveloperId = "dev2",
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            DoneOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            EpicsId = 11,
                            Priority = "3",
                            Status = "Done",
                            StoryPoints = 3,
                            Title = "us111",
                            UserStoriesDetails = "us00details"
                        },
                        new
                        {
                            Id = 115,
                            AcceptanceCriteria = "rand",
                            AssignedToDeveloperId = "dev4",
                            CreatedOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            DoneOn = new DateTime(2023, 5, 2, 11, 22, 51, 383, DateTimeKind.Local),
                            EpicsId = 11,
                            Priority = "3",
                            Status = "Done",
                            StoryPoints = 3,
                            Title = "us111",
                            UserStoriesDetails = "us00details"
                        });
                });

            modelBuilder.Entity("project_demo_1.DAL.Models.UserStories", b =>
                {
                    b.HasOne("project_demo_1.DAL.Models.Epics", "Epics")
                        .WithMany("UserStories")
                        .HasForeignKey("EpicsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Epics");
                });

            modelBuilder.Entity("project_demo_1.DAL.Models.Epics", b =>
                {
                    b.Navigation("UserStories");
                });
#pragma warning restore 612, 618
        }
    }
}