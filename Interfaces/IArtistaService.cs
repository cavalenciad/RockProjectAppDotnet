using RockProjectBackend.Models;

namespace RockProjectBackend.Interfaces
{
    public interface IArtistaService
    {
        Task<IEnumerable<Artista>> GetAllArtistasAsync();
        Task<Artista?> GetArtistaByIdAsync(int id);
        Task<Artista?> CreateArtistaAsync(Artista artista);
    }
}
