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

        public ConverterHelper(DataContext dataContext1)
        {
            _dataContext1 = dataContext1;
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

        public async Task<Pagostbl> ToPagoAsync(PagoViewModel model)
        {
           var pagos = new Pagostbl
            {
                PAG_FECHAPAGADO = model.PAG_FECHAPAGADO,
                PAG_FECHACREACION = DateTime.Today,
                PAG_ESTADO = 'A',
                Propietario = await _dataContext1.Propietariostbls.FindAsync(model.PropietarioId),
                Anio = await _dataContext1.Aniostbls.FindAsync(model.AnioId),
                Mes = await _dataContext1.Mesestbls.FindAsync(model.MesId),
                Val = await _dataContext1.Valorestbls.FindAsync(model.ValorId),
                PuntodePago = await _dataContext1.PuntosPagotbls.FindAsync(model.PuntoPagoId),
           };

            if(model.Id != 0)
            {
                pagos.Id = model.Id;
            }

            return pagos;
        }
    }
}
