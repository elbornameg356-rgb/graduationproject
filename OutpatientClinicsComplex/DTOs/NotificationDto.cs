namespace OutpatientClinicsComplex.DTOs
{
    public class NotificationDto
    {
        public string DiseaseName { get; set; } = null!;
        public string RiskLevel { get; set; } = null!;
        public int ActiveCount { get; set; }
        public string ShippingStatus { get; set; } = null!;
    }
}
