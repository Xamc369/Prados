using System;
using System.Collections.Generic;
using System.Text;

namespace Prados.Common.Models
{
    public class PagosResponse
    {
        public DateTime PAG_FECHAPAGADO { get; set; }
        public DateTime PAG_FECHACREACION { get; set; }
        public string Anio1 { get; set; }
        public string Mes1 { get; set; }
        public string Val1 { get; set; }
        public string Tipos1 { get; set; }
        public string PuntodePago1 { get; set; }

    }
}
