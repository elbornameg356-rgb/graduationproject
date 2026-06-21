namespace OutpatientClinicsComplex.DTOs
{
    public class SearchPatientRequest
    {
        public long NationalId { get; set; }
        public int ReceptionistCode { get; set; }
    }
}