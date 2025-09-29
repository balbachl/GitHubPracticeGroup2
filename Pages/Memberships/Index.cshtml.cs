using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GitHubPractice.Models;

namespace GitHubPractice.Pages.Memberships
{
    public class IndexModel : PageModel
    {
        private readonly GitHubPractice.Models.MembershipContext _context;

        public IndexModel(GitHubPractice.Models.MembershipContext context)
        {
            _context = context;
        }

        public IList<Membership> Membership { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Membership = await _context.Memberships.ToListAsync();
        }
    }
}
