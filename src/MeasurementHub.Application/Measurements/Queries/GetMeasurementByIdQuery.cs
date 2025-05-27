using MediatR;
using MeasurementHub.Application.DTOs;

namespace MeasurementHub.Application.Measurements.Queries
{
    public record GetMeasurementByIdQuery(Guid Id) : IRequest<MeasurementDto?>;
}
