using BetterLifeHospital.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BetterLifeHospital.Dtos
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
      
    }
}
