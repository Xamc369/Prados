using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prados.Common.Models;
using Prados.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PropietarioController: ControllerBase
    {
        private readonly DataContext _dataContext;

        public PropietarioController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpPost]
        [Route("GetOwnerByEmail")]
        public async Task<IActionResult> GetOwner(EmailRequest emailRequest)
        {
            var owner = await _dataContext.Propietariostbls
                .Include(o => o.User)
                .ThenInclude(o => o.TipIde)
                .Include(o => o.User)
                .ThenInclude(o => o.TipPer)
                .Include(o => o.User)
                .ThenInclude(o => o.TipViv)
                .Include(o => o.Vehiculos)
                .Include(o => o.Pagos)
                .ThenInclude(pag => pag.Anio)
                .Include(o => o.Pagos)
                .ThenInclude(pag => pag.Mes)
                .Include(o => o.Pagos)
                .ThenInclude(pag => pag.Val)
                .Include(o => o.Pagos)
                .ThenInclude(pag => pag.Tipos)
                .Include(o => o.Pagos)
                .ThenInclude(pag => pag.PuntodePago)
                .Include(o => o.Negocio)
                .ThenInclude(o => o.Producto)
                .FirstOrDefaultAsync(o => o.User.UserName.ToLower()==emailRequest.Email.ToLower());
            var response = new PropietarioResponse
            {
                Id = owner.Id,
                Pro_Lote = owner.User.Pro_Lote,
                Pro_Nombres = owner.User.Pro_Nombres,
                Pro_Apellidos = owner.User.Pro_Apellidos,
                Pro_Identificacion = owner.User.Pro_Identificacion,
                Pro_Telefono = owner.User.Pro_Telefono,
                Email = owner.User.Email,
                Pro_Observaciones = owner.User.Pro_Observaciones,
                TipPer = owner.User.TipPer.TipP_Descripcion,
                TipViv = owner.User.TipViv.TipV_Descripcion,
                TipIde = owner.User.TipIde.TipI_Descripcion,
                Vehiculos= owner.Vehiculos.Select(v => new VehiculoResponse
                {
                    Id = v.Id,
                    Veh_Codigo = v.Veh_Codigo,
                    Veh_Placa = v.Veh_Placa,
                    Veh_Detalles = v.Veh_Detalles,
                    Veh_Born = v.Veh_Born,
                    ImageUrl = v.ImageFullPath

                }).ToList(),
                Pagos = owner.Pagos.Select(p => new PagosResponse
                {
                    PAG_FECHAPAGADO = p.PAG_FECHAPAGADO,
                    Anio1 = p.Anio.Ani_Descripcion,
                    PuntodePago1 = p.PuntodePago.Pun_Descripcion,
                    Mes1 = p.Mes.Mes_Descripcion,
                    Val1 = p.Val.Val_Valor,
                    Tipos1 = p.Tipos.Tip_Descripcion,

                }).ToList(),
                Negocio = owner.Negocio.Select(n => new NegocioResponse
                {
                    Neg_Nombre = n.Neg_Nombre,
                    Neg_Descripcion = n.Neg_Descripcion,
                    Neg_Direccion = n.Neg_Direccion,
                    Neg_Telefono = n.Neg_Telefono,
                    //si no sale la imagen debes revisar esto en la app
                    ImageUrl = n.ImageUrl,
                    Productos = n.Producto.Select(pr => new ProductoResponse
                    {
                        Pro_Nombre = pr.Pro_Nombre,
                        Pro_Precio = pr.Pro_Precio,
                        ImageUrl = pr.ImageUrl,

                    }).ToList(),
                }).ToList(),
                };

            return Ok(response);
        }
    }

}

