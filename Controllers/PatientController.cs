using AutoMapper;
using BetterLifeHospital.Dtos;
using BetterLifeHospital.Entities;
using BetterLifeHospital.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BetterLifeHospital.Controllers
{
    [Route("api/patients")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IMapper _mapper;

        public PatientController(IPatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository ??
                throw new ArgumentNullException(nameof(patientRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
        [HttpPost]
        public async Task<ActionResult<PatientDto>> AddPatient(int Id, PatientCreated patientCreated)
        {
            var patientAdded = _mapper.Map<Patient>(patientCreated);
            await _patientRepository.AddPatientAsync(Id,patientAdded);
            await _patientRepository.SaveChangesAsync();
            var  newPatientAdded = _mapper.Map<PatientDto>(patientAdded);
            return CreatedAtRoute("GetPatient", new
            {
                Id = Id,
                patientId = newPatientAdded.Id
            },
            newPatientAdded);
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patient>>> GetPatientsAsync()
        {
            var GetPatients = await _patientRepository.GetPatientsAsync();
            return Ok(_mapper.Map<IEnumerable<PatientDto>>(GetPatients));
        }
        [HttpGet("{patientId}", Name = "GetPatient")]
        public async Task<ActionResult<PatientDto>> GetPatient( int patientId)
        {
            var getAPatient = await _patientRepository.GetPatientAsync(patientId);
            if (getAPatient == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<PatientDto>(getAPatient));
        }
    }
}
