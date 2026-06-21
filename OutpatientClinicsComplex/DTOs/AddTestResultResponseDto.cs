namespace OutpatientClinicsComplex.DTOs
{
    public class AddTestResultResponseDto
    {
        public string Message { get; set; } = null!;
        public int TestResultId { get; set; }
        public int RequiredTestId { get; set; }
    }
}
