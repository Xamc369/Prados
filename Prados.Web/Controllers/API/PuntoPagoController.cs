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
    public class PuntoPagoController : ControllerBase
    {
        private readonly DataContext _context;

        public PuntoPagoController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PuntoPago
        [HttpGet]
        public IEnumerable<PuntosPagotbl> GetPuntosPagotbls()
        {
            return _context.PuntosPagotbls;
        }

        // GET: api/PuntoPago/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPuntosPagotbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var puntosPagotbl = await _context.PuntosPagotbls.FindAsync(id);

            if (puntosPagotbl == null)
            {
                return NotFound();
            }

            return Ok(puntosPagotbl);
        }

        // PUT: api/PuntoPago/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPuntosPagotbl([FromRoute] int id, [FromBody] PuntosPagotbl puntosPagotbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != puntosPagotbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(puntosPagotbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PuntosPagotblExists(id))
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

        // POST: api/PuntoPago
        [HttpPost]
        public async Task<IActionResult> PostPuntosPagotbl([FromBody] PuntosPagotbl puntosPagotbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PuntosPagotbls.Add(puntosPagotbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPuntosPagotbl", new { id = puntosPagotbl.Id }, puntosPagotbl);
        }

        // DELETE: api/PuntoPago/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePuntosPagotbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var puntosPagotbl = await _context.PuntosPagotbls.FindAsync(id);
            if (puntosPagotbl == null)
            {
                return NotFound();
            }

            _context.PuntosPagotbls.Remove(puntosPagotbl);
            await _context.SaveChangesAsync();

            return Ok(puntosPagotbl);
        }

        private bool PuntosPagotblExists(int id)
        {
            return _context.PuntosPagotbls.Any(e => e.Id == id);
        }
    }
}