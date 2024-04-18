﻿// <auto-generated />
using System;
using BetterLifeHospital.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BetterLifeHospital.Migrations
{
    [DbContext(typeof(BetterLifeDbContext))]
    partial class BetterLifeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("BetterLifeHospital.Entities.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("appointments");

                    b.HasData(
                        new
                        {
                            Id = 1000,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Patient has been diagnosed of headache and has history of migraine",
                            DoctorId = 1,
                            PatientId = 112,
                            Title = "Head Patient"
                        },
                        new
                        {
                            Id = 1001,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Patient has been diagnosed of mild headache and has history of migraine",
                            DoctorId = 2,
                            PatientId = 111,
                            Title = "Head Patient"
                        });
                });

            modelBuilder.Entity("BetterLifeHospital.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("License")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Chibueze",
                            LastName = "Geoffrey",
                            License = new Guid("4166c52e-c85c-4ca8-a786-1bfda12e8f14")
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Chibuike",
                            LastName = "Aneke",
                            License = new Guid("d0d3c265-5085-4d1a-8001-e927f051f863")
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Patrick",
                            LastName = "Isak",
                            License = new Guid("b5c0b2ca-4e40-44e0-9e7f-b1c4cb5595b7")
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Cristiano",
                            LastName = "Alvaro",
                            License = new Guid("65ed4db4-d850-4e55-90fc-2044fa9b11e5")
                        });
                });

            modelBuilder.Entity("BetterLifeHospital.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoctorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("patients");

                    b.HasData(
                        new
                        {
                            Id = 111,
                            DoctorId = 1,
                            FirstName = "Linda",
                            LastName = "Lee",
                            Problem = "Head ache"
                        },
                        new
                        {
                            Id = 112,
                            DoctorId = 2,
                            FirstName = "Linda",
                            LastName = "SLee",
                            Problem = "Head ache"
                        });
                });

            modelBuilder.Entity("BetterLifeHospital.Entities.Appointment", b =>
                {
                    b.HasOne("BetterLifeHospital.Entities.Doctor", "doctor")
                        .WithMany("appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BetterLifeHospital.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("BetterLifeHospital.Entities.Patient", b =>
                {
                    b.HasOne("BetterLifeHospital.Entities.Doctor", "doctor")
                        .WithMany("patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("BetterLifeHospital.Entities.Doctor", b =>
                {
                    b.Navigation("appointments");

                    b.Navigation("patients");
                });
#pragma warning restore 612, 618
        }
    }
}
