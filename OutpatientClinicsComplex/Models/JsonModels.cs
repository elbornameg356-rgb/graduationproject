using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace OutpatientClinicsComplex.Models
{
    public class JsonDoctor
    {
        [JsonPropertyName("كود الطبيب")] public int Code { get; set; }
        [JsonPropertyName("كلمة المرور")] public string Password { get; set; } = null!;
    }

    public class JsonPharmacist
    {
        [JsonPropertyName("كود الصيدلي")] public int Code { get; set; }
        [JsonPropertyName("كلمة المرور")] public string Password { get; set; } = null!;
    }

    public class JsonLabTechnician
    {
        [JsonPropertyName("كود التقني")] public int Code { get; set; }
        [JsonPropertyName("كلمة المرور")] public string Password { get; set; } = null!;
    }

    public class JsonReceptionist
    {
        [JsonPropertyName("كود الاستقبال")] public int Code { get; set; }
        [JsonPropertyName("كلمة المرور")] public string Password { get; set; } = null!;
    }

    public class JsonPatientHistory
    {
        [JsonPropertyName("ID")] public int Id { get; set; }
        [JsonPropertyName("الرقم القومي")] public long NationalId { get; set; }
        [JsonPropertyName("الاسم الكامل")] public string FullName { get; set; } = null!;
        [JsonPropertyName("تاريخ الميلاد")] public string? DateOfBirth { get; set; }
        [JsonPropertyName("الجنس")] public string? Gender { get; set; }
        [JsonPropertyName("الهاتف")] public string? Phone { get; set; }
        [JsonPropertyName("فصيلة الدم")] public string? BloodType { get; set; }
        [JsonPropertyName("أمراض مزمنة")] public string? ChronicDiseases { get; set; }
        [JsonPropertyName("الحساسيات")] public string? Allergies { get; set; }
        [JsonPropertyName("كود الطبيب")] public int? DoctorCode { get; set; }
        [JsonPropertyName("كود الاستقبال")] public int? ReceptionistCode { get; set; }
    }

    public class JsonDiagnosis
    {
        [JsonPropertyName("ID")] public int Id { get; set; }
        [JsonPropertyName("الرقم القومي")] public long NationalId { get; set; }
        [JsonPropertyName("التشخيص")] public string DiagnosisText { get; set; } = null!;
        [JsonPropertyName("كود الطبيب")] public int? DoctorCode { get; set; }
        [JsonPropertyName("تاريخ التشخيص")] public string DiagnosisDate { get; set; } = null!;
        [JsonPropertyName("Dangerous?")] public string? IsDangerous { get; set; }
        [JsonPropertyName("Risk Level")] public string? RiskLevel { get; set; }
        [JsonPropertyName("الجنس")] public string? Gender { get; set; }
        [JsonPropertyName("العمر")] public int? Age { get; set; }
        [JsonPropertyName("تأكيد المعمل")] public string? LabConfirmed { get; set; }
        [JsonPropertyName("حاله الابلاغ")] public string? IsReported { get; set; }
        [JsonPropertyName("Month")] public int Month { get; set; }
        [JsonPropertyName("Year")] public int Year { get; set; }
        [JsonPropertyName("Week Number")] public int WeekNumber { get; set; }
    }

    public class JsonAppointment
    {
        [JsonPropertyName("ID")] public int Id { get; set; }
        [JsonPropertyName("تاريخ الموعد")] public string AppointmentDate { get; set; } = null!;
        [JsonPropertyName("وقت البدء")] public string StartTime { get; set; } = null!;
        [JsonPropertyName("وقت الانتهاء")] public string EndTime { get; set; } = null!;
        [JsonPropertyName("المدة بالدقائق")] public int DurationMinutes { get; set; }
        [JsonPropertyName("الحالة")] public string? Status { get; set; }
        [JsonPropertyName("كود الاستقبال")] public int? ReceptionistCode { get; set; }
        [JsonPropertyName("كود الطبيب")] public int? DoctorCode { get; set; }
        [JsonPropertyName("ID المريض")] public int? PatientId { get; set; }
        [JsonPropertyName("الرقم القومي للمريض")] public long? PatientNationalId { get; set; }
    }

   
 
    public class JsonPrescription
    {
        [JsonPropertyName("ID")] public int Id { get; set; }
        [JsonPropertyName("الرقم القومي")] public long NationalId { get; set; }
        [JsonPropertyName("تاريخ الروشتة")] public string PrescriptionDate { get; set; } = null!;
        [JsonPropertyName("الأدوية")] public string Medicines { get; set; } = null!;
        [JsonPropertyName("الحالة")] public string? Status { get; set; }
        [JsonPropertyName("كود الطبيب")] public int DoctorCode { get; set; }
        [JsonPropertyName("كود الصيدلي")] public int? PharmacistCode { get; set; }
    }
    public class JsonDangerousDisease
    {
        [JsonPropertyName("اسم المرض")] public string DiseaseName { get; set; } = null!;
        [JsonPropertyName("مستوى الخطورة")] public string RiskLevel { get; set; } = null!;
    }

    public class JsonReportSetting
    {
        [JsonPropertyName("نوع التقرير")] public string ReportType { get; set; } = null!;
        [JsonPropertyName("تاريخ المرجع")] public string ReferenceDate { get; set; } = null!;
        [JsonPropertyName("التشخيص")] public string Diagnosis { get; set; } = null!;
        [JsonPropertyName("Limit")] public int Limit { get; set; }
    }

    public class JsonOutbreakLimit
    {
        [JsonPropertyName("التشخيص")] public string Diagnosis { get; set; } = null!;
        [JsonPropertyName("Limit")] public int Limit { get; set; }
    }
    public class JsonRequiredTest
    {
        [JsonPropertyName("ID")] public int Id { get; set; }
        [JsonPropertyName("الرقم القومي")] public long NationalId { get; set; }
        [JsonPropertyName("تاريخ الطلب")] public string RequestDate { get; set; } = null!;
        [JsonPropertyName("التحاليل المطلوبة")] public string RequiredTestsText { get; set; } = null!;
        [JsonPropertyName("كود الطبيب")] public int? DoctorCode { get; set; }
        [JsonPropertyName("كود التقني")] public int? LabTechnicianCode { get; set; }
        [JsonPropertyName("الحالة")] public string? Status { get; set; }
    }

    public class JsonTestResult
    {
        [JsonPropertyName("ID")] public int Id { get; set; }
        [JsonPropertyName("الرقم القومي")] public long NationalId { get; set; }
        [JsonPropertyName("كود الطلب")] public int RequiredTestId { get; set; }
        [JsonPropertyName("النتيجة")] public string ResultTests { get; set; } = null!;
        [JsonPropertyName("كود التقني")] public int? LabTechnicianCode { get; set; }
    }
   
  

    public class JsonDatasetRoot
    {
        public List<JsonDoctor>? Doctors { get; set; }
        public List<JsonPharmacist>? Pharmacists { get; set; }
        public List<JsonLabTechnician>? LabTechnicians { get; set; }
        public List<JsonReceptionist>? Receptionists { get; set; }
        public List<JsonPatientHistory>? PatientHistories { get; set; }
        public List<JsonDiagnosis>? Diagnoses { get; set; }
        public List<JsonAppointment>? Appointments { get; set; }
        public List<JsonDangerousDisease>? DangerousDiseases { get; set; }
        public List<JsonReportSetting>? Settings { get; set; }  // الـ Settings اللي فيها التقارير والـ Limits مع بعض
        public List<JsonOutbreakLimit>? OutbreakLimits { get; set; }

        public List<JsonPrescription>? Prescriptions { get; set; }
        public List<JsonRequiredTest>? RequiredTests { get; set; }
        public List<JsonTestResult>? TestResults { get; set; }
    
    }
}