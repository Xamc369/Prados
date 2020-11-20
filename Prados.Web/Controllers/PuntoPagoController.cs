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
    public class PuntoPagoController : Controller
    {
        private readonly DataContext _context;

        public PuntoPagoController(DataContext context)
        {
            _context = context;
        }

        // GET: PuntoPago
        public async Task<IActionResult> Index()
        {
            return View(await _context.PuntosPagotbls.ToListAsync());
        }

        // GET: PuntoPago/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puntosPagotbl = await _context.PuntosPagotbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (puntosPagotbl == null)
            {
                return NotFound();
            }

            return View(puntosPagotbl);
        }

        // GET: PuntoPago/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PuntoPago/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pun_Descripcion")] PuntosPagotbl puntosPagotbl)
        {
            if (ModelState.IsValid)
            {
                try { 
                _context.Add(puntosPagotbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.Message.Contains("duplicate"))
                    {
                        ModelState.AddModelError(string.Empty, "El punto pago ya esta registrado");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, ex.InnerException.Message);
                    }
                }

            }
            return View(puntosPagotbl);
        }

        // GET: PuntoPago/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puntosPagotbl = await _context.PuntosPagotbls.FindAsync(id);
            if (puntosPagotbl == null)
            {
                return NotFound();
            }
            return View(puntosPagotbl);
        }

        // POST: PuntoPago/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pun_Descripcion")] PuntosPagotbl puntosPagotbl)
        {
            if (id != puntosPagotbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(puntosPagotbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PuntosPagotblExists(puntosPagotbl.Id))
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
            return View(puntosPagotbl);
        }

        // GET: PuntoPago/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var puntosPagotbl = await _context.PuntosPagotbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (puntosPagotbl == null)
            {
                return NotFound();
            }

            return View(puntosPagotbl);
        }

        // POST: PuntoPago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var puntosPagotbl = await _context.PuntosPagotbls.FindAsync(id);
            _context.PuntosPagotbls.Remove(puntosPagotbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PuntosPagotblExists(int id)
        {
            return _context.PuntosPagotbls.Any(e => e.Id == id);
        }
    }
}
