using System.ComponentModel.DataAnnotations;

namespace BetterLifeHospital.Dtos
{
    public class PatientCreated
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        [MaxLength(250)]
        public string Problem { get; set; } = string.Empty;
    }
}
