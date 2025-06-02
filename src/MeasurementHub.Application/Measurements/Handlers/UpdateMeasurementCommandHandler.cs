using MeasurementHub.Application.Measurements.Commands;
using MeasurementHub.Domain.Interfaces;
using MediatR;


namespace MeasurementHub.Application.Measurements.Handlers
{
    /// <summary>
    /// Handler for creating a new measurement.
    /// </summary>
    /// <remarks>
    /// This handler processes the CreateMeasurementCommand and persists the new measurement to the repository.
    /// </remarks>
    public class UpdateMeasurementCommandHandler : IRequestHandler<UpdateMeasurementCommand, bool>
    {
        private readonly IMeasurementRepository _repo;

        public UpdateMeasurementCommandHandler(IMeasurementRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(UpdateMeasurementCommand request, CancellationToken cancellationToken)
        {
            var existing = await _repo.GetByIdAsync(request.Id);
            if (existing == null) return false;

            existing.Type = request.Type;
            existing.Value = request.Value;
            existing.Timestamp = request.Timestamp;
            existing.CompanyName = request.CompanyName;
            existing.Notes = request.Notes; 
            existing.Status = request.Status;    

            await _repo.UpdateAsync(existing);
            return true;
        }
    }
} // End of namespace