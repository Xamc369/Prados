using Microsoft.AspNetCore.Mvc.Rendering;
using Prados.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Models
{
    public class EgresoViewModel:Egresostbl
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Año")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un año.")]
        public int AnioId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Mes")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un mes.")]
        public int MesId { get; set; }

        public IEnumerable<SelectListItem> Anios1 { get; set; }
        public IEnumerable<SelectListItem> Meses1 { get; set; }
    }
}
