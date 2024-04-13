using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BetterLifeHospital.Entities
{
    public class Appointment: BaseEntity
    {
        [Required]
        [MaxLength(250)]
        public string Description {  get; set; }
        [Required]
        [MaxLength (50)]
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public Doctor? doctor { get; set; }
        public int DoctorId { get; set; }
        public Patient? Patient { get; set; }
        public int PatientId { get; set; }
       // public ICollection <Doctor> Doctors { get; set; } = new List<Doctor>();
       
    }
}
