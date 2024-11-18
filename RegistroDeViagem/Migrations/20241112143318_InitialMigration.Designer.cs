﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroDeViagem.Data;

#nullable disable

namespace RegistroDeViagem.Migrations
{
    [DbContext(typeof(RegistroDeViagemContext))]
    [Migration("20241112143318_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RegistroDeViagem.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TripId")
                        .IsUnique();

                    b.ToTable("Album");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Itinerary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ArrivalDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartureLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Itinerary");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AlbumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UploadDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlbumId");

                    b.HasIndex("TripId");

                    b.ToTable("Photo");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Evaluation")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.TravelCompanions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Relation")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TravelCompanions");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.TravelExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExpenseName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("TravelExpenses");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.TravelStatistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("TotalPhotos")
                        .HasColumnType("int");

                    b.Property<int>("TotalTrips")
                        .HasColumnType("int");

                    b.Property<int>("TotalVisitedLocations")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("TravelStatistics");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TripEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TripName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("TripStartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.TripTravelCompanions", b =>
                {
                    b.Property<int>("TravelCompanionId")
                        .HasColumnType("int");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.HasKey("TravelCompanionId", "TripId");

                    b.HasIndex("TripId");

                    b.ToTable("TripTravelCompanions");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("TravelStatisticsId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.VisitedLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataHoraAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataHoraInclusao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LocationDescription")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioAlteracao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioInclusao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VisitDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TripId");

                    b.ToTable("VisitedLocations");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Album", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.Trip", "Trip")
                        .WithOne("Album")
                        .HasForeignKey("RegistroDeViagem.Entities.Album", "TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Itinerary", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.Trip", "Trip")
                        .WithMany("Itineraries")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Photo", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.Album", "Album")
                        .WithMany("Photos")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroDeViagem.Entities.Trip", "Trip")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Rating", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.Trip", "Trip")
                        .WithMany("Ratings")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.TravelExpense", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.Trip", "Trip")
                        .WithMany("TravelExpenses")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.TravelStatistics", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.User", "User")
                        .WithOne("TravelStatistics")
                        .HasForeignKey("RegistroDeViagem.Entities.TravelStatistics", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Trip", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.User", "User")
                        .WithMany("Trips")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.TripTravelCompanions", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.TravelCompanions", "TravelCompanion")
                        .WithMany("TripTravelCompanions")
                        .HasForeignKey("TravelCompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroDeViagem.Entities.Trip", "Trip")
                        .WithMany("TripTravelCompanions")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelCompanion");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.VisitedLocation", b =>
                {
                    b.HasOne("RegistroDeViagem.Entities.Trip", "Trip")
                        .WithMany("VisitedLocations")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Album", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.TravelCompanions", b =>
                {
                    b.Navigation("TripTravelCompanions");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.Trip", b =>
                {
                    b.Navigation("Album")
                        .IsRequired();

                    b.Navigation("Itineraries");

                    b.Navigation("Ratings");

                    b.Navigation("TravelExpenses");

                    b.Navigation("TripTravelCompanions");

                    b.Navigation("VisitedLocations");
                });

            modelBuilder.Entity("RegistroDeViagem.Entities.User", b =>
                {
                    b.Navigation("TravelStatistics")
                        .IsRequired();

                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
