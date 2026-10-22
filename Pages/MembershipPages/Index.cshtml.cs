using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GitHubPractice.Models;

namespace GitHubPractice.Pages.MembershipPages;

public class IndexModel : PageModel
{
    private readonly MembershipContext _context;

    public IndexModel(MembershipContext context)
    {
        _context = context;
    }

    public IList<Membership> Membership { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Membership = await _context.Memberships.ToListAsync();
    }
}
