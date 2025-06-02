
using MeasurementHub.Application.DTOs;
using MeasurementHub.Application.Measurements.Queries;
using MeasurementHub.Domain.Interfaces;
using MediatR;

namespace MeasurementHub.Application.Measurements.Handlers
{
	public class GetMeasurementByIdQueryHandler : IRequestHandler<GetMeasurementByIdQuery, MeasurementDto?>
	{
		private readonly IMeasurementRepository _repo;

		public GetMeasurementByIdQueryHandler(IMeasurementRepository repo)
		{
			_repo = repo;
		}

        public async Task<MeasurementDto?> Handle(GetMeasurementByIdQuery request, CancellationToken cancellationToken)
        {
            var m = await _repo.GetByIdAsync(request.Id);
            if (m == null) return null;

            return new MeasurementDto
            {
                Id = m.Id,
                Type = m.Type,
                Value = m.Value,
                Timestamp = m.Timestamp,
                CompanyName = m.CompanyName,
                Notes = m.Notes,        
                Status = m.Status      
            };
        }
    }
}