using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data;
using Prados.Web.Data.Entities;
using Prados.Web.Helpers;
using Prados.Web.Models;

namespace Prados.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PropietarioController : Controller
    {

        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;
        private readonly ICombosHelper _combosHelper;
        private readonly IConverterHelper _converterHelper;

        public PropietarioController(DataContext context,
             IUserHelper userHelper,
             ICombosHelper combosHelper,
             IConverterHelper converterHelper)
        {
            _context = context;
            _userHelper = userHelper;
            _combosHelper = combosHelper;
            _converterHelper = converterHelper;
        }

        // GET: Propietarios
        public IActionResult Index()
        {
            return View(_context.Propietariostbls
                .Include(o => o.User)
                .Include(o => o.Vehiculos)
                .Include(o => o.Pagos));
        }

        // GET: Propietarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietariostbls
                .Include(o => o.User)
                 .Include(o => o.Vehiculos)
                 .Include(o => o.Pagos)
                 .ThenInclude(p => p.Anio)
                 .Include(o => o.Pagos)
                 .ThenInclude(p => p.Mes)
                 .Include(o => o.Pagos)
                 .ThenInclude(p => p.Val)
                 .Include(o => o.Pagos)
                 .ThenInclude(p => p.PuntodePago)
                 .Include(o => o.Pagos)
                 .ThenInclude(p => p.Tipos)
                 .FirstOrDefaultAsync(m => m.Id == id);

            if (propietario == null)
            {
                return NotFound();
            }

            return View(propietario);
        }

        // GET: Propietarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Propietarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                Userstbl user = new Userstbl
                {
                    Pro_Lote = model.PRO_LOTE,
                    Pro_Nombres = model.PRO_NOMBRES,
                    Pro_Apellidos = model.PRO_APELLIDOS,
                    Pro_Observaciones = model.PRO_OBSERVACIONES,
                    Pro_Telefono = model.PRO_TELEFONO,
                    Pro_TipoIdentificacion = model.PRO_TIPOIDENTIFICACION,
                    Pro_Identificacion = model.PRO_IDENTIFICACION,
                    Email = model.Username,
                    UserName = model.Username
                };

                Microsoft.AspNetCore.Identity.IdentityResult response = await _userHelper.AddUserAsync(user, model.Password);
                if (response.Succeeded)
                {
                    Userstbl userInDB = await _userHelper.GetUserByEmailAsync(model.Username);
                    await _userHelper.AddUserToRoleAsync(userInDB, "Customer");

                    var propietario = new Propietariostbl
                    {
                        Vehiculos = new List<Vehiculostbl>(),
                        User = userInDB,
                    };

                    _context.Propietariostbls.Add(propietario);

                    try
                    {
                        await _context.SaveChangesAsync();
                        return RedirectToAction(nameof(Index));
                    }
                    catch (Exception ex)
                    {

                        ModelState.AddModelError(string.Empty, ex.ToString());
                        return View(model);
                    }
                }
                ModelState.AddModelError(string.Empty, response.Errors.FirstOrDefault().Description);
            }
            return View(model);
        }

        // GET: Propietarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietariostbls.FindAsync(id);
            if (propietario == null)
            {
                return NotFound();
            }
            return View(propietario);
        }

        // POST: Propietarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] Propietariostbl propietario)
        {
            if (id != propietario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propietario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropietarioExists(propietario.Id))
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
            return View(propietario);
        }

        // GET: Propietarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietariostbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (propietario == null)
            {
                return NotFound();
            }

            return View(propietario);
        }

        // POST: Propietarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propietario = await _context.Propietariostbls.FindAsync(id);
            _context.Propietariostbls.Remove(propietario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropietarioExists(int id)
        {
            return _context.Propietariostbls.Any(e => e.Id == id);
        }


        public async Task<IActionResult> AddVehiculo(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietariostbls.FindAsync(id.Value);

            if (propietario == null)
            {
                return NotFound();
            }

            var model = new VehiculoViewModel
            {
                Veh_Born = DateTime.Today,
                PropietarioId = propietario.Id,

            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddVehiculo(VehiculoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var path = string.Empty;

                if (model.ImageFile != null)
                {

                    var guid = Guid.NewGuid().ToString();
                    var file = $"{guid}.jpg";
                    path = Path.Combine(
                        Directory.GetCurrentDirectory(),
                        "wwwroot\\images\\Vehiculos",
                        file);

                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.ImageFile.CopyToAsync(stream);
                    }
                    path = $"~/images/Vehiculos/{file}";

                }

                var vehiculo = await _converterHelper.ToVehiculoAsync(model, path);
                _context.Vehiculostbls.Add(vehiculo);
                await _context.SaveChangesAsync();
                return RedirectToAction($"Details/{model.PropietarioId}");

            }

            return View(model);
        }

        public async Task<IActionResult> AddPago(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propietario = await _context.Propietariostbls.FindAsync(id.Value);

            if (propietario == null)
            {
                return NotFound();
            }

            var model = new PagoViewModel
            {
                PropietarioId = propietario.Id,
                PAG_FECHACREACION = DateTime.Today,
                PAG_ESTADO = 'A',
                Anios1 = _combosHelper.GetComboAnios(),
                Meses1 = _combosHelper.GetComboMeses(),
                Valores = _combosHelper.GetComboValores(),
                TiposPago =_combosHelper.GetComboValoresDescripcion(),
                Puntos = _combosHelper.GetComboPuntos()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPago(PagoViewModel model, ContabilidadViewModel model1)
        {
            if (ModelState.IsValid)
            {

                var pago = await _converterHelper.ToPagoAsync(model, true);

                //var anio_nuevo = pago.Anio.Id;
                //var anio = _context.Pagostbls.Find(model.AnioId);
                //var mes_nuevo = pago.Mes.Id;
                //var mes = _context.Pagostbls.Find(model.MesId);
                //var anio_nuevo2 = anio_nuevo.ToString();
                //var mes_nuevo2 = mes_nuevo.ToString();            
                //guardamos el pago
                _context.Pagostbls.Add(pago);
                await _context.SaveChangesAsync();
                return RedirectToAction($"Details/{model.PropietarioId}");
            }
           return View(model);
        }

        public async Task<IActionResult> EditPago(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pago = await _context.Pagostbls
               .Include(o => o.Propietario)
               .Include(p => p.Anio)
               .Include(p => p.Mes)
               .Include(p => p.Val)
               .Include(p => p.Tipos)
               .Include(p => p.PuntodePago)
               .FirstOrDefaultAsync(p => p.Id == id);

            if (pago == null)
            {
                return NotFound();
            }

            return View(_converterHelper.ToPagoViewModel(pago));
        }

        [HttpPost]
        public async Task<IActionResult> EditPago(PagoViewModel model, ContabilidadViewModel model1)
        {
            if (ModelState.IsValid)
            {
                var pago = await _converterHelper.ToPagoAsync(model, false);
               // var ingreso = await _converterHelper.ToIngresosAsync(model1, true);
                _context.Pagostbls.Update(pago);
               // _context.Ingresostbls.Update(ingreso);
                await _context.SaveChangesAsync();
                return RedirectToAction($"Details/{model.PropietarioId}");

            }

            return View(model);
        }

    }
}
