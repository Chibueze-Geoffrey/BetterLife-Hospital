using BetterLifeHospital.Entities;
using System.ComponentModel.DataAnnotations;

namespace BetterLifeHospital.Dtos
{
    public class DoctorDto 
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
        public Guid License { get; set; } = Guid.NewGuid();
        public ICollection<AppointmentDto> appointments { get; set; } = new List<AppointmentDto>();
        public int NumberOfAppointment
        {
            get
            {
                return appointments.Count;
            }
        }
        public ICollection<PatientDto>patients { get; set; } = new List<PatientDto>();
        public int NumberOfPatient
        {
            get
            {
                return patients.Count;
            }
        }
    }
}
