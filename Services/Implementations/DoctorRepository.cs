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
        public Task<Doctor> GetDoctorAsync(Guid Id, bool IncludeAppointment, bool IncludePatient)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
        {
            return await _betterLifeDbContext.doctors.OrderBy(x=>x.LastName).ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _betterLifeDbContext.SaveChangesAsync() >= 0);
        }
    }
}
