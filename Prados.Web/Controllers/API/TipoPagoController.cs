using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;
using Prados.Web.Data.Entities;

namespace Prados.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TipoPagoController : ControllerBase
    {
        private readonly DataContext _context;

        public TipoPagoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/TipoPago
        [HttpGet]
        public IEnumerable<TiposPagotbl> GetTiposPagotbl()
        {
            return _context.TiposPagotbl;
        }

        // GET: api/TipoPago/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTiposPagotbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tiposPagotbl = await _context.TiposPagotbl.FindAsync(id);

            if (tiposPagotbl == null)
            {
                return NotFound();
            }

            return Ok(tiposPagotbl);
        }

        // PUT: api/TipoPago/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTiposPagotbl([FromRoute] int id, [FromBody] TiposPagotbl tiposPagotbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tiposPagotbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(tiposPagotbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TiposPagotblExists(id))
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

        // POST: api/TipoPago
        [HttpPost]
        public async Task<IActionResult> PostTiposPagotbl([FromBody] TiposPagotbl tiposPagotbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TiposPagotbl.Add(tiposPagotbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTiposPagotbl", new { id = tiposPagotbl.Id }, tiposPagotbl);
        }

        // DELETE: api/TipoPago/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTiposPagotbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tiposPagotbl = await _context.TiposPagotbl.FindAsync(id);
            if (tiposPagotbl == null)
            {
                return NotFound();
            }

            _context.TiposPagotbl.Remove(tiposPagotbl);
            await _context.SaveChangesAsync();

            return Ok(tiposPagotbl);
        }

        private bool TiposPagotblExists(int id)
        {
            return _context.TiposPagotbl.Any(e => e.Id == id);
        }
    }
}