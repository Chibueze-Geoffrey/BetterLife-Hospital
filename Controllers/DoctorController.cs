using AutoMapper;
using BetterLifeHospital.DatabaseContext;
using BetterLifeHospital.Dtos;
using BetterLifeHospital.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BetterLifeHospital.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorController(IDoctorRepository doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository ??
                throw new ArgumentNullException(nameof(doctorRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public async Task <ActionResult<IEnumerable<DoctorWithoutAppointmentDto>>> GetDoctors()
        {
            var doctorsOnDuty = await _doctorRepository.GetDoctorsAsync();
            return Ok(_mapper.Map<IEnumerable<DoctorWithoutAppointmentDto>>(doctorsOnDuty));
        }
        [HttpGet("{doctorId}")]
        public async Task <ActionResult> GetDoctor (int doctorId, bool 
            IncludeAppointment= false, bool IncludePatient= false)
        {
            var getDoctor = await _doctorRepository.GetDoctorAsync(doctorId, IncludeAppointment, IncludePatient);
            if (getDoctor == null)
            {
                return NotFound();
            }
            if (IncludeAppointment || IncludePatient)
            {
                return Ok (_mapper.Map<DoctorDto>(getDoctor));
            }
           return Ok (_mapper.Map<DoctorWithoutAppointmentDto>(getDoctor));
        }
    }
}
