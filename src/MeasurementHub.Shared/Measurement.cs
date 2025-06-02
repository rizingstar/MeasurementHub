// Measurement.cs
using System.ComponentModel.DataAnnotations;

namespace MeasurementHub.Shared
{
    public class Measurement
    {
        public Guid Id { get; set; }

        [Required, StringLength(100, MinimumLength = 2)]
        public string Type { get; set; }

        [Range(0, 1000)]
        public decimal Value { get; set; }

        [Required]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [Required, StringLength(200)]
        public string CompanyName { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }

        [Required]
        public MeasurementStatus Status { get; set; }
    }
}
