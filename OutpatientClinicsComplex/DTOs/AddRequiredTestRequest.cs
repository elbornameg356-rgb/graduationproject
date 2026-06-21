namespace OutpatientClinicsComplex.DTOs
{
    public class AddRequiredTestRequest
    {
        public long NationalId { get; set; }
        public string RequiredTests { get; set; } = null!;
        public int DoctorCode { get; set; }
    }
}
