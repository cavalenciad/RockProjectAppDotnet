using RockProjectBackend.Models;

namespace RockProjectBackend.Interfaces
{
    public interface IArtistaRepository
    {
        Task<IEnumerable<Artista>> GetAllAsync();
        Task<Artista?> GetByIdAsync(int id);
        Task<Artista> CreateAsync(Artista artista);
    }
}