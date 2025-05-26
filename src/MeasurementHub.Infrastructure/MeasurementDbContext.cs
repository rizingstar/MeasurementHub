using MeasurementHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeasurementHub.Infrastructure
{
    public class MeasurementDbContext : DbContext
    {
        public DbSet<Measurement> Measurements => Set<Measurement>();

        public MeasurementDbContext(DbContextOptions<MeasurementDbContext> options) : base(options) { }
    }
}
