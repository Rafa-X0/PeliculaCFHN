
using PeliculasCFHN.ClienteBlazor.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace PeliculasCFHN.ClienteBlazor.Services
{
    public class PeliculaService : IPeliculaService
    {
        //implementación de dependencias de HttpClient
        private readonly HttpClient _httpClient;

        public PeliculaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //Configurar las opciones del serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Pelicula>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Pelicula");
            return JsonSerializer.Deserialize<IEnumerable<Pelicula>>(resp, options);
        }

        public async Task<IEnumerable<Pelicula>> GetByDirector(int idDirector)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Pelicula/Buscar", new { idDirector = idDirector });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Pelicula>>(respString, options);
        }

        public async Task<IEnumerable<Pelicula>> GetByGenero(int idGenero)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Pelicula/Buscar", new { idGenero = idGenero });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Pelicula>>(respString, options);
        }

        public async Task<Pelicula> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Pelicula/{id}");
            return JsonSerializer.Deserialize<Pelicula>(resp, options);
        }
    }
}
