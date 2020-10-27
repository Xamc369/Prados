using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Egresostbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Fecha de Pago")]
        [DataType(DataType.Date)]
        public DateTime Egr_FechadePago { get; set; }

        [Display(Name = "DETALLE")]
        public string Egr_Descripcion { get; set; }

        [Display(Name = "VALOR")]
        public string Egr_Valor { get; set; }
    }
}
