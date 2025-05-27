using MediatR;

namespace MeasurementHub.Application.Measurements.Commands
{
    public record CreateMeasurementCommand(string Type, decimal Value, string CompanyName) : IRequest<Guid>;
}
