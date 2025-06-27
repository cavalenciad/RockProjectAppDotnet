using Microsoft.EntityFrameworkCore;
using RockProjectBackend.Data;
using RockProjectBackend.Interfaces;
using RockProjectBackend.Models;

namespace RockProjectBackend.Repositories
{
    public class ArtistaRepository : IArtistaRepository
    {
        private readonly AppDbContext _context;

        public ArtistaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Artista>> GetAllAsync()
        {
            return await _context.Artistas.ToListAsync();
        }

        public async Task<Artista?> GetByIdAsync(int id)
        {
            return await _context.Artistas.FindAsync(id);
        }

        public async Task<Artista> CreateAsync(Artista artista)
        {
            _context.Artistas.Add(artista);
            await _context.SaveChangesAsync();
            return artista;
        }

    }
}
