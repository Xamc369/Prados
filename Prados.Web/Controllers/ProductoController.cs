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
    public class ProductoController : Controller
    {
        private readonly DataContext _context;

        public ProductoController(DataContext context)
        {
            _context = context;
        }

        // GET: Producto
        public async Task<IActionResult> Index()
        {
           // return View(await _context.Productostbls.Where(p => p.Pro_Estado == 'A').ToListAsync());
            return View(await _context.Productostbls.ToListAsync());
        }

        // GET: Producto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productostbl = await _context.Productostbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productostbl == null)
            {
                return NotFound();
            }

            return View(productostbl);
        }

        // GET: Producto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Pro_Nombre,Pro_Precio,Pro_FechaCreacion,Pro_Estado")] Productostbl productostbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productostbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productostbl);
        }

        // GET: Producto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productostbl = await _context.Productostbls.FindAsync(id);
            if (productostbl == null)
            {
                return NotFound();
            }
            return View(productostbl);
        }

        // POST: Producto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Pro_Nombre,Pro_Precio,Pro_FechaCreacion,Pro_Estado")] Productostbl productostbl)
        {
            if (id != productostbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productostbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductostblExists(productostbl.Id))
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
            return View(productostbl);
        }

        // GET: Producto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productostbl = await _context.Productostbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (productostbl == null)
            {
                return NotFound();
            }

            return View(productostbl);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productostbl = await _context.Productostbls.FindAsync(id);
            _context.Productostbls.Remove(productostbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductostblExists(int id)
        {
            return _context.Productostbls.Any(e => e.Id == id);
        }
    }
}
