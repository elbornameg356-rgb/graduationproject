using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutpatientClinicsComplex.Models;
using OutpatientClinicsComplex.DTOs;

namespace OutpatientClinicsComplex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionistController : ControllerBase
    {
        private readonly OutpatientClinicsComplexContext _context;

        public ReceptionistController(OutpatientClinicsComplexContext context)
        {
            _context = context;
        }

        // 1. البحث عن مريض (POST)
        [HttpPost("search-patient")]
        public async Task<IActionResult> SearchPatient([FromBody] SearchPatientRequest request)
        {
            if (request == null || request.NationalId == 0)
                return BadRequest(new { message = "Invalid data" });

            var receptionist = await _context.Receptionists.FindAsync(request.ReceptionistCode);
            if (receptionist == null)
                return Unauthorized(new { message = "Invalid receptionist code" });

            var patient = await _context.PatientHistories
                .Where(p => p.NationalId == request.NationalId)
                .Select(p => new PatientBasicDto  // ✅ استخدام DTO للـ Response
                {
                    Id = p.Id,
                    NationalId = p.NationalId,
                    FullName = p.FullName,
                    Phone = p.Phone
                })
                .FirstOrDefaultAsync();

            if (patient == null)
                return NotFound(new { message = "Patient not found" });

            return Ok(patient);
        }

        // 2. تسجيل مريض جديد (POST)
        [HttpPost("register-patient")]
        public async Task<IActionResult> RegisterPatient([FromBody] RegisterPatientRequest request)
        {
            if (request == null)
                return BadRequest(new { message = "Invalid data" });

            var receptionist = await _context.Receptionists.FindAsync(request.ReceptionistCode);
            if (receptionist == null)
                return Unauthorized(new { message = "Invalid receptionist code" });

            var doctor = await _context.Doctors.FindAsync(request.DoctorCode);
            if (doctor == null)
                return BadRequest(new { message = "Doctor not found" });

            var existingPatient = await _context.PatientHistories
                .AnyAsync(p => p.NationalId == request.NationalId);
            if (existingPatient)
                return Conflict(new { message = "Patient with this National ID already exists" });

            var newId = await _context.PatientHistories.MaxAsync(p => (int?)p.Id) ?? 0;
            newId++;

            var patient = new PatientHistory
            {
                Id = newId,
                NationalId = request.NationalId,
                FullName = request.FullName,
                DateOfBirth = DateOnly.FromDateTime(request.DateOfBirth),
                Gender = request.Gender,
                Phone = request.Phone,
                BloodType = request.BloodType,
                ChronicDiseases = request.ChronicDiseases,
                Allergies = request.Allergies,
                DoctorCode = request.DoctorCode,
                ReceptionistCode = request.ReceptionistCode
            };

            _context.PatientHistories.Add(patient);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Patient registered successfully",
                patientId = patient.Id,
                nationalId = patient.NationalId
            });
        }

        // 3. حجز موعد (POST)
        [HttpPost("book-appointment")]
        public async Task<IActionResult> BookAppointment([FromBody] BookAppointmentRequest request)
        {
            if (request == null)
                return BadRequest(new { message = "Invalid data" });

            var receptionist = await _context.Receptionists.FindAsync(request.ReceptionistCode);
            if (receptionist == null)
                return Unauthorized(new { message = "Invalid receptionist code" });

            var doctor = await _context.Doctors.FindAsync(request.DoctorCode);
            if (doctor == null)
                return BadRequest(new { message = "Doctor not found" });

            var patient = await _context.PatientHistories
                .FirstOrDefaultAsync(p => p.Id == request.PatientId && p.NationalId == request.PatientNationalId);
            if (patient == null)
                return BadRequest(new { message = "Patient not found" });

            var endTime = request.StartTime.Add(TimeSpan.FromMinutes(15));

            var isDoctorBusy = await _context.Appointments
                .AnyAsync(a => a.DoctorCode == request.DoctorCode &&
                               a.AppointmentDate == request.AppointmentDate &&
                               a.StartTime < endTime &&
                               a.EndTime > request.StartTime);

            if (isDoctorBusy)
                return Conflict(new { message = "Doctor is not available at this time" });

            var appointment = new Appointment
            {
                PatientId = request.PatientId,
                PatientNationalId = request.PatientNationalId,
                DoctorCode = request.DoctorCode,
                AppointmentDate = request.AppointmentDate,
                StartTime = request.StartTime,
                EndTime = endTime,
                DurationMinutes = 15,
                ReceptionistCode = request.ReceptionistCode,
                Status = "Scheduled"
            };

            _context.Appointments.Add(appointment);
            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Appointment booked successfully",
                appointmentId = appointment.Id,
                appointmentDate = appointment.AppointmentDate,
                startTime = appointment.StartTime,
                endTime = appointment.EndTime,
                durationMinutes = appointment.DurationMinutes
            });
        }
    }
}
