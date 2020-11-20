using Microsoft.AspNetCore.Http;
using Prados.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Models
{
    public class Modelos_noticia
    {
        public List<Negociostbl> Negociostbls { get; set; }
        public List<Noticiastbl> Noticiastbls { get; set; }
}
}
