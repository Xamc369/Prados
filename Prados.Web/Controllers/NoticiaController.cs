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
using Vereyon.Web;

namespace Prados.Web.Controllers
{
    public class NoticiaController : Controller
    {
        private readonly IConverterHelper _converterHelper;
        private readonly IImageHelper _imageHelper;
        private readonly IFlashMessage _flashMessage;
        private readonly DataContext _context;

        public NoticiaController(DataContext context, IImageHelper imageHelper, IConverterHelper converterHelper, IFlashMessage flashMessage)
        {
            _context = context;
            _imageHelper = imageHelper;
            _converterHelper = converterHelper;
            _flashMessage = flashMessage;
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

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticiastbls
                .FirstOrDefaultAsync(n => n.Id == id);

            if (noticia == null)
            {
                return NotFound();
            }
            return View(_converterHelper.ToNoticiaViewModel(noticia));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NoticiaViewModel model)
        {
            if (ModelState.IsValid)
            {
                var path = model.ImageUrl;

                if (model.ImageFile != null)
                {
                    path = await _imageHelper.UploadImageAsyncNoticia(model.ImageFile);

                }

                var noticia = await _converterHelper.ToNoticiaAsync(model, false, path);
                _context.Noticiastbls.Update(noticia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticiastbls
                .FirstOrDefaultAsync(h => h.Id == id.Value);

            if (noticia == null)
            {
                return NotFound();
            }

            noticia.Not_Estado = 'I';
            // _context.Negociostbls.Remove(negocio);
            await _context.SaveChangesAsync();
            _flashMessage.Confirmation("La noticia fue borrada");
            return RedirectToAction(nameof(Index));
        }

        private bool NoticiastblExists(int id)
        {
            return _context.Noticiastbls.Any(e => e.Id == id);
        }
    }
}
