using Microsoft.AspNetCore.Identity;
using Prados.Web.Data.Entities;
using Prados.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prados.Web.Helpers
{
    public interface IUserHelper
    {
        Task<Userstbl> GetUserByEmailAsync(string email);

        Task<IdentityResult> AddUserAsync(Userstbl user, string password);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(Userstbl user, string roleName);

        Task<bool> IsUserInRoleAsync(Userstbl user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

        Task<bool> DeleteUserAsync(string email);

        Task<IdentityResult> UpdateUserAsync(Userstbl user);

        Task<SignInResult> ValidatePasswordAsync(Userstbl user, string password);
        Task<string> GenerateEmailConfirmationTokenAsync(Userstbl user);

        Task<IdentityResult> ConfirmEmailAsync(Userstbl user, string token);

        Task<Userstbl> GetUserByIdAsync(string userId);

    }
}
