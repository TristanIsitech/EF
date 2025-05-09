﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWebApi;

#nullable disable

namespace MyWebApi.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20250408125443_UpdateTableEvent")]
    partial class UpdateTableEvent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("MyWebApi.Models.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("MyWebApi.Models.EventParticipant", b =>
                {
                    b.Property<Guid>("EventId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ParticipantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("AttendanceStatus")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("EventId", "ParticipantId");

                    b.HasIndex("ParticipantId");

                    b.ToTable("EventParticipants");
                });

            modelBuilder.Entity("MyWebApi.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MyWebApi.Models.Participant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Company")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("JobTitle")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("MyWebApi.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<Guid>("ParticipantId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<Guid>("SessionId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("ParticipantId");

                    b.HasIndex("SessionId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("MyWebApi.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("MyWebApi.Models.Session", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("EventId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("RoomId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("MyWebApi.Models.SessionSpeaker", b =>
                {
                    b.Property<Guid>("SessionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("SpeakerId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SessionId", "SpeakerId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("SessionSpeakers");
                });

            modelBuilder.Entity("MyWebApi.Models.Speaker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bio")
                        .HasColumnType("longtext");

                    b.Property<string>("Company")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("MyWebApi.Models.Event", b =>
                {
                    b.HasOne("MyWebApi.Models.Location", "Location")
                        .WithMany("Events")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MyWebApi.Models.EventParticipant", b =>
                {
                    b.HasOne("MyWebApi.Models.Event", "Event")
                        .WithMany("EventParticipants")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWebApi.Models.Participant", "Participant")
                        .WithMany("EventParticipants")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Participant");
                });

            modelBuilder.Entity("MyWebApi.Models.Rating", b =>
                {
                    b.HasOne("MyWebApi.Models.Participant", "Participant")
                        .WithMany("Ratings")
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWebApi.Models.Session", "Session")
                        .WithMany("Ratings")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("Session");
                });

            modelBuilder.Entity("MyWebApi.Models.Room", b =>
                {
                    b.HasOne("MyWebApi.Models.Location", "Location")
                        .WithMany("Rooms")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("MyWebApi.Models.Session", b =>
                {
                    b.HasOne("MyWebApi.Models.Event", "Event")
                        .WithMany("Sessions")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWebApi.Models.Room", "Room")
                        .WithMany("Sessions")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("MyWebApi.Models.SessionSpeaker", b =>
                {
                    b.HasOne("MyWebApi.Models.Session", "Session")
                        .WithMany("SessionSpeakers")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyWebApi.Models.Speaker", "Speaker")
                        .WithMany("SessionSpeakers")
                        .HasForeignKey("SpeakerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("Speaker");
                });

            modelBuilder.Entity("MyWebApi.Models.Event", b =>
                {
                    b.Navigation("EventParticipants");

                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("MyWebApi.Models.Location", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("MyWebApi.Models.Participant", b =>
                {
                    b.Navigation("EventParticipants");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("MyWebApi.Models.Room", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("MyWebApi.Models.Session", b =>
                {
                    b.Navigation("Ratings");

                    b.Navigation("SessionSpeakers");
                });

            modelBuilder.Entity("MyWebApi.Models.Speaker", b =>
                {
                    b.Navigation("SessionSpeakers");
                });
#pragma warning restore 612, 618
        }
    }
}
