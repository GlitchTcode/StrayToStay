using StrayToStay.Models;

namespace StrayToStay.Infrastructure.Interfaces
{
    public interface Interface_RolesService
    {
        public Task<bool> AddUserToRole(AppUser user, string roleName);
        public Task<bool> RemoveUserFromRole(AppUser user, string roleName);
        public Task<IEnumerable<string>> GetUserRoles(AppUser user);
    }
}
