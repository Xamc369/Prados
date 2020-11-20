using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class PuntosPagotbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Punto de Pago")]
        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "La descripcion debe tener un minimo de 3 caracteres y un maximo de 50")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Solo se permiten mayúsculas")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "La descripcion es obligatoria")]
        public string Pun_Descripcion { get; set; }

        public ICollection<Pagostbl> Pagos { get; set; }
    }
}
