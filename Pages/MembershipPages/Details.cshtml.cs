using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GitHubPractice.Models;

namespace GitHubPractice.Pages.MembershipPages;

public class DetailsModel : PageModel
{
    private readonly MembershipContext _context;
    public DetailsModel(MembershipContext context)
    {
        _context = context;
    }

    public Membership Membership { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var membership = await _context.Memberships.FirstOrDefaultAsync(m => m.Id == id);
        if (membership is null)
        {
            return NotFound();
        }
        else
        {
            Membership = membership;
        }

        return Page();
    }
}
