using MeasurementHub.Application.DTOs;
using MeasurementHub.Application.Measurements.Handlers;
using MeasurementHub.Domain.Interfaces;
using MeasurementHub.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MeasurementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMeasurementRepository, MeasurementRepository>();
builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssembly(typeof(CreateMeasurementCommandHandler).Assembly);
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); // <-- ADD THIS LINE
builder.Services.AddAutoMapper(typeof(MeasurementDto).Assembly);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:7228")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                     .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
                     .AddEnvironmentVariables();

var app = builder.Build();

app.UseCors();

app.UseSwagger();
app.UseSwaggerUI(); // <-- It's also standard to add this line for the Swagger UI

app.MapControllers();

app.Run();
