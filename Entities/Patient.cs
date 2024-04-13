using System.ComponentModel.DataAnnotations.Schema;

namespace BetterLifeHospital.Entities
{
    public class Patient: BaseEntity
    {
        public string FirstName { get; set; }= string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Problem {  get; set; } = string.Empty;
        public Doctor? doctor { get; set; }
        public int DoctorId {get; set; }
    }
}
