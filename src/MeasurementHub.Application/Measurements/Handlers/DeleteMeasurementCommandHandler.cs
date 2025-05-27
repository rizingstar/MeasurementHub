using MeasurementHub.Application.Measurements.Commands;
using MeasurementHub.Domain.Interfaces;
using MediatR;

namespace MeasurementHub.Application.Measurements.Handlers
{
    public class DeleteMeasurementCommandHandler : IRequestHandler<DeleteMeasurementCommand, bool>
    {
        private readonly IMeasurementRepository _repo;

        public DeleteMeasurementCommandHandler(IMeasurementRepository repo)
        {
            _repo = repo;
        }

        public async Task<bool> Handle(DeleteMeasurementCommand request, CancellationToken cancellationToken)
        {
            var entity = await _repo.GetByIdAsync(request.Id);
            if (entity == null) return false;

            await _repo.DeleteAsync(entity);
            return true;
        }
    }
}
