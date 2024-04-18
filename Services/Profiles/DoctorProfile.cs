using AutoMapper;

namespace BetterLifeHospital.Services.Profiles
{
    public class DoctorProfile: Profile
    {
        public DoctorProfile()
        {
            CreateMap<Entities.Doctor, Dtos.DoctorWithoutAppointmentDto>();
            CreateMap<Entities.Doctor, Dtos.DoctorDto>();
        }
    }
}
