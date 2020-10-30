using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;

namespace Prados.Web.Controllers
{
    public class NegocioController : Controller
    {
        private readonly DataContext _context;

        public NegocioController(DataContext context)
        {
            _context = context;
        }
            public IActionResult Index()
            {
            return View(_context.Negociostbls
                         .Include(o => o.Propietarios));
            }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietariostbls
                .Include(o => o.User)
                .Include(o => o.Negocio)
                .ThenInclude(n => n.Producto)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (propietario == null)
            {
                return NotFound();
            }

            return View(propietario);
        }
    }
}
