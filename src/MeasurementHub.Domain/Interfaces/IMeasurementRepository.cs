using MeasurementHub.Domain.Entities;

namespace MeasurementHub.Domain.Interfaces
{
    public interface IMeasurementRepository
    {
        Task AddAsync(Measurement measurement);
        Task<IEnumerable<Measurement>> GetAllAsync();
        Task<Measurement?> GetByIdAsync(Guid id);
        Task UpdateAsync(Measurement measurement);
        Task DeleteAsync(Measurement measurement);
    }
}
