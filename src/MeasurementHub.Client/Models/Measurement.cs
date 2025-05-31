namespace MeasurementHub.Client.Models
{
    public class Measurement
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public DateTime Timestamp { get; set; }
        public string CompanyName { get; set; }
    }
}
