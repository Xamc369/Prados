using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data.Entities
{
    public class Userstbl: IdentityUser
    {
        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de lote es obligatorio")]
        [StringLength(3, ErrorMessage = "El lote debe tener solo 3 numeros")]
        [Display(Name = "No. Lote")]
        public string Pro_Lote { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Los nombres deben tener un minimo de 3 caracteres y un maximo de 50")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Solo se permiten mayúsculas")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Los nombres son obligatorios")]
        [Display(Name = "Nombres")]
        public string Pro_Nombres { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Los apellidos deben tener un minimo de 3 caracteres y un maximo de 50")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Los apellidos son obligatorios")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Solo se permiten mayúsculas")]
        [Display(Name = "Apellidos")]
        public string Pro_Apellidos { get; set; }

        [Display(Name = "Observaciones")]
        public string Pro_Observaciones { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Display(Name = "Telefono/Celular")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de telefono es obligatorio")]
        [StringLength(10, MinimumLength = 10,
        ErrorMessage = "El numero de telefono deben tener un minimo de 10 caracteres")]
        public string Pro_Telefono { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El tipo de identificacion es obligatorio")]
        [Display(Name = "Tipo de Identificacion")]
        [StringLength(10, MinimumLength = 3,
        ErrorMessage = "El numero de identificación deben tener un minimo de 3 caracteres y un maximo de 10")]
        public char Pro_TipoIdentificacion { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de identificacion es obligatorio")]
        [StringLength(10, MinimumLength = 3,
        ErrorMessage = "La identificacion deben tener un minimo de 3 caracteres y un maximo de 10")]
        [Display(Name = "Identificacion")]
        public string Pro_Identificacion { get; set; }
        public string NombreCompleto => $"{Pro_Nombres} {Pro_Apellidos}";

        [Display(Name = "Tipo de Persona")]
        public TipoPersonatbl TipPer { get; set; }
        [Display(Name = "Tipo de Vivienda")]
        public TiposViviendatbl TipViv { get; set; }
        [Display(Name = "Tipo de Identificacion")]
        public TipoIdentificaciontbl TipIde { get; set; }
    }
}
