namespace OutpatientClinicsComplex.DTOs
{
    public class BookAppointmentRequest
    {
        public int PatientId { get; set; }
        public long PatientNationalId { get; set; }
        public int DoctorCode { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public int ReceptionistCode { get; set; }
    }
}