using System.ComponentModel.DataAnnotations;

namespace RockProjectBackend.Models
{
    public class Artista
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Nombre { get; set; }

        [StringLength(100)]
        public string? AlbumDestacado { get; set; }

        [StringLength(100)]
        public string? CancionDestacada { get; set; }

        [StringLength(50)]
        public string? Subgenero { get; set; }

        public string? Resena { get; set; }
        
        public string? Imagen { get; set; }
    }
}