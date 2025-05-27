using MediatR;
using MeasurementHub.Application.DTOs;

namespace MeasurementHub.Application.Measurements.Queries
{
    public record GetAllMeasurementsQuery() : IRequest<List<MeasurementDto>>;
}
