using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Negociostbl
    {
        public int Id { get; set; }
        public string Neg_Nombre { get; set; }
        public string Neg_Descripcion { get; set; }
        public string Neg_Telefono { get; set; }
        public string Neg_Direccion { get; set; }
        public string Neg_Email { get; set; }
        public DateTime Neg_FechaCreacion { get; set; }
        public Char Neg_Estado { get; set; }
        public Propietariostbl Propietarios { get; set; }
        public ICollection<Productostbl> Producto { get; set; }
    }
}
