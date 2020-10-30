using Microsoft.AspNetCore.Http;
using Prados.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Models
{
    public class NegocioViewModel: Negociostbl
    {
        public int PropietarioId { get; set; }

        [Display(Name = "Imagen")]
        public IFormFile ImageFile { get; set; }
    }
}
