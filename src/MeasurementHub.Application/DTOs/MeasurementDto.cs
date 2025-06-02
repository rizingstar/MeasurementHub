using MeasurementHub.Domain.Entities;

namespace MeasurementHub.Application.DTOs
{
    public class MeasurementDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public DateTime Timestamp { get; set; }
        public string CompanyName { get; set; }
        public string? Notes { get; set; }
        public MeasurementStatus Status { get; set; }
    }
}
