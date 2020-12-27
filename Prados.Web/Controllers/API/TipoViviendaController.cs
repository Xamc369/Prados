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
    public class TipoViviendaController : ControllerBase
    {
        private readonly DataContext _context;

        public TipoViviendaController(DataContext context)
        {
            _context = context;
        }

        // GET: api/TipoVivienda
        [HttpGet]
        public IEnumerable<TiposViviendatbl> GetTiposViviendatbls()
        {
            return _context.TiposViviendatbls;
        }

        // GET: api/TipoVivienda/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTiposViviendatbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tiposViviendatbl = await _context.TiposViviendatbls.FindAsync(id);

            if (tiposViviendatbl == null)
            {
                return NotFound();
            }

            return Ok(tiposViviendatbl);
        }

        // PUT: api/TipoVivienda/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposViviendatbl([FromRoute] int id, [FromBody] TiposViviendatbl tiposViviendatbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tiposViviendatbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(tiposViviendatbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposViviendatblExists(id))
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

        // POST: api/TipoVivienda
        [HttpPost]
        public async Task<IActionResult> PostTiposViviendatbl([FromBody] TiposViviendatbl tiposViviendatbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TiposViviendatbls.Add(tiposViviendatbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTiposViviendatbl", new { id = tiposViviendatbl.Id }, tiposViviendatbl);
        }

        // DELETE: api/TipoVivienda/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiposViviendatbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tiposViviendatbl = await _context.TiposViviendatbls.FindAsync(id);
            if (tiposViviendatbl == null)
            {
                return NotFound();
            }

            _context.TiposViviendatbls.Remove(tiposViviendatbl);
            await _context.SaveChangesAsync();

            return Ok(tiposViviendatbl);
        }

        private bool TiposViviendatblExists(int id)
        {
            return _context.TiposViviendatbls.Any(e => e.Id == id);
        }
    }
}