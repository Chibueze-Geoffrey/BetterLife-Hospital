using System.ComponentModel.DataAnnotations;

namespace BetterLifeHospital.Dtos
{
    public class AppointmentCreated : BaseDto
    {
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
