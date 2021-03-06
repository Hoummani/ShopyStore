﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPIPayement.Models;

namespace WebAPIPayement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190516160135_changeDbContextName")]
    partial class changeDbContextName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebAPIPayement.Models.PayementDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CVV")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("CardNumber")
                        .IsRequired();

                    b.Property<string>("CardOwnerName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("ExpirationDate")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("PayementDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
