using MeasurementHub.Application.Measurements.Commands;
using MeasurementHub.Domain.Entities;
using MeasurementHub.Domain.Interfaces;
using MediatR;


namespace MeasurementHub.Application.Measurements.Handlers
{
    public class CreateMeasurementCommandHandler : IRequestHandler<CreateMeasurementCommand, Guid>
    {
        private readonly IMeasurementRepository _repo;

        public CreateMeasurementCommandHandler(IMeasurementRepository repo)
        {
            _repo = repo;
        }

        public async Task<Guid> Handle(CreateMeasurementCommand request, CancellationToken cancellationToken)
        {
            var measurement = new Measurement
            {
                Id = Guid.NewGuid(), // Optional: EF Core can auto-generate this too
                Type = request.Type,
                Value = request.Value,
                CompanyName = request.CompanyName,
                Timestamp = DateTime.UtcNow
            };

            await _repo.AddAsync(measurement);
            return measurement.Id;
        }
    }
} // End of namespace