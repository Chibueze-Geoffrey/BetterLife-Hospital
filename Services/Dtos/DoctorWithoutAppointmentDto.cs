namespace BetterLifeHospital.Dtos
{
    public class DoctorWithoutAppointmentDto 
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Guid License { get; set; } = Guid.NewGuid();
    }
}
