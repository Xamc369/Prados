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

        public char Con_EstadoIng { get; set; }
        public char Con_EstadoEgr { get; set; }

        //********************************EGRESOS*********************************
        public ICollection<Egresostbl> Con_Egresos { get; set; }
        [Display(Name = "Egresos")]
        public Egresostbl Egr { get; set; }

        //***********************************INGRESOS****************************
        public ICollection<TiposPagotbl> Con_Tipos { get; set; }
        public ICollection<Valorestbl> Con_Valores { get; set; }
        public ICollection<PuntosPagotbl> Con_Puntos { get; set; }
        public ICollection<Aniostbl> Con_Anios { get; set; }
        public ICollection<Mesestbl> Con_Meses { get; set; }

        [Display(Name = "Tipo")]
        public TiposPagotbl Tip { get; set; }

        [Display(Name = "Valor")]
        public Valorestbl Valo { get; set; }

        [Display(Name = "Puntos")]
        public PuntosPagotbl Punt { get; set; }

        [Display(Name = "Año")]
        public Aniostbl Anio { get; set; }

        [Display(Name = "Mes")]
        public Mesestbl Mess { get; set; }

    }
}
