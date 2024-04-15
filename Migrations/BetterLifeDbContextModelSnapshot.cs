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
                            License = new Guid("be3bd169-f170-4243-85c9-d8f85f3f62e7")
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Chibuike",
                            LastName = "Aneke",
                            License = new Guid("07b6ac58-ae6c-4f6e-9878-3db87a204b15")
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Patrick",
                            LastName = "Isak",
                            License = new Guid("031f9ba7-b7b7-4e7c-b17c-cd408dfa49a9")
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "Cristiano",
                            LastName = "Alvaro",
                            License = new Guid("22492fbf-d9bd-4793-b470-efc36b5dbe23")
                        });
                });

            modelBuilder.Entity("BetterLifeHospital.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DoctorId")
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
                            FirstName = "Linda",
                            LastName = "Lee",
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
                    b.HasOne("BetterLifeHospital.Entities.Doctor", null)
                        .WithMany("patients")
                        .HasForeignKey("DoctorId");
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
