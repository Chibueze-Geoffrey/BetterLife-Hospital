﻿// <auto-generated />
using System;
using BetterLifeHospital.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BetterLifeHospital.Migrations
{
    [DbContext(typeof(BetterLifeDbContext))]
    [Migration("20240412113325_InfoRearranged")]
    partial class InfoRearranged
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("BetterLifeHospital.Entities.Appointment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("DoctorId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("License")
                        .HasColumnType("TEXT");

                    b.Property<string>("PatientId")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

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
                            Id = "1",
                            FirstName = "Chibueze",
                            LastName = "Geoffrey",
                            License = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = "2",
                            FirstName = "Chibuike",
                            LastName = "Aneke",
                            License = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = "3",
                            FirstName = "Patrick",
                            LastName = "Isak",
                            License = new Guid("00000000-0000-0000-0000-000000000000")
                        },
                        new
                        {
                            Id = "4",
                            FirstName = "Cristiano",
                            LastName = "Alvaro",
                            License = new Guid("00000000-0000-0000-0000-000000000000")
                        });
                });

            modelBuilder.Entity("BetterLifeHospital.Entities.Patient", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("DoctorId")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("License")
                        .HasColumnType("TEXT");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("patients");
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
                        .HasForeignKey("DoctorId");

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
