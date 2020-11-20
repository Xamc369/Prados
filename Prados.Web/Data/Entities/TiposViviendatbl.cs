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

        [Display(Name = "Tipo de Vivienda")]
        public string TipV_Descripcion { get; set; }
        public ICollection<Userstbl> Propietarios { get; set; }
    }
}
