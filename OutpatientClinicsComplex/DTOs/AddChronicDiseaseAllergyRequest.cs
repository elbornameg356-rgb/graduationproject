namespace OutpatientClinicsComplex.DTOs
{
    public class AddChronicDiseaseAllergyRequest
    {
        public long NationalId { get; set; }
        public string? Disease { get; set; }
        public string? Allergy { get; set; }
    }
}