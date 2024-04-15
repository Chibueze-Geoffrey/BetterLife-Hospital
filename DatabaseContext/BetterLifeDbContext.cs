using BetterLifeHospital.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BetterLifeHospital.DatabaseContext
{
    public class BetterLifeDbContext: DbContext
    {
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> patients { get; set; }
        public DbSet<Appointment> appointments { get; set; }
       // public DbSet<Patient> patients { get; set; }
        public BetterLifeDbContext(DbContextOptions<BetterLifeDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().
                HasData(
               new Doctor()
               {
                   Id = 1,
                   FirstName= "Chibueze",
                   LastName="Geoffrey"
               },
               new Doctor()
               {
                   Id = 2,
                   FirstName= "Chibuike",
                   LastName= "Aneke",
               },
               new Doctor()
               {
                   Id = 3,
                   FirstName= "Patrick",
                   LastName = "Isak",
               },
               new Doctor()
               {
                   Id = 4,
                   FirstName= "Cristiano",
                   LastName = "Alvaro",
               });
            modelBuilder.Entity<Patient>().
                HasData(
               new Patient()
               {
                   Id = 111,
                   //DoctorId = 1,
                   FirstName = "Linda",
                   LastName = "Lee",
                   Problem = "Head ache"
               });

            base.OnModelCreating(modelBuilder);
        }
    }
}
