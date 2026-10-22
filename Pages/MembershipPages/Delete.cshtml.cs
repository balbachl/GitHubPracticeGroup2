using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GitHubPractice.Models;

namespace GitHubPractice.Pages.MembershipPages;

public class DeleteModel : PageModel
{
    private readonly MembershipContext _context;

    public DeleteModel(MembershipContext context)
    {
        _context = context;
    }

    [BindProperty]
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

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var membership = await _context.Memberships.FindAsync(id);
        if (membership != null)
        {
            Membership = membership;
            _context.Memberships.Remove(Membership);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
