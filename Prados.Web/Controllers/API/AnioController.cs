using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;
using Prados.Web.Data.Entities;

namespace Prados.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnioController : ControllerBase
    {
        private readonly DataContext _context;

        public AnioController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Anio
        [HttpGet]
        public IEnumerable<Aniostbl> GetAniostbls()
        {
            return _context.Aniostbls;
        }

        // GET: api/Anio/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAniostbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aniostbl = await _context.Aniostbls.FindAsync(id);

            if (aniostbl == null)
            {
                return NotFound();
            }

            return Ok(aniostbl);
        }

        // PUT: api/Anio/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAniostbl([FromRoute] int id, [FromBody] Aniostbl aniostbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != aniostbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(aniostbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AniostblExists(id))
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

        // POST: api/Anio
        [HttpPost]
        public async Task<IActionResult> PostAniostbl([FromBody] Aniostbl aniostbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Aniostbls.Add(aniostbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAniostbl", new { id = aniostbl.Id }, aniostbl);
        }

        // DELETE: api/Anio/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAniostbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aniostbl = await _context.Aniostbls.FindAsync(id);
            if (aniostbl == null)
            {
                return NotFound();
            }

            _context.Aniostbls.Remove(aniostbl);
            await _context.SaveChangesAsync();

            return Ok(aniostbl);
        }

        private bool AniostblExists(int id)
        {
            return _context.Aniostbls.Any(e => e.Id == id);
        }
    }
}