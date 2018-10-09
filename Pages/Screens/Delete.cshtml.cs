using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using siwp_app.Models;

namespace siwp_app.Pages.Screens
{
    public class DeleteModel : PageModel
    {
        private readonly siwp_app.Models.SiwpContext _context;

        public DeleteModel(siwp_app.Models.SiwpContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Screen Screens { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Screens = await _context.Screens.SingleOrDefaultAsync(m => m.ID == id);

            if (Screens == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Screens = await _context.Screens.FindAsync(id);

            if (Screens != null)
            {
                _context.Screens.Remove(Screens);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
