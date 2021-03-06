﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Contexts;

namespace Persistence.Migrations
{
    [DbContext(typeof(BikesDbContext))]
    partial class BikesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Entities.Bike", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Bikes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 20.99m,
                            Status = 0,
                            Title = "Giant Contend AR 2 2020",
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            Price = 18.99m,
                            Status = 0,
                            Title = "Cyclone MMXX 29 2020",
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            Price = 15.99m,
                            Status = 0,
                            Title = "Trek Domane AL 3 2019",
                            Type = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
