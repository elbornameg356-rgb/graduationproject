namespace OutpatientClinicsComplex.DTOs
{
    public class RequiredTestDto
    {
        public int Id { get; set; }
        public long NationalId { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequiredTests { get; set; } = null!;
        public int? DoctorCode { get; set; }
        public int? LabTechnicianCode { get; set; }
        public string? Status { get; set; }
    }
}
