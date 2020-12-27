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
    public class TipoPersonaController : ControllerBase
    {
        private readonly DataContext _context;

        public TipoPersonaController(DataContext context)
        {
            _context = context;
        }

        // GET: api/TipoPersona
        [HttpGet]
        public IEnumerable<TipoPersonatbl> GetTipoPersonastbls()
        {
            return _context.TipoPersonastbls;
        }

        // GET: api/TipoPersona/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoPersonatbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipoPersonatbl = await _context.TipoPersonastbls.FindAsync(id);

            if (tipoPersonatbl == null)
            {
                return NotFound();
            }

            return Ok(tipoPersonatbl);
        }

        // PUT: api/TipoPersona/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoPersonatbl([FromRoute] int id, [FromBody] TipoPersonatbl tipoPersonatbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoPersonatbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoPersonatbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoPersonatblExists(id))
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

        // POST: api/TipoPersona
        [HttpPost]
        public async Task<IActionResult> PostTipoPersonatbl([FromBody] TipoPersonatbl tipoPersonatbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TipoPersonastbls.Add(tipoPersonatbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoPersonatbl", new { id = tipoPersonatbl.Id }, tipoPersonatbl);
        }

        // DELETE: api/TipoPersona/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoPersonatbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipoPersonatbl = await _context.TipoPersonastbls.FindAsync(id);
            if (tipoPersonatbl == null)
            {
                return NotFound();
            }

            _context.TipoPersonastbls.Remove(tipoPersonatbl);
            await _context.SaveChangesAsync();

            return Ok(tipoPersonatbl);
        }

        private bool TipoPersonatblExists(int id)
        {
            return _context.TipoPersonastbls.Any(e => e.Id == id);
        }
    }
}