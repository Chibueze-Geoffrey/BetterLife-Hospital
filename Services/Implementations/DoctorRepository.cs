using BetterLifeHospital.DatabaseContext;
using BetterLifeHospital.Entities;
using BetterLifeHospital.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BetterLifeHospital.Services.Implementations
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly BetterLifeDbContext _betterLifeDbContext;

        public DoctorRepository(BetterLifeDbContext betterLifeDbContext)
        {
            _betterLifeDbContext = betterLifeDbContext;
        }
        public async Task<Doctor?> GetDoctorAsync(int doctorId, bool IncludeAppointment, bool IncludePatient)
        {
            if (IncludePatient)
            {
                return await _betterLifeDbContext.doctors.Include(x=>x.patients).
                    Where(x=>x.Id == doctorId).FirstOrDefaultAsync();
            }
            if(IncludeAppointment)
            {
                return await _betterLifeDbContext.doctors.Include(x => x.appointments).
                   
                    Where(x => x.Id == doctorId).FirstOrDefaultAsync();
            }
            return await _betterLifeDbContext.doctors.
                Where(x=>x.Id== doctorId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            return await _betterLifeDbContext.doctors.OrderBy(x=>x.LastName).ToListAsync();
        }

        //public async Task<bool> SaveChangesAsync()
        //{
        //    return (await _betterLifeDbContext.SaveChangesAsync() >= 0);
        //}
    }
}
