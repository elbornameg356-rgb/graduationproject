using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutpatientClinicsComplex.Models;
using OutpatientClinicsComplex.DTOs;

namespace OutpatientClinicsComplex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabTechniciansController : ControllerBase
    {
        private readonly OutpatientClinicsComplexContext _context;

        public LabTechniciansController(OutpatientClinicsComplexContext context)
        {
            _context = context;
        }

        // 1. البحث عن مريض (POST)
        [HttpPost("search-patient")]
        public async Task<IActionResult> SearchPatient([FromBody] long nationalId)
        {
            var patient = await _context.PatientHistories
                .Where(p => p.NationalId == nationalId)
                .Select(p => new PatientBasicDto
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

        // 2. جلب التحاليل المطلوبة (Pending) - GET
        [HttpGet("pending-tests/{nationalId}")]
        public async Task<IActionResult> GetPendingTests(long nationalId)
        {
            var tests = await _context.RequiredTests
                .Where(t => t.NationalId == nationalId && t.Status == "Pending")
                .OrderBy(t => t.RequestDate)
                .Select(t => new RequiredTestDto
                {
                    Id = t.Id,
                    NationalId = t.NationalId,
                    RequestDate = t.RequestDate,
                    RequiredTests = t.RequiredTests,
                    DoctorCode = t.DoctorCode,
                    LabTechnicianCode = t.LabTechnicianCode,
                    Status = t.Status
                })
                .ToListAsync();

            if (tests == null || tests.Count == 0)
                return NotFound(new { message = "No pending tests found" });

            return Ok(tests);
        }

        // 3. إضافة نتيجة تحليل (POST)
        [HttpPost("add-test-result")]
        public async Task<IActionResult> AddTestResult([FromBody] AddTestResultRequest request)
        {
            var technician = await _context.LabTechnicians.FindAsync(request.LabTechnicianCode);
            if (technician == null)
                return Unauthorized(new { message = "Invalid lab technician code" });

            var requiredTest = await _context.RequiredTests
                .FirstOrDefaultAsync(rt => rt.Id == request.RequiredTestId && rt.NationalId == request.NationalId && rt.Status == "Pending");

            if (requiredTest == null)
                return NotFound(new { message = "Required test not found or already done" });

            var testResult = new TestResult
            {
                NationalId = request.NationalId,
                RequiredTestId = request.RequiredTestId,
                ResultTests = request.ResultTests,
                LabTechnicianCode = request.LabTechnicianCode
            };

            _context.TestResults.Add(testResult);
            await _context.SaveChangesAsync();

            requiredTest.Status = "Done";
            requiredTest.LabTechnicianCode = request.LabTechnicianCode;
            await _context.SaveChangesAsync();

            var response = new AddTestResultResponseDto
            {
                Message = "Test result added successfully",
                TestResultId = testResult.Id,
                RequiredTestId = requiredTest.Id
            };

            return Ok(response);
        }
    }
}

