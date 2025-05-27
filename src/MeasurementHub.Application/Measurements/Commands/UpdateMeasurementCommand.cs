using MediatR;

namespace MeasurementHub.Application.Measurements.Commands
{
    public record UpdateMeasurementCommand(Guid Id, string Type, decimal Value, DateTime Timestamp, string CompanyName) : IRequest<bool>;
}
