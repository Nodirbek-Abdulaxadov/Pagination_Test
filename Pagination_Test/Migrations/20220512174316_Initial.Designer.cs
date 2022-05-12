﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pagination_Test.Data;

#nullable disable

namespace Pagination_Test.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220512174316_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pagination_Test.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Faculty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 2,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 2,
                            Age = 3,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 3,
                            Age = 4,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 4,
                            Age = 5,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 5,
                            Age = 6,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 6,
                            Age = 7,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 7,
                            Age = 8,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 8,
                            Age = 9,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 9,
                            Age = 10,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 10,
                            Age = 11,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 11,
                            Age = 12,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 12,
                            Age = 13,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 13,
                            Age = 14,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 14,
                            Age = 15,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 15,
                            Age = 16,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 16,
                            Age = 17,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 17,
                            Age = 18,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 18,
                            Age = 19,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 19,
                            Age = 20,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 20,
                            Age = 21,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 21,
                            Age = 22,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 22,
                            Age = 23,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 23,
                            Age = 24,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 24,
                            Age = 25,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 25,
                            Age = 26,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 26,
                            Age = 27,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 27,
                            Age = 28,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 28,
                            Age = 29,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 29,
                            Age = 30,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 30,
                            Age = 31,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 31,
                            Age = 32,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 32,
                            Age = 33,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 33,
                            Age = 34,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 34,
                            Age = 35,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 35,
                            Age = 36,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 36,
                            Age = 37,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 37,
                            Age = 38,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 38,
                            Age = 39,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 39,
                            Age = 40,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 40,
                            Age = 41,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 41,
                            Age = 42,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 42,
                            Age = 43,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 43,
                            Age = 44,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 44,
                            Age = 45,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 45,
                            Age = 46,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 46,
                            Age = 47,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 47,
                            Age = 48,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 48,
                            Age = 49,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 49,
                            Age = 50,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 50,
                            Age = 51,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 51,
                            Age = 52,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 52,
                            Age = 53,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 53,
                            Age = 54,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 54,
                            Age = 55,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 55,
                            Age = 56,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 56,
                            Age = 57,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 57,
                            Age = 58,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 58,
                            Age = 59,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 59,
                            Age = 60,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 60,
                            Age = 61,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 61,
                            Age = 62,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 62,
                            Age = 63,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 63,
                            Age = 64,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 64,
                            Age = 65,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 65,
                            Age = 66,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 66,
                            Age = 67,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 67,
                            Age = 68,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 68,
                            Age = 69,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 69,
                            Age = 70,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 70,
                            Age = 71,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 71,
                            Age = 72,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 72,
                            Age = 73,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 73,
                            Age = 74,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 74,
                            Age = 75,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 75,
                            Age = 76,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 76,
                            Age = 77,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 77,
                            Age = 78,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 78,
                            Age = 79,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 79,
                            Age = 80,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 80,
                            Age = 81,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 81,
                            Age = 82,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 82,
                            Age = 83,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 83,
                            Age = 84,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 84,
                            Age = 85,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 85,
                            Age = 86,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 86,
                            Age = 87,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 87,
                            Age = 88,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 88,
                            Age = 89,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 89,
                            Age = 90,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 90,
                            Age = 91,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 91,
                            Age = 92,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 92,
                            Age = 93,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 93,
                            Age = 94,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 94,
                            Age = 95,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 95,
                            Age = 96,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 96,
                            Age = 97,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 97,
                            Age = 98,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 98,
                            Age = 99,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 99,
                            Age = 100,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        },
                        new
                        {
                            Id = 100,
                            Age = 101,
                            Faculty = "Math",
                            FirstName = "Mr. Tom",
                            LastName = "Any"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}