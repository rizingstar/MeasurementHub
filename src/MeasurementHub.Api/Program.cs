using MeasurementHub.Domain.Interfaces;
using MeasurementHub.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore; // Add this using directive for 'UseInMemoryDatabase'

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MeasurementDbContext>(options =>
    options.UseInMemoryDatabase("MeasurementDb")); // This requires the Microsoft.EntityFrameworkCore namespace

builder.Services.AddScoped<IMeasurementRepository, MeasurementRepository>();
builder.Services.AddMediatR(typeof(CreateMeasurementCommandHandler).Assembly);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
