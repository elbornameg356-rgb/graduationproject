namespace OutpatientClinicsComplex.DTOs
{
    public class DiagnosisDto
    {
        public int Id { get; set; }
        public long NationalId { get; set; }
        public string Diagnosis1 { get; set; } = null!;
        public int? DoctorCode { get; set; }
        public DateTime DiagnosisDate { get; set; }
        public bool? IsDangerous { get; set; }
        public string? RiskLevel { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public bool? LabConfirmed { get; set; }
        public bool? IsReported { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int WeekNumber { get; set; }
    }
}
