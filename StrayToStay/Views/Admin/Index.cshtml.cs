using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StrayToStay.Data;
using StrayToStay.Infrastructure.Interfaces;
using StrayToStay.Models;

namespace StrayToStay.Views.Admin
{
    public class IndexModel : PageModel
    {
        private readonly Interface_RolesService _rolesService;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IndexModel(Interface_RolesService rolesService, ApplicationDbContext context, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _rolesService = rolesService;
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public IActionResult OnGet()
        {
            return Page();
        }
        [BindProperty]
        public IndexModel indexModel { get; set; } = default;
        public string RoleName;
        public async Task<IActionResult> OnPostAsync()
        {
            IdentityRole role = new() { Name = indexModel.RoleName };
            IdentityResult result = await _roleManager.CreateAsync(role);

            return RedirectToPage("./Index");

        }
    }
}
