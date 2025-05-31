using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using MeasurementHub.Client.Models;

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
            return await _httpClient.GetFromJsonAsync<List<Measurement>>("api/Measurements");
        }
        public async Task<bool> AddMeasurementAsync(string type, decimal value, string companyName)
        {
            var createCommand = new
            {
                Type = type,
                Value = value,
                CompanyName = companyName
            };

            var response = await _httpClient.PostAsJsonAsync("api/Measurements", createCommand);
            return response.IsSuccessStatusCode;
        }
    }
}
