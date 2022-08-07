using Microsoft.AspNetCore.Identity;
using StrayToStay.Data;
using StrayToStay.Infrastructure.Interfaces;
using StrayToStay.Models;

namespace StrayToStay.Infrastructure
{
    public class RolesService : Interface_RolesService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public RolesService(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<bool> AddUserToRole(AppUser user, string roleName)
        {
            bool result = (await _userManager.AddToRoleAsync(user, roleName)).Succeeded;
            return result;
        }

        public async Task<bool> RemoveUserFromRole(AppUser user, string roleName)
        {
            bool result = (await _userManager.RemoveFromRoleAsync(user, roleName)).Succeeded;
            return result;
        }

        public async Task<IEnumerable<string>> GetUserRoles(AppUser user)
        {
            IEnumerable<string> result = await _userManager.GetRolesAsync(user);
            return result;
        }
    }
}
