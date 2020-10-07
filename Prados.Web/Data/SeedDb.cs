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
            var manager = await CheckUserAsync("10", "JOHAN", "ALTAMIRANO", "tec_inf_johan@hotmail.com", "GENIAL", "0998759275", 'c', "1723629240", "Admin");
            var customer = await CheckUserAsync("11", "XIMENA", "MORENO", "gohanalexanderdj@hotmail.com", "GENIAL", "0998759275", 'C', "1723629240", "Customer");

            await CheckPropietariosAsync(customer);
            await CheckManagerAsync(manager);
            await CheckModeloAutoAsync();


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





        private async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");

            await _userHelper.CheckRoleAsync("Customer");


        }

        private async Task<Userstbl> CheckUserAsync(string PRO_LOTE, string PRO_NOMBRES,
            string PRO_APELLIDOS, string email, string PRO_OBSERVACIONES, string PRO_TELEFONO, char PRO_TIPOIDENTIFICACION,
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
