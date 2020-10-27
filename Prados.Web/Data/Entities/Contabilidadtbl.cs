using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Contabilidadtbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        //********************************EGRESOS*********************************
        public ICollection<Egresostbl> Con_Egresos { get; set; }
        [Display(Name = "Egresos")]
        public Egresostbl Egr { get; set; }

        //***********************************INGRESOS****************************
        public ICollection<Valorestbl> Con_Valores { get; set; }
        public ICollection<TiposPagotbl> Con_Tipos { get; set; }
        public ICollection<PuntosPagotbl> Con_Puntos { get; set; }
        public ICollection<Aniostbl> Con_Anios { get; set; }

        public Pagostbl PagosCont { get; set; }

        [Display(Name = "Valor")]
        public Valorestbl Val { get; set; }
        [Display(Name = "Tipo")]
        public TiposPagotbl Tip { get; set; }
        [Display(Name = "Punto")]
        public PuntosPagotbl Pun { get; set; }
        [Display(Name = "Año")]
        public Aniostbl Ani { get; set; }

        [Display(Name = "ID INGRESO")]
        public int Con_IngId { get; set; }

    }
}
