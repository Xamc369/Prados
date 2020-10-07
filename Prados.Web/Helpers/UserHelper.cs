using Microsoft.AspNetCore.Identity;
using Prados.Web.Data.Entities;
using Prados.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<Userstbl> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<Userstbl> _signInManager;

        public UserHelper(
            UserManager<Userstbl> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<Userstbl> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        //eliminar un propietario

        public async Task<bool> DeleteUserAsync(string email)
        {
            var user = await GetUserByEmailAsync(email);
            if (user == null)
            {
                return true;
            }

            var response = await _userManager.DeleteAsync(user);
            return response.Succeeded;
        }

        // sing in result para el lgoueo y deslogueo
        public async Task<SignInResult> LoginAsync(LoginViewModel model)
        {
            return await _signInManager.PasswordSignInAsync(
                model.Username,
                model.Password,
                model.RememberMe,
                false);
        }

        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }
        //  las interfaces de agregar o adicionar usuarips
        public async Task<IdentityResult> AddUserAsync(Userstbl user, string password)
        {
            return await _userManager.CreateAsync(user, password);
        }

        public async Task AddUserToRoleAsync(Userstbl user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            bool roleExists = await _roleManager.RoleExistsAsync(roleName);
            if (!roleExists)
            {
                await _roleManager.CreateAsync(new IdentityRole
                {
                    Name = roleName
                });
            }
        }

        public async Task<Userstbl> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);

        }

        public async Task<bool> IsUserInRoleAsync(Userstbl user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }
    }
}
