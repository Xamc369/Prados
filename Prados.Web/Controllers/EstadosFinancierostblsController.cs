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
    public class EstadosFinancierostblsController : Controller
    {
        private readonly DataContext _context;

        public EstadosFinancierostblsController(DataContext context)
        {
            _context = context;
        }

        // GET: EstadosFinancierostbls
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadosFinancierostbls
                .Include(es => es.Ingresos)
                .Include(es => es.Egresos)
                .ToListAsync());
        }

        // GET: EstadosFinancierostbls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadosFinancierostbl = await _context.EstadosFinancierostbls
                .FirstOrDefaultAsync(m => m.IdIngresos == id);
            if (estadosFinancierostbl == null)
            {
                return NotFound();
            }

            return View(estadosFinancierostbl);
        }

        // GET: EstadosFinancierostbls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadosFinancierostbls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdIngresos,IdEgresos")] EstadosFinancierostbl estadosFinancierostbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadosFinancierostbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadosFinancierostbl);
        }

        // GET: EstadosFinancierostbls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadosFinancierostbl = await _context.EstadosFinancierostbls.FindAsync(id);
            if (estadosFinancierostbl == null)
            {
                return NotFound();
            }
            return View(estadosFinancierostbl);
        }

        // POST: EstadosFinancierostbls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdIngresos,IdEgresos")] EstadosFinancierostbl estadosFinancierostbl)
        {
            if (id != estadosFinancierostbl.IdIngresos)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadosFinancierostbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadosFinancierostblExists(estadosFinancierostbl.IdIngresos))
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
            return View(estadosFinancierostbl);
        }

        // GET: EstadosFinancierostbls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadosFinancierostbl = await _context.EstadosFinancierostbls
                .FirstOrDefaultAsync(m => m.IdIngresos == id);
            if (estadosFinancierostbl == null)
            {
                return NotFound();
            }

            return View(estadosFinancierostbl);
        }

        // POST: EstadosFinancierostbls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estadosFinancierostbl = await _context.EstadosFinancierostbls.FindAsync(id);
            _context.EstadosFinancierostbls.Remove(estadosFinancierostbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadosFinancierostblExists(int id)
        {
            return _context.EstadosFinancierostbls.Any(e => e.IdIngresos == id);
        }
    }
}
