using BetterLifeHospital.DatabaseContext;
using BetterLifeHospital.Entities;
using BetterLifeHospital.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BetterLifeHospital.Services.Implementations
{
    public class PatientRepository : IPatientRepository 
    {
        private readonly BetterLifeDbContext _betterLifeDbContext;
        private readonly IDoctorRepository _doctorRepository;

        public PatientRepository(BetterLifeDbContext betterLifeDbContext, IDoctorRepository doctorRepository)
        {
            _betterLifeDbContext = betterLifeDbContext;
            _doctorRepository = doctorRepository;
        }
        public async Task AddPatientAsync( int doctorId, Patient Patient)
        {

            var patientAdded = await _doctorRepository.GetDoctorAsync(doctorId, false,false);
            if (patientAdded != null)
            {
                patientAdded.patients.Add(Patient);
            }
             //await _betterLifeDbContext.patients.Where(x=>x.DoctorId == doctorId).
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
