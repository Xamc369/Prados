using Microsoft.AspNetCore.Mvc.Rendering;
using Prados.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _datacontext;


        public CombosHelper(DataContext datacontext)

        {
            _datacontext = datacontext;

        }
        public IEnumerable<SelectListItem> GetComboMarcaAutoes()
        {
            var list = _datacontext.MarcasAutostbls.Select(vh => new SelectListItem
            {
                Text = vh.Mar_Descripcion,
                Value = $"{vh.Id}"
            })
                .OrderBy(vh => vh.Text)
                .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Selecione una marca]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboPuntos()
        {
            var list = _datacontext.PuntosPagotbls.Select(pp => new SelectListItem
            {
                Text = pp.Pun_Descripcion,
                Value = $"{pp.Id}"
            })
               .OrderBy(pp => pp.Text)
               .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Selecione un punto de pago...]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboValores()
        {
            var list = _datacontext.Valorestbls.Select(va => new SelectListItem
            {
                Text = va.Val_Valor,
                Value = $"{va.Id}"
            })
              .OrderBy(va => va.Text)
              .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Selecione un valor pagado...]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboValoresDescripcion()
        {
            var list = _datacontext.TiposPagotbls.Select(va => new SelectListItem
            {
                Text = va.Tip_Descripcion,
                Value = $"{va.Id}"
            })
              .OrderBy(va => va.Text)
              .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Selecione un tipo de pago...]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboMeses()
        {
            var list = _datacontext.Mesestbls.Select(me => new SelectListItem
            {
                Text = me.Mes_Descripcion,
                Value = $"{me.Id}"
            })
              .OrderBy(me => me.Text)
              .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Selecione un mes...]",
                Value = "0"
            });

            return list;
        }

        public IEnumerable<SelectListItem> GetComboAnios()
        {
            var list = _datacontext.Aniostbls.Select(an => new SelectListItem
            {
                Text = an.Ani_Descripcion,
                Value = $"{an.Id}"
            })
              .OrderBy(an => an.Text)
              .ToList();

            list.Insert(0, new SelectListItem
            {
                Text = "[Selecione un año...]",
                Value = "0"
            });

            return list;
        }
    }
}
