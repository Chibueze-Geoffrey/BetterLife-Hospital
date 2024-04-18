using BetterLifeHospital.Entities;

namespace BetterLifeHospital.Services.Interfaces
{
    public interface IPatientRepository
    {
        Task <IEnumerable<Patient>> GetPatientsAsync ();
        Task<Patient?> GetPatientAsync(int patientId);
        Task AddPatientAsync (int doctorId,Patient Patient);
       // Task<bool> PatientExistsAsync(Guid Id);
        Task<bool> SaveChangesAsync();
    }
}
