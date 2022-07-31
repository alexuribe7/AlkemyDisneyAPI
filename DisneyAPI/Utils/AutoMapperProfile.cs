using AutoMapper;
using DisneyAPI.Model;
using DisneyAPI.DTO;

namespace DisneyAPI.Utils
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            //Aquí van las reglas de mapeo <origen,destino>
            CreateMap<Personaje, PersonajeDTO>();
            CreateMap<Pelicula, PeliculaDTO>();
            CreateMap<Genero, GeneroDTO>();

        }
    }
}
