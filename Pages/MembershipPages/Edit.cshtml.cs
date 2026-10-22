using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GitHubPractice.Models;

namespace GitHubPractice.Pages.MembershipPages;

public class EditModel : PageModel
{
    private readonly MembershipContext _context;

    public EditModel(MembershipContext context)
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
        Membership = membership;
        return Page();
    }

    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Attach(Membership).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!MembershipExists(Membership.Id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return RedirectToPage("./Index");
    }

    private bool MembershipExists(int id)
    {
        return _context.Memberships.Any(e => e.Id == id);
    }
}
