using Prados.Web.Data.Entities;
using Prados.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;
        private readonly IUserHelper _userHelper;

        public SeedDb(
            DataContext context,
            IUserHelper userHelper)
        {
            _dataContext = context;
            _userHelper = userHelper;
        }


        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckRoles();
            var manager = await CheckUserAsync("10", "JOHAN", "ALTAMIRANO", "tec_inf_johan@hotmail.com", "GENIAL", "0998759275", "c", "1723629240", "Admin");
            var customer = await CheckUserAsync("11", "XIMENA", "MORENO", "gohanalexanderdj@hotmail.com", "GENIAL", "0998759275", "C", "1723629240", "Customer");

            await CheckPropietariosAsync(customer);
            await CheckManagerAsync(manager);
            await CheckModeloAutoAsync();
            await CheckMesesAsync();
            await CheckAniosAsync();
            await CheckTipodePagoAsync();
            await CheckTipodePersonaAsync();
            await CheckTipodeViviendaAsync();
            await CheckTipodeIdentificacionAsync();

        }
        private async Task CheckModeloAutoAsync()
        {
            if (!_dataContext.MarcasAutostbls.Any())
            {
                _dataContext.MarcasAutostbls.Add(new MarcasAutostbl { Mar_Descripcion = "Chevrolet" });
                _dataContext.MarcasAutostbls.Add(new MarcasAutostbl { Mar_Descripcion = "BMW" });
                _dataContext.MarcasAutostbls.Add(new MarcasAutostbl { Mar_Descripcion = "Honda" });
                _dataContext.MarcasAutostbls.Add(new MarcasAutostbl { Mar_Descripcion = "ABC" });
                await _dataContext.SaveChangesAsync();

            }
        }

        private async Task CheckMesesAsync()
        {
            if (!_dataContext.Mesestbls.Any())
            {
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "ENERO" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "FEBRERO" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "MARZO" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "ABRIL" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "MAYO" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "JUNIO" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "JULIO" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "AGOSTO" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "SEPTIEMBRE" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "OCTUBRE" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "NOVIEMBRE" });
                _dataContext.Mesestbls.Add(new Mesestbl { Mes_Descripcion = "DICIEMBRE" });
                await _dataContext.SaveChangesAsync();

            }
        }

        private async Task CheckAniosAsync()
        {
            if (!_dataContext.Aniostbls.Any())
            {
                _dataContext.Aniostbls.Add(new Aniostbl { Ani_Descripcion = "2015" });
                _dataContext.Aniostbls.Add(new Aniostbl { Ani_Descripcion = "2016" });
                _dataContext.Aniostbls.Add(new Aniostbl { Ani_Descripcion = "2017" });
                _dataContext.Aniostbls.Add(new Aniostbl { Ani_Descripcion = "2018" });
                _dataContext.Aniostbls.Add(new Aniostbl { Ani_Descripcion = "2019" });
                _dataContext.Aniostbls.Add(new Aniostbl { Ani_Descripcion = "2020" });
                await _dataContext.SaveChangesAsync();

            }
        }

        private async Task CheckTipodePagoAsync()
        {
            if (!_dataContext.TiposPagotbls.Any())
            {
                _dataContext.TiposPagotbls.Add(new TiposPagotbl { Tip_Descripcion = "ALICUOTA" });
                _dataContext.TiposPagotbls.Add(new TiposPagotbl { Tip_Descripcion = "SEDE" });
                _dataContext.TiposPagotbls.Add(new TiposPagotbl { Tip_Descripcion = "TAG" });
                _dataContext.TiposPagotbls.Add(new TiposPagotbl { Tip_Descripcion = "OTROS" });
                await _dataContext.SaveChangesAsync();

            }
        }

        private async Task CheckTipodePersonaAsync()
        {
            if (!_dataContext.TipoPersonastbls.Any())
            {
                _dataContext.TipoPersonastbls.Add(new TipoPersonatbl { TipP_Descripcion = "PROPIETARIO" });
                _dataContext.TipoPersonastbls.Add(new TipoPersonatbl { TipP_Descripcion = "INQUILINO" });
                await _dataContext.SaveChangesAsync();

            }
        }

        private async Task CheckTipodeViviendaAsync()
        {
            if (!_dataContext.TiposViviendatbls.Any())
            {
                _dataContext.TiposViviendatbls.Add(new TiposViviendatbl { TipV_Descripcion = "CASA" });
                _dataContext.TiposViviendatbls.Add(new TiposViviendatbl { TipV_Descripcion = "DEPARTAMENTO" });
                _dataContext.TiposViviendatbls.Add(new TiposViviendatbl { TipV_Descripcion = "LOTE BALDIO" });
                _dataContext.TiposViviendatbls.Add(new TiposViviendatbl { TipV_Descripcion = "LOTE CON CERRAMIENTO" });
                await _dataContext.SaveChangesAsync();

            }
        }

        private async Task CheckTipodeIdentificacionAsync()
        {
            if (!_dataContext.TipoIdentificaciontbls.Any())
            {
                _dataContext.TipoIdentificaciontbls.Add(new TipoIdentificaciontbl { TipI_Descripcion = "CEDULA" });
                _dataContext.TipoIdentificaciontbls.Add(new TipoIdentificaciontbl { TipI_Descripcion = "PASAPORTE" });
                await _dataContext.SaveChangesAsync();

            }
        }


        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");

            await _userHelper.CheckRoleAsync("Customer");


        }

        private async Task<Userstbl> CheckUserAsync(string PRO_LOTE, string PRO_NOMBRES,
            string PRO_APELLIDOS, string email, string PRO_OBSERVACIONES, string PRO_TELEFONO, string PRO_TIPOIDENTIFICACION,
            string PRO_IDENTIFICACION, string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new Userstbl
                {
                    Pro_Lote = PRO_LOTE,
                    Pro_Nombres = PRO_NOMBRES,
                    Pro_Apellidos = PRO_APELLIDOS,
                    Email = email,
                    UserName = email,
                    Pro_Observaciones = PRO_OBSERVACIONES,
                    Pro_Telefono = PRO_TELEFONO,
                    Pro_TipoIdentificacion = PRO_TIPOIDENTIFICACION,
                    Pro_Identificacion = PRO_IDENTIFICACION
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }

            return user;
        }
        private async Task CheckPropietariosAsync(Userstbl user)
        {
            if (!_dataContext.Propietariostbls.Any())
            {
                _dataContext.Propietariostbls.Add(new Propietariostbl { User = user });
                await _dataContext.SaveChangesAsync();
            }
        }

        private async Task CheckManagerAsync(Userstbl user)
        {
            if (!_dataContext.Managerstbls.Any())
            {
                _dataContext.Managerstbls.Add(new Managerstbl { User = user });
                await _dataContext.SaveChangesAsync();
            }
        }

    }
}
