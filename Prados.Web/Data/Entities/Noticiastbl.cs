using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Noticiastbl
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "TITULO")]
        public string Not_Titulo { get; set; }

        [Display(Name = "AUTOR")]
        public string Not_Autor { get; set; }

        [Display(Name = "TEXTO")]
        public string Not_Descripcion { get; set; }

        [Display(Name = "FECHA NOTICIA")]
        [DataType(DataType.Date)]
        public DateTime Not_Fecha { get; set; }


        [Display(Name = "FECHA CREACION")]
        [DataType(DataType.Date)]
        public DateTime Not_FechaCreacion { get; set; }

        [Display(Name = "Estado")]
        public char Not_Estado { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

    }
}
