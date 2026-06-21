namespace OutpatientClinicsComplex.DTOs
{
    public class AddTestResultRequest
    {
        public long NationalId { get; set; }
        public int RequiredTestId { get; set; }
        public string ResultTests { get; set; } = null!;
        public int LabTechnicianCode { get; set; }
    }
}