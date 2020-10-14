using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Pagostbl
    {
        public int Id { get; set; }

        [Display(Name = "Fecha de Pago")]
        [DataType(DataType.Date)]
        public DateTime PAG_FECHAPAGADO { get; set; }
        public DateTime PAG_FECHACREACION { get; set; }
        public string PAG_TOTAL { get; set; }
        public char PAG_ESTADO { get; set; }
        public Propietariostbl Propietario { get; set; }
        [Display(Name = "Año")]
        public Aniostbl Anio { get; set; }
        [Display(Name = "Mes")]
        public Mesestbl Mes { get; set; }
        [Display(Name = "Valor")]
        public Valorestbl Val { get; set; }
        [Display(Name = "Punto de Pago")]
        public PuntosPagotbl PuntodePago { get; set; }
    }
}
