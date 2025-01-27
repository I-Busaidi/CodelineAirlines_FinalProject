﻿// <auto-generated />
using System;
using CodelineAirlines;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodelineAirlines.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CodelineAirlines.Models.Airplane", b =>
                {
                    b.Property<int>("AirplaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AirplaneId"));

                    b.Property<string>("AirplaneModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CurrentAirportId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("ManufactureDate")
                        .HasColumnType("date");

                    b.HasKey("AirplaneId");

                    b.HasIndex("AirplaneModel");

                    b.HasIndex("CurrentAirportId");

                    b.ToTable("Airplanes");
                });

            modelBuilder.Entity("CodelineAirlines.Models.AirplaneSpecs", b =>
                {
                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("AvgSpeed")
                        .HasColumnType("float");

                    b.Property<double>("LuggageCapacity")
                        .HasColumnType("float");

                    b.Property<int>("PassengerCapacity")
                        .HasColumnType("int");

                    b.HasKey("Model");

                    b.ToTable("AirplaneSpecs");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Airport", b =>
                {
                    b.Property<int>("AirportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AirportId"));

                    b.Property<string>("AirportName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("AirportId");

                    b.HasIndex("AirportName")
                        .IsUnique();

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("CodelineAirlines.Models.AirportLocation", b =>
                {
                    b.Property<int>("AirportId")
                        .HasColumnType("int");

                    b.Property<double>("AirportLatitude")
                        .HasColumnType("float");

                    b.Property<double>("AirportLongitude")
                        .HasColumnType("float");

                    b.HasKey("AirportId", "AirportLatitude", "AirportLongitude");

                    b.ToTable("AirportLocations");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("BookingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightNo")
                        .HasColumnType("int");

                    b.Property<int>("LoyaltyPointsUsed")
                        .HasColumnType("int");

                    b.Property<string>("Meal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassengerPassport")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("SeatNo")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BookingId");

                    b.HasIndex("FlightNo");

                    b.HasIndex("PassengerPassport");

                    b.HasIndex("SeatNo", "FlightNo")
                        .IsUnique()
                        .HasFilter("[SeatNo] IS NOT NULL");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Flight", b =>
                {
                    b.Property<int>("FlightNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightNo"));

                    b.Property<DateTime>("ActualDepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AirplaneId")
                        .HasColumnType("int");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DestinationAirportId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("time");

                    b.Property<decimal?>("FlightRating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ScheduledDepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SourceAirportId")
                        .HasColumnType("int");

                    b.Property<int>("StatusCode")
                        .HasColumnType("int");

                    b.HasKey("FlightNo");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("DestinationAirportId");

                    b.HasIndex("SourceAirportId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Passenger", b =>
                {
                    b.Property<string>("Passport")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("LoyaltyPoints")
                        .HasColumnType("int");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PassengerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Passport");

                    b.HasIndex("Passport")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FlightNo")
                        .HasColumnType("int");

                    b.Property<decimal>("Rating")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReviewerPassport")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ReviewId");

                    b.HasIndex("FlightNo");

                    b.HasIndex("ReviewerPassport");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("CodelineAirlines.Models.SeatTemplate", b =>
                {
                    b.Property<string>("AirplaneModel")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("SeatNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("SeatCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SeatLocation")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AirplaneModel", "SeatNumber");

                    b.HasIndex("AirplaneModel", "SeatNumber")
                        .IsUnique();

                    b.ToTable("SeatTemplates");
                });

            modelBuilder.Entity("CodelineAirlines.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserPhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserRole")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.HasIndex("UserEmail")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Airplane", b =>
                {
                    b.HasOne("CodelineAirlines.Models.AirplaneSpecs", "AirplaneSpec")
                        .WithMany("Airplane")
                        .HasForeignKey("AirplaneModel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodelineAirlines.Models.Airport", "Airport")
                        .WithMany("Airplanes")
                        .HasForeignKey("CurrentAirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirplaneSpec");

                    b.Navigation("Airport");
                });

            modelBuilder.Entity("CodelineAirlines.Models.AirportLocation", b =>
                {
                    b.HasOne("CodelineAirlines.Models.Airport", "Airport")
                        .WithMany()
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airport");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Booking", b =>
                {
                    b.HasOne("CodelineAirlines.Models.Flight", "Flight")
                        .WithMany("Bookings")
                        .HasForeignKey("FlightNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodelineAirlines.Models.Passenger", "Passenger")
                        .WithMany("Bookings")
                        .HasForeignKey("PassengerPassport")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");

                    b.Navigation("Passenger");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Flight", b =>
                {
                    b.HasOne("CodelineAirlines.Models.Airplane", "Airplane")
                        .WithMany("Flights")
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodelineAirlines.Models.Airport", "DestinationAirport")
                        .WithMany("DestinationFlights")
                        .HasForeignKey("DestinationAirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodelineAirlines.Models.Airport", "SourceAirport")
                        .WithMany("SourceFlights")
                        .HasForeignKey("SourceAirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airplane");

                    b.Navigation("DestinationAirport");

                    b.Navigation("SourceAirport");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Passenger", b =>
                {
                    b.HasOne("CodelineAirlines.Models.User", "User")
                        .WithMany("Passengers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Review", b =>
                {
                    b.HasOne("CodelineAirlines.Models.Flight", "FlightReview")
                        .WithMany("Reviews")
                        .HasForeignKey("FlightNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodelineAirlines.Models.Passenger", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerPassport")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlightReview");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("CodelineAirlines.Models.SeatTemplate", b =>
                {
                    b.HasOne("CodelineAirlines.Models.AirplaneSpecs", "AirplaneSpec")
                        .WithMany("Seats")
                        .HasForeignKey("AirplaneModel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirplaneSpec");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Airplane", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("CodelineAirlines.Models.AirplaneSpecs", b =>
                {
                    b.Navigation("Airplane");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Airport", b =>
                {
                    b.Navigation("Airplanes");

                    b.Navigation("DestinationFlights");

                    b.Navigation("SourceFlights");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Flight", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("CodelineAirlines.Models.Passenger", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("CodelineAirlines.Models.User", b =>
                {
                    b.Navigation("Passengers");
                });
#pragma warning restore 612, 618
        }
    }
}
