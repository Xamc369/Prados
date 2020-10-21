using Microsoft.AspNetCore.Mvc.Rendering;
using Prados.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Models
{
    public class PagoViewModel : Pagostbl
    {
        public int PropietarioId { get; set; }

        //es el id de todas las tablas relacionadas
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Año")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un año.")]
        public int AnioId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Mes")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un mes.")]
        public int MesId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Valor Pagado")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un valor a pagar.")]
        public int ValorId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Punto Pago")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un punto de pago.")]
        public int PuntoPagoId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Tipo de Pago")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un punto de pago.")]
        public int TipoPagoId { get; set; }

        public IEnumerable<SelectListItem> Anios1 { get; set; }
        public IEnumerable<SelectListItem> Meses1 { get; set; }
        public IEnumerable<SelectListItem> Valores { get; set; }
        public IEnumerable<SelectListItem> TiposPago { get; set; }
        public IEnumerable<SelectListItem> Puntos { get; set; }
    }
}
