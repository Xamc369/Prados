using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class EstadosFinancierostbl
    {
            
            public int IdIngresos { get; set; }
            public int IdEgresos { get; set; }
            public Pagostbl Ingresos { get; set; }
            public Egresostbl Egresos { get; set; }
        
    }
}
