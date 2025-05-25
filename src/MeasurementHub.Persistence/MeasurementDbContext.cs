using Microsoft.EntityFrameworkCore;
using MeasurementHub.Domain;

namespace MeasurementHub.Persistence
{
    public class MeasurementDbContext : DbContext
    {
        public MeasurementDbContext(DbContextOptions<MeasurementDbContext> options)
            : base(options) { }

        public DbSet<Measurement> Measurements { get; set; }
    }

}
