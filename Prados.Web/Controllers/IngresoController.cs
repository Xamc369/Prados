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
    public class IngresoController : Controller
    {
        private readonly DataContext _context;

        public IngresoController(DataContext context)
        {
            _context = context;
        }

        // GET: Ingreso
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ingresostbls.ToListAsync());
        }

        // GET: Ingreso/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingresostbl = await _context.Ingresostbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ingresostbl == null)
            {
                return NotFound();
            }

            return View(ingresostbl);
        }

        // GET: Ingreso/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Ingreso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ing_Sede,Ing_FechadePago")] Ingresostbl ingresostbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ingresostbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ingresostbl);
        }

        // GET: Ingreso/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingresostbl = await _context.Ingresostbls.FindAsync(id);
            if (ingresostbl == null)
            {
                return NotFound();
            }
            return View(ingresostbl);
        }

        // POST: Ingreso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ing_Sede,Ing_FechadePago")] Ingresostbl ingresostbl)
        {
            if (id != ingresostbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingresostbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngresostblExists(ingresostbl.Id))
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
            return View(ingresostbl);
        }

        // GET: Ingreso/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingresostbl = await _context.Ingresostbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ingresostbl == null)
            {
                return NotFound();
            }

            return View(ingresostbl);
        }

        // POST: Ingreso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ingresostbl = await _context.Ingresostbls.FindAsync(id);
            _context.Ingresostbls.Remove(ingresostbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IngresostblExists(int id)
        {
            return _context.Ingresostbls.Any(e => e.Id == id);
        }
    }
}
