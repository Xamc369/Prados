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
    public class MesController : Controller
    {
        private readonly DataContext _context;

        public MesController(DataContext context)
        {
            _context = context;
        }

        // GET: Mes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mesestbls.ToListAsync());
        }

        // GET: Mes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesestbl = await _context.Mesestbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mesestbl == null)
            {
                return NotFound();
            }

            return View(mesestbl);
        }

        // GET: Mes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Mes_Descripcion")] Mesestbl mesestbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mesestbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mesestbl);
        }

        // GET: Mes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesestbl = await _context.Mesestbls.FindAsync(id);
            if (mesestbl == null)
            {
                return NotFound();
            }
            return View(mesestbl);
        }

        // POST: Mes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mes_Descripcion")] Mesestbl mesestbl)
        {
            if (id != mesestbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mesestbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MesestblExists(mesestbl.Id))
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
            return View(mesestbl);
        }

        // GET: Mes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesestbl = await _context.Mesestbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mesestbl == null)
            {
                return NotFound();
            }

            return View(mesestbl);
        }

        // POST: Mes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mesestbl = await _context.Mesestbls.FindAsync(id);
            _context.Mesestbls.Remove(mesestbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MesestblExists(int id)
        {
            return _context.Mesestbls.Any(e => e.Id == id);
        }
    }
}
