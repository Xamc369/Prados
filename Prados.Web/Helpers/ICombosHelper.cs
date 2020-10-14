using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Helpers
{
    public interface ICombosHelper
    {
        IEnumerable<SelectListItem> GetComboMarcaAutoes();
        IEnumerable<SelectListItem> GetComboPuntos();
        IEnumerable<SelectListItem> GetComboValores();
        IEnumerable<SelectListItem> GetComboValoresDescripcion();
        IEnumerable<SelectListItem> GetComboMeses();
        IEnumerable<SelectListItem> GetComboAnios();
    }
}
