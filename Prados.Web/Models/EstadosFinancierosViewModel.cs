using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Prados.Web.Data.Entities;

namespace Prados.Web.Models
{
    public class EstadosFinancierosViewModel
    {
        public List<Pagostbl> ingresos { get; set; }
        public List<Egresostbl> egresos { get; set; }
        public List<Aniostbl> anios { get; set; }
        public List<Mesestbl> meses { get; set; }
        public IEnumerable<SelectListItem> Anios1 { get; set; }
        public IEnumerable<SelectListItem> Meses1 { get; set; }

        public EstadosFinancierosViewModel()
        {
            this.Anios1 = new SelectList(new List<string>());
            this.Meses1 = new SelectList(new List<string>() {"Sin Datos"});
        }


        public SelectList AniosList { get; set; }
        public SelectList MesesList { get; set; }

        public List<int> MesSeleccionado { get; set; }
    }
}

