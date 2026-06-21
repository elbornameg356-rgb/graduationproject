namespace OutpatientClinicsComplex.DTOs
{
    public class PatientBasicDto
    {
        public int Id { get; set; }
        public long NationalId { get; set; }
        public string FullName { get; set; } = null!;
        public string? Phone { get; set; }
    }
}
