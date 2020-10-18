using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Ingresostbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Cuotas")]
        public double Ing_Cuotas { get; set; }
        [Display(Name = "Tag")]
        public double Ing_Tag { get; set; }
        [Display(Name = "Sede")]
        public double Ing_Sede { get; set; }
        public ICollection<Vehiculostbl> Veh_Ing { get; set; }
        public ICollection<Valorestbl> Ing_Valores { get; set; }

        public Pagostbl PagosCont { get; set; }

        [Display(Name = "Valor")]
        public Valorestbl Val { get; set; }

    }
}
