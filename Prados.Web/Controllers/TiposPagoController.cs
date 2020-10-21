using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;
using Prados.Web.Data.Entities;

namespace Prados.Web.Controllers
{
    public class TiposPagoController : Controller
    {
        private readonly DataContext _context;

        public TiposPagoController(DataContext context)
        {
            _context = context;
        }

        // GET: TiposPago
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposPagotbl.ToListAsync());
        }

        // GET: TiposPago/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposPagotbl = await _context.TiposPagotbl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposPagotbl == null)
            {
                return NotFound();
            }

            return View(tiposPagotbl);
        }

        // GET: TiposPago/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposPago/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tip_Descripcion")] TiposPagotbl tiposPagotbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tiposPagotbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tiposPagotbl);
        }

        // GET: TiposPago/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposPagotbl = await _context.TiposPagotbl.FindAsync(id);
            if (tiposPagotbl == null)
            {
                return NotFound();
            }
            return View(tiposPagotbl);
        }

        // POST: TiposPago/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tip_Descripcion")] TiposPagotbl tiposPagotbl)
        {
            if (id != tiposPagotbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tiposPagotbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiposPagotblExists(tiposPagotbl.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tiposPagotbl);
        }

        // GET: TiposPago/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposPagotbl = await _context.TiposPagotbl
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposPagotbl == null)
            {
                return NotFound();
            }

            return View(tiposPagotbl);
        }

        // POST: TiposPago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tiposPagotbl = await _context.TiposPagotbl.FindAsync(id);
            _context.TiposPagotbl.Remove(tiposPagotbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiposPagotblExists(int id)
        {
            return _context.TiposPagotbl.Any(e => e.Id == id);
        }
    }
}
