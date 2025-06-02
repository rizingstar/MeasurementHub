using MeasurementHub.Application.DTOs;
using MeasurementHub.Application.Measurements.Queries;
using MeasurementHub.Domain.Interfaces;
using MediatR;

namespace MeasurementHub.Application.Measurements.Handlers
{
    public class GetAllMeasurementsQueryHandler : IRequestHandler<GetAllMeasurementsQuery, List<MeasurementDto>>
    {
        private readonly IMeasurementRepository _repo;

        public GetAllMeasurementsQueryHandler(IMeasurementRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<MeasurementDto>> Handle(GetAllMeasurementsQuery request, CancellationToken cancellationToken)
        {
            var data = await _repo.GetAllAsync();
            return data.Select(m => new MeasurementDto
            {
                Id = m.Id,
                Type = m.Type,
                Value = m.Value,
                Timestamp = m.Timestamp,
                CompanyName = m.CompanyName,
                Notes = m.Notes,         
                Status = m.Status        
            }).ToList();
        }
    }
}
