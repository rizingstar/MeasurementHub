using MeasurementHub.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Telerik.Blazor.Services;
using MeasurementHub.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Hardcoded for dev; swap with config as needed!
builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri("https://localhost:7213/") }
);

builder.Services.AddTelerikBlazor();
builder.Services.AddScoped<MeasurementService>();

await builder.Build().RunAsync();
