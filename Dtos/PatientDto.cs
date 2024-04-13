namespace BetterLifeHospital.Dtos
{
    public class PatientDto : BaseDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Problem { get; set; } = string.Empty;
    }
}
