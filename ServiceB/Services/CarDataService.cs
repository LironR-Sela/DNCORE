using Microsoft.Extensions.Configuration;
using MSDemo.Models;
using Newtonsoft.Json;
using ServiceB.Infra;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServiceB.Services
{
    public class CarDataService : IDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public CarDataService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<Car> GetData()
        {
            var url = _configuration["DataServiceUrl"];
            var response = await _httpClient.GetAsync($"{url}/api/car");
            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<Car>(await response.Content.ReadAsStringAsync());
                return data;
            }

            return null;
        }
    }
}
