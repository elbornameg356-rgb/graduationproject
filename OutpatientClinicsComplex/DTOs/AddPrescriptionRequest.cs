namespace OutpatientClinicsComplex.DTOs
{
    public class AddPrescriptionRequest
    {
        public long NationalId { get; set; }
        public string Medicines { get; set; } = null!;
        public int DoctorCode { get; set; }
    }
}