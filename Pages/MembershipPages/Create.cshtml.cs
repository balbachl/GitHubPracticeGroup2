using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GitHubPractice.Models;

namespace GitHubPractice.Pages.MembershipPages;

public class CreateModel : PageModel
{
    private readonly MembershipContext _context;

    public CreateModel(MembershipContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Membership Membership { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Memberships.Add(Membership);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
