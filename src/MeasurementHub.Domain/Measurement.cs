namespace MeasurementHub.Domain
{
    public class Measurement
    {
        public Guid Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public decimal Value { get; set; }
        public DateTime Timestamp { get; set; }
        public string CompanyName { get; set; } = string.Empty;
    }
}
