using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;
using Prados.Web.Data.Entities;
using Prados.Web.Helpers;
using Prados.Web.Models;

namespace Prados.Web.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly IConverterHelper _converterHelper;
        private readonly IImageHelper _imageHelper;
        private readonly DataContext _context;

        public NoticiaController(DataContext context, IImageHelper imageHelper, IConverterHelper converterHelper)
        {
            _context = context;
            _imageHelper = imageHelper;
            _converterHelper = converterHelper;
        }

        // GET: Noticia
        public async Task<IActionResult> Index()
        {        
            return View(await _context.Noticiastbls.ToListAsync());
        }

        // GET: Noticia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticiastbl = await _context.Noticiastbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticiastbl == null)
            {
                return NotFound();
            }

            return View(noticiastbl);
        }

        // GET: Noticia/Create
        public async Task<IActionResult> Create(int? id)
        {
            var model = new NoticiaViewModel
            {
                Not_FechaCreacion= DateTime.Today,
                Not_Estado = 'A',
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NoticiaViewModel model)
        {
            if (ModelState.IsValid)
            {
                var path = string.Empty;

                if (model.ImageFile != null)
                {
                    path = await _imageHelper.UploadImageAsyncNegocio(model.ImageFile);

                }

                var noticia = await _converterHelper.ToNoticiaAsync(model, true, path);
                _context.Noticiastbls.Add(noticia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

            return View(model);
        }

        // GET: Noticia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticiastbl = await _context.Noticiastbls.FindAsync(id);
            if (noticiastbl == null)
            {
                return NotFound();
            }
            return View(noticiastbl);
        }

        // POST: Noticia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Not_Titulo,Not_Autor,Not_Descripcion,Not_Fecha,Not_Estado")] Noticiastbl noticiastbl)
        {
            if (id != noticiastbl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(noticiastbl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NoticiastblExists(noticiastbl.Id))
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
            return View(noticiastbl);
        }

        // GET: Noticia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticiastbl = await _context.Noticiastbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (noticiastbl == null)
            {
                return NotFound();
            }

            return View(noticiastbl);
        }

        // POST: Noticia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var noticiastbl = await _context.Noticiastbls.FindAsync(id);
            _context.Noticiastbls.Remove(noticiastbl);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticiastblExists(int id)
        {
            return _context.Noticiastbls.Any(e => e.Id == id);
        }
    }
}
