using MeasurementHub.Domain.Entities;
using MeasurementHub.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeasurementHub.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementsController : ControllerBase
    {
        private readonly MeasurementDbContext _db;

        public MeasurementsController(MeasurementDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Measurement>>> GetMeasurements()
            => await _db.Measurements.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Measurement>> GetMeasurement(Guid id)
        {
            var m = await _db.Measurements.FindAsync(id);
            if (m == null) return NotFound();
            return m;
        }

        [HttpPost]
        public async Task<ActionResult<Measurement>> PostMeasurement(Measurement measurement)
        {
            _db.Measurements.Add(measurement);
            await _db.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMeasurement), new { id = measurement.Id }, measurement);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMeasurement(Guid id, Measurement input)
        {
            var measurement = await _db.Measurements.FindAsync(id);
            if (measurement == null) return NotFound();

            measurement.Type = input.Type;
            measurement.Value = input.Value;
            measurement.Timestamp = input.Timestamp;
            measurement.CompanyName = input.CompanyName;

            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMeasurement(Guid id)
        {
            var measurement = await _db.Measurements.FindAsync(id);
            if (measurement == null) return NotFound();

            _db.Measurements.Remove(measurement);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
