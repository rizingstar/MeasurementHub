using MediatR;

namespace MeasurementHub.Application.Measurements.Commands
{
    public record DeleteMeasurementCommand(Guid Id) : IRequest<bool>;
}
