using Microsoft.AspNetCore.Mvc.Rendering;
using Prados.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Models
{
    public class ContabViewModel: Contabilidadtbl
    {
        public List<Pagostbl> Details { get; set; }

        public IEnumerable<SelectListItem> PagosValores { get; set; }

        [Display(Name = "Valor Pagado")]
        public int PagoId { get; set; }
    }
}
