// Models/DangerousDisease.cs
namespace OutpatientClinicsComplex.Models
{
    public class DangerousDisease
    {
        public string DiseaseName { get; set; } = null!;
        public string RiskLevel { get; set; } = null!; // Strong, Medium, Weak
    }
}