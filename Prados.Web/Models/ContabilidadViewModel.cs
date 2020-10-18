using Microsoft.AspNetCore.Mvc.Rendering;
using Prados.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Models
{
    public class ContabilidadViewModel : Ingresostbl
    {
        public List<Pagostbl> Details { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double TotalQuantity { get { return Details == null ? 0 : Details.Sum(d => d.Val.Id); } }

        public IEnumerable<SelectListItem> PagosValores { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Valor Pagado")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un valor a pagar.")]
        public int ValorId { get; set; }
    }
}
