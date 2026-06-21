namespace OutpatientClinicsComplex.DTOs
{
    public class EarlyAlertDto
    {
        public string DiseaseName { get; set; } = null!;
        public int CurrentCases { get; set; }
        public int AllowedLimit { get; set; }
        public DateTime AlertTime { get; set; }
        public string AlertMessage { get; set; } = null!;
    }
}
