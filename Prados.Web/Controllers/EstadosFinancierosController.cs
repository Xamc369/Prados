using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;
using Prados.Web.Helpers;
using Prados.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vereyon.Web;

namespace Prados.Web.Controllers
{
    public class EstadosFinancierosController : Controller
    {
        private readonly IConverterHelper _converterHelper;
        private readonly IImageHelper _imageHelper;
        private readonly IFlashMessage _flashMessage;
        private readonly DataContext _context;

        public EstadosFinancierosController(DataContext context, IImageHelper imageHelper, IConverterHelper converterHelper, IFlashMessage flashMessage)
        {
            _context = context;
            _imageHelper = imageHelper;
            _converterHelper = converterHelper;
            _flashMessage = flashMessage;
        }

        private DataContext db = new DataContext();


        public IActionResult Index()
        {
            var ingreso = _context.Pagostbls
                .Include(ing => ing.Anio)
                .Include(ing => ing.Mes)
                .Include(ing => ing.Val)
                .Include(ing => ing.PuntodePago)
                .Include(ing => ing.Tipos)
                .ToList();
            var egreso = _context.Egresostbls.ToList();
            var view = new EstadosFinancierosViewModel()
            {
                ingresos = ingreso,
                egresos = egreso,
            };

            return View(view);
        }
    }
}
