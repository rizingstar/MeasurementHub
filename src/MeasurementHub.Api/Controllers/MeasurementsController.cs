using MeasurementHub.Application.DTOs;
using MeasurementHub.Application.Measurements.Commands;
using MeasurementHub.Application.Measurements.Queries;
using MeasurementHub.Shared;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MeasurementHub.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MeasurementsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MeasurementDto>>> Get()
        {
            var result = await _mediator.Send(new GetAllMeasurementsQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MeasurementDto>> GetById(Guid id)
        {
            var result = await _mediator.Send(new GetMeasurementByIdQuery(id));
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] Measurement model)
        {
            var statusEnum = (MeasurementHub.Domain.Entities.MeasurementStatus)
                Enum.Parse(typeof(MeasurementHub.Domain.Entities.MeasurementStatus), model.Status.ToString());


            // Pass all required params to the Command constructor
            var command = new CreateMeasurementCommand(
                model.Type,
                model.Value,
                model.Timestamp == default ? DateTime.UtcNow : model.Timestamp, // ensure not default
                model.CompanyName,
                model.Notes,
                statusEnum
            );

            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id }, id);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateMeasurementCommand command)
        {
            if (id != command.Id)
                return BadRequest("ID mismatch");

            var success = await _mediator.Send(command);
            if (!success) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var success = await _mediator.Send(new DeleteMeasurementCommand(id));
            if (!success) return NotFound();

            return NoContent();
        }
    }
}
