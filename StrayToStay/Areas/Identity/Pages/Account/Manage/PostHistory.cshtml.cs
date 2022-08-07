using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StrayToStay.Data;
using StrayToStay.Models;

namespace StrayToStay.Areas.Identity.Pages.Account.Manage
{
    public class PostHistoryModel : PageModel
    {
        private readonly StrayToStay.Data.ApplicationDbContext _context;

        public PostHistoryModel(StrayToStay.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Post> Post { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Posts != null)
            {
                Post = await _context.Posts.ToListAsync();
            }
        }
    }
}
