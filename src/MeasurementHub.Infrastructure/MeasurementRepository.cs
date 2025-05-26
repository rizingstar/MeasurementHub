using MeasurementHub.Domain.Entities;
using MeasurementHub.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MeasurementHub.Infrastructure
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly MeasurementDbContext _context;
        public MeasurementRepository(MeasurementDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Measurement m)
        {
            _context.Measurements.Add(m);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Measurement>> GetAllAsync()
        {
            return await _context.Measurements.ToListAsync();
        }
    }
}
