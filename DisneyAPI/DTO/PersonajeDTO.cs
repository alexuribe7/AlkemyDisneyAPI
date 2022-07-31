using System.ComponentModel.DataAnnotations;

namespace DisneyAPI.DTO
{
    public class PersonajeDTO
    {
        //public int PersonajeId { get; set; }
        public string? Imagen { get; set; }
        //public byte[] Photo { get; set; }
        public string? Nombre { get; set; }

        public List<GeneroDTO> Generos { get; set; }

        //Foreign key for Genero
        //public int GeneroId { get; set; }


        /*
        public int Edad { get; set; }
        public float Peso { get; set; }
        public string? Historia { get; set; }
        public string? Pelicula { get; set; }
        */
    }
}
