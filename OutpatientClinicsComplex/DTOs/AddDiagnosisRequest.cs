namespace OutpatientClinicsComplex.DTOs
{
    public class AddDiagnosisRequest
    {
        public long NationalId { get; set; }
        public string Diagnosis { get; set; } = null!;
        public int DoctorCode { get; set; }
        public bool LabConfirmed { get; set; }
    }
}