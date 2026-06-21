namespace OutpatientClinicsComplex.DTOs
{
    public class PrescriptionDto
    {
        public int Id { get; set; }
        public long NationalId { get; set; }
        public DateOnly PrescriptionDate { get; set; }
        public string Medicines { get; set; } = null!;
        public string? Status { get; set; }
        public int DoctorCode { get; set; }
        public int? PharmacistCode { get; set; }
    }
}
