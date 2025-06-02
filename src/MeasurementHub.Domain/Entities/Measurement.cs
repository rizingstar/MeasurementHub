using System;
using System.ComponentModel.DataAnnotations;

namespace MeasurementHub.Domain.Entities
{
    public class Measurement
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Type must be 2-100 chars")]
        public string Type { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "Value must be between 0 and 1000")]
        public decimal Value { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        [Required]
        [StringLength(200, ErrorMessage = "Company name too long")]
        public string CompanyName { get; set; }

        // New field
        [StringLength(200)]
        public string? Notes { get; set; }

        // Example: Enum-based validation
        [Required]
        public MeasurementStatus Status { get; set; } = MeasurementStatus.Pending;
    }
}
