using PeliculasCFHN.ClienteBlazor.Models;
using System.Text.Json;

namespace PeliculasCFHN.ClienteBlazor.Services
{
    public class DirectorService : IDirectorService
    {
        //Inyeccion de dependencias de HttpClient
        private readonly HttpClient _httpClient;

        public DirectorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Director>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Director");
            return JsonSerializer.Deserialize<IEnumerable<Director>>(resp, options);
        }
    }
}
