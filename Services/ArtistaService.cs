using Microsoft.EntityFrameworkCore;
using RockProjectBackend.Data;
using RockProjectBackend.Interfaces;
using RockProjectBackend.Models;

namespace RockProjectBackend.Services
{
    public class ArtistaService : IArtistaService
    {
        private readonly AppDbContext _context;
        private readonly IArtistaRepository _artistaRepository;

        public ArtistaService(AppDbContext context, IArtistaRepository artistaRepository)
        {
            _context = context;
            _artistaRepository = artistaRepository ?? throw new ArgumentNullException(nameof(artistaRepository));
        }

        public async Task<IEnumerable<Artista>> GetAllArtistasAsync()
        {
            return await _context.Artistas.ToListAsync();
        }

        public async Task<Artista?> GetArtistaByIdAsync(int id)
        {
            if (id <= 0)
                return null;

            return await _artistaRepository.GetByIdAsync(id);
        }

        public async Task<Artista?> CreateArtistaAsync(Artista artista)
        {
            if (string.IsNullOrWhiteSpace(artista?.Nombre))
                return null;

            // Validar que la reseña no sea excesivamente larga
            if (!string.IsNullOrEmpty(artista.Resena) && artista.Resena.Length > 1000)
                return null;

            // Validar formato básico de URL para imagen
            if (!string.IsNullOrEmpty(artista.Imagen) && !Uri.IsWellFormedUriString(artista.Imagen, UriKind.Absolute))
                return null;

            return await _artistaRepository.CreateAsync(artista);
        }
    }
}
