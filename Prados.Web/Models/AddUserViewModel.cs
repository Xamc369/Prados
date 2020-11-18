using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Models
{
    public class AddUserViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [EmailAddress]
        public string Username { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de lote es obligatorio")]
        [StringLength(3, ErrorMessage = "El lote debe tener solo 3 numeros")]
        [Display(Name = "No. Lote")]
        public string PRO_LOTE { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Los nombres deben tener un minimo de 3 caracteres y un maximo de 50")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Solo se permiten mayúsculas")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Los nombres son obligatorios")]
        [Display(Name = "Nombres")]
        public string PRO_NOMBRES { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Los apellidos deben tener un minimo de 3 caracteres y un maximo de 50")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Los apellidos son obligatorios")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Solo se permiten mayúsculas")]
        [Display(Name = "Apellidos")]
        public string PRO_APELLIDOS { get; set; }

        [Display(Name = "Observaciones")]
        public string PRO_OBSERVACIONES { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Display(Name = "Telefono/Celular")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de telefono es obligatorio")]
        [StringLength(10, MinimumLength = 10,
        ErrorMessage = "El numero de telefono deben tener un minimo de 10 caracteres")]
        public string PRO_TELEFONO { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El tipo de identificacion es obligatorio")]
        [Display(Name = "Tipo de Identificacion")]
        public char PRO_TIPOIDENTIFICACION { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de identificacion es obligatorio")]
        [StringLength(10, MinimumLength = 3,
        ErrorMessage = "La identificacion deben tener un minimo de 3 caracteres y un maximo de 10")]
        [Display(Name = "Identificacion")]
        public string PRO_IDENTIFICACION { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracter.")]
        public string Password { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} debe contener entre {2} y {1} caracter.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Tipo de Vivienda")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un tipo de vivienda.")]
        public int TVId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Tipo de Identificacion")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un tipo de identificacion.")]
        public int TIId { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Tipo de Persona")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes seleccionar un tipo de persona.")]
        public int TPId { get; set; }

        public IEnumerable<SelectListItem> TipoPersonaVM { get; set; }
        public IEnumerable<SelectListItem> TipoViviendaVM { get; set; }
        public IEnumerable<SelectListItem> TipoIdentificacionVM { get; set; }
    }
}
