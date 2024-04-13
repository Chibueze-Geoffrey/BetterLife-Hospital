namespace BetterLifeHospital.Dtos
{
    public class DoctorWithoutAppointmentDto : BaseDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Guid License { get; set; } = Guid.NewGuid();
    }
}
