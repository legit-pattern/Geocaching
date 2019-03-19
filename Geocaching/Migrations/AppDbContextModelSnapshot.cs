﻿// <auto-generated />
using System;
using Geocaching;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Geocaching.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Geocaching.FoundGeocache", b =>
                {
                    b.Property<int>("PersonId");

                    b.Property<int>("GeocacheId");

                    b.HasKey("PersonId", "GeocacheId");

                    b.HasIndex("GeocacheId");

                    b.ToTable("FoundGeocaches");
                });

            modelBuilder.Entity("Geocaching.Geocache", b =>
                {
                    b.Property<int>("GeocacheId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("varchar(255)");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Message")
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("PersonId");

                    b.HasKey("GeocacheId");

                    b.HasIndex("PersonId");

                    b.ToTable("Geocaches");
                });

            modelBuilder.Entity("Geocaching.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Country")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FirstName")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("StreetName")
                        .HasColumnType("varchar(50)");

                    b.Property<byte>("StreetNumber");

                    b.HasKey("PersonId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Geocaching.FoundGeocache", b =>
                {
                    b.HasOne("Geocaching.Geocache", "Geocache")
                        .WithMany("FoundGeocaches")
                        .HasForeignKey("GeocacheId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Geocaching.Person", "Person")
                        .WithMany("FoundGeocaches")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Geocaching.Geocache", b =>
                {
                    b.HasOne("Geocaching.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}
