using BetterLifeHospital.Entities;

namespace BetterLifeHospital.Services.Interfaces
{
    public interface IPatientRepository
    {
        Task <IEnumerable<Patient>> GetPatientsAsync ();
        Task<Patient?> GetPatientAsync(int patientId);
        Task AddPatientAsync (Patient Patient);
       // Task<bool> PatientExistsAsync(Guid Id);
        Task<bool> SaveChangesAsync();
    }
}
