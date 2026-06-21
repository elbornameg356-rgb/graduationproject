namespace OutpatientClinicsComplex.DTOs
{
    public class RegisterPatientRequest
    {
        public long NationalId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string BloodType { get; set; }
        public string ChronicDiseases { get; set; }
        public string Allergies { get; set; }
        public int DoctorCode { get; set; }
        public int ReceptionistCode { get; set; }
    }
}