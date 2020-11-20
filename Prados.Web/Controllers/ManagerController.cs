using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;
using Prados.Web.Data.Entities;

namespace Prados.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ManagerController : Controller
    {
        private readonly DataContext _context;

        public ManagerController(DataContext context)
        {
            _context = context;
        }

        // GET: Manager
        public async Task<IActionResult> Index()
        {
            return View(await _context.Managerstbls.ToListAsync());
        }

        // GET: Manager/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerstbl = await _context.Managerstbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (managerstbl == null)
            {
                return NotFound();
            }

            return View(managerstbl);
        }

        // GET: Manager/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] Managerstbl managerstbl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(managerstbl);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(managerstbl);
        }

        // GET: Manager/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerstbl = await _context.Managerstbls.FindAsync(id);
            if (managerstbl == null)
            {
                return NotFound();
            }
            return View(managerstbl);
        }

        // POST: Manager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Managerstbl managerstbl)
        {
            if (id != managerstbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(managerstbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManagerstblExists(managerstbl.Id))
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
            return View(managerstbl);
        }

        // GET: Manager/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerstbl = await _context.Managerstbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (managerstbl == null)
            {
                return NotFound();
            }

            return View(managerstbl);
        }

        // POST: Manager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var managerstbl = await _context.Managerstbls.FindAsync(id);
            _context.Managerstbls.Remove(managerstbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManagerstblExists(int id)
        {
            return _context.Managerstbls.Any(e => e.Id == id);
        }
    }
}
