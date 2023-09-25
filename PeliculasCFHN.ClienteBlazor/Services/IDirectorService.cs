using PeliculasCFHN.ClienteBlazor.Models;

namespace PeliculasCFHN.ClienteBlazor.Services
{
    public interface IDirectorService
    {
        Task<IEnumerable<Director>> GetAll();
    }
}
