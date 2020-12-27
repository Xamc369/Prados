using System;
using System.Collections.Generic;
using System.Text;

namespace Prados.Common.Models
{
    public class ProductoResponse
    {
        public int Id { get; set; }
        public string Pro_Nombre { get; set; }
        public string Pro_Precio { get; set; }
        public DateTime Pro_FechaCreacion { get; set; }
        public string ImageUrl { get; set; }
    }
}
