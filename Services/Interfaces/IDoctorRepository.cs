﻿using BetterLifeHospital.Entities;

namespace BetterLifeHospital.Services.Interfaces
{
    public interface IDoctorRepository
    {
        Task <IEnumerable<Doctor>> GetDoctorsAsync ();
        Task <Doctor> GetDoctorAsync (Guid Id, bool IncludeAppointment,bool IncludePatient);
        Task<bool> SaveChangesAsync();


    }
}
