// Models/OutbreakLimit.cs
namespace OutpatientClinicsComplex.Models
{
    public class OutbreakLimit
    {
        public string Diagnosis { get; set; } = null!;
        public int Limit { get; set; } = 100;
    }
}