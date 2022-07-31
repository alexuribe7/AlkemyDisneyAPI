using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisneyAPI.Model
{
    public class Personaje
    {
        [Key]
        public int PersonajeId { get; set; }
        public string ? Imagen { get; set; }
        //public byte[] Photo { get; set; }

        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }
        [Required]
        public int Edad { get; set; }
        [Required]
        public float Peso { get; set; }
        [Required]
        [StringLength(50)]
        public string? Historia { get; set; }

        [Required]
        [StringLength(50)]
        public string? Pelicula { get; set; }

        
        //Foreign key for Genero
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public virtual Genero? Genero { get; set; }
        
        

       

        /*
        public ICollection<Pelicula>? Peliculas { get; set; }
        */

    }
}
