using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prados.Web.Data.Entities;

namespace Prados.Web.Models
{
    public class EstadosFinancierosViewModel
    {
        public List<Pagostbl> ingresos { get; set; }
        public List<Egresostbl> egresos { get; set; }
    }
}
