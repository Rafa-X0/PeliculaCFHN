
using PeliculasCFHN.ClienteBlazor.Models;

namespace PeliculasCFHN.ClienteBlazor.Services
{
    public interface IPeliculaService
    {
        Task<IEnumerable<Pelicula>> GetAll();
        Task<IEnumerable<Pelicula>> GetByGenero(int idGenero);
        Task<IEnumerable<Pelicula>> GetByDirector(int idDirector);
        Task<Pelicula> GetById(int id);
    }
}
