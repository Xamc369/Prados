using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class MarcasAutostbl
    {
        public int Id { get; set; }

        [Display(Name = "Marca Auto")]
        [MaxLength(50, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Mar_Descripcion { get; set; }

        public ICollection<Vehiculostbl> Vehiculos { get; set; }
    }
}
