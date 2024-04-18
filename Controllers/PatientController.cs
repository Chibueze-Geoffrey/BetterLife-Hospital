using AutoMapper;
using BetterLifeHospital.Dtos;
using BetterLifeHospital.Entities;
using BetterLifeHospital.Services.Implementations;
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
        private readonly DoctorRepository _doctorRepository;

        public PatientController(IPatientRepository patientRepository, IMapper mapper)
        {
            _patientRepository = patientRepository ??
                throw new ArgumentNullException(nameof(patientRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }
        [HttpPost]
        public async Task<ActionResult<PatientDto>> AddPatient(int doctorId,PatientCreated patientCreated)
        {
            var patientAdded = _mapper.Map<Patient>(patientCreated);
            await _patientRepository.AddPatientAsync(doctorId, patientAdded);
          //  AddPatientAsync error CS0103: The name 'AddPatientAsync' does not exist in the current context

    await _patientRepository.SaveChangesAsync();
            var newPatientAdded = _mapper.Map<PatientDto>(patientAdded);
            return CreatedAtRoute("GetPatient", new
            {
                
                patientId = newPatientAdded.Id
            },
            newPatientAdded);
            // await _patientRepository.SaveChangesAsync();
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
