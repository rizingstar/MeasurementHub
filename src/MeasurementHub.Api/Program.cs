using MeasurementHub.Application.DTOs;
using MeasurementHub.Application.Measurements.Handlers;
using MeasurementHub.Domain.Interfaces;
using MeasurementHub.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MeasurementDbContext>(options =>
    options.UseInMemoryDatabase("MeasurementDb"));

builder.Services.AddScoped<IMeasurementRepository, MeasurementRepository>();
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssembly(typeof(CreateMeasurementCommandHandler).Assembly);
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // <-- ADD THIS LINE
builder.Services.AddAutoMapper(typeof(MeasurementDto).Assembly);
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                     .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
                     .AddEnvironmentVariables();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI(); // <-- It's also standard to add this line for the Swagger UI

app.MapControllers();

app.Run();
