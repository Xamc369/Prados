using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;
using Prados.Web.Data.Entities;
using Prados.Web.Helpers;

namespace Prados.Web.Controllers
{
    public class ContabilidadController : Controller
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private readonly ICombosHelper _combosHelper;
        private readonly IConverterHelper _converterHelper;

        public ContabilidadController(DataContext context,
            IUserHelper userHelper,
            ICombosHelper combosHelper,
            IConverterHelper converterHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _combosHelper = combosHelper;
            _converterHelper = converterHelper;
        }

        public IActionResult Index()
        {
            return View(_context.Ingresostbls
                .Include(o => o.Val));
        }

        

    }
}
