namespace BetterLifeHospital.Dtos
{
    public class PatientDto 
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Problem { get; set; } = string.Empty;
        public ICollection<AppointmentDto> appointments { get; set; } = new List<AppointmentDto>();
        public int NumberOfAppointment
        {
            get
            {
                return appointments.Count;
            }
        }
    }
}
