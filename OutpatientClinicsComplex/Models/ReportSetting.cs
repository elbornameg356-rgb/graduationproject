// Models/ReportSetting.cs
namespace OutpatientClinicsComplex.Models
{
    public class ReportSetting
    {
        public string ReportType { get; set; } = null!; // Daily, Weekly, Monthly
        public DateTime ReferenceDate { get; set; }
        public string Diagnosis { get; set; } = null!;
        public int Limit { get; set; } = 100;
    }
}