using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OutpatientClinicsComplex.DTOs;
using OutpatientClinicsComplex.Models;
using OutpatientClinicsComplex.Services;

namespace OutpatientClinicsComplex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly OutpatientClinicsComplexContext _context;
        private readonly IMinistryService _ministryService;

        public DoctorsController(OutpatientClinicsComplexContext context, IMinistryService ministryService)
        {
            _context = context;
            _ministryService = ministryService;
        }

        // 1. جلب مواعيد الدكتور (GET)
        [HttpGet("appointments/{doctorCode}")]
        public async Task<IActionResult> GetAppointments(int doctorCode)
        {
            var targetDate =  DateOnly.FromDateTime(DateTime.Today);
            var appointments = await _context.Appointments
                .Where(a => a.DoctorCode == doctorCode && a.AppointmentDate == targetDate)
                .Select(a => new AppointmentDto
                {
                    Id = a.Id,
                    AppointmentDate = a.AppointmentDate,
                    StartTime = a.StartTime,
                    EndTime = a.EndTime,
                    DurationMinutes = a.DurationMinutes,
                    Status = a.Status,
                    ReceptionistCode = a.ReceptionistCode,
                    DoctorCode = a.DoctorCode,
                    PatientId = a.PatientId,
                    PatientNationalId = a.PatientNationalId
                })
                .OrderBy(a => a.StartTime)
                .ToListAsync();

            if (appointments == null || appointments.Count == 0)
                return NotFound(new { message = "No appointments for this doctor on this date" });

            return Ok(appointments);
        }

        // 2. البحث عن مريض (POST)
        [HttpPost("search-patient")]
        public async Task<IActionResult> SearchPatient([FromBody] long nationalId)
        {
            var patient = await _context.PatientHistories
                .Where(p => p.NationalId == nationalId)
                .Select(p => new PatientDto
                {
                    Id = p.Id,
                    NationalId = p.NationalId,
                    FullName = p.FullName,
                    DateOfBirth = p.DateOfBirth,
                    Gender = p.Gender,
                    Phone = p.Phone,
                    BloodType = p.BloodType,
                    ChronicDiseases = p.ChronicDiseases,
                    Allergies = p.Allergies,
                    DoctorCode = p.DoctorCode,
                    ReceptionistCode = p.ReceptionistCode
                })
                .FirstOrDefaultAsync();

            if (patient == null)
                return NotFound(new { message = "Patient not found" });

            return Ok(patient);
        }

        // 3. جلب تشخيصات المريض (GET)
        [HttpGet("diagnoses/{nationalId}")]
        public async Task<IActionResult> GetPatientDiagnoses(long nationalId)
        {
            var diagnoses = await _context.Diagnoses
                .Where(d => d.NationalId == nationalId)
                .OrderByDescending(d => d.DiagnosisDate)
                .Select(d => new DiagnosisDto
                {
                    Id = d.Id,
                    NationalId = d.NationalId,
                    Diagnosis1 = d.Diagnosis1,
                    DoctorCode = d.DoctorCode,
                    DiagnosisDate = d.DiagnosisDate,
                    IsDangerous = d.IsDangerous,
                    RiskLevel = d.RiskLevel,
                    Gender = d.Gender,
                    Age = d.Age,
                    LabConfirmed = d.LabConfirmed,
                    IsReported = d.IsReported,
                    Month = d.Month,
                    Year = d.Year,
                    WeekNumber = d.WeekNumber
                })
                .ToListAsync();

            if (diagnoses == null || diagnoses.Count == 0)
                return NotFound(new { message = "No diagnoses found for this patient" });

            return Ok(diagnoses);
        }

        // 4. جلب التحاليل المطلوبة (GET)
        [HttpGet("required-tests/{nationalId}")]
        public async Task<IActionResult> GetRequiredTestsForPatient(long nationalId)
        {
            var requiredTests = await _context.RequiredTests
                .Where(rt => rt.NationalId == nationalId)
                .OrderByDescending(rt => rt.RequestDate)
                .Select(rt => new RequiredTestDto
                {
                    Id = rt.Id,
                    NationalId = rt.NationalId,
                    RequestDate = rt.RequestDate,
                    RequiredTests = rt.RequiredTests,
                    DoctorCode = rt.DoctorCode,
                    LabTechnicianCode = rt.LabTechnicianCode,
                    Status = rt.Status
                })
                .ToListAsync();

            if (requiredTests == null || requiredTests.Count == 0)
                return NotFound(new { message = "No required tests found for this patient" });

            return Ok(requiredTests);
        }

        // 5. إضافة تحليل مطلوب (POST)
        [HttpPost("add-required-test")]
        public async Task<IActionResult> AddRequiredTest([FromBody] AddRequiredTestRequest request)
        {
            var requiredTest = new RequiredTest
            {
                NationalId = request.NationalId,
                RequiredTests = request.RequiredTests,
                DoctorCode = request.DoctorCode,
                Status = "Pending",
                RequestDate = DateTime.Now
            };

            _context.RequiredTests.Add(requiredTest);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Required test added successfully", id = requiredTest.Id });
        }

        // 6. جلب الروشتات (GET)
        [HttpGet("prescriptions/{nationalId}")]
        public async Task<IActionResult> GetPrescriptions(long nationalId)
        {
            var prescriptions = await _context.Prescriptions
                .Where(p => p.NationalId == nationalId)
                .OrderByDescending(p => p.PrescriptionDate)
                .Select(p => new PrescriptionDto
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
                return NotFound(new { message = "No prescriptions found for this patient" });

            return Ok(prescriptions);
        }

        // 7. إضافة روشتة جديدة (POST)
        [HttpPost("add-prescription")]
        public async Task<IActionResult> AddPrescription([FromBody] AddPrescriptionRequest request)
        {
            var prescription = new Prescription
            {
                NationalId = request.NationalId,
                Medicines = request.Medicines,
                DoctorCode = request.DoctorCode,
                Status = "Pending",
                PrescriptionDate = DateOnly.FromDateTime(DateTime.Now),
                PharmacistCode = null
            };

            _context.Prescriptions.Add(prescription);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Prescription added successfully", id = prescription.Id });
        }

        // 8. إضافة مرض مزمن أو حساسية (POST)
        [HttpPost("add-chronic-disease-allergy")]
        public async Task<IActionResult> AddChronicDiseaseAllergy([FromBody] AddChronicDiseaseAllergyRequest request)
        {
            var patient = await _context.PatientHistories
                .FirstOrDefaultAsync(p => p.NationalId == request.NationalId);

            if (patient == null)
                return NotFound(new { message = "Patient not found" });

            if (!string.IsNullOrEmpty(request.Disease))
            {
                patient.ChronicDiseases = string.IsNullOrEmpty(patient.ChronicDiseases)
                    ? request.Disease
                    : patient.ChronicDiseases + ", " + request.Disease;
            }

            if (!string.IsNullOrEmpty(request.Allergy))
            {
                patient.Allergies = string.IsNullOrEmpty(patient.Allergies)
                    ? request.Allergy
                    : patient.Allergies + ", " + request.Allergy;
            }

            await _context.SaveChangesAsync();

            return Ok(new { message = "Chronic disease or allergy added successfully" });
        }

        // 9. جلب نتائج التحاليل (GET)
        [HttpGet("patient-test-results/{nationalId}")]
        public async Task<IActionResult> GetPatientTestResults(long nationalId)
        {
            var testResults = await _context.TestResults
                .Where(tr => tr.NationalId == nationalId)
                .OrderByDescending(tr => tr.Id)
                .Select(tr => new TestResultDto
                {
                    Id = tr.Id,
                    NationalId = tr.NationalId,
                    RequiredTestId = tr.RequiredTestId,
                    ResultTests = tr.ResultTests,
                    LabTechnicianCode = tr.LabTechnicianCode
                })
                .ToListAsync();

            if (testResults == null || testResults.Count == 0)
                return NotFound(new { message = "No test results found for this patient" });

            return Ok(testResults);
        }

        // 10. إضافة تشخيص جديد (POST)
        [HttpPost("add-diagnosis")]
        public async Task<IActionResult> AddDiagnosis([FromBody] AddDiagnosisRequest request)
        {
            var patient = await _context.PatientHistories
                .FirstOrDefaultAsync(p => p.NationalId == request.NationalId);

            if (patient == null)
                return NotFound(new { message = "Patient not found" });

            var diagnosisDate = DateTime.Now;

            int age = 0;
            if (patient.DateOfBirth.HasValue)
            {
                var birthDate = patient.DateOfBirth.Value;
                age = diagnosisDate.Year - birthDate.Year;
                if (birthDate.Month > diagnosisDate.Month ||
                    (birthDate.Month == diagnosisDate.Month && birthDate.Day > diagnosisDate.Day))
                    age--;
            }

            var diseaseInfo = await _context.DangerousDiseases
                .FirstOrDefaultAsync(d => d.DiseaseName == request.Diagnosis);

            string riskLevel = diseaseInfo?.RiskLevel ?? "Weak";
            bool isDangerous = diseaseInfo != null;

            var diagnosis = new Diagnosis
            {
                NationalId = request.NationalId,
                Diagnosis1 = request.Diagnosis,
                DoctorCode = request.DoctorCode,
                DiagnosisDate = diagnosisDate,
                IsDangerous = isDangerous,
                RiskLevel = riskLevel,
                Gender = patient.Gender,
                Age = age,
                LabConfirmed = request.LabConfirmed,
                IsReported = false,
                Month = diagnosisDate.Month,
                Year = diagnosisDate.Year,
                WeekNumber = GetWeekNumber(diagnosisDate)
            };

            _context.Diagnoses.Add(diagnosis);
            await _context.SaveChangesAsync();

            var startOfToday = DateTime.Today;
            var todayCasesCount = await _context.Diagnoses
                .CountAsync(d => d.Diagnosis1 == request.Diagnosis && d.DiagnosisDate >= startOfToday);

            var outbreakLimitSetting = await _context.OutbreakLimits
                .FirstOrDefaultAsync(l => l.Diagnosis == request.Diagnosis);

            int currentLimit = outbreakLimitSetting?.Limit ?? 100;

            string outbreakAlert = "No alert";
            if (todayCasesCount >= currentLimit)
            {
                outbreakAlert = $"🚨 Early outbreak alert! Exceeded {currentLimit} cases (current: {todayCasesCount})";
                await _ministryService.SendEarlyAlert(request.Diagnosis, todayCasesCount, currentLimit);
                Console.WriteLine($"[EARLY ALERT] {outbreakAlert}");
            }

            return Ok(new
            {
                message = "Diagnosis added successfully",
                id = diagnosis.Id,
                assignedRisk = riskLevel,
                todayCount = todayCasesCount,
                alertStatus = outbreakAlert
            });
        }

        // 11. شاشة الإشعارات (GET)
        [HttpGet("notifications-board")]
        public async Task<IActionResult> GetNotificationsBoard()
        {
            var diseases = await _context.DangerousDiseases.ToListAsync();

            var activeCases = await _context.Diagnoses
                .Where(d => d.IsReported == false)
                .GroupBy(d => d.Diagnosis1)
                .Select(g => new { DiseaseName = g.Key, Count = g.Count() })
                .ToDictionaryAsync(x => x.DiseaseName, x => x.Count);

            var notificationsList = diseases.Select(d => {
                int count = activeCases.ContainsKey(d.DiseaseName) ? activeCases[d.DiseaseName] : 0;

                string shippingStatus = "No cases";
                if (count > 0)
                {
                    if (d.RiskLevel == "Strong")
                        shippingStatus = "⚠️ Daily report needed";
                    else if (d.RiskLevel == "Medium")
                        shippingStatus = "Weekly report needed";
                    else if (d.RiskLevel == "Weak")
                        shippingStatus = "Monthly report needed";
                }

                return new NotificationDto
                {
                    DiseaseName = d.DiseaseName,
                    RiskLevel = d.RiskLevel,
                    ActiveCount = count,
                    ShippingStatus = shippingStatus
                };
            });

            return Ok(new { Notifications = notificationsList });
        }

        // 12. إنذارات التفشي المبكر (GET)
        [HttpGet("early-alerts")]
        public async Task<IActionResult> GetEarlyAlerts()
        {
            var today = DateTime.Today;

            var allDiagnoses = await _context.Diagnoses
                .Where(d => d.DiagnosisDate >= today)
                .GroupBy(d => d.Diagnosis1)
                .Select(g => new { Diagnosis = g.Key, Count = g.Count() })
                .ToListAsync();

            var limits = await _context.OutbreakLimits.ToDictionaryAsync(l => l.Diagnosis, l => l.Limit);

            var earlyAlerts = new List<EarlyAlertDto>();

            foreach (var item in allDiagnoses)
            {
                int limit = limits.GetValueOrDefault(item.Diagnosis, 100);
                if (item.Count >= limit)
                {
                    earlyAlerts.Add(new EarlyAlertDto
                    {
                        DiseaseName = item.Diagnosis,
                        CurrentCases = item.Count,
                        AllowedLimit = limit,
                        AlertTime = DateTime.Now,
                        AlertMessage = "⚠️ Early outbreak alert (send to ministry)"
                    });
                }
            }

            return Ok(new { EarlyOutbreakAlerts = earlyAlerts });
        }

        private int GetWeekNumber(DateTime date)
        {
            var culture = System.Globalization.CultureInfo.InvariantCulture;
            return culture.Calendar.GetWeekOfYear(date,
                System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}


