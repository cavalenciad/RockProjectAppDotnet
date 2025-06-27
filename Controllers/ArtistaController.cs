using Microsoft.AspNetCore.Mvc;
using RockProjectBackend.Interfaces;
using RockProjectBackend.Models;
using RockProjectBackend.Services;

[ApiController]
[Route("api/[controller]")]
public class ArtistaController : ControllerBase
{
    private readonly IArtistaService _artistaService;

    public ArtistaController(IArtistaService artistaService)
    {
        _artistaService = artistaService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Artista>>> GetAllArtistas()
    {
        var artistas = await _artistaService.GetAllArtistasAsync();
        return Ok(artistas);
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

        // Validaciones adicionales para los nuevos campos
        if (!string.IsNullOrEmpty(artista.Resena) && artista.Resena.Length > 1000)
            return BadRequest("La reseña no puede exceder 1000 caracteres");

        if (!string.IsNullOrEmpty(artista.Imagen) && !Uri.IsWellFormedUriString(artista.Imagen, UriKind.Absolute))
            return BadRequest("La URL de la imagen no es válida");

        var createdArtista = await _artistaService.CreateArtistaAsync(artista);
        
        if (createdArtista == null)
            return BadRequest("Invalid artist data");

        return CreatedAtAction(nameof(GetArtistaById), 
            new { id = createdArtista.Id }, createdArtista);
    }
}
