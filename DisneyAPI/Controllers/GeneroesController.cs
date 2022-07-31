using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DisneyAPI.Data;
using DisneyAPI.Model;
using Microsoft.AspNetCore.Authorization;

namespace DisneyAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroesController : ControllerBase
    {
        private readonly DisneyAPIContext _context;

        public GeneroesController(DisneyAPIContext context)
        {
            _context = context;
        }

        // GET: api/Generoes
        [HttpGet]
        //[Authorize] // SOLO USUARIOS AUTENTICADOS
        public async Task<ActionResult<IEnumerable<Genero>>> GetGenero()
        {
          if (_context.Genero == null)
          {
              return NotFound();
          }
            return await _context.Genero.ToListAsync();
        }

        // GET: api/Generoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Genero>> GetGenero(int id)
        {
          if (_context.Genero == null)
          {
              return NotFound();
          }
            var genero = await _context.Genero.FindAsync(id);

            if (genero == null)
            {
                return NotFound();
            }

            return genero;
        }

        // PUT: api/Generoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGenero(int id, Genero genero)
        {
            if (id != genero.GeneroId)
            {
                return BadRequest();
            }

            _context.Entry(genero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GeneroExists(id))
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

        // POST: api/Generoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Genero>> PostGenero(Genero genero)
        {
          if (_context.Genero == null)
          {
              return Problem("Entity set 'DisneyAPIContext.Genero'  is null.");
          }
            _context.Genero.Add(genero);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGenero", new { id = genero.GeneroId }, genero);
        }

        // DELETE: api/Generoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGenero(int id)
        {
            if (_context.Genero == null)
            {
                return NotFound();
            }
            var genero = await _context.Genero.FindAsync(id);
            if (genero == null)
            {
                return NotFound();
            }

            _context.Genero.Remove(genero);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GeneroExists(int id)
        {
            return (_context.Genero?.Any(e => e.GeneroId == id)).GetValueOrDefault();
        }
    }
}
