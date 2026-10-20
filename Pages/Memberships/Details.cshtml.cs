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
    public class DetailsModel : PageModel
    {
        private readonly GitHubPractice.Models.MembershipContext _context;

        public DetailsModel(GitHubPractice.Models.MembershipContext context)
        {
            _context = context;
        }

        public Membership Membership { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membership = await _context.Memberships.FirstOrDefaultAsync(m => m.Id == id);

            if (membership is not null)
            {
                Membership = membership;

                return Page();
            }

            return NotFound();
        }
    }
}
