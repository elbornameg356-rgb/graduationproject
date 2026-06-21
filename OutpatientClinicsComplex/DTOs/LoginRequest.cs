namespace OutpatientClinicsComplex.DTOs
{
    public class LoginRequest
    {
        public string Role { get; set; } = null!;
        public int Code { get; set; }
        public string Password { get; set; }

    }
}
