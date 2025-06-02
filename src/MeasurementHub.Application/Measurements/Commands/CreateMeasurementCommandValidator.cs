using FluentValidation;

namespace MeasurementHub.Application.Measurements.Commands
{
    public class CreateMeasurementCommandValidator : AbstractValidator<CreateMeasurementCommand>
    {
        public CreateMeasurementCommandValidator()
        {
            RuleFor(x => x.Type).NotEmpty().Length(2, 100);
            RuleFor(x => x.Value).InclusiveBetween(0, 1000);
            RuleFor(x => x.CompanyName).NotEmpty().MaximumLength(200);
            RuleFor(x => x.Timestamp).LessThanOrEqualTo(DateTime.UtcNow);
        }
    }
}
