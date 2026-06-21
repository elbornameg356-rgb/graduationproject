namespace OutpatientClinicsComplex.DTOs
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DateOnly AppointmentDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int DurationMinutes { get; set; }
        public string? Status { get; set; }
        public int? ReceptionistCode { get; set; }
        public int? DoctorCode { get; set; }
        public int? PatientId { get; set; }
        public long? PatientNationalId { get; set; }
    }
}
