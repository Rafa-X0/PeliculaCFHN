using PeliculasCFHN.ClienteBlazor.Models;

namespace PeliculasCFHN.ClienteBlazor.Services
{
    public interface IGeneroService
    {
        Task<IEnumerable<Genero>> GetAll();
    }
}
