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
    public class TipoIdentificacionController : ControllerBase
    {
        private readonly DataContext _context;

        public TipoIdentificacionController(DataContext context)
        {
            _context = context;
        }

        // GET: api/TipoIdentificacion
        [HttpGet]
        public IEnumerable<TipoIdentificaciontbl> GetTipoIdentificaciontbls()
        {
            return _context.TipoIdentificaciontbls;
        }

        // GET: api/TipoIdentificacion/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoIdentificaciontbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipoIdentificaciontbl = await _context.TipoIdentificaciontbls.FindAsync(id);

            if (tipoIdentificaciontbl == null)
            {
                return NotFound();
            }

            return Ok(tipoIdentificaciontbl);
        }

        // PUT: api/TipoIdentificacion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipoIdentificaciontbl([FromRoute] int id, [FromBody] TipoIdentificaciontbl tipoIdentificaciontbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoIdentificaciontbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipoIdentificaciontbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoIdentificaciontblExists(id))
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

        // POST: api/TipoIdentificacion
        [HttpPost]
        public async Task<IActionResult> PostTipoIdentificaciontbl([FromBody] TipoIdentificaciontbl tipoIdentificaciontbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TipoIdentificaciontbls.Add(tipoIdentificaciontbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipoIdentificaciontbl", new { id = tipoIdentificaciontbl.Id }, tipoIdentificaciontbl);
        }

        // DELETE: api/TipoIdentificacion/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoIdentificaciontbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tipoIdentificaciontbl = await _context.TipoIdentificaciontbls.FindAsync(id);
            if (tipoIdentificaciontbl == null)
            {
                return NotFound();
            }

            _context.TipoIdentificaciontbls.Remove(tipoIdentificaciontbl);
            await _context.SaveChangesAsync();

            return Ok(tipoIdentificaciontbl);
        }

        private bool TipoIdentificaciontblExists(int id)
        {
            return _context.TipoIdentificaciontbls.Any(e => e.Id == id);
        }
    }
}