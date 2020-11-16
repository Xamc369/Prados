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
    public class MesController : ControllerBase
    {
        private readonly DataContext _context;

        public MesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Mes
        [HttpGet]
        public IEnumerable<Mesestbl> GetMesestbls()
        {
            return _context.Mesestbls;
        }

        // GET: api/Mes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMesestbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mesestbl = await _context.Mesestbls.FindAsync(id);

            if (mesestbl == null)
            {
                return NotFound();
            }

            return Ok(mesestbl);
        }

        // PUT: api/Mes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMesestbl([FromRoute] int id, [FromBody] Mesestbl mesestbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != mesestbl.Id)
            {
                return BadRequest();
            }

            _context.Entry(mesestbl).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MesestblExists(id))
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

        // POST: api/Mes
        [HttpPost]
        public async Task<IActionResult> PostMesestbl([FromBody] Mesestbl mesestbl)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Mesestbls.Add(mesestbl);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMesestbl", new { id = mesestbl.Id }, mesestbl);
        }

        // DELETE: api/Mes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMesestbl([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var mesestbl = await _context.Mesestbls.FindAsync(id);
            if (mesestbl == null)
            {
                return NotFound();
            }

            _context.Mesestbls.Remove(mesestbl);
            await _context.SaveChangesAsync();

            return Ok(mesestbl);
        }

        private bool MesestblExists(int id)
        {
            return _context.Mesestbls.Any(e => e.Id == id);
        }
    }
}