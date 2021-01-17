using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Vehiculostbl
    {
        public int Id { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de TAG es obligatorio")]
        [StringLength(5, ErrorMessage = "El número es demasiado largo")]
        [Display(Name = "No. Tag")]
        public string Veh_Codigo { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de placa es obligatorio")]
        [StringLength(7, MinimumLength = 7, ErrorMessage = "La placa consta de siete caracteres")]
        [Display(Name = "No. Placa")]
        public string Veh_Placa { get; set; }

        [Display(Name = "Imagen")]
        public string ImageUrl { get; set; }

        [Display(Name = "ESTADO")]
        public Char Veh_Estado { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime Veh_Born { get; set; }

        [Display(Name = "Detalles")]
        public string Veh_Detalles { get; set; }

        //TODO: replace the correct URL for the image
        public string ImageFullPath => string.IsNullOrEmpty(ImageUrl)
            ? null
            : $"https://prados.azurewebsites.net{ImageUrl.Substring(1)}";

        [Display(Name = "Born")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime BornLocal => Veh_Born.ToLocalTime();


        public Propietariostbl Propietario { get; set; }
    }
}
