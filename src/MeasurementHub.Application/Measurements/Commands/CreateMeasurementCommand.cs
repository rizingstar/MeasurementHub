using MeasurementHub.Domain.Entities;
using MediatR;

namespace MeasurementHub.Application.Measurements.Commands
{
    public record CreateMeasurementCommand(
    string Type,
    decimal Value,
    DateTime Timestamp,
    string CompanyName,
    string? Notes,
    MeasurementStatus Status
) : IRequest<Guid>;
}
