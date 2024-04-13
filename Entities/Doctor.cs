using System.ComponentModel.DataAnnotations;

namespace BetterLifeHospital.Entities
{
    public class Doctor: BaseEntity
    {
        //public int Id { get; set; }
        [Required]
        public string FirstName {  get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        public Guid License { get; set; } = Guid.NewGuid();
        public ICollection <Appointment> appointments { get; set; } = new List<Appointment>();
        public ICollection<Patient> patients { get; set; } = new List<Patient>();



    }
}
