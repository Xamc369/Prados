using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Valorestbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "VALOR ALICUOTA")]
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El registro es obligatorio")]
        [StringLength(5, ErrorMessage = "El valor debe ser maximo de tres enteros y dos decimales")]
        public string Val_Valor { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        [Display(Name = "FECHA DE CREACION")]
        public DateTime Val_FechaCreacion { get; set; }

        [Display(Name = "ESTADO")]
        public Char Val_Estado { get; set; }

        public ICollection<Pagostbl> Pagos { get; set; }
    }
}
