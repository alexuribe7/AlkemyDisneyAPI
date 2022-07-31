using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DisneyAPI.Data;
using DisneyAPI.Model;
using AutoMapper;
using DisneyAPI.DTO;
using AutoMapper.QueryableExtensions;

namespace DisneyAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("characters")]
    [ApiController]
    public class PersonajesController : ControllerBase
    {
        private readonly DisneyAPIContext _context;
        private readonly IMapper _mapper;

        public PersonajesController(DisneyAPIContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        // GET: api/Personajes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personaje>>> GetPersonaje()
        {
          if (_context.Personaje == null)
          {
              return NotFound();
          }
            return await _context.Personaje.ToListAsync();
        }

        //prueba DTo
        /*
        // GET: api/Personajes
        [HttpGet("GetPersonajeTO")]
        public async Task<ActionResult<List<PersonajeDTO>>> Get()
        {
            var personajes = await _context.Personaje.ToListAsync();
            return _mapper.Map<List<PersonajeDTO>>(personajes);
        }
        */

        //------------------
        //Listar por la Clase DTO PersonajeDTO

        [HttpGet("ListadoPersonajeNombre")]
        public async Task<ActionResult<IEnumerable<PersonajeDTO>>> GetProjectTo()
        {

            return await _context.Personaje.ProjectTo<PersonajeDTO>(_mapper.ConfigurationProvider).ToListAsync();
        }

        //------------------

        // GET: api/Personajes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Personaje>> GetPersonaje(int id)
        {
          if (_context.Personaje == null)
          {
              return NotFound();
          }
            var personaje = await _context.Personaje.FindAsync(id);

            if (personaje == null)
            {
                return NotFound();
            }

            return personaje;
        }

        // PUT: api/Personajes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonaje(int id, Personaje personaje)
        {
            if (id != personaje.PersonajeId)
            {
                return BadRequest();
            }

            _context.Entry(personaje).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonajeExists(personaje.Nombre))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Personajes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Personaje>> PostPersonaje(Personaje personaje)
        {
          if (_context.Personaje == null)
          {
              return Problem("Entity set 'DisneyAPIContext.Personaje'  is null.");
          }
            _context.Personaje.Add(personaje);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PersonajeExists(personaje.Nombre))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPersonaje", new { id = personaje.Nombre }, personaje);
        }

        // DELETE: api/Personajes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonaje(int id)
        {
            if (_context.Personaje == null)
            {
                return NotFound();
            }
            var personaje = await _context.Personaje.FindAsync(id);
            if (personaje == null)
            {
                return NotFound();
            }

            _context.Personaje.Remove(personaje);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonajeExists(string id)
        {
            return (_context.Personaje?.Any(e => e.Nombre == id)).GetValueOrDefault();
        }
    }
}
