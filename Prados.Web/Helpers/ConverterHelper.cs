using Microsoft.AspNetCore.Identity.UI.Pages;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using Prados.Web.Data;
using Prados.Web.Data.Entities;
using Prados.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _dataContext1;
        private readonly ICombosHelper _combosHelper;

        public ConverterHelper(DataContext dataContext1,
            ICombosHelper combosHelper)
        {
            _dataContext1 = dataContext1;
            _combosHelper = combosHelper;
        }

        public async Task<Vehiculostbl> ToVehiculoAsync(VehiculoViewModel model, string path)
        {
            return new Vehiculostbl
            {
               Veh_Codigo = model.Veh_Codigo,
               Veh_Placa = model.Veh_Placa,
               Veh_Born = model.Veh_Born,
                ImageUrl = path,
               Veh_Estado = model.Veh_Estado,
                Propietario = await _dataContext1.Propietariostbls.FindAsync(model.PropietarioId),
               Veh_Detalles = model.Veh_Detalles
            };
        }

        public async Task<Pagostbl> ToPagoAsync(PagoViewModel model, bool isNew)
        {

            var pagos = new Pagostbl
            {
                PAG_FECHAPAGADO = model.PAG_FECHAPAGADO,
                PAG_FECHACREACION = DateTime.Today,
                PAG_ESTADO = 'A',
                Id = isNew ? 0 : model.Id,
                Propietario = await _dataContext1.Propietariostbls.FindAsync(model.PropietarioId),
                Anio = await _dataContext1.Aniostbls.FindAsync(model.AnioId),
                Mes = await _dataContext1.Mesestbls.FindAsync(model.MesId),
                Val = await _dataContext1.Valorestbls.FindAsync(model.ValorId),
                PuntodePago = await _dataContext1.PuntosPagotbls.FindAsync(model.PuntoPagoId),
           };
            
            return pagos;

            
        }

        public PagoViewModel ToPagoViewModel(Pagostbl pago)
        {
            return new PagoViewModel
            {
                PAG_FECHAPAGADO = pago.PAG_FECHAPAGADO,
                PAG_FECHACREACION = DateTime.Today,
                PAG_ESTADO = 'A',
                Propietario = pago.Propietario,
                Anio = pago.Anio,
                Mes = pago.Mes,
                Val = pago.Val,
                PuntodePago = pago.PuntodePago,
                Id = pago.Id,
                PropietarioId = pago.Propietario.Id,
                AnioId = pago.Anio.Id,
                MesId = pago.Mes.Id,
                ValorId = pago.Val.Id,
                PuntoPagoId = pago.PuntodePago.Id,
                Anios1 = _combosHelper.GetComboAnios(),
                Meses1 = _combosHelper.GetComboMeses(),
                Valores = _combosHelper.GetComboValores(),
                Puntos = _combosHelper.GetComboPuntos(),
            };
        }
    }
}
