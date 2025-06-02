using MeasurementHub.Shared;
using System.Net.Http.Json;

namespace MeasurementHub.Client.Services
{
    public class MeasurementService
    {
        private readonly HttpClient _httpClient;
        public MeasurementService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Measurement>> GetMeasurementsAsync()
        {
            var clientMeasurements = await _httpClient.GetFromJsonAsync<List<Models.Measurement>>("api/measurements");
            return clientMeasurements?.Select(m => new Measurement
            {
                Id = m.Id,
                Type = m.Type,
                Value = m.Value,
                Timestamp = m.Timestamp,
                CompanyName = m.CompanyName,
                Notes = m.Notes,
                Status = (MeasurementStatus)m.Status
            }).ToList() ?? new List<Measurement>();
        }
        public async Task<bool> AddMeasurementAsync(Models.Measurement measurement)
        {
            var response = await _httpClient.PostAsJsonAsync("api/measurements", measurement);
            return response.IsSuccessStatusCode;
        }
    }
}
