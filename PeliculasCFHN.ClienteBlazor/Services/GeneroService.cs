using PeliculasCFHN.ClienteBlazor.Models;
using System.Text.Json;

namespace PeliculasCFHN.ClienteBlazor.Services
{
    public class GeneroService : IGeneroService
    {
        //Inyeccion de dependencias de HttpClient
        private readonly HttpClient _httpClient;

        public GeneroService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Genero>> GetAll()
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string resp = await _httpClient.GetStringAsync($"Genero");
            return JsonSerializer.Deserialize<IEnumerable<Genero>>(resp, options);
        }
    }
}
