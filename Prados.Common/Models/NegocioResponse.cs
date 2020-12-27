using System;
using System.Collections.Generic;
using System.Text;

namespace Prados.Common.Models
{
    public class NegocioResponse
    {
        public int Id { get; set; }

        public string Neg_Nombre { get; set; }

        public string Neg_Descripcion { get; set; }

        public string Neg_Telefono { get; set; }

        public string Neg_Direccion { get; set; }

        public DateTime Neg_FechaCreacion { get; set; }
        
        public string ImageUrl { get; set; }
        
        public ICollection<ProductoResponse> Productos { get; set; }

    }
}
