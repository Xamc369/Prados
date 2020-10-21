﻿using Microsoft.AspNetCore.Identity;
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
        [StringLength(4, ErrorMessage = "El número es demasiado largo")]
        [Display(Name = "No. Lote")]
        public string Pro_Lote { get; set; }

        //helper
        [Display(Name = "Tipo de Vivienda")]
        public TiposViviendatbl Pro_TipoVivienda { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "Los nombres deben tener un minimo de 3 caracteres y un maximo de 50")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Los nombres son obligatorios")]
        [Display(Name = "Nombres")]
        public string Pro_Nombres { get; set; }

        [StringLength(50, MinimumLength = 3,
        ErrorMessage = "los apellidos deben tener un minimo de 3 caracteres y un maximo de 50")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "los apellidos son obligatorios")]
        [RegularExpression(@"^[a-z]+[a-za-z]*$")]
        [Display(Name = "Apellidos")]
        public string Pro_Apellidos { get; set; }

        [Display(Name = "Observaciones")]
        public string Pro_Observaciones { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Display(Name = "Telefono/Celular")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de telefono es obligatorio")]
        [StringLength(10, MinimumLength = 3,
        ErrorMessage = "El numero de telefono deben tener un minimo de 3 caracteres y un maximo de 50")]
        public string Pro_Telefono { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "El tipo de identificacion es obligatorio")]
        [Display(Name = "Tipo de Identificacion")]
        public char Pro_TipoIdentificacion { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo se permiten números")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número de identificacion es obligatorio")]
        [StringLength(10, MinimumLength = 3,
        ErrorMessage = "La identificacion deben tener un minimo de 3 caracteres y un maximo de 50")]
        [Display(Name = "Identificacion")]
        public string Pro_Identificacion { get; set; }
        public string NombreCompleto => $"{Pro_Nombres} {Pro_Apellidos}";
    }
}