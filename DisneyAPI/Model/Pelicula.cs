using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DisneyAPI.Model
{
    public class Pelicula
    {
        [Key]
        public int PeliculaId { get; set; }

        public string? Imagen { get; set; }

        [Required]
        [StringLength(50)]
        public string? Titulo { get; set; }  
        public DateTime FechaCreacion { get; set; }

        [Required]
        public int Calificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string? Personaje { get; set; }

        
        //Foreign key for Genero
        public int GeneroId { get; set; }
        public Genero? Genero { get; set; }


        /*
        [ForeignKey("Titulo")]
        public Genero? GeneroPelicula { get; set; }


        [ForeignKey("Personaje")]
        public Personaje? PersonajeNombre { get; set; }
        */




    }
}
