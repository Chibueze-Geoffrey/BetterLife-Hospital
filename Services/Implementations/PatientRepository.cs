using BetterLifeHospital.DatabaseContext;
using BetterLifeHospital.Entities;
using BetterLifeHospital.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BetterLifeHospital.Services.Implementations
{
    public class PatientRepository : IPatientRepository
    {
        private readonly BetterLifeDbContext _betterLifeDbContext;

        public PatientRepository(BetterLifeDbContext betterLifeDbContext)
        {
            _betterLifeDbContext = betterLifeDbContext;
        }
        public async Task AddPatientAsync( Patient Patient)
        {

             await _betterLifeDbContext.patients.AddAsync(Patient);
        }

        public async Task<Patient?> GetPatientAsync(int patientId)
        {
            return await _betterLifeDbContext.patients.Where(x => x.Id ==patientId)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Patient>> GetPatientsAsync()
        {
           
                return await _betterLifeDbContext.patients.OrderBy(x=>x.LastName)
                .ToListAsync();
            
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _betterLifeDbContext.SaveChangesAsync() >= 0;
        }
    }
}
