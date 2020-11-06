﻿using Prados.Web.Data.Entities;
using Prados.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Vehiculostbl> ToVehiculoAsync(VehiculoViewModel model, string path, bool IsNew);
        Task<Negociostbl> ToNegocioAsync(NegocioViewModel model, string path, bool IsNew);
        Task<Pagostbl> ToPagoAsync(PagoViewModel model, bool isNew);
        PagoViewModel ToPagoViewModel(Pagostbl pago);
        Task<Contabilidadtbl> ToIngresosAsync(ContabilidadViewModel model1, bool isNew);      
        Task<Contabilidadtbl> ToContabilidadAsync(ContabilidadViewModel model1, bool isNew);
        VehiculoViewModel ToVehiculoViewModel(Vehiculostbl vehiculo);
        NegocioViewModel ToNegocioViewModel(Negociostbl negocio);
    }
}
