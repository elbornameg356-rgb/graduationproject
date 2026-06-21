namespace OutpatientClinicsComplex.DTOs
{
    public class TestResultDto
    {
        public int Id { get; set; }
        public long NationalId { get; set; }
        public int RequiredTestId { get; set; }
        public string ResultTests { get; set; } = null!;
        public int? LabTechnicianCode { get; set; }
    }
}
