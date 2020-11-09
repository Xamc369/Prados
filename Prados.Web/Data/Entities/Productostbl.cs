using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Productostbl
    {
        public int Id { get; set; }
        public string Pro_Nombre { get; set; }
        public string Pro_Precio { get; set; }
        public DateTime Pro_FechaCreacion { get; set; }
        public Char Pro_Estado { get; set; }
        public Negociostbl Negocio { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}
