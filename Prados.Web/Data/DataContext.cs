using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prados.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data
{
    public class DataContext : IdentityDbContext<Userstbl>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Aniostbl> Aniostbls { get; set; }
        public DbSet<Managerstbl> Managerstbls { get; set; }
        public DbSet<MarcasAutostbl> MarcasAutostbls { get; set; }
        public DbSet<Mesestbl> Mesestbls { get; set; }
        public DbSet<Negociostbl> Negociostbls{ get; set; }
        public DbSet<Pagostbl>  Pagostbls{ get; set; }
        public DbSet<Productostbl>  Productostbls{ get; set; }
        public DbSet<Propietariostbl> Propietariostbls { get; set; }
        public DbSet<PuntosPagotbl> PuntosPagotbls { get; set; }
        public DbSet<TiposViviendatbl> TiposViviendatbls { get; set; }
        public DbSet<Valorestbl> Valorestbls { get; set; }
        public DbSet<Vehiculostbl> Vehiculostbls { get; set; }
        public DbSet<Ingresostbl> Ingresostbls { get; set; }
        public DbSet<Egresostbl> Egresostbls { get; set; }
        public DbSet<Saldostbl> Saldostbls { get; set; }
        public DbSet<Prados.Web.Data.Entities.TiposPagotbl> TiposPagotbl { get; set; }
        public DbSet<TiposPagotbl> TiposPagotbls { get; set; }
        public DbSet<Contabilidadtbl> Contabilidadtbls { get; set; }
        public DbSet<Noticiastbl> Noticiastbls { get; set; }
        public DbSet<TipoIdentificaciontbl> TipoIdentificaciontbls { get; set; }
        public DbSet<TipoPersonatbl> TipoPersonastbls { get; set; }

    }

}

