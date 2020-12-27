using System;
using System.Collections.Generic;
using System.Text;

namespace Prados.Common.Models
{
    public class PropietarioResponse
    {
        public int Id { get; set; }
        public string Pro_Lote { get; set; }
        public string Pro_Nombres { get; set; }
        public string Pro_Apellidos { get; set; }
        public string Pro_Observaciones { get; set; }
        public string Pro_Telefono { get; set; }
        public string Pro_Identificacion { get; set; }
        public string Email { get; set; }
        public string NombreCompleto => $"{Pro_Nombres} {Pro_Apellidos}";
        public string TipPer { get; set; }
        public string TipViv { get; set; }
        public string TipIde { get; set; }
        public ICollection<VehiculoResponse> Vehiculos { get; set; }
        public ICollection<PagosResponse> Pagos { get; set; }
        public ICollection<NegocioResponse> Negocio { get; set; }
    }
}
