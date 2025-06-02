using MeasurementHub.Domain.Entities;
using MediatR;

namespace MeasurementHub.Application.Measurements.Commands
{
    public record UpdateMeasurementCommand(
    Guid Id,
    string Type,
    decimal Value,
    DateTime Timestamp,
    string CompanyName,
    string Notes, // or string? if nullable
    MeasurementStatus Status
) : IRequest<bool>;
}
