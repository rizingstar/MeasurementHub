using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MeasurementHub.Persistence
{
    public class MeasurementDbContextFactory : IDesignTimeDbContextFactory<MeasurementDbContext>
    {
        public MeasurementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MeasurementDbContext>();

            // Use your real connection string here (same as appsettings.json)
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MeasurementHubDb;Trusted_Connection=True;");

            return new MeasurementDbContext(optionsBuilder.Options);
        }
    }
}
