using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutpatientClinicsComplex.Models;
using OutpatientClinicsComplex.DTOs;

namespace OutpatientClinicsComplex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PharmacistsController : ControllerBase
    {
        private readonly OutpatientClinicsComplexContext _context;

        public PharmacistsController(OutpatientClinicsComplexContext context)
        {
            _context = context;
        }

        // 1. البحث عن مريض (POST)
        [HttpPost("search-patient")]
        public async Task<IActionResult> SearchPatient([FromBody] long nationalId)
        {
            var patient = await _context.PatientHistories
                .Where(p => p.NationalId == nationalId)
                .Select(p => new PatientBasicDto  // ✅ Response DTO
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

        // 2. جلب الروشتات غير المصروفة (GET)
        [HttpGet("unfilled-prescriptions/{nationalId}")]
        public async Task<IActionResult> GetUnfilledPrescriptions(long nationalId)
        {
            var prescriptions = await _context.Prescriptions
                .Where(p => p.NationalId == nationalId && p.Status != "Dispensed")
                .OrderBy(p => p.PrescriptionDate)
                .Select(p => new PrescriptionDto  // ✅ Response DTO
                {
                    Id = p.Id,
                    NationalId = p.NationalId,
                    PrescriptionDate = p.PrescriptionDate,
                    Medicines = p.Medicines,
                    Status = p.Status,
                    DoctorCode = p.DoctorCode,
                    PharmacistCode = p.PharmacistCode
                })
                .ToListAsync();

            if (prescriptions == null || prescriptions.Count == 0)
                return NotFound(new { message = "No unfilled prescriptions found" });

            return Ok(prescriptions);
        }

        // 3. صرف روشتة (POST)
        [HttpPost("dispense-prescription")]
        public async Task<IActionResult> DispensePrescription([FromBody] DispensePrescriptionRequest request)  // ✅ Request DTO
        {
            var pharmacist = await _context.Pharmacists.FindAsync(request.PharmacistCode);
            if (pharmacist == null)
                return Unauthorized(new { message = "Invalid pharmacist code" });

            var prescription = await _context.Prescriptions
                .FirstOrDefaultAsync(p => p.Id == request.PrescriptionId && p.NationalId == request.NationalId && p.Status != "Dispensed");

            if (prescription == null)
                return NotFound(new { message = "Prescription not found or already dispensed" });

            prescription.Status = "Dispensed";
            prescription.PharmacistCode = request.PharmacistCode;

            await _context.SaveChangesAsync();

            return Ok(new
            {
                message = "Prescription dispensed successfully",
                prescriptionId = prescription.Id,
                status = prescription.Status,
                pharmacistCode = prescription.PharmacistCode
            });
        }
    }
}
