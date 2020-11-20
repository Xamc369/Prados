using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Negociostbl
    {
        public int Id { get; set; }
        [Display(Name = "NOMBRE")]
        public string Neg_Nombre { get; set; }
        [Display(Name = "DESCRIPCION")]
        public string Neg_Descripcion { get; set; }
        [Display(Name = "TELEFONO")]
        public string Neg_Telefono { get; set; }
        [Display(Name = "DIRECCION")]
        public string Neg_Direccion { get; set; }
        [Display(Name = "Fecha de Creacion")]
        public DateTime Neg_FechaCreacion { get; set; }
        [Display(Name = "Estado")]
        public Char Neg_Estado { get; set; }
        public Propietariostbl Propietarios { get; set; }
        public ICollection<Productostbl> Producto { get; set; }      
        [Display(Name = "IMAGEN")]
        public string ImageUrl { get; set; }
    }
}
