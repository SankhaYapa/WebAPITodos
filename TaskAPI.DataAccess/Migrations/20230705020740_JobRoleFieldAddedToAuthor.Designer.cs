﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskAPI.DataAccess;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20230705020740_JobRoleFieldAddedToAuthor")]
    partial class JobRoleFieldAddedToAuthor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication2.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("JobRole")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "45",
                            City = "City 1",
                            FullName = "Sankha",
                            JobRole = "Developer",
                            Street = "Street1"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "46",
                            City = "City 1",
                            FullName = "Yapa",
                            JobRole = "Engineer",
                            Street = "Street1"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "47",
                            City = "City 1",
                            FullName = "Priyamantha",
                            JobRole = "Developer",
                            Street = "Street1"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "48",
                            City = "City 1",
                            FullName = "Bandara",
                            JobRole = "QA",
                            Street = "Street1"
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            CreatedDate = new DateTime(2023, 7, 5, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9190),
                            Description = "Get some text books for school",
                            Status = 0,
                            Title = "Get books for school form DB",
                            UpdatedDate = new DateTime(2023, 7, 10, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9200)
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            CreatedDate = new DateTime(2023, 7, 5, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9208),
                            Description = "Get some text books for school",
                            Status = 0,
                            Title = "Get books for school form DB",
                            UpdatedDate = new DateTime(2023, 7, 10, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9209)
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            CreatedDate = new DateTime(2023, 7, 5, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9210),
                            Description = "Get some text books for school",
                            Status = 0,
                            Title = "Get books for school form DB",
                            UpdatedDate = new DateTime(2023, 7, 10, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9211)
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            CreatedDate = new DateTime(2023, 7, 5, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9212),
                            Description = "Get some text books for school",
                            Status = 0,
                            Title = "Get books for school form DB",
                            UpdatedDate = new DateTime(2023, 7, 10, 7, 37, 39, 528, DateTimeKind.Local).AddTicks(9213)
                        });
                });

            modelBuilder.Entity("WebApplication2.Models.Todo", b =>
                {
                    b.HasOne("WebApplication2.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("WebApplication2.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
