namespace OutpatientClinicsComplex.DTOs
{
    public class DispensePrescriptionRequest
    {
        public int PrescriptionId { get; set; }
        public long NationalId { get; set; }
        public int PharmacistCode { get; set; }
    }
}