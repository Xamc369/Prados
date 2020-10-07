using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class TiposViviendatbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Punto de Pago")]
        public string Tip_Descripcion { get; set; }

        public ICollection<Propietariostbl> Propietarios { get; set; }
    }
}
