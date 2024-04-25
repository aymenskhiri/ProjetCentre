using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PfaFinal.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PfaFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalleController : ControllerBase
    {
        private readonly Dbcontext _context; // Update to use your DbContext

        public SalleController(Dbcontext context)
        {
            _context = context;   
        }                            

        // GET: api/Salle
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Salle>>> GetSalles()
        {
            return await _context.Salles.ToListAsync();
        }

        // GET: api/Salle/
        [HttpGet("{id}")]
        public async Task<ActionResult<Salle>> GetSalleById(int id)
        {
            var salle = await _context.Salles.FindAsync(id);

            if (salle == null)
            {
                return NotFound();
            }

            return salle;
        }

        // POST: api/Salle
        [HttpPost("CreateSalle")]
        public async Task<ActionResult<Salle>> CreateSalle(Salle salle)
        {
            _context.Salles.Add(salle);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetSalleById), new { id = salle.Id }, salle);
        }

        // PUT: api/Salle/
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSalle(int id, Salle salle)
        {
            if (id != salle.Id)
            {
                return BadRequest();
            }

            _context.Entry(salle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalleExists(id))
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

        // DELETE: api/Salle/
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalle(int id)
        {
            var salle = await _context.Salles.FindAsync(id);
            if (salle == null)
            {
                return NotFound();
            }
               
            _context.Salles.Remove(salle);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalleExists(int id)
        {
            return _context.Salles.Any(e => e.Id == id);
        }
    }
}


