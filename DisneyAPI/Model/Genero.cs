using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisneyAPI.Model
{
    public class Genero
    {
        [Key]
        public int GeneroId { get; set; }
        public string? Imagen { get; set; }

        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string? Pelicula { get; set; }

        public ICollection<Personaje>? Personaje { get; set; }
        //public ICollection<Pelicula>? Peliculas { get; set; }

        /*
        public ICollection<Personaje>? Personajes { get; set; }
        public ICollection<Pelicula>? Peliculas { get; set; }
        */

    }
}
