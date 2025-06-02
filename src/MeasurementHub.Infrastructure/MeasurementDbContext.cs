using MeasurementHub.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeasurementHub.Infrastructure
{
    public class MeasurementDbContext : DbContext
    {
        public DbSet<Measurement> Measurements => Set<Measurement>();

        public MeasurementDbContext(DbContextOptions<MeasurementDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Measurement>()
                .Property(m => m.Value)
                .HasPrecision(18, 4); // <--- adjust precision/scale as needed

            modelBuilder.Entity<Measurement>()
                .Property(m => m.Status)
                .HasConversion<string>();
        }
    }
}
