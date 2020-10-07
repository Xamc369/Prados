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
    public class ValorController : Controller
    {
        private readonly DataContext _context;

        public ValorController(DataContext context)
        {
            _context = context;
        }

        // GET: Valor
        public async Task<IActionResult> Index()
        {
            return View(await _context.Valorestbls.ToListAsync());
        }

        // GET: Valor/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valorestbl = await _context.Valorestbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (valorestbl == null)
            {
                return NotFound();
            }

            return View(valorestbl);
        }

        // GET: Valor/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Valor/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Val_Valor,Val_FechaCreacion,Val_Estado")] Valorestbl valorestbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(valorestbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(valorestbl);
        }

        // GET: Valor/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valorestbl = await _context.Valorestbls.FindAsync(id);
            if (valorestbl == null)
            {
                return NotFound();
            }
            return View(valorestbl);
        }

        // POST: Valor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Val_Valor,Val_FechaCreacion,Val_Estado")] Valorestbl valorestbl)
        {
            if (id != valorestbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(valorestbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ValorestblExists(valorestbl.Id))
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
            return View(valorestbl);
        }

        // GET: Valor/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valorestbl = await _context.Valorestbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (valorestbl == null)
            {
                return NotFound();
            }

            return View(valorestbl);
        }

        // POST: Valor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var valorestbl = await _context.Valorestbls.FindAsync(id);
            _context.Valorestbls.Remove(valorestbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ValorestblExists(int id)
        {
            return _context.Valorestbls.Any(e => e.Id == id);
        }
    }
}
