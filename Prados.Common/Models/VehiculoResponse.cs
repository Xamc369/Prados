using System;
using System.Collections.Generic;
using System.Text;

namespace Prados.Common.Models
{
    public class VehiculoResponse
    {
        public int Id { get; set; }

        public string Veh_Codigo { get; set; }

        public string Veh_Placa { get; set; }

        public string ImageUrl { get; set; }

        public DateTime Veh_Born { get; set; }

        public string Veh_Detalles { get; set; }

        public DateTime BornLocal => Veh_Born.ToLocalTime();
    }
}
