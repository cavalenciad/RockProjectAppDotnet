using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RockProjectBackend.Interfaces;
using RockProjectBackend.Models;
using RockProjectBackend.Services;

namespace RockProjectBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistaController : ControllerBase
    {
        private readonly IArtistaService _artistaService;
        private readonly ILogger<ArtistaController> _logger;

        public ArtistaController(IArtistaService artistaService, ILogger<ArtistaController> logger)
        {
            _artistaService = artistaService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artista>>> GetAllArtistas()
        {
            try
            {
                var artistas = await _artistaService.GetAllArtistasAsync();
                return Ok(artistas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving artistas");
                return StatusCode(500, $"Error interno del servidor: {ex.Message} --- StackTrace: {ex.StackTrace}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Artista>> GetArtistaById(int id)
        {
            var artista = await _artistaService.GetArtistaByIdAsync(id);
            
            if (artista is null)
                return NotFound();

            return Ok(artista!);
        }

        [HttpPost]
        public async Task<ActionResult<Artista>> CreateArtista([FromBody] Artista artista)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                var createdArtista = await _artistaService.CreateArtistaAsync(artista);
                
                if (createdArtista == null)
                    return BadRequest("Invalid artist data");

                return CreatedAtAction(nameof(GetArtistaById), 
                    new { id = createdArtista.Id }, createdArtista);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
